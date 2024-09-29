using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequirmentsEngineering
{
    public partial class Yearly : Form
    {

        Booking year = new Booking();
        public Yearly()
        {
            InitializeComponent();
        }

        private void backYearly_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYearly_Click(object sender, EventArgs e)
        {

                MessageBox.Show("Generating Data", "Result", MessageBoxButtons.OK);
            
        }

        private void Yearly_Load(object sender, EventArgs e)
        {
           
            
        
        }

        private void btnyear_Click(object sender, EventArgs e)
        {
            year.genReport(cbmYear.Text, dgvyearly);
            

        }
    }
}
