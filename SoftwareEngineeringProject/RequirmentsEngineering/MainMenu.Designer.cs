namespace RequirmentsEngineering
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMainMenuRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuRegisterMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuUpdateMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuCancelMembership = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuRenewMembership = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuAddFunds = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuClasses = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuScheduleClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuCancelClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuBookClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuCancelBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuGenerateRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbMainMenu = new System.Windows.Forms.PictureBox();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuRegister,
            this.mnuMainMenuClasses,
            this.mnuMainMenuBooking,
            this.mnuMainMenuAdmin,
            this.exitToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.mnuMainMenu.Size = new System.Drawing.Size(1080, 26);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuMainMenuRegister
            // 
            this.mnuMainMenuRegister.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuRegisterMember,
            this.mnuMainMenuUpdateMember,
            this.mnuMainMenuCancelMembership,
            this.mnuMainMenuRenewMembership,
            this.mnuMainMenuAddFunds});
            this.mnuMainMenuRegister.Name = "mnuMainMenuRegister";
            this.mnuMainMenuRegister.Size = new System.Drawing.Size(79, 24);
            this.mnuMainMenuRegister.Text = "Member";
            // 
            // mnuMainMenuRegisterMember
            // 
            this.mnuMainMenuRegisterMember.Name = "mnuMainMenuRegisterMember";
            this.mnuMainMenuRegisterMember.Size = new System.Drawing.Size(223, 26);
            this.mnuMainMenuRegisterMember.Text = "Register Member";
            this.mnuMainMenuRegisterMember.Click += new System.EventHandler(this.mnuMainMenuRegisterMember_Click);
            // 
            // mnuMainMenuUpdateMember
            // 
            this.mnuMainMenuUpdateMember.Name = "mnuMainMenuUpdateMember";
            this.mnuMainMenuUpdateMember.Size = new System.Drawing.Size(223, 26);
            this.mnuMainMenuUpdateMember.Text = "Update Member";
            this.mnuMainMenuUpdateMember.Click += new System.EventHandler(this.mnuMainMenuUpdateMember_Click);
            // 
            // mnuMainMenuCancelMembership
            // 
            this.mnuMainMenuCancelMembership.Name = "mnuMainMenuCancelMembership";
            this.mnuMainMenuCancelMembership.Size = new System.Drawing.Size(223, 26);
            this.mnuMainMenuCancelMembership.Text = "Cancel Membership";
            this.mnuMainMenuCancelMembership.Click += new System.EventHandler(this.mnuMainMenuCancelMembership_Click);
            // 
            // mnuMainMenuRenewMembership
            // 
            this.mnuMainMenuRenewMembership.Name = "mnuMainMenuRenewMembership";
            this.mnuMainMenuRenewMembership.Size = new System.Drawing.Size(223, 26);
            this.mnuMainMenuRenewMembership.Text = "Renew Membership";
            this.mnuMainMenuRenewMembership.Click += new System.EventHandler(this.mnuMainMenuRenewMembership_Click);
            // 
            // mnuMainMenuAddFunds
            // 
            this.mnuMainMenuAddFunds.Name = "mnuMainMenuAddFunds";
            this.mnuMainMenuAddFunds.Size = new System.Drawing.Size(223, 26);
            this.mnuMainMenuAddFunds.Text = "Add Funds";
            this.mnuMainMenuAddFunds.Click += new System.EventHandler(this.mnuMainMenuAddFunds_Click);
            // 
            // mnuMainMenuClasses
            // 
            this.mnuMainMenuClasses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuScheduleClass,
            this.mnuMainMenuCancelClass});
            this.mnuMainMenuClasses.Name = "mnuMainMenuClasses";
            this.mnuMainMenuClasses.Size = new System.Drawing.Size(70, 24);
            this.mnuMainMenuClasses.Text = "Classes";
            // 
            // mnuMainMenuScheduleClass
            // 
            this.mnuMainMenuScheduleClass.Name = "mnuMainMenuScheduleClass";
            this.mnuMainMenuScheduleClass.Size = new System.Drawing.Size(203, 26);
            this.mnuMainMenuScheduleClass.Text = "Schedule A Class";
            this.mnuMainMenuScheduleClass.Click += new System.EventHandler(this.mnuMainMenuScheduleClass_Click);
            // 
            // mnuMainMenuCancelClass
            // 
            this.mnuMainMenuCancelClass.Name = "mnuMainMenuCancelClass";
            this.mnuMainMenuCancelClass.Size = new System.Drawing.Size(203, 26);
            this.mnuMainMenuCancelClass.Text = "Cancel A Class";
            this.mnuMainMenuCancelClass.Click += new System.EventHandler(this.mnuMainMenuCancelClass_Click);
            // 
            // mnuMainMenuBooking
            // 
            this.mnuMainMenuBooking.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuBookClass,
            this.mnuMainMenuCancelBook});
            this.mnuMainMenuBooking.Name = "mnuMainMenuBooking";
            this.mnuMainMenuBooking.Size = new System.Drawing.Size(78, 24);
            this.mnuMainMenuBooking.Text = "Booking";
            // 
            // mnuMainMenuBookClass
            // 
            this.mnuMainMenuBookClass.Name = "mnuMainMenuBookClass";
            this.mnuMainMenuBookClass.Size = new System.Drawing.Size(209, 26);
            this.mnuMainMenuBookClass.Text = "Book A Class";
            this.mnuMainMenuBookClass.Click += new System.EventHandler(this.mnuMainMenuBookClass_Click);
            // 
            // mnuMainMenuCancelBook
            // 
            this.mnuMainMenuCancelBook.Name = "mnuMainMenuCancelBook";
            this.mnuMainMenuCancelBook.Size = new System.Drawing.Size(209, 26);
            this.mnuMainMenuCancelBook.Text = "Cancel A Booking";
            this.mnuMainMenuCancelBook.Click += new System.EventHandler(this.mnuMainMenuCancelBook_Click);
            // 
            // mnuMainMenuAdmin
            // 
            this.mnuMainMenuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuGenerateRevenue});
            this.mnuMainMenuAdmin.Name = "mnuMainMenuAdmin";
            this.mnuMainMenuAdmin.Size = new System.Drawing.Size(67, 24);
            this.mnuMainMenuAdmin.Text = "Admin";
            // 
            // mnuMainMenuGenerateRevenue
            // 
            this.mnuMainMenuGenerateRevenue.Name = "mnuMainMenuGenerateRevenue";
            this.mnuMainMenuGenerateRevenue.Size = new System.Drawing.Size(312, 26);
            this.mnuMainMenuGenerateRevenue.Text = "Generate Yearly Revenue Analysis";
            this.mnuMainMenuGenerateRevenue.Click += new System.EventHandler(this.mnuMainMenuGenerateRevenue_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pbMainMenu
            // 
            this.pbMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMainMenu.Image")));
            this.pbMainMenu.InitialImage = null;
            this.pbMainMenu.Location = new System.Drawing.Point(51, 80);
            this.pbMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMainMenu.Name = "pbMainMenu";
            this.pbMainMenu.Size = new System.Drawing.Size(952, 431);
            this.pbMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainMenu.TabIndex = 1;
            this.pbMainMenu.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 565);
            this.Controls.Add(this.pbMainMenu);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuRegister;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuRegisterMember;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuUpdateMember;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuCancelMembership;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuRenewMembership;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuAddFunds;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuClasses;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuScheduleClass;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuCancelClass;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuBookClass;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuCancelBook;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuAdmin;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuGenerateRevenue;
        private System.Windows.Forms.PictureBox pbMainMenu;
    }
}