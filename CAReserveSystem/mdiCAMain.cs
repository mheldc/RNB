using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BNRLibrary;
using System.IO;

namespace CAReserveSystem
{
    public partial class mdiCAMain : Form
    {
        public mdiCAMain()
        {
            InitializeComponent();
        }

        private void mdiCAMain_Load(object sender, EventArgs e)
        {
            Settings.Load();
            if(G.PLicenseKey == null )
            {
                tsmiSignIn.Enabled = false;
                frmSystemSetup f = new frmSystemSetup();
                f.ShowDialog();
                return;
            }
            if (G.PLicenseKey != G.LicenseKey)
            {
                tsmiSignIn.Enabled = false;
                frmSystemSetup f = new frmSystemSetup();
                f.ShowDialog();
                return;
            }
            if(G.PLicenseKey == G.LicenseKey)
            {
                tsmiReserve.Visible = G.AllowReservation;
                tsmiBooking.Visible = G.AllowBooking;
                tsmiReports.Visible = G.AllowCashiering;
                tsmiMaintenance.Visible = G.AllowSetup;

                tsslLogUser1.Text = G.CurrentUserName;
                tsslUserRole1.Text = G.CurrentUserRole;

                using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                {
                    G.Qry = "select `coname`, `cologo` from `ca_company_profile` where `id` = 1;";
                    G.dt = MyDb.GetResults(G.cn, G.Qry);
                    if(G.dt!= null)
                    {
                        foreach(DataRow rw in G.dt.Rows)
                        {
                            G.CompanyLogo = (byte[])rw["cologo"];
                            MemoryStream ms = new MemoryStream(G.CompanyLogo);
                            picLogo.Image = Image.FromStream(ms);
                            this.Text = Convert.ToString(rw["coname"]) + " Booking and Reservation System v" + Application.ProductVersion.ToString();
                        }
                    
                    }
                }  
            }
  
        }

        private void mdiCAMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logging.Activity("User " + G.CurrentUserName + " attempts to close the system, waiting for user confirmation.");
        }

        private void mdiCAMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logging.Activity("User " + G.CurrentUserName + " attempts to close the system, waiting for user confirmation.... CONFIRMED.");
            G.CurrentRoleId = 0;
            G.CurrentUserRole = null;
            G.CurrentUserId = 0;
            G.CurrentUserName = null;
        }

        private void timerdt_Tick(object sender, EventArgs e)
        {
            tsslCurrDatetime1.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss ttt");
            tsmiSignIn.Visible = G.SignInFlag;
            tsmiReserve.Visible = G.AllowReservation;
            //tsmiReserve.Visible = false;
            tsmiBooking.Visible = G.AllowBooking;
            tsmiReports.Visible = G.AllowCashiering;
            tsmiMaintenance.Visible = G.AllowSetup;

            tsslLogUser1.Text = G.CurrentUserName;
            tsslUserRole1.Text = G.CurrentUserRole;
            if (G.SignInFlag == false) { tsmiSignOut.Visible = true; } else { tsmiSignOut.Visible = false; }
        }

        private void tsmiSystem_Click(object sender, EventArgs e)
        {
            frmSystemSetup f = new frmSystemSetup();
            Form fc = Application.OpenForms[f.Name];
            if (fc != null)
            {
                MessageBox.Show("System Setup is already open.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                f.TopLevel = false;
                f.AutoScroll = true;
                this.pnlContainer.Controls.Add(f);
                f.StartPosition = FormStartPosition.CenterParent;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void tsmiBooking_Click(object sender, EventArgs e)
        {
            frmBooking f = new frmBooking();
            Form fc = Application.OpenForms[f.Name];
            if (fc != null)
            {
                MessageBox.Show("Booking screen is already open.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                f.TopLevel = false;
                f.AutoScroll = true;
                this.pnlContainer.Controls.Add(f);
                f.StartPosition = FormStartPosition.CenterParent;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }

        }

        private void tsmiSignIn_Click(object sender, EventArgs e)
        {
            timerdt.Enabled = false;
            frmSignIn f = new frmSignIn();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            timerdt.Enabled = true;
        }

        private void tsmiSignOut_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Logging.Activity("User " + G.CurrentUserName + " successfully logs out of the system.");
                G.CurrentRoleId = 0;
                G.CurrentUserRole = null;
                G.CurrentUserId = 0;
                G.CurrentUserName = null;
                G.SignInFlag = true;

                G.AllowReservation = false;
                G.AllowBooking = false;
                G.AllowCashiering = false;
                G.AllowSetup = false;

                foreach(Form f in pnlContainer.Controls)
                {
                    f.Close();
                }
            }

        }

        private void tsmiAccomodation_Click(object sender, EventArgs e)
        {
            frmAccommodationsSetup f = new frmAccommodationsSetup();
            Form fc = Application.OpenForms[f.Name];
            if(fc != null)
            {
                MessageBox.Show("Accommodation setup is already open.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                f.TopLevel = false;
                f.AutoScroll = true;
                this.pnlContainer.Controls.Add(f);
                f.StartPosition = FormStartPosition.CenterParent;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void tsmiUsers_Click(object sender, EventArgs e)
        {
            frmUserSetup f = new frmUserSetup();
            Form fc = Application.OpenForms[f.Name];
            if (fc != null)
            {
                MessageBox.Show("Users setup is already open.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                f.TopLevel = false;
                f.AutoScroll = true;
                this.pnlContainer.Controls.Add(f);
                f.StartPosition = FormStartPosition.CenterParent;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void tsmiGuestRates_Click(object sender, EventArgs e)
        {
            frmGuestsSetup f = new frmGuestsSetup();
            Form fc = Application.OpenForms[f.Name];
            if (fc != null)
            {
                MessageBox.Show("Guest rates setup is already open.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                f.TopLevel = false;
                f.AutoScroll = true;
                this.pnlContainer.Controls.Add(f);
                f.StartPosition = FormStartPosition.CenterParent;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void tsmiInventory_Click(object sender, EventArgs e)
        {
            frmInventorySetup f = new frmInventorySetup();
            Form fc = Application.OpenForms[f.Name];
            if (fc != null)
            {
                MessageBox.Show("Item inventory setup is already open.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                f.TopLevel = false;
                f.AutoScroll = true;
                this.pnlContainer.Controls.Add(f);
                f.StartPosition = FormStartPosition.CenterParent;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void tsmiReports_Click(object sender, EventArgs e)
        {

        }

        private void tsmiReportDaily_Click(object sender, EventArgs e)
        {
            G.ReportType = 1;
            frmRepGen rg = new frmRepGen();
            rg.ShowDialog();
        }

        private void tsmiReportBooking_Click(object sender, EventArgs e)
        {
            G.ReportType = 2;
            frmRepGen rg = new frmRepGen();
            rg.ShowDialog();
        }

        private void tsmiReportInv_Click(object sender, EventArgs e)
        {
            G.ReportType = 3;
            frmRepGen rg = new frmRepGen();
            rg.ShowDialog();
        }

        private void tsmiReserve_Click(object sender, EventArgs e)
        {
            frmReservation f = new frmReservation();
            Form fc = Application.OpenForms[f.Name];
            if (fc != null)
            {
                MessageBox.Show("Reservation screen is already open.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                f.TopLevel = false;
                f.AutoScroll = true;
                this.pnlContainer.Controls.Add(f);
                f.StartPosition = FormStartPosition.CenterParent;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }
    }
}
