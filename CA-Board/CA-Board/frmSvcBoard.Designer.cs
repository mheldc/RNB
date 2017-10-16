namespace CA_Board
{
    partial class frmSvcBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSvcBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvSvc = new System.Windows.Forms.DataGridView();
            this.imgBtn = new System.Windows.Forms.ImageList(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsplblLQ = new System.Windows.Forms.ToolStripLabel();
            this.tspCbo = new System.Windows.Forms.ToolStripComboBox();
            this.SvcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SvcGuest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SvcMsg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SvcDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SvcBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SvcDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.served = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SvcNow = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSvc)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 41);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 35);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvSvc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(725, 389);
            this.panel3.TabIndex = 2;
            // 
            // dgvSvc
            // 
            this.dgvSvc.AllowUserToAddRows = false;
            this.dgvSvc.AllowUserToDeleteRows = false;
            this.dgvSvc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSvc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SvcId,
            this.SvcGuest,
            this.SvcMsg,
            this.SvcDT,
            this.SvcBy,
            this.SvcDuration,
            this.served,
            this.SvcNow});
            this.dgvSvc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSvc.Location = new System.Drawing.Point(0, 0);
            this.dgvSvc.Name = "dgvSvc";
            this.dgvSvc.ReadOnly = true;
            this.dgvSvc.Size = new System.Drawing.Size(725, 389);
            this.dgvSvc.TabIndex = 0;
            this.dgvSvc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSvc_CellContentClick);
            this.dgvSvc.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSvc_DataBindingComplete);
            // 
            // imgBtn
            // 
            this.imgBtn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgBtn.ImageStream")));
            this.imgBtn.TransparentColor = System.Drawing.Color.Transparent;
            this.imgBtn.Images.SetKeyName(0, "accept_document.png");
            this.imgBtn.Images.SetKeyName(1, "account_functions.png");
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(122, 14);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Total Pending Queues : ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspBtnRefresh,
            this.tspCbo,
            this.tsplblLQ});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(725, 41);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tspBtnRefresh
            // 
            this.tspBtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspBtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tspBtnRefresh.Image")));
            this.tspBtnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspBtnRefresh.Name = "tspBtnRefresh";
            this.tspBtnRefresh.Size = new System.Drawing.Size(36, 38);
            this.tspBtnRefresh.Text = "toolStripButton1";
            this.tspBtnRefresh.ToolTipText = "Refresh";
            // 
            // tsplblLQ
            // 
            this.tsplblLQ.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsplblLQ.Name = "tsplblLQ";
            this.tsplblLQ.Size = new System.Drawing.Size(76, 38);
            this.tsplblLQ.Text = "Load Queues";
            // 
            // tspCbo
            // 
            this.tspCbo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tspCbo.Items.AddRange(new object[] {
            "Active / Open",
            "Served"});
            this.tspCbo.Name = "tspCbo";
            this.tspCbo.Size = new System.Drawing.Size(121, 41);
            this.tspCbo.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            this.tspCbo.SelectedIndexChanged += new System.EventHandler(this.tspCbo_SelectedIndexChanged);
            //              
            // SvcId
            // 
            this.SvcId.DataPropertyName = "svcid";
            this.SvcId.HeaderText = "Id";
            this.SvcId.Name = "SvcId";
            this.SvcId.ReadOnly = true;
            this.SvcId.Visible = false;
            // 
            // SvcGuest
            // 
            this.SvcGuest.DataPropertyName = "guestname";
            this.SvcGuest.HeaderText = "Guest Name";
            this.SvcGuest.MinimumWidth = 200;
            this.SvcGuest.Name = "SvcGuest";
            this.SvcGuest.ReadOnly = true;
            this.SvcGuest.Width = 200;
            // 
            // SvcMsg
            // 
            this.SvcMsg.DataPropertyName = "message";
            this.SvcMsg.HeaderText = "Service Message";
            this.SvcMsg.MinimumWidth = 500;
            this.SvcMsg.Name = "SvcMsg";
            this.SvcMsg.ReadOnly = true;
            this.SvcMsg.Width = 500;
            // 
            // SvcDT
            // 
            this.SvcDT.DataPropertyName = "svcdt";
            this.SvcDT.HeaderText = "Serviced Date/Time";
            this.SvcDT.MinimumWidth = 150;
            this.SvcDT.Name = "SvcDT";
            this.SvcDT.ReadOnly = true;
            this.SvcDT.Width = 150;
            // 
            // SvcBy
            // 
            this.SvcBy.DataPropertyName = "servedby";
            this.SvcBy.HeaderText = "Serviced By";
            this.SvcBy.MinimumWidth = 200;
            this.SvcBy.Name = "SvcBy";
            this.SvcBy.ReadOnly = true;
            this.SvcBy.Width = 200;
            // 
            // SvcDuration
            // 
            this.SvcDuration.HeaderText = "Duration";
            this.SvcDuration.Name = "SvcDuration";
            this.SvcDuration.ReadOnly = true;
            // 
            // served
            // 
            this.served.DataPropertyName = "isserved";
            this.served.HeaderText = "Served";
            this.served.Name = "served";
            this.served.ReadOnly = true;
            this.served.Visible = false;
            // 
            // SvcNow
            // 
            this.SvcNow.HeaderText = "";
            this.SvcNow.Image = ((System.Drawing.Image)(resources.GetObject("SvcNow.Image")));
            this.SvcNow.MinimumWidth = 50;
            this.SvcNow.Name = "SvcNow";
            this.SvcNow.ReadOnly = true;
            this.SvcNow.Width = 50;
            // 
            // frmSvcBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 465);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSvcBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resort Service Board";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSvcBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSvc)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvSvc;
        private System.Windows.Forms.ImageList imgBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tspBtnRefresh;
        private System.Windows.Forms.ToolStripComboBox tspCbo;
        private System.Windows.Forms.ToolStripLabel tsplblLQ;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn SvcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SvcGuest;
        private System.Windows.Forms.DataGridViewTextBoxColumn SvcMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn SvcDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SvcBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SvcDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn served;
        private System.Windows.Forms.DataGridViewImageColumn SvcNow;
    }
}