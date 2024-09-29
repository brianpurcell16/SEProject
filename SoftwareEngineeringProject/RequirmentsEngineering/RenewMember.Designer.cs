namespace RequirmentsEngineering
{
    partial class RenewMember
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
            this.txtRenewMemID = new System.Windows.Forms.TextBox();
            this.lblMemIDRenew = new System.Windows.Forms.Label();
            this.RenewGroupBox = new System.Windows.Forms.GroupBox();
            this.btnRenewMember = new System.Windows.Forms.Button();
            this.txtRenewSname = new System.Windows.Forms.TextBox();
            this.txtRenewFname = new System.Windows.Forms.TextBox();
            this.txtRenewPhone = new System.Windows.Forms.TextBox();
            this.txtRenewEmail = new System.Windows.Forms.TextBox();
            this.lblPhoneRenew = new System.Windows.Forms.Label();
            this.lblFnameRenew = new System.Windows.Forms.Label();
            this.lblSnameRenew = new System.Windows.Forms.Label();
            this.lblEmailRenew = new System.Windows.Forms.Label();
            this.lblRenewHeader = new System.Windows.Forms.Label();
            this.mnuBackRenew = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMemberMenu = new System.Windows.Forms.MenuStrip();
            this.dgvRenew = new System.Windows.Forms.DataGridView();
            this.btnRenewGetDetails = new System.Windows.Forms.Button();
            this.RenewGroupBox.SuspendLayout();
            this.CreateMemberMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenew)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRenewMemID
            // 
            this.txtRenewMemID.Location = new System.Drawing.Point(321, 181);
            this.txtRenewMemID.Margin = new System.Windows.Forms.Padding(2);
            this.txtRenewMemID.MaxLength = 3;
            this.txtRenewMemID.Name = "txtRenewMemID";
            this.txtRenewMemID.Size = new System.Drawing.Size(95, 20);
            this.txtRenewMemID.TabIndex = 26;
            // 
            // lblMemIDRenew
            // 
            this.lblMemIDRenew.AutoSize = true;
            this.lblMemIDRenew.Location = new System.Drawing.Point(231, 188);
            this.lblMemIDRenew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemIDRenew.Name = "lblMemIDRenew";
            this.lblMemIDRenew.Size = new System.Drawing.Size(72, 13);
            this.lblMemIDRenew.TabIndex = 24;
            this.lblMemIDRenew.Text = "Enter MemID:";
            // 
            // RenewGroupBox
            // 
            this.RenewGroupBox.Controls.Add(this.btnRenewMember);
            this.RenewGroupBox.Controls.Add(this.txtRenewSname);
            this.RenewGroupBox.Controls.Add(this.txtRenewFname);
            this.RenewGroupBox.Controls.Add(this.txtRenewPhone);
            this.RenewGroupBox.Controls.Add(this.txtRenewEmail);
            this.RenewGroupBox.Controls.Add(this.lblPhoneRenew);
            this.RenewGroupBox.Controls.Add(this.lblFnameRenew);
            this.RenewGroupBox.Controls.Add(this.lblSnameRenew);
            this.RenewGroupBox.Controls.Add(this.lblEmailRenew);
            this.RenewGroupBox.Location = new System.Drawing.Point(122, 232);
            this.RenewGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.RenewGroupBox.Name = "RenewGroupBox";
            this.RenewGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.RenewGroupBox.Size = new System.Drawing.Size(583, 266);
            this.RenewGroupBox.TabIndex = 23;
            this.RenewGroupBox.TabStop = false;
            this.RenewGroupBox.Text = "Member Details";
            // 
            // btnRenewMember
            // 
            this.btnRenewMember.Location = new System.Drawing.Point(166, 214);
            this.btnRenewMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenewMember.Name = "btnRenewMember";
            this.btnRenewMember.Size = new System.Drawing.Size(152, 32);
            this.btnRenewMember.TabIndex = 18;
            this.btnRenewMember.Text = "Renew Member";
            this.btnRenewMember.UseVisualStyleBackColor = true;
            this.btnRenewMember.Click += new System.EventHandler(this.btnRenewMember_Click);
            // 
            // txtRenewSname
            // 
            this.txtRenewSname.Location = new System.Drawing.Point(175, 94);
            this.txtRenewSname.Margin = new System.Windows.Forms.Padding(2);
            this.txtRenewSname.MaxLength = 10;
            this.txtRenewSname.Name = "txtRenewSname";
            this.txtRenewSname.Size = new System.Drawing.Size(128, 20);
            this.txtRenewSname.TabIndex = 11;
            // 
            // txtRenewFname
            // 
            this.txtRenewFname.Location = new System.Drawing.Point(175, 59);
            this.txtRenewFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtRenewFname.MaxLength = 50;
            this.txtRenewFname.Name = "txtRenewFname";
            this.txtRenewFname.Size = new System.Drawing.Size(128, 20);
            this.txtRenewFname.TabIndex = 10;
            // 
            // txtRenewPhone
            // 
            this.txtRenewPhone.Location = new System.Drawing.Point(175, 162);
            this.txtRenewPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtRenewPhone.MaxLength = 35;
            this.txtRenewPhone.Name = "txtRenewPhone";
            this.txtRenewPhone.Size = new System.Drawing.Size(128, 20);
            this.txtRenewPhone.TabIndex = 9;
            // 
            // txtRenewEmail
            // 
            this.txtRenewEmail.Location = new System.Drawing.Point(175, 127);
            this.txtRenewEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtRenewEmail.MaxLength = 35;
            this.txtRenewEmail.Name = "txtRenewEmail";
            this.txtRenewEmail.Size = new System.Drawing.Size(128, 20);
            this.txtRenewEmail.TabIndex = 8;
            // 
            // lblPhoneRenew
            // 
            this.lblPhoneRenew.AutoSize = true;
            this.lblPhoneRenew.Location = new System.Drawing.Point(49, 162);
            this.lblPhoneRenew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneRenew.Name = "lblPhoneRenew";
            this.lblPhoneRenew.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneRenew.TabIndex = 7;
            this.lblPhoneRenew.Text = "Phone Number:";
            // 
            // lblFnameRenew
            // 
            this.lblFnameRenew.AutoSize = true;
            this.lblFnameRenew.Location = new System.Drawing.Point(49, 59);
            this.lblFnameRenew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFnameRenew.Name = "lblFnameRenew";
            this.lblFnameRenew.Size = new System.Drawing.Size(57, 13);
            this.lblFnameRenew.TabIndex = 6;
            this.lblFnameRenew.Text = "Forename:";
            // 
            // lblSnameRenew
            // 
            this.lblSnameRenew.AutoSize = true;
            this.lblSnameRenew.Location = new System.Drawing.Point(49, 94);
            this.lblSnameRenew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSnameRenew.Name = "lblSnameRenew";
            this.lblSnameRenew.Size = new System.Drawing.Size(52, 13);
            this.lblSnameRenew.TabIndex = 4;
            this.lblSnameRenew.Text = "Surname:";
            // 
            // lblEmailRenew
            // 
            this.lblEmailRenew.AutoSize = true;
            this.lblEmailRenew.Location = new System.Drawing.Point(49, 127);
            this.lblEmailRenew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailRenew.Name = "lblEmailRenew";
            this.lblEmailRenew.Size = new System.Drawing.Size(35, 13);
            this.lblEmailRenew.TabIndex = 3;
            this.lblEmailRenew.Text = "Email:";
            // 
            // lblRenewHeader
            // 
            this.lblRenewHeader.AutoSize = true;
            this.lblRenewHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenewHeader.Location = new System.Drawing.Point(273, 27);
            this.lblRenewHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRenewHeader.Name = "lblRenewHeader";
            this.lblRenewHeader.Size = new System.Drawing.Size(202, 25);
            this.lblRenewHeader.TabIndex = 22;
            this.lblRenewHeader.Text = "Renew Membership";
            // 
            // mnuBackRenew
            // 
            this.mnuBackRenew.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBackRenew.Name = "mnuBackRenew";
            this.mnuBackRenew.Size = new System.Drawing.Size(44, 22);
            this.mnuBackRenew.Text = "Back";
            this.mnuBackRenew.Click += new System.EventHandler(this.mnuBackRenew_Click);
            // 
            // CreateMemberMenu
            // 
            this.CreateMemberMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CreateMemberMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackRenew});
            this.CreateMemberMenu.Location = new System.Drawing.Point(0, 0);
            this.CreateMemberMenu.Name = "CreateMemberMenu";
            this.CreateMemberMenu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.CreateMemberMenu.Size = new System.Drawing.Size(841, 24);
            this.CreateMemberMenu.TabIndex = 21;
            this.CreateMemberMenu.Text = "CreateMenu";
            // 
            // dgvRenew
            // 
            this.dgvRenew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRenew.Location = new System.Drawing.Point(122, 71);
            this.dgvRenew.Name = "dgvRenew";
            this.dgvRenew.Size = new System.Drawing.Size(564, 105);
            this.dgvRenew.TabIndex = 27;
            // 
            // btnRenewGetDetails
            // 
            this.btnRenewGetDetails.Location = new System.Drawing.Point(309, 205);
            this.btnRenewGetDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenewGetDetails.Name = "btnRenewGetDetails";
            this.btnRenewGetDetails.Size = new System.Drawing.Size(116, 23);
            this.btnRenewGetDetails.TabIndex = 19;
            this.btnRenewGetDetails.Text = "Get Details";
            this.btnRenewGetDetails.UseVisualStyleBackColor = true;
            this.btnRenewGetDetails.Click += new System.EventHandler(this.btnRenewGetDetails_Click_1);
            // 
            // RenewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 509);
            this.Controls.Add(this.btnRenewGetDetails);
            this.Controls.Add(this.dgvRenew);
            this.Controls.Add(this.txtRenewMemID);
            this.Controls.Add(this.lblMemIDRenew);
            this.Controls.Add(this.RenewGroupBox);
            this.Controls.Add(this.lblRenewHeader);
            this.Controls.Add(this.CreateMemberMenu);
            this.Name = "RenewMember";
            this.Text = "Members-RenewMember";
            this.Load += new System.EventHandler(this.RenewMember_Load_1);
            this.RenewGroupBox.ResumeLayout(false);
            this.RenewGroupBox.PerformLayout();
            this.CreateMemberMenu.ResumeLayout(false);
            this.CreateMemberMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRenewMemID;
        private System.Windows.Forms.Label lblMemIDRenew;
        private System.Windows.Forms.GroupBox RenewGroupBox;
        private System.Windows.Forms.Button btnRenewMember;
        private System.Windows.Forms.TextBox txtRenewSname;
        private System.Windows.Forms.TextBox txtRenewFname;
        private System.Windows.Forms.TextBox txtRenewPhone;
        private System.Windows.Forms.TextBox txtRenewEmail;
        private System.Windows.Forms.Label lblPhoneRenew;
        private System.Windows.Forms.Label lblFnameRenew;
        private System.Windows.Forms.Label lblSnameRenew;
        private System.Windows.Forms.Label lblEmailRenew;
        private System.Windows.Forms.Label lblRenewHeader;
        private System.Windows.Forms.ToolStripMenuItem mnuBackRenew;
        private System.Windows.Forms.MenuStrip CreateMemberMenu;
        private System.Windows.Forms.DataGridView dgvRenew;
        private System.Windows.Forms.Button btnRenewGetDetails;
    }
}