
namespace CAReserveSystem
{
    partial class frmBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooking));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbFind = new System.Windows.Forms.ToolStripButton();
            this.tstFind = new System.Windows.Forms.ToolStripTextBox();
            this.tslFind = new System.Windows.Forms.ToolStripLabel();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.pnlBookCount = new System.Windows.Forms.Panel();
            this.lblABCount = new System.Windows.Forms.Label();
            this.lblActiveBookings = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.imlBooking = new System.Windows.Forms.ImageList(this.components);
            this.colBkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGuest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGuestCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckOut = new System.Windows.Forms.DataGridViewImageColumn();
            this.colCheckOut1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPymt = new System.Windows.Forms.DataGridViewImageColumn();
            this.colPymt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddGuest = new System.Windows.Forms.DataGridViewImageColumn();
            this.colChangeAcc = new System.Windows.Forms.DataGridViewImageColumn();
            this.colGuestReq = new System.Windows.Forms.DataGridViewImageColumn();
            this.colIssuePass = new System.Windows.Forms.DataGridViewImageColumn();
            this.colBCToIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServing = new System.Windows.Forms.DataGridViewImageColumn();
            this.colServed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInQueue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMenu.SuspendLayout();
            this.pnlBookCount.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
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
            this.tsMenu.Size = new System.Drawing.Size(1143, 39);
            this.tsMenu.TabIndex = 0;
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
            this.tstFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstFind_KeyDown);
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
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // pnlBookCount
            // 
            this.pnlBookCount.Controls.Add(this.lblABCount);
            this.pnlBookCount.Controls.Add(this.lblActiveBookings);
            this.pnlBookCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBookCount.Location = new System.Drawing.Point(0, 366);
            this.pnlBookCount.Name = "pnlBookCount";
            this.pnlBookCount.Size = new System.Drawing.Size(1143, 33);
            this.pnlBookCount.TabIndex = 1;
            // 
            // lblABCount
            // 
            this.lblABCount.AutoSize = true;
            this.lblABCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABCount.Location = new System.Drawing.Point(148, 6);
            this.lblABCount.Name = "lblABCount";
            this.lblABCount.Size = new System.Drawing.Size(17, 19);
            this.lblABCount.TabIndex = 1;
            this.lblABCount.Text = "0";
            // 
            // lblActiveBookings
            // 
            this.lblActiveBookings.AutoSize = true;
            this.lblActiveBookings.Location = new System.Drawing.Point(12, 10);
            this.lblActiveBookings.Name = "lblActiveBookings";
            this.lblActiveBookings.Size = new System.Drawing.Size(130, 14);
            this.lblActiveBookings.TabIndex = 0;
            this.lblActiveBookings.Text = "Total Active Bookings : ";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.dgvBooking);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 39);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1143, 327);
            this.pnlContainer.TabIndex = 2;
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToDeleteRows = false;
            this.dgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBkId,
            this.colGuest,
            this.colAcc,
            this.colGuestCnt,
            this.colCheckOut,
            this.colCheckOut1,
            this.colPymt,
            this.colPymt1,
            this.colAddGuest,
            this.colChangeAcc,
            this.colGuestReq,
            this.colIssuePass,
            this.colBCToIssue,
            this.colServing,
            this.colServed,
            this.colInQueue});
            this.dgvBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooking.Location = new System.Drawing.Point(0, 0);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.Size = new System.Drawing.Size(1141, 325);
            this.dgvBooking.TabIndex = 0;
            this.dgvBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellContentClick);
            this.dgvBooking.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBooking_CellFormatting);
            this.dgvBooking.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvBooking_DataBindingComplete);
            // 
            // imlBooking
            // 
            this.imlBooking.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlBooking.ImageStream")));
            this.imlBooking.TransparentColor = System.Drawing.Color.Transparent;
            this.imlBooking.Images.SetKeyName(0, "cancel.png");
            this.imlBooking.Images.SetKeyName(1, "accept_button.png");
            this.imlBooking.Images.SetKeyName(2, "account_functions.png");
            // 
            // colBkId
            // 
            this.colBkId.DataPropertyName = "bkid";
            this.colBkId.HeaderText = "Id";
            this.colBkId.Name = "colBkId";
            this.colBkId.ReadOnly = true;
            this.colBkId.Visible = false;
            this.colBkId.Width = 43;
            // 
            // colGuest
            // 
            this.colGuest.DataPropertyName = "guestname";
            this.colGuest.HeaderText = "Guest Name";
            this.colGuest.MinimumWidth = 250;
            this.colGuest.Name = "colGuest";
            this.colGuest.ReadOnly = true;
            this.colGuest.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colGuest.Width = 250;
            // 
            // colAcc
            // 
            this.colAcc.DataPropertyName = "room";
            this.colAcc.HeaderText = "Availed Accommodation";
            this.colAcc.MinimumWidth = 250;
            this.colAcc.Name = "colAcc";
            this.colAcc.ReadOnly = true;
            this.colAcc.Width = 250;
            // 
            // colGuestCnt
            // 
            this.colGuestCnt.DataPropertyName = "qty";
            this.colGuestCnt.HeaderText = "Number of Guests";
            this.colGuestCnt.MinimumWidth = 80;
            this.colGuestCnt.Name = "colGuestCnt";
            this.colGuestCnt.ReadOnly = true;
            this.colGuestCnt.Width = 85;
            // 
            // colCheckOut
            // 
            this.colCheckOut.HeaderText = "Check Out";
            this.colCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("colCheckOut.Image")));
            this.colCheckOut.MinimumWidth = 60;
            this.colCheckOut.Name = "colCheckOut";
            this.colCheckOut.ReadOnly = true;
            this.colCheckOut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCheckOut.ToolTipText = "Guest Check out";
            this.colCheckOut.Width = 60;
            // 
            // colCheckOut1
            // 
            this.colCheckOut1.DataPropertyName = "timeout";
            this.colCheckOut1.HeaderText = "CheckOut";
            this.colCheckOut1.Name = "colCheckOut1";
            this.colCheckOut1.ReadOnly = true;
            this.colCheckOut1.Visible = false;
            this.colCheckOut1.Width = 82;
            // 
            // colPymt
            // 
            this.colPymt.HeaderText = "For Payment";
            this.colPymt.Image = ((System.Drawing.Image)(resources.GetObject("colPymt.Image")));
            this.colPymt.MinimumWidth = 60;
            this.colPymt.Name = "colPymt";
            this.colPymt.ReadOnly = true;
            this.colPymt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPymt.ToolTipText = "Due for Payment";
            this.colPymt.Width = 71;
            // 
            // colPymt1
            // 
            this.colPymt1.DataPropertyName = "unpaid";
            this.colPymt1.HeaderText = "Payment";
            this.colPymt1.Name = "colPymt1";
            this.colPymt1.ReadOnly = true;
            this.colPymt1.Visible = false;
            this.colPymt1.Width = 78;
            // 
            // colAddGuest
            // 
            this.colAddGuest.HeaderText = "Add Guest";
            this.colAddGuest.Image = ((System.Drawing.Image)(resources.GetObject("colAddGuest.Image")));
            this.colAddGuest.MinimumWidth = 60;
            this.colAddGuest.Name = "colAddGuest";
            this.colAddGuest.ReadOnly = true;
            this.colAddGuest.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAddGuest.ToolTipText = "Additional Guests";
            this.colAddGuest.Width = 62;
            // 
            // colChangeAcc
            // 
            this.colChangeAcc.HeaderText = "Change Accom.";
            this.colChangeAcc.Image = ((System.Drawing.Image)(resources.GetObject("colChangeAcc.Image")));
            this.colChangeAcc.MinimumWidth = 60;
            this.colChangeAcc.Name = "colChangeAcc";
            this.colChangeAcc.ReadOnly = true;
            this.colChangeAcc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colChangeAcc.ToolTipText = "Transfer Accommodation";
            this.colChangeAcc.Width = 84;
            // 
            // colGuestReq
            // 
            this.colGuestReq.HeaderText = "Request Items";
            this.colGuestReq.Image = ((System.Drawing.Image)(resources.GetObject("colGuestReq.Image")));
            this.colGuestReq.MinimumWidth = 60;
            this.colGuestReq.Name = "colGuestReq";
            this.colGuestReq.ReadOnly = true;
            this.colGuestReq.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGuestReq.ToolTipText = "Guest Requests";
            this.colGuestReq.Width = 83;
            // 
            // colIssuePass
            // 
            this.colIssuePass.HeaderText = "Issue Passes";
            this.colIssuePass.Image = ((System.Drawing.Image)(resources.GetObject("colIssuePass.Image")));
            this.colIssuePass.MinimumWidth = 60;
            this.colIssuePass.Name = "colIssuePass";
            this.colIssuePass.ReadOnly = true;
            this.colIssuePass.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIssuePass.Width = 76;
            // 
            // colBCToIssue
            // 
            this.colBCToIssue.DataPropertyName = "bctoissue";
            this.colBCToIssue.HeaderText = "Barcode to issue";
            this.colBCToIssue.Name = "colBCToIssue";
            this.colBCToIssue.ReadOnly = true;
            this.colBCToIssue.Visible = false;
            this.colBCToIssue.Width = 86;
            // 
            // colServing
            // 
            this.colServing.HeaderText = "Served";
            this.colServing.Image = ((System.Drawing.Image)(resources.GetObject("colServing.Image")));
            this.colServing.Name = "colServing";
            this.colServing.ReadOnly = true;
            this.colServing.Width = 49;
            // 
            // colServed
            // 
            this.colServed.DataPropertyName = "served";
            this.colServed.HeaderText = "Served";
            this.colServed.Name = "colServed";
            this.colServed.ReadOnly = true;
            this.colServed.Visible = false;
            this.colServed.Width = 68;
            // 
            // colInQueue
            // 
            this.colInQueue.DataPropertyName = "inqueue";
            this.colInQueue.HeaderText = "OnQueue";
            this.colInQueue.Name = "colInQueue";
            this.colInQueue.ReadOnly = true;
            this.colInQueue.Visible = false;
            this.colInQueue.Width = 83;
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 399);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlBookCount);
            this.Controls.Add(this.tsMenu);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Module";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBooking_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.pnlBookCount.ResumeLayout(false);
            this.pnlBookCount.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbFind;
        private System.Windows.Forms.ToolStripTextBox tstFind;
        private System.Windows.Forms.ToolStripLabel tslFind;
        private System.Windows.Forms.Panel pnlBookCount;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Label lblABCount;
        private System.Windows.Forms.Label lblActiveBookings;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ImageList imlBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGuest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGuestCnt;
        private System.Windows.Forms.DataGridViewImageColumn colCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckOut1;
        private System.Windows.Forms.DataGridViewImageColumn colPymt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPymt1;
        private System.Windows.Forms.DataGridViewImageColumn colAddGuest;
        private System.Windows.Forms.DataGridViewImageColumn colChangeAcc;
        private System.Windows.Forms.DataGridViewImageColumn colGuestReq;
        private System.Windows.Forms.DataGridViewImageColumn colIssuePass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBCToIssue;
        private System.Windows.Forms.DataGridViewImageColumn colServing;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInQueue;
    }
}