namespace CAReserveSystem
{
    partial class mdiCAMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiCAMain));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.tsslLogUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLogUser1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUserRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUserRole1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCurrDatetime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCurrDatetime1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiReserve = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAccomodation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuestRates = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReports = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportDaily = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportReserve = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportInv = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSignIn = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSpacer = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlSpacer1 = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.timerdt = new System.Windows.Forms.Timer(this.components);
            this.stsStatus.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.msMain.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // stsStatus
            // 
            this.stsStatus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslLogUser,
            this.tsslLogUser1,
            this.tsslUserRole,
            this.tsslUserRole1,
            this.tsslCurrDatetime,
            this.tsslCurrDatetime1});
            this.stsStatus.Location = new System.Drawing.Point(0, 412);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(969, 23);
            this.stsStatus.TabIndex = 5;
            // 
            // tsslLogUser
            // 
            this.tsslLogUser.Name = "tsslLogUser";
            this.tsslLogUser.Size = new System.Drawing.Size(82, 18);
            this.tsslLogUser.Text = "Logged User : ";
            // 
            // tsslLogUser1
            // 
            this.tsslLogUser1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslLogUser1.Name = "tsslLogUser1";
            this.tsslLogUser1.Size = new System.Drawing.Size(19, 18);
            this.tsslLogUser1.Text = "--";
            // 
            // tsslUserRole
            // 
            this.tsslUserRole.Name = "tsslUserRole";
            this.tsslUserRole.Size = new System.Drawing.Size(66, 18);
            this.tsslUserRole.Text = "User Role :";
            // 
            // tsslUserRole1
            // 
            this.tsslUserRole1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslUserRole1.Name = "tsslUserRole1";
            this.tsslUserRole1.Size = new System.Drawing.Size(19, 18);
            this.tsslUserRole1.Text = "--";
            // 
            // tsslCurrDatetime
            // 
            this.tsslCurrDatetime.Name = "tsslCurrDatetime";
            this.tsslCurrDatetime.Size = new System.Drawing.Size(125, 18);
            this.tsslCurrDatetime.Text = "Current Date && Time : ";
            // 
            // tsslCurrDatetime1
            // 
            this.tsslCurrDatetime1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslCurrDatetime1.Name = "tsslCurrDatetime1";
            this.tsslCurrDatetime1.Size = new System.Drawing.Size(19, 18);
            this.tsslCurrDatetime1.Text = "--";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.msMain);
            this.pnlMenu.Controls.Add(this.pnlSpacer);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Controls.Add(this.pnlSpacer1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(231, 412);
            this.pnlMenu.TabIndex = 6;
            // 
            // msMain
            // 
            this.msMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msMain.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReserve,
            this.tsmiBooking,
            this.tsmiMaintenance,
            this.tsmiReports,
            this.tsmiSignOut,
            this.tsmiUProfile,
            this.tsmiSignIn});
            this.msMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.msMain.Location = new System.Drawing.Point(0, 154);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(229, 256);
            this.msMain.TabIndex = 7;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiReserve
            // 
            this.tsmiReserve.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReserve.Image")));
            this.tsmiReserve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiReserve.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiReserve.Name = "tsmiReserve";
            this.tsmiReserve.Size = new System.Drawing.Size(222, 36);
            this.tsmiReserve.Text = "Reservation";
            this.tsmiReserve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiReserve.Click += new System.EventHandler(this.tsmiReserve_Click);
            // 
            // tsmiBooking
            // 
            this.tsmiBooking.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBooking.Image")));
            this.tsmiBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiBooking.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiBooking.Name = "tsmiBooking";
            this.tsmiBooking.Size = new System.Drawing.Size(222, 36);
            this.tsmiBooking.Text = "Booking";
            this.tsmiBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiBooking.Click += new System.EventHandler(this.tsmiBooking_Click);
            // 
            // tsmiMaintenance
            // 
            this.tsmiMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSystem,
            this.tsmiUsers,
            this.tsmiAccomodation,
            this.tsmiGuestRates,
            this.tsmiInventory});
            this.tsmiMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMaintenance.Image")));
            this.tsmiMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiMaintenance.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMaintenance.Name = "tsmiMaintenance";
            this.tsmiMaintenance.Size = new System.Drawing.Size(222, 36);
            this.tsmiMaintenance.Text = "Setup";
            this.tsmiMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsmiSystem
            // 
            this.tsmiSystem.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSystem.Image")));
            this.tsmiSystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiSystem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSystem.Name = "tsmiSystem";
            this.tsmiSystem.Size = new System.Drawing.Size(318, 38);
            this.tsmiSystem.Text = "System";
            this.tsmiSystem.Click += new System.EventHandler(this.tsmiSystem_Click);
            // 
            // tsmiUsers
            // 
            this.tsmiUsers.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUsers.Image")));
            this.tsmiUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUsers.Name = "tsmiUsers";
            this.tsmiUsers.Size = new System.Drawing.Size(318, 38);
            this.tsmiUsers.Text = "Users";
            this.tsmiUsers.Click += new System.EventHandler(this.tsmiUsers_Click);
            // 
            // tsmiAccomodation
            // 
            this.tsmiAccomodation.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAccomodation.Image")));
            this.tsmiAccomodation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiAccomodation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAccomodation.Name = "tsmiAccomodation";
            this.tsmiAccomodation.Size = new System.Drawing.Size(318, 38);
            this.tsmiAccomodation.Text = "Accommodations";
            this.tsmiAccomodation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiAccomodation.Click += new System.EventHandler(this.tsmiAccomodation_Click);
            // 
            // tsmiGuestRates
            // 
            this.tsmiGuestRates.Image = ((System.Drawing.Image)(resources.GetObject("tsmiGuestRates.Image")));
            this.tsmiGuestRates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiGuestRates.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiGuestRates.Name = "tsmiGuestRates";
            this.tsmiGuestRates.Size = new System.Drawing.Size(318, 38);
            this.tsmiGuestRates.Text = "Guest Information and Rates";
            this.tsmiGuestRates.Click += new System.EventHandler(this.tsmiGuestRates_Click);
            // 
            // tsmiInventory
            // 
            this.tsmiInventory.Image = ((System.Drawing.Image)(resources.GetObject("tsmiInventory.Image")));
            this.tsmiInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiInventory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiInventory.Name = "tsmiInventory";
            this.tsmiInventory.Size = new System.Drawing.Size(318, 38);
            this.tsmiInventory.Text = "Inventory";
            this.tsmiInventory.Click += new System.EventHandler(this.tsmiInventory_Click);
            // 
            // tsmiReports
            // 
            this.tsmiReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReportDaily,
            this.tsmiReportReserve,
            this.tsmiReportBooking,
            this.tsmiReportInv});
            this.tsmiReports.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReports.Image")));
            this.tsmiReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiReports.Name = "tsmiReports";
            this.tsmiReports.Size = new System.Drawing.Size(222, 36);
            this.tsmiReports.Text = "Reports";
            this.tsmiReports.Click += new System.EventHandler(this.tsmiReports_Click);
            // 
            // tsmiReportDaily
            // 
            this.tsmiReportDaily.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReportDaily.Image")));
            this.tsmiReportDaily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiReportDaily.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiReportDaily.Name = "tsmiReportDaily";
            this.tsmiReportDaily.Size = new System.Drawing.Size(191, 38);
            this.tsmiReportDaily.Text = "Sales Report";
            this.tsmiReportDaily.Click += new System.EventHandler(this.tsmiReportDaily_Click);
            // 
            // tsmiReportReserve
            // 
            this.tsmiReportReserve.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReportReserve.Image")));
            this.tsmiReportReserve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiReportReserve.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiReportReserve.Name = "tsmiReportReserve";
            this.tsmiReportReserve.ShowShortcutKeys = false;
            this.tsmiReportReserve.Size = new System.Drawing.Size(191, 38);
            this.tsmiReportReserve.Text = "Reservations";
            this.tsmiReportReserve.Visible = false;
            // 
            // tsmiReportBooking
            // 
            this.tsmiReportBooking.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReportBooking.Image")));
            this.tsmiReportBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiReportBooking.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiReportBooking.Name = "tsmiReportBooking";
            this.tsmiReportBooking.Size = new System.Drawing.Size(191, 38);
            this.tsmiReportBooking.Text = "Bookings";
            this.tsmiReportBooking.Click += new System.EventHandler(this.tsmiReportBooking_Click);
            // 
            // tsmiReportInv
            // 
            this.tsmiReportInv.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReportInv.Image")));
            this.tsmiReportInv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiReportInv.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiReportInv.Name = "tsmiReportInv";
            this.tsmiReportInv.Size = new System.Drawing.Size(191, 38);
            this.tsmiReportInv.Text = "Inventory";
            this.tsmiReportInv.Click += new System.EventHandler(this.tsmiReportInv_Click);
            // 
            // tsmiSignOut
            // 
            this.tsmiSignOut.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSignOut.Image")));
            this.tsmiSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiSignOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSignOut.Name = "tsmiSignOut";
            this.tsmiSignOut.Size = new System.Drawing.Size(222, 36);
            this.tsmiSignOut.Text = "Sign Out";
            this.tsmiSignOut.Visible = false;
            this.tsmiSignOut.Click += new System.EventHandler(this.tsmiSignOut_Click);
            // 
            // tsmiUProfile
            // 
            this.tsmiUProfile.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUProfile.Image")));
            this.tsmiUProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiUProfile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUProfile.Name = "tsmiUProfile";
            this.tsmiUProfile.Size = new System.Drawing.Size(222, 36);
            this.tsmiUProfile.Text = "Profile";
            this.tsmiUProfile.Visible = false;
            // 
            // tsmiSignIn
            // 
            this.tsmiSignIn.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSignIn.Image")));
            this.tsmiSignIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiSignIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSignIn.Name = "tsmiSignIn";
            this.tsmiSignIn.Size = new System.Drawing.Size(222, 36);
            this.tsmiSignIn.Text = "Sign In";
            this.tsmiSignIn.Click += new System.EventHandler(this.tsmiSignIn_Click);
            // 
            // pnlSpacer
            // 
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpacer.Location = new System.Drawing.Point(0, 141);
            this.pnlSpacer.Name = "pnlSpacer";
            this.pnlSpacer.Size = new System.Drawing.Size(229, 13);
            this.pnlSpacer.TabIndex = 6;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 12);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(229, 129);
            this.pnlLogo.TabIndex = 5;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(229, 129);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlSpacer1
            // 
            this.pnlSpacer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpacer1.Location = new System.Drawing.Point(0, 0);
            this.pnlSpacer1.Name = "pnlSpacer1";
            this.pnlSpacer1.Size = new System.Drawing.Size(229, 12);
            this.pnlSpacer1.TabIndex = 4;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(231, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(738, 412);
            this.pnlContainer.TabIndex = 7;
            // 
            // timerdt
            // 
            this.timerdt.Enabled = true;
            this.timerdt.Tick += new System.EventHandler(this.timerdt_Tick);
            // 
            // mdiCAMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 435);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.stsStatus);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "mdiCAMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking and Reservation System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mdiCAMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mdiCAMain_FormClosed);
            this.Load += new System.EventHandler(this.mdiCAMain_Load);
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private global::System.Windows.Forms.ToolTip toolTip;
        private global::System.Windows.Forms.StatusStrip stsStatus;
        private global::System.Windows.Forms.Panel pnlMenu;
        private global::System.Windows.Forms.Panel pnlContainer;
        private global::System.Windows.Forms.ToolStripStatusLabel tsslLogUser;
        private global::System.Windows.Forms.ToolStripStatusLabel tsslLogUser1;
        private global::System.Windows.Forms.ToolStripStatusLabel tsslUserRole;
        private global::System.Windows.Forms.ToolStripStatusLabel tsslUserRole1;
        private global::System.Windows.Forms.ToolStripStatusLabel tsslCurrDatetime;
        private global::System.Windows.Forms.ToolStripStatusLabel tsslCurrDatetime1;
        private global::System.Windows.Forms.Timer timerdt;
        private global::System.Windows.Forms.MenuStrip msMain;
        private global::System.Windows.Forms.ToolStripMenuItem tsmiReserve;
        private global::System.Windows.Forms.ToolStripMenuItem tsmiBooking;
        private global::System.Windows.Forms.ToolStripMenuItem tsmiMaintenance;
        private global::System.Windows.Forms.ToolStripMenuItem tsmiSystem;
        private global::System.Windows.Forms.ToolStripMenuItem tsmiUsers;
        private global::System.Windows.Forms.ToolStripMenuItem tsmiAccomodation;
        private global::System.Windows.Forms.ToolStripMenuItem tsmiGuestRates;
        private global::System.Windows.Forms.ToolStripMenuItem tsmiInventory;
        private global::System.Windows.Forms.ToolStripMenuItem tsmiReports;
        private global::System.Windows.Forms.ToolStripMenuItem tsmiReportDaily;
        private global::System.Windows.Forms.ToolStripMenuItem tsmiReportReserve;
        private global::System.Windows.Forms.ToolStripMenuItem tsmiReportBooking;
        private global::System.Windows.Forms.ToolStripMenuItem tsmiReportInv;
        private global::System.Windows.Forms.ToolStripMenuItem tsmiSignOut;
        private global::System.Windows.Forms.Panel pnlSpacer;
        private global::System.Windows.Forms.Panel pnlLogo;
        private global::System.Windows.Forms.PictureBox picLogo;
        private global::System.Windows.Forms.Panel pnlSpacer1;
        private global::System.Windows.Forms.ToolStripMenuItem tsmiSignIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiUProfile;
    }
}