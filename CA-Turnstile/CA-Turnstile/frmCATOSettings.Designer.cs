namespace CA_Turnstile
{
    partial class frmCATOSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCATOSettings));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboDelay = new System.Windows.Forms.ComboBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.chkUseNullModem = new System.Windows.Forms.CheckBox();
            this.btnScanPort = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnApplyCs = new System.Windows.Forms.Button();
            this.cboHandshake = new System.Windows.Forms.ComboBox();
            this.cboParityBit = new System.Windows.Forms.ComboBox();
            this.cboStopBit = new System.Windows.Forms.ComboBox();
            this.cboDataBit = new System.Windows.Forms.ComboBox();
            this.cboBaud = new System.Windows.Forms.ComboBox();
            this.cboDefPort = new System.Windows.Forms.ComboBox();
            this.lblHandshake = new System.Windows.Forms.Label();
            this.lblParityBit = new System.Windows.Forms.Label();
            this.lblStopBit = new System.Windows.Forms.Label();
            this.lblDataBit = new System.Windows.Forms.Label();
            this.lblBaud = new System.Windows.Forms.Label();
            this.lblDefPort = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUseDbSet = new System.Windows.Forms.Button();
            this.btnDbTest = new System.Windows.Forms.Button();
            this.txtDbPw = new System.Windows.Forms.TextBox();
            this.lblDBPw = new System.Windows.Forms.Label();
            this.txtDbUid = new System.Windows.Forms.TextBox();
            this.lblDBUid = new System.Windows.Forms.Label();
            this.txtDefDb = new System.Windows.Forms.TextBox();
            this.lblDefDb = new System.Windows.Forms.Label();
            this.txtDbPort = new System.Windows.Forms.TextBox();
            this.txtDbHost = new System.Windows.Forms.TextBox();
            this.lblDbPort = new System.Windows.Forms.Label();
            this.lblDbHost = new System.Windows.Forms.Label();
            this.cboScanDelay = new System.Windows.Forms.ComboBox();
            this.lblScanDelay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(367, 301);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cboScanDelay);
            this.tabPage1.Controls.Add(this.lblScanDelay);
            this.tabPage1.Controls.Add(this.cboDelay);
            this.tabPage1.Controls.Add(this.lblDelay);
            this.tabPage1.Controls.Add(this.chkUseNullModem);
            this.tabPage1.Controls.Add(this.btnScanPort);
            this.tabPage1.Controls.Add(this.btnTest);
            this.tabPage1.Controls.Add(this.btnApplyCs);
            this.tabPage1.Controls.Add(this.cboHandshake);
            this.tabPage1.Controls.Add(this.cboParityBit);
            this.tabPage1.Controls.Add(this.cboStopBit);
            this.tabPage1.Controls.Add(this.cboDataBit);
            this.tabPage1.Controls.Add(this.cboBaud);
            this.tabPage1.Controls.Add(this.cboDefPort);
            this.tabPage1.Controls.Add(this.lblHandshake);
            this.tabPage1.Controls.Add(this.lblParityBit);
            this.tabPage1.Controls.Add(this.lblStopBit);
            this.tabPage1.Controls.Add(this.lblDataBit);
            this.tabPage1.Controls.Add(this.lblBaud);
            this.tabPage1.Controls.Add(this.lblDefPort);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(359, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "COM Port Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboDelay
            // 
            this.cboDelay.FormattingEnabled = true;
            this.cboDelay.Items.AddRange(new object[] {
            "1 second",
            "3 seconds",
            "5 seconds",
            "10 seconds",
            "15 seconds",
            "20 seconds",
            "25 seconds",
            "30 seconds"});
            this.cboDelay.Location = new System.Drawing.Point(123, 165);
            this.cboDelay.Name = "cboDelay";
            this.cboDelay.Size = new System.Drawing.Size(197, 22);
            this.cboDelay.TabIndex = 31;
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelay.Location = new System.Drawing.Point(18, 168);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(98, 14);
            this.lblDelay.TabIndex = 30;
            this.lblDelay.Text = "Open Signal Delay";
            // 
            // chkUseNullModem
            // 
            this.chkUseNullModem.AutoSize = true;
            this.chkUseNullModem.Location = new System.Drawing.Point(123, 333);
            this.chkUseNullModem.Name = "chkUseNullModem";
            this.chkUseNullModem.Size = new System.Drawing.Size(177, 18);
            this.chkUseNullModem.TabIndex = 29;
            this.chkUseNullModem.Text = "Send Signal to NULL modem";
            this.chkUseNullModem.UseVisualStyleBackColor = true;
            // 
            // btnScanPort
            // 
            this.btnScanPort.Location = new System.Drawing.Point(123, 222);
            this.btnScanPort.Name = "btnScanPort";
            this.btnScanPort.Size = new System.Drawing.Size(97, 23);
            this.btnScanPort.TabIndex = 28;
            this.btnScanPort.Text = "Scan for Ports";
            this.btnScanPort.UseVisualStyleBackColor = true;
            this.btnScanPort.Click += new System.EventHandler(this.btnScanPort_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(123, 353);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(97, 23);
            this.btnTest.TabIndex = 27;
            this.btnTest.Text = "Test Serial Port";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click_1);
            // 
            // btnApplyCs
            // 
            this.btnApplyCs.Location = new System.Drawing.Point(223, 222);
            this.btnApplyCs.Name = "btnApplyCs";
            this.btnApplyCs.Size = new System.Drawing.Size(97, 23);
            this.btnApplyCs.TabIndex = 26;
            this.btnApplyCs.Text = "Appy Changes";
            this.btnApplyCs.UseVisualStyleBackColor = true;
            this.btnApplyCs.Click += new System.EventHandler(this.btnApplyCs_Click);
            // 
            // cboHandshake
            // 
            this.cboHandshake.FormattingEnabled = true;
            this.cboHandshake.Items.AddRange(new object[] {
            "None",
            "XOnXOff",
            "RequestToSend",
            "RequestToSendXOnXOff"});
            this.cboHandshake.Location = new System.Drawing.Point(123, 140);
            this.cboHandshake.Name = "cboHandshake";
            this.cboHandshake.Size = new System.Drawing.Size(197, 22);
            this.cboHandshake.TabIndex = 25;
            // 
            // cboParityBit
            // 
            this.cboParityBit.FormattingEnabled = true;
            this.cboParityBit.Items.AddRange(new object[] {
            "None",
            "Even",
            "Mark",
            "Odd",
            "Space"});
            this.cboParityBit.Location = new System.Drawing.Point(123, 115);
            this.cboParityBit.Name = "cboParityBit";
            this.cboParityBit.Size = new System.Drawing.Size(197, 22);
            this.cboParityBit.TabIndex = 24;
            // 
            // cboStopBit
            // 
            this.cboStopBit.FormattingEnabled = true;
            this.cboStopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cboStopBit.Location = new System.Drawing.Point(123, 90);
            this.cboStopBit.Name = "cboStopBit";
            this.cboStopBit.Size = new System.Drawing.Size(197, 22);
            this.cboStopBit.TabIndex = 23;
            // 
            // cboDataBit
            // 
            this.cboDataBit.FormattingEnabled = true;
            this.cboDataBit.Items.AddRange(new object[] {
            "7 bits",
            "8 bits"});
            this.cboDataBit.Location = new System.Drawing.Point(123, 65);
            this.cboDataBit.Name = "cboDataBit";
            this.cboDataBit.Size = new System.Drawing.Size(197, 22);
            this.cboDataBit.TabIndex = 22;
            // 
            // cboBaud
            // 
            this.cboBaud.FormattingEnabled = true;
            this.cboBaud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cboBaud.Location = new System.Drawing.Point(123, 40);
            this.cboBaud.Name = "cboBaud";
            this.cboBaud.Size = new System.Drawing.Size(197, 22);
            this.cboBaud.TabIndex = 21;
            // 
            // cboDefPort
            // 
            this.cboDefPort.FormattingEnabled = true;
            this.cboDefPort.Location = new System.Drawing.Point(123, 15);
            this.cboDefPort.Name = "cboDefPort";
            this.cboDefPort.Size = new System.Drawing.Size(197, 22);
            this.cboDefPort.TabIndex = 20;
            // 
            // lblHandshake
            // 
            this.lblHandshake.AutoSize = true;
            this.lblHandshake.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandshake.Location = new System.Drawing.Point(18, 143);
            this.lblHandshake.Name = "lblHandshake";
            this.lblHandshake.Size = new System.Drawing.Size(62, 14);
            this.lblHandshake.TabIndex = 19;
            this.lblHandshake.Text = "Handshake";
            // 
            // lblParityBit
            // 
            this.lblParityBit.AutoSize = true;
            this.lblParityBit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParityBit.Location = new System.Drawing.Point(18, 118);
            this.lblParityBit.Name = "lblParityBit";
            this.lblParityBit.Size = new System.Drawing.Size(58, 14);
            this.lblParityBit.TabIndex = 18;
            this.lblParityBit.Text = "Parity Bits";
            // 
            // lblStopBit
            // 
            this.lblStopBit.AutoSize = true;
            this.lblStopBit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopBit.Location = new System.Drawing.Point(18, 93);
            this.lblStopBit.Name = "lblStopBit";
            this.lblStopBit.Size = new System.Drawing.Size(51, 14);
            this.lblStopBit.TabIndex = 17;
            this.lblStopBit.Text = "Stop Bits";
            // 
            // lblDataBit
            // 
            this.lblDataBit.AutoSize = true;
            this.lblDataBit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBit.Location = new System.Drawing.Point(18, 68);
            this.lblDataBit.Name = "lblDataBit";
            this.lblDataBit.Size = new System.Drawing.Size(53, 14);
            this.lblDataBit.TabIndex = 16;
            this.lblDataBit.Text = "Data Bits";
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaud.Location = new System.Drawing.Point(18, 43);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(58, 14);
            this.lblBaud.TabIndex = 15;
            this.lblBaud.Text = "Baud Rate";
            // 
            // lblDefPort
            // 
            this.lblDefPort.AutoSize = true;
            this.lblDefPort.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefPort.Location = new System.Drawing.Point(18, 18);
            this.lblDefPort.Name = "lblDefPort";
            this.lblDefPort.Size = new System.Drawing.Size(67, 14);
            this.lblDefPort.TabIndex = 14;
            this.lblDefPort.Text = "Default Port";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.btnUseDbSet);
            this.tabPage2.Controls.Add(this.btnDbTest);
            this.tabPage2.Controls.Add(this.txtDbPw);
            this.tabPage2.Controls.Add(this.lblDBPw);
            this.tabPage2.Controls.Add(this.txtDbUid);
            this.tabPage2.Controls.Add(this.lblDBUid);
            this.tabPage2.Controls.Add(this.txtDefDb);
            this.tabPage2.Controls.Add(this.lblDefDb);
            this.tabPage2.Controls.Add(this.txtDbPort);
            this.tabPage2.Controls.Add(this.txtDbHost);
            this.tabPage2.Controls.Add(this.lblDbPort);
            this.tabPage2.Controls.Add(this.lblDbHost);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(359, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Database Setting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUseDbSet
            // 
            this.btnUseDbSet.Location = new System.Drawing.Point(233, 143);
            this.btnUseDbSet.Name = "btnUseDbSet";
            this.btnUseDbSet.Size = new System.Drawing.Size(81, 23);
            this.btnUseDbSet.TabIndex = 26;
            this.btnUseDbSet.Text = "Use Setting";
            this.btnUseDbSet.UseVisualStyleBackColor = true;
            this.btnUseDbSet.Click += new System.EventHandler(this.btnUseDbSet_Click);
            // 
            // btnDbTest
            // 
            this.btnDbTest.Location = new System.Drawing.Point(122, 143);
            this.btnDbTest.Name = "btnDbTest";
            this.btnDbTest.Size = new System.Drawing.Size(108, 23);
            this.btnDbTest.TabIndex = 25;
            this.btnDbTest.Text = "Test Connection";
            this.btnDbTest.UseVisualStyleBackColor = true;
            this.btnDbTest.Click += new System.EventHandler(this.btnDbTest_Click);
            // 
            // txtDbPw
            // 
            this.txtDbPw.Location = new System.Drawing.Point(122, 115);
            this.txtDbPw.Name = "txtDbPw";
            this.txtDbPw.PasswordChar = '*';
            this.txtDbPw.Size = new System.Drawing.Size(192, 22);
            this.txtDbPw.TabIndex = 24;
            // 
            // lblDBPw
            // 
            this.lblDBPw.AutoSize = true;
            this.lblDBPw.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBPw.Location = new System.Drawing.Point(18, 118);
            this.lblDBPw.Name = "lblDBPw";
            this.lblDBPw.Size = new System.Drawing.Size(54, 14);
            this.lblDBPw.TabIndex = 23;
            this.lblDBPw.Text = "Password";
            // 
            // txtDbUid
            // 
            this.txtDbUid.Location = new System.Drawing.Point(122, 90);
            this.txtDbUid.Name = "txtDbUid";
            this.txtDbUid.Size = new System.Drawing.Size(192, 22);
            this.txtDbUid.TabIndex = 22;
            // 
            // lblDBUid
            // 
            this.lblDBUid.AutoSize = true;
            this.lblDBUid.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBUid.Location = new System.Drawing.Point(18, 93);
            this.lblDBUid.Name = "lblDBUid";
            this.lblDBUid.Size = new System.Drawing.Size(45, 14);
            this.lblDBUid.TabIndex = 21;
            this.lblDBUid.Text = "Login Id";
            // 
            // txtDefDb
            // 
            this.txtDefDb.Location = new System.Drawing.Point(122, 65);
            this.txtDefDb.Name = "txtDefDb";
            this.txtDefDb.Size = new System.Drawing.Size(192, 22);
            this.txtDefDb.TabIndex = 20;
            // 
            // lblDefDb
            // 
            this.lblDefDb.AutoSize = true;
            this.lblDefDb.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefDb.Location = new System.Drawing.Point(18, 68);
            this.lblDefDb.Name = "lblDefDb";
            this.lblDefDb.Size = new System.Drawing.Size(94, 14);
            this.lblDefDb.TabIndex = 19;
            this.lblDefDb.Text = "Default Database";
            // 
            // txtDbPort
            // 
            this.txtDbPort.Location = new System.Drawing.Point(122, 40);
            this.txtDbPort.MaxLength = 6;
            this.txtDbPort.Name = "txtDbPort";
            this.txtDbPort.Size = new System.Drawing.Size(72, 22);
            this.txtDbPort.TabIndex = 18;
            // 
            // txtDbHost
            // 
            this.txtDbHost.Location = new System.Drawing.Point(122, 15);
            this.txtDbHost.Name = "txtDbHost";
            this.txtDbHost.Size = new System.Drawing.Size(192, 22);
            this.txtDbHost.TabIndex = 17;
            // 
            // lblDbPort
            // 
            this.lblDbPort.AutoSize = true;
            this.lblDbPort.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDbPort.Location = new System.Drawing.Point(18, 43);
            this.lblDbPort.Name = "lblDbPort";
            this.lblDbPort.Size = new System.Drawing.Size(67, 14);
            this.lblDbPort.TabIndex = 16;
            this.lblDbPort.Text = "Default Port";
            // 
            // lblDbHost
            // 
            this.lblDbHost.AutoSize = true;
            this.lblDbHost.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDbHost.Location = new System.Drawing.Point(18, 18);
            this.lblDbHost.Name = "lblDbHost";
            this.lblDbHost.Size = new System.Drawing.Size(65, 14);
            this.lblDbHost.TabIndex = 15;
            this.lblDbHost.Text = "Host Server";
            // 
            // cboScanDelay
            // 
            this.cboScanDelay.FormattingEnabled = true;
            this.cboScanDelay.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "10"});
            this.cboScanDelay.Location = new System.Drawing.Point(123, 190);
            this.cboScanDelay.Name = "cboScanDelay";
            this.cboScanDelay.Size = new System.Drawing.Size(97, 22);
            this.cboScanDelay.TabIndex = 33;
            // 
            // lblScanDelay
            // 
            this.lblScanDelay.AutoSize = true;
            this.lblScanDelay.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanDelay.Location = new System.Drawing.Point(18, 193);
            this.lblScanDelay.Name = "lblScanDelay";
            this.lblScanDelay.Size = new System.Drawing.Size(62, 14);
            this.lblScanDelay.TabIndex = 32;
            this.lblScanDelay.Text = "Scan Delay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 34;
            this.label2.Text = "second(s)";
            // 
            // frmCATOSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 301);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCATOSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmCATOSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnApplyCs;
        private System.Windows.Forms.ComboBox cboHandshake;
        private System.Windows.Forms.ComboBox cboParityBit;
        private System.Windows.Forms.ComboBox cboStopBit;
        private System.Windows.Forms.ComboBox cboDataBit;
        private System.Windows.Forms.ComboBox cboBaud;
        private System.Windows.Forms.ComboBox cboDefPort;
        private System.Windows.Forms.Label lblHandshake;
        private System.Windows.Forms.Label lblParityBit;
        private System.Windows.Forms.Label lblStopBit;
        private System.Windows.Forms.Label lblDataBit;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.Label lblDefPort;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtDbPw;
        private System.Windows.Forms.Label lblDBPw;
        private System.Windows.Forms.TextBox txtDbUid;
        private System.Windows.Forms.Label lblDBUid;
        private System.Windows.Forms.TextBox txtDefDb;
        private System.Windows.Forms.Label lblDefDb;
        private System.Windows.Forms.TextBox txtDbPort;
        private System.Windows.Forms.TextBox txtDbHost;
        private System.Windows.Forms.Label lblDbPort;
        private System.Windows.Forms.Label lblDbHost;
        private System.Windows.Forms.Button btnUseDbSet;
        private System.Windows.Forms.Button btnDbTest;
        private System.Windows.Forms.Button btnScanPort;
        private System.Windows.Forms.CheckBox chkUseNullModem;
        private System.Windows.Forms.ComboBox cboDelay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboScanDelay;
        private System.Windows.Forms.Label lblScanDelay;
    }
}