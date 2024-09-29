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
    public partial class ScheduleClass : Form
    {
        public ScheduleClass()
        {
            InitializeComponent();
        }

        private void mnuShecduleBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {

            

            if (txtTitleSchedule.Text.Equals(""))
            {
                MessageBox.Show("Title must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitleSchedule.Focus();
                return;
            }

            if (txtTitleSchedule.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Title must not have a digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitleSchedule.Clear();
                txtTitleSchedule.Focus();
                return;
            }

            if (txtPriceSchedule.Text.Equals(""))
            {
                MessageBox.Show("Price must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPriceSchedule.Focus();
                return;
            }

            if (txtPriceSchedule.Text.Any(char.IsDigit) == false)
            {
                MessageBox.Show("Price must be numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPriceSchedule.Clear();
                txtPriceSchedule.Focus();
                return;
            }

           int conPrice = Convert.ToInt32(txtPriceSchedule.Text);

            if (conPrice > 100) {
                MessageBox.Show("Price must be less than 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPriceSchedule.Clear();
                txtPriceSchedule.Focus();
                return;
            }

            if (txtCapacitySchedule.Text.Equals(""))
            {
                MessageBox.Show("Capacity must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCapacitySchedule.Focus();
                return;
            }

            if (txtCapacitySchedule.Text.Any(char.IsDigit) == false)
            {
                MessageBox.Show("Capacity must be numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCapacitySchedule.Clear();
                txtCapacitySchedule.Focus();
                return;
            }

            int conCapacity = Convert.ToInt32(txtCapacitySchedule.Text);

            if (conCapacity > 100)
            {
                MessageBox.Show("Capacity must be less than 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCapacitySchedule.Clear();
                txtCapacitySchedule.Focus();
                return;
            }

            if (dtpSchedule.Value<DateTime.Today)
            {
                MessageBox.Show("Invalid Date, date has to be after today", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpSchedule.Focus();
                return;
            }

            if(cmbTime.SelectedIndex == -1)
            {
                MessageBox.Show("Invalid, A time must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbTime.Focus();
                return;

            }


            else
            {

                Classes aClass = new Classes(Convert.ToInt32(Classes.getNextClassID().ToString("000")),txtTitleSchedule.Text,Convert.ToInt32(txtPriceSchedule.Text),cmbTime.Text,dtpSchedule.Value, Convert.ToInt32(txtCapacitySchedule.Text), Convert.ToInt32(txtCapacitySchedule.Text));

                aClass.addClass();

                MessageBox.Show("Class Added", "Well Done", MessageBoxButtons.OK);
                txtCapacitySchedule.Clear();
                txtPriceSchedule.Clear();
                txtTitleSchedule.Clear();
                cmbTime.SelectedIndex = -1;
                dtpSchedule.Value = DateTime.Today.AddDays(1);
            }

        }

        private void ScheduleClass_Load(object sender, EventArgs e)
        {
            dtpSchedule.MinDate = DateTime.Today.AddDays(1);
        }
    }
}
