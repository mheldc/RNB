namespace CAReserveSystem
{
    partial class frmUserSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserSetup));
            this.tcContainer = new System.Windows.Forms.TabControl();
            this.tpUserRoles = new System.Windows.Forms.TabPage();
            this.pnlURList = new System.Windows.Forms.Panel();
            this.dgvUR = new System.Windows.Forms.DataGridView();
            this.colURSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colURDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colURId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colURDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlURData = new System.Windows.Forms.Panel();
            this.chkURReports = new System.Windows.Forms.CheckBox();
            this.chkURSetup = new System.Windows.Forms.CheckBox();
            this.chkURReserve = new System.Windows.Forms.CheckBox();
            this.chkURBooking = new System.Windows.Forms.CheckBox();
            this.chkURLogin = new System.Windows.Forms.CheckBox();
            this.lblURPriviledges = new System.Windows.Forms.Label();
            this.txtURDesc = new System.Windows.Forms.TextBox();
            this.lblURDesc = new System.Windows.Forms.Label();
            this.tsUR = new System.Windows.Forms.ToolStrip();
            this.tsbURAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbUREdit = new System.Windows.Forms.ToolStripButton();
            this.tsbURSave = new System.Windows.Forms.ToolStripButton();
            this.tsbURCancel = new System.Windows.Forms.ToolStripButton();
            this.tpUserAccts = new System.Windows.Forms.TabPage();
            this.pnlUAList = new System.Windows.Forms.Panel();
            this.dgvUAList = new System.Windows.Forms.DataGridView();
            this.pnlUAData = new System.Windows.Forms.Panel();
            this.lblAccessId = new System.Windows.Forms.Label();
            this.txtAccessId = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblMName = new System.Windows.Forms.Label();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.cmbUARole = new System.Windows.Forms.ComboBox();
            this.lblUARole = new System.Windows.Forms.Label();
            this.lblLoginPw1 = new System.Windows.Forms.Label();
            this.txtLoginPw1 = new System.Windows.Forms.TextBox();
            this.lblLoginPw = new System.Windows.Forms.Label();
            this.txtLoginPw = new System.Windows.Forms.TextBox();
            this.lblLoginId = new System.Windows.Forms.Label();
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.lblLoginInfo = new System.Windows.Forms.Label();
            this.tsUA = new System.Windows.Forms.ToolStrip();
            this.tsbUAAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbUAEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbUASave = new System.Windows.Forms.ToolStripButton();
            this.tsbUACancel = new System.Windows.Forms.ToolStripButton();
            this.colUASelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colUADel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colUAId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUAName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcContainer.SuspendLayout();
            this.tpUserRoles.SuspendLayout();
            this.pnlURList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUR)).BeginInit();
            this.pnlURData.SuspendLayout();
            this.tsUR.SuspendLayout();
            this.tpUserAccts.SuspendLayout();
            this.pnlUAList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUAList)).BeginInit();
            this.pnlUAData.SuspendLayout();
            this.tsUA.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcContainer
            // 
            this.tcContainer.Controls.Add(this.tpUserRoles);
            this.tcContainer.Controls.Add(this.tpUserAccts);
            this.tcContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcContainer.Location = new System.Drawing.Point(0, 0);
            this.tcContainer.Name = "tcContainer";
            this.tcContainer.SelectedIndex = 0;
            this.tcContainer.Size = new System.Drawing.Size(594, 586);
            this.tcContainer.TabIndex = 0;
            // 
            // tpUserRoles
            // 
            this.tpUserRoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpUserRoles.Controls.Add(this.pnlURList);
            this.tpUserRoles.Controls.Add(this.pnlURData);
            this.tpUserRoles.Controls.Add(this.tsUR);
            this.tpUserRoles.Location = new System.Drawing.Point(4, 23);
            this.tpUserRoles.Name = "tpUserRoles";
            this.tpUserRoles.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserRoles.Size = new System.Drawing.Size(586, 559);
            this.tpUserRoles.TabIndex = 0;
            this.tpUserRoles.Text = "User Roles";
            this.tpUserRoles.UseVisualStyleBackColor = true;
            // 
            // pnlURList
            // 
            this.pnlURList.Controls.Add(this.dgvUR);
            this.pnlURList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlURList.Location = new System.Drawing.Point(3, 225);
            this.pnlURList.Name = "pnlURList";
            this.pnlURList.Size = new System.Drawing.Size(578, 329);
            this.pnlURList.TabIndex = 3;
            // 
            // dgvUR
            // 
            this.dgvUR.AllowUserToAddRows = false;
            this.dgvUR.AllowUserToDeleteRows = false;
            this.dgvUR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colURSelect,
            this.colURDel,
            this.colURId,
            this.colURDesc});
            this.dgvUR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUR.Location = new System.Drawing.Point(0, 0);
            this.dgvUR.Name = "dgvUR";
            this.dgvUR.ReadOnly = true;
            this.dgvUR.Size = new System.Drawing.Size(578, 329);
            this.dgvUR.TabIndex = 0;
            this.dgvUR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUR_CellContentClick);
            this.dgvUR.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvUR_CellBindingComplete);
            // 
            // colURSelect
            // 
            this.colURSelect.HeaderText = "";
            this.colURSelect.MinimumWidth = 60;
            this.colURSelect.Name = "colURSelect";
            this.colURSelect.ReadOnly = true;
            this.colURSelect.Text = "Select";
            this.colURSelect.UseColumnTextForButtonValue = true;
            this.colURSelect.Width = 60;
            // 
            // colURDel
            // 
            this.colURDel.HeaderText = "";
            this.colURDel.MinimumWidth = 60;
            this.colURDel.Name = "colURDel";
            this.colURDel.ReadOnly = true;
            this.colURDel.Text = "Remove";
            this.colURDel.UseColumnTextForButtonValue = true;
            this.colURDel.Width = 60;
            // 
            // colURId
            // 
            this.colURId.HeaderText = "";
            this.colURId.MinimumWidth = 50;
            this.colURId.Name = "colURId";
            this.colURId.ReadOnly = true;
            this.colURId.Visible = false;
            this.colURId.Width = 50;
            // 
            // colURDesc
            // 
            this.colURDesc.HeaderText = "Role Description";
            this.colURDesc.MinimumWidth = 350;
            this.colURDesc.Name = "colURDesc";
            this.colURDesc.ReadOnly = true;
            this.colURDesc.Width = 350;
            // 
            // pnlURData
            // 
            this.pnlURData.Controls.Add(this.chkURReports);
            this.pnlURData.Controls.Add(this.chkURSetup);
            this.pnlURData.Controls.Add(this.chkURReserve);
            this.pnlURData.Controls.Add(this.chkURBooking);
            this.pnlURData.Controls.Add(this.chkURLogin);
            this.pnlURData.Controls.Add(this.lblURPriviledges);
            this.pnlURData.Controls.Add(this.txtURDesc);
            this.pnlURData.Controls.Add(this.lblURDesc);
            this.pnlURData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlURData.Location = new System.Drawing.Point(3, 42);
            this.pnlURData.Name = "pnlURData";
            this.pnlURData.Size = new System.Drawing.Size(578, 183);
            this.pnlURData.TabIndex = 2;
            // 
            // chkURReports
            // 
            this.chkURReports.AutoSize = true;
            this.chkURReports.Enabled = false;
            this.chkURReports.Location = new System.Drawing.Point(123, 150);
            this.chkURReports.Name = "chkURReports";
            this.chkURReports.Size = new System.Drawing.Size(165, 18);
            this.chkURReports.TabIndex = 15;
            this.chkURReports.Text = "Allow Generating Reports";
            this.chkURReports.UseVisualStyleBackColor = true;
            // 
            // chkURSetup
            // 
            this.chkURSetup.AutoSize = true;
            this.chkURSetup.Enabled = false;
            this.chkURSetup.Location = new System.Drawing.Point(123, 126);
            this.chkURSetup.Name = "chkURSetup";
            this.chkURSetup.Size = new System.Drawing.Size(197, 18);
            this.chkURSetup.TabIndex = 14;
            this.chkURSetup.Text = "Allow Adding/Updating Settings";
            this.chkURSetup.UseVisualStyleBackColor = true;
            // 
            // chkURReserve
            // 
            this.chkURReserve.AutoSize = true;
            this.chkURReserve.Enabled = false;
            this.chkURReserve.Location = new System.Drawing.Point(123, 102);
            this.chkURReserve.Name = "chkURReserve";
            this.chkURReserve.Size = new System.Drawing.Size(195, 18);
            this.chkURReserve.TabIndex = 13;
            this.chkURReserve.Text = "Allow Reservation Transactions";
            this.chkURReserve.UseVisualStyleBackColor = true;
            // 
            // chkURBooking
            // 
            this.chkURBooking.AutoSize = true;
            this.chkURBooking.Enabled = false;
            this.chkURBooking.Location = new System.Drawing.Point(123, 78);
            this.chkURBooking.Name = "chkURBooking";
            this.chkURBooking.Size = new System.Drawing.Size(175, 18);
            this.chkURBooking.TabIndex = 12;
            this.chkURBooking.Text = "Allow Booking Transactions";
            this.chkURBooking.UseVisualStyleBackColor = true;
            // 
            // chkURLogin
            // 
            this.chkURLogin.AutoSize = true;
            this.chkURLogin.Enabled = false;
            this.chkURLogin.Location = new System.Drawing.Point(123, 54);
            this.chkURLogin.Name = "chkURLogin";
            this.chkURLogin.Size = new System.Drawing.Size(130, 18);
            this.chkURLogin.TabIndex = 11;
            this.chkURLogin.Text = "Allow System Login";
            this.chkURLogin.UseVisualStyleBackColor = true;
            // 
            // lblURPriviledges
            // 
            this.lblURPriviledges.AutoSize = true;
            this.lblURPriviledges.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURPriviledges.Location = new System.Drawing.Point(15, 55);
            this.lblURPriviledges.Name = "lblURPriviledges";
            this.lblURPriviledges.Size = new System.Drawing.Size(86, 14);
            this.lblURPriviledges.TabIndex = 10;
            this.lblURPriviledges.Text = "Role Priviledges";
            // 
            // txtURDesc
            // 
            this.txtURDesc.Enabled = false;
            this.txtURDesc.Location = new System.Drawing.Point(123, 12);
            this.txtURDesc.Name = "txtURDesc";
            this.txtURDesc.Size = new System.Drawing.Size(350, 22);
            this.txtURDesc.TabIndex = 9;
            // 
            // lblURDesc
            // 
            this.lblURDesc.AutoSize = true;
            this.lblURDesc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURDesc.Location = new System.Drawing.Point(15, 15);
            this.lblURDesc.Name = "lblURDesc";
            this.lblURDesc.Size = new System.Drawing.Size(88, 14);
            this.lblURDesc.TabIndex = 8;
            this.lblURDesc.Text = "Role Description";
            // 
            // tsUR
            // 
            this.tsUR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbURAdd,
            this.tsbUREdit,
            this.tsbURSave,
            this.tsbURCancel});
            this.tsUR.Location = new System.Drawing.Point(3, 3);
            this.tsUR.Name = "tsUR";
            this.tsUR.Size = new System.Drawing.Size(578, 39);
            this.tsUR.TabIndex = 0;
            this.tsUR.Text = "toolStrip1";
            // 
            // tsbURAdd
            // 
            this.tsbURAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbURAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbURAdd.Image")));
            this.tsbURAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbURAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbURAdd.Name = "tsbURAdd";
            this.tsbURAdd.Size = new System.Drawing.Size(36, 36);
            this.tsbURAdd.Text = "Create New Role";
            this.tsbURAdd.Click += new System.EventHandler(this.tsbURAdd_Click);
            // 
            // tsbUREdit
            // 
            this.tsbUREdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUREdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbUREdit.Image")));
            this.tsbUREdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUREdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUREdit.Name = "tsbUREdit";
            this.tsbUREdit.Size = new System.Drawing.Size(36, 36);
            this.tsbUREdit.Text = "Edit Role";
            this.tsbUREdit.ToolTipText = "Edit Role";
            this.tsbUREdit.Visible = false;
            this.tsbUREdit.Click += new System.EventHandler(this.tsbUREdit_Click);
            // 
            // tsbURSave
            // 
            this.tsbURSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbURSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbURSave.Image")));
            this.tsbURSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbURSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbURSave.Name = "tsbURSave";
            this.tsbURSave.Size = new System.Drawing.Size(36, 36);
            this.tsbURSave.Text = "Save Role";
            this.tsbURSave.Visible = false;
            this.tsbURSave.Click += new System.EventHandler(this.tsbURSave_Click);
            // 
            // tsbURCancel
            // 
            this.tsbURCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbURCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbURCancel.Image")));
            this.tsbURCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbURCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbURCancel.Name = "tsbURCancel";
            this.tsbURCancel.Size = new System.Drawing.Size(36, 36);
            this.tsbURCancel.Text = "Cancel";
            this.tsbURCancel.Visible = false;
            this.tsbURCancel.Click += new System.EventHandler(this.tsbURCancel_Click);
            // 
            // tpUserAccts
            // 
            this.tpUserAccts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpUserAccts.Controls.Add(this.pnlUAList);
            this.tpUserAccts.Controls.Add(this.pnlUAData);
            this.tpUserAccts.Controls.Add(this.tsUA);
            this.tpUserAccts.Location = new System.Drawing.Point(4, 23);
            this.tpUserAccts.Name = "tpUserAccts";
            this.tpUserAccts.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserAccts.Size = new System.Drawing.Size(586, 559);
            this.tpUserAccts.TabIndex = 1;
            this.tpUserAccts.Text = "User Accounts";
            this.tpUserAccts.UseVisualStyleBackColor = true;
            // 
            // pnlUAList
            // 
            this.pnlUAList.Controls.Add(this.dgvUAList);
            this.pnlUAList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUAList.Location = new System.Drawing.Point(3, 330);
            this.pnlUAList.Name = "pnlUAList";
            this.pnlUAList.Size = new System.Drawing.Size(578, 224);
            this.pnlUAList.TabIndex = 5;
            // 
            // dgvUAList
            // 
            this.dgvUAList.AllowUserToAddRows = false;
            this.dgvUAList.AllowUserToDeleteRows = false;
            this.dgvUAList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUAList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUASelect,
            this.colUADel,
            this.colUAId,
            this.colUAName});
            this.dgvUAList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUAList.Location = new System.Drawing.Point(0, 0);
            this.dgvUAList.Name = "dgvUAList";
            this.dgvUAList.ReadOnly = true;
            this.dgvUAList.Size = new System.Drawing.Size(578, 224);
            this.dgvUAList.TabIndex = 0;
            this.dgvUAList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUAList_CellContentClick);
            this.dgvUAList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvUAList_DataBindingComplete);
            // 
            // pnlUAData
            // 
            this.pnlUAData.Controls.Add(this.lblAccessId);
            this.pnlUAData.Controls.Add(this.txtAccessId);
            this.pnlUAData.Controls.Add(this.lblLName);
            this.pnlUAData.Controls.Add(this.txtLName);
            this.pnlUAData.Controls.Add(this.lblMName);
            this.pnlUAData.Controls.Add(this.txtMName);
            this.pnlUAData.Controls.Add(this.lblFName);
            this.pnlUAData.Controls.Add(this.txtFName);
            this.pnlUAData.Controls.Add(this.cmbUARole);
            this.pnlUAData.Controls.Add(this.lblUARole);
            this.pnlUAData.Controls.Add(this.lblLoginPw1);
            this.pnlUAData.Controls.Add(this.txtLoginPw1);
            this.pnlUAData.Controls.Add(this.lblLoginPw);
            this.pnlUAData.Controls.Add(this.txtLoginPw);
            this.pnlUAData.Controls.Add(this.lblLoginId);
            this.pnlUAData.Controls.Add(this.lblAccountInfo);
            this.pnlUAData.Controls.Add(this.txtLoginId);
            this.pnlUAData.Controls.Add(this.lblLoginInfo);
            this.pnlUAData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUAData.Location = new System.Drawing.Point(3, 42);
            this.pnlUAData.Name = "pnlUAData";
            this.pnlUAData.Size = new System.Drawing.Size(578, 288);
            this.pnlUAData.TabIndex = 4;
            // 
            // lblAccessId
            // 
            this.lblAccessId.AutoSize = true;
            this.lblAccessId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessId.Location = new System.Drawing.Point(44, 178);
            this.lblAccessId.Name = "lblAccessId";
            this.lblAccessId.Size = new System.Drawing.Size(52, 14);
            this.lblAccessId.TabIndex = 25;
            this.lblAccessId.Text = "Access Id";
            // 
            // txtAccessId
            // 
            this.txtAccessId.Enabled = false;
            this.txtAccessId.Location = new System.Drawing.Point(149, 175);
            this.txtAccessId.Name = "txtAccessId";
            this.txtAccessId.Size = new System.Drawing.Size(194, 22);
            this.txtAccessId.TabIndex = 24;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(44, 250);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(60, 14);
            this.lblLName.TabIndex = 23;
            this.lblLName.Text = "Last Name";
            // 
            // txtLName
            // 
            this.txtLName.Enabled = false;
            this.txtLName.Location = new System.Drawing.Point(149, 247);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(194, 22);
            this.txtLName.TabIndex = 22;
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMName.Location = new System.Drawing.Point(44, 226);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(74, 14);
            this.lblMName.TabIndex = 21;
            this.lblMName.Text = "Middle Name";
            // 
            // txtMName
            // 
            this.txtMName.Enabled = false;
            this.txtMName.Location = new System.Drawing.Point(149, 223);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(194, 22);
            this.txtMName.TabIndex = 20;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(44, 202);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(62, 14);
            this.lblFName.TabIndex = 19;
            this.lblFName.Text = "First Name";
            // 
            // txtFName
            // 
            this.txtFName.Enabled = false;
            this.txtFName.Location = new System.Drawing.Point(149, 199);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(194, 22);
            this.txtFName.TabIndex = 18;
            // 
            // cmbUARole
            // 
            this.cmbUARole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUARole.Enabled = false;
            this.cmbUARole.FormattingEnabled = true;
            this.cmbUARole.Location = new System.Drawing.Point(149, 151);
            this.cmbUARole.Name = "cmbUARole";
            this.cmbUARole.Size = new System.Drawing.Size(350, 22);
            this.cmbUARole.TabIndex = 17;
            // 
            // lblUARole
            // 
            this.lblUARole.AutoSize = true;
            this.lblUARole.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUARole.Location = new System.Drawing.Point(44, 154);
            this.lblUARole.Name = "lblUARole";
            this.lblUARole.Size = new System.Drawing.Size(71, 14);
            this.lblUARole.TabIndex = 16;
            this.lblUARole.Text = "Account Role";
            // 
            // lblLoginPw1
            // 
            this.lblLoginPw1.AutoSize = true;
            this.lblLoginPw1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPw1.Location = new System.Drawing.Point(44, 88);
            this.lblLoginPw1.Name = "lblLoginPw1";
            this.lblLoginPw1.Size = new System.Drawing.Size(96, 14);
            this.lblLoginPw1.TabIndex = 15;
            this.lblLoginPw1.Text = "Confirm Password";
            // 
            // txtLoginPw1
            // 
            this.txtLoginPw1.Enabled = false;
            this.txtLoginPw1.Location = new System.Drawing.Point(149, 85);
            this.txtLoginPw1.Name = "txtLoginPw1";
            this.txtLoginPw1.PasswordChar = '•';
            this.txtLoginPw1.Size = new System.Drawing.Size(194, 22);
            this.txtLoginPw1.TabIndex = 14;
            // 
            // lblLoginPw
            // 
            this.lblLoginPw.AutoSize = true;
            this.lblLoginPw.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPw.Location = new System.Drawing.Point(44, 64);
            this.lblLoginPw.Name = "lblLoginPw";
            this.lblLoginPw.Size = new System.Drawing.Size(54, 14);
            this.lblLoginPw.TabIndex = 13;
            this.lblLoginPw.Text = "Password";
            // 
            // txtLoginPw
            // 
            this.txtLoginPw.Enabled = false;
            this.txtLoginPw.Location = new System.Drawing.Point(149, 61);
            this.txtLoginPw.Name = "txtLoginPw";
            this.txtLoginPw.PasswordChar = '•';
            this.txtLoginPw.Size = new System.Drawing.Size(194, 22);
            this.txtLoginPw.TabIndex = 12;
            // 
            // lblLoginId
            // 
            this.lblLoginId.AutoSize = true;
            this.lblLoginId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginId.Location = new System.Drawing.Point(44, 40);
            this.lblLoginId.Name = "lblLoginId";
            this.lblLoginId.Size = new System.Drawing.Size(45, 14);
            this.lblLoginId.TabIndex = 11;
            this.lblLoginId.Text = "Login Id";
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.AutoSize = true;
            this.lblAccountInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountInfo.Location = new System.Drawing.Point(15, 127);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Size = new System.Drawing.Size(107, 14);
            this.lblAccountInfo.TabIndex = 10;
            this.lblAccountInfo.Text = "Account Information";
            // 
            // txtLoginId
            // 
            this.txtLoginId.Enabled = false;
            this.txtLoginId.Location = new System.Drawing.Point(149, 37);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(194, 22);
            this.txtLoginId.TabIndex = 9;
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.AutoSize = true;
            this.lblLoginInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginInfo.Location = new System.Drawing.Point(15, 15);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(94, 14);
            this.lblLoginInfo.TabIndex = 8;
            this.lblLoginInfo.Text = "Login Information";
            // 
            // tsUA
            // 
            this.tsUA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUAAdd,
            this.tsbUAEdit,
            this.tsbUASave,
            this.tsbUACancel});
            this.tsUA.Location = new System.Drawing.Point(3, 3);
            this.tsUA.Name = "tsUA";
            this.tsUA.Size = new System.Drawing.Size(578, 39);
            this.tsUA.TabIndex = 1;
            this.tsUA.Text = "toolStrip2";
            // 
            // tsbUAAdd
            // 
            this.tsbUAAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUAAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbUAAdd.Image")));
            this.tsbUAAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUAAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUAAdd.Name = "tsbUAAdd";
            this.tsbUAAdd.Size = new System.Drawing.Size(36, 36);
            this.tsbUAAdd.Text = "New User Account";
            this.tsbUAAdd.Click += new System.EventHandler(this.tsbUAAdd_Click);
            // 
            // tsbUAEdit
            // 
            this.tsbUAEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUAEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbUAEdit.Image")));
            this.tsbUAEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUAEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUAEdit.Name = "tsbUAEdit";
            this.tsbUAEdit.Size = new System.Drawing.Size(36, 36);
            this.tsbUAEdit.Text = "Edit Account";
            this.tsbUAEdit.Visible = false;
            this.tsbUAEdit.Click += new System.EventHandler(this.tsbUAEdit_Click);
            // 
            // tsbUASave
            // 
            this.tsbUASave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUASave.Image = ((System.Drawing.Image)(resources.GetObject("tsbUASave.Image")));
            this.tsbUASave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUASave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUASave.Name = "tsbUASave";
            this.tsbUASave.Size = new System.Drawing.Size(36, 36);
            this.tsbUASave.Text = "Save Account";
            this.tsbUASave.ToolTipText = "Save Account";
            this.tsbUASave.Visible = false;
            this.tsbUASave.Click += new System.EventHandler(this.tsbUASave_Click);
            // 
            // tsbUACancel
            // 
            this.tsbUACancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUACancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbUACancel.Image")));
            this.tsbUACancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUACancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUACancel.Name = "tsbUACancel";
            this.tsbUACancel.Size = new System.Drawing.Size(36, 36);
            this.tsbUACancel.Text = "Cancel";
            this.tsbUACancel.Visible = false;
            this.tsbUACancel.Click += new System.EventHandler(this.tsbUACancel_Click);
            // 
            // colUASelect
            // 
            this.colUASelect.HeaderText = "";
            this.colUASelect.MinimumWidth = 60;
            this.colUASelect.Name = "colUASelect";
            this.colUASelect.ReadOnly = true;
            this.colUASelect.Text = "Select";
            this.colUASelect.UseColumnTextForButtonValue = true;
            this.colUASelect.Width = 70;
            // 
            // colUADel
            // 
            this.colUADel.HeaderText = "";
            this.colUADel.MinimumWidth = 60;
            this.colUADel.Name = "colUADel";
            this.colUADel.ReadOnly = true;
            this.colUADel.Text = "Remove";
            this.colUADel.UseColumnTextForButtonValue = true;
            this.colUADel.Width = 70;
            // 
            // colUAId
            // 
            this.colUAId.HeaderText = "Id";
            this.colUAId.MinimumWidth = 50;
            this.colUAId.Name = "colUAId";
            this.colUAId.ReadOnly = true;
            this.colUAId.Visible = false;
            this.colUAId.Width = 50;
            // 
            // colUAName
            // 
            this.colUAName.HeaderText = "Name";
            this.colUAName.MinimumWidth = 350;
            this.colUAName.Name = "colUAName";
            this.colUAName.ReadOnly = true;
            this.colUAName.Width = 350;
            // 
            // frmUserSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 586);
            this.Controls.Add(this.tcContainer);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Account Setup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUserSetup_Load);
            this.tcContainer.ResumeLayout(false);
            this.tpUserRoles.ResumeLayout(false);
            this.tpUserRoles.PerformLayout();
            this.pnlURList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUR)).EndInit();
            this.pnlURData.ResumeLayout(false);
            this.pnlURData.PerformLayout();
            this.tsUR.ResumeLayout(false);
            this.tsUR.PerformLayout();
            this.tpUserAccts.ResumeLayout(false);
            this.tpUserAccts.PerformLayout();
            this.pnlUAList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUAList)).EndInit();
            this.pnlUAData.ResumeLayout(false);
            this.pnlUAData.PerformLayout();
            this.tsUA.ResumeLayout(false);
            this.tsUA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcContainer;
        private System.Windows.Forms.TabPage tpUserRoles;
        private System.Windows.Forms.TabPage tpUserAccts;
        private System.Windows.Forms.Panel pnlURList;
        private System.Windows.Forms.DataGridView dgvUR;
        private System.Windows.Forms.Panel pnlURData;
        private System.Windows.Forms.CheckBox chkURReports;
        private System.Windows.Forms.CheckBox chkURSetup;
        private System.Windows.Forms.CheckBox chkURReserve;
        private System.Windows.Forms.CheckBox chkURBooking;
        private System.Windows.Forms.CheckBox chkURLogin;
        private System.Windows.Forms.Label lblURPriviledges;
        private System.Windows.Forms.TextBox txtURDesc;
        private System.Windows.Forms.Label lblURDesc;
        private System.Windows.Forms.ToolStrip tsUR;
        private System.Windows.Forms.ToolStripButton tsbURAdd;
        private System.Windows.Forms.ToolStripButton tsbURSave;
        private System.Windows.Forms.ToolStripButton tsbURCancel;
        private System.Windows.Forms.Panel pnlUAList;
        private System.Windows.Forms.DataGridView dgvUAList;
        private System.Windows.Forms.Panel pnlUAData;
        private System.Windows.Forms.Label lblAccountInfo;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.Label lblLoginInfo;
        private System.Windows.Forms.ToolStrip tsUA;
        private System.Windows.Forms.ToolStripButton tsbUAAdd;
        private System.Windows.Forms.ToolStripButton tsbUASave;
        private System.Windows.Forms.ToolStripButton tsbUACancel;
        private System.Windows.Forms.Label lblLoginPw;
        private System.Windows.Forms.TextBox txtLoginPw;
        private System.Windows.Forms.Label lblLoginId;
        private System.Windows.Forms.Label lblLoginPw1;
        private System.Windows.Forms.TextBox txtLoginPw1;
        private System.Windows.Forms.Label lblAccessId;
        private System.Windows.Forms.TextBox txtAccessId;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.ComboBox cmbUARole;
        private System.Windows.Forms.Label lblUARole;
        private System.Windows.Forms.ToolStripButton tsbUREdit;
        private System.Windows.Forms.ToolStripButton tsbUAEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colURSelect;
        private System.Windows.Forms.DataGridViewButtonColumn colURDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colURId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colURDesc;
        private System.Windows.Forms.DataGridViewButtonColumn colUASelect;
        private System.Windows.Forms.DataGridViewButtonColumn colUADel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUAId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUAName;
    }
}