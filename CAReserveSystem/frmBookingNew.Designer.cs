namespace CAReserveSystem
{
    partial class frmBookingNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookingNew));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbSaveBooking = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGuestLookup = new System.Windows.Forms.ToolStripButton();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.txtAccRate = new System.Windows.Forms.TextBox();
            this.btnClearGF = new System.Windows.Forms.Button();
            this.lblGEmail = new System.Windows.Forms.Label();
            this.txtGEmail = new System.Windows.Forms.TextBox();
            this.lblGMobile = new System.Windows.Forms.Label();
            this.txtGMobile = new System.Windows.Forms.TextBox();
            this.lblGLand = new System.Windows.Forms.Label();
            this.txtGLand = new System.Windows.Forms.TextBox();
            this.lblGAddr = new System.Windows.Forms.Label();
            this.txtGAddr = new System.Windows.Forms.TextBox();
            this.lblGMName = new System.Windows.Forms.Label();
            this.txtGMName = new System.Windows.Forms.TextBox();
            this.lblGFName = new System.Windows.Forms.Label();
            this.txtGFName = new System.Windows.Forms.TextBox();
            this.txtGLName = new System.Windows.Forms.TextBox();
            this.lblGLName = new System.Windows.Forms.Label();
            this.cmbGSalutation = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblGuestInfo = new System.Windows.Forms.Label();
            this.txtGCChild4below = new System.Windows.Forms.TextBox();
            this.txtGCChild4up = new System.Windows.Forms.TextBox();
            this.txtGCAdult = new System.Windows.Forms.TextBox();
            this.lblGCChild4below = new System.Windows.Forms.Label();
            this.lblGCChild4up = new System.Windows.Forms.Label();
            this.lblGCAdult = new System.Windows.Forms.Label();
            this.lblGuestCnt = new System.Windows.Forms.Label();
            this.dtpUsageTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpUsageFrom = new System.Windows.Forms.DateTimePicker();
            this.lblAccDuration = new System.Windows.Forms.Label();
            this.txtAccCap = new System.Windows.Forms.TextBox();
            this.lblAccCap = new System.Windows.Forms.Label();
            this.cmbAccRate = new System.Windows.Forms.ComboBox();
            this.lblAccRate = new System.Windows.Forms.Label();
            this.cmbAcc = new System.Windows.Forms.ComboBox();
            this.cmbAccType = new System.Windows.Forms.ComboBox();
            this.lblAcc = new System.Windows.Forms.Label();
            this.lblAccType = new System.Windows.Forms.Label();
            this.lblAccInfo = new System.Windows.Forms.Label();
            this.cmbBookingType = new System.Windows.Forms.ComboBox();
            this.lblBookingType = new System.Windows.Forms.Label();
            this.tsMenu.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSaveBooking,
            this.toolStripSeparator1,
            this.tsbGuestLookup});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(839, 39);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbSaveBooking
            // 
            this.tsbSaveBooking.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveBooking.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveBooking.Image")));
            this.tsbSaveBooking.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSaveBooking.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveBooking.Name = "tsbSaveBooking";
            this.tsbSaveBooking.Size = new System.Drawing.Size(36, 36);
            this.tsbSaveBooking.Text = "Save Booking";
            this.tsbSaveBooking.ToolTipText = "Save Booking";
            this.tsbSaveBooking.Click += new System.EventHandler(this.tsbSaveBooking_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbGuestLookup
            // 
            this.tsbGuestLookup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuestLookup.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuestLookup.Image")));
            this.tsbGuestLookup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbGuestLookup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuestLookup.Name = "tsbGuestLookup";
            this.tsbGuestLookup.Size = new System.Drawing.Size(36, 36);
            this.tsbGuestLookup.Text = "Guest Lookup";
            this.tsbGuestLookup.ToolTipText = "Guest Lookup";
            this.tsbGuestLookup.Click += new System.EventHandler(this.tsbGuestLookup_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.txtAccRate);
            this.pnlContainer.Controls.Add(this.btnClearGF);
            this.pnlContainer.Controls.Add(this.lblGEmail);
            this.pnlContainer.Controls.Add(this.txtGEmail);
            this.pnlContainer.Controls.Add(this.lblGMobile);
            this.pnlContainer.Controls.Add(this.txtGMobile);
            this.pnlContainer.Controls.Add(this.lblGLand);
            this.pnlContainer.Controls.Add(this.txtGLand);
            this.pnlContainer.Controls.Add(this.lblGAddr);
            this.pnlContainer.Controls.Add(this.txtGAddr);
            this.pnlContainer.Controls.Add(this.lblGMName);
            this.pnlContainer.Controls.Add(this.txtGMName);
            this.pnlContainer.Controls.Add(this.lblGFName);
            this.pnlContainer.Controls.Add(this.txtGFName);
            this.pnlContainer.Controls.Add(this.txtGLName);
            this.pnlContainer.Controls.Add(this.lblGLName);
            this.pnlContainer.Controls.Add(this.cmbGSalutation);
            this.pnlContainer.Controls.Add(this.label11);
            this.pnlContainer.Controls.Add(this.lblGuestInfo);
            this.pnlContainer.Controls.Add(this.txtGCChild4below);
            this.pnlContainer.Controls.Add(this.txtGCChild4up);
            this.pnlContainer.Controls.Add(this.txtGCAdult);
            this.pnlContainer.Controls.Add(this.lblGCChild4below);
            this.pnlContainer.Controls.Add(this.lblGCChild4up);
            this.pnlContainer.Controls.Add(this.lblGCAdult);
            this.pnlContainer.Controls.Add(this.lblGuestCnt);
            this.pnlContainer.Controls.Add(this.dtpUsageTo);
            this.pnlContainer.Controls.Add(this.label5);
            this.pnlContainer.Controls.Add(this.dtpUsageFrom);
            this.pnlContainer.Controls.Add(this.lblAccDuration);
            this.pnlContainer.Controls.Add(this.txtAccCap);
            this.pnlContainer.Controls.Add(this.lblAccCap);
            this.pnlContainer.Controls.Add(this.cmbAccRate);
            this.pnlContainer.Controls.Add(this.lblAccRate);
            this.pnlContainer.Controls.Add(this.cmbAcc);
            this.pnlContainer.Controls.Add(this.cmbAccType);
            this.pnlContainer.Controls.Add(this.lblAcc);
            this.pnlContainer.Controls.Add(this.lblAccType);
            this.pnlContainer.Controls.Add(this.lblAccInfo);
            this.pnlContainer.Controls.Add(this.cmbBookingType);
            this.pnlContainer.Controls.Add(this.lblBookingType);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 39);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(839, 370);
            this.pnlContainer.TabIndex = 1;
            // 
            // txtAccRate
            // 
            this.txtAccRate.BackColor = System.Drawing.Color.White;
            this.txtAccRate.Location = new System.Drawing.Point(290, 123);
            this.txtAccRate.Name = "txtAccRate";
            this.txtAccRate.ReadOnly = true;
            this.txtAccRate.Size = new System.Drawing.Size(94, 22);
            this.txtAccRate.TabIndex = 39;
            this.txtAccRate.Text = "0.00";
            this.txtAccRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClearGF
            // 
            this.btnClearGF.Location = new System.Drawing.Point(686, 8);
            this.btnClearGF.Name = "btnClearGF";
            this.btnClearGF.Size = new System.Drawing.Size(131, 25);
            this.btnClearGF.TabIndex = 18;
            this.btnClearGF.Text = "Clear Guest Fields";
            this.btnClearGF.UseVisualStyleBackColor = true;
            this.btnClearGF.Click += new System.EventHandler(this.btnClearGF_Click);
            // 
            // lblGEmail
            // 
            this.lblGEmail.AutoSize = true;
            this.lblGEmail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGEmail.Location = new System.Drawing.Point(463, 298);
            this.lblGEmail.Name = "lblGEmail";
            this.lblGEmail.Size = new System.Drawing.Size(77, 14);
            this.lblGEmail.TabIndex = 38;
            this.lblGEmail.Text = "Email Address";
            // 
            // txtGEmail
            // 
            this.txtGEmail.Location = new System.Drawing.Point(576, 295);
            this.txtGEmail.Name = "txtGEmail";
            this.txtGEmail.Size = new System.Drawing.Size(241, 22);
            this.txtGEmail.TabIndex = 13;
            // 
            // lblGMobile
            // 
            this.lblGMobile.AutoSize = true;
            this.lblGMobile.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGMobile.Location = new System.Drawing.Point(463, 274);
            this.lblGMobile.Name = "lblGMobile";
            this.lblGMobile.Size = new System.Drawing.Size(41, 14);
            this.lblGMobile.TabIndex = 36;
            this.lblGMobile.Text = "Mobile";
            // 
            // txtGMobile
            // 
            this.txtGMobile.Location = new System.Drawing.Point(576, 271);
            this.txtGMobile.Name = "txtGMobile";
            this.txtGMobile.Size = new System.Drawing.Size(241, 22);
            this.txtGMobile.TabIndex = 12;
            // 
            // lblGLand
            // 
            this.lblGLand.AutoSize = true;
            this.lblGLand.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGLand.Location = new System.Drawing.Point(463, 250);
            this.lblGLand.Name = "lblGLand";
            this.lblGLand.Size = new System.Drawing.Size(48, 14);
            this.lblGLand.TabIndex = 34;
            this.lblGLand.Text = "Landline";
            // 
            // txtGLand
            // 
            this.txtGLand.Location = new System.Drawing.Point(576, 247);
            this.txtGLand.Name = "txtGLand";
            this.txtGLand.Size = new System.Drawing.Size(241, 22);
            this.txtGLand.TabIndex = 11;
            // 
            // lblGAddr
            // 
            this.lblGAddr.AutoSize = true;
            this.lblGAddr.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGAddr.Location = new System.Drawing.Point(463, 173);
            this.lblGAddr.Name = "lblGAddr";
            this.lblGAddr.Size = new System.Drawing.Size(46, 14);
            this.lblGAddr.TabIndex = 32;
            this.lblGAddr.Text = "Address";
            // 
            // txtGAddr
            // 
            this.txtGAddr.Location = new System.Drawing.Point(576, 170);
            this.txtGAddr.Multiline = true;
            this.txtGAddr.Name = "txtGAddr";
            this.txtGAddr.Size = new System.Drawing.Size(241, 75);
            this.txtGAddr.TabIndex = 10;
            // 
            // lblGMName
            // 
            this.lblGMName.AutoSize = true;
            this.lblGMName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGMName.Location = new System.Drawing.Point(463, 149);
            this.lblGMName.Name = "lblGMName";
            this.lblGMName.Size = new System.Drawing.Size(74, 14);
            this.lblGMName.TabIndex = 30;
            this.lblGMName.Text = "Middle Name";
            // 
            // txtGMName
            // 
            this.txtGMName.Location = new System.Drawing.Point(576, 146);
            this.txtGMName.Name = "txtGMName";
            this.txtGMName.Size = new System.Drawing.Size(241, 22);
            this.txtGMName.TabIndex = 9;
            // 
            // lblGFName
            // 
            this.lblGFName.AutoSize = true;
            this.lblGFName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGFName.Location = new System.Drawing.Point(463, 125);
            this.lblGFName.Name = "lblGFName";
            this.lblGFName.Size = new System.Drawing.Size(62, 14);
            this.lblGFName.TabIndex = 28;
            this.lblGFName.Text = "First Name";
            // 
            // txtGFName
            // 
            this.txtGFName.Location = new System.Drawing.Point(576, 122);
            this.txtGFName.Name = "txtGFName";
            this.txtGFName.Size = new System.Drawing.Size(241, 22);
            this.txtGFName.TabIndex = 8;
            // 
            // txtGLName
            // 
            this.txtGLName.Location = new System.Drawing.Point(576, 98);
            this.txtGLName.Name = "txtGLName";
            this.txtGLName.Size = new System.Drawing.Size(241, 22);
            this.txtGLName.TabIndex = 7;
            // 
            // lblGLName
            // 
            this.lblGLName.AutoSize = true;
            this.lblGLName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGLName.Location = new System.Drawing.Point(463, 101);
            this.lblGLName.Name = "lblGLName";
            this.lblGLName.Size = new System.Drawing.Size(60, 14);
            this.lblGLName.TabIndex = 25;
            this.lblGLName.Text = "Last Name";
            // 
            // cmbGSalutation
            // 
            this.cmbGSalutation.BackColor = System.Drawing.Color.White;
            this.cmbGSalutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGSalutation.FormattingEnabled = true;
            this.cmbGSalutation.Items.AddRange(new object[] {
            "Mr.",
            "Ms.",
            "Mrs."});
            this.cmbGSalutation.Location = new System.Drawing.Point(576, 74);
            this.cmbGSalutation.Name = "cmbGSalutation";
            this.cmbGSalutation.Size = new System.Drawing.Size(241, 22);
            this.cmbGSalutation.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(463, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 14);
            this.label11.TabIndex = 23;
            this.label11.Text = "Salutation";
            // 
            // lblGuestInfo
            // 
            this.lblGuestInfo.AutoSize = true;
            this.lblGuestInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestInfo.Location = new System.Drawing.Point(445, 49);
            this.lblGuestInfo.Name = "lblGuestInfo";
            this.lblGuestInfo.Size = new System.Drawing.Size(97, 14);
            this.lblGuestInfo.TabIndex = 22;
            this.lblGuestInfo.Text = "Guest Information";
            // 
            // txtGCChild4below
            // 
            this.txtGCChild4below.Location = new System.Drawing.Point(281, 247);
            this.txtGCChild4below.Name = "txtGCChild4below";
            this.txtGCChild4below.Size = new System.Drawing.Size(63, 22);
            this.txtGCChild4below.TabIndex = 5;
            this.txtGCChild4below.Text = "0";
            this.txtGCChild4below.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGCChild4up
            // 
            this.txtGCChild4up.Location = new System.Drawing.Point(281, 223);
            this.txtGCChild4up.Name = "txtGCChild4up";
            this.txtGCChild4up.Size = new System.Drawing.Size(63, 22);
            this.txtGCChild4up.TabIndex = 4;
            this.txtGCChild4up.Text = "0";
            this.txtGCChild4up.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGCAdult
            // 
            this.txtGCAdult.Location = new System.Drawing.Point(281, 199);
            this.txtGCAdult.Name = "txtGCAdult";
            this.txtGCAdult.Size = new System.Drawing.Size(63, 22);
            this.txtGCAdult.TabIndex = 3;
            this.txtGCAdult.Text = "0";
            this.txtGCAdult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGCChild4below
            // 
            this.lblGCChild4below.AutoSize = true;
            this.lblGCChild4below.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGCChild4below.Location = new System.Drawing.Point(140, 250);
            this.lblGCChild4below.Name = "lblGCChild4below";
            this.lblGCChild4below.Size = new System.Drawing.Size(97, 14);
            this.lblGCChild4below.TabIndex = 18;
            this.lblGCChild4below.Text = "Children below 4ft";
            // 
            // lblGCChild4up
            // 
            this.lblGCChild4up.AutoSize = true;
            this.lblGCChild4up.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGCChild4up.Location = new System.Drawing.Point(140, 226);
            this.lblGCChild4up.Name = "lblGCChild4up";
            this.lblGCChild4up.Size = new System.Drawing.Size(110, 14);
            this.lblGCChild4up.TabIndex = 17;
            this.lblGCChild4up.Text = "Senior Citizen / PWD";
            // 
            // lblGCAdult
            // 
            this.lblGCAdult.AutoSize = true;
            this.lblGCAdult.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGCAdult.Location = new System.Drawing.Point(140, 202);
            this.lblGCAdult.Name = "lblGCAdult";
            this.lblGCAdult.Size = new System.Drawing.Size(33, 14);
            this.lblGCAdult.TabIndex = 16;
            this.lblGCAdult.Text = "Adult";
            // 
            // lblGuestCnt
            // 
            this.lblGuestCnt.AutoSize = true;
            this.lblGuestCnt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestCnt.Location = new System.Drawing.Point(30, 202);
            this.lblGuestCnt.Name = "lblGuestCnt";
            this.lblGuestCnt.Size = new System.Drawing.Size(67, 14);
            this.lblGuestCnt.TabIndex = 15;
            this.lblGuestCnt.Text = "Guest Count";
            // 
            // dtpUsageTo
            // 
            this.dtpUsageTo.Enabled = false;
            this.dtpUsageTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpUsageTo.Location = new System.Drawing.Point(281, 171);
            this.dtpUsageTo.Name = "dtpUsageTo";
            this.dtpUsageTo.Size = new System.Drawing.Size(103, 22);
            this.dtpUsageTo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "to";
            // 
            // dtpUsageFrom
            // 
            this.dtpUsageFrom.Enabled = false;
            this.dtpUsageFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpUsageFrom.Location = new System.Drawing.Point(143, 171);
            this.dtpUsageFrom.Name = "dtpUsageFrom";
            this.dtpUsageFrom.Size = new System.Drawing.Size(103, 22);
            this.dtpUsageFrom.TabIndex = 5;
            // 
            // lblAccDuration
            // 
            this.lblAccDuration.AutoSize = true;
            this.lblAccDuration.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccDuration.Location = new System.Drawing.Point(30, 174);
            this.lblAccDuration.Name = "lblAccDuration";
            this.lblAccDuration.Size = new System.Drawing.Size(84, 14);
            this.lblAccDuration.TabIndex = 11;
            this.lblAccDuration.Text = "Usage Duration";
            // 
            // txtAccCap
            // 
            this.txtAccCap.BackColor = System.Drawing.Color.White;
            this.txtAccCap.Location = new System.Drawing.Point(143, 147);
            this.txtAccCap.Name = "txtAccCap";
            this.txtAccCap.ReadOnly = true;
            this.txtAccCap.Size = new System.Drawing.Size(63, 22);
            this.txtAccCap.TabIndex = 4;
            this.txtAccCap.Text = "0";
            this.txtAccCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAccCap
            // 
            this.lblAccCap.AutoSize = true;
            this.lblAccCap.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccCap.Location = new System.Drawing.Point(30, 150);
            this.lblAccCap.Name = "lblAccCap";
            this.lblAccCap.Size = new System.Drawing.Size(49, 14);
            this.lblAccCap.TabIndex = 9;
            this.lblAccCap.Text = "Capacity";
            // 
            // cmbAccRate
            // 
            this.cmbAccRate.BackColor = System.Drawing.Color.White;
            this.cmbAccRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccRate.Enabled = false;
            this.cmbAccRate.FormattingEnabled = true;
            this.cmbAccRate.Items.AddRange(new object[] {
            "Daytime",
            "Night time",
            "Floating Time"});
            this.cmbAccRate.Location = new System.Drawing.Point(143, 123);
            this.cmbAccRate.Name = "cmbAccRate";
            this.cmbAccRate.Size = new System.Drawing.Size(144, 22);
            this.cmbAccRate.TabIndex = 3;
            // 
            // lblAccRate
            // 
            this.lblAccRate.AutoSize = true;
            this.lblAccRate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccRate.Location = new System.Drawing.Point(30, 126);
            this.lblAccRate.Name = "lblAccRate";
            this.lblAccRate.Size = new System.Drawing.Size(30, 14);
            this.lblAccRate.TabIndex = 7;
            this.lblAccRate.Text = "Rate";
            // 
            // cmbAcc
            // 
            this.cmbAcc.BackColor = System.Drawing.Color.White;
            this.cmbAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcc.FormattingEnabled = true;
            this.cmbAcc.Location = new System.Drawing.Point(143, 99);
            this.cmbAcc.Name = "cmbAcc";
            this.cmbAcc.Size = new System.Drawing.Size(241, 22);
            this.cmbAcc.TabIndex = 2;
            this.cmbAcc.SelectedValueChanged += new System.EventHandler(this.cmbAcc_SelectedValueChanged);
            // 
            // cmbAccType
            // 
            this.cmbAccType.BackColor = System.Drawing.Color.White;
            this.cmbAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccType.FormattingEnabled = true;
            this.cmbAccType.Items.AddRange(new object[] {
            "Walk-In",
            "Phone In",
            "Online"});
            this.cmbAccType.Location = new System.Drawing.Point(143, 75);
            this.cmbAccType.Name = "cmbAccType";
            this.cmbAccType.Size = new System.Drawing.Size(241, 22);
            this.cmbAccType.TabIndex = 1;
            this.cmbAccType.SelectedValueChanged += new System.EventHandler(this.cmbAccType_SelectedValueChanged);
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcc.Location = new System.Drawing.Point(30, 102);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(87, 14);
            this.lblAcc.TabIndex = 4;
            this.lblAcc.Text = "Accommodation\r\n";
            // 
            // lblAccType
            // 
            this.lblAccType.AutoSize = true;
            this.lblAccType.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccType.Location = new System.Drawing.Point(30, 78);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(31, 14);
            this.lblAccType.TabIndex = 3;
            this.lblAccType.Text = "Type";
            // 
            // lblAccInfo
            // 
            this.lblAccInfo.AutoSize = true;
            this.lblAccInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccInfo.Location = new System.Drawing.Point(12, 49);
            this.lblAccInfo.Name = "lblAccInfo";
            this.lblAccInfo.Size = new System.Drawing.Size(148, 14);
            this.lblAccInfo.TabIndex = 2;
            this.lblAccInfo.Text = "Accommodation Information";
            // 
            // cmbBookingType
            // 
            this.cmbBookingType.BackColor = System.Drawing.Color.White;
            this.cmbBookingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingType.FormattingEnabled = true;
            this.cmbBookingType.Items.AddRange(new object[] {
            "Walk-In",
            "Phone In",
            "Online"});
            this.cmbBookingType.Location = new System.Drawing.Point(143, 8);
            this.cmbBookingType.Name = "cmbBookingType";
            this.cmbBookingType.Size = new System.Drawing.Size(241, 22);
            this.cmbBookingType.TabIndex = 0;
            // 
            // lblBookingType
            // 
            this.lblBookingType.AutoSize = true;
            this.lblBookingType.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingType.Location = new System.Drawing.Point(12, 11);
            this.lblBookingType.Name = "lblBookingType";
            this.lblBookingType.Size = new System.Drawing.Size(74, 14);
            this.lblBookingType.TabIndex = 0;
            this.lblBookingType.Text = "Booking Type";
            // 
            // frmBookingNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 409);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.tsMenu);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookingNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Booking";
            this.Load += new System.EventHandler(this.frmBookingNew_Load);
            this.GotFocus += new System.EventHandler(this.frmBookingNew_GotFocus);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbSaveBooking;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.Label lblAccInfo;
        private System.Windows.Forms.ComboBox cmbBookingType;
        private System.Windows.Forms.Label lblBookingType;
        private System.Windows.Forms.Label lblAccDuration;
        private System.Windows.Forms.TextBox txtAccCap;
        private System.Windows.Forms.Label lblAccCap;
        private System.Windows.Forms.ComboBox cmbAccRate;
        private System.Windows.Forms.Label lblAccRate;
        private System.Windows.Forms.ComboBox cmbAcc;
        private System.Windows.Forms.ComboBox cmbAccType;
        private System.Windows.Forms.TextBox txtGCChild4below;
        private System.Windows.Forms.TextBox txtGCChild4up;
        private System.Windows.Forms.TextBox txtGCAdult;
        private System.Windows.Forms.Label lblGCChild4below;
        private System.Windows.Forms.Label lblGCChild4up;
        private System.Windows.Forms.Label lblGCAdult;
        private System.Windows.Forms.Label lblGuestCnt;
        private System.Windows.Forms.DateTimePicker dtpUsageTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpUsageFrom;
        private System.Windows.Forms.ComboBox cmbGSalutation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblGuestInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbGuestLookup;
        private System.Windows.Forms.Label lblGEmail;
        private System.Windows.Forms.TextBox txtGEmail;
        private System.Windows.Forms.Label lblGMobile;
        private System.Windows.Forms.TextBox txtGMobile;
        private System.Windows.Forms.Label lblGLand;
        private System.Windows.Forms.TextBox txtGLand;
        private System.Windows.Forms.Label lblGAddr;
        private System.Windows.Forms.TextBox txtGAddr;
        private System.Windows.Forms.Label lblGMName;
        private System.Windows.Forms.TextBox txtGMName;
        private System.Windows.Forms.Label lblGFName;
        private System.Windows.Forms.TextBox txtGFName;
        private System.Windows.Forms.TextBox txtGLName;
        private System.Windows.Forms.Label lblGLName;
        private System.Windows.Forms.Button btnClearGF;
        private System.Windows.Forms.TextBox txtAccRate;
    }
}