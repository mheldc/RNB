namespace CAReserveSystem
{
    partial class frmBRequestItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBRequestItems));
            this.pnlAcctInfo = new System.Windows.Forms.Panel();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lblAcc = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblAcctInfo = new System.Windows.Forms.Label();
            this.pnlItemData = new System.Windows.Forms.Panel();
            this.txtST = new System.Windows.Forms.TextBox();
            this.lblST = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtDP = new System.Windows.Forms.TextBox();
            this.chkDP = new System.Windows.Forms.CheckBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.cmbIType = new System.Windows.Forms.ComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblIType = new System.Windows.Forms.Label();
            this.lblItemInfo = new System.Windows.Forms.Label();
            this.pnlRIList = new System.Windows.Forms.Panel();
            this.dgvRIList = new System.Windows.Forms.DataGridView();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlItemTotals = new System.Windows.Forms.Panel();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.txtTotalValue = new System.Windows.Forms.TextBox();
            this.btnProcessRI = new System.Windows.Forms.Button();
            this.pnlAcctInfo.SuspendLayout();
            this.pnlItemData.SuspendLayout();
            this.pnlRIList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRIList)).BeginInit();
            this.pnlItemTotals.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAcctInfo
            // 
            this.pnlAcctInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAcctInfo.Controls.Add(this.txtAcc);
            this.pnlAcctInfo.Controls.Add(this.txtGuestName);
            this.pnlAcctInfo.Controls.Add(this.lblAcc);
            this.pnlAcctInfo.Controls.Add(this.lblGuestName);
            this.pnlAcctInfo.Controls.Add(this.lblAcctInfo);
            this.pnlAcctInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAcctInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlAcctInfo.Name = "pnlAcctInfo";
            this.pnlAcctInfo.Size = new System.Drawing.Size(684, 93);
            this.pnlAcctInfo.TabIndex = 6;
            // 
            // txtAcc
            // 
            this.txtAcc.Enabled = false;
            this.txtAcc.Location = new System.Drawing.Point(129, 54);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.ReadOnly = true;
            this.txtAcc.Size = new System.Drawing.Size(386, 22);
            this.txtAcc.TabIndex = 4;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Enabled = false;
            this.txtGuestName.Location = new System.Drawing.Point(129, 30);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.ReadOnly = true;
            this.txtGuestName.Size = new System.Drawing.Size(386, 22);
            this.txtGuestName.TabIndex = 3;
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcc.Location = new System.Drawing.Point(31, 57);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(87, 14);
            this.lblAcc.TabIndex = 2;
            this.lblAcc.Text = "Accommodation";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.Location = new System.Drawing.Point(31, 33);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(69, 14);
            this.lblGuestName.TabIndex = 1;
            this.lblGuestName.Text = "Guest Name";
            // 
            // lblAcctInfo
            // 
            this.lblAcctInfo.AutoSize = true;
            this.lblAcctInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctInfo.Location = new System.Drawing.Point(12, 9);
            this.lblAcctInfo.Name = "lblAcctInfo";
            this.lblAcctInfo.Size = new System.Drawing.Size(107, 14);
            this.lblAcctInfo.TabIndex = 0;
            this.lblAcctInfo.Text = "Account Information";
            // 
            // pnlItemData
            // 
            this.pnlItemData.Controls.Add(this.txtST);
            this.pnlItemData.Controls.Add(this.lblST);
            this.pnlItemData.Controls.Add(this.txtPrice);
            this.pnlItemData.Controls.Add(this.lbPrice);
            this.pnlItemData.Controls.Add(this.txtQty);
            this.pnlItemData.Controls.Add(this.lblQty);
            this.pnlItemData.Controls.Add(this.btnAddItem);
            this.pnlItemData.Controls.Add(this.txtDP);
            this.pnlItemData.Controls.Add(this.chkDP);
            this.pnlItemData.Controls.Add(this.cmbItem);
            this.pnlItemData.Controls.Add(this.cmbIType);
            this.pnlItemData.Controls.Add(this.lblItem);
            this.pnlItemData.Controls.Add(this.lblIType);
            this.pnlItemData.Controls.Add(this.lblItemInfo);
            this.pnlItemData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlItemData.Location = new System.Drawing.Point(0, 93);
            this.pnlItemData.Name = "pnlItemData";
            this.pnlItemData.Size = new System.Drawing.Size(684, 202);
            this.pnlItemData.TabIndex = 7;
            // 
            // txtST
            // 
            this.txtST.BackColor = System.Drawing.Color.White;
            this.txtST.Location = new System.Drawing.Point(130, 140);
            this.txtST.Name = "txtST";
            this.txtST.ReadOnly = true;
            this.txtST.Size = new System.Drawing.Size(96, 22);
            this.txtST.TabIndex = 14;
            this.txtST.Text = "0.00";
            this.txtST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblST
            // 
            this.lblST.AutoSize = true;
            this.lblST.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblST.Location = new System.Drawing.Point(32, 143);
            this.lblST.Name = "lblST";
            this.lblST.Size = new System.Drawing.Size(52, 14);
            this.lblST.TabIndex = 13;
            this.lblST.Text = "Sub Total";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(130, 115);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(96, 22);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.Text = "0.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(32, 118);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 14);
            this.lbPrice.TabIndex = 11;
            this.lbPrice.Text = "Price";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(130, 90);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(50, 22);
            this.txtQty.TabIndex = 10;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(32, 93);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(50, 14);
            this.lblQty.TabIndex = 9;
            this.lblQty.Text = "Quantity";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(130, 168);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 25);
            this.btnAddItem.TabIndex = 8;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtDP
            // 
            this.txtDP.BackColor = System.Drawing.Color.White;
            this.txtDP.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDP.Location = new System.Drawing.Point(403, 112);
            this.txtDP.MaxLength = 12;
            this.txtDP.Name = "txtDP";
            this.txtDP.ReadOnly = true;
            this.txtDP.Size = new System.Drawing.Size(85, 26);
            this.txtDP.TabIndex = 7;
            this.txtDP.Text = "0.00";
            this.txtDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDP.Visible = false;
            // 
            // chkDP
            // 
            this.chkDP.AutoSize = true;
            this.chkDP.Location = new System.Drawing.Point(259, 117);
            this.chkDP.Name = "chkDP";
            this.chkDP.Size = new System.Drawing.Size(138, 18);
            this.chkDP.TabIndex = 6;
            this.chkDP.Text = "Require Deposit of P";
            this.chkDP.UseVisualStyleBackColor = true;
            this.chkDP.Visible = false;
            // 
            // cmbItem
            // 
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(130, 65);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(386, 22);
            this.cmbItem.TabIndex = 5;
            this.cmbItem.SelectedValueChanged += new System.EventHandler(this.cmbItem_SelectedValueChanged);
            // 
            // cmbIType
            // 
            this.cmbIType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIType.FormattingEnabled = true;
            this.cmbIType.Location = new System.Drawing.Point(130, 40);
            this.cmbIType.Name = "cmbIType";
            this.cmbIType.Size = new System.Drawing.Size(386, 22);
            this.cmbIType.TabIndex = 4;
            this.cmbIType.SelectedValueChanged += new System.EventHandler(this.cmbIType_SelectedValueChanged);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(32, 68);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(30, 14);
            this.lblItem.TabIndex = 3;
            this.lblItem.Text = "Item";
            // 
            // lblIType
            // 
            this.lblIType.AutoSize = true;
            this.lblIType.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIType.Location = new System.Drawing.Point(32, 43);
            this.lblIType.Name = "lblIType";
            this.lblIType.Size = new System.Drawing.Size(57, 14);
            this.lblIType.TabIndex = 2;
            this.lblIType.Text = "Item Type";
            // 
            // lblItemInfo
            // 
            this.lblItemInfo.AutoSize = true;
            this.lblItemInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemInfo.Location = new System.Drawing.Point(13, 14);
            this.lblItemInfo.Name = "lblItemInfo";
            this.lblItemInfo.Size = new System.Drawing.Size(91, 14);
            this.lblItemInfo.TabIndex = 1;
            this.lblItemInfo.Text = "Item Information";
            // 
            // pnlRIList
            // 
            this.pnlRIList.Controls.Add(this.dgvRIList);
            this.pnlRIList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRIList.Location = new System.Drawing.Point(0, 295);
            this.pnlRIList.Name = "pnlRIList";
            this.pnlRIList.Size = new System.Drawing.Size(684, 366);
            this.pnlRIList.TabIndex = 8;
            // 
            // dgvRIList
            // 
            this.dgvRIList.AllowUserToAddRows = false;
            this.dgvRIList.AllowUserToDeleteRows = false;
            this.dgvRIList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRIList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRIList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDelete,
            this.colId,
            this.colTypeId,
            this.colItemId,
            this.colIDesc,
            this.colIQty,
            this.colSubTotal});
            this.dgvRIList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRIList.Location = new System.Drawing.Point(0, 0);
            this.dgvRIList.Name = "dgvRIList";
            this.dgvRIList.ReadOnly = true;
            this.dgvRIList.Size = new System.Drawing.Size(684, 366);
            this.dgvRIList.TabIndex = 0;
            this.dgvRIList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRIList_CellContentClick);
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.MinimumWidth = 70;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "Remove";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 70;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 50;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colId.Visible = false;
            // 
            // colTypeId
            // 
            this.colTypeId.DataPropertyName = "itemtype";
            this.colTypeId.HeaderText = "Item Type";
            this.colTypeId.MinimumWidth = 50;
            this.colTypeId.Name = "colTypeId";
            this.colTypeId.ReadOnly = true;
            this.colTypeId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTypeId.Visible = false;
            // 
            // colItemId
            // 
            this.colItemId.HeaderText = "Item Id";
            this.colItemId.MinimumWidth = 50;
            this.colItemId.Name = "colItemId";
            this.colItemId.ReadOnly = true;
            this.colItemId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colItemId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colItemId.Visible = false;
            // 
            // colIDesc
            // 
            this.colIDesc.DataPropertyName = "itemdesc";
            this.colIDesc.HeaderText = "Item Description";
            this.colIDesc.MinimumWidth = 350;
            this.colIDesc.Name = "colIDesc";
            this.colIDesc.ReadOnly = true;
            this.colIDesc.Width = 350;
            // 
            // colIQty
            // 
            this.colIQty.DataPropertyName = "itemqty";
            this.colIQty.HeaderText = "Quantity";
            this.colIQty.MinimumWidth = 60;
            this.colIQty.Name = "colIQty";
            this.colIQty.ReadOnly = true;
            this.colIQty.Width = 77;
            // 
            // colSubTotal
            // 
            this.colSubTotal.DataPropertyName = "itemamt";
            this.colSubTotal.HeaderText = "Sub Total";
            this.colSubTotal.MinimumWidth = 100;
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            // 
            // pnlItemTotals
            // 
            this.pnlItemTotals.Controls.Add(this.btnProcessRI);
            this.pnlItemTotals.Controls.Add(this.txtTotalValue);
            this.pnlItemTotals.Controls.Add(this.lblTotalValue);
            this.pnlItemTotals.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlItemTotals.Location = new System.Drawing.Point(0, 569);
            this.pnlItemTotals.Name = "pnlItemTotals";
            this.pnlItemTotals.Size = new System.Drawing.Size(684, 92);
            this.pnlItemTotals.TabIndex = 9;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(12, 11);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(251, 23);
            this.lblTotalValue.TabIndex = 14;
            this.lblTotalValue.Text = "Total Value of Items Purchased";
            // 
            // txtTotalValue
            // 
            this.txtTotalValue.BackColor = System.Drawing.Color.White;
            this.txtTotalValue.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalValue.Location = new System.Drawing.Point(449, 8);
            this.txtTotalValue.MaxLength = 12;
            this.txtTotalValue.Name = "txtTotalValue";
            this.txtTotalValue.ReadOnly = true;
            this.txtTotalValue.Size = new System.Drawing.Size(205, 31);
            this.txtTotalValue.TabIndex = 15;
            this.txtTotalValue.Text = "0.00";
            this.txtTotalValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnProcessRI
            // 
            this.btnProcessRI.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessRI.Location = new System.Drawing.Point(449, 49);
            this.btnProcessRI.Name = "btnProcessRI";
            this.btnProcessRI.Size = new System.Drawing.Size(205, 37);
            this.btnProcessRI.TabIndex = 16;
            this.btnProcessRI.Text = "Process for Payment";
            this.btnProcessRI.UseVisualStyleBackColor = true;
            this.btnProcessRI.Click += new System.EventHandler(this.btnProcessRI_Click);
            // 
            // frmBRequestItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.pnlItemTotals);
            this.Controls.Add(this.pnlRIList);
            this.Controls.Add(this.pnlItemData);
            this.Controls.Add(this.pnlAcctInfo);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBRequestItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Rquests";
            this.Load += new System.EventHandler(this.frmBRequestItems_Load);
            this.pnlAcctInfo.ResumeLayout(false);
            this.pnlAcctInfo.PerformLayout();
            this.pnlItemData.ResumeLayout(false);
            this.pnlItemData.PerformLayout();
            this.pnlRIList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRIList)).EndInit();
            this.pnlItemTotals.ResumeLayout(false);
            this.pnlItemTotals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAcctInfo;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblAcctInfo;
        private System.Windows.Forms.Panel pnlItemData;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.ComboBox cmbIType;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblIType;
        private System.Windows.Forms.Label lblItemInfo;
        private System.Windows.Forms.TextBox txtDP;
        private System.Windows.Forms.CheckBox chkDP;
        private System.Windows.Forms.TextBox txtST;
        private System.Windows.Forms.Label lblST;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Panel pnlRIList;
        private System.Windows.Forms.DataGridView dgvRIList;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.Panel pnlItemTotals;
        private System.Windows.Forms.TextBox txtTotalValue;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Button btnProcessRI;
    }
}