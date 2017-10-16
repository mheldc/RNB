using System;
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

namespace CA_Board
{
    public partial class frmGuestBoard : Form
    {
        string GuestName = "";

        public frmGuestBoard()
        {
            InitializeComponent();
        }

        private void LoadQueue()
        {
            using(MySqlConnection cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                G.dt = new DataTable();
                G.dt = MyDb.GetResults(cn, "call sp_getnextguestonqueue();");
                GuestName = "";
                if (G.dt != null)
                {
                    if (G.dt.Rows.Count > 0)
                    {
                        foreach(DataRow rw in G.dt.Rows)
                        {
                            GuestName = rw[1].ToString();
                        }
                    }
                    else
                    {
                        lblOnQueue.Text = "";
                    }
                }
            }

            if (GuestName != lblOnQueue.Text) { lblOnQueue.Text = GuestName; }
        }

        private void frmGuestBoard_Load(object sender, EventArgs e)
        {
            Settings.Load();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd MMMM dd, yyyy hh:mm:ss tt");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lblOnQueue.ForeColor == Color.DarkBlue) { lblOnQueue.ForeColor = Color.White; } else { lblOnQueue.ForeColor = Color.DarkBlue; }
            LoadQueue();
        }
    }
}
