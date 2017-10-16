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
    public partial class frmBPassIssuance : Form
    {
        public frmBPassIssuance()
        {
            InitializeComponent();
        }

        private void frmBPassIssuance_Load(object sender, EventArgs e)
        {
            LoadPassesToIssue();
        }

        private void txtPassToScan_TextChanged(object sender, EventArgs e)
        {
            tmrScanPass.Enabled = true;
        }

        private void tmrScanPass_Tick(object sender, EventArgs e)
        {
            bool PassExists = false;

            if (txtPassToScan.Text.Length >= 7)
            {
                if (libPasses.Items.Count == 0)
                {
                    libPasses.Items.Add(txtPassToScan.Text);
                    txtPassToScan.Text = "";
                    lblRemaining1.Text = (Convert.ToInt16(lblTotalPass1.Text) - Convert.ToInt16(libPasses.Items.Count)).ToString("###,##0");
                    tmrScanPass.Enabled = false;
                }
                else
                {
                    for (int i = 0; i < libPasses.Items.Count; i++)
                    {
                        if (libPasses.Items[i].ToString() == txtPassToScan.Text)
                        {
                            MessageBox.Show("Cannot add resort pass " + txtPassToScan.Text + " due to pass has been issued already or already in the list. Please scan a unique pass.", "Error Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Logging.Activity("User " + G.CurrentUserName + " attempts to scan pass " + txtPassToScan.Text + " which is already been scanned or issued.");
                            PassExists = true;
                        }
                    }

                    if (PassExists == false)
                    {
                        libPasses.Items.Add(txtPassToScan.Text);
                        txtPassToScan.Text = "";
                        lblRemaining1.Text = (Convert.ToInt16(lblTotalPass1.Text) - Convert.ToInt16(libPasses.Items.Count)).ToString("###,##0");
                        tmrScanPass.Enabled = false;
                    }
                    else
                    {
                        txtPassToScan.Text = "";
                        tmrScanPass.Enabled = false;
                    }
                }

                if(Convert.ToInt16(lblTotalPass1.Text) == libPasses.Items.Count)
                {
                    txtPassToScan.ReadOnly = true;
                }
            }
            
        }

        private void btnIssuePass_Click(object sender, EventArgs e)
        {
            int passcount = 0, passfail = 0;

            // When user attempts to trigger pass registration without scanning a pass.
            if(lblRemaining1.Text == lblTotalPass1.Text || Convert.ToInt16(lblRemaining1.Text) != 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to trigger register/issue pass without scanning the total number of passes. Aborting operation.");
                MessageBox.Show("Unable to issue passes without scanning and registering the total number in the system.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // When User registers partial number of passes to guest.
            //if(Convert.ToInt16(lblRemaining1.Text) > 0)
            //{
            //    Logging.Activity("There are " + lblRemaining1.Text + " passes that needs to be registered before issuing to guest.");
            //    if(MessageBox.Show("There are still " + lblRemaining1.Text + " passes that needs to be scanned/registered. Issue the remaining passes later?","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        Logging.Activity("User " + G.CurrentUserName + " confirms the issuance of the remaining passes to " + txtGuestName.Text + " at a later time.");
            //        using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            //        {
            //            for(int i = 0; i < libPasses.Items.Count; i++)
            //            {
            //                G.spArr = new ArrayList();
            //                G.spArr.Add(new MySqlParameter("@bid", G.SelectedBID));
            //                G.spArr.Add(new MySqlParameter("@bcw", libPasses.Items[i].ToString()));
            //                G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));

            //                G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_registerresortpasses(@bid, @bcw, @cid);", G.spArr);
            //                if(G.AffectedDbRows == 0) { Logging.Activity("Unable to register pass number " + libPasses.Items[i].ToString()); passfail += 1; }
            //                else { Logging.Activity("Resort pass number " + libPasses.Items[i].ToString() + " has been registered succesfully."); passcount += 1; }
            //            }
            //        }
            //        MessageBox.Show("Passes registration summary: \n Success : " + passcount.ToString() + "\n Failed : " + passfail.ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        libPasses.Items.Clear();
            //        LoadPassesToIssue();
            //    }
            //    return; 
            //}
            
            // When user issues all passes to guest.
            if (Convert.ToInt16(lblRemaining1.Text) == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " confirms the issuance of passes to " + txtGuestName.Text);
                using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                {
                    for (int i = 0; i < libPasses.Items.Count; i++)
                    {
                        G.spArr = new ArrayList();
                        G.spArr.Add(new MySqlParameter("@bid", G.SelectedBID));
                        G.spArr.Add(new MySqlParameter("@bcw", libPasses.Items[i].ToString()));
                        G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));

                        G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_registerresortpasses(@bid, @bcw, @cid);", G.spArr);
                        if (G.AffectedDbRows == 0) { Logging.Activity("Unable to register pass number " + libPasses.Items[i].ToString()); passfail += 1; }
                        else { Logging.Activity("Resort pass number " + libPasses.Items[i].ToString() + " has been registered succesfully."); passcount += 1; }
                    }
                }
                MessageBox.Show("Passes registration summary: \n Success : " + passcount.ToString() + "\n Failed : " + passfail.ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                libPasses.Items.Clear();
                LoadPassesToIssue();
                return;
            } 
        }

        private void LoadPassesToIssue()
        {
            if (G.SelectedBID > 0)
            {
                using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                {
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@bid", G.SelectedBID));
                    G.dt = MyDb.GetResults(G.cn, "call sp_getbookinginfo(@bid);", G.spArr);

                    if (G.dt != null)
                    {
                        foreach (DataRow rw in G.dt.Rows)
                        {
                            txtGuestName.Text = rw["guestname"].ToString();
                            txtAcc.Text = rw["room"].ToString();
                            Logging.Activity("Loading payment information for guest " + txtGuestName.Text + ".");
                        }
                        G.dt = null;
                    }
                }
                txtPassToScan.Focus();
                lblTotalPass1.Text = G.PassToIssue.ToString("###,##0");
                lblRemaining1.Text = (Convert.ToInt16(lblTotalPass1.Text) - Convert.ToInt16(libPasses.Items.Count)).ToString("###,##0");
            }
        }
    }
}
