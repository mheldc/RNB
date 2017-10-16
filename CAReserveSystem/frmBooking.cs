using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BNRLibrary;

namespace CAReserveSystem
{
    public partial class frmBooking : Form
    {

        public frmBooking()
        {
            InitializeComponent();
        }

        private void LoadActiveBookings()
        {
            using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                G.spArr = new ArrayList();
                G.spArr.Add(new MySqlParameter("@sp", tstFind.Text));
                G.dt = MyDb.GetResults(G.cn, "call sp_getactivebookings(@sp);", G.spArr);
                dgvBooking.AutoGenerateColumns = false;
                dgvBooking.DataSource = G.dt;

                lblABCount.Text = dgvBooking.Rows.Count.ToString("###,##0");
            }
        }

        private Int32 GetUnpaidGuests(Int32 bid)
        {
            Int32 unpaidguest = 0;
            using(G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                G.spArr = new ArrayList();
                G.spArr.Add(new MySqlParameter("@bid", bid));
                G.dt = MyDb.GetResults(G.cn, "call sp_getunpaidguest(@bid);", G.spArr);
                if(G.dt != null)
                {
                    if(G.dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in G.dt.Rows)
                        {
                            unpaidguest = Convert.ToInt32(rw["itemqty"]);
                        }
                    }
                }
            }
            return unpaidguest;
        }

        private void UpdateQueueBoard(Int32 bid, int utype)
        {
            using(MySqlConnection cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {

                G.spArr = new ArrayList();
                G.spArr.Add(new MySqlParameter("@bid", bid));
                G.spArr.Add(new MySqlParameter("@u", utype));

                G.AffectedDbRows = MyDb.ExecSQL(cn, "call sp_updatequeueboard(@bid, @u)", G.spArr);

                if (utype == 0 && G.AffectedDbRows > 0)
                {
                    MessageBox.Show("Guest is now on Queue.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (utype == 1 && G.AffectedDbRows > 0)
                {
                    MessageBox.Show("Guest has been served successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Problem in serving guest or putting guest on queue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void dgvBooking_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (G.dt != null)
            {
                dgvBooking.AutoGenerateColumns = false;
                dgvBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvBooking.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                foreach(DataGridViewRow rw in dgvBooking.Rows)
                {
                    if (Convert.ToBoolean(rw.Cells[7].Value) == false) { rw.Cells[6].Value = imlBooking.Images[0]; }
                    if (Convert.ToBoolean(rw.Cells[14].Value) == true && Convert.ToBoolean(rw.Cells[15].Value) == true ) { rw.Cells[13].Value = imlBooking.Images[1]; }
                    if (Convert.ToBoolean(rw.Cells[14].Value) == false && Convert.ToBoolean(rw.Cells[15].Value) == true) { rw.Cells[13].Value = imlBooking.Images[2]; }

                    //if (Convert.ToInt32(rw.Cells[12].Value) == 0 || Convert.ToBoolean(rw.Cells[7].Value) == true) { rw.Cells[11].Value = imlBooking.Images[0]; }
                }
            }
        }

        private void dgvBooking_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dgvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(Convert.ToString(dgvBooking[0, e.RowIndex].Value));
            //return;
            switch (e.ColumnIndex)
            {
                case 4: // Check Out

                        if(Convert.ToBoolean(dgvBooking[7, e.RowIndex].Value) == true)
                        {
                            MessageBox.Show("Unable to process guest checkout.\n There are still items that needs to be settled first. \n Once unpaid transactions are settled try check out again.", "Unsettled Payments", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            if(MessageBox.Show("Confirm guest checkout, proceed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if(MessageBox.Show("Check all guest accountabilities first before checking out. Once confirmed click Yes.", "Accountabilities",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    using(G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                                    {
                                        if(G.cn != null)
                                        {
                                            G.spArr = new ArrayList();
                                            G.spArr.Add(new MySqlParameter("@bid", Convert.ToInt32(dgvBooking[0, e.RowIndex].Value)));
                                            G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));
                                            G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_checkout(@bid, @cid);", G.spArr);

                                            if(G.AffectedDbRows > 0)
                                            {
                                                MessageBox.Show("Guest " + Convert.ToString(dgvBooking[1, e.RowIndex].Value) + " checked out successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                LoadActiveBookings();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    break;

                case 6: // Payment
                    if(Convert.ToBoolean(dgvBooking[7, e.RowIndex].Value) == true)
                    {
                        G.SelectedBID = Convert.ToInt32(dgvBooking[0, e.RowIndex].Value);
                        frmBPayment f = new frmBPayment();
                        f.ShowDialog();
                        LoadActiveBookings();
                    }
                    else
                    {
                        MessageBox.Show("There are no items due for payment for guest " + dgvBooking[1, e.RowIndex].Value.ToString() + ".", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    break;

                case 8: // Additional Guests
                    G.SelectedBID = Convert.ToInt32(dgvBooking[0, e.RowIndex].Value);
                    frmBAddtionalGuest ba = new frmBAddtionalGuest();
                    ba.ShowDialog();
                    LoadActiveBookings();
                    break;

                case 9: // Transfer Accommodation
                    G.SelectedBID = Convert.ToInt32(dgvBooking[0, e.RowIndex].Value);
                    frmBTransferAccommodation ta = new frmBTransferAccommodation();
                    ta.ShowDialog();
                    LoadActiveBookings();
                    break;

                case 10: // Guest Request/Items
                    G.SelectedBID = Convert.ToInt32(dgvBooking[0, e.RowIndex].Value);
                    frmBRequestItems ri = new frmBRequestItems();
                    ri.ShowDialog();
                    LoadActiveBookings();
                    break;

                case 11: // Pass Issuance
                    if(GetUnpaidGuests(Convert.ToInt32(dgvBooking[0, e.RowIndex].Value)) > 0){
                        MessageBox.Show("Unable to issue passes for guest " + dgvBooking[1, e.RowIndex].Value.ToString() + " Please pay passes fee to the cashier first then try again.", "Pass Issuance Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        if(Convert.ToInt32(dgvBooking[12, e.RowIndex].Value) > 0)
                        {

                            G.SelectedBID = Convert.ToInt32(dgvBooking[0, e.RowIndex].Value);
                            G.PassToIssue = Convert.ToInt32(dgvBooking[12, e.RowIndex].Value);
                            frmBPassIssuance f = new frmBPassIssuance();
                            f.ShowDialog();
                            LoadActiveBookings();
                        }
                        else
                        {
                            MessageBox.Show("There are no passes to issue to guest " + dgvBooking[1, e.RowIndex].Value.ToString() + ". \n (1) Add guests first. \n (2) Settle Payment. \n (3) Issue passes.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }

                    break;

                case 13:
                    if (Convert.ToBoolean(dgvBooking[7, e.RowIndex].Value) == true)
                    {
                        MessageBox.Show("Unable to put guest " + dgvBooking[1, e.RowIndex].Value.ToString() + " on queue due to pending items for payment. Please settle first then try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        LoadActiveBookings();
                    }
                    else
                    {
                        G.SelectedBID = Convert.ToInt32(dgvBooking[0, e.RowIndex].Value);
                        if (Convert.ToBoolean(dgvBooking[14, e.RowIndex].Value) == false && Convert.ToBoolean(dgvBooking[15, e.RowIndex].Value) == false)
                        {
                            if (MessageBox.Show("Put guest " + dgvBooking[1, e.RowIndex].Value.ToString() + " on queue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                UpdateQueueBoard(G.SelectedBID, 0);
                                LoadActiveBookings();
                            }
                        }
                        else if (Convert.ToBoolean(dgvBooking[14, e.RowIndex].Value) == false && Convert.ToBoolean(dgvBooking[15, e.RowIndex].Value) == true)
                        {
                            if (MessageBox.Show("Tag guest " + dgvBooking[1, e.RowIndex].Value.ToString() + " as served?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                UpdateQueueBoard(G.SelectedBID, 1);
                                LoadActiveBookings();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Guest has been served already.", "Served", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    break;

                default: break;
            }
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            LoadActiveBookings();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            frmBookingNew f = new frmBookingNew();
            f.ShowDialog();
            LoadActiveBookings();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            LoadActiveBookings();
        }

        private void tsbFind_Click(object sender, EventArgs e)
        {
            LoadActiveBookings();
        }

        private void tstFind_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoadActiveBookings();
            }
        }
    }
}
