namespace RequirmentsEngineering
{
    partial class UpdateMember
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
            this.mnuUpdateBack = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateGroupBox = new System.Windows.Forms.GroupBox();
            this.txtFornameUpdate2 = new System.Windows.Forms.TextBox();
            this.txtSurnameUpdate2 = new System.Windows.Forms.TextBox();
            this.lblupdateforename2 = new System.Windows.Forms.Label();
            this.lblUpdateSurname2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPhoneUpdate = new System.Windows.Forms.TextBox();
            this.txtEmailUpdate = new System.Windows.Forms.TextBox();
            this.lblPhoneUpdate = new System.Windows.Forms.Label();
            this.lblEmailUpdate = new System.Windows.Forms.Label();
            this.lblUpdateHeader = new System.Windows.Forms.Label();
            this.lblupdateforename = new System.Windows.Forms.Label();
            this.txtForenameUpdate = new System.Windows.Forms.TextBox();
            this.lblupdatesurname = new System.Windows.Forms.Label();
            this.txtSurnameUpdate = new System.Windows.Forms.TextBox();
            this.srchbtn = new System.Windows.Forms.Button();
            this.CreateMemberMenu.SuspendLayout();
            this.UpdateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateMemberMenu
            // 
            this.CreateMemberMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CreateMemberMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdateBack});
            this.CreateMemberMenu.Location = new System.Drawing.Point(0, 0);
            this.CreateMemberMenu.Name = "CreateMemberMenu";
            this.CreateMemberMenu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.CreateMemberMenu.Size = new System.Drawing.Size(678, 24);
            this.CreateMemberMenu.TabIndex = 1;
            this.CreateMemberMenu.Text = "CreateMenu";
            // 
            // mnuUpdateBack
            // 
            this.mnuUpdateBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuUpdateBack.Name = "mnuUpdateBack";
            this.mnuUpdateBack.Size = new System.Drawing.Size(44, 22);
            this.mnuUpdateBack.Text = "Back";
            this.mnuUpdateBack.Click += new System.EventHandler(this.mnuUpdateBack_Click);
            // 
            // UpdateGroupBox
            // 
            this.UpdateGroupBox.Controls.Add(this.txtFornameUpdate2);
            this.UpdateGroupBox.Controls.Add(this.txtSurnameUpdate2);
            this.UpdateGroupBox.Controls.Add(this.lblupdateforename2);
            this.UpdateGroupBox.Controls.Add(this.lblUpdateSurname2);
            this.UpdateGroupBox.Controls.Add(this.btnUpdate);
            this.UpdateGroupBox.Controls.Add(this.txtPhoneUpdate);
            this.UpdateGroupBox.Controls.Add(this.txtEmailUpdate);
            this.UpdateGroupBox.Controls.Add(this.lblPhoneUpdate);
            this.UpdateGroupBox.Controls.Add(this.lblEmailUpdate);
            this.UpdateGroupBox.Location = new System.Drawing.Point(45, 146);
            this.UpdateGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateGroupBox.Name = "UpdateGroupBox";
            this.UpdateGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.UpdateGroupBox.Size = new System.Drawing.Size(583, 266);
            this.UpdateGroupBox.TabIndex = 6;
            this.UpdateGroupBox.TabStop = false;
            this.UpdateGroupBox.Text = "Your Details";
            // 
            // txtFornameUpdate2
            // 
            this.txtFornameUpdate2.Location = new System.Drawing.Point(196, 75);
            this.txtFornameUpdate2.Margin = new System.Windows.Forms.Padding(2);
            this.txtFornameUpdate2.MaxLength = 35;
            this.txtFornameUpdate2.Name = "txtFornameUpdate2";
            this.txtFornameUpdate2.Size = new System.Drawing.Size(128, 20);
            this.txtFornameUpdate2.TabIndex = 22;
            // 
            // txtSurnameUpdate2
            // 
            this.txtSurnameUpdate2.Location = new System.Drawing.Point(196, 101);
            this.txtSurnameUpdate2.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurnameUpdate2.MaxLength = 35;
            this.txtSurnameUpdate2.Name = "txtSurnameUpdate2";
            this.txtSurnameUpdate2.Size = new System.Drawing.Size(128, 20);
            this.txtSurnameUpdate2.TabIndex = 21;
            // 
            // lblupdateforename2
            // 
            this.lblupdateforename2.AutoSize = true;
            this.lblupdateforename2.Location = new System.Drawing.Point(49, 75);
            this.lblupdateforename2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblupdateforename2.Name = "lblupdateforename2";
            this.lblupdateforename2.Size = new System.Drawing.Size(85, 13);
            this.lblupdateforename2.TabIndex = 20;
            this.lblupdateforename2.Text = "Enter Forename:";
            // 
            // lblUpdateSurname2
            // 
            this.lblUpdateSurname2.AutoSize = true;
            this.lblUpdateSurname2.Location = new System.Drawing.Point(49, 101);
            this.lblUpdateSurname2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateSurname2.Name = "lblUpdateSurname2";
            this.lblUpdateSurname2.Size = new System.Drawing.Size(80, 13);
            this.lblUpdateSurname2.TabIndex = 19;
            this.lblUpdateSurname2.Text = "Enter Surname:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(196, 230);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 32);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPhoneUpdate
            // 
            this.txtPhoneUpdate.Location = new System.Drawing.Point(196, 161);
            this.txtPhoneUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneUpdate.MaxLength = 10;
            this.txtPhoneUpdate.Name = "txtPhoneUpdate";
            this.txtPhoneUpdate.Size = new System.Drawing.Size(128, 20);
            this.txtPhoneUpdate.TabIndex = 9;
            // 
            // txtEmailUpdate
            // 
            this.txtEmailUpdate.Location = new System.Drawing.Point(196, 130);
            this.txtEmailUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailUpdate.MaxLength = 50;
            this.txtEmailUpdate.Name = "txtEmailUpdate";
            this.txtEmailUpdate.Size = new System.Drawing.Size(173, 20);
            this.txtEmailUpdate.TabIndex = 8;
            // 
            // lblPhoneUpdate
            // 
            this.lblPhoneUpdate.AutoSize = true;
            this.lblPhoneUpdate.Location = new System.Drawing.Point(49, 163);
            this.lblPhoneUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneUpdate.Name = "lblPhoneUpdate";
            this.lblPhoneUpdate.Size = new System.Drawing.Size(109, 13);
            this.lblPhoneUpdate.TabIndex = 7;
            this.lblPhoneUpdate.Text = "Enter Phone Number:";
            // 
            // lblEmailUpdate
            // 
            this.lblEmailUpdate.AutoSize = true;
            this.lblEmailUpdate.Location = new System.Drawing.Point(49, 130);
            this.lblEmailUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailUpdate.Name = "lblEmailUpdate";
            this.lblEmailUpdate.Size = new System.Drawing.Size(63, 13);
            this.lblEmailUpdate.TabIndex = 3;
            this.lblEmailUpdate.Text = "Enter Email:";
            // 
            // lblUpdateHeader
            // 
            this.lblUpdateHeader.AutoSize = true;
            this.lblUpdateHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateHeader.Location = new System.Drawing.Point(227, 24);
            this.lblUpdateHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateHeader.Name = "lblUpdateHeader";
            this.lblUpdateHeader.Size = new System.Drawing.Size(165, 25);
            this.lblUpdateHeader.TabIndex = 7;
            this.lblUpdateHeader.Text = "Update Member";
            // 
            // lblupdateforename
            // 
            this.lblupdateforename.AutoSize = true;
            this.lblupdateforename.Location = new System.Drawing.Point(163, 61);
            this.lblupdateforename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblupdateforename.Name = "lblupdateforename";
            this.lblupdateforename.Size = new System.Drawing.Size(85, 13);
            this.lblupdateforename.TabIndex = 23;
            this.lblupdateforename.Text = "Enter Forename:";
            // 
            // txtForenameUpdate
            // 
            this.txtForenameUpdate.Location = new System.Drawing.Point(252, 61);
            this.txtForenameUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtForenameUpdate.MaxLength = 35;
            this.txtForenameUpdate.Name = "txtForenameUpdate";
            this.txtForenameUpdate.Size = new System.Drawing.Size(128, 20);
            this.txtForenameUpdate.TabIndex = 23;
            // 
            // lblupdatesurname
            // 
            this.lblupdatesurname.AutoSize = true;
            this.lblupdatesurname.Location = new System.Drawing.Point(163, 88);
            this.lblupdatesurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblupdatesurname.Name = "lblupdatesurname";
            this.lblupdatesurname.Size = new System.Drawing.Size(80, 13);
            this.lblupdatesurname.TabIndex = 23;
            this.lblupdatesurname.Text = "Enter Surname:";
            // 
            // txtSurnameUpdate
            // 
            this.txtSurnameUpdate.Location = new System.Drawing.Point(252, 85);
            this.txtSurnameUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurnameUpdate.MaxLength = 35;
            this.txtSurnameUpdate.Name = "txtSurnameUpdate";
            this.txtSurnameUpdate.Size = new System.Drawing.Size(128, 20);
            this.txtSurnameUpdate.TabIndex = 23;
            // 
            // srchbtn
            // 
            this.srchbtn.Location = new System.Drawing.Point(257, 109);
            this.srchbtn.Margin = new System.Windows.Forms.Padding(2);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(114, 26);
            this.srchbtn.TabIndex = 23;
            this.srchbtn.Text = "Search";
            this.srchbtn.UseVisualStyleBackColor = true;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // UpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 423);
            this.Controls.Add(this.srchbtn);
            this.Controls.Add(this.txtSurnameUpdate);
            this.Controls.Add(this.lblupdatesurname);
            this.Controls.Add(this.txtForenameUpdate);
            this.Controls.Add(this.lblupdateforename);
            this.Controls.Add(this.lblUpdateHeader);
            this.Controls.Add(this.UpdateGroupBox);
            this.Controls.Add(this.CreateMemberMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateMember";
            this.Text = "Members-UpdateMember";
            this.CreateMemberMenu.ResumeLayout(false);
            this.CreateMemberMenu.PerformLayout();
            this.UpdateGroupBox.ResumeLayout(false);
            this.UpdateGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip CreateMemberMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateBack;
        private System.Windows.Forms.GroupBox UpdateGroupBox;
        private System.Windows.Forms.Label lblEmailUpdate;
        private System.Windows.Forms.Label lblPhoneUpdate;
        private System.Windows.Forms.TextBox txtPhoneUpdate;
        private System.Windows.Forms.TextBox txtEmailUpdate;
        private System.Windows.Forms.Label lblUpdateHeader;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtFornameUpdate2;
        private System.Windows.Forms.TextBox txtSurnameUpdate2;
        private System.Windows.Forms.Label lblupdateforename2;
        private System.Windows.Forms.Label lblUpdateSurname2;
        private System.Windows.Forms.Label lblupdateforename;
        private System.Windows.Forms.TextBox txtForenameUpdate;
        private System.Windows.Forms.Label lblupdatesurname;
        private System.Windows.Forms.TextBox txtSurnameUpdate;
        private System.Windows.Forms.Button srchbtn;
    }
}