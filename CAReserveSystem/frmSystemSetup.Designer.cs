namespace CAReserveSystem
{
    partial class frmSystemSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing = false)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystemSetup));
            this.tcSystem = new System.Windows.Forms.TabControl();
            this.tpCompany = new System.Windows.Forms.TabPage();
            this.pnlApplyComp = new System.Windows.Forms.Panel();
            this.btnCancelComp = new System.Windows.Forms.Button();
            this.btnApplyComp = new System.Windows.Forms.Button();
            this.txtProps = new System.Windows.Forms.TextBox();
            this.txtTIN = new System.Windows.Forms.TextBox();
            this.txtContacts = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblProps = new System.Windows.Forms.Label();
            this.lblTIN = new System.Windows.Forms.Label();
            this.lblContacts = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.tpServer = new System.Windows.Forms.TabPage();
            this.pnlApplyDb = new System.Windows.Forms.Panel();
            this.btnTestCon = new System.Windows.Forms.Button();
            this.btnCancelDb = new System.Windows.Forms.Button();
            this.btnApplyDb = new System.Windows.Forms.Button();
            this.txtLPW = new System.Windows.Forms.TextBox();
            this.lblLWD = new System.Windows.Forms.Label();
            this.txtLID = new System.Windows.Forms.TextBox();
            this.lblLID = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLicense = new System.Windows.Forms.Button();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.lblLicense = new System.Windows.Forms.Label();
            this.ofdPic = new System.Windows.Forms.OpenFileDialog();
            this.tcSystem.SuspendLayout();
            this.tpCompany.SuspendLayout();
            this.pnlApplyComp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tpServer.SuspendLayout();
            this.pnlApplyDb.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSystem
            // 
            this.tcSystem.Controls.Add(this.tpCompany);
            this.tcSystem.Controls.Add(this.tpServer);
            this.tcSystem.Controls.Add(this.tabPage1);
            this.tcSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSystem.Location = new System.Drawing.Point(0, 0);
            this.tcSystem.Name = "tcSystem";
            this.tcSystem.SelectedIndex = 0;
            this.tcSystem.Size = new System.Drawing.Size(670, 383);
            this.tcSystem.TabIndex = 0;
            // 
            // tpCompany
            // 
            this.tpCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpCompany.Controls.Add(this.pnlApplyComp);
            this.tpCompany.Controls.Add(this.txtProps);
            this.tpCompany.Controls.Add(this.txtTIN);
            this.tpCompany.Controls.Add(this.txtContacts);
            this.tpCompany.Controls.Add(this.txtAddress);
            this.tpCompany.Controls.Add(this.txtCompany);
            this.tpCompany.Controls.Add(this.lblProps);
            this.tpCompany.Controls.Add(this.lblTIN);
            this.tpCompany.Controls.Add(this.lblContacts);
            this.tpCompany.Controls.Add(this.lblAddress);
            this.tpCompany.Controls.Add(this.picLogo);
            this.tpCompany.Controls.Add(this.lblCompany);
            this.tpCompany.Location = new System.Drawing.Point(4, 23);
            this.tpCompany.Name = "tpCompany";
            this.tpCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompany.Size = new System.Drawing.Size(662, 356);
            this.tpCompany.TabIndex = 0;
            this.tpCompany.Text = "Company Profile";
            this.tpCompany.UseVisualStyleBackColor = true;
            // 
            // pnlApplyComp
            // 
            this.pnlApplyComp.Controls.Add(this.btnCancelComp);
            this.pnlApplyComp.Controls.Add(this.btnApplyComp);
            this.pnlApplyComp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlApplyComp.Location = new System.Drawing.Point(3, 320);
            this.pnlApplyComp.Name = "pnlApplyComp";
            this.pnlApplyComp.Size = new System.Drawing.Size(654, 31);
            this.pnlApplyComp.TabIndex = 11;
            // 
            // btnCancelComp
            // 
            this.btnCancelComp.Location = new System.Drawing.Point(574, 3);
            this.btnCancelComp.Name = "btnCancelComp";
            this.btnCancelComp.Size = new System.Drawing.Size(77, 25);
            this.btnCancelComp.TabIndex = 1;
            this.btnCancelComp.Text = "Cancel";
            this.btnCancelComp.UseVisualStyleBackColor = true;
            // 
            // btnApplyComp
            // 
            this.btnApplyComp.Location = new System.Drawing.Point(459, 3);
            this.btnApplyComp.Name = "btnApplyComp";
            this.btnApplyComp.Size = new System.Drawing.Size(114, 25);
            this.btnApplyComp.TabIndex = 0;
            this.btnApplyComp.Text = "Apply Changes";
            this.btnApplyComp.UseVisualStyleBackColor = true;
            this.btnApplyComp.Click += new System.EventHandler(this.btnApplyComp_Click);
            // 
            // txtProps
            // 
            this.txtProps.Location = new System.Drawing.Point(332, 121);
            this.txtProps.Multiline = true;
            this.txtProps.Name = "txtProps";
            this.txtProps.Size = new System.Drawing.Size(321, 65);
            this.txtProps.TabIndex = 10;
            // 
            // txtTIN
            // 
            this.txtTIN.Location = new System.Drawing.Point(332, 97);
            this.txtTIN.Name = "txtTIN";
            this.txtTIN.Size = new System.Drawing.Size(321, 22);
            this.txtTIN.TabIndex = 9;
            // 
            // txtContacts
            // 
            this.txtContacts.Location = new System.Drawing.Point(332, 73);
            this.txtContacts.Name = "txtContacts";
            this.txtContacts.Size = new System.Drawing.Size(321, 22);
            this.txtContacts.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(332, 30);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(321, 41);
            this.txtAddress.TabIndex = 7;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(332, 6);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(321, 22);
            this.txtCompany.TabIndex = 6;
            // 
            // lblProps
            // 
            this.lblProps.AutoSize = true;
            this.lblProps.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProps.Location = new System.Drawing.Point(211, 124);
            this.lblProps.Name = "lblProps";
            this.lblProps.Size = new System.Drawing.Size(66, 14);
            this.lblProps.TabIndex = 5;
            this.lblProps.Text = "Proprietor/s";
            // 
            // lblTIN
            // 
            this.lblTIN.AutoSize = true;
            this.lblTIN.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIN.Location = new System.Drawing.Point(211, 100);
            this.lblTIN.Name = "lblTIN";
            this.lblTIN.Size = new System.Drawing.Size(24, 14);
            this.lblTIN.TabIndex = 4;
            this.lblTIN.Text = "TIN";
            // 
            // lblContacts
            // 
            this.lblContacts.AutoSize = true;
            this.lblContacts.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacts.Location = new System.Drawing.Point(211, 76);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(105, 14);
            this.lblContacts.TabIndex = 3;
            this.lblContacts.Text = "Contact Information";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(211, 33);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(46, 14);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(7, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(182, 128);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(211, 9);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(86, 14);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "Company Name";
            // 
            // tpServer
            // 
            this.tpServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpServer.Controls.Add(this.pnlApplyDb);
            this.tpServer.Controls.Add(this.txtLPW);
            this.tpServer.Controls.Add(this.lblLWD);
            this.tpServer.Controls.Add(this.txtLID);
            this.tpServer.Controls.Add(this.lblLID);
            this.tpServer.Controls.Add(this.txtDatabase);
            this.tpServer.Controls.Add(this.lblDatabase);
            this.tpServer.Controls.Add(this.txtPort);
            this.tpServer.Controls.Add(this.lblPort);
            this.tpServer.Controls.Add(this.txtServer);
            this.tpServer.Controls.Add(this.lblServer);
            this.tpServer.Location = new System.Drawing.Point(4, 23);
            this.tpServer.Name = "tpServer";
            this.tpServer.Padding = new System.Windows.Forms.Padding(3);
            this.tpServer.Size = new System.Drawing.Size(662, 356);
            this.tpServer.TabIndex = 1;
            this.tpServer.Text = "Server Configuration";
            this.tpServer.UseVisualStyleBackColor = true;
            // 
            // pnlApplyDb
            // 
            this.pnlApplyDb.Controls.Add(this.btnTestCon);
            this.pnlApplyDb.Controls.Add(this.btnCancelDb);
            this.pnlApplyDb.Controls.Add(this.btnApplyDb);
            this.pnlApplyDb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlApplyDb.Location = new System.Drawing.Point(3, 320);
            this.pnlApplyDb.Name = "pnlApplyDb";
            this.pnlApplyDb.Size = new System.Drawing.Size(654, 31);
            this.pnlApplyDb.TabIndex = 17;
            // 
            // btnTestCon
            // 
            this.btnTestCon.Location = new System.Drawing.Point(4, 3);
            this.btnTestCon.Name = "btnTestCon";
            this.btnTestCon.Size = new System.Drawing.Size(114, 25);
            this.btnTestCon.TabIndex = 2;
            this.btnTestCon.Text = "Test Connection";
            this.btnTestCon.UseVisualStyleBackColor = true;
            this.btnTestCon.Click += new System.EventHandler(this.btnTestCon_Click);
            // 
            // btnCancelDb
            // 
            this.btnCancelDb.Location = new System.Drawing.Point(574, 3);
            this.btnCancelDb.Name = "btnCancelDb";
            this.btnCancelDb.Size = new System.Drawing.Size(77, 25);
            this.btnCancelDb.TabIndex = 1;
            this.btnCancelDb.Text = "Cancel";
            this.btnCancelDb.UseVisualStyleBackColor = true;
            // 
            // btnApplyDb
            // 
            this.btnApplyDb.Location = new System.Drawing.Point(459, 3);
            this.btnApplyDb.Name = "btnApplyDb";
            this.btnApplyDb.Size = new System.Drawing.Size(114, 25);
            this.btnApplyDb.TabIndex = 0;
            this.btnApplyDb.Text = "Apply Changes";
            this.btnApplyDb.UseVisualStyleBackColor = true;
            this.btnApplyDb.Click += new System.EventHandler(this.btnApplyDb_Click);
            // 
            // txtLPW
            // 
            this.txtLPW.Location = new System.Drawing.Point(133, 102);
            this.txtLPW.Name = "txtLPW";
            this.txtLPW.PasswordChar = '*';
            this.txtLPW.Size = new System.Drawing.Size(321, 22);
            this.txtLPW.TabIndex = 16;
            // 
            // lblLWD
            // 
            this.lblLWD.AutoSize = true;
            this.lblLWD.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLWD.Location = new System.Drawing.Point(12, 105);
            this.lblLWD.Name = "lblLWD";
            this.lblLWD.Size = new System.Drawing.Size(54, 14);
            this.lblLWD.TabIndex = 15;
            this.lblLWD.Text = "Password";
            // 
            // txtLID
            // 
            this.txtLID.Location = new System.Drawing.Point(133, 78);
            this.txtLID.Name = "txtLID";
            this.txtLID.Size = new System.Drawing.Size(321, 22);
            this.txtLID.TabIndex = 14;
            // 
            // lblLID
            // 
            this.lblLID.AutoSize = true;
            this.lblLID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLID.Location = new System.Drawing.Point(12, 81);
            this.lblLID.Name = "lblLID";
            this.lblLID.Size = new System.Drawing.Size(58, 14);
            this.lblLID.TabIndex = 13;
            this.lblLID.Text = "Account Id";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(133, 54);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(321, 22);
            this.txtDatabase.TabIndex = 12;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabase.Location = new System.Drawing.Point(12, 57);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(94, 14);
            this.lblDatabase.TabIndex = 11;
            this.lblDatabase.Text = "Default Database";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(133, 30);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(83, 22);
            this.txtPort.TabIndex = 10;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(12, 33);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(27, 14);
            this.lblPort.TabIndex = 9;
            this.lblPort.Text = "Port";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(133, 6);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(321, 22);
            this.txtServer.TabIndex = 8;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(12, 9);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(65, 14);
            this.lblServer.TabIndex = 7;
            this.lblServer.Text = "Server Host";
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btnLicense);
            this.tabPage1.Controls.Add(this.txtLicense);
            this.tabPage1.Controls.Add(this.lblLicense);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(662, 356);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "License";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLicense
            // 
            this.btnLicense.Location = new System.Drawing.Point(325, 83);
            this.btnLicense.Name = "btnLicense";
            this.btnLicense.Size = new System.Drawing.Size(124, 25);
            this.btnLicense.TabIndex = 13;
            this.btnLicense.Text = "Activate License";
            this.btnLicense.UseVisualStyleBackColor = true;
            this.btnLicense.Click += new System.EventHandler(this.btnLicense_Click);
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(128, 12);
            this.txtLicense.Multiline = true;
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(321, 65);
            this.txtLicense.TabIndex = 12;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.Location = new System.Drawing.Point(7, 15);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(65, 14);
            this.lblLicense.TabIndex = 11;
            this.lblLicense.Text = "License Key";
            // 
            // ofdPic
            // 
            this.ofdPic.FileName = "Image";
            this.ofdPic.Filter = "Image Files | *.jpeg; *.jpg;*.png; *.bmp";
            // 
            // frmSystemSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 383);
            this.Controls.Add(this.tcSystem);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSystemSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Setup";
            this.Load += new System.EventHandler(this.frmSystemSetup_Load);
            this.tcSystem.ResumeLayout(false);
            this.tpCompany.ResumeLayout(false);
            this.tpCompany.PerformLayout();
            this.pnlApplyComp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tpServer.ResumeLayout(false);
            this.tpServer.PerformLayout();
            this.pnlApplyDb.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private global::System.Windows.Forms.TabControl tcSystem;
        private global::System.Windows.Forms.TabPage tpCompany;
        private global::System.Windows.Forms.TabPage tpServer;
        private global::System.Windows.Forms.PictureBox picLogo;
        private global::System.Windows.Forms.Label lblCompany;
        private global::System.Windows.Forms.OpenFileDialog ofdPic;
        private global::System.Windows.Forms.TextBox txtProps;
        private global::System.Windows.Forms.TextBox txtTIN;
        private global::System.Windows.Forms.TextBox txtContacts;
        private global::System.Windows.Forms.TextBox txtAddress;
        private global::System.Windows.Forms.TextBox txtCompany;
        private global::System.Windows.Forms.Label lblProps;
        private global::System.Windows.Forms.Label lblTIN;
        private global::System.Windows.Forms.Label lblContacts;
        private global::System.Windows.Forms.Label lblAddress;
        private global::System.Windows.Forms.TextBox txtLPW;
        private global::System.Windows.Forms.Label lblLWD;
        private global::System.Windows.Forms.TextBox txtLID;
        private global::System.Windows.Forms.Label lblLID;
        private global::System.Windows.Forms.TextBox txtDatabase;
        private global::System.Windows.Forms.Label lblDatabase;
        private global::System.Windows.Forms.TextBox txtPort;
        private global::System.Windows.Forms.Label lblPort;
        private global::System.Windows.Forms.TextBox txtServer;
        private global::System.Windows.Forms.Label lblServer;
        private global::System.Windows.Forms.Panel pnlApplyComp;
        private global::System.Windows.Forms.Button btnCancelComp;
        private global::System.Windows.Forms.Button btnApplyComp;
        private global::System.Windows.Forms.Panel pnlApplyDb;
        private global::System.Windows.Forms.Button btnTestCon;
        private global::System.Windows.Forms.Button btnCancelDb;
        private global::System.Windows.Forms.Button btnApplyDb;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Button btnLicense;
    }
}