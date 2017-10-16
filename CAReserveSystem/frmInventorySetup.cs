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
    public partial class frmInventorySetup : Form
    {
        private static int SelectedItemTypeId = 0;
        private static int SelectedItemId = 0;
        private static int ITypeOperation = -1;
        private static int ItemOperation = -1;

        public frmInventorySetup()
        {
            InitializeComponent();
        }

        private void ItemTypeTransaction(int t)
        {
            using(G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                if(G.cn != null)
                {
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@rtype", t));
                    G.spArr.Add(new MySqlParameter("@rtid", SelectedItemTypeId));
                    G.spArr.Add(new MySqlParameter("@itdesc",txtIType.Text));
                    G.spArr.Add(new MySqlParameter("@sparam", tstFind.Text));
                    G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));

                    if(t == 0 || t == 1 || t == 2)
                    {
                        G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_traninvtypes(@rtype, @rtid, @itdesc, @sparam, @cid);", G.spArr);

                        if(t == 0 && G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " added new Item Type " + txtIType.Text + ".");
                            MessageBox.Show("New item type " + txtIType.Text + " has been added successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (t == 1 && G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " updated Item Type " + txtIType.Text + ".");
                            MessageBox.Show("Item type " + txtIType.Text + " has been updated successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (t == 2 && G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " removed Item Type " + txtIType.Text + ".");
                            MessageBox.Show("Item type " + txtIType.Text + " has been removed successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Nothing to do here.
                        }
                    }
                    else if(t == 3)
                    {
                        G.dt = MyDb.GetResults(G.cn, "call sp_traninvtypes(@rtype, @rtid, @itdesc, @sparam, @cid);", G.spArr);
                        if(G.dt != null)
                        {
                            foreach(DataRow rw in G.dt.Rows) { txtIType.Text = rw["typedesc"].ToString(); }
                        }
                    }
                    else if(t == 4 || t == 5)
                    {
                        G.dt = MyDb.GetResults(G.cn, "call sp_traninvtypes(@rtype, @rtid, @itdesc, @sparam, @cid);", G.spArr);
                        dgvIT.AutoGenerateColumns = false;
                        dgvIT.DataSource = G.dt;
                    }
                    else
                    {
                        // Nothing to do here.
                    }
                }
            }
        }

        private void ItemTransaction(int t)
        {
            using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                if (G.cn != null)
                {
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@rtype", t));
                    G.spArr.Add(new MySqlParameter("@iid", SelectedItemId));
                    G.spArr.Add(new MySqlParameter("@itid", cmbIType.SelectedValue));
                    G.spArr.Add(new MySqlParameter("@icode", txtICode.Text));
                    G.spArr.Add(new MySqlParameter("@idesc", txtIDesc.Text));
                    G.spArr.Add(new MySqlParameter("@iprice", txtIPrice.Text));
                    G.spArr.Add(new MySqlParameter("@wdepo", chkDepo.Checked));
                    G.spArr.Add(new MySqlParameter("@depoamt", txtDepo.Text));
                    G.spArr.Add(new MySqlParameter("@sparam", tstIFind.Text));
                    G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));

                    if (t == 0 || t == 1 || t == 2)
                    {
                        G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_traninvitems(@rtype, @iid, @itid, @icode, @idesc, @iprice, @wdepo, @depoamt, @sparam, @cid);", G.spArr);

                        if (t == 0 && G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " added new Item " + txtIDesc.Text + ".");
                            MessageBox.Show("New item " + txtIDesc.Text + " has been added successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (t == 1 && G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " updated Item " + txtIDesc.Text + ".");
                            MessageBox.Show("Item " + txtIDesc.Text + " has been updated successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (t == 2 && G.AffectedDbRows > 0)
                        {
                            Logging.Activity("User " + G.CurrentUserName + " removed Item Type " + txtIDesc.Text + ".");
                            MessageBox.Show("Item " + txtIDesc.Text + " has been removed successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Nothing to do here.
                        }
                    }
                    else if (t == 3)
                    {
                        G.dt = MyDb.GetResults(G.cn, "call sp_traninvitems(@rtype, @iid, @itid, @icode, @idesc, @iprice, @wdepo, @depoamt, @sparam, @cid);", G.spArr);
                        if (G.dt != null)
                        {
                            foreach (DataRow rw in G.dt.Rows)
                            {
                                cmbIType.SelectedValue = Convert.ToInt32(rw["typeid"]);
                                txtICode.Text = Convert.ToString(rw["itemcode"]);
                                txtIDesc.Text = Convert.ToString(rw["itemdesc"]);
                                txtIPrice.Text = Convert.ToDouble(rw["price"]).ToString("###,##0.00");
                                chkDepo.Checked = Convert.ToBoolean(rw["withdeposit"]);
                                txtDepo.Text = Convert.ToDouble(rw["depositamt"]).ToString("###,##0.00");
                            }
                        }
                    }
                    else if (t == 4 || t == 5)
                    {
                        G.dt = MyDb.GetResults(G.cn, "call sp_traninvitems(@rtype, @iid, @itid, @icode, @idesc, @iprice, @wdepo, @depoamt, @sparam, @cid);", G.spArr);
                        dgvI.AutoGenerateColumns = false;
                        dgvI.DataSource = G.dt;
                    }
                    else
                    {
                        // Nothing to do here.
                    }
                }
            }
        }

        private void LoadItemTypes()
        {
            using(G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                if(G.cn != null) { MyDb.LoadDataToComboBox(cmbIType, "id", "typedesc", "call sp_getitemtypes();", G.cn); }
            }
        }

        private void frmInventorySetup_Load(object sender, EventArgs e)
        {
            ItemTypeTransaction(4);
            ItemTransaction(4);
            LoadItemTypes();
        }

        private void tsbITAdd_Click(object sender, EventArgs e)
        {
            ITypeOperation = 0;
            tsbITAdd.Visible = false;
            tsbITEdit.Visible = false;
            tsbITSave.Visible = true;
            tsbITCancel.Visible = true;
        }

        private void tsbITEdit_Click(object sender, EventArgs e)
        {
            ITypeOperation = 1;
            tsbITAdd.Visible = false;
            tsbITEdit.Visible = false;
            tsbITSave.Visible = true;
            tsbITCancel.Visible = true;
        }

        private void tsbITSave_Click(object sender, EventArgs e)
        {
            if(txtIType.Text.Trim().Length == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save/update an Item Type but fails to enter the type description.");
                MessageBox.Show("Type description cannot be empty. Please supply a valid entry then try again.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIType.Focus();
                return;
            }


            if(ITypeOperation == 0 && MessageBox.Show("Proceed adding new Item Type " + txtIType.Text + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ItemTypeTransaction(ITypeOperation);
                ItemTypeTransaction(4);
                tsbITCancel.PerformClick();

            }
            else if(ITypeOperation == 1 && MessageBox.Show("Save changes to Item Type?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ItemTypeTransaction(ITypeOperation);
                ItemTypeTransaction(4);
                tsbITCancel.PerformClick();
            }
            else
            {
                // Nothing to do here.
            }
        }

        private void tsbITCancel_Click(object sender, EventArgs e)
        {
            ITypeOperation = -1;
            SelectedItemTypeId = 0;
            tsbITAdd.Visible = true;
            tsbITEdit.Visible = false;
            tsbITSave.Visible = false;
            tsbITCancel.Visible = false;
            txtIType.Clear();
        }

        private void tstFind_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tsbFind.PerformClick();
            }
        }

        private void tsbFind_Click(object sender, EventArgs e)
        {
            ItemTypeTransaction(5);
        }

        private void dgvIT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                ITypeOperation = 1;
                SelectedItemTypeId = Convert.ToInt32(dgvIT[2, e.RowIndex].Value);
                ItemTypeTransaction(3);
                tsbITAdd.Visible = false;
                tsbITEdit.Visible = true;
                tsbITSave.Visible = false;
                tsbITCancel.Visible = true;
            }
            else if(e.ColumnIndex == 1)
            {
                if(MessageBox.Show("Are you sure you want to delete Item Type " + dgvIT[3, e.RowIndex].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SelectedItemTypeId = Convert.ToInt32(dgvIT[2, e.RowIndex].Value);
                    ItemTypeTransaction(2);
                    ItemTypeTransaction(4);
                    SelectedItemTypeId = 0;
                }
            }
            else
            {
                // Nothing to do here.
            }
        }

        private void dgvIT_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvIT.AutoGenerateColumns = false;
            dgvIT.Columns[2].DataPropertyName = "id";
            dgvIT.Columns[3].DataPropertyName = "typedesc";
        }

        private void tsbIAdd_Click(object sender, EventArgs e)
        {
            ItemOperation = 0;
            tsbIAdd.Visible = false;
            tsbIEdit.Visible = false;
            tsbISave.Visible = true;
            tsbICancel.Visible = true;

            cmbIType.SelectedValue = 0;
            txtICode.Clear();
            txtIDesc.Clear();
            txtIPrice.Text = "0.00";
            chkDepo.Checked = false;
            txtDepo.Text = "0.00";
        }

        private void tsbIEdit_Click(object sender, EventArgs e)
        {
            ItemOperation = 1;
            tsbIAdd.Visible = false;
            tsbIEdit.Visible = false;
            tsbISave.Visible = true;
            tsbICancel.Visible = true;
        }

        private void tsbISave_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(cmbIType.SelectedValue) == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save Item without selecting an Item Type.");
                MessageBox.Show("Unable to save item, an item type must be selected first.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbIType.Focus();
                return;
            }

            if (txtICode.Text.Trim().Length == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save Item without entering an Item Code.");
                MessageBox.Show("Unable to save item, an item code must be entered first.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtICode.Focus();
                return;
            }

            if (txtIDesc.Text.Trim().Length == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save Item without entering an Item Name.");
                MessageBox.Show("Unable to save item, an item name must be entered first.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDesc.Focus();
                return;
            }

            if(txtIPrice.Text.Trim().Length == 0)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save Item without entering a price for the item.");
                MessageBox.Show("Unable to save item, an item name must have at least a minimum price.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIPrice.Focus();
                return;
            }
            else
            {
                try
                {
                    double.Parse(txtIPrice.Text);
                }
                catch (Exception ex)
                {
                    Logging.Activity("User " + G.CurrentUserName + " attempts to save an item with an invalid price.");
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIPrice.Text = "0.00";
                    txtIPrice.Focus();
                    return;
                }
            }

            if (txtDepo.Text.Trim().Length == 0 && chkDepo.Checked == true)
            {
                Logging.Activity("User " + G.CurrentUserName + " attempts to save Item without entering a price for the item.");
                MessageBox.Show("Unable to save item, an item name must have at least a minimum price.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIPrice.Focus();
                return;
            }
            //else
            //{
            //    try
            //    {
            //        double.Parse(txtIPrice.Text);
            //    }
            //    catch (Exception ex)
            //    {
            //        Logging.Activity("User " + G.CurrentUserName + " attempts to save an item with an invalid price.");
            //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txtIPrice.Text = "0.00";
            //        txtIPrice.Focus();
            //        return;
            //    }
            //}

            if(ItemOperation == 0 && MessageBox.Show("Add new item " + txtIDesc.Text + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ItemTransaction(0);
                ItemTransaction(4);
                tsbICancel.PerformClick();
            }

            if (ItemOperation == 1 && MessageBox.Show("Save changes to item " + txtIDesc.Text + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ItemTransaction(1);
                ItemTransaction(4);
                tsbICancel.PerformClick();
            }
        }

        private void tsbICancel_Click(object sender, EventArgs e)
        {
            ItemOperation = -1;
            tsbIAdd.Visible = true;
            tsbIEdit.Visible = false;
            tsbISave.Visible = false;
            tsbICancel.Visible = false;

            cmbIType.SelectedValue = 0;
            txtICode.Clear();
            txtIDesc.Clear();
            txtIPrice.Text = "0.00";
            chkDepo.Checked = false;
            txtDepo.Text = "0.00";
            ItemTransaction(4);
        }

        private void tstIFind_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tsbIFind.PerformClick();
            }
        }

        private void tsbIFind_Click(object sender, EventArgs e)
        {
            ItemTransaction(5);
        }

        private void dgvI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                ItemOperation = 1;
                SelectedItemId = Convert.ToInt32(dgvI[2, e.RowIndex].Value);
                ItemTransaction(3);
                tsbIAdd.Visible = false;
                tsbIEdit.Visible = true;
                tsbISave.Visible = false;
                tsbICancel.Visible = true;
            }
            else if(e.ColumnIndex == 1)
            {
                if(MessageBox.Show("Are you sure you want to remove item " + dgvI[4, e.RowIndex].Value.ToString() + "?", "Confim", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SelectedItemId = Convert.ToInt32(dgvI[2, e.RowIndex].Value);
                    ItemTransaction(2);
                    ItemTransaction(4);
                    tsbICancel.PerformClick();
                }
            }
            else
            {
                // Nothing to do here.
            }
        }

        private void dgvI_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvI.AutoGenerateColumns = false;
            dgvI.Columns[2].DataPropertyName = "id";
            dgvI.Columns[3].DataPropertyName = "itemcode";
            dgvI.Columns[4].DataPropertyName = "itemdesc";
        }

    }
}
