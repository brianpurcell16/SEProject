using Oracle.ManagedDataAccess.Client;
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
    public partial class RenewMember : Form

    {

        Member renewMember = new Member();
        public RenewMember()
        {
            InitializeComponent();
        }

        private void mnuBackRenew_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnRenewMember_Click(object sender, EventArgs e)
        {

            renewMember.updateStatusRenew(txtRenewMemID.Text);
            

            MessageBox.Show("Membership has been renewed!", "Renewal", MessageBoxButtons.OK);
            txtRenewMemID.Clear();
            txtRenewFname.Clear();
            txtRenewSname.Clear();
            txtRenewEmail.Clear();
            txtRenewPhone.Clear();
            Member.getAllRenewMembers(dgvRenew);
        }

       

        private void RenewMember_Load_1(object sender, EventArgs e)
        {
            Member.getAllRenewMembers(dgvRenew);
            txtRenewFname.Enabled = false;
            txtRenewSname.Enabled = false;
            txtRenewEmail.Enabled = false;
            txtRenewPhone.Enabled = false;
        }


        private void btnRenewGetDetails_Click_1(object sender, EventArgs e)
        {
            Debug.WriteLine("hello");

            if (txtRenewMemID.Text.Any(char.IsDigit) == false)
            {
                MessageBox.Show("Member ID must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                Debug.WriteLine(txtRenewMemID.Text);
                renewMember.getMemberRenewOrClose(txtRenewMemID.Text);

                txtRenewFname.Text = renewMember.getFname();
                txtRenewSname.Text = renewMember.getSname();
                txtRenewEmail.Text = renewMember.getEmail();
                txtRenewPhone.Text = renewMember.getPhone();
            }

        }
    }
}
