namespace RequirmentsEngineering
{
    partial class Yearly
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
            this.mnuYearly = new System.Windows.Forms.MenuStrip();
            this.backYearly = new System.Windows.Forms.ToolStripMenuItem();
            this.lblYearlyHeader = new System.Windows.Forms.Label();
            this.lblYearlyYear = new System.Windows.Forms.Label();
            this.cbmYear = new System.Windows.Forms.ComboBox();
            this.dgvyearly = new System.Windows.Forms.DataGridView();
            this.btnyear = new System.Windows.Forms.Button();
            this.mnuYearly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvyearly)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuYearly
            // 
            this.mnuYearly.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuYearly.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backYearly});
            this.mnuYearly.Location = new System.Drawing.Point(0, 0);
            this.mnuYearly.Name = "mnuYearly";
            this.mnuYearly.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.mnuYearly.Size = new System.Drawing.Size(1043, 26);
            this.mnuYearly.TabIndex = 0;
            this.mnuYearly.Text = "menuStrip1";
            // 
            // backYearly
            // 
            this.backYearly.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backYearly.Name = "backYearly";
            this.backYearly.Size = new System.Drawing.Size(54, 24);
            this.backYearly.Text = "Back";
            this.backYearly.Click += new System.EventHandler(this.backYearly_Click);
            // 
            // lblYearlyHeader
            // 
            this.lblYearlyHeader.AutoSize = true;
            this.lblYearlyHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearlyHeader.Location = new System.Drawing.Point(343, 28);
            this.lblYearlyHeader.Name = "lblYearlyHeader";
            this.lblYearlyHeader.Size = new System.Drawing.Size(316, 31);
            this.lblYearlyHeader.TabIndex = 19;
            this.lblYearlyHeader.Text = "Yearly Revenue Analysis";
            this.lblYearlyHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblYearlyYear
            // 
            this.lblYearlyYear.AutoSize = true;
            this.lblYearlyYear.Location = new System.Drawing.Point(347, 86);
            this.lblYearlyYear.Name = "lblYearlyYear";
            this.lblYearlyYear.Size = new System.Drawing.Size(73, 16);
            this.lblYearlyYear.TabIndex = 20;
            this.lblYearlyYear.Text = "Enter Year:";
            // 
            // cbmYear
            // 
            this.cbmYear.FormattingEnabled = true;
            this.cbmYear.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cbmYear.Location = new System.Drawing.Point(435, 83);
            this.cbmYear.Name = "cbmYear";
            this.cbmYear.Size = new System.Drawing.Size(121, 24);
            this.cbmYear.TabIndex = 24;
            // 
            // dgvyearly
            // 
            this.dgvyearly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvyearly.Location = new System.Drawing.Point(294, 202);
            this.dgvyearly.Name = "dgvyearly";
            this.dgvyearly.RowHeadersWidth = 51;
            this.dgvyearly.RowTemplate.Height = 24;
            this.dgvyearly.Size = new System.Drawing.Size(394, 258);
            this.dgvyearly.TabIndex = 25;
            // 
            // btnyear
            // 
            this.btnyear.Location = new System.Drawing.Point(435, 123);
            this.btnyear.Name = "btnyear";
            this.btnyear.Size = new System.Drawing.Size(121, 28);
            this.btnyear.TabIndex = 26;
            this.btnyear.Text = "Generate";
            this.btnyear.UseVisualStyleBackColor = true;
            this.btnyear.Click += new System.EventHandler(this.btnyear_Click);
            // 
            // Yearly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 534);
            this.Controls.Add(this.btnyear);
            this.Controls.Add(this.dgvyearly);
            this.Controls.Add(this.cbmYear);
            this.Controls.Add(this.lblYearlyYear);
            this.Controls.Add(this.lblYearlyHeader);
            this.Controls.Add(this.mnuYearly);
            this.MainMenuStrip = this.mnuYearly;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Yearly";
            this.Text = "Yearly";
            this.Load += new System.EventHandler(this.Yearly_Load);
            this.mnuYearly.ResumeLayout(false);
            this.mnuYearly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvyearly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuYearly;
        private System.Windows.Forms.ToolStripMenuItem backYearly;
        private System.Windows.Forms.Label lblYearlyHeader;
        private System.Windows.Forms.Label lblYearlyYear;
        private System.Windows.Forms.ComboBox cbmYear;
        private System.Windows.Forms.DataGridView dgvyearly;
        private System.Windows.Forms.Button btnyear;
    }
}