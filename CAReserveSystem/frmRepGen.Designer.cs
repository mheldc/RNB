namespace CAReserveSystem
{
    partial class frmRepGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepGen));
            this.lblRptGen = new System.Windows.Forms.Label();
            this.cmbRptGen = new System.Windows.Forms.ComboBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.dtpPStart = new System.Windows.Forms.DateTimePicker();
            this.lblPStart = new System.Windows.Forms.Label();
            this.lblPEnd = new System.Windows.Forms.Label();
            this.dtpPEnd = new System.Windows.Forms.DateTimePicker();
            this.btnPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRptGen
            // 
            this.lblRptGen.AutoSize = true;
            this.lblRptGen.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRptGen.Location = new System.Drawing.Point(12, 19);
            this.lblRptGen.Name = "lblRptGen";
            this.lblRptGen.Size = new System.Drawing.Size(102, 14);
            this.lblRptGen.TabIndex = 0;
            this.lblRptGen.Text = "Report to Generate";
            // 
            // cmbRptGen
            // 
            this.cmbRptGen.FormattingEnabled = true;
            this.cmbRptGen.Items.AddRange(new object[] {
            "- Select a report to generate -",
            "Sales Report per Cashier",
            "Sales Report per Items",
            "Sales Report per Accommodation",
            "Inventory Report"});
            this.cmbRptGen.Location = new System.Drawing.Point(133, 16);
            this.cmbRptGen.Name = "cmbRptGen";
            this.cmbRptGen.Size = new System.Drawing.Size(350, 22);
            this.cmbRptGen.TabIndex = 1;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(12, 47);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(74, 14);
            this.lblPeriod.TabIndex = 2;
            this.lblPeriod.Text = "Report Period";
            // 
            // dtpPStart
            // 
            this.dtpPStart.CustomFormat = "yyyy-MM-dd";
            this.dtpPStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPStart.Location = new System.Drawing.Point(171, 41);
            this.dtpPStart.Name = "dtpPStart";
            this.dtpPStart.Size = new System.Drawing.Size(144, 22);
            this.dtpPStart.TabIndex = 3;
            // 
            // lblPStart
            // 
            this.lblPStart.AutoSize = true;
            this.lblPStart.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPStart.Location = new System.Drawing.Point(130, 47);
            this.lblPStart.Name = "lblPStart";
            this.lblPStart.Size = new System.Drawing.Size(31, 14);
            this.lblPStart.TabIndex = 4;
            this.lblPStart.Text = "Start";
            // 
            // lblPEnd
            // 
            this.lblPEnd.AutoSize = true;
            this.lblPEnd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPEnd.Location = new System.Drawing.Point(130, 72);
            this.lblPEnd.Name = "lblPEnd";
            this.lblPEnd.Size = new System.Drawing.Size(25, 14);
            this.lblPEnd.TabIndex = 5;
            this.lblPEnd.Text = "End";
            // 
            // dtpPEnd
            // 
            this.dtpPEnd.CustomFormat = "yyyy-MM-dd";
            this.dtpPEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPEnd.Location = new System.Drawing.Point(171, 66);
            this.dtpPEnd.Name = "dtpPEnd";
            this.dtpPEnd.Size = new System.Drawing.Size(144, 22);
            this.dtpPEnd.TabIndex = 6;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(311, 115);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(172, 32);
            this.btnPreview.TabIndex = 7;
            this.btnPreview.Text = "Preview Report";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // frmRepGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 153);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.dtpPEnd);
            this.Controls.Add(this.lblPEnd);
            this.Controls.Add(this.lblPStart);
            this.Controls.Add(this.dtpPStart);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.cmbRptGen);
            this.Controls.Add(this.lblRptGen);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRepGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Generator";
            this.Load += new System.EventHandler(this.frmRepGen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRptGen;
        private System.Windows.Forms.ComboBox cmbRptGen;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.DateTimePicker dtpPStart;
        private System.Windows.Forms.Label lblPStart;
        private System.Windows.Forms.Label lblPEnd;
        private System.Windows.Forms.DateTimePicker dtpPEnd;
        private System.Windows.Forms.Button btnPreview;
    }
}