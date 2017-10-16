using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_Board
{
    public partial class frmSvcBoard : Form
    {
        public frmSvcBoard()
        {
            InitializeComponent();
        }

        private void frmSvcBoard_Load(object sender, EventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            Rectangle rec = new Rectangle(50, 100, 150, 150);
            SolidBrush sbr = new SolidBrush(Color.Yellow);
            
            gr.DrawEllipse(Pens.Black, rec);
            gr.DrawRectangle(Pens.Red, rec);
        }

        private void dgvSvc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSvc_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int calculatedWidth = 0;
            for(int i = 0; i < dgvSvc.Columns.Count - 1; i++)
            {
                if(dgvSvc.Columns[i].Visible == true && i != 2 )
                {
                    calculatedWidth += dgvSvc.Columns[i].Width;
                }
            }

            dgvSvc.Columns[2].Width = ((dgvSvc.Width - 50) - calculatedWidth);   
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void tspCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tspCbo.SelectedIndex == 0)
            {
                lblStatus.Text = "Total Pending Queues : " + dgvSvc.Rows.Count.ToString();
            }
            else if (tspCbo.SelectedIndex == 1)
            {
                lblStatus.Text = "Total Served Queues : " + dgvSvc.Rows.Count.ToString();
            }
            else
            {
                lblStatus.Text = "";
            }
        }
    }
}
