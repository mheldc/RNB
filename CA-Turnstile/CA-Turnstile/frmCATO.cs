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
using System.IO.Ports;
using System.Threading;
using MySql.Data.MySqlClient;
using System.IO;
using System.Configuration;
using System.Management;

namespace CA_Turnstile
{
    public partial class frmCATO : Form
    {
        int ScanCounter = 0;

        public frmCATO()
        {
            InitializeComponent();
        }

        private void frmCATO_Load(object sender, EventArgs e)
        {
            if(File.Exists(Application.StartupPath + "\\CATOLic.conf"))
            {
                if(ValidateLK(CAGlobals.LKType.Validation) == false)
                {
                    frmLK f = new frmLK();
                    f.ShowDialog();
                } else
                {
                    LoadSettings();
                    if (CAGlobals.DefaultHost == "" || File.Exists(CAGlobals.COMSettingsFile) == false)
                    {
                        using(frmCATOSettings f = new frmCATOSettings())
                        {
                            f.ShowDialog();
                        }
                    } else
                    {
                        txbBCode.Focus();
                    }
                }
            }
            else
            {
                frmLK f = new frmLK();
                f.ShowDialog();
            }

        }

        private void btnSendOpen_Click(object sender, EventArgs e)
        {
            if (CAGlobals.DefaultHost == "" || CAGlobals.DefaultCOMPort == -1)
            {
                using (frmCATOSettings f = new frmCATOSettings())
                {
                    f.ShowDialog();
                }
            }
            else
            {
                int delays = Convert.ToInt32(CAGlobals.DelayName.ToString().Replace("second", "").Replace("seconds", "")) * 1000;
                try
                {
                    using (SerialPort sp = new SerialPort(CAGlobals.COMPortName, Convert.ToInt32(CAGlobals.BaudRateName), (Parity)CAGlobals.DefaultParityBits))
                    {
                        if (sp.IsOpen == false)
                        {
                            sp.Open();
                            sp.Handshake = Handshake.XOnXOff;
                            sp.DtrEnable = true;
                            sp.BreakState = true;
                            Thread.Sleep(delays);
                            sp.BreakState = false;
                            sp.DtrEnable = false;
                        } else
                        {
                            sp.Handshake = Handshake.XOnXOff;
                            sp.DtrEnable = true;
                            sp.BreakState = true;
                            Thread.Sleep(delays);
                            sp.BreakState = false;
                            sp.DtrEnable = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    using (StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Turnstile" + DateTime.Now.ToString("yyyyMMdd") + ".logs", true))
                    {
                        sw.WriteLine(DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss") + " An error occurred while sending signal to the machine. " + ex.Message);
                    }
                    tmrScan.Stop();
                }

                if(chkUseNullModem.Checked == true)
                {
                    try
                    {
                        using (SerialPort sp = new SerialPort(CAGlobals.COMPortName, Convert.ToInt32(CAGlobals.BaudRateName), (Parity)CAGlobals.DefaultParityBits))
                        {
                            if (sp.IsOpen == false)
                            {
                                sp.Open();
                                sp.Handshake = Handshake.XOnXOff;
                                sp.DtrEnable = true;
                                Thread.Sleep(delays);
                                sp.DtrEnable = false;
                            }
                            else
                            {
                                sp.Handshake = Handshake.XOnXOff;
                                sp.DtrEnable = true;
                                Thread.Sleep(delays);
                                sp.DtrEnable = false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        using (StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Turnstile" + DateTime.Now.ToString("yyyyMMdd") + ".logs", true))
                        {
                            sw.WriteLine(DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss") + " An error occurred while sending signal to the machine. " + ex.Message);
                        }
                        tmrScan.Stop();
                    }
                }
            }
            tmrScan.Stop();
        }

        private void tsmSettings_Click(object sender, EventArgs e)
        {
            frmCATOSettings f = new frmCATOSettings();
            Form fc = Application.OpenForms[f.Name];
            if (fc != null)
            {
                MessageBox.Show("Turnstile settings window is already open.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                f.TopLevel = true;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }

        private void txbBCode_TextChanged(object sender, EventArgs e)
        {
            ScanCounter = 0;
        }

        private void LoadSettings()
        {
            if (Properties.Settings.Default.ServerHost == "Host")
            {
                return;
            }

            CaligrapyEncryption ce = new CaligrapyEncryption();
            CADatabase cd = new CADatabase();
            DataTable dt = new DataTable();

            if (File.Exists(Application.StartupPath + @"\CATODb.conf"))
            {
                int lnum = 1;
                using (StreamReader sw = new StreamReader(Application.StartupPath + @"\CATODb.conf"))
                {
                    while (sw.EndOfStream == false)
                    {
                        if (lnum == 1) { CAGlobals.DefaultHost =  ce.DecryptText(sw.ReadLine()); }
                        else if (lnum == 2) { CAGlobals.DefaultDatabase = ce.DecryptText(sw.ReadLine()); }
                        else if (lnum == 3) { CAGlobals.DefaultPort = Convert.ToInt16(ce.DecryptText(sw.ReadLine())); }
                        else if (lnum == 4) { CAGlobals.LoginUID = ce.DecryptText(sw.ReadLine()); }
                        else if (lnum == 5) { CAGlobals.LoginPWD = ce.DecryptText(sw.ReadLine()); }
                        else { }
                        lnum++;
                    }
                }
            }

            if (File.Exists(CAGlobals.COMSettingsFile) == true)
            {
                using (StreamReader sr = new StreamReader(CAGlobals.COMSettingsFile))
                {
                    int lnum = 1;
                    while (!sr.EndOfStream)
                    {
                        if (lnum == 1) { CAGlobals.DefaultCOMPort = Convert.ToInt32(sr.ReadLine()); }
                        if (lnum == 2) { CAGlobals.COMPortName = sr.ReadLine().ToString(); }
                        if (lnum == 3) { CAGlobals.DefaultBaudRate = Convert.ToInt32(sr.ReadLine()); }
                        if (lnum == 4) { CAGlobals.BaudRateName = sr.ReadLine().ToString(); }
                        if (lnum == 5) { CAGlobals.DefaultDataBits = Convert.ToInt32(sr.ReadLine()); }
                        if (lnum == 6) { CAGlobals.DataBitName = Convert.ToString(sr.ReadLine()); }
                        if (lnum == 7) { CAGlobals.DefaultStopBits = Convert.ToInt32(sr.ReadLine()); }
                        if (lnum == 8) { CAGlobals.StopBitName = Convert.ToString(sr.ReadLine()); }
                        if (lnum == 9) { CAGlobals.DefaultParityBits = Convert.ToInt32(sr.ReadLine()); }
                        if (lnum == 10) { CAGlobals.ParityName = Convert.ToString(sr.ReadLine()); }
                        if (lnum == 11) { CAGlobals.DefaultHandshake = Convert.ToInt32(sr.ReadLine()); }
                        if (lnum == 12) { CAGlobals.HandshakeName = Convert.ToString(sr.ReadLine()); }
                        if (lnum == 13) { CAGlobals.DefaultDelay = Convert.ToInt32(sr.ReadLine()); }
                        if (lnum == 14) { CAGlobals.DelayName = Convert.ToString(sr.ReadLine()); }
                        if (lnum == 15) { CAGlobals.ScanDelay = Convert.ToInt16(sr.ReadLine()); }
                        if (lnum == 16) { CAGlobals.GateDirection = Convert.ToInt16(sr.ReadLine()); }
                        lnum += 1;
                    }
                    sr.Close();
                }
            }

            //if (CAGlobals.DefaultHost.Length > 0)
            //{
            //    using (MySqlConnection cn = cd.MyDbOpen(CAGlobals.DefaultHost, CAGlobals.DefaultDatabase, CAGlobals.LoginUID, CAGlobals.LoginPWD, CAGlobals.DefaultPort))
            //    {
            //        dt = cd.GetResults(cn, "call sp_getportsetting");
            //    }

            //    if (dt != null)
            //    {
            //        foreach (DataRow rw in dt.Rows)
            //        {
            //            CAGlobals.DefaultCOMPort = Convert.ToInt32(rw["portid"]);
            //            CAGlobals.COMPortName = Convert.ToString(rw["portname"]);
            //            CAGlobals.DefaultBaudRate = Convert.ToInt32(rw["baudid"]);
            //            CAGlobals.BaudRateName = Convert.ToString(rw["baudnm"]);
            //            CAGlobals.DefaultDataBits = Convert.ToInt32(rw["databitid"]);
            //            CAGlobals.DataBitName = Convert.ToString(rw["databitnm"]);
            //            CAGlobals.DefaultStopBits = Convert.ToInt32(rw["stopbitid"]);
            //            CAGlobals.StopBitName = Convert.ToString(rw["stopbitnm"]);
            //            CAGlobals.DefaultParityBits = Convert.ToInt32(rw["parityid"]);
            //            CAGlobals.ParityName = Convert.ToString(rw["paritynm"]);
            //            CAGlobals.DefaultHandshake = Convert.ToInt32(rw["handshakeid"]);
            //            CAGlobals.HandshakeName = Convert.ToString(rw["handshakenm"]);
            //            CAGlobals.DefaultDelay = Convert.ToInt32(rw["txdelay"]);
            //            CAGlobals.DelayName = Convert.ToString(rw["txdelaynm"]);
            //        }
            //    }
            //}
        }

        private void ValidatePass()
        {
            CADatabase cd = new CADatabase();
            bool EntryFlag = false;
            bool ExitFlag = false;
            int UType = -1;
            int AffectedDbRows = 0;
            string ScannedBCode = txbBCode.Text;
            txbBCode.Text = "";
            if (txbBCode.Focused == false) { txbBCode.Text = ""; txbBCode.Focus(); } else { txbBCode.Text = ""; txbBCode.Focus(); }

            try
            {
                using (MySqlConnection cn = cd.MyDbOpen(CAGlobals.DefaultHost, CAGlobals.DefaultDatabase, CAGlobals.LoginUID, CAGlobals.LoginPWD, CAGlobals.DefaultPort))
                {
                    if(cn != null)
                    {
                        DataTable dt = new DataTable();
                        ArrayList sp = new ArrayList();
                        sp.Add(new MySqlParameter("@bc", ScannedBCode));
                        dt = cd.GetResults(cn, "call sp_getbclogs(@bc);", sp);

                        if (dt != null)
                        {
                            foreach (DataRow dr in dt.Rows)
                            {
                                EntryFlag = Convert.ToBoolean(dr["entryflag"]);
                                ExitFlag = Convert.ToBoolean(dr["exitflag"]);
                                if (Convert.ToInt16(dr["bkid"]) > 0) { UType = 1; } else { UType = 0; }
                            }

                            sp = new ArrayList();
                            sp.Add(new MySqlParameter("@bc", ScannedBCode));
                            sp.Add(new MySqlParameter("@logtype", chkUseOnExit.Checked));
                            sp.Add(new MySqlParameter("@utype", UType));
                            AffectedDbRows = cd.ExecSQL(cn, "call sp_logpass(@bc, @logtype, @utype);", sp);

                            if (chkUseOnExit.Checked == true && AffectedDbRows > 0)
                            {
                                using (StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Turnstile" + DateTime.Now.ToString("yyyyMMdd") + ".logs", true))
                                {
                                    if (UType == 0)
                                    {
                                        sw.WriteLine(DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss") + " Employee with pass " + txbBCode.Text + " have been validated and successfully exited the premises.");
                                    }
                                    if (UType == 1)
                                    {
                                        sw.WriteLine(DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss") + " Guest with pass " + txbBCode.Text + " have been validated and successfully exited the premises.");
                                    }
                                }
                                btnSendOpen.PerformClick();
                            }
                            else if (chkUseOnExit.Checked == false && AffectedDbRows > 0)
                            {
                                using (StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Turnstile" + DateTime.Now.ToString("yyyyMMdd") + ".logs", true))
                                {
                                    if (UType == 0)
                                    {
                                        sw.WriteLine(DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss") + " Employee with pass " + txbBCode.Text + " have been validated and successfully entered the premises.");
                                    }
                                    if (UType == 1)
                                    {
                                        sw.WriteLine(DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss") + " Guest with pass " + txbBCode.Text + " have been validated and successfully entered the premises.");
                                    }
                                }
                                btnSendOpen.PerformClick();
                            }
                            else
                            {
                                using (StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Turnstile" + DateTime.Now.ToString("yyyyMMdd") + ".logs", true))
                                {
                                    sw.WriteLine(DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss") + " An error occurre while validating pass " + txbBCode.Text + ". Please contact your system administrator.");
                                }
                                if (txbBCode.Focused == false) { txbBCode.Focus(); } else { txbBCode.Focus(); }
                            }
                        }
                        else
                        {
                            using (StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Turnstile" + DateTime.Now.ToString("yyyyMMdd") + ".logs", true))
                            {
                                sw.WriteLine(DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss") + " No records were retrieved while validating pass " + txbBCode.Text + ". Please contact your system administrator.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Turnstile" + DateTime.Now.ToString("yyyyMMdd") + ".logs", true))
                {
                    sw.WriteLine(DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss") + " An error occurred while reading/validating barcode. " + ex.Message);
                }
                tmrScan.Stop();
            }
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

            using (StreamReader sr = new StreamReader(Application.StartupPath + "\\CATOLic.conf"))
            {
                int lnum = 1;
                while (sr.EndOfStream == false)
                {
                    if (lnum == 1) { CAGlobals.LicenseKey = sr.ReadLine(); }
                    string lk = ce.DecryptText(CAGlobals.LicenseKey);
                    string hw = mboard + hdd;
                    if (hw == lk) { b = true; }
                }

            }
            return b;
        }

        private void txbBCode_KeyUp(object sender, KeyEventArgs e)
        {
            //tmrScan.Enabled = true;
        }

        private void txb_KeyDown(object sender, KeyEventArgs e)
        {
            lblCtr.Text = "0";
        }

        private void tmrScan_Tick(object sender, EventArgs e)
        {
            if(ScanCounter == CAGlobals.ScanDelay && txbBCode.Text.Trim().Length > 0)
            {
                ValidatePass();
            }
        }

        private void tmrCheckGoScan_Tick(object sender, EventArgs e)
        {
            if(ScanCounter < CAGlobals.ScanDelay) { ScanCounter += 1;  lblCtr.Text = ScanCounter.ToString(); }
            if(ScanCounter == CAGlobals.ScanDelay) { tmrScan.Start(); }
        }
    }
}
