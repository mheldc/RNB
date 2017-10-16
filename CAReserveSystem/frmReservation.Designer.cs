namespace CAReserveSystem
{
    partial class frmReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservation));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbFind = new System.Windows.Forms.ToolStripButton();
            this.tstFind = new System.Windows.Forms.ToolStripTextBox();
            this.tslFind = new System.Windows.Forms.ToolStripLabel();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.pnlBookCount = new System.Windows.Forms.Panel();
            this.lblARCount = new System.Windows.Forms.Label();
            this.lblAR = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.colRsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRsAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsPaidIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.colRsStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrint = new System.Windows.Forms.DataGridViewImageColumn();
            this.colCancel = new System.Windows.Forms.DataGridViewImageColumn();
            this.imlIcons = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tsMenu.SuspendLayout();
            this.pnlBookCount.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbFind,
            this.tstFind,
            this.tslFind,
            this.tsbRefresh});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(743, 39);
            this.tsMenu.TabIndex = 1;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(36, 36);
            this.tsbNew.Text = "New Booking";
            this.tsbNew.ToolTipText = "New Booking";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbFind
            // 
            this.tsbFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFind.Image = ((System.Drawing.Image)(resources.GetObject("tsbFind.Image")));
            this.tsbFind.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFind.Name = "tsbFind";
            this.tsbFind.Size = new System.Drawing.Size(36, 36);
            this.tsbFind.Text = "toolStripButton3";
            this.tsbFind.ToolTipText = "Search";
            this.tsbFind.Click += new System.EventHandler(this.tsbFind_Click);
            // 
            // tstFind
            // 
            this.tstFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstFind.Name = "tstFind";
            this.tstFind.Size = new System.Drawing.Size(200, 39);
            // 
            // tslFind
            // 
            this.tslFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslFind.Name = "tslFind";
            this.tslFind.Size = new System.Drawing.Size(30, 36);
            this.tslFind.Text = "Find";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(36, 36);
            this.tsbRefresh.Text = "Refresh List";
            // 
            // pnlBookCount
            // 
            this.pnlBookCount.Controls.Add(this.lblARCount);
            this.pnlBookCount.Controls.Add(this.lblAR);
            this.pnlBookCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBookCount.Location = new System.Drawing.Point(0, 421);
            this.pnlBookCount.Name = "pnlBookCount";
            this.pnlBookCount.Size = new System.Drawing.Size(743, 33);
            this.pnlBookCount.TabIndex = 2;
            // 
            // lblARCount
            // 
            this.lblARCount.AutoSize = true;
            this.lblARCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblARCount.Location = new System.Drawing.Point(163, 6);
            this.lblARCount.Name = "lblARCount";
            this.lblARCount.Size = new System.Drawing.Size(17, 19);
            this.lblARCount.TabIndex = 1;
            this.lblARCount.Text = "0";
            // 
            // lblAR
            // 
            this.lblAR.AutoSize = true;
            this.lblAR.Location = new System.Drawing.Point(12, 10);
            this.lblAR.Name = "lblAR";
            this.lblAR.Size = new System.Drawing.Size(150, 14);
            this.lblAR.TabIndex = 0;
            this.lblAR.Text = "Total Active Reservations : ";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.dgvReservation);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 39);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(743, 382);
            this.pnlContainer.TabIndex = 3;
            // 
            // dgvReservation
            // 
            this.dgvReservation.AllowUserToAddRows = false;
            this.dgvReservation.AllowUserToDeleteRows = false;
            this.dgvReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRsId,
            this.colGName,
            this.colRsAcc,
            this.colRsDate,
            this.colIsPaid,
            this.colIsPaidIcon,
            this.colRsStatus,
            this.colPrint,
            this.colCancel});
            this.dgvReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservation.Location = new System.Drawing.Point(0, 0);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.ReadOnly = true;
            this.dgvReservation.Size = new System.Drawing.Size(741, 380);
            this.dgvReservation.TabIndex = 0;
            this.dgvReservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservation_CellContentClick);
            // 
            // colRsId
            // 
            this.colRsId.DataPropertyName = "bkid";
            this.colRsId.HeaderText = "Id";
            this.colRsId.Name = "colRsId";
            this.colRsId.ReadOnly = true;
            this.colRsId.Visible = false;
            this.colRsId.Width = 43;
            // 
            // colGName
            // 
            this.colGName.HeaderText = "Guest Name";
            this.colGName.Name = "colGName";
            this.colGName.ReadOnly = true;
            this.colGName.Width = 91;
            // 
            // colRsAcc
            // 
            this.colRsAcc.HeaderText = "Reserved Accommodation";
            this.colRsAcc.MinimumWidth = 300;
            this.colRsAcc.Name = "colRsAcc";
            this.colRsAcc.ReadOnly = true;
            this.colRsAcc.Width = 300;
            // 
            // colRsDate
            // 
            this.colRsDate.HeaderText = "Reserved Date";
            this.colRsDate.MinimumWidth = 120;
            this.colRsDate.Name = "colRsDate";
            this.colRsDate.ReadOnly = true;
            this.colRsDate.Width = 120;
            // 
            // colIsPaid
            // 
            this.colIsPaid.HeaderText = "IsPaid";
            this.colIsPaid.Name = "colIsPaid";
            this.colIsPaid.ReadOnly = true;
            this.colIsPaid.Visible = false;
            this.colIsPaid.Width = 66;
            // 
            // colIsPaidIcon
            // 
            this.colIsPaidIcon.HeaderText = "Payment";
            this.colIsPaidIcon.Image = global::CAReserveSystem.Properties.Resources.money;
            this.colIsPaidIcon.MinimumWidth = 32;
            this.colIsPaidIcon.Name = "colIsPaidIcon";
            this.colIsPaidIcon.ReadOnly = true;
            this.colIsPaidIcon.Width = 59;
            // 
            // colRsStatus
            // 
            this.colRsStatus.HeaderText = "Status";
            this.colRsStatus.MinimumWidth = 100;
            this.colRsStatus.Name = "colRsStatus";
            this.colRsStatus.ReadOnly = true;
            // 
            // colPrint
            // 
            this.colPrint.HeaderText = "Print";
            this.colPrint.Image = global::CAReserveSystem.Properties.Resources.printer;
            this.colPrint.Name = "colPrint";
            this.colPrint.ReadOnly = true;
            this.colPrint.Width = 38;
            // 
            // colCancel
            // 
            this.colCancel.HeaderText = "Cancel";
            this.colCancel.Name = "colCancel";
            this.colCancel.ReadOnly = true;
            this.colCancel.Width = 49;
            // 
            // imlIcons
            // 
            this.imlIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlIcons.ImageStream")));
            this.imlIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlIcons.Images.SetKeyName(0, "cross.png");
            this.imlIcons.Images.SetKeyName(1, "printer.png");
            this.imlIcons.Images.SetKeyName(2, "money.png");
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Payment";
            this.dataGridViewImageColumn1.Image = global::CAReserveSystem.Properties.Resources.money;
            this.dataGridViewImageColumn1.MinimumWidth = 32;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 54;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Print";
            this.dataGridViewImageColumn2.Image = global::CAReserveSystem.Properties.Resources.printer;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 34;
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 454);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlBookCount);
            this.Controls.Add(this.tsMenu);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.frmReservation_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.pnlBookCount.ResumeLayout(false);
            this.pnlBookCount.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbFind;
        private System.Windows.Forms.ToolStripTextBox tstFind;
        private System.Windows.Forms.ToolStripLabel tslFind;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Panel pnlBookCount;
        private System.Windows.Forms.Label lblARCount;
        private System.Windows.Forms.Label lblAR;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.ImageList imlIcons;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRsAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRsDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsPaid;
        private System.Windows.Forms.DataGridViewImageColumn colIsPaidIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRsStatus;
        private System.Windows.Forms.DataGridViewImageColumn colPrint;
        private System.Windows.Forms.DataGridViewImageColumn colCancel;
    }
}