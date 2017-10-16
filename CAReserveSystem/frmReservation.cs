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
    public partial class frmReservation : Form
    {
        public frmReservation()
        {
            InitializeComponent();
        }

        private void LoadReservations(int rt = 0, string sp = "")
        {
            using (MySqlConnection cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                G.spArr = new ArrayList();
                G.spArr.Add(new MySqlParameter("@restype", rt));
                G.spArr.Add(new MySqlParameter("@sparam", sp));

                G.dt = MyDb.GetResults(cn, "call sp_getreservations(@restype, @sparam);", G.spArr);

                if(G.dt.Rows.Count > 0)
                {
                    dgvReservation.DataSource = G.dt;
                    dgvReservation.AutoGenerateColumns = false;
                }
            }
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void dgvReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbFind_Click(object sender, EventArgs e)
        {

        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            frmReservationNew f = new frmReservationNew();
            f.ShowDialog();
            LoadReservations();
        }
    }
}
