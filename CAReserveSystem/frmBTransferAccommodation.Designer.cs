namespace CAReserveSystem
{
    partial class frmBTransferAccommodation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBTransferAccommodation));
            this.pnlAcctInfo = new System.Windows.Forms.Panel();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lblAcc = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblAcctInfo = new System.Windows.Forms.Label();
            this.lblTransferDetails = new System.Windows.Forms.Label();
            this.cmbAccType = new System.Windows.Forms.ComboBox();
            this.lblAccType = new System.Windows.Forms.Label();
            this.lblNewAcc = new System.Windows.Forms.Label();
            this.cmbNewAcc = new System.Windows.Forms.ComboBox();
            this.lblAccFee = new System.Windows.Forms.Label();
            this.txtAccFee = new System.Windows.Forms.TextBox();
            this.lblAccBRate = new System.Windows.Forms.Label();
            this.lblAccBRate1 = new System.Windows.Forms.Label();
            this.lblAccBal = new System.Windows.Forms.Label();
            this.txtAccBal = new System.Windows.Forms.TextBox();
            this.btnAccTransfer = new System.Windows.Forms.Button();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.pnlAcctInfo.SuspendLayout();
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
            this.pnlAcctInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAcctInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlAcctInfo.Name = "pnlAcctInfo";
            this.pnlAcctInfo.Size = new System.Drawing.Size(528, 94);
            this.pnlAcctInfo.TabIndex = 1;
            // 
            // txtAcc
            // 
            this.txtAcc.BackColor = System.Drawing.Color.White;
            this.txtAcc.Enabled = false;
            this.txtAcc.Location = new System.Drawing.Point(166, 58);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.ReadOnly = true;
            this.txtAcc.Size = new System.Drawing.Size(349, 22);
            this.txtAcc.TabIndex = 4;
            // 
            // txtGuestName
            // 
            this.txtGuestName.BackColor = System.Drawing.Color.White;
            this.txtGuestName.Enabled = false;
            this.txtGuestName.Location = new System.Drawing.Point(166, 32);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.ReadOnly = true;
            this.txtGuestName.Size = new System.Drawing.Size(349, 22);
            this.txtGuestName.TabIndex = 3;
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcc.Location = new System.Drawing.Point(31, 61);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(126, 14);
            this.lblAcc.TabIndex = 2;
            this.lblAcc.Text = "Current Accommodation";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.Location = new System.Drawing.Point(31, 36);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(69, 14);
            this.lblGuestName.TabIndex = 1;
            this.lblGuestName.Text = "Guest Name";
            // 
            // lblAcctInfo
            // 
            this.lblAcctInfo.AutoSize = true;
            this.lblAcctInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctInfo.Location = new System.Drawing.Point(12, 10);
            this.lblAcctInfo.Name = "lblAcctInfo";
            this.lblAcctInfo.Size = new System.Drawing.Size(107, 14);
            this.lblAcctInfo.TabIndex = 0;
            this.lblAcctInfo.Text = "Account Information";
            // 
            // lblTransferDetails
            // 
            this.lblTransferDetails.AutoSize = true;
            this.lblTransferDetails.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferDetails.Location = new System.Drawing.Point(13, 121);
            this.lblTransferDetails.Name = "lblTransferDetails";
            this.lblTransferDetails.Size = new System.Drawing.Size(169, 14);
            this.lblTransferDetails.TabIndex = 2;
            this.lblTransferDetails.Text = "New Accommodation to Transfer";
            // 
            // cmbAccType
            // 
            this.cmbAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccType.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccType.FormattingEnabled = true;
            this.cmbAccType.Location = new System.Drawing.Point(167, 151);
            this.cmbAccType.Name = "cmbAccType";
            this.cmbAccType.Size = new System.Drawing.Size(349, 22);
            this.cmbAccType.TabIndex = 3;
            this.cmbAccType.SelectedValueChanged += new System.EventHandler(this.cmbAccType_SelectedValueChanged);
            // 
            // lblAccType
            // 
            this.lblAccType.AutoSize = true;
            this.lblAccType.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccType.Location = new System.Drawing.Point(32, 154);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(114, 14);
            this.lblAccType.TabIndex = 4;
            this.lblAccType.Text = "Accommodation Type";
            // 
            // lblNewAcc
            // 
            this.lblNewAcc.AutoSize = true;
            this.lblNewAcc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewAcc.Location = new System.Drawing.Point(32, 180);
            this.lblNewAcc.Name = "lblNewAcc";
            this.lblNewAcc.Size = new System.Drawing.Size(87, 14);
            this.lblNewAcc.TabIndex = 6;
            this.lblNewAcc.Text = "Accommodation";
            // 
            // cmbNewAcc
            // 
            this.cmbNewAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewAcc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNewAcc.FormattingEnabled = true;
            this.cmbNewAcc.Location = new System.Drawing.Point(167, 176);
            this.cmbNewAcc.Name = "cmbNewAcc";
            this.cmbNewAcc.Size = new System.Drawing.Size(349, 22);
            this.cmbNewAcc.TabIndex = 5;
            this.cmbNewAcc.SelectedValueChanged += new System.EventHandler(this.cmbNewAcc_SelectedValueChanged);
            // 
            // lblAccFee
            // 
            this.lblAccFee.AutoSize = true;
            this.lblAccFee.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccFee.Location = new System.Drawing.Point(32, 205);
            this.lblAccFee.Name = "lblAccFee";
            this.lblAccFee.Size = new System.Drawing.Size(108, 14);
            this.lblAccFee.TabIndex = 7;
            this.lblAccFee.Text = "Accommodation Fee";
            // 
            // txtAccFee
            // 
            this.txtAccFee.BackColor = System.Drawing.Color.White;
            this.txtAccFee.Enabled = false;
            this.txtAccFee.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccFee.Location = new System.Drawing.Point(167, 201);
            this.txtAccFee.Name = "txtAccFee";
            this.txtAccFee.ReadOnly = true;
            this.txtAccFee.Size = new System.Drawing.Size(100, 23);
            this.txtAccFee.TabIndex = 8;
            this.txtAccFee.Text = "0.00";
            this.txtAccFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAccBRate
            // 
            this.lblAccBRate.AutoSize = true;
            this.lblAccBRate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccBRate.Location = new System.Drawing.Point(32, 234);
            this.lblAccBRate.Name = "lblAccBRate";
            this.lblAccBRate.Size = new System.Drawing.Size(97, 14);
            this.lblAccBRate.TabIndex = 9;
            this.lblAccBRate.Text = "Applied Rate Base";
            // 
            // lblAccBRate1
            // 
            this.lblAccBRate1.AutoSize = true;
            this.lblAccBRate1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccBRate1.Location = new System.Drawing.Point(166, 233);
            this.lblAccBRate1.Name = "lblAccBRate1";
            this.lblAccBRate1.Size = new System.Drawing.Size(15, 14);
            this.lblAccBRate1.TabIndex = 10;
            this.lblAccBRate1.Text = "--";
            // 
            // lblAccBal
            // 
            this.lblAccBal.AutoSize = true;
            this.lblAccBal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccBal.Location = new System.Drawing.Point(32, 260);
            this.lblAccBal.Name = "lblAccBal";
            this.lblAccBal.Size = new System.Drawing.Size(80, 14);
            this.lblAccBal.TabIndex = 11;
            this.lblAccBal.Text = "Balance to pay";
            // 
            // txtAccBal
            // 
            this.txtAccBal.BackColor = System.Drawing.Color.White;
            this.txtAccBal.Enabled = false;
            this.txtAccBal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccBal.Location = new System.Drawing.Point(167, 256);
            this.txtAccBal.Name = "txtAccBal";
            this.txtAccBal.ReadOnly = true;
            this.txtAccBal.Size = new System.Drawing.Size(100, 23);
            this.txtAccBal.TabIndex = 13;
            this.txtAccBal.Text = "0.00";
            this.txtAccBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAccTransfer
            // 
            this.btnAccTransfer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccTransfer.Location = new System.Drawing.Point(327, 434);
            this.btnAccTransfer.Name = "btnAccTransfer";
            this.btnAccTransfer.Size = new System.Drawing.Size(189, 32);
            this.btnAccTransfer.TabIndex = 14;
            this.btnAccTransfer.Text = "Process Transfer";
            this.btnAccTransfer.UseVisualStyleBackColor = true;
            this.btnAccTransfer.Click += new System.EventHandler(this.btnAccTransfer_Click);
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Location = new System.Drawing.Point(32, 285);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(103, 14);
            this.lblReason.TabIndex = 15;
            this.lblReason.Text = "Reason for Transfer";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(167, 282);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(349, 146);
            this.txtReason.TabIndex = 16;
            // 
            // frmBTransferAccommodation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 478);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.btnAccTransfer);
            this.Controls.Add(this.txtAccBal);
            this.Controls.Add(this.lblAccBal);
            this.Controls.Add(this.lblAccBRate1);
            this.Controls.Add(this.lblAccBRate);
            this.Controls.Add(this.txtAccFee);
            this.Controls.Add(this.lblAccFee);
            this.Controls.Add(this.lblNewAcc);
            this.Controls.Add(this.cmbNewAcc);
            this.Controls.Add(this.lblAccType);
            this.Controls.Add(this.cmbAccType);
            this.Controls.Add(this.lblTransferDetails);
            this.Controls.Add(this.pnlAcctInfo);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBTransferAccommodation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Accommodation";
            this.Load += new System.EventHandler(this.frmBTransferAccommodation_Load);
            this.pnlAcctInfo.ResumeLayout(false);
            this.pnlAcctInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAcctInfo;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblAcctInfo;
        private System.Windows.Forms.Label lblTransferDetails;
        private System.Windows.Forms.ComboBox cmbAccType;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.Label lblNewAcc;
        private System.Windows.Forms.ComboBox cmbNewAcc;
        private System.Windows.Forms.Label lblAccFee;
        private System.Windows.Forms.TextBox txtAccFee;
        private System.Windows.Forms.Label lblAccBRate;
        private System.Windows.Forms.Label lblAccBRate1;
        private System.Windows.Forms.Label lblAccBal;
        private System.Windows.Forms.TextBox txtAccBal;
        private System.Windows.Forms.Button btnAccTransfer;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
    }
}