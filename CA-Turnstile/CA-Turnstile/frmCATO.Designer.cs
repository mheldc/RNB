namespace CA_Turnstile
{
    partial class frmCATO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCATO));
            this.txbBCode = new System.Windows.Forms.TextBox();
            this.lblBCode = new System.Windows.Forms.Label();
            this.btnSendOpen = new System.Windows.Forms.Button();
            this.msSetting = new System.Windows.Forms.MenuStrip();
            this.tsmSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrScan = new System.Windows.Forms.Timer(this.components);
            this.chkUseNullModem = new System.Windows.Forms.CheckBox();
            this.chkUseOnExit = new System.Windows.Forms.CheckBox();
            this.tmrCheckGoScan = new System.Windows.Forms.Timer(this.components);
            this.lblCtr = new System.Windows.Forms.Label();
            this.msSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbBCode
            // 
            this.txbBCode.Location = new System.Drawing.Point(125, 39);
            this.txbBCode.MaxLength = 20;
            this.txbBCode.Name = "txbBCode";
            this.txbBCode.Size = new System.Drawing.Size(177, 22);
            this.txbBCode.TabIndex = 0;
            this.txbBCode.TextChanged += new System.EventHandler(this.txbBCode_TextChanged);
            this.txbBCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_KeyDown);
            this.txbBCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbBCode_KeyUp);
            // 
            // lblBCode
            // 
            this.lblBCode.AutoSize = true;
            this.lblBCode.Location = new System.Drawing.Point(6, 42);
            this.lblBCode.Name = "lblBCode";
            this.lblBCode.Size = new System.Drawing.Size(113, 14);
            this.lblBCode.TabIndex = 1;
            this.lblBCode.Text = "Scan Barcode here :";
            // 
            // btnSendOpen
            // 
            this.btnSendOpen.Location = new System.Drawing.Point(125, 67);
            this.btnSendOpen.Name = "btnSendOpen";
            this.btnSendOpen.Size = new System.Drawing.Size(177, 29);
            this.btnSendOpen.TabIndex = 1;
            this.btnSendOpen.Text = "Send Open Signal";
            this.btnSendOpen.UseVisualStyleBackColor = true;
            this.btnSendOpen.Click += new System.EventHandler(this.btnSendOpen_Click);
            // 
            // msSetting
            // 
            this.msSetting.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSettings});
            this.msSetting.Location = new System.Drawing.Point(0, 0);
            this.msSetting.Name = "msSetting";
            this.msSetting.Size = new System.Drawing.Size(314, 24);
            this.msSetting.TabIndex = 3;
            this.msSetting.Text = "menuStrip1";
            // 
            // tsmSettings
            // 
            this.tsmSettings.Name = "tsmSettings";
            this.tsmSettings.Size = new System.Drawing.Size(61, 20);
            this.tsmSettings.Text = "Settings";
            this.tsmSettings.Click += new System.EventHandler(this.tsmSettings_Click);
            // 
            // tmrScan
            // 
            this.tmrScan.Enabled = true;
            this.tmrScan.Interval = 1000;
            this.tmrScan.Tick += new System.EventHandler(this.tmrScan_Tick);
            // 
            // chkUseNullModem
            // 
            this.chkUseNullModem.AutoSize = true;
            this.chkUseNullModem.Location = new System.Drawing.Point(125, 102);
            this.chkUseNullModem.Name = "chkUseNullModem";
            this.chkUseNullModem.Size = new System.Drawing.Size(177, 18);
            this.chkUseNullModem.TabIndex = 4;
            this.chkUseNullModem.Text = "Send Signal to NULL modem";
            this.chkUseNullModem.UseVisualStyleBackColor = true;
            // 
            // chkUseOnExit
            // 
            this.chkUseOnExit.AutoSize = true;
            this.chkUseOnExit.Location = new System.Drawing.Point(125, 126);
            this.chkUseOnExit.Name = "chkUseOnExit";
            this.chkUseOnExit.Size = new System.Drawing.Size(134, 18);
            this.chkUseOnExit.TabIndex = 5;
            this.chkUseOnExit.Text = "Use in Exit Terminal";
            this.chkUseOnExit.UseVisualStyleBackColor = true;
            // 
            // tmrCheckGoScan
            // 
            this.tmrCheckGoScan.Enabled = true;
            this.tmrCheckGoScan.Interval = 1000;
            this.tmrCheckGoScan.Tick += new System.EventHandler(this.tmrCheckGoScan_Tick);
            // 
            // lblCtr
            // 
            this.lblCtr.AutoSize = true;
            this.lblCtr.Location = new System.Drawing.Point(6, 137);
            this.lblCtr.Name = "lblCtr";
            this.lblCtr.Size = new System.Drawing.Size(13, 14);
            this.lblCtr.TabIndex = 7;
            this.lblCtr.Text = "0";
            // 
            // frmCATO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 160);
            this.Controls.Add(this.lblCtr);
            this.Controls.Add(this.chkUseOnExit);
            this.Controls.Add(this.chkUseNullModem);
            this.Controls.Add(this.btnSendOpen);
            this.Controls.Add(this.lblBCode);
            this.Controls.Add(this.txbBCode);
            this.Controls.Add(this.msSetting);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msSetting;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCATO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CA-Turnstile Opener";
            this.Load += new System.EventHandler(this.frmCATO_Load);
            this.msSetting.ResumeLayout(false);
            this.msSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbBCode;
        private System.Windows.Forms.Label lblBCode;
        private System.Windows.Forms.Button btnSendOpen;
        private System.Windows.Forms.MenuStrip msSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmSettings;
        private System.Windows.Forms.Timer tmrScan;
        private System.Windows.Forms.CheckBox chkUseNullModem;
        private System.Windows.Forms.CheckBox chkUseOnExit;
        private System.Windows.Forms.Timer tmrCheckGoScan;
        private System.Windows.Forms.Label lblCtr;
    }
}

