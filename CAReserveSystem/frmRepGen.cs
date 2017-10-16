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
using CAReserveSystem.reports;
using MySql.Data.MySqlClient;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;

namespace CAReserveSystem
{
    public partial class frmRepGen : Form
    {
        public frmRepGen()
        {
            InitializeComponent();
        }

        private void frmRepGen_Load(object sender, EventArgs e)
        {
            if(G.ReportType == 1)
            {
                cmbRptGen.Items.Clear();
                cmbRptGen.Items.Add("- Select a Report -");
                cmbRptGen.Items.Add("Sales Report per Accommodation");
                cmbRptGen.Items.Add("Sales Report per Cashier");
                cmbRptGen.SelectedIndex = 0;
            }

            if(G.ReportType == 2)
            {
                cmbRptGen.Items.Clear();
                cmbRptGen.Items.Add("- Select a Report -");
                cmbRptGen.Items.Add("Booking Report");
                cmbRptGen.SelectedIndex = 0;
            }

            if(G.ReportType == 3)
            {
                cmbRptGen.Items.Clear();
                cmbRptGen.Items.Add("- Select a Report -");
                cmbRptGen.Items.Add("Inventory Report");
                cmbRptGen.SelectedIndex = 0;
            }

            if(Directory.Exists(@"C:\CA-Report") == false) { Directory.CreateDirectory(@"C:\CA-Report"); }

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if(cmbRptGen.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a report to generate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if(dtpPStart.Value > dtpPEnd.Value)
            {
                MessageBox.Show("Report period is invalid. Please select a valid range for the report period.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if(G.ReportType == 1)
            {
                if(cmbRptGen.SelectedIndex == 1)
                {
                    if(File.Exists(@"C:\CA-Report\SalesReportPerAccommodation-" + DateTime.Now.ToString("yyyyMMdd") + ".pdf") == true)
                    {
                        File.Delete(@"C:\CA-Report\SalesReportPerAccommodation-" + DateTime.Now.ToString("yyyyMMdd") + ".pdf");
                    }

                    try
                    {
                        using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                        {
                            G.spArr = new ArrayList();
                            G.spArr.Add(new MySqlParameter("@df", dtpPStart.Value));
                            G.spArr.Add(new MySqlParameter("@dt", dtpPEnd.Value));
                            G.dt = MyDb.GetResults(G.cn, "call sp_reportperaccommodation( @df, @dt);", G.spArr);

                            SalesReportPerAccommodation r = new SalesReportPerAccommodation();
                            r.Load();
                            r.SetDataSource(G.dt);
                            r.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"C:\CA-Report\SalesReportPerAccommodation-" + DateTime.Now.ToString("yyyyMMdd") + ".pdf");
                            MessageBox.Show(@"Report have been generated successfully. Report file can be viewed in C:\CA-Report folder.","Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }

                if(cmbRptGen.SelectedIndex == 2)
                {
                    if (File.Exists(@"C:\CA-Report\SalesReportPerCashier-" + DateTime.Now.ToString("yyyyMMdd") + ".pdf") == true)
                    {
                        File.Delete(@"C:\CA-Report\SalesReportPerCashier-" + DateTime.Now.ToString("yyyyMMdd") + ".pdf");
                    }

                    try
                    {
                        using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                        {
                            G.spArr = new ArrayList();
                            G.spArr.Add(new MySqlParameter("@df", dtpPStart.Value));
                            G.spArr.Add(new MySqlParameter("@dt", dtpPEnd.Value));
                            G.dt = MyDb.GetResults(G.cn, "call sp_reportpercashier( @df, @dt);", G.spArr);

                            SalesReportPerCashier r = new SalesReportPerCashier();
                            r.Load();
                            r.SetDataSource(G.dt);
                            r.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"C:\CA-Report\SalesReportPerCashier-" + DateTime.Now.ToString("yyyyMMdd") + ".pdf");
                            MessageBox.Show(@"Report have been generated successfully. Report file can be viewed in C:\CA-Report folder.", "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }

            if(G.ReportType == 2 && cmbRptGen.SelectedIndex == 1)
            {
                if (File.Exists(@"C:\CA-Report\BookingSummary-" + DateTime.Now.ToString("yyyyMMdd") + ".pdf") == true)
                {
                    File.Delete(@"C:\CA-Report\BookingSummary-" + DateTime.Now.ToString("yyyyMMdd") + ".pdf");
                }

                try
                {
                    using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                    {
                        G.spArr = new ArrayList();
                        G.spArr.Add(new MySqlParameter("@df", dtpPStart.Value));
                        G.spArr.Add(new MySqlParameter("@dt", dtpPEnd.Value));
                        G.dt = MyDb.GetResults(G.cn, "call sp_bookingsummary( @df, @dt);", G.spArr);

                        BookingSummary r = new BookingSummary();
                        r.Load();
                        r.SetDataSource(G.dt);
                        r.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"C:\CA-Report\BookingSummaryReport-" + DateTime.Now.ToString("yyyyMMdd") + ".pdf");
                        MessageBox.Show(@"Report have been generated successfully. Report file can be viewed in C:\CA-Report folder.", "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            if(G.ReportType == 3 && cmbRptGen.SelectedIndex == 1)
            {
                if (File.Exists(@"C:\CA-Report\InventoryReport-" + DateTime.Now.ToString("yyyyMMdd") + ".pdf") == true)
                {
                    File.Delete(@"C:\CA-Report\InventoryReport-" + DateTime.Now.ToString("yyyyMMdd") + ".pdf");
                }

                try
                {
                    using (G.cn = MyDb.Open(G.DefaultHost, G.DefaultDb, G.DefaultId, G.DefaultPw, G.DefaultPort))
                    {
                        G.spArr = new ArrayList();
                        G.spArr.Add(new MySqlParameter("@df", dtpPStart.Value));
                        G.spArr.Add(new MySqlParameter("@dt", dtpPEnd.Value));
                        G.dt = MyDb.GetResults(G.cn, "call sp_inventoryreport( @df, @dt);", G.spArr);

                        InventoryReport r = new InventoryReport();
                        r.Load();
                        r.SetDataSource(G.dt);
                        r.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"C:\CA-Report\InventoryReport-" + DateTime.Now.ToString("yyyyMMdd") + ".pdf");
                        MessageBox.Show(@"Report have been generated successfully. Report file can be viewed in C:\CA-Report folder.", "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

        }
    }
}
