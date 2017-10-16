namespace CAReserveSystem
{
    partial class frmInventorySetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventorySetup));
            this.tcContainer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlITList = new System.Windows.Forms.Panel();
            this.dgvIT = new System.Windows.Forms.DataGridView();
            this.colSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colITId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvTypeDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlITData = new System.Windows.Forms.Panel();
            this.txtIType = new System.Windows.Forms.TextBox();
            this.lblIType = new System.Windows.Forms.Label();
            this.tsInvTypes = new System.Windows.Forms.ToolStrip();
            this.tsbITAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbITEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbITSave = new System.Windows.Forms.ToolStripButton();
            this.tsbITCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbFind = new System.Windows.Forms.ToolStripButton();
            this.tstFind = new System.Windows.Forms.ToolStripTextBox();
            this.tslFind = new System.Windows.Forms.ToolStripLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlIList = new System.Windows.Forms.Panel();
            this.dgvI = new System.Windows.Forms.DataGridView();
            this.pnlIData = new System.Windows.Forms.Panel();
            this.txtDepo = new System.Windows.Forms.TextBox();
            this.chkDepo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIType = new System.Windows.Forms.ComboBox();
            this.txtICode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsItems = new System.Windows.Forms.ToolStrip();
            this.tsbIAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbIEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbISave = new System.Windows.Forms.ToolStripButton();
            this.tsbICancel = new System.Windows.Forms.ToolStripButton();
            this.tsbIFind = new System.Windows.Forms.ToolStripButton();
            this.tstIFind = new System.Windows.Forms.ToolStripTextBox();
            this.tslIFind = new System.Windows.Forms.ToolStripLabel();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colIId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcContainer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlITList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIT)).BeginInit();
            this.pnlITData.SuspendLayout();
            this.tsInvTypes.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlIList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvI)).BeginInit();
            this.pnlIData.SuspendLayout();
            this.tsItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcContainer
            // 
            this.tcContainer.Controls.Add(this.tabPage1);
            this.tcContainer.Controls.Add(this.tabPage2);
            this.tcContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcContainer.Location = new System.Drawing.Point(0, 0);
            this.tcContainer.Name = "tcContainer";
            this.tcContainer.SelectedIndex = 0;
            this.tcContainer.Size = new System.Drawing.Size(718, 453);
            this.tcContainer.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.pnlITList);
            this.tabPage1.Controls.Add(this.pnlITData);
            this.tabPage1.Controls.Add(this.tsInvTypes);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(710, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inventory Types";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlITList
            // 
            this.pnlITList.Controls.Add(this.dgvIT);
            this.pnlITList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlITList.Location = new System.Drawing.Point(3, 88);
            this.pnlITList.Name = "pnlITList";
            this.pnlITList.Size = new System.Drawing.Size(702, 333);
            this.pnlITList.TabIndex = 2;
            // 
            // dgvIT
            // 
            this.dgvIT.AllowUserToAddRows = false;
            this.dgvIT.AllowUserToDeleteRows = false;
            this.dgvIT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colRemove,
            this.colITId,
            this.colInvTypeDesc});
            this.dgvIT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIT.Location = new System.Drawing.Point(0, 0);
            this.dgvIT.Name = "dgvIT";
            this.dgvIT.ReadOnly = true;
            this.dgvIT.Size = new System.Drawing.Size(702, 333);
            this.dgvIT.TabIndex = 0;
            this.dgvIT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIT_CellContentClick);
            this.dgvIT.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvIT_DataBindingComplete);
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "";
            this.colSelect.MinimumWidth = 60;
            this.colSelect.Name = "colSelect";
            this.colSelect.ReadOnly = true;
            this.colSelect.Text = "Select";
            this.colSelect.UseColumnTextForButtonValue = true;
            this.colSelect.Width = 60;
            // 
            // colRemove
            // 
            this.colRemove.HeaderText = "";
            this.colRemove.MinimumWidth = 60;
            this.colRemove.Name = "colRemove";
            this.colRemove.ReadOnly = true;
            this.colRemove.Text = "Remove";
            this.colRemove.UseColumnTextForButtonValue = true;
            this.colRemove.Width = 60;
            // 
            // colITId
            // 
            this.colITId.HeaderText = "Id";
            this.colITId.MinimumWidth = 50;
            this.colITId.Name = "colITId";
            this.colITId.ReadOnly = true;
            this.colITId.Visible = false;
            this.colITId.Width = 50;
            // 
            // colInvTypeDesc
            // 
            this.colInvTypeDesc.HeaderText = "Description";
            this.colInvTypeDesc.MinimumWidth = 400;
            this.colInvTypeDesc.Name = "colInvTypeDesc";
            this.colInvTypeDesc.ReadOnly = true;
            this.colInvTypeDesc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colInvTypeDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colInvTypeDesc.Width = 400;
            // 
            // pnlITData
            // 
            this.pnlITData.Controls.Add(this.txtIType);
            this.pnlITData.Controls.Add(this.lblIType);
            this.pnlITData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlITData.Location = new System.Drawing.Point(3, 42);
            this.pnlITData.Name = "pnlITData";
            this.pnlITData.Size = new System.Drawing.Size(702, 46);
            this.pnlITData.TabIndex = 1;
            // 
            // txtIType
            // 
            this.txtIType.Location = new System.Drawing.Point(120, 12);
            this.txtIType.Name = "txtIType";
            this.txtIType.Size = new System.Drawing.Size(300, 22);
            this.txtIType.TabIndex = 1;
            // 
            // lblIType
            // 
            this.lblIType.AutoSize = true;
            this.lblIType.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIType.Location = new System.Drawing.Point(15, 15);
            this.lblIType.Name = "lblIType";
            this.lblIType.Size = new System.Drawing.Size(57, 14);
            this.lblIType.TabIndex = 0;
            this.lblIType.Text = "Item Type";
            // 
            // tsInvTypes
            // 
            this.tsInvTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbITAdd,
            this.tsbITEdit,
            this.tsbITSave,
            this.tsbITCancel,
            this.tsbFind,
            this.tstFind,
            this.tslFind});
            this.tsInvTypes.Location = new System.Drawing.Point(3, 3);
            this.tsInvTypes.Name = "tsInvTypes";
            this.tsInvTypes.Size = new System.Drawing.Size(702, 39);
            this.tsInvTypes.TabIndex = 0;
            this.tsInvTypes.Text = "toolStrip1";
            // 
            // tsbITAdd
            // 
            this.tsbITAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbITAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbITAdd.Image")));
            this.tsbITAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbITAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbITAdd.Name = "tsbITAdd";
            this.tsbITAdd.Size = new System.Drawing.Size(36, 36);
            this.tsbITAdd.Text = "New Type";
            this.tsbITAdd.Click += new System.EventHandler(this.tsbITAdd_Click);
            // 
            // tsbITEdit
            // 
            this.tsbITEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbITEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbITEdit.Image")));
            this.tsbITEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbITEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbITEdit.Name = "tsbITEdit";
            this.tsbITEdit.Size = new System.Drawing.Size(36, 36);
            this.tsbITEdit.Text = "toolStripButton4";
            this.tsbITEdit.Visible = false;
            this.tsbITEdit.Click += new System.EventHandler(this.tsbITEdit_Click);
            // 
            // tsbITSave
            // 
            this.tsbITSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbITSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbITSave.Image")));
            this.tsbITSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbITSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbITSave.Name = "tsbITSave";
            this.tsbITSave.Size = new System.Drawing.Size(36, 36);
            this.tsbITSave.Text = "Save";
            this.tsbITSave.Visible = false;
            this.tsbITSave.Click += new System.EventHandler(this.tsbITSave_Click);
            // 
            // tsbITCancel
            // 
            this.tsbITCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbITCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbITCancel.Image")));
            this.tsbITCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbITCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbITCancel.Name = "tsbITCancel";
            this.tsbITCancel.Size = new System.Drawing.Size(36, 36);
            this.tsbITCancel.Text = "Cancel";
            this.tsbITCancel.Visible = false;
            this.tsbITCancel.Click += new System.EventHandler(this.tsbITCancel_Click);
            // 
            // tsbFind
            // 
            this.tsbFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFind.Image = ((System.Drawing.Image)(resources.GetObject("tsbFind.Image")));
            this.tsbFind.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFind.Name = "tsbFind";
            this.tsbFind.Size = new System.Drawing.Size(36, 36);
            this.tsbFind.Text = "toolStripButton5";
            this.tsbFind.Click += new System.EventHandler(this.tsbFind_Click);
            // 
            // tstFind
            // 
            this.tstFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstFind.Name = "tstFind";
            this.tstFind.Size = new System.Drawing.Size(150, 39);
            this.tstFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstFind_KeyDown);
            // 
            // tslFind
            // 
            this.tslFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslFind.Name = "tslFind";
            this.tslFind.Size = new System.Drawing.Size(30, 36);
            this.tslFind.Text = "Find";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.pnlIList);
            this.tabPage2.Controls.Add(this.pnlIData);
            this.tabPage2.Controls.Add(this.tsItems);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Items";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlIList
            // 
            this.pnlIList.Controls.Add(this.dgvI);
            this.pnlIList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIList.Location = new System.Drawing.Point(3, 163);
            this.pnlIList.Name = "pnlIList";
            this.pnlIList.Size = new System.Drawing.Size(702, 258);
            this.pnlIList.TabIndex = 4;
            // 
            // dgvI
            // 
            this.dgvI.AllowUserToAddRows = false;
            this.dgvI.AllowUserToDeleteRows = false;
            this.dgvI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2,
            this.colIId,
            this.dataGridViewTextBoxColumn1,
            this.colIDesc});
            this.dgvI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvI.Location = new System.Drawing.Point(0, 0);
            this.dgvI.Name = "dgvI";
            this.dgvI.ReadOnly = true;
            this.dgvI.Size = new System.Drawing.Size(702, 258);
            this.dgvI.TabIndex = 0;
            this.dgvI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvI_CellContentClick);
            this.dgvI.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvIT_DataBindingComplete);
            // 
            // pnlIData
            // 
            this.pnlIData.Controls.Add(this.txtDepo);
            this.pnlIData.Controls.Add(this.chkDepo);
            this.pnlIData.Controls.Add(this.label4);
            this.pnlIData.Controls.Add(this.txtIPrice);
            this.pnlIData.Controls.Add(this.label3);
            this.pnlIData.Controls.Add(this.txtIDesc);
            this.pnlIData.Controls.Add(this.label2);
            this.pnlIData.Controls.Add(this.cmbIType);
            this.pnlIData.Controls.Add(this.txtICode);
            this.pnlIData.Controls.Add(this.label1);
            this.pnlIData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIData.Location = new System.Drawing.Point(3, 42);
            this.pnlIData.Name = "pnlIData";
            this.pnlIData.Size = new System.Drawing.Size(702, 121);
            this.pnlIData.TabIndex = 3;
            // 
            // txtDepo
            // 
            this.txtDepo.Location = new System.Drawing.Point(350, 84);
            this.txtDepo.Name = "txtDepo";
            this.txtDepo.Size = new System.Drawing.Size(70, 22);
            this.txtDepo.TabIndex = 11;
            this.txtDepo.Text = "0.00";
            this.txtDepo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDepo.Visible = false;
            // 
            // chkDepo
            // 
            this.chkDepo.AutoSize = true;
            this.chkDepo.Location = new System.Drawing.Point(246, 86);
            this.chkDepo.Name = "chkDepo";
            this.chkDepo.Size = new System.Drawing.Size(98, 18);
            this.chkDepo.TabIndex = 10;
            this.chkDepo.Text = "With Deposit";
            this.chkDepo.UseVisualStyleBackColor = true;
            this.chkDepo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // txtIPrice
            // 
            this.txtIPrice.Location = new System.Drawing.Point(120, 84);
            this.txtIPrice.Name = "txtIPrice";
            this.txtIPrice.Size = new System.Drawing.Size(70, 22);
            this.txtIPrice.TabIndex = 8;
            this.txtIPrice.Text = "0.00";
            this.txtIPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // txtIDesc
            // 
            this.txtIDesc.Location = new System.Drawing.Point(120, 60);
            this.txtIDesc.Name = "txtIDesc";
            this.txtIDesc.Size = new System.Drawing.Size(300, 22);
            this.txtIDesc.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item Code";
            // 
            // cmbIType
            // 
            this.cmbIType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIType.FormattingEnabled = true;
            this.cmbIType.Location = new System.Drawing.Point(120, 12);
            this.cmbIType.Name = "cmbIType";
            this.cmbIType.Size = new System.Drawing.Size(300, 22);
            this.cmbIType.TabIndex = 4;
            // 
            // txtICode
            // 
            this.txtICode.Location = new System.Drawing.Point(120, 36);
            this.txtICode.Name = "txtICode";
            this.txtICode.Size = new System.Drawing.Size(300, 22);
            this.txtICode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Type";
            // 
            // tsItems
            // 
            this.tsItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbIAdd,
            this.tsbIEdit,
            this.tsbISave,
            this.tsbICancel,
            this.tsbIFind,
            this.tstIFind,
            this.tslIFind});
            this.tsItems.Location = new System.Drawing.Point(3, 3);
            this.tsItems.Name = "tsItems";
            this.tsItems.Size = new System.Drawing.Size(702, 39);
            this.tsItems.TabIndex = 0;
            this.tsItems.Text = "toolStrip1";
            // 
            // tsbIAdd
            // 
            this.tsbIAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbIAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbIAdd.Image")));
            this.tsbIAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbIAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIAdd.Name = "tsbIAdd";
            this.tsbIAdd.Size = new System.Drawing.Size(36, 36);
            this.tsbIAdd.Text = "New Type";
            this.tsbIAdd.Click += new System.EventHandler(this.tsbIAdd_Click);
            // 
            // tsbIEdit
            // 
            this.tsbIEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbIEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbIEdit.Image")));
            this.tsbIEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbIEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIEdit.Name = "tsbIEdit";
            this.tsbIEdit.Size = new System.Drawing.Size(36, 36);
            this.tsbIEdit.Text = "toolStripButton4";
            this.tsbIEdit.Visible = false;
            this.tsbIEdit.Click += new System.EventHandler(this.tsbIEdit_Click);
            // 
            // tsbISave
            // 
            this.tsbISave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbISave.Image = ((System.Drawing.Image)(resources.GetObject("tsbISave.Image")));
            this.tsbISave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbISave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbISave.Name = "tsbISave";
            this.tsbISave.Size = new System.Drawing.Size(36, 36);
            this.tsbISave.Text = "Save";
            this.tsbISave.Visible = false;
            this.tsbISave.Click += new System.EventHandler(this.tsbISave_Click);
            // 
            // tsbICancel
            // 
            this.tsbICancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbICancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbICancel.Image")));
            this.tsbICancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbICancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbICancel.Name = "tsbICancel";
            this.tsbICancel.Size = new System.Drawing.Size(36, 36);
            this.tsbICancel.Text = "Cancel";
            this.tsbICancel.Visible = false;
            this.tsbICancel.Click += new System.EventHandler(this.tsbICancel_Click);
            // 
            // tsbIFind
            // 
            this.tsbIFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbIFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbIFind.Image = ((System.Drawing.Image)(resources.GetObject("tsbIFind.Image")));
            this.tsbIFind.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbIFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIFind.Name = "tsbIFind";
            this.tsbIFind.Size = new System.Drawing.Size(36, 36);
            this.tsbIFind.Text = "toolStripButton5";
            this.tsbIFind.Click += new System.EventHandler(this.tsbIFind_Click);
            // 
            // tstIFind
            // 
            this.tstIFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstIFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstIFind.Name = "tstIFind";
            this.tstIFind.Size = new System.Drawing.Size(150, 39);
            this.tstIFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstIFind_KeyDown);
            // 
            // tslIFind
            // 
            this.tslIFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslIFind.Name = "tslIFind";
            this.tslIFind.Size = new System.Drawing.Size(30, 36);
            this.tslIFind.Text = "Find";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.MinimumWidth = 60;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Select";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 60;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.MinimumWidth = 60;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Text = "Remove";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn2.Width = 60;
            // 
            // colIId
            // 
            this.colIId.DataPropertyName = "id";
            this.colIId.HeaderText = "Id";
            this.colIId.Name = "colIId";
            this.colIId.ReadOnly = true;
            this.colIId.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "itemcode";
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colIDesc
            // 
            this.colIDesc.DataPropertyName = "itemdesc";
            this.colIDesc.HeaderText = "Description";
            this.colIDesc.MinimumWidth = 400;
            this.colIDesc.Name = "colIDesc";
            this.colIDesc.ReadOnly = true;
            this.colIDesc.Width = 400;
            // 
            // frmInventorySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 453);
            this.Controls.Add(this.tcContainer);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInventorySetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Setup";
            this.Load += new System.EventHandler(this.frmInventorySetup_Load);
            this.tcContainer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlITList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIT)).EndInit();
            this.pnlITData.ResumeLayout(false);
            this.pnlITData.PerformLayout();
            this.tsInvTypes.ResumeLayout(false);
            this.tsInvTypes.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnlIList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvI)).EndInit();
            this.pnlIData.ResumeLayout(false);
            this.pnlIData.PerformLayout();
            this.tsItems.ResumeLayout(false);
            this.tsItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcContainer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip tsInvTypes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlITList;
        private System.Windows.Forms.DataGridView dgvIT;
        private System.Windows.Forms.Panel pnlITData;
        private System.Windows.Forms.ToolStripButton tsbITAdd;
        private System.Windows.Forms.ToolStripButton tsbITSave;
        private System.Windows.Forms.ToolStripButton tsbITCancel;
        private System.Windows.Forms.ToolStrip tsItems;
        private System.Windows.Forms.ToolStripButton tsbITEdit;
        private System.Windows.Forms.ToolStripButton tsbFind;
        private System.Windows.Forms.ToolStripTextBox tstFind;
        private System.Windows.Forms.ToolStripLabel tslFind;
        private System.Windows.Forms.ToolStripButton tsbIAdd;
        private System.Windows.Forms.ToolStripButton tsbIEdit;
        private System.Windows.Forms.ToolStripButton tsbISave;
        private System.Windows.Forms.ToolStripButton tsbICancel;
        private System.Windows.Forms.ToolStripLabel tslIFind;
        private System.Windows.Forms.ToolStripTextBox tstIFind;
        private System.Windows.Forms.ToolStripButton tsbIFind;
        private System.Windows.Forms.Panel pnlIList;
        private System.Windows.Forms.DataGridView dgvI;
        private System.Windows.Forms.Panel pnlIData;
        private System.Windows.Forms.TextBox txtIType;
        private System.Windows.Forms.Label lblIType;
        private System.Windows.Forms.ComboBox cmbIType;
        private System.Windows.Forms.TextBox txtICode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDepo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepo;
        private System.Windows.Forms.DataGridViewButtonColumn colSelect;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn colITId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvTypeDesc;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDesc;
    }
}