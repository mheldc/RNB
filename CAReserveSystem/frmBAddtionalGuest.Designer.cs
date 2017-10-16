namespace CAReserveSystem
{
    partial class frmBAddtionalGuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBAddtionalGuest));
            this.lblAdult = new System.Windows.Forms.Label();
            this.lblChild0 = new System.Windows.Forms.Label();
            this.lblChild1 = new System.Windows.Forms.Label();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.txtQAdult = new System.Windows.Forms.TextBox();
            this.txtQChild0 = new System.Windows.Forms.TextBox();
            this.txtQChild1 = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblEntryFee = new System.Windows.Forms.Label();
            this.txtEFChild1 = new System.Windows.Forms.TextBox();
            this.txtEFChild0 = new System.Windows.Forms.TextBox();
            this.txtEFAdult = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSTChild1 = new System.Windows.Forms.TextBox();
            this.txtSTChild0 = new System.Windows.Forms.TextBox();
            this.txtSTAdult = new System.Windows.Forms.TextBox();
            this.lblAppRate = new System.Windows.Forms.Label();
            this.lblAppRate1 = new System.Windows.Forms.Label();
            this.pnlAcctInfo = new System.Windows.Forms.Panel();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lblAcc = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblAcctInfo = new System.Windows.Forms.Label();
            this.pnlAcctInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdult
            // 
            this.lblAdult.AutoSize = true;
            this.lblAdult.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdult.Location = new System.Drawing.Point(12, 177);
            this.lblAdult.Name = "lblAdult";
            this.lblAdult.Size = new System.Drawing.Size(54, 23);
            this.lblAdult.TabIndex = 0;
            this.lblAdult.Text = "Adult";
            // 
            // lblChild0
            // 
            this.lblChild0.AutoSize = true;
            this.lblChild0.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChild0.Location = new System.Drawing.Point(12, 211);
            this.lblChild0.Name = "lblChild0";
            this.lblChild0.Size = new System.Drawing.Size(174, 23);
            this.lblChild0.TabIndex = 1;
            this.lblChild0.Text = "Senior Citizen / PWD";
            // 
            // lblChild1
            // 
            this.lblChild1.AutoSize = true;
            this.lblChild1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChild1.Location = new System.Drawing.Point(12, 246);
            this.lblChild1.Name = "lblChild1";
            this.lblChild1.Size = new System.Drawing.Size(181, 23);
            this.lblChild1.TabIndex = 2;
            this.lblChild1.Text = "Children below 4 feet";
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGuest.Location = new System.Drawing.Point(404, 312);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(228, 35);
            this.btnAddGuest.TabIndex = 3;
            this.btnAddGuest.Text = "Process Guest Additions";
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // txtQAdult
            // 
            this.txtQAdult.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQAdult.Location = new System.Drawing.Point(274, 174);
            this.txtQAdult.Name = "txtQAdult";
            this.txtQAdult.Size = new System.Drawing.Size(100, 31);
            this.txtQAdult.TabIndex = 0;
            this.txtQAdult.Text = "0";
            this.txtQAdult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQAdult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQAdult_KeyDown);
            this.txtQAdult.LostFocus += new System.EventHandler(this.txtQAdult_LostFocus);
            // 
            // txtQChild0
            // 
            this.txtQChild0.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQChild0.Location = new System.Drawing.Point(274, 208);
            this.txtQChild0.Name = "txtQChild0";
            this.txtQChild0.Size = new System.Drawing.Size(100, 31);
            this.txtQChild0.TabIndex = 1;
            this.txtQChild0.Text = "0";
            this.txtQChild0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQChild0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQChild0_KeyDown);
            this.txtQChild0.LostFocus += new System.EventHandler(this.txtQChild0_LostFocus);
            // 
            // txtQChild1
            // 
            this.txtQChild1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQChild1.Location = new System.Drawing.Point(274, 243);
            this.txtQChild1.Name = "txtQChild1";
            this.txtQChild1.Size = new System.Drawing.Size(100, 31);
            this.txtQChild1.TabIndex = 2;
            this.txtQChild1.Text = "0";
            this.txtQChild1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQChild1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQChild1_KeyDown);
            this.txtQChild1.LostFocus += new System.EventHandler(this.txtQChild1_LostFocus);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(284, 148);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(79, 23);
            this.lblQty.TabIndex = 7;
            this.lblQty.Text = "Quantity";
            // 
            // lblEntryFee
            // 
            this.lblEntryFee.AutoSize = true;
            this.lblEntryFee.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryFee.Location = new System.Drawing.Point(385, 148);
            this.lblEntryFee.Name = "lblEntryFee";
            this.lblEntryFee.Size = new System.Drawing.Size(85, 23);
            this.lblEntryFee.TabIndex = 11;
            this.lblEntryFee.Text = "Entry Fee";
            // 
            // txtEFChild1
            // 
            this.txtEFChild1.BackColor = System.Drawing.SystemColors.Control;
            this.txtEFChild1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEFChild1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEFChild1.Location = new System.Drawing.Point(393, 247);
            this.txtEFChild1.Name = "txtEFChild1";
            this.txtEFChild1.ReadOnly = true;
            this.txtEFChild1.Size = new System.Drawing.Size(72, 24);
            this.txtEFChild1.TabIndex = 10;
            this.txtEFChild1.Text = "0.00";
            this.txtEFChild1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEFChild0
            // 
            this.txtEFChild0.BackColor = System.Drawing.SystemColors.Control;
            this.txtEFChild0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEFChild0.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEFChild0.Location = new System.Drawing.Point(393, 212);
            this.txtEFChild0.Name = "txtEFChild0";
            this.txtEFChild0.ReadOnly = true;
            this.txtEFChild0.Size = new System.Drawing.Size(72, 24);
            this.txtEFChild0.TabIndex = 9;
            this.txtEFChild0.Text = "0.00";
            this.txtEFChild0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEFAdult
            // 
            this.txtEFAdult.BackColor = System.Drawing.SystemColors.Control;
            this.txtEFAdult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEFAdult.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEFAdult.Location = new System.Drawing.Point(393, 177);
            this.txtEFAdult.Name = "txtEFAdult";
            this.txtEFAdult.ReadOnly = true;
            this.txtEFAdult.Size = new System.Drawing.Size(72, 24);
            this.txtEFAdult.TabIndex = 8;
            this.txtEFAdult.Text = "0.00";
            this.txtEFAdult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(514, 148);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(81, 23);
            this.lblSubtotal.TabIndex = 15;
            this.lblSubtotal.Text = "Sub Total";
            // 
            // txtSTChild1
            // 
            this.txtSTChild1.BackColor = System.Drawing.Color.White;
            this.txtSTChild1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTChild1.Location = new System.Drawing.Point(482, 243);
            this.txtSTChild1.Name = "txtSTChild1";
            this.txtSTChild1.ReadOnly = true;
            this.txtSTChild1.Size = new System.Drawing.Size(150, 31);
            this.txtSTChild1.TabIndex = 14;
            this.txtSTChild1.Text = "0.00";
            this.txtSTChild1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSTChild0
            // 
            this.txtSTChild0.BackColor = System.Drawing.Color.White;
            this.txtSTChild0.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTChild0.Location = new System.Drawing.Point(482, 208);
            this.txtSTChild0.Name = "txtSTChild0";
            this.txtSTChild0.ReadOnly = true;
            this.txtSTChild0.Size = new System.Drawing.Size(150, 31);
            this.txtSTChild0.TabIndex = 13;
            this.txtSTChild0.Text = "0.00";
            this.txtSTChild0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSTAdult
            // 
            this.txtSTAdult.BackColor = System.Drawing.Color.White;
            this.txtSTAdult.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTAdult.Location = new System.Drawing.Point(482, 174);
            this.txtSTAdult.Name = "txtSTAdult";
            this.txtSTAdult.ReadOnly = true;
            this.txtSTAdult.Size = new System.Drawing.Size(150, 31);
            this.txtSTAdult.TabIndex = 12;
            this.txtSTAdult.Text = "0.00";
            this.txtSTAdult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAppRate
            // 
            this.lblAppRate.AutoSize = true;
            this.lblAppRate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppRate.Location = new System.Drawing.Point(12, 105);
            this.lblAppRate.Name = "lblAppRate";
            this.lblAppRate.Size = new System.Drawing.Size(113, 23);
            this.lblAppRate.TabIndex = 16;
            this.lblAppRate.Text = "Applied Rate";
            // 
            // lblAppRate1
            // 
            this.lblAppRate1.AutoSize = true;
            this.lblAppRate1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppRate1.Location = new System.Drawing.Point(270, 105);
            this.lblAppRate1.Name = "lblAppRate1";
            this.lblAppRate1.Size = new System.Drawing.Size(22, 23);
            this.lblAppRate1.TabIndex = 17;
            this.lblAppRate1.Text = "--";
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
            this.pnlAcctInfo.Size = new System.Drawing.Size(645, 93);
            this.pnlAcctInfo.TabIndex = 18;
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
            // frmBAddtionalGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 360);
            this.Controls.Add(this.pnlAcctInfo);
            this.Controls.Add(this.lblAppRate1);
            this.Controls.Add(this.lblAppRate);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtSTChild1);
            this.Controls.Add(this.txtSTChild0);
            this.Controls.Add(this.txtSTAdult);
            this.Controls.Add(this.lblEntryFee);
            this.Controls.Add(this.txtEFChild1);
            this.Controls.Add(this.txtEFChild0);
            this.Controls.Add(this.txtEFAdult);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtQChild1);
            this.Controls.Add(this.txtQChild0);
            this.Controls.Add(this.txtQAdult);
            this.Controls.Add(this.btnAddGuest);
            this.Controls.Add(this.lblChild1);
            this.Controls.Add(this.lblChild0);
            this.Controls.Add(this.lblAdult);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBAddtionalGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Additional Guests";
            this.Load += new System.EventHandler(this.frmBAddtionalGuest_Load);
            this.pnlAcctInfo.ResumeLayout(false);
            this.pnlAcctInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdult;
        private System.Windows.Forms.Label lblChild0;
        private System.Windows.Forms.Label lblChild1;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.TextBox txtQAdult;
        private System.Windows.Forms.TextBox txtQChild0;
        private System.Windows.Forms.TextBox txtQChild1;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblEntryFee;
        private System.Windows.Forms.TextBox txtEFChild1;
        private System.Windows.Forms.TextBox txtEFChild0;
        private System.Windows.Forms.TextBox txtEFAdult;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSTChild1;
        private System.Windows.Forms.TextBox txtSTChild0;
        private System.Windows.Forms.TextBox txtSTAdult;
        private System.Windows.Forms.Label lblAppRate;
        private System.Windows.Forms.Label lblAppRate1;
        private System.Windows.Forms.Panel pnlAcctInfo;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblAcctInfo;
    }
}