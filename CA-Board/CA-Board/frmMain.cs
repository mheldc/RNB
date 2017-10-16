using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BNRLibrary;

namespace CA_Board
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void LoadSettings()
        {
            CaligrapySecurity ce = new CaligrapySecurity();
            MyDb cd = new MyDb();
            DataTable dt = new DataTable();

            if (File.Exists(Application.StartupPath + @"\CATODb.conf"))
            {
                int lnum = 1;
                using (StreamReader sw = new StreamReader(Application.StartupPath + @"\CATODb.conf"))
                {
                    while (sw.EndOfStream == false)
                    {
                        if (lnum == 1) { G.DefaultHost = CaligrapySecurity.DecryptText(sw.ReadLine(), G.EncryptionKey); }
                        else if (lnum == 2) { G.DefaultDb = CaligrapySecurity.DecryptText(sw.ReadLine(), G.EncryptionKey); }
                        else if (lnum == 3) { G.DefaultPort = Convert.ToInt16(sw.ReadLine()); }
                        else if (lnum == 4) { G.DefaultId = CaligrapySecurity.DecryptText(sw.ReadLine(), G.EncryptionKey); }
                        else if (lnum == 5) { G.DefaultPw = CaligrapySecurity.DecryptText(sw.ReadLine(), G.EncryptionKey); }
                        else { }
                        lnum++;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSvcBoard f = new frmSvcBoard();
            Form fc = Application.OpenForms[f.Name];
            if (fc != null)
            {
                MessageBox.Show("Guest board screen is already open.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                f.StartPosition = FormStartPosition.CenterScreen;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGuestBoard f = new frmGuestBoard();
            Form fc = Application.OpenForms[f.Name];
            if (fc != null)
            {
                MessageBox.Show("Guest board screen is already open.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                f.StartPosition = FormStartPosition.CenterScreen;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }
    }
}
