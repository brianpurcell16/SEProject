namespace RequirmentsEngineering
{
    partial class BookClass
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
            this.mnuBooking = new System.Windows.Forms.MenuStrip();
            this.mnuBookBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBookHeader = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblClassIDBook = new System.Windows.Forms.Label();
            this.txtBookClassID = new System.Windows.Forms.TextBox();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.lblBookFname = new System.Windows.Forms.Label();
            this.lblBookSname = new System.Windows.Forms.Label();
            this.txtBookFname = new System.Windows.Forms.TextBox();
            this.txtBookSname = new System.Windows.Forms.TextBox();
            this.mnuBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuBooking
            // 
            this.mnuBooking.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuBooking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBookBack});
            this.mnuBooking.Location = new System.Drawing.Point(0, 0);
            this.mnuBooking.Name = "mnuBooking";
            this.mnuBooking.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.mnuBooking.Size = new System.Drawing.Size(1249, 26);
            this.mnuBooking.TabIndex = 33;
            this.mnuBooking.Text = "CreateMenu";
            // 
            // mnuBookBack
            // 
            this.mnuBookBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBookBack.Name = "mnuBookBack";
            this.mnuBookBack.Size = new System.Drawing.Size(54, 24);
            this.mnuBookBack.Text = "Back";
            this.mnuBookBack.Click += new System.EventHandler(this.mnuBookBack_Click);
            // 
            // lblBookHeader
            // 
            this.lblBookHeader.AutoSize = true;
            this.lblBookHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookHeader.Location = new System.Drawing.Point(442, 26);
            this.lblBookHeader.Name = "lblBookHeader";
            this.lblBookHeader.Size = new System.Drawing.Size(222, 39);
            this.lblBookHeader.TabIndex = 34;
            this.lblBookHeader.Text = "Book A Class";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(449, 505);
            this.btnBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(203, 39);
            this.btnBook.TabIndex = 19;
            this.btnBook.Text = "Book Class";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblClassIDBook
            // 
            this.lblClassIDBook.AutoSize = true;
            this.lblClassIDBook.Location = new System.Drawing.Point(446, 449);
            this.lblClassIDBook.Name = "lblClassIDBook";
            this.lblClassIDBook.Size = new System.Drawing.Size(91, 16);
            this.lblClassIDBook.TabIndex = 25;
            this.lblClassIDBook.Text = "Enter ClassID:";
            // 
            // txtBookClassID
            // 
            this.txtBookClassID.Location = new System.Drawing.Point(561, 451);
            this.txtBookClassID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookClassID.Name = "txtBookClassID";
            this.txtBookClassID.Size = new System.Drawing.Size(89, 22);
            this.txtBookClassID.TabIndex = 35;
            // 
            // dgvBooking
            // 
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(149, 116);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.RowTemplate.Height = 24;
            this.dgvBooking.Size = new System.Drawing.Size(892, 207);
            this.dgvBooking.TabIndex = 36;
            // 
            // lblBookFname
            // 
            this.lblBookFname.AutoSize = true;
            this.lblBookFname.Location = new System.Drawing.Point(446, 399);
            this.lblBookFname.Name = "lblBookFname";
            this.lblBookFname.Size = new System.Drawing.Size(106, 16);
            this.lblBookFname.TabIndex = 37;
            this.lblBookFname.Text = "Enter Forename:";
            // 
            // lblBookSname
            // 
            this.lblBookSname.AutoSize = true;
            this.lblBookSname.Location = new System.Drawing.Point(446, 424);
            this.lblBookSname.Name = "lblBookSname";
            this.lblBookSname.Size = new System.Drawing.Size(98, 16);
            this.lblBookSname.TabIndex = 38;
            this.lblBookSname.Text = "Enter Surname:";
            // 
            // txtBookFname
            // 
            this.txtBookFname.Location = new System.Drawing.Point(561, 399);
            this.txtBookFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookFname.Name = "txtBookFname";
            this.txtBookFname.Size = new System.Drawing.Size(130, 22);
            this.txtBookFname.TabIndex = 39;
            // 
            // txtBookSname
            // 
            this.txtBookSname.Location = new System.Drawing.Point(561, 425);
            this.txtBookSname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookSname.Name = "txtBookSname";
            this.txtBookSname.Size = new System.Drawing.Size(130, 22);
            this.txtBookSname.TabIndex = 40;
            // 
            // BookClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 670);
            this.Controls.Add(this.txtBookSname);
            this.Controls.Add(this.txtBookFname);
            this.Controls.Add(this.lblBookSname);
            this.Controls.Add(this.lblBookFname);
            this.Controls.Add(this.dgvBooking);
            this.Controls.Add(this.txtBookClassID);
            this.Controls.Add(this.lblClassIDBook);
            this.Controls.Add(this.lblBookHeader);
            this.Controls.Add(this.mnuBooking);
            this.Controls.Add(this.btnBook);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookClass";
            this.Text = "BookClass";
            this.Load += new System.EventHandler(this.BookClass_Load);
            this.mnuBooking.ResumeLayout(false);
            this.mnuBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuBookBack;
        private System.Windows.Forms.Label lblBookHeader;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblClassIDBook;
        private System.Windows.Forms.TextBox txtBookClassID;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Label lblBookFname;
        private System.Windows.Forms.Label lblBookSname;
        private System.Windows.Forms.TextBox txtBookFname;
        private System.Windows.Forms.TextBox txtBookSname;
    }
}