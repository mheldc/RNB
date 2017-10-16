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
    public partial class frmUserSetup : Form
    {
        /* 
         * Operations Legend:
         *  0 - Add
         *  1 - Edit
         *  2 - Delete
         *  4 - Load Information
         *  5 - Load as List
         */

        private static int UROperation = -1;
        private static int UAOperation = -1;
        private static Int32 SelectedURId = 0;
        private static Int32 SelectedUAId = 0;

        public frmUserSetup()
        {
            InitializeComponent();
        }

        private void ClearAndEnableUserRoleFields(bool isenabled = false)
        {
            txtURDesc.Enabled = isenabled;
            chkURLogin.Enabled = isenabled;
            chkURBooking.Enabled = isenabled;
            chkURReserve.Enabled = isenabled;
            chkURSetup.Enabled = isenabled;
            chkURReports.Enabled = isenabled;

            if (UROperation != 1) {
                txtURDesc.Clear();
                chkURLogin.Checked = false;
                chkURBooking.Checked = false;
                chkURReserve.Checked = false;
                chkURSetup.Checked = false;
                chkURReports.Checked = false;
                txtURDesc.Focus();
            }
        }

        private void ClearAndEnableUserFields(bool isenabled = false)
        {
            txtLoginId.Enabled = isenabled;
            txtLoginPw.Enabled = isenabled;
            txtLoginPw1.Enabled = isenabled;
            txtAccessId.Enabled = isenabled;
            txtFName.Enabled = isenabled;
            txtMName.Enabled = isenabled;
            txtLName.Enabled = isenabled;
            cmbUARole.Enabled = isenabled;

            if (UAOperation != 1)
            {
                txtLoginId.Clear();
                txtLoginPw.Clear();
                txtLoginPw1.Clear();
                txtAccessId.Clear();
                txtFName.Clear();
                txtMName.Clear();
                txtLName.Clear();
                cmbUARole.SelectedValue = 0;
                txtLoginId.Focus();
            }
        }

        private void UserRoleTransaction(int t)
        {
            using(G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                G.spArr = new ArrayList();
                G.spArr.Add(new MySqlParameter("@rtype", t));
                G.spArr.Add(new MySqlParameter("@rid", SelectedURId));
                G.spArr.Add(new MySqlParameter("@rdesc", txtURDesc.Text));
                G.spArr.Add(new MySqlParameter("@a1", chkURLogin.Checked));
                G.spArr.Add(new MySqlParameter("@a2", chkURBooking.Checked));
                G.spArr.Add(new MySqlParameter("@a3", chkURReserve.Checked));
                G.spArr.Add(new MySqlParameter("@a4", true));
                G.spArr.Add(new MySqlParameter("@a5", chkURReports.Checked));
                G.spArr.Add(new MySqlParameter("@a6", chkURSetup.Checked));
                G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));

                if(t == 0 || t== 1|| t == 2)
                {
                    G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_tranuserroles(@rtype, @rid, @rdesc, @a1, @a2, @a3, @a4, @a5, @a6, @cid);", G.spArr);

                    if (t == 0 && G.AffectedDbRows > 0)
                    {
                        Logging.Activity("User " + G.CurrentUserName + " has created new role " + txtURDesc.Text + ".");
                        MessageBox.Show("Role " + txtURDesc.Text + " has been created successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tsbURAdd.Visible = true;
                        tsbUREdit.Visible = false;
                        tsbURSave.Visible = false;
                        tsbURCancel.Visible = false;
                        UROperation = -1;
                        ClearAndEnableUserRoleFields();
                    }
                    else if (t == 1 && G.AffectedDbRows > 0)
                    {
                        Logging.Activity("User " + G.CurrentUserName + " modified/updated role " + txtURDesc.Text + ".");
                        MessageBox.Show("Role " + txtURDesc.Text + " has been updated successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tsbURAdd.Visible = true;
                        tsbUREdit.Visible = false;
                        tsbURSave.Visible = false;
                        tsbURCancel.Visible = false;
                        UROperation = -1;
                        ClearAndEnableUserRoleFields();
                    }
                    else if(t == 2 && G.AffectedDbRows > 0)
                    {
                        Logging.Activity("User " + G.CurrentUserName + " deleted role " + txtURDesc.Text + ".");
                        MessageBox.Show("Role " + txtURDesc.Text + " has been removed successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tsbURAdd.Visible = true;
                        tsbUREdit.Visible = false;
                        tsbURSave.Visible = false;
                        tsbURCancel.Visible = false;
                        UROperation = -1;
                        ClearAndEnableUserRoleFields();
                    } else
                    {
                        Logging.Activity("Failed to create/update/delete role.");
                        MessageBox.Show("There is a problem creating/updating/removing role. Please contact your system provider for support.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (t == 3)
                {
                    G.dt = MyDb.GetResults(G.cn, "call sp_tranuserroles(@rtype, @rid, @rdesc, @a1, @a2, @a3, @a4, @a5, @a6, @cid);", G.spArr);
                    if (G.dt != null)
                    {
                        foreach(DataRow rw in G.dt.Rows)
                        {
                            SelectedURId = Convert.ToInt32(rw["id"]);
                            txtURDesc.Text = Convert.ToString(rw["roledesc"]);
                            chkURLogin.Checked = Convert.ToBoolean(rw["allowlogin"]);
                            chkURBooking.Checked = Convert.ToBoolean(rw["allowbilling"]);
                            chkURReserve.Checked = Convert.ToBoolean(rw["allowreserve"]);
                            chkURReports.Checked = Convert.ToBoolean(rw["allowcashier"]);
                            chkURSetup.Checked = Convert.ToBoolean(rw["allowsettings"]);
                        }
                    }
                }
                else if(t == 4) {
                    G.dt = MyDb.GetResults(G.cn, "call sp_tranuserroles(@rtype, @rid, @rdesc, @a1, @a2, @a3, @a4, @a5, @a6, @cid);", G.spArr);
                    if(G.dt != null) { dgvUR.DataSource = G.dt; }
                }
                LoadUserRoles();
            }
        }

        private void UserAccountTransaction(int t)
        {
            using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                G.spArr = new ArrayList();
                G.spArr.Add(new MySqlParameter("@rtype", t));
                G.spArr.Add(new MySqlParameter("@uid", SelectedUAId));
                G.spArr.Add(new MySqlParameter("@bcid", txtAccessId.Text));
                G.spArr.Add(new MySqlParameter("@lid", txtLoginId.Text));
                G.spArr.Add(new MySqlParameter("@lpw", txtLoginPw.Text));
                G.spArr.Add(new MySqlParameter("@lname", txtLName.Text));
                G.spArr.Add(new MySqlParameter("@fname", txtFName.Text));
                G.spArr.Add(new MySqlParameter("@mname", txtMName.Text));
                G.spArr.Add(new MySqlParameter("@rid", cmbUARole.SelectedValue));
                G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));

                if (t == 0 || t == 1 || t == 2)
                {
                    G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_tranusers(@rtype, @uid, @bcid, @lid, @lpw, @lname, @fname, @mname, @rid, @cid);", G.spArr);

                    if (t == 0 && G.AffectedDbRows > 0)
                    {
                        Logging.Activity("User " + G.CurrentUserName + " has created new user account " + txtLoginId.Text + " for " + txtFName.Text + " " + txtLName.Text);
                        MessageBox.Show("User Account " + txtLoginId.Text + " has been created successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tsbUAAdd.Visible = true;
                        tsbUAEdit.Visible = false;
                        tsbUASave.Visible = false;
                        tsbUACancel.Visible = false;
                        UAOperation = -1;
                        ClearAndEnableUserFields();
                    }
                    else if (t == 1 && G.AffectedDbRows > 0)
                    {
                        Logging.Activity("User " + G.CurrentUserName + " modified/updated role " + txtURDesc.Text + ".");
                        MessageBox.Show("User Account" + txtLoginId.Text + " for " + txtFName.Text + " " + txtLName.Text + " has been updated successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tsbUAAdd.Visible = true;
                        tsbUAEdit.Visible = false;
                        tsbUASave.Visible = false;
                        tsbUACancel.Visible = false;
                        UAOperation = -1;
                        ClearAndEnableUserFields();
                    }
                    else if (t == 2 && G.AffectedDbRows > 0)
                    {
                        Logging.Activity("User " + G.CurrentUserName + " deleted role " + txtURDesc.Text + ".");
                        MessageBox.Show("User Account " + txtLoginId.Text + " for " + txtFName.Text + " " + txtLName.Text + " has been removed successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tsbUAAdd.Visible = true;
                        tsbUAEdit.Visible = false;
                        tsbUASave.Visible = false;
                        tsbUACancel.Visible = false;
                        UAOperation = -1;
                        ClearAndEnableUserFields();
                    }
                    else
                    {
                        //Logging.Activity("Failed to create/update/delete User Account.");
                        //MessageBox.Show("There is a problem creating/updating/removing the user account. Please contact your system provider for support.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        if (t == 0 || t == 1)
                        {
                            Logging.Activity("Failed creating User Account " + txtLoginId.Text + " account already exists.");
                            MessageBox.Show("Unable to create/update account " + txtLoginId.Text + " the account already exists and/or disabled.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        if(t == 2)
                        {
                            Logging.Activity("Failed updating User Account " + txtLoginId.Text + " account already exists.");
                            MessageBox.Show("Unable to delete account " + txtLoginId.Text + ".", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
                else if (t == 3)
                {
                    G.dt = MyDb.GetResults(G.cn, "call sp_tranusers(@rtype, @uid, @bcid, @lid, @lpw, @lname, @fname, @mname, @rid, @cid);", G.spArr);
                    if (G.dt != null)
                    {
                        foreach (DataRow rw in G.dt.Rows)
                        {
                            SelectedUAId = Convert.ToInt32(rw["id"]);
                            txtAccessId.Text = Convert.ToString(rw["barcodeid"]);
                            txtLoginId.Text = Convert.ToString(rw["loginid"]);
                            txtFName.Text = Convert.ToString(rw["firstname"]);
                            txtLName.Text = Convert.ToString(rw["lastname"]);
                            txtMName.Text = Convert.ToString(rw["middlename"]);
                            cmbUARole.SelectedValue = Convert.ToInt32(rw["roleid"]);
                        }
                    }
                }
                else if (t == 4)
                {
                    G.dt = MyDb.GetResults(G.cn, "call sp_tranusers(@rtype, @uid, @bcid, @lid, @lpw, @lname, @fname, @mname, @rid, @cid);", G.spArr);
                    if (G.dt != null) { dgvUAList.DataSource = G.dt; }
                }
            }
        }

        private void LoadUserRoles()
        {
            using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                MyDb.LoadDataToComboBox(cmbUARole, "id", "roledesc", "call sp_getuserroles();", G.cn);
            }
        }

        private void tsbUAAdd_Click(object sender, EventArgs e)
        {
            UAOperation = 0;
            tsbUAAdd.Visible = false;
            tsbUASave.Visible = true;
            tsbUACancel.Visible = true;
            ClearAndEnableUserFields(true);
        }

        private void tsbUAEdit_Click(object sender, EventArgs e)
        {
            UAOperation = 1;
            tsbUAEdit.Visible = false;
            tsbUASave.Visible = true;
            tsbUACancel.Visible = true;
            ClearAndEnableUserFields(true);
        }

        private void tsbUASave_Click(object sender, EventArgs e)
        {
            if(txtLoginId.Text.Trim().Length == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save or update a user account with a blank Login Id.");
                MessageBox.Show("Login Id is required in order to process this user account. Please supply a value then try again.", "Invalid Login Id", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLoginId.Focus();
                return;
            }

            if(txtLoginId.Text.Trim().Length > 0 && txtLoginId.Text.Trim().Length < 6)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save or update a user account with a Login Id that does not meet the required length.");
                MessageBox.Show("Login Id supplied does not meet the required length. In order to process this user account, please supply a value with a minimum of 6 alphanumeric characters then try again.", "Invalid Login Id", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLoginId.Focus();
                return;
            }
            
            if(UAOperation != 1)
            {
                if(txtLoginPw.Text.Trim().Length == 0)
                {
                    Logging.Activity("User " + G.CurrentUserName + " attempts to save or update a user account with a blank Login Password.");
                    MessageBox.Show("Account Password is required in order to process this user account. Please supply a value then try again.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLoginPw.Focus();
                    return;
                }

                if (txtLoginPw.Text.Trim().Length > 0 && txtLoginPw.Text.Trim().Length < 6)
                {
                    Logging.Activity("User " + G.CurrentUserName + " attempts to save or update a user account with a Password that does not meet the required length.");
                    MessageBox.Show("Password supplied does not meet the required length. In order to process this user account, please supply a value with a minimum of 6 alphanumeric characters then try again.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLoginPw.Focus();
                    return;
                }

                if(txtLoginPw.Text != txtLoginPw1.Text)
                {
                    Logging.Activity("User " + G.CurrentUserName + " attempts to save or update a user account with a Password that does match with the Confirmation Password.");
                    MessageBox.Show("Password does not match. Please re-enter and cofirm your password for the account.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLoginPw.Focus();
                    return;
                }
            }

            if(UAOperation == 1)
            {
                if(txtLoginPw.Text.Trim().Length > 0)
                {
                    if (txtLoginPw.Text.Trim().Length > 0 && txtLoginPw.Text.Trim().Length < 6)
                    {
                        Logging.Activity("User " + G.CurrentUserName + " attempts to save or update a user account with a Password that does not meet the required length.");
                        MessageBox.Show("Password supplied does not meet the required length. In order to process this user account, please supply a value with a minimum of 6 alphanumeric characters then try again.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtLoginPw.Focus();
                        return;
                    }

                    if (txtLoginPw.Text != txtLoginPw1.Text)
                    {
                        Logging.Activity("User " + G.CurrentUserName + " attempts to save or update a user account with a Password that does match with the Confirmation Password.");
                        MessageBox.Show("Password does not match. Please re-enter and cofirm your password for the account.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtLoginPw.Focus();
                        return;
                    }
                }
            }

            if (Convert.ToInt16(cmbUARole.SelectedValue) == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save or update a user account without assiging a role for the account.");
                MessageBox.Show("Please select a role for the account.", "Invalid Role", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbUARole.Focus();
                return;
            }

            if(txtAccessId.Text.Trim().Length == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save or update a user account without assiging an Access Id for the account.");
                MessageBox.Show("Please supply a valid Access Id for the account.", "Invalid Access Id", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAccessId.Focus();
                return;
            }
            
            if(txtFName.Text.Trim().Length == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save or update a user account without supplying a First Name for the account holder.");
                MessageBox.Show("Please suppy a valid First Name of the account holder.", "Invalid Role", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFName.Focus();
                return;
            }

            if (txtLName.Text.Trim().Length == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save or update a user account without supplying a Last Name for the account holder.");
                MessageBox.Show("Please suppy a valid First Name of the account holder.", "Invalid Role", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLName.Focus();
                return;
            }

            if(UAOperation == 0 && MessageBox.Show("Save new user account for " + txtFName.Text + " " + txtLName.Text + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UserAccountTransaction(UAOperation);
                UserAccountTransaction(4);
            }

            if (UAOperation == 1 && MessageBox.Show("Save changes to user account " + txtFName.Text + " " + txtLName.Text + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UserAccountTransaction(UAOperation);
                UserAccountTransaction(4);
            }
        }

        private void tsbUACancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel current user operation?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Logging.Activity("User " + G.CurrentUserName + " cancels current user account operation.");
                UAOperation = -1;
                tsbUAAdd.Visible = true;
                tsbUAEdit.Visible = false;
                tsbUASave.Visible = false;
                tsbUACancel.Visible = false;
                ClearAndEnableUserFields();
            }
        }

        private void frmUserSetup_Load(object sender, EventArgs e)
        {
            ClearAndEnableUserFields();
            ClearAndEnableUserRoleFields();
            UserRoleTransaction(4);
            UserAccountTransaction(4);
            LoadUserRoles();
        }

        private void tsbURAdd_Click(object sender, EventArgs e)
        {
            UROperation = 0;
            ClearAndEnableUserRoleFields(true);
            tsbURAdd.Visible = false;
            tsbURSave.Visible = true;
            tsbURCancel.Visible = true;
        }

        private void tsbUREdit_Click(object sender, EventArgs e)
        {
            UROperation = 1;
            ClearAndEnableUserRoleFields(true);
            tsbUREdit.Visible = false;
            tsbURSave.Visible = true;
            tsbURCancel.Visible = true;
        }

        private void tsbURCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Cancel current role operation?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Logging.Activity("User " + G.CurrentUserName + " cancels current role operation.");
                UROperation = -1;
                tsbURAdd.Visible = true;
                tsbUREdit.Visible = false;
                tsbURSave.Visible = false;
                tsbURCancel.Visible = false;
                ClearAndEnableUserRoleFields();
            }
        }

        private void tsbURSave_Click(object sender, EventArgs e)
        {
            if(txtURDesc.Text.Trim().Length == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save a role information without supplying a valid Role Description. Saving failed.");
                MessageBox.Show("You must supply a valid Description for the role!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtURDesc.Focus();
                return;
            }

            if(chkURLogin.Checked == false && chkURBooking.Checked == false && chkURReserve.Checked == false && chkURReports.Checked == false && chkURSetup.Checked == false)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save a role information without giving the role at least signing in the system. Saving failed.");
                MessageBox.Show("You must supply at least [Allow System Login] access for the role!", "Insufficient Rights", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (UROperation == 0 && MessageBox.Show("Proceed adding new role " + txtURDesc.Text + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UserRoleTransaction(UROperation);
                UserRoleTransaction(4);
            }

            if (UROperation == 1 && MessageBox.Show("Save changes made to role " + txtURDesc.Text + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UserRoleTransaction(UROperation);
                UserRoleTransaction(4);
            }
        }

        private void dgvUR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                SelectedURId = Convert.ToInt16(dgvUR[2, e.RowIndex].Value);
                UserRoleTransaction(3);

                tsbURAdd.Visible = false;
                tsbUREdit.Visible = true;
                tsbURCancel.Visible = true;
            }

            if(e.ColumnIndex == 1)
            {
                if(MessageBox.Show("Are you sure you want to delete this role? Accounts under this role will be disabled. Continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SelectedURId = Convert.ToInt16(dgvUR[2, e.RowIndex].Value);
                    UserRoleTransaction(2);
                    UserRoleTransaction(4);
                }
            }
        }

        private void dgvUR_CellBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvUR.Columns[2].DataPropertyName = "id";
            dgvUR.Columns[3].DataPropertyName = "roledesc";
            for(int i = 4; i < dgvUR.Columns.Count -1; i++) { dgvUR.Columns[i].Visible = false; }
        }

        private void dgvUAList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    SelectedUAId = Convert.ToInt32(dgvUAList[2, e.RowIndex].Value);
                    tsbUAAdd.Visible = false;
                    tsbUAEdit.Visible = true;
                    tsbUASave.Visible = false;
                    tsbUACancel.Visible = true;
                    UserAccountTransaction(3);
                    break;

                case 1:
                    if(MessageBox.Show("Are you sure you want to remove user account " + txtFName.Text + " " + txtLName.Text + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SelectedUAId = Convert.ToInt32(dgvUAList[2, e.RowIndex].Value);
                        UserAccountTransaction(2);
                    }
                    break;

                default : break;
                     
            }
            
        }

        private void dgvUAList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvUAList.Columns[2].DataPropertyName = "id";
            dgvUAList.Columns[3].DataPropertyName = "guestname";
            for(int i = 4; i < dgvUAList.Columns.Count -1; i++) { dgvUAList.Columns[i].Visible = false; }
        }
    }
}
