using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequirmentsEngineering
{
    public partial class CancelClass : Form
    {

        Classes cancel = new Classes();
        public CancelClass()
        {
            InitializeComponent();
        }

        private void mnuCancelBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel.cancelClass(txtClassIDCancel.Text);
            MessageBox.Show("Class has been cancelled", "Cancellation", MessageBoxButtons.OK);
            txtTitleCancel.Clear();
            txtCapacityCancel.Clear();
            txtTimeCancel.Clear();
            txtPriceCancel.Clear();
            txtClassIDCancel.Clear();
            Classes.activeClasses(dgvCancelClass);
        }

        private void CancelClass_Load(object sender, EventArgs e)
        {
            Classes.activeClasses(dgvCancelClass);
        }

        private void btnCancelDetails_Click(object sender, EventArgs e)
        {
            if (txtClassIDCancel.Text.Any(char.IsDigit) == false)
            {
                MessageBox.Show("Class ID must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
                cancel.getCancelDetails(txtClassIDCancel.Text);

            if(cancel.getTitle() == "")
            {
                MessageBox.Show("Class Dosent Exist", "Error");
                txtClassIDCancel.Clear();
                txtClassIDCancel.Focus();
                return;
            }

            txtTitleCancel.Text = cancel.getTitle();
            dtpCancelClass.Value = cancel.GetCDate();
            txtTimeCancel.Text = cancel.getCTime();
            txtPriceCancel.Text = cancel.getPrice().ToString();
            txtCapacityCancel.Text = cancel.getCapacity().ToString();


        }
    }
}
