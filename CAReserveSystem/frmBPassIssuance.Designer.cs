namespace CAReserveSystem
{
    partial class frmBPassIssuance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBPassIssuance));
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.btnIssuePass = new System.Windows.Forms.Button();
            this.pnlAcctInfo = new System.Windows.Forms.Panel();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lblAcc = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblAcctInfo = new System.Windows.Forms.Label();
            this.pnlScanPass = new System.Windows.Forms.Panel();
            this.lblTotalPass1 = new System.Windows.Forms.Label();
            this.lblTotalPass = new System.Windows.Forms.Label();
            this.lblRemaining1 = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.txtPassToScan = new System.Windows.Forms.TextBox();
            this.lblPassToScan = new System.Windows.Forms.Label();
            this.pnlScannedPass = new System.Windows.Forms.Panel();
            this.libPasses = new System.Windows.Forms.ListBox();
            this.tmrScanPass = new System.Windows.Forms.Timer(this.components);
            this.pnlPayment.SuspendLayout();
            this.pnlAcctInfo.SuspendLayout();
            this.pnlScanPass.SuspendLayout();
            this.pnlScannedPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPayment
            // 
            this.pnlPayment.Controls.Add(this.btnIssuePass);
            this.pnlPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPayment.Location = new System.Drawing.Point(0, 372);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(528, 39);
            this.pnlPayment.TabIndex = 6;
            // 
            // btnIssuePass
            // 
            this.btnIssuePass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssuePass.Location = new System.Drawing.Point(340, 3);
            this.btnIssuePass.Name = "btnIssuePass";
            this.btnIssuePass.Size = new System.Drawing.Size(184, 33);
            this.btnIssuePass.TabIndex = 1;
            this.btnIssuePass.Text = "Issue Resort Pass";
            this.btnIssuePass.UseVisualStyleBackColor = true;
            this.btnIssuePass.Click += new System.EventHandler(this.btnIssuePass_Click);
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
            this.pnlAcctInfo.Size = new System.Drawing.Size(528, 93);
            this.pnlAcctInfo.TabIndex = 5;
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
            // pnlScanPass
            // 
            this.pnlScanPass.Controls.Add(this.lblTotalPass1);
            this.pnlScanPass.Controls.Add(this.lblTotalPass);
            this.pnlScanPass.Controls.Add(this.lblRemaining1);
            this.pnlScanPass.Controls.Add(this.lblRemaining);
            this.pnlScanPass.Controls.Add(this.txtPassToScan);
            this.pnlScanPass.Controls.Add(this.lblPassToScan);
            this.pnlScanPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlScanPass.Location = new System.Drawing.Point(0, 93);
            this.pnlScanPass.Name = "pnlScanPass";
            this.pnlScanPass.Size = new System.Drawing.Size(528, 108);
            this.pnlScanPass.TabIndex = 7;
            // 
            // lblTotalPass1
            // 
            this.lblTotalPass1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPass1.Location = new System.Drawing.Point(178, 71);
            this.lblTotalPass1.Name = "lblTotalPass1";
            this.lblTotalPass1.Size = new System.Drawing.Size(124, 27);
            this.lblTotalPass1.TabIndex = 5;
            this.lblTotalPass1.Text = "0";
            // 
            // lblTotalPass
            // 
            this.lblTotalPass.AutoSize = true;
            this.lblTotalPass.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPass.Location = new System.Drawing.Point(32, 78);
            this.lblTotalPass.Name = "lblTotalPass";
            this.lblTotalPass.Size = new System.Drawing.Size(97, 14);
            this.lblTotalPass.TabIndex = 4;
            this.lblTotalPass.Text = "Total Pass to Issue";
            // 
            // lblRemaining1
            // 
            this.lblRemaining1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining1.Location = new System.Drawing.Point(178, 44);
            this.lblRemaining1.Name = "lblRemaining1";
            this.lblRemaining1.Size = new System.Drawing.Size(124, 27);
            this.lblRemaining1.TabIndex = 3;
            this.lblRemaining1.Text = "0";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining.Location = new System.Drawing.Point(32, 51);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(124, 14);
            this.lblRemaining.TabIndex = 2;
            this.lblRemaining.Text = "Remaining Pass to Scan";
            // 
            // txtPassToScan
            // 
            this.txtPassToScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassToScan.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassToScan.Location = new System.Drawing.Point(180, 6);
            this.txtPassToScan.MaxLength = 20;
            this.txtPassToScan.Name = "txtPassToScan";
            this.txtPassToScan.Size = new System.Drawing.Size(276, 33);
            this.txtPassToScan.TabIndex = 0;
            this.txtPassToScan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassToScan.TextChanged += new System.EventHandler(this.txtPassToScan_TextChanged);
            // 
            // lblPassToScan
            // 
            this.lblPassToScan.AutoSize = true;
            this.lblPassToScan.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassToScan.Location = new System.Drawing.Point(32, 18);
            this.lblPassToScan.Name = "lblPassToScan";
            this.lblPassToScan.Size = new System.Drawing.Size(82, 14);
            this.lblPassToScan.TabIndex = 1;
            this.lblPassToScan.Text = "Scan Pass Here";
            // 
            // pnlScannedPass
            // 
            this.pnlScannedPass.Controls.Add(this.libPasses);
            this.pnlScannedPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScannedPass.Location = new System.Drawing.Point(0, 201);
            this.pnlScannedPass.Name = "pnlScannedPass";
            this.pnlScannedPass.Size = new System.Drawing.Size(528, 171);
            this.pnlScannedPass.TabIndex = 8;
            // 
            // libPasses
            // 
            this.libPasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libPasses.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libPasses.FormattingEnabled = true;
            this.libPasses.ItemHeight = 23;
            this.libPasses.Location = new System.Drawing.Point(0, 0);
            this.libPasses.Name = "libPasses";
            this.libPasses.Size = new System.Drawing.Size(528, 171);
            this.libPasses.TabIndex = 0;
            // 
            // tmrScanPass
            // 
            this.tmrScanPass.Interval = 3000;
            this.tmrScanPass.Tick += new System.EventHandler(this.tmrScanPass_Tick);
            // 
            // frmBPassIssuance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 411);
            this.Controls.Add(this.pnlScannedPass);
            this.Controls.Add(this.pnlScanPass);
            this.Controls.Add(this.pnlPayment);
            this.Controls.Add(this.pnlAcctInfo);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBPassIssuance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resort Pass Issuance";
            this.Load += new System.EventHandler(this.frmBPassIssuance_Load);
            this.pnlPayment.ResumeLayout(false);
            this.pnlAcctInfo.ResumeLayout(false);
            this.pnlAcctInfo.PerformLayout();
            this.pnlScanPass.ResumeLayout(false);
            this.pnlScanPass.PerformLayout();
            this.pnlScannedPass.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Button btnIssuePass;
        private System.Windows.Forms.Panel pnlAcctInfo;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblAcctInfo;
        private System.Windows.Forms.Panel pnlScanPass;
        private System.Windows.Forms.TextBox txtPassToScan;
        private System.Windows.Forms.Label lblPassToScan;
        private System.Windows.Forms.Panel pnlScannedPass;
        private System.Windows.Forms.ListBox libPasses;
        private System.Windows.Forms.Timer tmrScanPass;
        private System.Windows.Forms.Label lblTotalPass1;
        private System.Windows.Forms.Label lblTotalPass;
        private System.Windows.Forms.Label lblRemaining1;
        private System.Windows.Forms.Label lblRemaining;
    }
}