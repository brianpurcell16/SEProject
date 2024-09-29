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
    public partial class UpdateMember : Form
    {
        Member theMember = new Member();
        public UpdateMember()
        {
            InitializeComponent();
        }


        private void mnuUpdateBack_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {

            if (txtForenameUpdate.Text.Equals(""))
            {
                MessageBox.Show("Forename must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFornameUpdate2.Focus();
                return;
            }

            if (txtForenameUpdate.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Forename must not have a digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFornameUpdate2.Clear();
                txtFornameUpdate2.Focus();
                return;
            }

            if (txtSurnameUpdate.Text.Equals(""))
            {
                MessageBox.Show("Surname must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurnameUpdate2.Focus();
                return;
            }
            if (txtSurnameUpdate.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Surname must not have a digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurnameUpdate2.Clear();
                txtSurnameUpdate2.Focus();
                return;
            }

            
            theMember.getMember(txtForenameUpdate.Text, txtSurnameUpdate.Text);

            txtFornameUpdate2.Text = theMember.getFname();
            txtSurnameUpdate2.Text = theMember.getSname();
            txtEmailUpdate.Text = theMember.getEmail();
            txtPhoneUpdate.Text = theMember.getPhone();

            
            
            
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
           

            if (txtFornameUpdate2.Text.Equals(""))
            {
                MessageBox.Show("Forename must be entered to be updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFornameUpdate2.Focus();
                return;
            }

            if (txtFornameUpdate2.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Forename must not have a digit to be updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFornameUpdate2.Clear();
                txtFornameUpdate2.Focus();
                return;
            }

            if (txtSurnameUpdate2.Text.Equals(""))
            {
                MessageBox.Show("Surname must be entered to be updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurnameUpdate2.Focus();
                return;
            }
            if (txtSurnameUpdate2.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Surname must not have a digit to be updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurnameUpdate2.Clear();
                txtSurnameUpdate2.Focus();
                return;
            }

            if (txtPhoneUpdate.Text.Equals(""))
            {
                MessageBox.Show("Phone number must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneUpdate.Focus();
                return;
            }

            if (txtPhoneUpdate.Text.Any(char.IsDigit) == false)
            {
                MessageBox.Show("Phone number must be 10 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneUpdate.Clear();
                txtPhoneUpdate.Focus();
                return;
            }

            if (txtPhoneUpdate.Text.Length > 10 || txtPhoneUpdate.Text.Length < 10)
            {
                MessageBox.Show("Phone number must be 10 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneUpdate.Clear();
                txtPhoneUpdate.Focus();
                return;
            }

            if (txtPhoneUpdate.Text[0] != '0' || txtPhoneUpdate.Text[1] != '8')
            {
                MessageBox.Show("This is not a valid mobile phone number, A mobile phone number must begin with 08.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneUpdate.Clear();
                txtPhoneUpdate.Focus();
                return;
            }

            if (txtEmailUpdate.Text.EndsWith(".com") == false && txtEmailUpdate.Text.EndsWith(".ie") == false)
            {
                MessageBox.Show("This is not valid, An email must end with .ie or .com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailUpdate.Clear();
                txtEmailUpdate.Focus();
                return;
            }

            if (txtEmailUpdate.Text.Contains("@students.ittralee.ie") == false && txtEmailUpdate.Text.Contains("@gmail") == false &&
               txtEmailUpdate.Text.Contains("@yahoo") == false)
            {
                MessageBox.Show("This is not valid, An email must contain a domain name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailUpdate.Clear();
                txtEmailUpdate.Focus();
                return;
            }


            else
            {
                //instantiate the object variables
                theMember.setFname(txtFornameUpdate2.Text);
                theMember.setSname(txtSurnameUpdate2.Text);
                theMember.setEmail(txtEmailUpdate.Text);
                theMember.setPhone(txtPhoneUpdate.Text);

                //update data in database
                theMember.updateMember(txtForenameUpdate.Text, txtSurnameUpdate.Text);
                
                //confirmation message
                MessageBox.Show("Your details have been updated", "Account Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

                //Reset UI
                txtForenameUpdate.Clear();
                txtFornameUpdate2.Clear();
                txtSurnameUpdate.Clear();
                txtSurnameUpdate2.Clear();
                txtEmailUpdate.Clear(); 
                txtPhoneUpdate.Clear();
                txtForenameUpdate.Focus();
            }
        }

        
    }
}

