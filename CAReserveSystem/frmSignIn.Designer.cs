namespace CAReserveSystem
{
    partial class frmSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignIn));
            this.picShield = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.lblAcctId = new System.Windows.Forms.Label();
            this.lblAcctPw = new System.Windows.Forms.Label();
            this.txtAcctId = new System.Windows.Forms.TextBox();
            this.txtAcctPw = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // picShield
            // 
            this.picShield.Image = ((System.Drawing.Image)(resources.GetObject("picShield.Image")));
            this.picShield.Location = new System.Drawing.Point(12, 13);
            this.picShield.Name = "picShield";
            this.picShield.Size = new System.Drawing.Size(48, 48);
            this.picShield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picShield.TabIndex = 0;
            this.picShield.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.Transparent;
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(12, 63);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(48, 48);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUser.TabIndex = 1;
            this.picUser.TabStop = false;
            // 
            // lblAcctId
            // 
            this.lblAcctId.AutoSize = true;
            this.lblAcctId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctId.Location = new System.Drawing.Point(86, 30);
            this.lblAcctId.Name = "lblAcctId";
            this.lblAcctId.Size = new System.Drawing.Size(77, 19);
            this.lblAcctId.TabIndex = 2;
            this.lblAcctId.Text = "Account Id";
            // 
            // lblAcctPw
            // 
            this.lblAcctPw.AutoSize = true;
            this.lblAcctPw.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctPw.Location = new System.Drawing.Point(86, 59);
            this.lblAcctPw.Name = "lblAcctPw";
            this.lblAcctPw.Size = new System.Drawing.Size(71, 19);
            this.lblAcctPw.TabIndex = 3;
            this.lblAcctPw.Text = "Password";
            // 
            // txtAcctId
            // 
            this.txtAcctId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctId.Location = new System.Drawing.Point(178, 27);
            this.txtAcctId.Name = "txtAcctId";
            this.txtAcctId.Size = new System.Drawing.Size(151, 27);
            this.txtAcctId.TabIndex = 4;
            // 
            // txtAcctPw
            // 
            this.txtAcctPw.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctPw.Location = new System.Drawing.Point(178, 56);
            this.txtAcctPw.Name = "txtAcctPw";
            this.txtAcctPw.PasswordChar = '•';
            this.txtAcctPw.Size = new System.Drawing.Size(151, 27);
            this.txtAcctPw.TabIndex = 5;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(178, 89);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 28);
            this.btnSignIn.TabIndex = 6;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(254, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 138);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtAcctPw);
            this.Controls.Add(this.txtAcctId);
            this.Controls.Add(this.lblAcctPw);
            this.Controls.Add(this.lblAcctId);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.picShield);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.frmSignIn_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSignIn_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picShield;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblAcctId;
        private System.Windows.Forms.Label lblAcctPw;
        private System.Windows.Forms.TextBox txtAcctId;
        private System.Windows.Forms.TextBox txtAcctPw;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnCancel;
    }
}

