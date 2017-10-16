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
    public partial class frmBPayment : Form
    {
        private static decimal SubTotal = 0;
        private static decimal TenderedAmt = 0;

        public frmBPayment()
        {
            InitializeComponent();
        }

        private void frmBPayment_Load(object sender, EventArgs e)
        {
            txtTendered.Focus();
            if(G.SelectedBID > 0)
            {
                using(G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                {
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@bid", G.SelectedBID));
                    G.dt = MyDb.GetResults(G.cn, "call sp_getbookinginfo(@bid);", G.spArr);

                    if(G.dt != null)
                    {
                        foreach(DataRow rw in G.dt.Rows)
                        {
                            txtGuestName.Text = rw["guestname"].ToString();
                            txtAcc.Text = rw["room"].ToString();
                            Logging.Activity("Loading payment information for guest " + txtGuestName.Text + ".");
                        }
                        G.dt = null;
                    }

                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@bid", G.SelectedBID));
                    G.dt = MyDb.GetResults(G.cn, "call sp_getitemsforpayment(@bid);", G.spArr);

                    if(G.dt != null)
                    {
                        Logging.Activity("Loading payment payment items for guest " + txtGuestName.Text + ".");
                        dgvItems.DataSource = G.dt;
                        dgvItems.AutoGenerateColumns = false;

                        foreach(DataRow rw in G.dt.Rows)
                        {
                            SubTotal = SubTotal + Convert.ToDecimal(rw["itemamt"]);
                        }
                        lblSubTotal1.Text = SubTotal.ToString("###,###,##0.00");
                        if(SubTotal == 0) { btnSettle.Enabled = false; txtTendered.ReadOnly = true; }
                        Logging.Activity("Loading payment payment items for guest " + txtGuestName.Text + "... Loaded.");
                    }
                    else
                    {
                        btnSettle.Enabled = false;
                    }
                }
            }
        }

        private void frmBPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            SubTotal = 0;
            TenderedAmt = 0;
            txtTendered.Text = "0.00";
        }

        private void dgvItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if(G.dt != null)
            {
                dgvItems.AutoGenerateColumns = false;
                dgvItems.Columns[0].DataPropertyName = "id";
                dgvItems.Columns[1].DataPropertyName = "bkid";
                dgvItems.Columns[2].DataPropertyName = "itemtype";
                dgvItems.Columns[3].DataPropertyName = "itemdesc";
                dgvItems.Columns[4].DataPropertyName = "itemqty";
                dgvItems.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvItems.Columns[5].DataPropertyName = "itemamt";
                dgvItems.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvItems.Columns[5].DefaultCellStyle.Format="###,###,##0.00";
                dgvItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                if(dgvItems.Columns.Count > 6)
                {
                    for(int i = 6; i < dgvItems.Columns.Count; i++)
                    {
                        dgvItems.Columns[i].Visible = false;
                    }
                }
            }
        }

        private void btnSettle_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtTendered.Text, out TenderedAmt);
            if(TenderedAmt == 0)
            {
                Logging.Activity("Amount entered is invalid a numeric value is expected but " + txtTendered.Text + " supplied.");
                MessageBox.Show("Invalid amount entered for tendered/received amount. Please supply a valid amount then try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(MessageBox.Show("You received " + txtTendered.Text + " from guest to settle " + lblSubTotal1.Text + ". Please confirm payment settlement.", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using(G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                {
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@bid", G.SelectedBID));
                    G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_settlepayment(@bid);", G.spArr);

                    if(G.AffectedDbRows > 0)
                    {
                        Logging.Activity("User " + G.CurrentUserName + " received the amount of " + txtTendered.Text + " settled payment for " + txtGuestName.Text + " amounting to " + lblSubTotal1.Text + ".");
                        MessageBox.Show("Payment settlement succeeded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    } else
                    {
                        Logging.Activity("Settling of payment for " + txtGuestName.Text + " failed.");
                        MessageBox.Show("Payment settlement failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void txtTendered_TextChanged(object sender, EventArgs e)
        {
            if (txtTendered.Text == "" || txtTendered.Text == "0.00")
            {
                txtTendered.Text = "0.00";
                lblChange1.Text = "0.00";
            }
            else
            {
                lblChange1.Text = (Convert.ToDecimal(txtTendered.Text) - Convert.ToDecimal(lblSubTotal1.Text)).ToString("###,###,##0.00");
            }
            
        }
    }
}
