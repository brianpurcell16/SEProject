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
    public partial class BookClass : Form
    {

        Booking newBooking = new Booking();
        public BookClass()
        {
            InitializeComponent();
        }
        

        private void mnuBookBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {

            if (txtBookFname.Text.Equals(""))
            {
                MessageBox.Show("Forename must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookFname.Focus();
                return;
            }

            if (txtBookFname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Forename must not have a digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookFname.Clear();
                txtBookFname.Focus();
                return;
            }

            if (txtBookSname.Text.Equals(""))
            {
                MessageBox.Show("Surname must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookSname.Focus();
                return;
            }
            if (txtBookSname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Surname must not have a digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookSname.Clear();
                txtBookSname.Focus();
                return;
            }

            if (txtBookClassID.Text.Equals(""))
            {
                MessageBox.Show("ClassID must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookClassID.Focus();
                return;
            }

            if (txtBookClassID.Text.Any(char.IsDigit) == false)
            {
                MessageBox.Show("ClassID must be digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookClassID.Clear();
                txtBookClassID.Focus();
                return;
            }

              int MemID = newBooking.getMemberID(txtBookFname.Text, txtBookSname.Text);

            Booking aBooking = new Booking(Convert.ToInt32(Booking.getNextBookingID().ToString("000")),MemID,Convert.ToInt32(txtBookClassID.Text),DateTime.Now);

            if (newBooking.updatingAvailability(Convert.ToInt32(txtBookClassID.Text)) == 0)
            {
                MessageBox.Show("Class is full no spaces left","Error");
                return;
            }
            if(newBooking.removingPrice(txtBookFname.Text, txtBookSname.Text, Convert.ToInt32(txtBookClassID.Text)) == 0){
                MessageBox.Show("Not enough money in wallet, Add Funds first", "Error");
                return;

            }
            aBooking.addBooking(Convert.ToInt32(txtBookClassID.Text));
            MessageBox.Show("Class has been booked", "Booking", MessageBoxButtons.OK);
            txtBookClassID.Clear();
            txtBookFname.Clear();
            txtBookSname.Clear();
            
        }

        private void BookClass_Load(object sender, EventArgs e)
        {
            Booking.getActiveClasses(dgvBooking);
        }
    }
}
