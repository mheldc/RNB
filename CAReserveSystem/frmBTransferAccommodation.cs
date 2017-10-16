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
    public partial class frmBTransferAccommodation : Form
    {
        decimal cAccRate = 0;
        decimal nAccRate = 0;
        bool isOvernight = false;
        bool preLoad = true;
        Int32 RTID = 0;
        Int32 RID = 0;

        public frmBTransferAccommodation()
        {
            InitializeComponent();
        }

        private void LoadAccommodationTypes()
        {
            using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
            {
                MyDb.LoadDataToComboBox(cmbAccType, "rtid", "rtdesc", "call `sp_getaccommodationtypes`;", G.cn);
            }
        }

        private void frmBTransferAccommodation_Load(object sender, EventArgs e)
        {
            G.spArr = new ArrayList();
            G.spArr.Add(new MySqlParameter("@bid", Convert.ToInt32(G.SelectedBID)));
            G.dt = MyDb.GetResults(G.cn, "call sp_getbookinginfo(@bid);", G.spArr);

            if (G.dt != null)
            {
                foreach (DataRow rw in G.dt.Rows)
                {
                    txtGuestName.Text = rw["guestname"].ToString();
                    txtAcc.Text = rw["room"].ToString();
                    lblAccBRate1.Text = rw["ratebase"].ToString();
                    cAccRate = Convert.ToDecimal(rw["roomrate"]);
                    isOvernight = Convert.ToBoolean(rw["isovernight"]);
                    RTID = Convert.ToInt32(rw["rtid"]);
                    RID = Convert.ToInt32(rw["rid"]);

                    Logging.Activity("Loading payment information for guest " + txtGuestName.Text + ".");
                }
                G.dt = null;
            }

            LoadAccommodationTypes();
            preLoad = false;
        }

        private void cmbAccType_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                {
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@rtid", cmbAccType.SelectedValue));
                    MyDb.LoadDataToComboBox(cmbNewAcc, "rid", "rdesc", "call sp_getaccommodations(@rtid);", G.cn, G.spArr);
                }
            }
            catch (Exception)
            {

            }

        }

        private void cmbNewAcc_SelectedValueChanged(object sender, EventArgs e)
        {
            if(preLoad == false)
            {
                using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                {
                    try
                    {

                        G.spArr = new ArrayList();
                        G.spArr.Add(new MySqlParameter("@rtid", cmbAccType.SelectedValue));
                        G.spArr.Add(new MySqlParameter("@rid", cmbNewAcc.SelectedValue));
                        G.spArr.Add(new MySqlParameter("@isovn", isOvernight));
                        G.dt = MyDb.GetResults(G.cn, "call sp_getaccommodationfortransfer(@rtid, @rid, @isovn);", G.spArr);

                        if(G.dt != null)
                        {
                            foreach(DataRow rw in G.dt.Rows)
                            {
                                txtAccFee.Text = Convert.ToDecimal(rw["roomrate"]).ToString("###,##0.00");
                                nAccRate = Convert.ToDecimal(rw["roomrate"]);

                                txtAccBal.Text = Convert.ToDecimal((nAccRate - cAccRate)).ToString("###,##0.00");
                            }
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void btnAccTransfer_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(cmbAccType.SelectedValue) == 0 || Convert.ToInt32(cmbNewAcc.SelectedValue) == 0)
            {
                MessageBox.Show("Please select New Accommodation to transfer.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if(txtReason.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please provide a valid reason for the transfer of accommodation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtReason.Focus();
                return;
            }

            if (nAccRate < cAccRate && MessageBox.Show("Warning : Accommodation downgrading is not allowed, seek approval first with the manager then click Yes to proceed. Proceed?", "Confirn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                {
                    // Insert entry in Booking Transfer
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@bkid", G.SelectedBID));
                    G.spArr.Add(new MySqlParameter("@frtid", RTID));
                    G.spArr.Add(new MySqlParameter("@frid", RID));
                    G.spArr.Add(new MySqlParameter("@frate", cAccRate));
                    G.spArr.Add(new MySqlParameter("@nrtid", cmbAccType.SelectedValue));
                    G.spArr.Add(new MySqlParameter("@nrid", cmbNewAcc.SelectedValue));
                    G.spArr.Add(new MySqlParameter("@nrate", Convert.ToDouble(txtAccFee.Text)));
                    G.spArr.Add(new MySqlParameter("@trem", txtReason.Text));
                    G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));
                    G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_tranaccommodationtransfer(@bkid, @frtid, @frid, @frate, @nrtid, @nrid, @nrate, @trem, @cid);", G.spArr);

                    // Insert entry in Booking Items for Accommodation Transfer
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@bid", G.SelectedBID));
                    G.spArr.Add(new MySqlParameter("@typeid", 0));
                    G.spArr.Add(new MySqlParameter("@itype", 1));
                    G.spArr.Add(new MySqlParameter("@idesc", "Transfer Accommodation : " + txtAcc.Text + " to " + cmbNewAcc.Text + " Refund : " + Convert.ToDouble(cAccRate - nAccRate).ToString("###,##0.00")));
                    G.spArr.Add(new MySqlParameter("@iqty", 1));
                    G.spArr.Add(new MySqlParameter("@iamt", Convert.ToDecimal(0)));
                    G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));
                    G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_tranbookingitems(@bid, @typeid, @itype, @idesc, @iqty, @iamt, @cid);", G.spArr);

                    // Update Booking for Accommodation Transfer
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@bid", G.SelectedBID));
                    G.spArr.Add(new MySqlParameter("@rtid", Convert.ToInt32(cmbAccType.SelectedValue)));
                    G.spArr.Add(new MySqlParameter("@rid", Convert.ToInt32(cmbNewAcc.SelectedValue)));
                    G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));
                    G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_updatebookingaccommodation(@bid, @rtid, @rid, @cid);", G.spArr);

                    // Insert entry for Refund.
                    G.spArr = new ArrayList();
                    G.spArr.Add(new MySqlParameter("@rtype", Convert.ToInt32(cmbNewAcc.SelectedValue)));
                    G.spArr.Add(new MySqlParameter("@bid", G.SelectedBID));
                    G.spArr.Add(new MySqlParameter("@tid", Convert.ToInt32(cmbAccType.SelectedValue)));
                    G.spArr.Add(new MySqlParameter("@itid", Convert.ToInt32(cmbNewAcc.SelectedValue)));
                    G.spArr.Add(new MySqlParameter("@itname", Convert.ToInt32(cmbAccType.SelectedValue)));
                    G.spArr.Add(new MySqlParameter("@refamt", Convert.ToInt32(cmbNewAcc.SelectedValue)));                   
                    G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));
                    G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_tranrefunditems(@rtype, @bid, @tid, @itid, @itname, @refamt, @cid);", G.spArr);
                }

                if (G.AffectedDbRows > 0) { MessageBox.Show("Transfer complete. Please give guest the Accommodation refund of P " + Convert.ToDouble(cAccRate - nAccRate).ToString("###,##0.00"), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Close(); }
            }
            else
            {
                if(MessageBox.Show("Confirm process of transfer accommodation?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                    {
                        // Insert entry in Booking Transfer
                        G.spArr = new ArrayList();
                        G.spArr.Add(new MySqlParameter("@bkid", G.SelectedBID));
                        G.spArr.Add(new MySqlParameter("@frtid", RTID));
                        G.spArr.Add(new MySqlParameter("@frid", RID));
                        G.spArr.Add(new MySqlParameter("@frate", cAccRate));
                        G.spArr.Add(new MySqlParameter("@nrtid", cmbAccType.SelectedValue));
                        G.spArr.Add(new MySqlParameter("@nrid", cmbNewAcc.SelectedValue));
                        G.spArr.Add(new MySqlParameter("@nrate", Convert.ToDouble(txtAccFee.Text)));
                        G.spArr.Add(new MySqlParameter("@trem", txtReason.Text));
                        G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));
                        G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_tranaccommodationtransfer(@bkid, @frtid, @frid, @frate, @nrtid, @nrid, @nrate, @trem, @cid);", G.spArr);

                        // Insert entry in Booking Items for Accommodation Transfer
                        G.spArr = new ArrayList();
                        G.spArr.Add(new MySqlParameter("@bid", G.SelectedBID));
                        G.spArr.Add(new MySqlParameter("@typeid", 0));
                        G.spArr.Add(new MySqlParameter("@itype", 1));
                        G.spArr.Add(new MySqlParameter("@idesc", "Transfer Accommodation : " + txtAcc.Text + " to " + cmbNewAcc.Text + " Balance to pay : " + Convert.ToDouble(nAccRate - cAccRate).ToString("###,##0.00")));
                        G.spArr.Add(new MySqlParameter("@iqty", 1));
                        G.spArr.Add(new MySqlParameter("@iamt", Convert.ToDecimal(nAccRate - cAccRate)));
                        G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));
                        G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_tranbookingitems(@bid, @typeid, @itype, @idesc, @iqty, @iamt, @cid);", G.spArr);

                        // Update Booking for Accommodation Transfer
                        G.spArr = new ArrayList();
                        G.spArr.Add(new MySqlParameter("@bid", G.SelectedBID));
                        G.spArr.Add(new MySqlParameter("@rtid", Convert.ToInt32(cmbAccType.SelectedValue)));
                        G.spArr.Add(new MySqlParameter("@rid", Convert.ToInt32(cmbNewAcc.SelectedValue)));
                        G.spArr.Add(new MySqlParameter("@cid", G.CurrentUserId));
                        G.AffectedDbRows = MyDb.ExecSQL(G.cn, "call sp_updatebookingaccommodation(@bid, @rtid, @rid, @cid);", G.spArr);
                    }

                    if(G.AffectedDbRows > 0) { MessageBox.Show("Transfer complete. Please make sure that balance have been paid first before transferring guest to new accommodation.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Close(); }
                }
            }
        }
    }
}
