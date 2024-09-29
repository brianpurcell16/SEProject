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
    public partial class CancelBooking : Form
    {

        Booking cancelBooking = new Booking();
        public CancelBooking()
        {
            InitializeComponent();
        }

        private void mnuCancelBookBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnCancelBook_Click(object sender, EventArgs e)
        {

           
                
                cancelBooking.cancelBooking(Convert.ToInt32(txtBookingIDCancelBook.Text));

                MessageBox.Show("Booking has been cancelled", "Cancellation", MessageBoxButtons.OK);
                txtCancelBookingID.Clear();
                txtMemIDCancelBooking.Clear();
                txtClassIDCancelBooking.Clear();
                dtpCancelBook.Value = DateTime.Today;
                Booking.activeBookings(dgvCancelBooking);


        }

        private void CancelBooking_Load(object sender, EventArgs e)
        {
            Booking.activeBookings(dgvCancelBooking);
            txtCancelBookingID.Enabled = false;
            txtMemIDCancelBooking.Enabled = false;
            txtClassIDCancelBooking.Enabled = false;
            dtpCancelBook.Enabled = false;
        }

        private void btnCancelBookingsDetails_Click(object sender, EventArgs e)
        {
            if (txtBookingIDCancelBook.Text.Any(char.IsDigit) == false)
            {
                MessageBox.Show("Booking ID must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                cancelBooking.getBookingDetails(Convert.ToInt32(txtBookingIDCancelBook.Text));
              

                    txtCancelBookingID.Text = cancelBooking.getBookingID().ToString();
                    txtClassIDCancelBooking.Text = cancelBooking.getClassID().ToString();
                    txtMemIDCancelBooking.Text = cancelBooking.getMemID().ToString();
                    dtpCancelBook.Value = cancelBooking.getDateBooked();

                
               
            }
        }
    }
}
