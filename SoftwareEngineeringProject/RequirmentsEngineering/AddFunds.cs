using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequirmentsEngineering
{
    public partial class AddFunds : Form
    {

        Member fundsMember = new Member();
        public AddFunds()
        {
            InitializeComponent();
        }


        private void mnuFundsBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btnAddFunds_Click(object sender, EventArgs e)
        {

            if (txtFundsFname.Text.Equals(""))
            {
                MessageBox.Show("Forename must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFundsFname.Focus();
                return;
            }

            if (txtFundsFname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Forename must not have a digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFundsFname.Clear();
                txtFundsFname.Focus();
                return;
            }

            if (txtFundsSname.Text.Equals(""))
            {
                MessageBox.Show("Surname must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFundsSname.Focus();
                return;
            }
            if (txtFundsSname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Surname must not have a digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFundsSname.Clear();
                txtFundsSname.Focus();
                return;
            }


            if (txtFundsCardName.Text.Equals(""))
            {
                MessageBox.Show("Card Name must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFundsCardName.Focus();
                return;
            }


            if (txtFundsCardName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Forename must not have a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFundsCardName.Clear();
                txtFundsCardName.Focus();
                return;
            }

            if (txtFundsExpiry.Text.Equals(""))
            {
                MessageBox.Show("Expiry Date must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFundsExpiry.Focus();
                return;
            }

            if (txtFundsExpiry.Text.Any(char.IsDigit) == false)
            {
                MessageBox.Show("Expiry Date must be numbers ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFundsExpiry.Clear();
                txtFundsExpiry.Focus();
                return;
            }

            if (txtFundsCardNumber.Text.Equals(""))
            {
                MessageBox.Show("Card Number must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFundsCardNumber.Focus();
                return;
            }

            if (txtFundsCardNumber.Text.Length != 16)
            {
                MessageBox.Show("Card Number must be 16 characters(No Spaces)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFundsCardNumber.Focus();
                return;
            }

            if (txtFundsCardNumber.Text.Any(char.IsDigit) == false)
            {
                MessageBox.Show("Card Number must be numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFundsCardNumber.Clear();
                txtFundsCardNumber.Focus();
                return;
            }

            if (txtFundsCode.Text.Equals(""))
            {
                MessageBox.Show("Security Code must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFundsCode.Focus();
                return;
            }

            if (txtFundsCode.Text.Length > 4)
            {
                MessageBox.Show("Security Code must be 3 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFundsCode.Focus();
                return;
            }

            if (txtFundsCode.Text.Any(char.IsDigit) == false)
            {
                MessageBox.Show("Security Code must be numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFundsCode.Clear();
                txtFundsCode.Focus();
                return;
            }

            if (txtFundsAmount.Text.Equals(""))
            {
                MessageBox.Show("Amount must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFundsAmount.Focus();
                return;
            }

            if (txtFundsAmount.Text.Length >= 4)
            {
                MessageBox.Show("Cant add more than 100 at a time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFundsAmount.Focus();
                return;
            }

            if (txtFundsAmount.Text.Any(char.IsDigit) == false)
            {
                MessageBox.Show("Amount must be numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFundsAmount.Clear();
                txtFundsAmount.Focus();
                return;
            }

            else
            {

                fundsMember.addingFunds(txtFundsFname.Text,txtFundsSname.Text, Convert.ToDouble(txtFundsAmount.Text));

                MessageBox.Show("Funds added to your account", "Funds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFundsCardNumber.Clear();
                txtFundsCardName.Clear();
                txtFundsCode.Clear();
                txtFundsExpiry.Clear();
                txtFundsAmount.Clear();
                txtFundsFname.Clear();
                txtFundsSname.Clear();
                txtFundsFname.Focus();
            }

        }

        private void AddFunds_Load(object sender, EventArgs e)
        {
            txtFundsFname.Focus();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
