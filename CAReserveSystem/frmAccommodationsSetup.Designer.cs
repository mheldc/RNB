namespace CAReserveSystem
{
    partial class frmAccommodationsSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccommodationsSetup));
            this.tcAccommodation = new System.Windows.Forms.TabControl();
            this.tpAccType = new System.Windows.Forms.TabPage();
            this.pnlATList = new System.Windows.Forms.Panel();
            this.dgvAT = new System.Windows.Forms.DataGridView();
            this.colATSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colATDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colATId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllowDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDPValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlATData = new System.Windows.Forms.Panel();
            this.cmbDPType = new System.Windows.Forms.ComboBox();
            this.txtDP = new System.Windows.Forms.TextBox();
            this.lblDP = new System.Windows.Forms.Label();
            this.txtATDesc = new System.Windows.Forms.TextBox();
            this.chkAllowDP = new System.Windows.Forms.CheckBox();
            this.lblATDesc = new System.Windows.Forms.Label();
            this.tsAccType = new System.Windows.Forms.ToolStrip();
            this.tsbAddAT = new System.Windows.Forms.ToolStripButton();
            this.tsbEditAT = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveAT = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelAT = new System.Windows.Forms.ToolStripButton();
            this.tpAcc = new System.Windows.Forms.TabPage();
            this.pnlAccList = new System.Windows.Forms.Panel();
            this.dgvAC = new System.Windows.Forms.DataGridView();
            this.colACSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colACDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colACId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colACCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colACDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAccData = new System.Windows.Forms.Panel();
            this.lblACCapPax = new System.Windows.Forms.Label();
            this.txtACCap = new System.Windows.Forms.TextBox();
            this.txtACDesc = new System.Windows.Forms.TextBox();
            this.txtACCode = new System.Windows.Forms.TextBox();
            this.cmbACAT = new System.Windows.Forms.ComboBox();
            this.lblACCap = new System.Windows.Forms.Label();
            this.lblACDesc = new System.Windows.Forms.Label();
            this.lblACCode = new System.Windows.Forms.Label();
            this.lblACAT = new System.Windows.Forms.Label();
            this.tsAcc = new System.Windows.Forms.ToolStrip();
            this.tsbAddAcc = new System.Windows.Forms.ToolStripButton();
            this.tsbAccEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveAcc = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelAcc = new System.Windows.Forms.ToolStripButton();
            this.tpAccRates = new System.Windows.Forms.TabPage();
            this.pnlARData = new System.Windows.Forms.Panel();
            this.txtARWholeDay = new System.Windows.Forms.TextBox();
            this.lblARWholeDay = new System.Windows.Forms.Label();
            this.cmbAREx = new System.Windows.Forms.ComboBox();
            this.dtpARNightTo = new System.Windows.Forms.DateTimePicker();
            this.dtpARDayTo = new System.Windows.Forms.DateTimePicker();
            this.dtpARNightFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpARDayFrom = new System.Windows.Forms.DateTimePicker();
            this.txtAREx = new System.Windows.Forms.TextBox();
            this.txtARNight = new System.Windows.Forms.TextBox();
            this.txtARDay = new System.Windows.Forms.TextBox();
            this.lblAREx = new System.Windows.Forms.Label();
            this.lblUsageNight = new System.Windows.Forms.Label();
            this.lblUsageDay = new System.Windows.Forms.Label();
            this.lblARNight = new System.Windows.Forms.Label();
            this.lblARDay = new System.Windows.Forms.Label();
            this.lblATRates = new System.Windows.Forms.Label();
            this.cmbATAR = new System.Windows.Forms.ComboBox();
            this.lblATAR = new System.Windows.Forms.Label();
            this.tsAccRates = new System.Windows.Forms.ToolStrip();
            this.tsbSaveAR = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelAR = new System.Windows.Forms.ToolStripButton();
            this.tcAccommodation.SuspendLayout();
            this.tpAccType.SuspendLayout();
            this.pnlATList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAT)).BeginInit();
            this.pnlATData.SuspendLayout();
            this.tsAccType.SuspendLayout();
            this.tpAcc.SuspendLayout();
            this.pnlAccList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAC)).BeginInit();
            this.pnlAccData.SuspendLayout();
            this.tsAcc.SuspendLayout();
            this.tpAccRates.SuspendLayout();
            this.pnlARData.SuspendLayout();
            this.tsAccRates.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAccommodation
            // 
            this.tcAccommodation.Controls.Add(this.tpAccType);
            this.tcAccommodation.Controls.Add(this.tpAcc);
            this.tcAccommodation.Controls.Add(this.tpAccRates);
            this.tcAccommodation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAccommodation.Location = new System.Drawing.Point(0, 0);
            this.tcAccommodation.Name = "tcAccommodation";
            this.tcAccommodation.SelectedIndex = 0;
            this.tcAccommodation.Size = new System.Drawing.Size(826, 446);
            this.tcAccommodation.TabIndex = 0;
            // 
            // tpAccType
            // 
            this.tpAccType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpAccType.Controls.Add(this.pnlATList);
            this.tpAccType.Controls.Add(this.pnlATData);
            this.tpAccType.Controls.Add(this.tsAccType);
            this.tpAccType.Location = new System.Drawing.Point(4, 23);
            this.tpAccType.Name = "tpAccType";
            this.tpAccType.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccType.Size = new System.Drawing.Size(818, 419);
            this.tpAccType.TabIndex = 0;
            this.tpAccType.Text = "Accommodation Types";
            this.tpAccType.UseVisualStyleBackColor = true;
            // 
            // pnlATList
            // 
            this.pnlATList.Controls.Add(this.dgvAT);
            this.pnlATList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlATList.Location = new System.Drawing.Point(3, 138);
            this.pnlATList.Name = "pnlATList";
            this.pnlATList.Size = new System.Drawing.Size(810, 276);
            this.pnlATList.TabIndex = 2;
            // 
            // dgvAT
            // 
            this.dgvAT.AllowUserToAddRows = false;
            this.dgvAT.AllowUserToDeleteRows = false;
            this.dgvAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colATSelect,
            this.colATDel,
            this.colATId,
            this.colAType,
            this.colAllowDP,
            this.colDPValue,
            this.Column1});
            this.dgvAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAT.Location = new System.Drawing.Point(0, 0);
            this.dgvAT.Name = "dgvAT";
            this.dgvAT.ReadOnly = true;
            this.dgvAT.Size = new System.Drawing.Size(810, 276);
            this.dgvAT.TabIndex = 0;
            this.dgvAT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAT_CellContentClick);
            this.dgvAT.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAT_DataBindingComplete);
            // 
            // colATSelect
            // 
            this.colATSelect.HeaderText = "";
            this.colATSelect.MinimumWidth = 60;
            this.colATSelect.Name = "colATSelect";
            this.colATSelect.ReadOnly = true;
            this.colATSelect.Text = "Select";
            this.colATSelect.UseColumnTextForButtonValue = true;
            this.colATSelect.Width = 70;
            // 
            // colATDel
            // 
            this.colATDel.HeaderText = "";
            this.colATDel.MinimumWidth = 60;
            this.colATDel.Name = "colATDel";
            this.colATDel.ReadOnly = true;
            this.colATDel.Text = "Remove";
            this.colATDel.UseColumnTextForButtonValue = true;
            this.colATDel.Width = 70;
            // 
            // colATId
            // 
            this.colATId.HeaderText = "Id";
            this.colATId.Name = "colATId";
            this.colATId.ReadOnly = true;
            this.colATId.Visible = false;
            // 
            // colAType
            // 
            this.colAType.HeaderText = "Accommodation Type";
            this.colAType.MinimumWidth = 350;
            this.colAType.Name = "colAType";
            this.colAType.ReadOnly = true;
            this.colAType.Width = 350;
            // 
            // colAllowDP
            // 
            this.colAllowDP.HeaderText = "Accepts DP";
            this.colAllowDP.MinimumWidth = 90;
            this.colAllowDP.Name = "colAllowDP";
            this.colAllowDP.ReadOnly = true;
            this.colAllowDP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAllowDP.Width = 90;
            // 
            // colDPValue
            // 
            this.colDPValue.HeaderText = "DP Value";
            this.colDPValue.MinimumWidth = 80;
            this.colDPValue.Name = "colDPValue";
            this.colDPValue.ReadOnly = true;
            this.colDPValue.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DP Type";
            this.Column1.MinimumWidth = 80;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // pnlATData
            // 
            this.pnlATData.Controls.Add(this.cmbDPType);
            this.pnlATData.Controls.Add(this.txtDP);
            this.pnlATData.Controls.Add(this.lblDP);
            this.pnlATData.Controls.Add(this.txtATDesc);
            this.pnlATData.Controls.Add(this.chkAllowDP);
            this.pnlATData.Controls.Add(this.lblATDesc);
            this.pnlATData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlATData.Location = new System.Drawing.Point(3, 42);
            this.pnlATData.Name = "pnlATData";
            this.pnlATData.Size = new System.Drawing.Size(810, 96);
            this.pnlATData.TabIndex = 1;
            // 
            // cmbDPType
            // 
            this.cmbDPType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDPType.FormattingEnabled = true;
            this.cmbDPType.Items.AddRange(new object[] {
            "- Select DP Value type -",
            "in Percent",
            "in Fixed Amount"});
            this.cmbDPType.Location = new System.Drawing.Point(232, 60);
            this.cmbDPType.Name = "cmbDPType";
            this.cmbDPType.Size = new System.Drawing.Size(196, 22);
            this.cmbDPType.TabIndex = 6;
            // 
            // txtDP
            // 
            this.txtDP.Location = new System.Drawing.Point(145, 60);
            this.txtDP.Name = "txtDP";
            this.txtDP.Size = new System.Drawing.Size(81, 22);
            this.txtDP.TabIndex = 5;
            this.txtDP.Text = "0";
            this.txtDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDP
            // 
            this.lblDP.AutoSize = true;
            this.lblDP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDP.Location = new System.Drawing.Point(15, 63);
            this.lblDP.Name = "lblDP";
            this.lblDP.Size = new System.Drawing.Size(110, 14);
            this.lblDP.TabIndex = 4;
            this.lblDP.Text = "Downpayment Value";
            // 
            // txtATDesc
            // 
            this.txtATDesc.Location = new System.Drawing.Point(145, 11);
            this.txtATDesc.Name = "txtATDesc";
            this.txtATDesc.Size = new System.Drawing.Size(283, 22);
            this.txtATDesc.TabIndex = 3;
            // 
            // chkAllowDP
            // 
            this.chkAllowDP.AutoSize = true;
            this.chkAllowDP.Location = new System.Drawing.Point(145, 39);
            this.chkAllowDP.Name = "chkAllowDP";
            this.chkAllowDP.Size = new System.Drawing.Size(142, 18);
            this.chkAllowDP.TabIndex = 2;
            this.chkAllowDP.Text = "Accept Downpayment";
            this.chkAllowDP.UseVisualStyleBackColor = true;
            this.chkAllowDP.CheckedChanged += new System.EventHandler(this.chkAllowDP_CheckedChanged);
            // 
            // lblATDesc
            // 
            this.lblATDesc.AutoSize = true;
            this.lblATDesc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATDesc.Location = new System.Drawing.Point(15, 14);
            this.lblATDesc.Name = "lblATDesc";
            this.lblATDesc.Size = new System.Drawing.Size(114, 14);
            this.lblATDesc.TabIndex = 1;
            this.lblATDesc.Text = "Accommodation Type";
            // 
            // tsAccType
            // 
            this.tsAccType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddAT,
            this.tsbEditAT,
            this.tsbSaveAT,
            this.tsbCancelAT});
            this.tsAccType.Location = new System.Drawing.Point(3, 3);
            this.tsAccType.Name = "tsAccType";
            this.tsAccType.Size = new System.Drawing.Size(810, 39);
            this.tsAccType.TabIndex = 0;
            this.tsAccType.Text = "toolStrip1";
            // 
            // tsbAddAT
            // 
            this.tsbAddAT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddAT.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddAT.Image")));
            this.tsbAddAT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddAT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddAT.Name = "tsbAddAT";
            this.tsbAddAT.Size = new System.Drawing.Size(36, 36);
            this.tsbAddAT.Text = "New Accommodation Type";
            this.tsbAddAT.Click += new System.EventHandler(this.tsbAddAT_Click);
            // 
            // tsbEditAT
            // 
            this.tsbEditAT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditAT.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditAT.Image")));
            this.tsbEditAT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditAT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditAT.Name = "tsbEditAT";
            this.tsbEditAT.Size = new System.Drawing.Size(36, 36);
            this.tsbEditAT.Text = "Edit Accommodation Type";
            this.tsbEditAT.Visible = false;
            this.tsbEditAT.Click += new System.EventHandler(this.tsbEditAT_Click);
            // 
            // tsbSaveAT
            // 
            this.tsbSaveAT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveAT.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveAT.Image")));
            this.tsbSaveAT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSaveAT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveAT.Name = "tsbSaveAT";
            this.tsbSaveAT.Size = new System.Drawing.Size(36, 36);
            this.tsbSaveAT.Text = "Save";
            this.tsbSaveAT.Visible = false;
            this.tsbSaveAT.Click += new System.EventHandler(this.tsbSaveAT_Click);
            // 
            // tsbCancelAT
            // 
            this.tsbCancelAT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelAT.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelAT.Image")));
            this.tsbCancelAT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCancelAT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelAT.Name = "tsbCancelAT";
            this.tsbCancelAT.Size = new System.Drawing.Size(36, 36);
            this.tsbCancelAT.Text = "Cancel";
            this.tsbCancelAT.Visible = false;
            this.tsbCancelAT.Click += new System.EventHandler(this.tsbCancelAT_Click);
            // 
            // tpAcc
            // 
            this.tpAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpAcc.Controls.Add(this.pnlAccList);
            this.tpAcc.Controls.Add(this.pnlAccData);
            this.tpAcc.Controls.Add(this.tsAcc);
            this.tpAcc.Location = new System.Drawing.Point(4, 23);
            this.tpAcc.Name = "tpAcc";
            this.tpAcc.Padding = new System.Windows.Forms.Padding(3);
            this.tpAcc.Size = new System.Drawing.Size(818, 419);
            this.tpAcc.TabIndex = 1;
            this.tpAcc.Text = "Accommodations";
            this.tpAcc.UseVisualStyleBackColor = true;
            // 
            // pnlAccList
            // 
            this.pnlAccList.Controls.Add(this.dgvAC);
            this.pnlAccList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAccList.Location = new System.Drawing.Point(3, 157);
            this.pnlAccList.Name = "pnlAccList";
            this.pnlAccList.Size = new System.Drawing.Size(810, 257);
            this.pnlAccList.TabIndex = 4;
            // 
            // dgvAC
            // 
            this.dgvAC.AllowUserToAddRows = false;
            this.dgvAC.AllowUserToDeleteRows = false;
            this.dgvAC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colACSelect,
            this.colACDel,
            this.colACId,
            this.colACCode,
            this.colACDesc,
            this.colCap});
            this.dgvAC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAC.Location = new System.Drawing.Point(0, 0);
            this.dgvAC.Name = "dgvAC";
            this.dgvAC.ReadOnly = true;
            this.dgvAC.Size = new System.Drawing.Size(810, 257);
            this.dgvAC.TabIndex = 1;
            this.dgvAC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAC_CellContentClick);
            this.dgvAC.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAC_DataBindingComplete);
            // 
            // colACSelect
            // 
            this.colACSelect.HeaderText = "";
            this.colACSelect.MinimumWidth = 60;
            this.colACSelect.Name = "colACSelect";
            this.colACSelect.ReadOnly = true;
            this.colACSelect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colACSelect.Text = "Select";
            this.colACSelect.UseColumnTextForButtonValue = true;
            this.colACSelect.Width = 70;
            // 
            // colACDel
            // 
            this.colACDel.HeaderText = "";
            this.colACDel.MinimumWidth = 60;
            this.colACDel.Name = "colACDel";
            this.colACDel.ReadOnly = true;
            this.colACDel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colACDel.Text = "Remove";
            this.colACDel.UseColumnTextForButtonValue = true;
            this.colACDel.Width = 70;
            // 
            // colACId
            // 
            this.colACId.HeaderText = "Id";
            this.colACId.Name = "colACId";
            this.colACId.ReadOnly = true;
            this.colACId.Visible = false;
            // 
            // colACCode
            // 
            this.colACCode.HeaderText = "Code";
            this.colACCode.MinimumWidth = 100;
            this.colACCode.Name = "colACCode";
            this.colACCode.ReadOnly = true;
            this.colACCode.Width = 120;
            // 
            // colACDesc
            // 
            this.colACDesc.HeaderText = "Description";
            this.colACDesc.MinimumWidth = 300;
            this.colACDesc.Name = "colACDesc";
            this.colACDesc.ReadOnly = true;
            this.colACDesc.Width = 350;
            // 
            // colCap
            // 
            this.colCap.HeaderText = "Capacity";
            this.colCap.MinimumWidth = 100;
            this.colCap.Name = "colCap";
            this.colCap.ReadOnly = true;
            // 
            // pnlAccData
            // 
            this.pnlAccData.Controls.Add(this.lblACCapPax);
            this.pnlAccData.Controls.Add(this.txtACCap);
            this.pnlAccData.Controls.Add(this.txtACDesc);
            this.pnlAccData.Controls.Add(this.txtACCode);
            this.pnlAccData.Controls.Add(this.cmbACAT);
            this.pnlAccData.Controls.Add(this.lblACCap);
            this.pnlAccData.Controls.Add(this.lblACDesc);
            this.pnlAccData.Controls.Add(this.lblACCode);
            this.pnlAccData.Controls.Add(this.lblACAT);
            this.pnlAccData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccData.Location = new System.Drawing.Point(3, 42);
            this.pnlAccData.Name = "pnlAccData";
            this.pnlAccData.Size = new System.Drawing.Size(810, 115);
            this.pnlAccData.TabIndex = 3;
            // 
            // lblACCapPax
            // 
            this.lblACCapPax.AutoSize = true;
            this.lblACCapPax.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACCapPax.Location = new System.Drawing.Point(162, 86);
            this.lblACCapPax.Name = "lblACCapPax";
            this.lblACCapPax.Size = new System.Drawing.Size(25, 14);
            this.lblACCapPax.TabIndex = 10;
            this.lblACCapPax.Text = "pax";
            // 
            // txtACCap
            // 
            this.txtACCap.Location = new System.Drawing.Point(102, 83);
            this.txtACCap.MaxLength = 6;
            this.txtACCap.Name = "txtACCap";
            this.txtACCap.Size = new System.Drawing.Size(58, 22);
            this.txtACCap.TabIndex = 9;
            this.txtACCap.Text = "0";
            this.txtACCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtACDesc
            // 
            this.txtACDesc.Location = new System.Drawing.Point(102, 59);
            this.txtACDesc.MaxLength = 100;
            this.txtACDesc.Name = "txtACDesc";
            this.txtACDesc.Size = new System.Drawing.Size(310, 22);
            this.txtACDesc.TabIndex = 8;
            // 
            // txtACCode
            // 
            this.txtACCode.Location = new System.Drawing.Point(102, 35);
            this.txtACCode.MaxLength = 25;
            this.txtACCode.Name = "txtACCode";
            this.txtACCode.Size = new System.Drawing.Size(237, 22);
            this.txtACCode.TabIndex = 7;
            // 
            // cmbACAT
            // 
            this.cmbACAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbACAT.FormattingEnabled = true;
            this.cmbACAT.Location = new System.Drawing.Point(102, 11);
            this.cmbACAT.Name = "cmbACAT";
            this.cmbACAT.Size = new System.Drawing.Size(310, 22);
            this.cmbACAT.TabIndex = 6;
            this.cmbACAT.SelectedValueChanged += new System.EventHandler(this.cmbACAT_SelectedValueChanged);
            // 
            // lblACCap
            // 
            this.lblACCap.AutoSize = true;
            this.lblACCap.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACCap.Location = new System.Drawing.Point(15, 86);
            this.lblACCap.Name = "lblACCap";
            this.lblACCap.Size = new System.Drawing.Size(49, 14);
            this.lblACCap.TabIndex = 5;
            this.lblACCap.Text = "Capacity";
            // 
            // lblACDesc
            // 
            this.lblACDesc.AutoSize = true;
            this.lblACDesc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACDesc.Location = new System.Drawing.Point(15, 62);
            this.lblACDesc.Name = "lblACDesc";
            this.lblACDesc.Size = new System.Drawing.Size(63, 14);
            this.lblACDesc.TabIndex = 4;
            this.lblACDesc.Text = "Description";
            // 
            // lblACCode
            // 
            this.lblACCode.AutoSize = true;
            this.lblACCode.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACCode.Location = new System.Drawing.Point(15, 38);
            this.lblACCode.Name = "lblACCode";
            this.lblACCode.Size = new System.Drawing.Size(31, 14);
            this.lblACCode.TabIndex = 3;
            this.lblACCode.Text = "Code";
            // 
            // lblACAT
            // 
            this.lblACAT.AutoSize = true;
            this.lblACAT.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACAT.Location = new System.Drawing.Point(15, 14);
            this.lblACAT.Name = "lblACAT";
            this.lblACAT.Size = new System.Drawing.Size(31, 14);
            this.lblACAT.TabIndex = 2;
            this.lblACAT.Text = "Type";
            // 
            // tsAcc
            // 
            this.tsAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddAcc,
            this.tsbAccEdit,
            this.tsbSaveAcc,
            this.tsbCancelAcc});
            this.tsAcc.Location = new System.Drawing.Point(3, 3);
            this.tsAcc.Name = "tsAcc";
            this.tsAcc.Size = new System.Drawing.Size(810, 39);
            this.tsAcc.TabIndex = 1;
            this.tsAcc.Text = "toolStrip2";
            // 
            // tsbAddAcc
            // 
            this.tsbAddAcc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddAcc.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddAcc.Image")));
            this.tsbAddAcc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddAcc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddAcc.Name = "tsbAddAcc";
            this.tsbAddAcc.Size = new System.Drawing.Size(36, 36);
            this.tsbAddAcc.Text = "New Accommodation";
            this.tsbAddAcc.Click += new System.EventHandler(this.tsbAddAcc_Click);
            // 
            // tsbAccEdit
            // 
            this.tsbAccEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAccEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbAccEdit.Image")));
            this.tsbAccEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAccEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAccEdit.Name = "tsbAccEdit";
            this.tsbAccEdit.Size = new System.Drawing.Size(36, 36);
            this.tsbAccEdit.Text = "Edit Accommodation";
            this.tsbAccEdit.Visible = false;
            this.tsbAccEdit.Click += new System.EventHandler(this.tsbAccEdit_Click);
            // 
            // tsbSaveAcc
            // 
            this.tsbSaveAcc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveAcc.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveAcc.Image")));
            this.tsbSaveAcc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSaveAcc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveAcc.Name = "tsbSaveAcc";
            this.tsbSaveAcc.Size = new System.Drawing.Size(36, 36);
            this.tsbSaveAcc.Text = "Save Accommodation";
            this.tsbSaveAcc.Visible = false;
            this.tsbSaveAcc.Click += new System.EventHandler(this.tsbSaveAcc_Click);
            // 
            // tsbCancelAcc
            // 
            this.tsbCancelAcc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelAcc.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelAcc.Image")));
            this.tsbCancelAcc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCancelAcc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelAcc.Name = "tsbCancelAcc";
            this.tsbCancelAcc.Size = new System.Drawing.Size(36, 36);
            this.tsbCancelAcc.Text = "Cancel";
            this.tsbCancelAcc.Visible = false;
            this.tsbCancelAcc.Click += new System.EventHandler(this.tsbCancelAcc_Click);
            // 
            // tpAccRates
            // 
            this.tpAccRates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpAccRates.Controls.Add(this.pnlARData);
            this.tpAccRates.Controls.Add(this.tsAccRates);
            this.tpAccRates.Location = new System.Drawing.Point(4, 23);
            this.tpAccRates.Name = "tpAccRates";
            this.tpAccRates.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccRates.Size = new System.Drawing.Size(818, 419);
            this.tpAccRates.TabIndex = 2;
            this.tpAccRates.Text = "Accommodation Rates";
            this.tpAccRates.UseVisualStyleBackColor = true;
            // 
            // pnlARData
            // 
            this.pnlARData.Controls.Add(this.txtARWholeDay);
            this.pnlARData.Controls.Add(this.lblARWholeDay);
            this.pnlARData.Controls.Add(this.cmbAREx);
            this.pnlARData.Controls.Add(this.dtpARNightTo);
            this.pnlARData.Controls.Add(this.dtpARDayTo);
            this.pnlARData.Controls.Add(this.dtpARNightFrom);
            this.pnlARData.Controls.Add(this.dtpARDayFrom);
            this.pnlARData.Controls.Add(this.txtAREx);
            this.pnlARData.Controls.Add(this.txtARNight);
            this.pnlARData.Controls.Add(this.txtARDay);
            this.pnlARData.Controls.Add(this.lblAREx);
            this.pnlARData.Controls.Add(this.lblUsageNight);
            this.pnlARData.Controls.Add(this.lblUsageDay);
            this.pnlARData.Controls.Add(this.lblARNight);
            this.pnlARData.Controls.Add(this.lblARDay);
            this.pnlARData.Controls.Add(this.lblATRates);
            this.pnlARData.Controls.Add(this.cmbATAR);
            this.pnlARData.Controls.Add(this.lblATAR);
            this.pnlARData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlARData.Location = new System.Drawing.Point(3, 42);
            this.pnlARData.Name = "pnlARData";
            this.pnlARData.Size = new System.Drawing.Size(810, 372);
            this.pnlARData.TabIndex = 3;
            // 
            // txtARWholeDay
            // 
            this.txtARWholeDay.Location = new System.Drawing.Point(269, 150);
            this.txtARWholeDay.Name = "txtARWholeDay";
            this.txtARWholeDay.Size = new System.Drawing.Size(100, 22);
            this.txtARWholeDay.TabIndex = 9;
            this.txtARWholeDay.Text = "0.00";
            this.txtARWholeDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtARWholeDay.Visible = false;
            // 
            // lblARWholeDay
            // 
            this.lblARWholeDay.AutoSize = true;
            this.lblARWholeDay.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblARWholeDay.Location = new System.Drawing.Point(50, 153);
            this.lblARWholeDay.Name = "lblARWholeDay";
            this.lblARWholeDay.Size = new System.Drawing.Size(213, 14);
            this.lblARWholeDay.TabIndex = 24;
            this.lblARWholeDay.Text = "Whole day rates from opening till closing ";
            this.lblARWholeDay.Visible = false;
            // 
            // cmbAREx
            // 
            this.cmbAREx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAREx.FormattingEnabled = true;
            this.cmbAREx.Items.AddRange(new object[] {
            "per Hour",
            "per Day"});
            this.cmbAREx.Location = new System.Drawing.Point(253, 115);
            this.cmbAREx.Name = "cmbAREx";
            this.cmbAREx.Size = new System.Drawing.Size(121, 22);
            this.cmbAREx.TabIndex = 8;
            // 
            // dtpARNightTo
            // 
            this.dtpARNightTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpARNightTo.Location = new System.Drawing.Point(530, 91);
            this.dtpARNightTo.Name = "dtpARNightTo";
            this.dtpARNightTo.ShowUpDown = true;
            this.dtpARNightTo.Size = new System.Drawing.Size(110, 22);
            this.dtpARNightTo.TabIndex = 6;
            // 
            // dtpARDayTo
            // 
            this.dtpARDayTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpARDayTo.Location = new System.Drawing.Point(530, 67);
            this.dtpARDayTo.Name = "dtpARDayTo";
            this.dtpARDayTo.ShowUpDown = true;
            this.dtpARDayTo.Size = new System.Drawing.Size(110, 22);
            this.dtpARDayTo.TabIndex = 3;
            // 
            // dtpARNightFrom
            // 
            this.dtpARNightFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpARNightFrom.Location = new System.Drawing.Point(387, 91);
            this.dtpARNightFrom.Name = "dtpARNightFrom";
            this.dtpARNightFrom.ShowUpDown = true;
            this.dtpARNightFrom.Size = new System.Drawing.Size(110, 22);
            this.dtpARNightFrom.TabIndex = 5;
            // 
            // dtpARDayFrom
            // 
            this.dtpARDayFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpARDayFrom.Location = new System.Drawing.Point(387, 67);
            this.dtpARDayFrom.Name = "dtpARDayFrom";
            this.dtpARDayFrom.ShowUpDown = true;
            this.dtpARDayFrom.Size = new System.Drawing.Size(110, 22);
            this.dtpARDayFrom.TabIndex = 2;
            // 
            // txtAREx
            // 
            this.txtAREx.Location = new System.Drawing.Point(147, 115);
            this.txtAREx.Name = "txtAREx";
            this.txtAREx.Size = new System.Drawing.Size(100, 22);
            this.txtAREx.TabIndex = 7;
            this.txtAREx.Text = "0.00";
            this.txtAREx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtARNight
            // 
            this.txtARNight.Location = new System.Drawing.Point(147, 91);
            this.txtARNight.Name = "txtARNight";
            this.txtARNight.Size = new System.Drawing.Size(100, 22);
            this.txtARNight.TabIndex = 4;
            this.txtARNight.Text = "0.00";
            this.txtARNight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtARDay
            // 
            this.txtARDay.Location = new System.Drawing.Point(147, 67);
            this.txtARDay.Name = "txtARDay";
            this.txtARDay.Size = new System.Drawing.Size(100, 22);
            this.txtARDay.TabIndex = 1;
            this.txtARDay.Text = "0.00";
            this.txtARDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAREx
            // 
            this.lblAREx.AutoSize = true;
            this.lblAREx.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAREx.Location = new System.Drawing.Point(50, 118);
            this.lblAREx.Name = "lblAREx";
            this.lblAREx.Size = new System.Drawing.Size(86, 14);
            this.lblAREx.TabIndex = 14;
            this.lblAREx.Text = "Extension Rates";
            // 
            // lblUsageNight
            // 
            this.lblUsageNight.AutoSize = true;
            this.lblUsageNight.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsageNight.Location = new System.Drawing.Point(271, 94);
            this.lblUsageNight.Name = "lblUsageNight";
            this.lblUsageNight.Size = new System.Drawing.Size(253, 14);
            this.lblUsageNight.TabIndex = 13;
            this.lblUsageNight.Text = "Usage Duration from                                           till";
            // 
            // lblUsageDay
            // 
            this.lblUsageDay.AutoSize = true;
            this.lblUsageDay.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsageDay.Location = new System.Drawing.Point(271, 70);
            this.lblUsageDay.Name = "lblUsageDay";
            this.lblUsageDay.Size = new System.Drawing.Size(253, 14);
            this.lblUsageDay.TabIndex = 12;
            this.lblUsageDay.Text = "Usage Duration from                                           till";
            // 
            // lblARNight
            // 
            this.lblARNight.AutoSize = true;
            this.lblARNight.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblARNight.Location = new System.Drawing.Point(50, 94);
            this.lblARNight.Name = "lblARNight";
            this.lblARNight.Size = new System.Drawing.Size(87, 14);
            this.lblARNight.TabIndex = 11;
            this.lblARNight.Text = "Overnight Rates";
            // 
            // lblARDay
            // 
            this.lblARDay.AutoSize = true;
            this.lblARDay.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblARDay.Location = new System.Drawing.Point(50, 70);
            this.lblARDay.Name = "lblARDay";
            this.lblARDay.Size = new System.Drawing.Size(58, 14);
            this.lblARDay.TabIndex = 10;
            this.lblARDay.Text = "Day Rates";
            // 
            // lblATRates
            // 
            this.lblATRates.AutoSize = true;
            this.lblATRates.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATRates.Location = new System.Drawing.Point(15, 46);
            this.lblATRates.Name = "lblATRates";
            this.lblATRates.Size = new System.Drawing.Size(118, 14);
            this.lblATRates.TabIndex = 9;
            this.lblATRates.Text = "Accommodation Rates";
            // 
            // cmbATAR
            // 
            this.cmbATAR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbATAR.FormattingEnabled = true;
            this.cmbATAR.Location = new System.Drawing.Point(147, 11);
            this.cmbATAR.Name = "cmbATAR";
            this.cmbATAR.Size = new System.Drawing.Size(350, 22);
            this.cmbATAR.TabIndex = 0;
            this.cmbATAR.SelectedValueChanged += new System.EventHandler(this.cmbATAR_SelectedValueChanged);
            // 
            // lblATAR
            // 
            this.lblATAR.AutoSize = true;
            this.lblATAR.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATAR.Location = new System.Drawing.Point(15, 14);
            this.lblATAR.Name = "lblATAR";
            this.lblATAR.Size = new System.Drawing.Size(114, 14);
            this.lblATAR.TabIndex = 7;
            this.lblATAR.Text = "Accommodation Type";
            // 
            // tsAccRates
            // 
            this.tsAccRates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSaveAR,
            this.tsbCancelAR});
            this.tsAccRates.Location = new System.Drawing.Point(3, 3);
            this.tsAccRates.Name = "tsAccRates";
            this.tsAccRates.Size = new System.Drawing.Size(810, 39);
            this.tsAccRates.TabIndex = 1;
            this.tsAccRates.Text = "toolStrip3";
            // 
            // tsbSaveAR
            // 
            this.tsbSaveAR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveAR.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveAR.Image")));
            this.tsbSaveAR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSaveAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveAR.Name = "tsbSaveAR";
            this.tsbSaveAR.Size = new System.Drawing.Size(36, 36);
            this.tsbSaveAR.Text = "Save Rates";
            this.tsbSaveAR.Click += new System.EventHandler(this.tsbSaveAR_Click);
            // 
            // tsbCancelAR
            // 
            this.tsbCancelAR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelAR.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelAR.Image")));
            this.tsbCancelAR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCancelAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelAR.Name = "tsbCancelAR";
            this.tsbCancelAR.Size = new System.Drawing.Size(36, 36);
            this.tsbCancelAR.Text = "Cancel";
            this.tsbCancelAR.Click += new System.EventHandler(this.tsbCancelAR_Click);
            // 
            // frmAccommodationsSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 446);
            this.Controls.Add(this.tcAccommodation);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccommodationsSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accommodations Setup";
            this.Load += new System.EventHandler(this.frmAccommodationsSetup_Load);
            this.tcAccommodation.ResumeLayout(false);
            this.tpAccType.ResumeLayout(false);
            this.tpAccType.PerformLayout();
            this.pnlATList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAT)).EndInit();
            this.pnlATData.ResumeLayout(false);
            this.pnlATData.PerformLayout();
            this.tsAccType.ResumeLayout(false);
            this.tsAccType.PerformLayout();
            this.tpAcc.ResumeLayout(false);
            this.tpAcc.PerformLayout();
            this.pnlAccList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAC)).EndInit();
            this.pnlAccData.ResumeLayout(false);
            this.pnlAccData.PerformLayout();
            this.tsAcc.ResumeLayout(false);
            this.tsAcc.PerformLayout();
            this.tpAccRates.ResumeLayout(false);
            this.tpAccRates.PerformLayout();
            this.pnlARData.ResumeLayout(false);
            this.pnlARData.PerformLayout();
            this.tsAccRates.ResumeLayout(false);
            this.tsAccRates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAccommodation;
        private System.Windows.Forms.TabPage tpAccType;
        private System.Windows.Forms.TabPage tpAcc;
        private System.Windows.Forms.TabPage tpAccRates;
        private System.Windows.Forms.ToolStrip tsAccType;
        private System.Windows.Forms.ToolStripButton tsbAddAT;
        private System.Windows.Forms.ToolStripButton tsbSaveAT;
        private System.Windows.Forms.ToolStripButton tsbCancelAT;
        private System.Windows.Forms.ToolStrip tsAcc;
        private System.Windows.Forms.ToolStripButton tsbAddAcc;
        private System.Windows.Forms.ToolStripButton tsbSaveAcc;
        private System.Windows.Forms.ToolStripButton tsbCancelAcc;
        private System.Windows.Forms.ToolStrip tsAccRates;
        private System.Windows.Forms.ToolStripButton tsbSaveAR;
        private System.Windows.Forms.ToolStripButton tsbCancelAR;
        private System.Windows.Forms.Panel pnlATList;
        private System.Windows.Forms.DataGridView dgvAT;
        private System.Windows.Forms.Panel pnlATData;
        private System.Windows.Forms.ComboBox cmbDPType;
        private System.Windows.Forms.TextBox txtDP;
        private System.Windows.Forms.Label lblDP;
        private System.Windows.Forms.TextBox txtATDesc;
        private System.Windows.Forms.CheckBox chkAllowDP;
        private System.Windows.Forms.Label lblATDesc;
        private System.Windows.Forms.Panel pnlAccList;
        private System.Windows.Forms.DataGridView dgvAC;
        private System.Windows.Forms.Panel pnlAccData;
        private System.Windows.Forms.Label lblACCapPax;
        private System.Windows.Forms.TextBox txtACCap;
        private System.Windows.Forms.TextBox txtACDesc;
        private System.Windows.Forms.TextBox txtACCode;
        private System.Windows.Forms.ComboBox cmbACAT;
        private System.Windows.Forms.Label lblACCap;
        private System.Windows.Forms.Label lblACDesc;
        private System.Windows.Forms.Label lblACCode;
        private System.Windows.Forms.Label lblACAT;
        private System.Windows.Forms.Panel pnlARData;
        private System.Windows.Forms.ComboBox cmbATAR;
        private System.Windows.Forms.Label lblATAR;
        private System.Windows.Forms.ComboBox cmbAREx;
        private System.Windows.Forms.DateTimePicker dtpARNightTo;
        private System.Windows.Forms.DateTimePicker dtpARDayTo;
        private System.Windows.Forms.DateTimePicker dtpARNightFrom;
        private System.Windows.Forms.DateTimePicker dtpARDayFrom;
        private System.Windows.Forms.TextBox txtAREx;
        private System.Windows.Forms.TextBox txtARNight;
        private System.Windows.Forms.TextBox txtARDay;
        private System.Windows.Forms.Label lblAREx;
        private System.Windows.Forms.Label lblUsageNight;
        private System.Windows.Forms.Label lblUsageDay;
        private System.Windows.Forms.Label lblARNight;
        private System.Windows.Forms.Label lblARDay;
        private System.Windows.Forms.Label lblATRates;
        private System.Windows.Forms.TextBox txtARWholeDay;
        private System.Windows.Forms.Label lblARWholeDay;
        private System.Windows.Forms.ToolStripButton tsbEditAT;
        private System.Windows.Forms.ToolStripButton tsbAccEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colACSelect;
        private System.Windows.Forms.DataGridViewButtonColumn colACDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colACId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colACCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colACDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCap;
        private System.Windows.Forms.DataGridViewButtonColumn colATSelect;
        private System.Windows.Forms.DataGridViewButtonColumn colATDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colATId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllowDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDPValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}