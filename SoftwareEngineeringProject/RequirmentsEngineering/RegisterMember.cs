using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace RequirmentsEngineering
{
    public partial class RegisterMember : Form
    {

        OracleConnection con = new OracleConnection(DBConnect.oraDB);

       
        public RegisterMember()
        {
            InitializeComponent();
        }



        private void mnuRegisterBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void SubmitCreate_Click(object sender, EventArgs e)
        {


            if (txtRegisterFname.Text.Equals(""))
            {
                MessageBox.Show("Forename must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterFname.Focus();
                return;
            }

            if (txtRegisterFname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Forename must not have a digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterFname.Clear();
                txtRegisterFname.Focus();
                return;
            }

            if (txtRegisterSname.Text.Equals(""))
            {
                MessageBox.Show("Surname must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterSname.Focus();
                return;
            }
            if (txtRegisterSname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Surname must not have a digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterSname.Clear();
                txtRegisterSname.Focus();
                return;
            }

            if (txtRegisterPhone.Text.Equals(""))
            {
                MessageBox.Show("Phone number must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterPhone.Focus();
                return;
            }

            if (txtRegisterPhone.Text.Any(char.IsDigit) == false)
            {
                MessageBox.Show("Phone number must be 10 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterPhone.Clear();
                txtRegisterPhone.Focus();
                return;
            }

            if (txtRegisterPhone.Text.Length > 10 || txtRegisterPhone.Text.Length < 10)
            {
                MessageBox.Show("Phone number must be 10 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterPhone.Clear();
                txtRegisterPhone.Focus();
                return;
            }

            if (txtRegisterPhone.Text[0] != '0' || txtRegisterPhone.Text[1] != '8')
            {
                MessageBox.Show("This is not a valid mobile phone number, A mobile phone number must begin with 08.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterPhone.Clear();
                txtRegisterPhone.Focus();
                return;
            }

            if (txtRegisterEmail.Text.EndsWith(".com") == false && txtRegisterEmail.Text.EndsWith(".ie") == false)
            {
                MessageBox.Show("This is not valid, An email must end with .ie or .com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterEmail.Clear();
                txtRegisterEmail.Focus();
                return;
            }

            if (txtRegisterEmail.Text.Contains("@students.ittralee.ie") == false && txtRegisterEmail.Text.Contains("@gmail") == false &&
               txtRegisterEmail.Text.Contains("@yahoo") == false)
            {
                MessageBox.Show("This is not valid, An email must contain a domain name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterEmail.Clear();
                txtRegisterEmail.Focus();
                return;
            }

            if(dtpRegister.Value > DateTime.Today.AddYears(-16))
            {
                MessageBox.Show("Invalid date of birth entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterPhone.Focus();
                return;
            }

            
            else
            {

                //Create an instance of Member and instansiate with values from the form
                Member aMember = new Member(Convert.ToInt32(Member.getNextMemID().ToString("000")), txtRegisterFname.Text, txtRegisterSname.Text, dtpRegister.Value, txtRegisterEmail.Text, txtRegisterPhone.Text);

                //invoke method to add to Members table
                aMember.addMember();

                //display confirmation message
                MessageBox.Show("Thank you for registering", "Account opened", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //reset UI
                txtRegisterFname.Clear();
                txtRegisterSname.Clear();
                txtRegisterEmail.Clear();
                txtRegisterPhone.Clear();
                dtpRegister.ResetText();
                txtRegisterFname.Focus();


            }

            





        }

        private void mnuRegMemBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterMember_Load(object sender, EventArgs e)
        {
            dtpRegister.MaxDate = DateTime.Today.AddYears(-16);
        }
    }
}

    

