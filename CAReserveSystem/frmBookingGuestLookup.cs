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
using CAReserveSystem;

namespace CAReserveSystem
{
    public partial class frmBookingGuestLookup : Form
    {
        public frmBookingGuestLookup()
        {
            InitializeComponent();
        }

        private void frmBookingGuestLookup_Load(object sender, EventArgs e)
        {
            GetRegisteredGuests();
        }

        private void dgvdgvGuest_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvGuest.Columns[0].DataPropertyName = "id";
            dgvGuest.Columns[2].DataPropertyName = "guestname";

            //for(int i = 3; i < dgvGuest.Rows.Count - 1; i++)
            //{
            //    dgvGuest.Columns[i].Visible = false;
            //}
        }

        private void GetRegisteredGuests(int gid = 0, string searchparam = "")
        {
            using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                G.spArr = new ArrayList();
                G.spArr.Add(new MySqlParameter("@gid", gid));
                G.spArr.Add(new MySqlParameter("@searchparam", searchparam));

                G.dt = MyDb.GetResults(G.cn, "call sp_getregisteredguests(@gid, @searchparam);", G.spArr);
                dgvGuest.AutoGenerateColumns = false;
                dgvGuest.DataSource = G.dt;
            }
        }

        private void dgvGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                G.SelectedGID = Convert.ToInt32(dgvGuest[0, e.RowIndex].Value);
            }
            this.Close();
        }

        private void tstFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetRegisteredGuests(0, tstFind.Text);
            }
        }

        private void tsbFind_Click(object sender, EventArgs e)
        {
            if(tstFind.Text.Trim().Length > 0)
            {
                GetRegisteredGuests(0, tstFind.Text);
            }
        }
    }
}
