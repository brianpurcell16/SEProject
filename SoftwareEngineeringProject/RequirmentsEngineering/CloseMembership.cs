using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequirmentsEngineering
{
    public partial class CloseMembership : Form
    {

        Member closeMember = new Member();
        public CloseMembership()
        {
            InitializeComponent();
        }


        private void mnuBackClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnRemoveMember_Click(object sender, EventArgs e)
        {

            closeMember.updateStatusClose(txtMemIDClose.Text);

            MessageBox.Show("Membership has been closed!", "Closing", MessageBoxButtons.OK);
            txtForenameClose.Clear();
            txtSurnameClose.Clear();
            txtEmailClose.Clear();
            txtPhoneNumberClose.Clear();
            txtMemIDClose.Clear();
            Member.getAllCloseMembers(dgvClose);
        }

        private void CloseMembership_Load_1(object sender, EventArgs e)
        {
            Member.getAllCloseMembers(dgvClose);
            txtForenameClose.Enabled = false;
            txtSurnameClose.Enabled = false;
            txtEmailClose.Enabled = false;
            txtPhoneNumberClose.Enabled = false;
        }

        private void btnGetClose_Click(object sender, EventArgs e)
        {

            if (txtMemIDClose.Text.Any(char.IsDigit) == false)
            {
                MessageBox.Show("Member ID must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                closeMember.getMemberRenewOrClose(txtMemIDClose.Text);

                txtForenameClose.Text = closeMember.getFname();
                txtSurnameClose.Text = closeMember.getSname();
                txtEmailClose.Text = closeMember.getEmail();
                txtPhoneNumberClose.Text = closeMember.getPhone();
            }
        }
    }
}
