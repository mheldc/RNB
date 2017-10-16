namespace CAReserveSystem
{
    partial class frmBPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBPayment));
            this.pnlAcctInfo = new System.Windows.Forms.Panel();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lblAcc = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblAcctInfo = new System.Windows.Forms.Label();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.btnSettle = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTendered = new System.Windows.Forms.TextBox();
            this.lblChange1 = new System.Windows.Forms.Label();
            this.lblSubTotal1 = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblTendered = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.pnlAcctInfo.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAcctInfo
            // 
            this.pnlAcctInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAcctInfo.Controls.Add(this.txtAcc);
            this.pnlAcctInfo.Controls.Add(this.txtGuestName);
            this.pnlAcctInfo.Controls.Add(this.lblAcc);
            this.pnlAcctInfo.Controls.Add(this.lblGuestName);
            this.pnlAcctInfo.Controls.Add(this.lblAcctInfo);
            this.pnlAcctInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAcctInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlAcctInfo.Name = "pnlAcctInfo";
            this.pnlAcctInfo.Size = new System.Drawing.Size(768, 93);
            this.pnlAcctInfo.TabIndex = 0;
            // 
            // txtAcc
            // 
            this.txtAcc.Enabled = false;
            this.txtAcc.Location = new System.Drawing.Point(129, 54);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.ReadOnly = true;
            this.txtAcc.Size = new System.Drawing.Size(386, 22);
            this.txtAcc.TabIndex = 4;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Enabled = false;
            this.txtGuestName.Location = new System.Drawing.Point(129, 30);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.ReadOnly = true;
            this.txtGuestName.Size = new System.Drawing.Size(386, 22);
            this.txtGuestName.TabIndex = 3;
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcc.Location = new System.Drawing.Point(31, 57);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(87, 14);
            this.lblAcc.TabIndex = 2;
            this.lblAcc.Text = "Accommodation";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.Location = new System.Drawing.Point(31, 33);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(69, 14);
            this.lblGuestName.TabIndex = 1;
            this.lblGuestName.Text = "Guest Name";
            // 
            // lblAcctInfo
            // 
            this.lblAcctInfo.AutoSize = true;
            this.lblAcctInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctInfo.Location = new System.Drawing.Point(12, 9);
            this.lblAcctInfo.Name = "lblAcctInfo";
            this.lblAcctInfo.Size = new System.Drawing.Size(107, 14);
            this.lblAcctInfo.TabIndex = 0;
            this.lblAcctInfo.Text = "Account Information";
            // 
            // pnlPayment
            // 
            this.pnlPayment.Controls.Add(this.btnSettle);
            this.pnlPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPayment.Location = new System.Drawing.Point(0, 490);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(768, 53);
            this.pnlPayment.TabIndex = 1;
            // 
            // btnSettle
            // 
            this.btnSettle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettle.Location = new System.Drawing.Point(568, 6);
            this.btnSettle.Name = "btnSettle";
            this.btnSettle.Size = new System.Drawing.Size(184, 33);
            this.btnSettle.TabIndex = 0;
            this.btnSettle.Text = "Settle Payment";
            this.btnSettle.UseVisualStyleBackColor = true;
            this.btnSettle.Click += new System.EventHandler(this.btnSettle_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.dgvItems);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 93);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(768, 397);
            this.pnlContainer.TabIndex = 2;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colBid,
            this.colIType,
            this.colIDesc,
            this.colIQty,
            this.colIAmt});
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Location = new System.Drawing.Point(0, 0);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.Size = new System.Drawing.Size(768, 397);
            this.dgvItems.TabIndex = 0;
            this.dgvItems.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvItems_DataBindingComplete);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 50;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            this.colId.Width = 50;
            // 
            // colBid
            // 
            this.colBid.HeaderText = "BID";
            this.colBid.MinimumWidth = 50;
            this.colBid.Name = "colBid";
            this.colBid.ReadOnly = true;
            this.colBid.Visible = false;
            this.colBid.Width = 50;
            // 
            // colIType
            // 
            this.colIType.HeaderText = "Item Type";
            this.colIType.MinimumWidth = 50;
            this.colIType.Name = "colIType";
            this.colIType.ReadOnly = true;
            this.colIType.Visible = false;
            this.colIType.Width = 50;
            // 
            // colIDesc
            // 
            this.colIDesc.HeaderText = "Item Description";
            this.colIDesc.MinimumWidth = 150;
            this.colIDesc.Name = "colIDesc";
            this.colIDesc.ReadOnly = true;
            this.colIDesc.Width = 250;
            // 
            // colIQty
            // 
            this.colIQty.HeaderText = "Qty";
            this.colIQty.MinimumWidth = 70;
            this.colIQty.Name = "colIQty";
            this.colIQty.ReadOnly = true;
            this.colIQty.Width = 90;
            // 
            // colIAmt
            // 
            this.colIAmt.HeaderText = "Amount";
            this.colIAmt.MinimumWidth = 100;
            this.colIAmt.Name = "colIAmt";
            this.colIAmt.ReadOnly = true;
            this.colIAmt.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTendered);
            this.panel1.Controls.Add(this.lblChange1);
            this.panel1.Controls.Add(this.lblSubTotal1);
            this.panel1.Controls.Add(this.lblChange);
            this.panel1.Controls.Add(this.lblTendered);
            this.panel1.Controls.Add(this.lblSubTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 107);
            this.panel1.TabIndex = 3;
            // 
            // txtTendered
            // 
            this.txtTendered.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendered.Location = new System.Drawing.Point(577, 41);
            this.txtTendered.Name = "txtTendered";
            this.txtTendered.Size = new System.Drawing.Size(175, 31);
            this.txtTendered.TabIndex = 0;
            this.txtTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTendered.TextChanged += new System.EventHandler(this.txtTendered_TextChanged);
            // 
            // lblChange1
            // 
            this.lblChange1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange1.Location = new System.Drawing.Point(581, 74);
            this.lblChange1.Name = "lblChange1";
            this.lblChange1.Size = new System.Drawing.Size(175, 23);
            this.lblChange1.TabIndex = 6;
            this.lblChange1.Text = "0.00";
            this.lblChange1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotal1
            // 
            this.lblSubTotal1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal1.Location = new System.Drawing.Point(581, 12);
            this.lblSubTotal1.Name = "lblSubTotal1";
            this.lblSubTotal1.Size = new System.Drawing.Size(175, 29);
            this.lblSubTotal1.TabIndex = 5;
            this.lblSubTotal1.Text = "0.00";
            this.lblSubTotal1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(32, 74);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(68, 23);
            this.lblChange.TabIndex = 4;
            this.lblChange.Text = "Change";
            // 
            // lblTendered
            // 
            this.lblTendered.AutoSize = true;
            this.lblTendered.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTendered.Location = new System.Drawing.Point(32, 44);
            this.lblTendered.Name = "lblTendered";
            this.lblTendered.Size = new System.Drawing.Size(158, 23);
            this.lblTendered.TabIndex = 3;
            this.lblTendered.Text = "Payment Tendered";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(32, 15);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(81, 23);
            this.lblSubTotal.TabIndex = 2;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // frmBPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlPayment);
            this.Controls.Add(this.pnlAcctInfo);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Due for Payment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBPayment_FormClosed);
            this.Load += new System.EventHandler(this.frmBPayment_Load);
            this.pnlAcctInfo.ResumeLayout(false);
            this.pnlAcctInfo.PerformLayout();
            this.pnlPayment.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAcctInfo;
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Button btnSettle;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblAcctInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIAmt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTendered;
        private System.Windows.Forms.Label lblChange1;
        private System.Windows.Forms.Label lblSubTotal1;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblTendered;
        private System.Windows.Forms.Label lblSubTotal;
    }
}