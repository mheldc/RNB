using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Collections;
using System.Threading;
using System.IO;

namespace CA_Turnstile
{
    public partial class frmCATOSettings : Form
    {
        SerialPort COMPort = new SerialPort();

        public frmCATOSettings()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            if (cboDefPort.Items.Count > 0) 
            {
                try
                {
                    COMPort.PortName = cboDefPort.Text;
                    COMPort.BaudRate = Convert.ToInt32(cboDefPort.Text);
                    COMPort.DataBits = Convert.ToInt16(cboDataBit.Text);
                    COMPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBit.Text);
                    COMPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cboHandshake.Text);
                    COMPort.Parity = (Parity)Enum.Parse(typeof(Parity), cboParityBit.Text);
                    COMPort.Open();

                    MessageBox.Show("Serial port " + cboDefPort.Text + " test suceeded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error accessing/opening selected port. \n Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("System has not detected any existing/available communications port on this machine.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }

        }

        private void btnDbTest_Click(object sender, EventArgs e)
        {
            if(txtDbHost.Text.Length == 0)
            {
                MessageBox.Show("Server/Host has not been defined. Please key in a valid server host name or IP address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtDefDb.Text.Length == 0)
            {
                MessageBox.Show("Database has not been selected. Please key in a valid server database name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtDbUid.Text.Length == 0)
            {
                MessageBox.Show("Database account has not been specified. Please key in a valid database account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CADatabase cd = new CADatabase();
            MySqlConnection cn = cd.MyDbOpen(txtDbHost.Text, txtDefDb.Text, txtDbUid.Text, txtDbPw.Text, Convert.ToInt16(txtDbPort.Text));
            
            if(cn != null)
            {
                MessageBox.Show("Connection to server successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnApplyCs_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Save COM/Serial settings?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //CADatabase cd = new CADatabase();
                //using (MySqlConnection cn = cd.MyDbOpen(CAGlobals.DefaultHost, CAGlobals.DefaultDatabase, CAGlobals.LoginUID, CAGlobals.LoginPWD))
                //{
                //    string qry = String.Format("call sp_saveportsetting (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14);");

                //    ArrayList spa = new ArrayList();
                //    spa.Add(new MySqlParameter("@p1", cboDefPort.SelectedIndex));
                //    spa.Add(new MySqlParameter("@p2", cboDefPort.Text));
                //    spa.Add(new MySqlParameter("@p3", cboBaud.SelectedIndex));
                //    spa.Add(new MySqlParameter("@p4", cboBaud.Text));
                //    spa.Add(new MySqlParameter("@p5", cboDataBit.SelectedIndex));
                //    spa.Add(new MySqlParameter("@p6", cboDataBit.Text));
                //    spa.Add(new MySqlParameter("@p7", cboStopBit.SelectedIndex));
                //    spa.Add(new MySqlParameter("@p8", cboStopBit.Text));
                //    spa.Add(new MySqlParameter("@p9", cboParityBit.SelectedIndex));
                //    spa.Add(new MySqlParameter("@p10", cboParityBit.Text));
                //    spa.Add(new MySqlParameter("@p11", cboHandshake.SelectedIndex));
                //    spa.Add(new MySqlParameter("@p12", cboHandshake.Text));
                //    spa.Add(new MySqlParameter("@p13", cboDelay.SelectedIndex));
                //    spa.Add(new MySqlParameter("@p14", cboDelay.Text));

                //    cd.ExecSQL(cn, qry, spa);
                //}

                using (StreamWriter sw = new StreamWriter(CAGlobals.COMSettingsFile, false))
                {
                    sw.WriteLine(cboDefPort.SelectedIndex.ToString());
                    sw.WriteLine(cboDefPort.Text);
                    sw.WriteLine(cboBaud.SelectedIndex.ToString());
                    sw.WriteLine(cboBaud.Text);
                    sw.WriteLine(cboDataBit.SelectedIndex.ToString());
                    sw.WriteLine(cboDataBit.Text);
                    sw.WriteLine(cboStopBit.SelectedIndex.ToString());
                    sw.WriteLine(cboStopBit.Text);
                    sw.WriteLine(cboParityBit.SelectedIndex.ToString());
                    sw.WriteLine(cboParityBit.Text);
                    sw.WriteLine(cboHandshake.SelectedIndex.ToString());
                    sw.WriteLine(cboHandshake.Text);
                    sw.WriteLine(cboDelay.SelectedIndex.ToString());
                    sw.WriteLine(cboDelay.Text);
                    sw.WriteLine(cboScanDelay.Text);
                    sw.Close();
                }

                MessageBox.Show("Settings saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSettings(); 
            }
        }

        private void btnUseDbSet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save Database connectivity settings?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CaligrapyEncryption ce = new CaligrapyEncryption();
                using (StreamWriter sw = new StreamWriter(Application.StartupPath + @"\CATODb.conf", false))
                {
                    sw.WriteLine(ce.EncryptText(txtDbHost.Text));
                    sw.WriteLine(ce.EncryptText(txtDefDb.Text));
                    sw.WriteLine(ce.EncryptText(txtDbPort.Text));
                    sw.WriteLine(ce.EncryptText(txtDbUid.Text));
                    sw.WriteLine(ce.EncryptText(txtDbPw.Text));
                    sw.Close();
                }

                    MessageBox.Show("Settings saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSettings();
            }
        }

        private void LoadSettings()
        {

            if(Properties.Settings.Default.ServerHost == "Host")
            {
                return;
            }

            CaligrapyEncryption ce = new CaligrapyEncryption();
            CADatabase cd = new CADatabase();
            DataTable dt = new DataTable();

            if(File.Exists(Application.StartupPath + @"\CATODb.conf"))
            {
                int lnum = 1;
                using (StreamReader sw = new StreamReader(Application.StartupPath + @"\CATODb.conf"))
                {
                    while (sw.EndOfStream == false)
                    {
                        if (lnum == 1) { CAGlobals.DefaultHost = txtDbHost.Text = ce.DecryptText(sw.ReadLine()); }
                        else if (lnum == 2) { CAGlobals.DefaultDatabase = txtDefDb.Text = ce.DecryptText(sw.ReadLine()); }
                        else if (lnum == 3)
                        {
                            CAGlobals.DefaultPort = Convert.ToInt16(ce.DecryptText(sw.ReadLine()));
                            txtDbPort.Text = CAGlobals.DefaultPort.ToString();
                        }
                        else if (lnum == 4) { CAGlobals.LoginUID = txtDbUid.Text = ce.DecryptText(sw.ReadLine()); }
                        else if (lnum == 5) { CAGlobals.LoginPWD = txtDbPw.Text = ce.DecryptText(sw.ReadLine()); }
                        else { }
                        lnum++;
                        //MessageBox.Show(ce.DecryptText(sw.ReadLine()));
                    }
                }
            }

            if(File.Exists(CAGlobals.COMSettingsFile) == true)
            {
                try
                {
                    using(StreamReader sr = new StreamReader(CAGlobals.COMSettingsFile))
                    {
                        int lnum = 1;
                        while (!sr.EndOfStream)
                        {
                            if (lnum == 1) { cboDefPort.SelectedIndex = CAGlobals.DefaultCOMPort = Convert.ToInt32(sr.ReadLine()); }
                            if (lnum == 2) { CAGlobals.COMPortName = sr.ReadLine().ToString(); }
                            if (lnum == 3) { cboBaud.SelectedIndex = CAGlobals.DefaultBaudRate = Convert.ToInt32(sr.ReadLine()); }
                            if (lnum == 4) { CAGlobals.BaudRateName = sr.ReadLine().ToString(); }
                            if (lnum == 5) { cboDataBit.SelectedIndex = CAGlobals.DefaultDataBits = Convert.ToInt32(sr.ReadLine()); }
                            if (lnum == 6) { CAGlobals.DataBitName = Convert.ToString(sr.ReadLine()); }
                            if (lnum == 7) { cboStopBit.SelectedIndex = CAGlobals.DefaultStopBits = Convert.ToInt32(sr.ReadLine()); }
                            if (lnum == 8) { CAGlobals.StopBitName = Convert.ToString(sr.ReadLine()); }
                            if (lnum == 9) { cboParityBit.SelectedIndex = CAGlobals.DefaultParityBits = Convert.ToInt32(sr.ReadLine()); }
                            if (lnum == 10) { CAGlobals.ParityName = Convert.ToString(sr.ReadLine()); }
                            if (lnum == 11) { cboHandshake.SelectedIndex = CAGlobals.DefaultHandshake = Convert.ToInt32(sr.ReadLine()); }
                            if (lnum == 12) { CAGlobals.HandshakeName = Convert.ToString(sr.ReadLine()); }
                            if (lnum == 13) { cboDelay.SelectedIndex = CAGlobals.DefaultDelay = Convert.ToInt32(sr.ReadLine()); }
                            if (lnum == 14) { CAGlobals.DelayName = Convert.ToString(sr.ReadLine()); }
                            if (lnum == 15) { CAGlobals.ScanDelay = Convert.ToInt16(sr.ReadLine()); }

                            lnum+=1;
                        }
                        sr.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else
            {
                MessageBox.Show("No Communications port settings found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            //if(CAGlobals.DefaultHost.Length > 0)
            //{
            //    using (MySqlConnection cn = cd.MyDbOpen(txtDbHost.Text, txtDefDb.Text, txtDbUid.Text, txtDbPw.Text))
            //    {
            //        dt = cd.GetResults(cn, "call sp_getportsetting");
            //    }

            //    if(dt != null)
            //    {
            //        foreach(DataRow rw in dt.Rows)
            //        {
            //            try {
            //                cboDefPort.SelectedIndex = CAGlobals.DefaultCOMPort =  Convert.ToInt32(rw["portid"]);
            //                CAGlobals.COMPortName = Convert.ToString(rw["portname"]); 
            //                cboBaud.SelectedIndex = CAGlobals.DefaultBaudRate = Convert.ToInt32(rw["baudid"]);
            //                CAGlobals.BaudRateName = Convert.ToString(rw["baudnm"]);
            //                cboDataBit.SelectedIndex = CAGlobals.DefaultDataBits = Convert.ToInt32(rw["databitid"]);
            //                CAGlobals.DataBitName = Convert.ToString(rw["databitnm"]);
            //                cboStopBit.SelectedIndex = CAGlobals.DefaultStopBits = Convert.ToInt32(rw["stopbitid"]);
            //                CAGlobals.StopBitName = Convert.ToString(rw["stopbitnm"]);
            //                cboParityBit.SelectedIndex = CAGlobals.DefaultParityBits = Convert.ToInt32(rw["parityid"]);
            //                CAGlobals.ParityName = Convert.ToString(rw["paritynm"]);
            //                cboHandshake.SelectedIndex = CAGlobals.DefaultHandshake = Convert.ToInt32(rw["handshakeid"]);
            //                CAGlobals.HandshakeName = Convert.ToString(rw["handshakenm"]);
            //                cboDelay.SelectedIndex = CAGlobals.DefaultDelay = Convert.ToInt32(rw["txdelay"]);
            //                CAGlobals.DelayName = Convert.ToString(rw["txdelaynm"]);
            //            } catch(Exception ex)
            //            {
            //                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    }
            //}
        }

        private void LoadAvailablePorts()
        {
            cboDefPort.Items.Clear();
            foreach(string ports in SerialPort.GetPortNames())
            {
                cboDefPort.Items.Add(ports);
            }

            if(cboDefPort.Items.Count == 0)
            {
                MessageBox.Show("No available ports detected.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmCATOSettings_Load(object sender, EventArgs e)
        {
            LoadAvailablePorts();
            LoadSettings();
        }

        private void btnScanPort_Click(object sender, EventArgs e)
        {
            LoadAvailablePorts();
        }

        private void btnTest_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SerialPort sp = new SerialPort(CAGlobals.COMPortName, Convert.ToInt32(CAGlobals.BaudRateName), (Parity)CAGlobals.DefaultParityBits))
                {
                    if (sp.IsOpen == false)
                    {
                        sp.Open();
                        sp.Handshake = (Handshake)CAGlobals.DefaultHandshake;
                        sp.DtrEnable = true;
                        sp.BreakState = true;
                        Thread.Sleep(5000);
                        sp.BreakState = false;
                        sp.DtrEnable = false;
                        sp.Close();
                    }
                    else
                    {
                        sp.Handshake = (Handshake)CAGlobals.DefaultHandshake;
                        sp.DtrEnable = true;
                        sp.BreakState = true;
                        Thread.Sleep(5000);
                        sp.BreakState = false;
                        sp.DtrEnable = false;
                        sp.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if(chkUseNullModem.Checked == true)
            {
                try
                {
                    using (SerialPort sp = new SerialPort("COM2", Convert.ToInt32(CAGlobals.BaudRateName), (Parity)CAGlobals.DefaultParityBits))
                    {
                        if (sp.IsOpen == false)
                        {
                            sp.Open();
                            sp.Handshake = Handshake.XOnXOff;
                            sp.DtrEnable = true;
                            Thread.Sleep(5000);
                            sp.DtrEnable = false;
                        }
                        else
                        {
                            sp.Handshake = Handshake.XOnXOff;
                            sp.DtrEnable = true;
                            Thread.Sleep(5000);
                            sp.DtrEnable = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Null Modem Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
    }
}
