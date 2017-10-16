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
    public partial class frmBookingNew : Form
    {
        public frmBookingNew()
        {
            InitializeComponent();
        }

        private void tsbGuestLookup_Click(object sender, EventArgs e)
        {
            frmBookingGuestLookup f = new frmBookingGuestLookup();
            f.ShowDialog();
            DisplayGuestInfo();
        }

        private void frmBookingNew_Load(object sender, EventArgs e)
        {
            using(G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                MyDb.LoadDataToComboBox(cmbAccType, "rtid", "rtdesc", "call sp_getaccommodationtypes();", G.cn);
            }
            cmbBookingType.SelectedIndex = 0;
            cmbGSalutation.SelectedIndex = 0;
        }

        private void frmBookingNew_GotFocus(object sender, EventArgs e)
        {
            MessageBox.Show("You got me.");
        }

        private void frmBookingNew_FormClosed(object sender, FormClosedEventArgs e)
        {
            G.GuestInfo = null;
        }

        private void btnClearGF_Click(object sender, EventArgs e)
        {
            cmbGSalutation.SelectedIndex = 0;
            txtGLName.Clear();
            txtGFName.Clear();
            txtGMName.Clear();
            txtGAddr.Clear();
            txtGLand.Clear();
            txtGMobile.Clear();
            txtGEmail.Clear();

            cmbGSalutation.Enabled = true;
            txtGLName.Enabled = true;
            txtGFName.Enabled = true;
            txtGMName.Enabled = true;
            txtGAddr.Enabled = true;
            txtGLand.Enabled = true;
            txtGMobile.Enabled = true;
            txtGEmail.Enabled = true;

            cmbGSalutation.Focus();
            G.GuestInfo = null;
            G.SelectedGID = 0;

        }

        public void DisplayGuestInfo()
        {
            G.GuestInfo = new DataTable();
            using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                G.spArr = new ArrayList();
                G.spArr.Add(new MySqlParameter("@gid", G.SelectedGID));
                G.spArr.Add(new MySqlParameter("@searchparam", ""));

                G.GuestInfo = MyDb.GetResults(G.cn, "call sp_getregisteredguests(@gid, @searchparam);", G.spArr);

            }

            if (G.GuestInfo != null)
            {
                foreach (DataRow rw in G.GuestInfo.Rows)
                {
                    G.SelectedGID = Convert.ToInt16(rw["id"]);
                    cmbGSalutation.SelectedIndex = Convert.ToInt16(rw["salutation"]);
                    txtGLName.Text = Convert.ToString(rw["lastname"]);
                    txtGFName.Text = Convert.ToString(rw["firstname"]);
                    txtGMName.Text = Convert.ToString(rw["middlename"]);
                    txtGAddr.Text = Convert.ToString(rw["address"]);
                    txtGLand.Text = Convert.ToString(rw["landline"]);
                    txtGMobile.Text = Convert.ToString(rw["mobile"]);
                    txtGEmail.Text = Convert.ToString(rw["email"]);

                    cmbGSalutation.Enabled = false;
                    txtGLName.Enabled = false;
                    txtGFName.Enabled = false;
                    txtGMName.Enabled = false;
                    txtGAddr.Enabled = false;
                    txtGLand.Enabled = false;
                    txtGMobile.Enabled = false;
                    txtGEmail.Enabled = false;
                }
            }
        }

        private void cmbAccType_SelectedValueChanged(object sender, EventArgs e)
        {
            using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                G.spArr = new ArrayList();
                G.spArr.Add(new MySqlParameter("@rtid", Convert.ToInt32(cmbAccType.SelectedValue)));
                MyDb.LoadDataToComboBox(cmbAcc, "rid", "rdesc", "call sp_getaccommodations(@rtid);", G.cn, G.spArr);
                cmbAccRate.SelectedIndex = -1;
                txtAccRate.Text = "0.00";
                txtAccCap.Text = "0";
                dtpUsageFrom.Value = Convert.ToDateTime("1900-01-01 00:00:00");
                dtpUsageTo.Value = Convert.ToDateTime("1900-01-01 00:00:00");
            }
        }

        private void cmbAcc_SelectedValueChanged(object sender, EventArgs e)
        {
            using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                G.spArr = new ArrayList();
                G.spArr.Add(new MySqlParameter("@rid", Convert.ToInt32(cmbAcc.SelectedValue)));
                G.dt = MyDb.GetResults(G.cn, "call sp_getaccommodationinfo(@rid);", G.spArr);

                if (G.dt != null)
                {
                    foreach (DataRow rw in G.dt.Rows)
                    {
                        cmbAccRate.SelectedIndex = Convert.ToInt16(rw["ratebasis"]);
                        txtAccRate.Text = Convert.ToDecimal(rw["rate"]).ToString("###,###,##0.00");
                        txtAccCap.Text = Convert.ToInt32(rw["capacity"]).ToString();
                        dtpUsageFrom.Value = Convert.ToDateTime(rw["timefrom"]);
                        dtpUsageTo.Value = Convert.ToDateTime(rw["timeto"]);
                    }
                }
            }
        }

        private void tsbSaveBooking_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbAccType.SelectedValue) == 0 || Convert.ToInt32(cmbAcc.SelectedValue) == 0)
            {
                MessageBox.Show("Unable to process/register new booking. Invalid or No accommodation has been selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            try { Int16.Parse(txtGCAdult.Text); }
            catch (Exception)
            {
                MessageBox.Show("Unable to process/register new booking. Invalid guest count (Adult) supplied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtGCAdult.Focus();
                return;
            }

            try { Int16.Parse(txtGCChild4up.Text); }
            catch (Exception)
            {
                MessageBox.Show("Unable to process/register new booking. Invalid guest count (Child) supplied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtGCChild4up.Focus();
                return;
            }

            try { Int16.Parse(txtGCChild4below.Text); }
            catch (Exception)
            {
                MessageBox.Show("Unable to process/register new booking. Invalid guest count (Child) supplied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtGCChild4below.Focus();
                return;
            }

            if(G.SelectedGID == 0)
            {
                if (txtGLName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Unable to process/register new booking. Guest Last Name is a mandatory field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtGLName.Focus();
                    return;
                }

                if (txtGFName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Unable to process/register new booking. Guest First Name is a mandatory field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtGLName.Focus();
                    return;
                }

                if (txtGAddr.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Unable to process/register new booking. Guest Address is a mandatory field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtGAddr.Focus();
                    return;
                }

                if (txtGLand.Text.Trim().Length == 0 &&  txtGMobile.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Unable to process/register new booking. At least one (1) contact information is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtGLand.Focus();
                    return;
                }
            }

            Int32 AdultCount = Convert.ToInt32(txtGCAdult.Text);
            Int32 Child0Count = Convert.ToInt32(txtGCChild4below.Text);
            Int32 Child1Count = Convert.ToInt32(txtGCChild4up.Text);
            Int32 AccomCap = Convert.ToInt32(txtAccCap.Text);

            //if((AdultCount + Child0Count + Child1Count) > AccomCap)
            //{
            //    MessageBox.Show("Unable to process booking. Number of guest supplied is greater than the capacity of the selected accommodation. Please select a much larger accommodation for the number of guests.", "Over booking", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return;
            //}

            if ((AdultCount + Child0Count + Child1Count) > AccomCap
                && MessageBox.Show("Number of guests supplied is greated than the capacity of the selected accommodation. Suggest to acquire/book on a much larger accommodation or proceed on creating this booking?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (MessageBox.Show("Proceed registering new booking for guest " + cmbGSalutation.Text + " " + txtGFName.Text + " " + txtGLName.Text + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                {
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@bktype", cmbBookingType.SelectedIndex));
                    G.spArr.Add(new MySqlParameter("@rsid", Convert.ToInt32(0)));
                    G.spArr.Add(new MySqlParameter("@gid", G.SelectedGID));
                    G.spArr.Add(new MySqlParameter("@rtid", Convert.ToInt32(cmbAccType.SelectedValue.ToString())));
                    G.spArr.Add(new MySqlParameter("@rid", Convert.ToInt32(cmbAcc.SelectedValue.ToString())));

                    G.spArr.Add(new MySqlParameter("@rrate", Convert.ToDouble(txtAccRate.Text)));
                    G.spArr.Add(new MySqlParameter("@ga", Convert.ToInt16(txtGCAdult.Text)));
                    G.spArr.Add(new MySqlParameter("@gc", Convert.ToInt16(txtGCChild4up.Text)));
                    G.spArr.Add(new MySqlParameter("@gc0", Convert.ToInt16(txtGCChild4below.Text)));
                    G.spArr.Add(new MySqlParameter("@isovn", Convert.ToInt16(cmbAccRate.SelectedIndex)));

                    G.spArr.Add(new MySqlParameter("@g0", Convert.ToInt16(cmbGSalutation.SelectedIndex)));
                    G.spArr.Add(new MySqlParameter("@g1", txtGLName.Text));
                    G.spArr.Add(new MySqlParameter("@g2", txtGFName.Text));
                    G.spArr.Add(new MySqlParameter("@g3", txtGMName.Text));
                    G.spArr.Add(new MySqlParameter("@g4", txtGAddr.Text));

                    G.spArr.Add(new MySqlParameter("@g5", txtGEmail.Text));
                    G.spArr.Add(new MySqlParameter("@g6", txtGLand.Text));
                    G.spArr.Add(new MySqlParameter("@g7", txtGMobile.Text));
                    G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));

                    G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_registerbooking(@bktype, @rsid, @gid, @rtid, @rid, @rrate, @ga, @gc, @gc0, @isovn, @g0, @g1, @g2, @g3, @g4, @g5, @g6, @g7, @cid);", G.spArr);

                    if(G.AffectedDbRows > 0)
                    {
                        if(MessageBox.Show("Booking for guest " + cmbGSalutation.Text + " " + txtGFName.Text + " " + txtGLName.Text + " has been processed successfully.\n Create another booking?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cmbBookingType.SelectedIndex = 0;
                            cmbAccType.SelectedValue = 0;
                            txtAccRate.Text = "0.00";
                            cmbAccRate.SelectedIndex = -1;
                            dtpUsageFrom.Value = Convert.ToDateTime("01/01/1900 00:00:00");
                            dtpUsageTo.Value = Convert.ToDateTime("01/01/1900 00:00:00");
                            txtGCAdult.Text = "0";
                            txtGCChild4up.Text = "0";
                            txtGCChild4below.Text = "0";

                            btnClearGF.PerformClick();
                        }
                        else
                        {
                            this.Close();
                        }
                    }

                }
            }
        }

        private void cmbAccType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
