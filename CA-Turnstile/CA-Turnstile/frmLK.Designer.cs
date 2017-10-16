namespace CA_Turnstile
{
    partial class frmLK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLK));
            this.lblLK = new System.Windows.Forms.Label();
            this.txtLK = new System.Windows.Forms.TextBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLK
            // 
            this.lblLK.AutoSize = true;
            this.lblLK.Location = new System.Drawing.Point(12, 9);
            this.lblLK.Name = "lblLK";
            this.lblLK.Size = new System.Drawing.Size(69, 14);
            this.lblLK.TabIndex = 0;
            this.lblLK.Text = "License Key";
            // 
            // txtLK
            // 
            this.txtLK.Location = new System.Drawing.Point(87, 6);
            this.txtLK.Multiline = true;
            this.txtLK.Name = "txtLK";
            this.txtLK.Size = new System.Drawing.Size(256, 67);
            this.txtLK.TabIndex = 1;
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(87, 79);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(113, 25);
            this.btnActivate.TabIndex = 2;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // frmLK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 109);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.txtLK);
            this.Controls.Add(this.lblLK);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Key";
            this.Load += new System.EventHandler(this.frmLK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLK;
        private System.Windows.Forms.TextBox txtLK;
        private System.Windows.Forms.Button btnActivate;
    }
}