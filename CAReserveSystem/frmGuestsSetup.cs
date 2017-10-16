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
    public partial class frmGuestsSetup : Form
    {
        private static int SelectedGID = 0;
        private static int GIOperation = -1;

        public frmGuestsSetup() 
        {
            InitializeComponent();
        }

        private void GuestRatesTransaction(int t)
        {
            using(G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                if(G.cn != null)
                {
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@rtype", t));
                    G.spArr.Add(new MySqlParameter("@dr0", txtDAdult.Text));
                    G.spArr.Add(new MySqlParameter("@df0", dtpDAFrom.Value));
                    G.spArr.Add(new MySqlParameter("@dt0", dtpDATo.Value));
                    G.spArr.Add(new MySqlParameter("@nr0", txtNAdult.Text));
                    G.spArr.Add(new MySqlParameter("@nf0", dtpNAFrom.Value));
                    G.spArr.Add(new MySqlParameter("@nt0", dtpNATo.Value));
                    G.spArr.Add(new MySqlParameter("@dr1", txtDChild.Text));
                    G.spArr.Add(new MySqlParameter("@df1", dtpDCFrom.Value));
                    G.spArr.Add(new MySqlParameter("@dt1", dtpDCTo.Value));
                    G.spArr.Add(new MySqlParameter("@nr1", txtNChild.Text));
                    G.spArr.Add(new MySqlParameter("@nf1", dtpNCFrom.Value));
                    G.spArr.Add(new MySqlParameter("@nt1", dtpNCTo.Value));
                    G.spArr.Add(new MySqlParameter("@dr2", txtDChild0.Text));
                    G.spArr.Add(new MySqlParameter("@df2", dtpDC0From.Value));
                    G.spArr.Add(new MySqlParameter("@dt2", dtpDC0To.Value));
                    G.spArr.Add(new MySqlParameter("@nr2", txtNChild0.Text));
                    G.spArr.Add(new MySqlParameter("@nf2", dtpNC0From.Value));
                    G.spArr.Add(new MySqlParameter("@nt2", dtpNC0To.Value));
                    G.spArr.Add(new MySqlParameter("@dn0", txtDNA.Text));
                    G.spArr.Add(new MySqlParameter("@dn1", txtDNC.Text));
                    G.spArr.Add(new MySqlParameter("@dn2", txtDNC0.Text));
                    G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));

                    if(t == 0)
                    {
                        G.Qry = "call sp_tranguestrates(@rtype, @dr0, @df0, @dt0, @nr0, @nf0, @nt0, @dr1, @df1, @dt1, @nr1, @nf1, @nt1, @dr2, @df2, @dt2, @nr2, @nf2, @nt2, @dn0, @dn1, @dn2, @cid);";
                        G.AffectedDbRows = MyDb.ExecSQL(G.cn, G.Qry, G.spArr);

                        if(G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " updated guest rates.");
                            MessageBox.Show("Guest entrance rates have been updated successfully.", "Guest Rates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        G.Qry = "call sp_tranguestrates(@rtype, @dr0, @df0, @dt0, @nr0, @nf0, @nt0, @dr1, @df1, @dt1, @nr1, @nf1, @nt1, @dr2, @df2, @dt2, @nr2, @nf2, @nt2, @dn0, @dn1, @dn2, @cid);";
                        G.dt = MyDb.GetResults(G.cn, G.Qry, G.spArr);

                        if(G.dt != null)
                        {
                            foreach(DataRow rw in G.dt.Rows)
                            {
                                if(Convert.ToInt32(rw["id"]) == 1)
                                {
                                    txtDAdult.Text = Convert.ToDecimal(rw["dayrate"].ToString()).ToString("###,##0.00");
                                    dtpDAFrom.Value = Convert.ToDateTime("01/01/1900 " + rw["dfrom"]);
                                    dtpDATo.Value = Convert.ToDateTime("01/01/1900 " + rw["dto"]);
                                    txtNAdult.Text = Convert.ToDecimal(rw["nightrate"].ToString()).ToString("###,##0.00");
                                    dtpNAFrom.Value = Convert.ToDateTime("01/01/1900 " + rw["nfrom"]);
                                    dtpNATo.Value = Convert.ToDateTime("01/01/1900 " + rw["nto"]);
                                    txtDNA.Text = Convert.ToDecimal(rw["daynightrate"].ToString()).ToString("###,##0.00");
                                }

                                if (Convert.ToInt32(rw["id"]) == 2)
                                {
                                    txtDChild.Text = Convert.ToDecimal(rw["dayrate"].ToString()).ToString("###,##0.00");
                                    dtpDCFrom.Value = Convert.ToDateTime("01/01/1900 " + rw["dfrom"]);
                                    dtpDCTo.Value = Convert.ToDateTime("01/01/1900 " + rw["dto"]);
                                    txtNChild.Text = Convert.ToDecimal(rw["nightrate"].ToString()).ToString("###,##0.00");
                                    dtpNCFrom.Value = Convert.ToDateTime("01/01/1900 " + rw["nfrom"]);
                                    dtpNCTo.Value = Convert.ToDateTime("01/01/1900 " + rw["nto"]);
                                    txtDNC.Text = Convert.ToDecimal(rw["daynightrate"].ToString()).ToString("###,##0.00");
                                }

                                if (Convert.ToInt32(rw["id"]) == 3)
                                {
                                    txtDChild0.Text = Convert.ToDecimal(rw["dayrate"].ToString()).ToString("###,##0.00");
                                    dtpDC0From.Value = Convert.ToDateTime("01/01/1900 " + rw["dfrom"]);
                                    dtpDC0To.Value = Convert.ToDateTime("01/01/1900 " + rw["dto"]);
                                    txtNChild0.Text = Convert.ToDecimal(rw["nightrate"].ToString()).ToString("###,##0.00");
                                    dtpNC0From.Value = Convert.ToDateTime("01/01/1900 " + rw["nfrom"]);
                                    dtpNC0To.Value = Convert.ToDateTime("01/01/1900 " + rw["nto"]);
                                    txtDNC0.Text = Convert.ToDecimal(rw["daynightrate"].ToString()).ToString("###,##0.00");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void GuestInformationTransaction(int t)
        {
            using(G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                if (G.cn != null)
                {
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@rtype", t));
                    G.spArr.Add(new MySqlParameter("@sparam", tstGIFind.Text));
                    G.spArr.Add(new MySqlParameter("@gid", SelectedGID));
                    G.spArr.Add(new MySqlParameter("@sid", cmbSal.SelectedIndex));
                    G.spArr.Add(new MySqlParameter("@n1", txtLN.Text));
                    G.spArr.Add(new MySqlParameter("@n2", txtFN.Text));
                    G.spArr.Add(new MySqlParameter("@n3", txtMN.Text));
                    G.spArr.Add(new MySqlParameter("@i1", txtAddr.Text));
                    G.spArr.Add(new MySqlParameter("@i2", txtEml.Text));
                    G.spArr.Add(new MySqlParameter("@i3", txtLand.Text));
                    G.spArr.Add(new MySqlParameter("@i4", "0000000"));
                    G.spArr.Add(new MySqlParameter("@i5", txtMob.Text));
                    G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));

                    G.Qry = "call sp_tranguestinformation(@rtype, @sparam, @gid, @sid, @n1, @n2, @n3, @i1, @i2, @i3, @i4, @i5, @cid);";

                    if (t == 0 || t == 1 || t == 2)
                    {
                        G.AffectedDbRows = MyDb.ExecSQL(G.cn, G.Qry, G.spArr);

                        if (t == 0 && G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " has added a new guest information " + cmbSal.Text + " " + txtFN.Text + " " + txtLN.Text);
                            MessageBox.Show("New guest information has been added successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (t == 1 && G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " has updated guest information " + cmbSal.Text + " " + txtFN.Text + " " + txtLN.Text);
                            MessageBox.Show("Guest information has been updated successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (t == 2 && G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " has deleted guest information " + cmbSal.Text + " " + txtFN.Text + " " + txtLN.Text);
                            MessageBox.Show("Guest information has been removed successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Logging.Activity("Problem in adding/updating/deleting guest information for " + cmbSal.Text + " " + txtFN.Text + " " + txtLN.Text);
                            MessageBox.Show("Failed to add/update/delete guest information. Please call your system administrator for support.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else if(t == 3)
                    {
                        G.dt = MyDb.GetResults(G.cn, G.Qry, G.spArr);
                        if(G.dt != null)
                        {
                            foreach(DataRow rw in G.dt.Rows)
                            {
                                cmbSal.SelectedIndex = Convert.ToInt32(rw["salutation"]);
                                txtLN.Text = rw["lastname"].ToString();
                                txtFN.Text = rw["firstname"].ToString();
                                txtMN.Text = rw["middlename"].ToString();
                                txtAddr.Text = rw["address"].ToString();
                                txtEml.Text = rw["email"].ToString();
                                txtLand.Text = rw["landline"].ToString();
                                txtMob.Text = rw["mobile"].ToString();
                            }
                        }
                    }
                    else if(t == 4 || t == 5)
                    {
                        G.dt = MyDb.GetResults(G.cn, G.Qry, G.spArr);
                        dgvGI.AutoGenerateColumns = false;
                        dgvGI.DataSource = G.dt;
                    }
                    else
                    {
                        // Nothing to do here.
                    }
                }
                else
                {
                    MessageBox.Show("Unable to connect to server. Please contact your system administrator.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmGuestsSetup_Load(object sender, EventArgs e)
        {
            //tcContainer.TabPages.Remove(tpGuestsInfo);
            GuestInformationTransaction(4);
            GuestRatesTransaction(1);
        }

        private void tsbGIAdd_Click(object sender, EventArgs e)
        {
            GIOperation = 0;
            tsbGIAdd.Visible = false;
            tsbGIEdit.Visible = false;
            tsbGISave.Visible = true;
            tsbGICancel.Visible = true;
        }

        private void tsbGIEdit_Click(object sender, EventArgs e)
        {
            GIOperation = 1;
            tsbGIAdd.Visible = false;
            tsbGIEdit.Visible = false;
            tsbGISave.Visible = true;
            tsbGICancel.Visible = true;
        }

        private void tsbGISave_Click(object sender, EventArgs e)
        {
            if(cmbSal.SelectedIndex < 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save/update guest information without selecting a proper salutation.");
                MessageBox.Show("Failed to save guest information due to salutation is not defined or selection is invalid. Please select one then try again.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(txtFN.Text.Trim().Length == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save/update guest information without entering the guest's First Name.");
                MessageBox.Show("Failed to save guest information due to guests's First Name is invalid and/or null. Please enter a valid entry.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtLN.Text.Trim().Length == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save/update guest information without entering the guest's Last Name.");
                MessageBox.Show("Failed to save guest information due to guests's Last Name is invalid and/or null. Please enter a valid entry.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtAddr.Text.Trim().Length == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save/update guest information without entering the guest's Address.");
                MessageBox.Show("Failed to save guest information due to guests's Address is invalid and/or null. Please enter a valid entry.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtEml.Text.Trim().Length == 0 && txtLand.Text.Trim().Length == 0 && txtMob.Text.Trim().Length == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save/update guest information without entering at least 1 of the guest's contact details.");
                MessageBox.Show("Failed to save guest information due to guests's Email Address and/or Landline number and/or Mobile Number is invalid and/or null. Please enter a valid entry.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(GIOperation == 0 && MessageBox.Show("Proceed in adding new guest information?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GuestInformationTransaction(0);
                GuestInformationTransaction(4);
            }
            else if(GIOperation == 1 && MessageBox.Show("Proceed in updating guest information?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GuestInformationTransaction(1);
                GuestInformationTransaction(4);
            }
            else
            { 
                //Nothing to do here. 
            }

        }

        private void tsbGICancel_Click(object sender, EventArgs e)
        {
            cmbSal.SelectedIndex = 0;
            foreach(var t in pnlGIData.Controls.OfType<TextBox>())
            {
                t.Text = "";
            }
            GIOperation = -1;
            tsbGIAdd.Visible = true;
            tsbGIEdit.Visible = false;
            tsbGISave.Visible = false;
            tsbGICancel.Visible = false;
        }

        private void tsbGIFind_Click(object sender, EventArgs e)
        {
            GuestInformationTransaction(5);
        }

        private void tstGIFind_KeyDown(object sender, KeyEventArgs e)
        {
            GuestInformationTransaction(5);
        }

        private void dgvGI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                SelectedGID = Convert.ToInt32(dgvGI[2, e.RowIndex].Value);
                tsbGIAdd.Visible = false;
                tsbGIEdit.Visible = true;
                tsbGISave.Visible = false;
                tsbGICancel.Visible = true;
                GuestInformationTransaction(3);
            }
            else if(e.ColumnIndex == 1)
            {
                if(MessageBox.Show("Are you sure you want to remove Guest " + dgvGI[3, e.RowIndex].Value.ToString() + " from the list?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SelectedGID = Convert.ToInt32(dgvGI[2, e.RowIndex].Value);
                    GuestInformationTransaction(2);
                }
            }
            else
            {
                // Nothing to do here.
            }
        }

        private void dgvGI_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvGI.Columns[2].DataPropertyName = "id";
            dgvGI.Columns[3].DataPropertyName = "gname";
        }

        private void tsbGRSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Save changes to guest rates?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GuestRatesTransaction(0);
                    GuestRatesTransaction(1);
                }
            }
            catch (Exception ex)
            {
                Logging.Activity("User " + G.CurrentUserName + " encountered an error while saving guest rates : " + ex.Message);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbGRCancel_Click(object sender, EventArgs e)
        {
            foreach(var t in pnlGRData.Controls.OfType<TextBox>()) { t.Clear(); t.Text = "0.00"; }
            foreach(var d in pnlGRData.Controls.OfType<DateTimePicker>()) { d.Value = Convert.ToDateTime("01/01/1900 00:00:00"); }
        }

        private void dtpDATo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
