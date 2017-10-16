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
using BNRLibrary;
using MySql.Data.MySqlClient;

namespace CAReserveSystem
{
    public partial class frmReservationNew : Form
    {
        long SelectedResvId = 0;

        public frmReservationNew()
        {
            InitializeComponent();
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

        private void TransactReservation()
        {
            using (MySqlConnection cn  = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                G.spArr = new ArrayList();
                G.spArr.Add(new MySqlParameter("@rtype", 1));
                G.spArr.Add(new MySqlParameter("@resid", SelectedResvId));
                G.spArr.Add(new MySqlParameter("@gid", G.SelectedGID));
                G.spArr.Add(new MySqlParameter("@rtid", cmbAccType.SelectedValue));
                G.spArr.Add(new MySqlParameter("@rmid", cmbAcc.SelectedValue));
                G.spArr.Add(new MySqlParameter("@rdate", dtpRsvDate.Value));
                G.spArr.Add(new MySqlParameter("@ison", G.SelectedGID));
                G.spArr.Add(new MySqlParameter("@egcnt", G.SelectedGID));
                G.spArr.Add(new MySqlParameter("@paid", G.SelectedGID));
                G.spArr.Add(new MySqlParameter("@dp", G.SelectedGID));
                G.spArr.Add(new MySqlParameter("@bal", G.SelectedGID));
                G.spArr.Add(new MySqlParameter("@rmk", G.SelectedGID));
                G.spArr.Add(new MySqlParameter("@g0", G.SelectedGID));
                G.spArr.Add(new MySqlParameter("@g1", G.SelectedGID));
                G.spArr.Add(new MySqlParameter("@g2", G.SelectedGID));
                G.spArr.Add(new MySqlParameter("@g3", G.SelectedGID));
                G.spArr.Add(new MySqlParameter("@g4", G.SelectedGID));
                G.spArr.Add(new MySqlParameter("@g5", G.SelectedGID));
                G.spArr.Add(new MySqlParameter("@g6", G.SelectedGID));
                G.spArr.Add(new MySqlParameter("@g7", G.SelectedGID));
                G.spArr.Add(new MySqlParameter("@cid", G.SelectedGID));
                G.spArr.Add(new MySqlParameter("@sparam", ""));

            }
        }

        private void tsbGuestLookup_Click(object sender, EventArgs e)
        {
            frmBookingGuestLookup f = new frmBookingGuestLookup();
            f.ShowDialog();
            DisplayGuestInfo();
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

        private void dtpUsageFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmReservationNew_Load(object sender, EventArgs e)
        {

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

        }

        private void tsbSaveBooking_Click(object sender, EventArgs e)
        {

        }
    }
}
