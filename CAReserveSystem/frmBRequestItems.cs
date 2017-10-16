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
    public partial class frmBRequestItems : Form
    {
        bool preLoad = true;

        public frmBRequestItems()
        {
            InitializeComponent();
        }

        private void RequestItemsTransaction(int t)
        {
            using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                G.spArr = new ArrayList();
                G.spArr.Add(new MySqlParameter("@rtype", t));
                G.spArr.Add(new MySqlParameter("@bid", G.SelectedBID));
                G.spArr.Add(new MySqlParameter("@itype", Convert.ToInt32(cmbIType.SelectedValue)));
                G.spArr.Add(new MySqlParameter("@iid", Convert.ToInt32(cmbItem.SelectedValue)));
                G.spArr.Add(new MySqlParameter("@idesc", cmbItem.Text));
                G.spArr.Add(new MySqlParameter("@iqty", Convert.ToInt32(txtQty.Text)));
                G.spArr.Add(new MySqlParameter("@iamt", Convert.ToDecimal(txtST.Text)));

                if (t == 0 || t == 1 || t == 2 || t == 6)
                {
                    G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_tranreqitems(@rtype, @bid, @itype, @iid, @idesc, @iqty, @iamt);", G.spArr);

                    //if(t == 0) { MessageBox.Show("Item " + cmbItem.Text + " has been added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else if(t == 3 || t == 4)
                {
                    G.dt = MyDb.GetResults(G.cn, "call sp_tranreqitems(@rtype, @bid, @itype, @iid, @idesc, @iqty, @iamt);", G.spArr);
                    dgvRIList.AutoGenerateColumns = false;
                    dgvRIList.DataSource = G.dt;

                    decimal totalvalue = 0;
                    if(G.dt != null)
                    {
                        foreach(DataRow rw in G.dt.Rows)
                        {
                            totalvalue = totalvalue + Convert.ToDecimal(rw["itemamt"]);
                        }
                    }
                    txtTotalValue.Text = totalvalue.ToString("###,##0.00");
                }
                else
                {
                    // Nothing to do here.
                }
            }
        }

        private void LoadItemTypes()
        {
            using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                MyDb.LoadDataToComboBox(cmbIType, "id", "typedesc", "call sp_getitemtypes();", G.cn);
            }
        }

        private void LoadItems(Int32 tid)
        {
            using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                G.spArr = new ArrayList();
                G.spArr.Add(new MySqlParameter("@itype", tid));
                MyDb.LoadDataToComboBox(cmbItem, "id", "itemdesc", "call sp_getitems(@itype);", G.cn, G.spArr);
            }
        }

        private void LoadItemData(Int32 iid)
        {
            using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                G.spArr = new ArrayList();
                G.spArr.Add(new MySqlParameter("@iid", iid));
                G.dt = MyDb.GetResults(G.cn, "call sp_getiteminfo(@iid);", G.spArr);
                if(G.dt != null)
                {
                    foreach(DataRow rw in G.dt.Rows)
                    {
                        txtPrice.Text = Convert.ToDecimal(rw["price"]).ToString("###,##0.00");
                        chkDP.Checked = Convert.ToBoolean(rw["withdeposit"]);
                        txtDP.Text = Convert.ToDecimal(rw["depositamt"]).ToString("###,##0.00");
                    }
                }
            }
        }

        private void frmBRequestItems_Load(object sender, EventArgs e)
        {
            using(G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
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

            LoadItemTypes();
            preLoad = false;
        }

        private void dgvRIList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0 && MessageBox.Show("Are you sure you want to remove " + dgvRIList[4, e.RowIndex].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RequestItemsTransaction(2);
                RequestItemsTransaction(4);
            }
        }

        private void dgvRIList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvRIList.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvRIList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void cmbIType_SelectedValueChanged(object sender, EventArgs e)
        {
            try { LoadItems(Convert.ToInt32(cmbIType.SelectedValue.ToString())); }
            catch (Exception) { }
            
        }

        private void cmbItem_SelectedValueChanged(object sender, EventArgs e)
        {
            if(preLoad == false)
            {
                try { LoadItemData(Convert.ToInt32(cmbItem.SelectedValue.ToString())); txtQty.Focus(); }
                catch (Exception) { }
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtQty.Text);
                txtST.Text = Convert.ToDecimal(Convert.ToInt32(txtQty.Text) * Convert.ToDecimal(txtPrice.Text)).ToString("###,##0.00");
            }
            catch (Exception)
            { MessageBox.Show("Invalid quantity supplied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if(txtQty.Text == "0" || txtQty.Text.Trim().Length == 0)
            {
                MessageBox.Show("Invalid quantity for item. Please enter a valid quantity then try adding the item again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            MessageBox.Show("Note: For Non-Consumable Items. Please make sure that the item/s requested by the guest is/are available before entering it into the system.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if(MessageBox.Show("Proceed adding item " + cmbItem.Text + " to list?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RequestItemsTransaction(0);
                RequestItemsTransaction(4);
                txtQty.Text = "0";
                txtPrice.Text = "0.00";
                txtST.Text = "0.00";
                cmbItem.SelectedValue = 0;
            }
        }

        private void btnProcessRI_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Process requested items for payment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using(G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                {
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@bid", G.SelectedBID));
                    G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));
                    G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_transferritobi(@bid, @cid);", G.spArr);

                    if(G.AffectedDbRows > 0)
                    {
                        MessageBox.Show("Items have been processed. Please advise guest to pay the items first to the cashier.", "Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }
    }
}
