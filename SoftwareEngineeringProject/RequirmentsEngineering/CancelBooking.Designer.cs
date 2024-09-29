namespace RequirmentsEngineering
{
    partial class CancelBooking
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
            this.mnuCancelBook = new System.Windows.Forms.MenuStrip();
            this.mnuCancelBookBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCancelBookHeader = new System.Windows.Forms.Label();
            this.grpCancelBook = new System.Windows.Forms.GroupBox();
            this.dtpCancelBook = new System.Windows.Forms.DateTimePicker();
            this.txtMemIDCancelBooking = new System.Windows.Forms.TextBox();
            this.txtClassIDCancelBooking = new System.Windows.Forms.TextBox();
            this.txtCancelBookingID = new System.Windows.Forms.TextBox();
            this.btnCancelBook = new System.Windows.Forms.Button();
            this.lblMemIDCancelBooking = new System.Windows.Forms.Label();
            this.lblClassIDCancelBooking = new System.Windows.Forms.Label();
            this.lblDateBookedCancel = new System.Windows.Forms.Label();
            this.lblCancelBookingID = new System.Windows.Forms.Label();
            this.lblBookingIDCancelBook = new System.Windows.Forms.Label();
            this.txtBookingIDCancelBook = new System.Windows.Forms.TextBox();
            this.dgvCancelBooking = new System.Windows.Forms.DataGridView();
            this.btnCancelBookingsDetails = new System.Windows.Forms.Button();
            this.mnuCancelBook.SuspendLayout();
            this.grpCancelBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuCancelBook
            // 
            this.mnuCancelBook.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuCancelBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCancelBookBack});
            this.mnuCancelBook.Location = new System.Drawing.Point(0, 0);
            this.mnuCancelBook.Name = "mnuCancelBook";
            this.mnuCancelBook.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.mnuCancelBook.Size = new System.Drawing.Size(1244, 26);
            this.mnuCancelBook.TabIndex = 34;
            this.mnuCancelBook.Text = "CreateMenu";
            // 
            // mnuCancelBookBack
            // 
            this.mnuCancelBookBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuCancelBookBack.Name = "mnuCancelBookBack";
            this.mnuCancelBookBack.Size = new System.Drawing.Size(54, 24);
            this.mnuCancelBookBack.Text = "Back";
            this.mnuCancelBookBack.Click += new System.EventHandler(this.mnuCancelBookBack_Click);
            // 
            // lblCancelBookHeader
            // 
            this.lblCancelBookHeader.AutoSize = true;
            this.lblCancelBookHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelBookHeader.Location = new System.Drawing.Point(456, 30);
            this.lblCancelBookHeader.Name = "lblCancelBookHeader";
            this.lblCancelBookHeader.Size = new System.Drawing.Size(289, 39);
            this.lblCancelBookHeader.TabIndex = 36;
            this.lblCancelBookHeader.Text = "Cancel A Booking";
            // 
            // grpCancelBook
            // 
            this.grpCancelBook.Controls.Add(this.dtpCancelBook);
            this.grpCancelBook.Controls.Add(this.txtMemIDCancelBooking);
            this.grpCancelBook.Controls.Add(this.txtClassIDCancelBooking);
            this.grpCancelBook.Controls.Add(this.txtCancelBookingID);
            this.grpCancelBook.Controls.Add(this.btnCancelBook);
            this.grpCancelBook.Controls.Add(this.lblMemIDCancelBooking);
            this.grpCancelBook.Controls.Add(this.lblClassIDCancelBooking);
            this.grpCancelBook.Controls.Add(this.lblDateBookedCancel);
            this.grpCancelBook.Controls.Add(this.lblCancelBookingID);
            this.grpCancelBook.Location = new System.Drawing.Point(325, 343);
            this.grpCancelBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCancelBook.Name = "grpCancelBook";
            this.grpCancelBook.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCancelBook.Size = new System.Drawing.Size(575, 246);
            this.grpCancelBook.TabIndex = 37;
            this.grpCancelBook.TabStop = false;
            this.grpCancelBook.Text = "Booking Details";
            // 
            // dtpCancelBook
            // 
            this.dtpCancelBook.Location = new System.Drawing.Point(179, 71);
            this.dtpCancelBook.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCancelBook.Name = "dtpCancelBook";
            this.dtpCancelBook.Size = new System.Drawing.Size(153, 22);
            this.dtpCancelBook.TabIndex = 24;
            // 
            // txtMemIDCancelBooking
            // 
            this.txtMemIDCancelBooking.Location = new System.Drawing.Point(179, 126);
            this.txtMemIDCancelBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemIDCancelBooking.Name = "txtMemIDCancelBooking";
            this.txtMemIDCancelBooking.Size = new System.Drawing.Size(153, 22);
            this.txtMemIDCancelBooking.TabIndex = 23;
            // 
            // txtClassIDCancelBooking
            // 
            this.txtClassIDCancelBooking.Location = new System.Drawing.Point(179, 97);
            this.txtClassIDCancelBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClassIDCancelBooking.Name = "txtClassIDCancelBooking";
            this.txtClassIDCancelBooking.Size = new System.Drawing.Size(153, 22);
            this.txtClassIDCancelBooking.TabIndex = 22;
            // 
            // txtCancelBookingID
            // 
            this.txtCancelBookingID.Location = new System.Drawing.Point(179, 41);
            this.txtCancelBookingID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCancelBookingID.Name = "txtCancelBookingID";
            this.txtCancelBookingID.Size = new System.Drawing.Size(153, 22);
            this.txtCancelBookingID.TabIndex = 20;
            // 
            // btnCancelBook
            // 
            this.btnCancelBook.Location = new System.Drawing.Point(161, 179);
            this.btnCancelBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelBook.Name = "btnCancelBook";
            this.btnCancelBook.Size = new System.Drawing.Size(203, 39);
            this.btnCancelBook.TabIndex = 19;
            this.btnCancelBook.Text = "Cancel Booking";
            this.btnCancelBook.UseVisualStyleBackColor = true;
            this.btnCancelBook.Click += new System.EventHandler(this.btnCancelBook_Click);
            // 
            // lblMemIDCancelBooking
            // 
            this.lblMemIDCancelBooking.AutoSize = true;
            this.lblMemIDCancelBooking.Location = new System.Drawing.Point(55, 126);
            this.lblMemIDCancelBooking.Name = "lblMemIDCancelBooking";
            this.lblMemIDCancelBooking.Size = new System.Drawing.Size(53, 16);
            this.lblMemIDCancelBooking.TabIndex = 3;
            this.lblMemIDCancelBooking.Text = "MemID:";
            // 
            // lblClassIDCancelBooking
            // 
            this.lblClassIDCancelBooking.AutoSize = true;
            this.lblClassIDCancelBooking.Location = new System.Drawing.Point(55, 97);
            this.lblClassIDCancelBooking.Name = "lblClassIDCancelBooking";
            this.lblClassIDCancelBooking.Size = new System.Drawing.Size(57, 16);
            this.lblClassIDCancelBooking.TabIndex = 2;
            this.lblClassIDCancelBooking.Text = "ClassID:";
            // 
            // lblDateBookedCancel
            // 
            this.lblDateBookedCancel.AutoSize = true;
            this.lblDateBookedCancel.Location = new System.Drawing.Point(55, 69);
            this.lblDateBookedCancel.Name = "lblDateBookedCancel";
            this.lblDateBookedCancel.Size = new System.Drawing.Size(90, 16);
            this.lblDateBookedCancel.TabIndex = 1;
            this.lblDateBookedCancel.Text = "Date Booked:";
            // 
            // lblCancelBookingID
            // 
            this.lblCancelBookingID.AutoSize = true;
            this.lblCancelBookingID.Location = new System.Drawing.Point(55, 41);
            this.lblCancelBookingID.Name = "lblCancelBookingID";
            this.lblCancelBookingID.Size = new System.Drawing.Size(73, 16);
            this.lblCancelBookingID.TabIndex = 0;
            this.lblCancelBookingID.Text = "BookingID:";
            // 
            // lblBookingIDCancelBook
            // 
            this.lblBookingIDCancelBook.AutoSize = true;
            this.lblBookingIDCancelBook.Location = new System.Drawing.Point(380, 291);
            this.lblBookingIDCancelBook.Name = "lblBookingIDCancelBook";
            this.lblBookingIDCancelBook.Size = new System.Drawing.Size(107, 16);
            this.lblBookingIDCancelBook.TabIndex = 38;
            this.lblBookingIDCancelBook.Text = "Enter BookingID:";
            // 
            // txtBookingIDCancelBook
            // 
            this.txtBookingIDCancelBook.Location = new System.Drawing.Point(504, 291);
            this.txtBookingIDCancelBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookingIDCancelBook.Name = "txtBookingIDCancelBook";
            this.txtBookingIDCancelBook.Size = new System.Drawing.Size(153, 22);
            this.txtBookingIDCancelBook.TabIndex = 39;
            // 
            // dgvCancelBooking
            // 
            this.dgvCancelBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancelBooking.Location = new System.Drawing.Point(286, 129);
            this.dgvCancelBooking.Name = "dgvCancelBooking";
            this.dgvCancelBooking.RowHeadersWidth = 51;
            this.dgvCancelBooking.RowTemplate.Height = 24;
            this.dgvCancelBooking.Size = new System.Drawing.Size(630, 146);
            this.dgvCancelBooking.TabIndex = 40;
            // 
            // btnCancelBookingsDetails
            // 
            this.btnCancelBookingsDetails.Location = new System.Drawing.Point(486, 317);
            this.btnCancelBookingsDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelBookingsDetails.Name = "btnCancelBookingsDetails";
            this.btnCancelBookingsDetails.Size = new System.Drawing.Size(185, 32);
            this.btnCancelBookingsDetails.TabIndex = 25;
            this.btnCancelBookingsDetails.Text = "Get Details";
            this.btnCancelBookingsDetails.UseVisualStyleBackColor = true;
            this.btnCancelBookingsDetails.Click += new System.EventHandler(this.btnCancelBookingsDetails_Click);
            // 
            // CancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 631);
            this.Controls.Add(this.btnCancelBookingsDetails);
            this.Controls.Add(this.dgvCancelBooking);
            this.Controls.Add(this.txtBookingIDCancelBook);
            this.Controls.Add(this.lblBookingIDCancelBook);
            this.Controls.Add(this.grpCancelBook);
            this.Controls.Add(this.lblCancelBookHeader);
            this.Controls.Add(this.mnuCancelBook);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CancelBooking";
            this.Text = "Bookings-[Cancel A Booking]";
            this.Load += new System.EventHandler(this.CancelBooking_Load);
            this.mnuCancelBook.ResumeLayout(false);
            this.mnuCancelBook.PerformLayout();
            this.grpCancelBook.ResumeLayout(false);
            this.grpCancelBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCancelBook;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelBookBack;
        private System.Windows.Forms.Label lblCancelBookHeader;
        private System.Windows.Forms.GroupBox grpCancelBook;
        private System.Windows.Forms.TextBox txtMemIDCancelBooking;
        private System.Windows.Forms.TextBox txtClassIDCancelBooking;
        private System.Windows.Forms.TextBox txtCancelBookingID;
        private System.Windows.Forms.Button btnCancelBook;
        private System.Windows.Forms.Label lblMemIDCancelBooking;
        private System.Windows.Forms.Label lblClassIDCancelBooking;
        private System.Windows.Forms.Label lblDateBookedCancel;
        private System.Windows.Forms.Label lblCancelBookingID;
        private System.Windows.Forms.Label lblBookingIDCancelBook;
        private System.Windows.Forms.TextBox txtBookingIDCancelBook;
        private System.Windows.Forms.DateTimePicker dtpCancelBook;
        private System.Windows.Forms.DataGridView dgvCancelBooking;
        private System.Windows.Forms.Button btnCancelBookingsDetails;
    }
}