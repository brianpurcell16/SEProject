namespace RequirmentsEngineering
{
    partial class CloseMembership
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
            this.CreateMemberMenu = new System.Windows.Forms.MenuStrip();
            this.mnuBackClose = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCloseHeader = new System.Windows.Forms.Label();
            this.RemoveGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.txtSurnameClose = new System.Windows.Forms.TextBox();
            this.lblSurnameClose = new System.Windows.Forms.Label();
            this.txtForenameClose = new System.Windows.Forms.TextBox();
            this.txtPhoneNumberClose = new System.Windows.Forms.TextBox();
            this.txtEmailClose = new System.Windows.Forms.TextBox();
            this.lblPhoneClose = new System.Windows.Forms.Label();
            this.lblForenameClose = new System.Windows.Forms.Label();
            this.lblEmailClose = new System.Windows.Forms.Label();
            this.lblMemIDClose = new System.Windows.Forms.Label();
            this.txtMemIDClose = new System.Windows.Forms.TextBox();
            this.dgvClose = new System.Windows.Forms.DataGridView();
            this.btnGetClose = new System.Windows.Forms.Button();
            this.CreateMemberMenu.SuspendLayout();
            this.RemoveGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClose)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateMemberMenu
            // 
            this.CreateMemberMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CreateMemberMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackClose});
            this.CreateMemberMenu.Location = new System.Drawing.Point(0, 0);
            this.CreateMemberMenu.Name = "CreateMemberMenu";
            this.CreateMemberMenu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.CreateMemberMenu.Size = new System.Drawing.Size(845, 24);
            this.CreateMemberMenu.TabIndex = 2;
            this.CreateMemberMenu.Text = "CreateMenu";
            // 
            // mnuBackClose
            // 
            this.mnuBackClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBackClose.Name = "mnuBackClose";
            this.mnuBackClose.Size = new System.Drawing.Size(44, 22);
            this.mnuBackClose.Text = "Back";
            this.mnuBackClose.Click += new System.EventHandler(this.mnuBackClose_Click);
            // 
            // lblCloseHeader
            // 
            this.lblCloseHeader.AutoSize = true;
            this.lblCloseHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseHeader.Location = new System.Drawing.Point(291, 29);
            this.lblCloseHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCloseHeader.Name = "lblCloseHeader";
            this.lblCloseHeader.Size = new System.Drawing.Size(191, 25);
            this.lblCloseHeader.TabIndex = 3;
            this.lblCloseHeader.Text = "Close Membership";
            // 
            // RemoveGroupBox
            // 
            this.RemoveGroupBox.Controls.Add(this.button1);
            this.RemoveGroupBox.Controls.Add(this.btnRemoveMember);
            this.RemoveGroupBox.Controls.Add(this.txtSurnameClose);
            this.RemoveGroupBox.Controls.Add(this.lblSurnameClose);
            this.RemoveGroupBox.Controls.Add(this.txtForenameClose);
            this.RemoveGroupBox.Controls.Add(this.txtPhoneNumberClose);
            this.RemoveGroupBox.Controls.Add(this.txtEmailClose);
            this.RemoveGroupBox.Controls.Add(this.lblPhoneClose);
            this.RemoveGroupBox.Controls.Add(this.lblForenameClose);
            this.RemoveGroupBox.Controls.Add(this.lblEmailClose);
            this.RemoveGroupBox.Location = new System.Drawing.Point(114, 238);
            this.RemoveGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveGroupBox.Name = "RemoveGroupBox";
            this.RemoveGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.RemoveGroupBox.Size = new System.Drawing.Size(583, 266);
            this.RemoveGroupBox.TabIndex = 7;
            this.RemoveGroupBox.TabStop = false;
            this.RemoveGroupBox.Text = "Member Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, -22);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 18);
            this.button1.TabIndex = 19;
            this.button1.Text = "Remove Member";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Location = new System.Drawing.Point(186, 182);
            this.btnRemoveMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(152, 32);
            this.btnRemoveMember.TabIndex = 18;
            this.btnRemoveMember.Text = "Remove Member";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // txtSurnameClose
            // 
            this.txtSurnameClose.Location = new System.Drawing.Point(202, 68);
            this.txtSurnameClose.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurnameClose.MaxLength = 35;
            this.txtSurnameClose.Name = "txtSurnameClose";
            this.txtSurnameClose.Size = new System.Drawing.Size(128, 20);
            this.txtSurnameClose.TabIndex = 14;
            this.txtSurnameClose.Text = " ";
            // 
            // lblSurnameClose
            // 
            this.lblSurnameClose.AutoSize = true;
            this.lblSurnameClose.Location = new System.Drawing.Point(49, 68);
            this.lblSurnameClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurnameClose.Name = "lblSurnameClose";
            this.lblSurnameClose.Size = new System.Drawing.Size(52, 13);
            this.lblSurnameClose.TabIndex = 13;
            this.lblSurnameClose.Text = "Surname:";
            // 
            // txtForenameClose
            // 
            this.txtForenameClose.Location = new System.Drawing.Point(202, 40);
            this.txtForenameClose.Margin = new System.Windows.Forms.Padding(2);
            this.txtForenameClose.MaxLength = 35;
            this.txtForenameClose.Name = "txtForenameClose";
            this.txtForenameClose.Size = new System.Drawing.Size(128, 20);
            this.txtForenameClose.TabIndex = 12;
            this.txtForenameClose.Text = " ";
            // 
            // txtPhoneNumberClose
            // 
            this.txtPhoneNumberClose.Location = new System.Drawing.Point(202, 119);
            this.txtPhoneNumberClose.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNumberClose.MaxLength = 10;
            this.txtPhoneNumberClose.Name = "txtPhoneNumberClose";
            this.txtPhoneNumberClose.Size = new System.Drawing.Size(128, 20);
            this.txtPhoneNumberClose.TabIndex = 9;
            // 
            // txtEmailClose
            // 
            this.txtEmailClose.Location = new System.Drawing.Point(202, 94);
            this.txtEmailClose.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailClose.MaxLength = 50;
            this.txtEmailClose.Name = "txtEmailClose";
            this.txtEmailClose.Size = new System.Drawing.Size(128, 20);
            this.txtEmailClose.TabIndex = 8;
            // 
            // lblPhoneClose
            // 
            this.lblPhoneClose.AutoSize = true;
            this.lblPhoneClose.Location = new System.Drawing.Point(49, 119);
            this.lblPhoneClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneClose.Name = "lblPhoneClose";
            this.lblPhoneClose.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneClose.TabIndex = 7;
            this.lblPhoneClose.Text = "Phone Number:";
            // 
            // lblForenameClose
            // 
            this.lblForenameClose.AutoSize = true;
            this.lblForenameClose.Location = new System.Drawing.Point(49, 40);
            this.lblForenameClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForenameClose.Name = "lblForenameClose";
            this.lblForenameClose.Size = new System.Drawing.Size(57, 13);
            this.lblForenameClose.TabIndex = 5;
            this.lblForenameClose.Text = "Forename:";
            // 
            // lblEmailClose
            // 
            this.lblEmailClose.AutoSize = true;
            this.lblEmailClose.Location = new System.Drawing.Point(49, 96);
            this.lblEmailClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailClose.Name = "lblEmailClose";
            this.lblEmailClose.Size = new System.Drawing.Size(35, 13);
            this.lblEmailClose.TabIndex = 3;
            this.lblEmailClose.Text = "Email:";
            // 
            // lblMemIDClose
            // 
            this.lblMemIDClose.AutoSize = true;
            this.lblMemIDClose.Location = new System.Drawing.Point(256, 182);
            this.lblMemIDClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemIDClose.Name = "lblMemIDClose";
            this.lblMemIDClose.Size = new System.Drawing.Size(72, 13);
            this.lblMemIDClose.TabIndex = 21;
            this.lblMemIDClose.Text = "Enter MemID:";
            // 
            // txtMemIDClose
            // 
            this.txtMemIDClose.Location = new System.Drawing.Point(342, 179);
            this.txtMemIDClose.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemIDClose.MaxLength = 3;
            this.txtMemIDClose.Name = "txtMemIDClose";
            this.txtMemIDClose.Size = new System.Drawing.Size(88, 20);
            this.txtMemIDClose.TabIndex = 21;
            this.txtMemIDClose.Text = " ";
            // 
            // dgvClose
            // 
            this.dgvClose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClose.Location = new System.Drawing.Point(72, 57);
            this.dgvClose.Name = "dgvClose";
            this.dgvClose.Size = new System.Drawing.Size(650, 112);
            this.dgvClose.TabIndex = 22;
            // 
            // btnGetClose
            // 
            this.btnGetClose.Location = new System.Drawing.Point(316, 207);
            this.btnGetClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetClose.Name = "btnGetClose";
            this.btnGetClose.Size = new System.Drawing.Size(136, 27);
            this.btnGetClose.TabIndex = 20;
            this.btnGetClose.Text = "Get Details";
            this.btnGetClose.UseVisualStyleBackColor = true;
            this.btnGetClose.Click += new System.EventHandler(this.btnGetClose_Click);
            // 
            // CloseMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 506);
            this.Controls.Add(this.btnGetClose);
            this.Controls.Add(this.dgvClose);
            this.Controls.Add(this.txtMemIDClose);
            this.Controls.Add(this.lblMemIDClose);
            this.Controls.Add(this.RemoveGroupBox);
            this.Controls.Add(this.lblCloseHeader);
            this.Controls.Add(this.CreateMemberMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CloseMembership";
            this.Text = "Members-RemoveMember";
            this.Load += new System.EventHandler(this.CloseMembership_Load_1);
            this.CreateMemberMenu.ResumeLayout(false);
            this.CreateMemberMenu.PerformLayout();
            this.RemoveGroupBox.ResumeLayout(false);
            this.RemoveGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip CreateMemberMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuBackClose;
        private System.Windows.Forms.Label lblCloseHeader;
        private System.Windows.Forms.GroupBox RemoveGroupBox;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.TextBox txtSurnameClose;
        private System.Windows.Forms.Label lblSurnameClose;
        private System.Windows.Forms.TextBox txtForenameClose;
        private System.Windows.Forms.TextBox txtPhoneNumberClose;
        private System.Windows.Forms.TextBox txtEmailClose;
        private System.Windows.Forms.Label lblPhoneClose;
        private System.Windows.Forms.Label lblForenameClose;
        private System.Windows.Forms.Label lblEmailClose;
        private System.Windows.Forms.Label lblMemIDClose;
        private System.Windows.Forms.TextBox txtMemIDClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvClose;
        private System.Windows.Forms.Button btnGetClose;
    }
}