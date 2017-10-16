using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_Turnstile
{
    public partial class frmLK : Form
    {
        public frmLK()
        {
            InitializeComponent();
        }

        private void frmLK_Load(object sender, EventArgs e)
        {
            txtLK.Text = CAGlobals.LicenseKey;
        }

        private string GetMBoardSerial()
        {
            string s = "";
            //Get motherboard's serial number 
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
            foreach (ManagementObject mo in mbs.Get())
            {
                s = mo["SerialNumber"].ToString().Trim();
            }
            //Console.WriteLine(s);
            return s;
        }

        private string GetHDDSerial()
        {
            string s = "";

            //ManagementClass dc = new ManagementClass("Win32_DiskDrive");
            //PropertyDataCollection props = dc.Properties;
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
            foreach (ManagementObject hd in mos.Get())
            {
                //Console.WriteLine(hd["Tag"]);
                // get the hardware serial no.
                if (hd["Tag"].ToString() == "\\\\.\\PHYSICALDRIVE0")
                {
                    s = hd["SerialNumber"].ToString().Trim();
                }
            }

            //Console.WriteLine(s);
            return s;
        }

        private bool ValidateLK(CAGlobals.LKType LicenseType = CAGlobals.LKType.Registration)
        {
            bool b = false;
            string mboard = GetMBoardSerial();
            string hdd = GetHDDSerial();

            CaligrapyEncryption ce = new CaligrapyEncryption();

            if(LicenseType == CAGlobals.LKType.Registration)
            {
                string lk = ce.EncryptText(mboard + hdd);
                if(txtLK.Text == lk) {
                    using(StreamWriter sw = new StreamWriter(Application.StartupPath + "\\CATOLic.conf"))
                    {
                        sw.WriteLine(txtLK.Text);
                    }
                    b = true;
                }
                else
                {
                    b = false;
                }
            }
            else
            {
                if(File.Exists(Application.StartupPath + "\\CATOLic.conf") == true) {
                    using(StreamReader sr = new StreamReader(Application.StartupPath + "\\CATOLic.conf"))
                    {
                        int lnum = 1;
                        while(sr.EndOfStream == false)
                        {
                            if(lnum == 1) { CAGlobals.LicenseKey = sr.ReadLine(); }
                            string lk = ce.DecryptText(CAGlobals.LicenseKey);
                            string hw = mboard + hdd;
                            if (hw == lk) { b = true; }
                        }

                    }
                }
            }
            return b;
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            bool IsValid = ValidateLK(CAGlobals.LKType.Registration);
            if(IsValid == true) {
                MessageBox.Show("License key entered is valid and saved. Restart application.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else { MessageBox.Show("License key entered is invalid. Please supply a valid key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        }

        private bool CheckLicenseKey()
        {
            bool bflag = false;
            if (File.Exists(Application.StartupPath + "\\CATOLic.conf") == true)
            {
                using (StreamReader sr = new StreamReader(Application.StartupPath + "\\CATOLic.conf"))
                {
                    int lnum = 1;
                    string mboard = GetMBoardSerial();
                    string hdd = GetHDDSerial();
                    CaligrapyEncryption ce = new CaligrapyEncryption();

                    while (sr.EndOfStream == false)
                    {
                        if (lnum == 1) { CAGlobals.LicenseKey = txtLK.Text = sr.ReadLine(); }
                        string lk = ce.DecryptText(CAGlobals.LicenseKey);
                        string hw = mboard + hdd;
                        if (hw == lk) { bflag = true; }
                    }

                }
            }

            return bflag;
        }
    }
}
