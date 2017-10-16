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
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(txtAcctId.Text.Trim().Length == 0) {
                MessageBox.Show("Unable to process account validation. No or invalid Account Id supplied.","Account Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Logging.Activity("User attempts to log into the system with a blank and/or invalid account.");
                return;
            }

            if(txtAcctPw.Text.Trim().Length == 0) {
                MessageBox.Show("Unable to process account validation. No or invalid Account Password supplied", "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Logging.Activity("User attempts to log into the system with a blank and/or invalid password.");
                return;
            }

            try
            {
                using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                {
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@lid", txtAcctId.Text));
                    G.spArr.Add(new MySqlParameter("@lpw", txtAcctPw.Text));
                    G.dt = MyDb.GetResults(G.cn, "call `sp_validatecredentials` (@lid, @lpw);", G.spArr);

                    if (G.dt == null) { MessageBox.Show("Unable to verify supplied credential, either account does not exists and/or is invalid. \r Please check supplied credentials then try signing in again.", "Sign In Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    else
                    {
                        foreach(DataRow rw in G.dt.Rows)
                        {
                            if(Convert.ToBoolean(rw["recstatus"]) == true)
                            {
                                G.CurrentUserId = Convert.ToInt32(rw["uid"]);
                                G.CurrentUserName = Convert.ToString(rw["lname"] + ", " + rw["fname"]);
                                G.CurrentRoleId = Convert.ToInt32(rw["rid"]);
                                G.CurrentUserRole = Convert.ToString(rw["roledesc"]);
                                G.AllowSignIn = Convert.ToBoolean(rw["allowlogin"]);
                                G.AllowBooking = Convert.ToBoolean(rw["allowbilling"]);
                                G.AllowReservation = Convert.ToBoolean(rw["allowreserve"]);
                                G.AllowInventory = Convert.ToBoolean(rw["allowinventory"]);
                                G.AllowCashiering = Convert.ToBoolean(rw["allowcashier"]);
                                G.AllowSetup = Convert.ToBoolean(rw["allowsettings"]);
                            }
                            else
                            {
                                G.CurrentUserName = Convert.ToString(rw["lname"] + ", " + rw["fname"]);
                                Logging.Activity("Account " + G.CurrentUserName + " has already been disabled and tried to log in to the system.");
                                MessageBox.Show("The account you're trying to login is already been deleted or disabled. Please contact your system administrator.", "Account Disabled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                        }

                        Logging.Activity("User " + G.CurrentUserName + " have successfully logged into the system. Validating user role and access rights....");

                        if (G.AllowSignIn == false) {
                            MessageBox.Show("Your credentials are valid but does not have sufficient access to use the system. Please contact your System Administrator for assistance.");
                            Logging.Activity("User " + G.CurrentUserName + " have successfully logged into the system. But the system prevents the user from accessing the system due to insufficient priviledges.");
                            txtAcctId.Clear();
                            txtAcctPw.Clear();
                            Logging.Activity("Clearing user inputs. Waiting for user credentials to validate....");
                            return; }
                        else
                        {
                            Logging.Activity("User " + G.CurrentUserName + " have successfully logged into the system.Validating user role and access rights.... DONE.");
                            Logging.Activity("Loading priviledges for user " + G.CurrentUserName + ".");
                            MessageBox.Show("Welcome " + G.CurrentUserName + "!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            G.SignInFlag = false;
                            Logging.Activity("Closing down the sign in screen.");
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.Activity("An error occurred : " + ex.Message);
            }
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            Logging.Activity("Loading sign in screen...Loaded.");
            Settings.Load();

            if (G.DefaultHost == null)
            {
                this.Dispose();
                frmSystemSetup f = new frmSystemSetup();
                f.ShowDialog();
            }
        }

        private void frmSignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logging.Activity("User " + G.CurrentUserName + " attempts to terminate/close the application.");
        }
    }
}
