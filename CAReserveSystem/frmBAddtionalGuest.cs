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
    public partial class frmBAddtionalGuest : Form
    {
        Int32 Capacity = 0;
        Int32 RoomId = 0;
        Int32 GuestCount = 0;

        public frmBAddtionalGuest()
        {
            InitializeComponent();
        }

        private void LoadEntryRates()
        {
            using(G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {

                G.dt = MyDb.GetResults(G.cn, "call sp_getentryfee();");
                if(G.dt != null)
                {
                    if(G.dt.Rows.Count > 0)
                    {
                        foreach(DataRow rw in G.dt.Rows)
                        {
                            if(Convert.ToInt32(rw["rateid"].ToString()) == 1) { txtEFAdult.Text = Convert.ToDecimal(rw["rate"]).ToString("###,##0.00"); }
                            if (Convert.ToInt32(rw["rateid"].ToString()) == 2) { txtEFChild0.Text = Convert.ToDecimal(rw["rate"]).ToString("###,##0.00"); }
                            if (Convert.ToInt32(rw["rateid"].ToString()) == 3) { txtEFChild1.Text = Convert.ToDecimal(rw["rate"]).ToString("###,##0.00"); }
                            lblAppRate1.Text = rw["appliedrate"].ToString();
                        }
                    }
                }
            }
        }

        private void LoadAccommodationInfo(Int32 rid)
        {
            using(G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                G.spArr = new ArrayList();
                G.spArr.Add(new MySqlParameter("@rid", rid));
                G.dt = MyDb.GetResults(G.cn, "call sp_getaccommodationinfo(@rid);", G.spArr);

                if(G.dt != null)
                {
                    foreach(DataRow rw in G.dt.Rows) { Capacity = Convert.ToInt32(rw["capacity"]); }
                }
            }
        }

        private void frmBAddtionalGuest_Load(object sender, EventArgs e)
        {
            using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                G.spArr = new ArrayList();
                G.spArr.Add(new MySqlParameter("@bid", G.SelectedBID));
                G.dt = MyDb.GetResults(G.cn, "call sp_getbookinginfo(@bid);", G.spArr);

                if (G.dt != null)
                {
                    foreach (DataRow rw in G.dt.Rows)
                    {
                        txtGuestName.Text = rw["guestname"].ToString();
                        txtAcc.Text = rw["room"].ToString();
                        RoomId = Convert.ToInt32(rw["rid"]);
                        GuestCount = Convert.ToInt32(rw["gcount"]);
                        Logging.Activity("Loading payment information for guest " + txtGuestName.Text + ".");
                    }
                    G.dt = null;
                }
            }
            LoadAccommodationInfo(RoomId);
            LoadEntryRates();
        }

        private void txtQAdult_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                decimal rate = Convert.ToDecimal(txtEFAdult.Text);
                decimal ptype = 0;
                decimal subtotal = 0;

                try
                {
                    ptype = Decimal.Parse(txtQAdult.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid number entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQAdult.Text = "0.00";
                }
                finally
                {
                    subtotal = ptype * rate;
                    txtSTAdult.Text = subtotal.ToString("###,##0.00");
                }
            }
        }

        private void txtQAdult_LostFocus(object sender, EventArgs e)
        {
            decimal rate = Convert.ToDecimal(txtEFAdult.Text);
            decimal ptype = 0;
            decimal subtotal = 0;

            try
            {
                ptype = Decimal.Parse(txtQAdult.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid number entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQAdult.Text = "0.00";
            }
            finally
            {
                subtotal = ptype * rate;
                txtSTAdult.Text = subtotal.ToString("###,##0.00");
            }
        }

        private void txtQChild0_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal rate = Convert.ToDecimal(txtEFChild0.Text);
                decimal ptype = 0;
                decimal subtotal = 0;

                try
                {
                    ptype = Decimal.Parse(txtQChild0.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid number entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQChild0.Text = "0.00";
                    ptype = 0;
                }
                finally
                {
                    subtotal = ptype * rate;
                    txtSTChild0.Text = subtotal.ToString("###,##0.00");
                }
            }
        }

        private void txtQChild0_LostFocus(object sender, EventArgs e)
        {
            decimal rate = Convert.ToDecimal(txtEFChild0.Text);
            decimal ptype = 0;
            decimal subtotal = 0;

            try
            {
                ptype = Decimal.Parse(txtQChild0.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid number entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQChild0.Text = "0.00";
                ptype = 0;
            }
            finally
            {
                subtotal = ptype * rate;
                txtSTChild0.Text = subtotal.ToString("###,##0.00");
            }
        }

        private void txtQChild1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal rate = Decimal.Parse(txtEFChild1.Text);
                decimal ptype = 0;
                decimal subtotal = 0;

                try
                {
                    ptype = Decimal.Parse(txtQChild1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid number entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQChild1.Text = "0.00";
                    ptype = 0;
                }
                finally
                {
                    subtotal = ptype * rate;
                    txtSTChild1.Text = subtotal.ToString("###,##0.00");
                }
            }
        }

        private void txtQChild1_LostFocus(object sender, EventArgs e)
        {
            decimal rate = Decimal.Parse(txtEFChild1.Text);
            decimal ptype = 0;
            decimal subtotal = 0;

            try
            {
                ptype = Decimal.Parse(txtQChild1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid number entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQChild1.Text = "0.00";
                ptype = 0;
            }
            finally
            {
                subtotal = ptype * rate;
                txtSTChild1.Text = subtotal.ToString("###,##0.00");
            }
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            try { Int32.Parse(txtQAdult.Text); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }

            try { Int32.Parse(txtQChild0.Text); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }

            try { Int32.Parse(txtQChild1.Text); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }

            if(txtQAdult.Text == "0" && txtQChild0.Text == "0" && txtQChild1.Text == "0")
            {
                MessageBox.Show("Please provide at least one (1) guest to add in any of the category provided, then try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            //if((GuestCount + Convert.ToInt32(txtQAdult.Text) + Convert.ToInt32(txtQChild0.Text) + Convert.ToInt32(txtQChild1.Text)) > Capacity)
            //{
            //    MessageBox.Show("Maximum capacity reached for selected accommodation. Unable to add more guest. Suggest guest to upgrade or book another accommodation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return;
            //}
            //else
            //{
            //    MessageBox.Show("You can still add " + (Capacity - GuestCount).ToString() + " guest(s) to this accommodation.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    if ((GuestCount + Convert.ToInt32(txtQAdult.Text) + Convert.ToInt32(txtQChild0.Text) + Convert.ToInt32(txtQChild1.Text)) > Capacity)
            //    {
            //        MessageBox.Show("Maximum capacity reached for selected accommodation. Unable to add more guest. Suggest guest to upgrade or book another accommodation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        return;
            //    }
            //}

            if ((GuestCount + Convert.ToInt32(txtQAdult.Text) + Convert.ToInt32(txtQChild0.Text) + Convert.ToInt32(txtQChild1.Text)) > Capacity
                && MessageBox.Show("Maximum capacity reached for selected accommodation. Suggest guest to upgrade accommodation or book for a separate accommodation otherwise proceed adding guest?","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (MessageBox.Show("Add guest to current booking?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int records_affected = 0;

                using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                {                  
                    G.spArr = new ArrayList();

                    if (Convert.ToInt32(txtQAdult.Text) > 0)
                    {
                        G.spArr = new ArrayList();
                        G.spArr.Add(new MySqlParameter("@bid", G.SelectedBID));
                        G.spArr.Add(new MySqlParameter("@typeid", 1));
                        G.spArr.Add(new MySqlParameter("@itype", 2));
                        G.spArr.Add(new MySqlParameter("@idesc", "Entrance Fee (Adult)"));
                        G.spArr.Add(new MySqlParameter("@iqty", txtQAdult.Text));
                        G.spArr.Add(new MySqlParameter("@iamt", Convert.ToDouble(txtQAdult.Text) * Convert.ToDouble(txtEFAdult.Text)));
                        G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));
                        G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_tranbookingitems(@bid, @typeid, @itype, @idesc, @iqty, @iamt, @cid);", G.spArr);
                        records_affected += G.AffectedDbRows;
                    }

                    if (Convert.ToInt32(txtQChild0.Text) > 0)
                    {
                        G.spArr = new ArrayList();
                        G.spArr.Add(new MySqlParameter("@bid", G.SelectedBID));
                        G.spArr.Add(new MySqlParameter("@typeid", 2));
                        G.spArr.Add(new MySqlParameter("@itype", 2));
                        G.spArr.Add(new MySqlParameter("@idesc", "Entrance Fee (Senior Citizen / PWD)"));
                        G.spArr.Add(new MySqlParameter("@iqty", txtQChild0.Text));
                        G.spArr.Add(new MySqlParameter("@iamt", Convert.ToDouble(txtQChild0.Text) * Convert.ToDouble(txtEFChild0.Text)));
                        G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));
                        G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_tranbookingitems(@bid, @typeid, @itype, @idesc, @iqty, @iamt, @cid);", G.spArr);
                        records_affected += G.AffectedDbRows;
                    }

                    if (Convert.ToInt32(txtQChild1.Text) > 0)
                    {
                        G.spArr = new ArrayList();
                        G.spArr.Add(new MySqlParameter("@bid", G.SelectedBID));
                        G.spArr.Add(new MySqlParameter("@typeid", 3));
                        G.spArr.Add(new MySqlParameter("@itype", 2));
                        G.spArr.Add(new MySqlParameter("@idesc", "Entrance Fee (Children below 4ft)"));
                        G.spArr.Add(new MySqlParameter("@iqty", txtQChild1.Text));
                        G.spArr.Add(new MySqlParameter("@iamt", Convert.ToDouble(txtQChild1.Text) * Convert.ToDouble(txtEFChild1.Text)));
                        G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));
                        G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_tranbookingitems(@bid, @typeid, @itype, @idesc, @iqty, @iamt, @cid);", G.spArr);
                        records_affected += G.AffectedDbRows;
                    }

                    if(records_affected > 0)
                    {
                        MessageBox.Show("New guests have been added to booking. Please proceed to payment and issue pass.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed tp add new guest from current booking. Please contact your system administrator for support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }
    }
}
