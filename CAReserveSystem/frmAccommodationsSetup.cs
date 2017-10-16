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
    public partial class frmAccommodationsSetup : Form
    {
        private int ATOperation = -1;
        private int ACOperation = -1;
        private int SelectedAccType = 0;
        private int SelectedAcc = 0;

        public frmAccommodationsSetup()
        {
            InitializeComponent();
        }

        private void LoadAccommodationTypes()
        {
            using(G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                MyDb.LoadDataToComboBox(cmbACAT, "rtid", "rtdesc", "call `sp_getaccommodationtypes`;", G.cn);
                MyDb.LoadDataToComboBox(cmbATAR, "rtid", "rtdesc", "call `sp_getaccommodationtypes`;", G.cn);
            }
        }

        private void AccommodationTypeTransaction(int t)
        {
            decimal ATDownpayment = 0;
            if(txtDP.Text == "0" || txtDP.Text.Trim().Length == 0) { ATDownpayment = 0; } else { ATDownpayment = Convert.ToDecimal(txtDP.Text); }

            using(G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                if(G.cn == null)
                {
                    Logging.Activity("Unable to connect to database server. Check database server settings.");
                    MessageBox.Show("Unable to connect to database server. Please check database settings or contact your system administrator for assistance.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@rtype", t));
                    G.spArr.Add(new MySqlParameter("@atid", SelectedAccType));
                    G.spArr.Add(new MySqlParameter("@atdesc", txtATDesc.Text));
                    G.spArr.Add(new MySqlParameter("@act1", chkAllowDP.Checked));
                    G.spArr.Add(new MySqlParameter("@act2", cmbDPType.SelectedIndex));
                    G.spArr.Add(new MySqlParameter("@act3", ATDownpayment));
                    G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));

                    if(t == 0 || t == 1 || t == 2)
                    {
                        G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_tranaccommodationtypes(@rtype, @atid, @atdesc, @act1, @act2, @act3, @cid);", G.spArr);

                        if (t == 0 && G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " added new Accommodation type " + txtATDesc.Text + ".");
                            MessageBox.Show("Accommodation type " + txtATDesc.Text + " has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (t == 1 && G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " updated Accommodation type ID " + SelectedAccType.ToString() + ".");
                            MessageBox.Show("Accommodation type " + txtATDesc.Text + " has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (t == 2 && G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " removed Accommodation type " + txtATDesc.Text + ".");
                            MessageBox.Show("Accommodation type " + txtATDesc.Text + " has been removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Logging.Activity("An unknown error encountered while adding/updating/deleting Accommodation Type " + txtATDesc.Text + ".");
                            MessageBox.Show("An unknown error encountered while adding / updating / deleting Accommodation Type " + txtATDesc.Text + ". Please contact your system provider for support.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (t == 3) 
                    {
                        G.dt = MyDb.GetResults(G.cn, "call sp_tranaccommodationtypes(@rtype, @atid, @atdesc, @act1, @act2, @act3, @cid);", G.spArr);
                        if(G.dt != null)
                        {
                            foreach (DataRow rw in G.dt.Rows)
                            {
                                txtATDesc.Text = Convert.ToString(rw["typedesc"]);
                                chkAllowDP.Checked = Convert.ToBoolean(rw["allowdp"]);
                                cmbDPType.SelectedIndex = Convert.ToInt16(rw["dptype"]);
                                txtDP.Text = String.Format(Convert.ToString(rw["dpvalue"]), "###,##0.00");
                            }
                        }
                    }
                    else if(t == 4)
                    {
                        G.dt = MyDb.GetResults(G.cn, "call sp_tranaccommodationtypes(@rtype, @atid, @atdesc, @act1, @act2, @act3, @cid);", G.spArr);
                        if(G.dt != null) { dgvAT.DataSource = G.dt; }
                    }
                }
            }
        }

        private void AccommodationTransaction(int t)
        {
            int ACCapacity = 0;
            if(txtACCap.Text == "0" || txtACCap.Text.Trim().Length == 0) { ACCapacity = 0; } else { ACCapacity = Convert.ToInt32(txtACCap.Text); }

            using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                if (G.cn == null)
                {
                    Logging.Activity("Unable to connect to database server. Check database server settings.");
                    MessageBox.Show("Unable to connect to database server. Please check database settings or contact your system administrator for assistance.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@rtype", t));
                    G.spArr.Add(new MySqlParameter("@rid", SelectedAcc));
                    G.spArr.Add(new MySqlParameter("@rtid", cmbACAT.SelectedValue));
                    G.spArr.Add(new MySqlParameter("@rcode", txtACCode.Text));
                    G.spArr.Add(new MySqlParameter("@rdesc", txtACDesc.Text));
                    G.spArr.Add(new MySqlParameter("@cap", ACCapacity));
                    G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));

                    if (t == 0 || t == 1 || t == 2)
                    {
                        G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_tranaccommodations(@rtype, @rid, @rtid, @rcode, @rdesc, @cap, @cid);", G.spArr);

                        if (t == 0 && G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " added new Accommodation " + txtACDesc.Text + ".");
                            MessageBox.Show("Accommodation " + txtACDesc.Text + " has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (t == 1 && G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " updated Accommodation ID " + SelectedAcc.ToString() + ".");
                            MessageBox.Show("Accommodation " + txtACCode.Text + " has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (t == 2 && G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " removed Accommodation " + txtACDesc.Text + ".");
                            MessageBox.Show("Accommodation " + txtACDesc.Text + " has been removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } 
                        else
                        {
                            Logging.Activity("An unknown error encountered while adding/updating/deleting Accommodation " + txtACDesc.Text + ".");
                            MessageBox.Show("An unknown error encountered while adding / updating / deleting Accommodation " + txtACDesc.Text + ". Please contact your system provider for support.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (t == 3)
                    {
                        G.dt = MyDb.GetResults(G.cn, "call sp_tranaccommodations(@rtype, @rid, @rtid, @rcode, @rdesc, @cap, @cid);", G.spArr);
                        if (G.dt != null)
                        {
                            foreach (DataRow rw in G.dt.Rows)
                            {
                                cmbACAT.SelectedValue = Convert.ToInt32(rw["typeid"]);
                                txtACCode.Text = Convert.ToString(rw["roomcode"]);
                                txtACDesc.Text = Convert.ToString(rw["roomdesc"]);
                                txtACCap.Text = Convert.ToString(rw["capacity"]);
                            }
                        }
                    }
                    else if (t == 4)
                    {
                        G.dt = MyDb.GetResults(G.cn, "call sp_tranaccommodations(@rtype, @rid, @rtid, @rcode, @rdesc, @cap, @cid);", G.spArr);
                        if (G.dt != null) { dgvAC.DataSource = G.dt; }
                    }
                }
            }
        }

        private void AccommodationRatesTransaction(int t)
        {
            using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                if (G.cn == null)
                {
                    Logging.Activity("Unable to connect to database server. Check database server settings.");
                    MessageBox.Show("Unable to connect to database server. Please check database settings or contact your system administrator for assistance.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@rtype", t));
                    G.spArr.Add(new MySqlParameter("@rtid", cmbATAR.SelectedValue));
                    G.spArr.Add(new MySqlParameter("@r1", txtARDay.Text));
                    G.spArr.Add(new MySqlParameter("@r2", dtpARDayFrom.Value));
                    G.spArr.Add(new MySqlParameter("@r3", dtpARDayTo.Value));
                    G.spArr.Add(new MySqlParameter("@r4", txtARNight.Text));
                    G.spArr.Add(new MySqlParameter("@r5", dtpARNightFrom.Value));
                    G.spArr.Add(new MySqlParameter("@r6", dtpARNightTo.Value));
                    G.spArr.Add(new MySqlParameter("@r7", txtARWholeDay.Text));
                    G.spArr.Add(new MySqlParameter("@r8", dtpARDayFrom.Value));
                    G.spArr.Add(new MySqlParameter("@r9", dtpARNightTo.Value));
                    G.spArr.Add(new MySqlParameter("@r10", txtAREx.Text));
                    G.spArr.Add(new MySqlParameter("@r11", cmbAREx.SelectedIndex));
                    G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));

                    if (t == 0 || t == 1 || t == 2)
                    {
                        G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_tranaccommodationrates(@rtype, @rtid, @r1, @r2, @r3, @r4, @r5, @r6, @r7, @r8, @r9, @r10, @r11, @cid);", G.spArr);

                        if (t == 0 && G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " added new Accommodation rates for " + cmbATAR.Text + ".");
                            MessageBox.Show("Accommodation rates for " + cmbATAR.Text + " has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (t == 1 && G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " updated Accommodation rates for " + cmbATAR.Text + ".");
                            MessageBox.Show("Accommodation rates for " + cmbATAR.Text + " has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (t == 2 && G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " removed Accommodation rates for " + cmbATAR.Text + ".");
                            MessageBox.Show("Accommodation rates for " + cmbATAR.Text + " has been removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Logging.Activity("An unknown error encountered while adding/updating/deleting Accommodation rates for " + cmbATAR.Text + ".");
                            MessageBox.Show("An unknown error encountered while adding / updating / deleting Accommodation rates for " + cmbATAR.Text + ". Please contact your system provider for support.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (t == 3)
                    {
                        G.dt = MyDb.GetResults(G.cn, "call sp_tranaccommodationrates(@rtype, @rtid, @r1, @r2, @r3, @r4, @r5, @r6, @r7, @r8, @r9, @r10, @r11, @cid);", G.spArr);
                        if (G.dt != null)
                        {
                            foreach (DataRow rw in G.dt.Rows)
                            {
                                cmbATAR.SelectedValue = Convert.ToInt32(rw["rmtypeid"]);
                                txtARDay.Text = String.Format(rw["regular"].ToString(), "###,##0.00");
                                dtpARDayFrom.Value = Convert.ToDateTime("01/01/1900 " + rw["regtimein"].ToString());
                                dtpARDayTo.Value = Convert.ToDateTime("01/01/1900 " + rw["regtimeout"].ToString());
                                txtARNight.Text = String.Format(rw["overnight"].ToString(), "###,##0.00");
                                dtpARNightFrom.Value = Convert.ToDateTime("01/01/1900 " + rw["ovntimein"].ToString());
                                dtpARNightTo.Value = Convert.ToDateTime("01/01/1900 " + rw["ovntimeout"].ToString());
                                txtARWholeDay.Text = String.Format(rw["daynight"].ToString(), "###,##0.00");
                                txtAREx.Text = String.Format(rw["extension"].ToString(), "###,##0.00");
                                cmbAREx.SelectedIndex = Convert.ToInt16(rw["extratebase"]);
                            }
                        }
                        else
                        {
                            ClearAndEnableARFields(true);
                        }
                    }
                    else if (t == 4)
                    {
                        G.dt = MyDb.GetResults(G.cn, "call sp_tranaccommodationrates(@rtype, @rtid, @r1, @r2, @r3, @r4, @r5, @r6, @r7, @r8, @r9, @r10, @r11, @cid);", G.spArr);
                        if (G.dt != null) { dgvAT.DataSource = G.dt; }
                    }
                }
            }
        }

        private void frmAccommodationsSetup_Load(object sender, EventArgs e)
        {
            dgvAT.AutoGenerateColumns = false;
            dgvAC.AutoGenerateColumns = false;
            AccommodationTypeTransaction(4);
            AccommodationTransaction(4);
            LoadAccommodationTypes();
            dtpARDayFrom.Value = Convert.ToDateTime("01/01/1900 00:00:00");
            dtpARDayTo.Value = Convert.ToDateTime("01/01/1900 00:00:00");
            dtpARNightFrom.Value = Convert.ToDateTime("01/01/1900 00:00:00");
            dtpARNightTo.Value = Convert.ToDateTime("01/01/1900 00:00:00");
            txtDP.Enabled = chkAllowDP.Checked;
            cmbDPType.Enabled = chkAllowDP.Checked;
            ClearAndEnableATFields();
            ClearAndEnableACFields();
            ClearAndEnableARFields();
        }

        private void ClearAndEnableATFields(bool e = false)
        {
            txtATDesc.Enabled = e;
            chkAllowDP.Enabled = e;
            txtDP.Enabled = chkAllowDP.Checked;
            cmbDPType.Enabled = chkAllowDP.Checked;

            if(ATOperation != 1)
            {
                txtATDesc.Clear();
                chkAllowDP.Checked = false;
                txtDP.Clear();
                cmbDPType.SelectedIndex = 0;
            }
        }

        private void ClearAndEnableACFields(bool e = false)
        {
            txtACCode.Enabled = e;
            txtACDesc.Enabled = e;
            txtACCap.Enabled = e;

            if(ACOperation != 1)
            {
                cmbACAT.SelectedValue = 0;
                txtACCode.Clear();
                txtACDesc.Clear();
                txtACCap.Clear();
            }
        }

        private void ClearAndEnableARFields(bool e = false)
        {
            //txtARDay.Enabled = e;
            //dtpARDayFrom.Enabled = e;
            //dtpARDayTo.Enabled = e;
            //txtARNight.Enabled = e;
            //dtpARNightFrom.Enabled = e;
            //dtpARNightTo.Enabled = e;
            //txtAREx.Enabled = e;
            //cmbAREx.Enabled = e;
            //txtARWholeDay.Enabled = e;

            //cmbATAR.SelectedValue = 0;
            txtARDay.Text = "0.00";
            dtpARDayFrom.Value = Convert.ToDateTime("1/1/1900 12:00:00 AM");
            dtpARDayTo.Value = Convert.ToDateTime("1/1/1900 12:00:00 AM");
            txtARNight.Text = "0.00";
            dtpARNightFrom.Value = Convert.ToDateTime("1/1/1900 12:00:00 AM");
            dtpARNightTo.Value = Convert.ToDateTime("1/1/1900 12:00:00 AM");
            txtAREx.Text = "0.00";
            cmbAREx.SelectedIndex = 0;
            txtARWholeDay.Text = "0.00";
        }

        private void tsbAddAT_Click(object sender, EventArgs e)
        {
            ATOperation = 0;
            tsbAddAT.Visible = false;
            tsbEditAT.Visible = false;
            tsbSaveAT.Visible = true;
            tsbCancelAT.Visible = true;
            ClearAndEnableATFields(true);
        }

        private void tsbEditAT_Click(object sender, EventArgs e)
        {
            ATOperation = 1;
            tsbAddAT.Visible = false;
            tsbEditAT.Visible = false;
            tsbSaveAT.Visible = true;
            tsbCancelAT.Visible = true;
            ClearAndEnableATFields(true);
        }

        private void tsbSaveAT_Click(object sender, EventArgs e)
        {
            decimal dpAmt = 0;
            if(txtATDesc.Text.Trim().Length == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save/update Accommodation type without defining a name/description for the type.");
                MessageBox.Show("Accommodation type description is a mandatory field. Please supply a valid value then try again.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtATDesc.Focus();
                return;
            }
            if(chkAllowDP.Checked == true)
            {
                Decimal.TryParse(txtDP.Text, out dpAmt);
                if (dpAmt == 0)
                {
                    Logging.Activity("User " + G.CurrentUserName + " attempts to save/update Accommodation type without and/or entering a valid downpayment value.");
                    MessageBox.Show("Downpayment value for Accommodation type is required when Downpayment checkbox is ticked. Please supply a valid value then try again.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(cmbDPType.SelectedIndex < 1)
                {
                    Logging.Activity("User " + G.CurrentUserName + " attempts to save/update Accommodation type without and/or selecting a valid downpayment basis type.");
                    MessageBox.Show("Downpayment type for Accommodation type is required when Downpayment checkbox is ticked. Please supply a valid value then try again.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if(ATOperation == 0 && MessageBox.Show("Confirm saving new Accommodation type " + txtATDesc.Text + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AccommodationTypeTransaction(ATOperation);
                AccommodationTypeTransaction(4);
            }
            else if( ATOperation == 1 && MessageBox.Show("Save changes to Accommodation type " + txtATDesc.Text + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AccommodationTypeTransaction(ATOperation);
                AccommodationTypeTransaction(4);
            }
            tsbCancelAT.PerformClick();
            LoadAccommodationTypes();
        }

        private void tsbCancelAT_Click(object sender, EventArgs e)
        {
            ATOperation = -1;
            SelectedAccType = 0;
            tsbAddAT.Visible = true;
            tsbEditAT.Visible = false;
            tsbSaveAT.Visible = false;
            tsbCancelAT.Visible = false;
            ClearAndEnableATFields();
            AccommodationTypeTransaction(4);
        }

        private void dgvAT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    ATOperation = 1;
                    SelectedAccType = Convert.ToInt32(dgvAT[2, e.RowIndex].Value);
                    AccommodationTypeTransaction(3);
                    tsbAddAT.Visible = false;
                    tsbEditAT.Visible = true;
                    tsbSaveAT.Visible = false;
                    tsbCancelAT.Visible = true;
                    break;

                case 1:
                    if(MessageBox.Show("Are you sure you want to remove Accommodation type " + dgvAT[3, e.RowIndex].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ATOperation = 2;
                        SelectedAccType = Convert.ToInt32(dgvAT[2, e.RowIndex].Value);
                        AccommodationTypeTransaction(2);
                        ClearAndEnableATFields();
                        AccommodationTypeTransaction(4);
                    }
                    break;

                default: break;
            }
        }

        private void dgvAT_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAT.Columns[2].DataPropertyName = "id";
            dgvAT.Columns[3].DataPropertyName = "typedesc";
            dgvAT.Columns[4].DataPropertyName = "allowdp";
            dgvAT.Columns[5].DataPropertyName = "dpvalue";
            dgvAT.Columns[6].DataPropertyName = "dptype";
        }

        private void chkAllowDP_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAllowDP.Checked == false)
            {
                txtDP.Text = "0.00";
                cmbDPType.SelectedIndex = 0;
            }

            txtDP.Enabled = chkAllowDP.Checked;
            cmbDPType.Enabled = chkAllowDP.Checked;
        }

        private void tsbAddAcc_Click(object sender, EventArgs e)
        {
            ACOperation = 0;
            tsbAddAcc.Visible = false;
            tsbAccEdit.Visible = false;
            tsbSaveAcc.Visible = true;
            tsbCancelAcc.Visible = true;
            ClearAndEnableACFields(true);
        }

        private void tsbAccEdit_Click(object sender, EventArgs e)
        {
            ACOperation = 1;
            tsbAddAcc.Visible = false;
            tsbAccEdit.Visible = false;
            tsbSaveAcc.Visible = true;
            tsbCancelAcc.Visible = true;
            ClearAndEnableACFields(true);
        }

        private void tsbSaveAcc_Click(object sender, EventArgs e)
        {
            Int32 AcCap = 0;

            if(Convert.ToInt32(cmbACAT.SelectedValue) == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save/update Accommodation without selecting a valid Accommodation type.");
                MessageBox.Show("Accommodation type is a required field. Please select a valid value from the drop down list", "Invalid Accommodation Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbACAT.Focus();
                return;
            }

            if(txtACCode.Text.Trim().Length == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save/update Accommodation without entering a valid accommodation code.");
                MessageBox.Show("Accommodation code is a required field. Please enter a valid value.", "Invalid Accommodation Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtACCode.Focus();
                return;
            }

            if(txtACDesc.Text.Trim().Length == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save/update Accommodation without entering a valid Accommodation Description.");
                MessageBox.Show("Accommodation description is a required field. Please enter a valid value.", "Invalid Description", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtACDesc.Focus();
                return;
            }

            Int32.TryParse(txtACCap.Text, out AcCap);
            if(AcCap == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save/update Accommodation without entering a valid Accommodation Capacity.");
                MessageBox.Show("Accommodation capacity is a required field. Please enter a valid value.", "Invalid Capacity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtACCap.Focus();
                return;
            }

            if(ACOperation == 0 && MessageBox.Show("Create new accommodation " + txtACDesc.Text + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AccommodationTransaction(ACOperation);
                AccommodationTransaction(4);
                ClearAndEnableACFields();
                tsbCancelAcc.PerformClick();
            }
            else if(ACOperation == 1 && MessageBox.Show("Save changes to accommodation " + txtACDesc.Text + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AccommodationTransaction(ACOperation);
                AccommodationTransaction(4);
                ClearAndEnableACFields();
                tsbCancelAcc.PerformClick();
            }
        }

        private void tsbCancelAcc_Click(object sender, EventArgs e)
        {
            ACOperation = -1;
            tsbAddAcc.Visible = true;
            tsbAccEdit.Visible = false;
            tsbSaveAcc.Visible = false;
            tsbCancelAcc.Visible = false;
            ClearAndEnableACFields();
            AccommodationTransaction(4);
        }

        private void dgvAC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    ACOperation = 1;
                    SelectedAcc = Convert.ToInt32(dgvAC[2, e.RowIndex].Value);
                    AccommodationTransaction(3);
                    tsbAddAcc.Visible = false;
                    tsbAccEdit.Visible = true;
                    tsbSaveAcc.Visible = false;
                    tsbCancelAcc.Visible = true;
                    break;
                case 1:
                    if(MessageBox.Show("Are you sure you want to remove accommodation " + dgvAC[4, e.RowIndex].Value.ToString(), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SelectedAcc = Convert.ToInt32(dgvAC[2, e.RowIndex].Value);
                        AccommodationTransaction(2);
                        AccommodationTransaction(4);
                        tsbCancelAcc.PerformClick();
                    }
                    break;
                default: break;
            }
        }

        private void dgvAC_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAC.Columns[2].DataPropertyName = "id";
            dgvAC.Columns[3].DataPropertyName = "roomcode";
            dgvAC.Columns[4].DataPropertyName = "roomdesc";
            dgvAC.Columns[5].DataPropertyName = "capacity";
            //for(int i = 6; i < dgvAC.Columns.Count  - 1; i++)
            //{
            //    dgvAC.Columns[i].Visible = false;
            //} 
        }

        private void cmbATAR_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToInt32(cmbATAR.SelectedValue) > 0)
                {
                    AccommodationRatesTransaction(3);
                }
                else
                {
                    ClearAndEnableARFields(true);
                }
            }
            catch (Exception ex)
            {
                Logging.Activity(ex.Message);
            }
        }

        private void tsbCancelAR_Click(object sender, EventArgs e)
        {
            ClearAndEnableARFields();
        }

        private void tsbSaveAR_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(cmbATAR.SelectedValue) == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save/update rates without selecting an Accommodation type from the dropdown list.");
                MessageBox.Show("Accommodation type is required. Please select one from the dropdown list then try saving again.", "Invalid Accommodation Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbATAR.Focus();
                return;
            }

            if(MessageBox.Show("Save/Update rates for Accommodation " + cmbATAR.Text + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AccommodationRatesTransaction(0);
                ClearAndEnableARFields();
            }
        }

        private void cmbACAT_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                AccommodationTransaction(4);
            }
            catch (Exception)
            {

            }
            
        }
    }
}
