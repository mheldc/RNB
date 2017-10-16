namespace CAReserveSystem
{
    partial class frmBookingGuestLookup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookingGuestLookup));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbFind = new System.Windows.Forms.ToolStripButton();
            this.tstFind = new System.Windows.Forms.ToolStripTextBox();
            this.tslFind = new System.Windows.Forms.ToolStripLabel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.dgvGuest = new System.Windows.Forms.DataGridView();
            this.colGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMenu.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFind,
            this.tstFind,
            this.tslFind});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(491, 39);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
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
            this.tsbFind.Text = "toolStripButton1";
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
            this.tslFind.Size = new System.Drawing.Size(42, 36);
            this.tslFind.Text = "Search";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.dgvGuest);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 39);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(491, 489);
            this.pnlContainer.TabIndex = 1;
            // 
            // dgvGuest
            // 
            this.dgvGuest.AllowUserToAddRows = false;
            this.dgvGuest.AllowUserToDeleteRows = false;
            this.dgvGuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGID,
            this.colSelect,
            this.colGName});
            this.dgvGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGuest.Location = new System.Drawing.Point(0, 0);
            this.dgvGuest.Name = "dgvGuest";
            this.dgvGuest.ReadOnly = true;
            this.dgvGuest.Size = new System.Drawing.Size(489, 487);
            this.dgvGuest.TabIndex = 0;
            this.dgvGuest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuest_CellContentClick);
            this.dgvGuest.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvdgvGuest_DataBindingComplete);
            // 
            // colGID
            // 
            this.colGID.DataPropertyName = "id";
            this.colGID.HeaderText = "Id";
            this.colGID.Name = "colGID";
            this.colGID.ReadOnly = true;
            this.colGID.Visible = false;
            this.colGID.Width = 43;
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "";
            this.colSelect.MinimumWidth = 50;
            this.colSelect.Name = "colSelect";
            this.colSelect.ReadOnly = true;
            this.colSelect.Text = "Select";
            this.colSelect.UseColumnTextForButtonValue = true;
            this.colSelect.Width = 50;
            // 
            // colGName
            // 
            this.colGName.DataPropertyName = "guestname";
            this.colGName.HeaderText = "Name";
            this.colGName.MinimumWidth = 350;
            this.colGName.Name = "colGName";
            this.colGName.ReadOnly = true;
            this.colGName.Width = 350;
            // 
            // frmBookingGuestLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 528);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.tsMenu);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookingGuestLookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest Information Lookup";
            this.Load += new System.EventHandler(this.frmBookingGuestLookup_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbFind;
        private System.Windows.Forms.ToolStripTextBox tstFind;
        private System.Windows.Forms.ToolStripLabel tslFind;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.DataGridView dgvGuest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGID;
        private System.Windows.Forms.DataGridViewButtonColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGName;
    }
}