namespace RequirmentsEngineering
{
    partial class RegisterMember
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
            this.lblRegisterFname = new System.Windows.Forms.Label();
            this.lblRegisterSname = new System.Windows.Forms.Label();
            this.lblRegisterEmail = new System.Windows.Forms.Label();
            this.lblRegisterDOB = new System.Windows.Forms.Label();
            this.lblRegisterPhone = new System.Windows.Forms.Label();
            this.txtRegisterFname = new System.Windows.Forms.TextBox();
            this.txtRegisterSname = new System.Windows.Forms.TextBox();
            this.txtRegisterEmail = new System.Windows.Forms.TextBox();
            this.txtRegisterPhone = new System.Windows.Forms.TextBox();
            this.SubmitCreate = new System.Windows.Forms.Button();
            this.lblRegisterHeader = new System.Windows.Forms.Label();
            this.CreateMemberMenu = new System.Windows.Forms.MenuStrip();
            this.mnuRegMemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterBack = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpRegister = new System.Windows.Forms.DateTimePicker();
            this.CreateMemberMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegisterFname
            // 
            this.lblRegisterFname.AutoSize = true;
            this.lblRegisterFname.Location = new System.Drawing.Point(208, 111);
            this.lblRegisterFname.Name = "lblRegisterFname";
            this.lblRegisterFname.Size = new System.Drawing.Size(106, 16);
            this.lblRegisterFname.TabIndex = 1;
            this.lblRegisterFname.Text = "Enter Forename:";
            // 
            // lblRegisterSname
            // 
            this.lblRegisterSname.AutoSize = true;
            this.lblRegisterSname.Location = new System.Drawing.Point(208, 140);
            this.lblRegisterSname.Name = "lblRegisterSname";
            this.lblRegisterSname.Size = new System.Drawing.Size(98, 16);
            this.lblRegisterSname.TabIndex = 2;
            this.lblRegisterSname.Text = "Enter Surname:";
            // 
            // lblRegisterEmail
            // 
            this.lblRegisterEmail.AutoSize = true;
            this.lblRegisterEmail.Location = new System.Drawing.Point(208, 172);
            this.lblRegisterEmail.Name = "lblRegisterEmail";
            this.lblRegisterEmail.Size = new System.Drawing.Size(78, 16);
            this.lblRegisterEmail.TabIndex = 3;
            this.lblRegisterEmail.Text = "Enter Email:";
            // 
            // lblRegisterDOB
            // 
            this.lblRegisterDOB.AutoSize = true;
            this.lblRegisterDOB.Location = new System.Drawing.Point(208, 208);
            this.lblRegisterDOB.Name = "lblRegisterDOB";
            this.lblRegisterDOB.Size = new System.Drawing.Size(149, 16);
            this.lblRegisterDOB.TabIndex = 4;
            this.lblRegisterDOB.Text = "Enter Your Date Of Birth:";
            // 
            // lblRegisterPhone
            // 
            this.lblRegisterPhone.AutoSize = true;
            this.lblRegisterPhone.Location = new System.Drawing.Point(208, 244);
            this.lblRegisterPhone.Name = "lblRegisterPhone";
            this.lblRegisterPhone.Size = new System.Drawing.Size(165, 16);
            this.lblRegisterPhone.TabIndex = 5;
            this.lblRegisterPhone.Text = "Enter Your Phone Number:";
            // 
            // txtRegisterFname
            // 
            this.txtRegisterFname.Location = new System.Drawing.Point(447, 106);
            this.txtRegisterFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegisterFname.MaxLength = 35;
            this.txtRegisterFname.Name = "txtRegisterFname";
            this.txtRegisterFname.Size = new System.Drawing.Size(151, 22);
            this.txtRegisterFname.TabIndex = 9;
            // 
            // txtRegisterSname
            // 
            this.txtRegisterSname.Location = new System.Drawing.Point(447, 135);
            this.txtRegisterSname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegisterSname.MaxLength = 35;
            this.txtRegisterSname.Name = "txtRegisterSname";
            this.txtRegisterSname.Size = new System.Drawing.Size(151, 22);
            this.txtRegisterSname.TabIndex = 10;
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.Location = new System.Drawing.Point(447, 172);
            this.txtRegisterEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegisterEmail.MaxLength = 50;
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.Size = new System.Drawing.Size(200, 22);
            this.txtRegisterEmail.TabIndex = 11;
            // 
            // txtRegisterPhone
            // 
            this.txtRegisterPhone.Location = new System.Drawing.Point(447, 244);
            this.txtRegisterPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegisterPhone.MaxLength = 10;
            this.txtRegisterPhone.Name = "txtRegisterPhone";
            this.txtRegisterPhone.Size = new System.Drawing.Size(151, 22);
            this.txtRegisterPhone.TabIndex = 13;
            // 
            // SubmitCreate
            // 
            this.SubmitCreate.Location = new System.Drawing.Point(316, 319);
            this.SubmitCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitCreate.Name = "SubmitCreate";
            this.SubmitCreate.Size = new System.Drawing.Size(203, 39);
            this.SubmitCreate.TabIndex = 17;
            this.SubmitCreate.Text = "Submit";
            this.SubmitCreate.UseVisualStyleBackColor = true;
            this.SubmitCreate.Click += new System.EventHandler(this.SubmitCreate_Click);
            // 
            // lblRegisterHeader
            // 
            this.lblRegisterHeader.AutoSize = true;
            this.lblRegisterHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterHeader.Location = new System.Drawing.Point(309, 48);
            this.lblRegisterHeader.Name = "lblRegisterHeader";
            this.lblRegisterHeader.Size = new System.Drawing.Size(221, 31);
            this.lblRegisterHeader.TabIndex = 18;
            this.lblRegisterHeader.Text = "Register Member";
            this.lblRegisterHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreateMemberMenu
            // 
            this.CreateMemberMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CreateMemberMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegMemBack});
            this.CreateMemberMenu.Location = new System.Drawing.Point(0, 0);
            this.CreateMemberMenu.Name = "CreateMemberMenu";
            this.CreateMemberMenu.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.CreateMemberMenu.Size = new System.Drawing.Size(855, 26);
            this.CreateMemberMenu.TabIndex = 21;
            this.CreateMemberMenu.Text = "CreateMenu";
            // 
            // mnuRegMemBack
            // 
            this.mnuRegMemBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuRegMemBack.Name = "mnuRegMemBack";
            this.mnuRegMemBack.Size = new System.Drawing.Size(54, 24);
            this.mnuRegMemBack.Text = "Back";
            this.mnuRegMemBack.Click += new System.EventHandler(this.mnuRegMemBack_Click);
            // 
            // mnuRegisterBack
            // 
            this.mnuRegisterBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuRegisterBack.Name = "mnuRegisterBack";
            this.mnuRegisterBack.Size = new System.Drawing.Size(44, 22);
            this.mnuRegisterBack.Text = "Back";
            this.mnuRegisterBack.Click += new System.EventHandler(this.mnuRegisterBack_Click);
            // 
            // dtpRegister
            // 
            this.dtpRegister.Location = new System.Drawing.Point(447, 208);
            this.dtpRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpRegister.Name = "dtpRegister";
            this.dtpRegister.Size = new System.Drawing.Size(151, 22);
            this.dtpRegister.TabIndex = 22;
            // 
            // RegisterMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 423);
            this.Controls.Add(this.dtpRegister);
            this.Controls.Add(this.CreateMemberMenu);
            this.Controls.Add(this.lblRegisterHeader);
            this.Controls.Add(this.SubmitCreate);
            this.Controls.Add(this.txtRegisterPhone);
            this.Controls.Add(this.txtRegisterEmail);
            this.Controls.Add(this.txtRegisterSname);
            this.Controls.Add(this.txtRegisterFname);
            this.Controls.Add(this.lblRegisterPhone);
            this.Controls.Add(this.lblRegisterDOB);
            this.Controls.Add(this.lblRegisterEmail);
            this.Controls.Add(this.lblRegisterSname);
            this.Controls.Add(this.lblRegisterFname);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterMember";
            this.Text = "Members-CreateMember";
            this.Load += new System.EventHandler(this.RegisterMember_Load);
            this.CreateMemberMenu.ResumeLayout(false);
            this.CreateMemberMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRegisterFname;
        private System.Windows.Forms.Label lblRegisterSname;
        private System.Windows.Forms.Label lblRegisterEmail;
        private System.Windows.Forms.Label lblRegisterDOB;
        private System.Windows.Forms.Label lblRegisterPhone;
        private System.Windows.Forms.TextBox txtRegisterFname;
        private System.Windows.Forms.TextBox txtRegisterSname;
        private System.Windows.Forms.TextBox txtRegisterEmail;
        private System.Windows.Forms.TextBox txtRegisterPhone;
        private System.Windows.Forms.Button SubmitCreate;
        private System.Windows.Forms.Label lblRegisterHeader;
        private System.Windows.Forms.MenuStrip CreateMemberMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterBack;
        private System.Windows.Forms.DateTimePicker dtpRegister;
        private System.Windows.Forms.ToolStripMenuItem mnuRegMemBack;
    }
}

