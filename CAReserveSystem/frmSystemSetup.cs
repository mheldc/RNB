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
using System.IO;

namespace CAReserveSystem
{
    public partial class frmSystemSetup : Form
    {
        private static string SelectedImg = "";
        private static byte[] ImageStream = null;

        public frmSystemSetup()
        {
            InitializeComponent();
        }

        private void btnTestCon_Click(object sender, EventArgs e)
        {
            int portnum = 0;
            if (txtServer.Text.Length == 0)
            {
                Logging.Activity("No server host has been defined by the user.");
                MessageBox.Show("Server/Host has not been defined. Please key in a valid server host name or IP address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtDatabase.Text.Length == 0)
            {
                Logging.Activity("No default database defined by the user.");
                MessageBox.Show("Database has not been selected. Please key in a valid server database name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtLID.Text.Length == 0)
            {
                Logging.Activity("Database account has not been specified.");
                MessageBox.Show("Database account has not been specified. Please key in a valid database account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(int.TryParse(txtPort.Text, out portnum) == false)
            {
                Logging.Activity("Invalid port number [" + txtPort.Text + "] supplied by the user.");
            }

            G.cn = MyDb.Open(txtServer.Text, txtDatabase.Text, txtLID.Text, txtLPW.Text, Convert.ToInt16(txtPort.Text));

            if (G.cn != null)
            {
                Logging.Activity("Test connection to server [" + txtServer.Text + "] successful.");
                MessageBox.Show("Connection to server successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnApplyDb_Click(object sender, EventArgs e)
        {
            Logging.Activity("Waiting for confirmation to user " + G.CurrentUserName + " to apply changes to database setting.");
            if (MessageBox.Show("Save Database connectivity settings?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Logging.Activity("CONFIRMED. Applying changes to database settings.");
                using (StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Db.conf"))
                {
                    sw.WriteLine(CaligrapySecurity.EncryptText(txtServer.Text, G.EncryptionKey));
                    sw.WriteLine(CaligrapySecurity.EncryptText(txtDatabase.Text, G.EncryptionKey));
                    sw.WriteLine(txtPort.Text);
                    sw.WriteLine(CaligrapySecurity.EncryptText(txtLID.Text, G.EncryptionKey));
                    sw.WriteLine(CaligrapySecurity.EncryptText(txtLPW.Text,G.EncryptionKey));
                }

                Logging.Activity("Applying changes to database settings... DONE");
                MessageBox.Show("Settings saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Settings.Load();
            }
        }

        private void btnApplyComp_Click(object sender, EventArgs e)
        {
            if(G.DefaultHost == null)
            {
                MessageBox.Show("Please configure database connections first before you can save your company profile.", "Error Saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(G.PLicenseKey == null)
            {
                MessageBox.Show("Please enter and activate your license key before you can use the system.", "License Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtCompany.Text.Trim().Length == 0)
            {
                MessageBox.Show("Company name is a required field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Logging.Activity("Warning : User " + G.CurrentUserName + " fails and/or did not enter a value for [Company Name] field");
                txtCompany.Focus();
                return;
            }
            else if(txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Company Address is a required field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Logging.Activity("Warning : User " + G.CurrentUserName + " fails and/or did not enter a value for [Company Address] field");
                txtAddress.Focus();
                return;
            }
            else if (txtContacts.Text.Trim().Length == 0)
            {
                MessageBox.Show("Company contact info is a required field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Logging.Activity("Warning : User " + G.CurrentUserName + " fails and/or did not enter a value for [Company Contact Info] field");
                txtContacts.Focus();
                return;
            }
            else if (txtTIN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tax Identification Number is a required field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Logging.Activity("Warning : User " + G.CurrentUserName + " fails and/or did not enter a value for [Tax Identification Number] field");
                txtTIN.Focus();
                return;
            }
            else if (txtProps.Text.Trim().Length == 0)
            {
                MessageBox.Show("Proprietor/s is a required field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Logging.Activity("Warning : User " + G.CurrentUserName + " fails and/or did not enter a value for [Proprietor/s] field");
                txtProps.Focus();
                return;
            }
            else
            {
                Logging.Activity("Waiting confirmation from user " + G.CurrentUserName + " to apply changes made to company profile.");
                if(MessageBox.Show("Apply changes to company profile?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Logging.Activity("User " + G.CurrentUserName + " confirms to apply changes made to company profile.");
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@c1", txtCompany.Text));
                    G.spArr.Add(new MySqlParameter("@c2", txtAddress.Text));
                    G.spArr.Add(new MySqlParameter("@c3", txtContacts.Text));
                    G.spArr.Add(new MySqlParameter("@c4", txtTIN.Text));
                    G.spArr.Add(new MySqlParameter("@c5", txtProps.Text));

                    if(SelectedImg.Length > 0)
                    {
                        FileStream fs = new FileStream(SelectedImg, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        ImageStream = br.ReadBytes((int)fs.Length);
                        br.Close();
                        fs.Close();
                    }

                    G.spArr.Add(new MySqlParameter("@c6", ImageStream));

                    using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                    {
                        Logging.Activity("Saving [Company Profile] changes to database.");
                        G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_companyprofile (@c1, @c2, @c3, @c4, @c5, @c6);", G.spArr);
                    }
                    if(G.AffectedDbRows > 0) { MessageBox.Show("Company profile has been saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else
                {
                    using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                    {
                        G.dt = MyDb.GetResults(G.cn, "call sp_getcompanyprofile();");
                        if (G.dt != null)
                        {
                            foreach (DataRow rw in G.dt.Rows)
                            {
                                txtCompany.Text = Convert.ToString(rw["coname"]);
                                txtAddress.Text = Convert.ToString(rw["coaddr"]);
                                txtContacts.Text = Convert.ToString(rw["conumb"]);
                                txtTIN.Text = Convert.ToString(rw["cotin"]);
                                txtProps.Text = Convert.ToString(rw["coprops"]);
                                ImageStream = (byte[])rw["cologo"];
                                MemoryStream ms = new MemoryStream(ImageStream);
                                picLogo.Image = Image.FromStream(ms);
                            }
                        }
                    }


                }

            }
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            try
            {
                Logging.Activity("User " + G.CurrentUserName + " opens image dialog window and selects an image.");
                if(ofdPic.ShowDialog() == DialogResult.OK)
                {
                    SelectedImg = ofdPic.FileName;
                    picLogo.Image = Image.FromFile(SelectedImg);
                    Logging.Activity("Image " + ofdPic.SafeFileName + " has been selected and loaded on preview.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while processing image " + ofdPic.SafeFileName + ". Reason : " + ex.Message);
                Logging.Activity("Error occured : " + ex.Message);
            }
        }

        private void frmSystemSetup_Load(object sender, EventArgs e)
        {
            CheckSettings();
        }

        private void CheckSettings()
        {
            Settings.Load();
            if(G.DefaultHost != null)
            {
                txtServer.Text = G.DefaultHost;
                txtDatabase.Text = G.DefaultDb;
                txtPort.Text = Convert.ToString(G.DefaultPort);
                txtLID.Text = G.DefaultId;
                txtLPW.Text = G.DefaultPw;

                using(G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                {
                    G.dt = MyDb.GetResults(G.cn, "call sp_getcompanyprofile();");
                    if(G.dt != null)
                    {
                        foreach(DataRow rw in G.dt.Rows)
                        {
                            txtCompany.Text = Convert.ToString(rw["coname"]);
                            txtAddress.Text = Convert.ToString(rw["coaddr"]);
                            txtContacts.Text = Convert.ToString(rw["conumb"]);
                            txtTIN.Text = Convert.ToString(rw["cotin"]);
                            txtProps.Text = Convert.ToString(rw["coprops"]);
                            ImageStream = (byte[])rw["cologo"];
                            MemoryStream ms = new MemoryStream(ImageStream);
                            picLogo.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
            if(G.PLicenseKey == G.LicenseKey)
            {
                txtLicense.Text = G.PLicenseKey;
                txtLicense.ReadOnly = true;
                btnLicense.Visible = false;
            }
        }

        private void btnLicense_Click(object sender, EventArgs e)
        {
            if(txtLicense.Text != G.LicenseKey)
            {
                MessageBox.Show("The license you provided is invalid. Make sure you entered the correct serial, otherwise contact your software vendor for support.", "Invalid License", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            } else
            {
                using(StreamWriter sw = new StreamWriter(G.LiConfig))
                {
                    sw.WriteLine(txtLicense.Text);
                }
                Application.Restart();
            }

        }
    }
}
