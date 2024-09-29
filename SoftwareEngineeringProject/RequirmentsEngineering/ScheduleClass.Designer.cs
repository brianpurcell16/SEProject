namespace RequirmentsEngineering
{
    partial class ScheduleClass
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
            this.mnuSchedule = new System.Windows.Forms.MenuStrip();
            this.mnuShecduleBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSchedule = new System.Windows.Forms.GroupBox();
            this.dtpSchedule = new System.Windows.Forms.DateTimePicker();
            this.txtCapacitySchedule = new System.Windows.Forms.TextBox();
            this.txtPriceSchedule = new System.Windows.Forms.TextBox();
            this.txtTitleSchedule = new System.Windows.Forms.TextBox();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.lblCapSchedule = new System.Windows.Forms.Label();
            this.lblPriceSchedule = new System.Windows.Forms.Label();
            this.lblTimeSchedule = new System.Windows.Forms.Label();
            this.lblDateSchedule = new System.Windows.Forms.Label();
            this.lblTitleSchedule = new System.Windows.Forms.Label();
            this.lblScheduleHeader = new System.Windows.Forms.Label();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.mnuSchedule.SuspendLayout();
            this.grpSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSchedule
            // 
            this.mnuSchedule.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuSchedule.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShecduleBack});
            this.mnuSchedule.Location = new System.Drawing.Point(0, 0);
            this.mnuSchedule.Name = "mnuSchedule";
            this.mnuSchedule.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.mnuSchedule.Size = new System.Drawing.Size(1097, 26);
            this.mnuSchedule.TabIndex = 29;
            this.mnuSchedule.Text = "CreateMenu";
            // 
            // mnuShecduleBack
            // 
            this.mnuShecduleBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuShecduleBack.Name = "mnuShecduleBack";
            this.mnuShecduleBack.Size = new System.Drawing.Size(54, 24);
            this.mnuShecduleBack.Text = "Back";
            this.mnuShecduleBack.Click += new System.EventHandler(this.mnuShecduleBack_Click);
            // 
            // grpSchedule
            // 
            this.grpSchedule.Controls.Add(this.cmbTime);
            this.grpSchedule.Controls.Add(this.dtpSchedule);
            this.grpSchedule.Controls.Add(this.txtCapacitySchedule);
            this.grpSchedule.Controls.Add(this.txtPriceSchedule);
            this.grpSchedule.Controls.Add(this.txtTitleSchedule);
            this.grpSchedule.Controls.Add(this.btnSchedule);
            this.grpSchedule.Controls.Add(this.lblCapSchedule);
            this.grpSchedule.Controls.Add(this.lblPriceSchedule);
            this.grpSchedule.Controls.Add(this.lblTimeSchedule);
            this.grpSchedule.Controls.Add(this.lblDateSchedule);
            this.grpSchedule.Controls.Add(this.lblTitleSchedule);
            this.grpSchedule.Location = new System.Drawing.Point(245, 121);
            this.grpSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSchedule.Name = "grpSchedule";
            this.grpSchedule.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSchedule.Size = new System.Drawing.Size(575, 246);
            this.grpSchedule.TabIndex = 30;
            this.grpSchedule.TabStop = false;
            this.grpSchedule.Text = "Class Details";
            // 
            // dtpSchedule
            // 
            this.dtpSchedule.Location = new System.Drawing.Point(179, 71);
            this.dtpSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpSchedule.Name = "dtpSchedule";
            this.dtpSchedule.Size = new System.Drawing.Size(179, 22);
            this.dtpSchedule.TabIndex = 25;
            // 
            // txtCapacitySchedule
            // 
            this.txtCapacitySchedule.Location = new System.Drawing.Point(179, 156);
            this.txtCapacitySchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCapacitySchedule.MaxLength = 2;
            this.txtCapacitySchedule.Name = "txtCapacitySchedule";
            this.txtCapacitySchedule.Size = new System.Drawing.Size(153, 22);
            this.txtCapacitySchedule.TabIndex = 24;
            // 
            // txtPriceSchedule
            // 
            this.txtPriceSchedule.Location = new System.Drawing.Point(179, 126);
            this.txtPriceSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPriceSchedule.MaxLength = 2;
            this.txtPriceSchedule.Name = "txtPriceSchedule";
            this.txtPriceSchedule.Size = new System.Drawing.Size(153, 22);
            this.txtPriceSchedule.TabIndex = 23;
            // 
            // txtTitleSchedule
            // 
            this.txtTitleSchedule.Location = new System.Drawing.Point(179, 41);
            this.txtTitleSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitleSchedule.MaxLength = 40;
            this.txtTitleSchedule.Name = "txtTitleSchedule";
            this.txtTitleSchedule.Size = new System.Drawing.Size(153, 22);
            this.txtTitleSchedule.TabIndex = 20;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(179, 202);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(203, 39);
            this.btnSchedule.TabIndex = 19;
            this.btnSchedule.Text = "Add Class";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // lblCapSchedule
            // 
            this.lblCapSchedule.AutoSize = true;
            this.lblCapSchedule.Location = new System.Drawing.Point(55, 156);
            this.lblCapSchedule.Name = "lblCapSchedule";
            this.lblCapSchedule.Size = new System.Drawing.Size(97, 16);
            this.lblCapSchedule.TabIndex = 4;
            this.lblCapSchedule.Text = "Enter Capacity:";
            // 
            // lblPriceSchedule
            // 
            this.lblPriceSchedule.AutoSize = true;
            this.lblPriceSchedule.Location = new System.Drawing.Point(55, 126);
            this.lblPriceSchedule.Name = "lblPriceSchedule";
            this.lblPriceSchedule.Size = new System.Drawing.Size(75, 16);
            this.lblPriceSchedule.TabIndex = 3;
            this.lblPriceSchedule.Text = "Enter Price:";
            // 
            // lblTimeSchedule
            // 
            this.lblTimeSchedule.AutoSize = true;
            this.lblTimeSchedule.Location = new System.Drawing.Point(55, 97);
            this.lblTimeSchedule.Name = "lblTimeSchedule";
            this.lblTimeSchedule.Size = new System.Drawing.Size(75, 16);
            this.lblTimeSchedule.TabIndex = 2;
            this.lblTimeSchedule.Text = "Enter Time:";
            // 
            // lblDateSchedule
            // 
            this.lblDateSchedule.AutoSize = true;
            this.lblDateSchedule.Location = new System.Drawing.Point(55, 69);
            this.lblDateSchedule.Name = "lblDateSchedule";
            this.lblDateSchedule.Size = new System.Drawing.Size(73, 16);
            this.lblDateSchedule.TabIndex = 1;
            this.lblDateSchedule.Text = "Enter Date:";
            // 
            // lblTitleSchedule
            // 
            this.lblTitleSchedule.AutoSize = true;
            this.lblTitleSchedule.Location = new System.Drawing.Point(55, 41);
            this.lblTitleSchedule.Name = "lblTitleSchedule";
            this.lblTitleSchedule.Size = new System.Drawing.Size(70, 16);
            this.lblTitleSchedule.TabIndex = 0;
            this.lblTitleSchedule.Text = "Enter Title:";
            // 
            // lblScheduleHeader
            // 
            this.lblScheduleHeader.AutoSize = true;
            this.lblScheduleHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleHeader.Location = new System.Drawing.Point(389, 28);
            this.lblScheduleHeader.Name = "lblScheduleHeader";
            this.lblScheduleHeader.Size = new System.Drawing.Size(287, 39);
            this.lblScheduleHeader.TabIndex = 31;
            this.lblScheduleHeader.Text = "Schedule A Class";
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.cmbTime.Location = new System.Drawing.Point(179, 98);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(153, 24);
            this.cmbTime.TabIndex = 26;
            // 
            // ScheduleClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 591);
            this.Controls.Add(this.lblScheduleHeader);
            this.Controls.Add(this.grpSchedule);
            this.Controls.Add(this.mnuSchedule);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ScheduleClass";
            this.Text = "Class-[ScheduleClass]";
            this.Load += new System.EventHandler(this.ScheduleClass_Load);
            this.mnuSchedule.ResumeLayout(false);
            this.mnuSchedule.PerformLayout();
            this.grpSchedule.ResumeLayout(false);
            this.grpSchedule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSchedule;
        private System.Windows.Forms.ToolStripMenuItem mnuShecduleBack;
        private System.Windows.Forms.GroupBox grpSchedule;
        private System.Windows.Forms.Label lblScheduleHeader;
        private System.Windows.Forms.Label lblCapSchedule;
        private System.Windows.Forms.Label lblPriceSchedule;
        private System.Windows.Forms.Label lblTimeSchedule;
        private System.Windows.Forms.Label lblDateSchedule;
        private System.Windows.Forms.Label lblTitleSchedule;
        private System.Windows.Forms.TextBox txtCapacitySchedule;
        private System.Windows.Forms.TextBox txtPriceSchedule;
        private System.Windows.Forms.TextBox txtTitleSchedule;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.DateTimePicker dtpSchedule;
        private System.Windows.Forms.ComboBox cmbTime;
    }
}