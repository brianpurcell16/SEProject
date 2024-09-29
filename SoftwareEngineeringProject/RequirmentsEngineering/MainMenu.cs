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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void mnuMainMenuRegisterMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterMember nextForm = new RegisterMember();
            nextForm.ShowDialog();
            this.Show();
        }

        private void mnuMainMenuUpdateMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateMember nextForm = new UpdateMember();
            nextForm.ShowDialog();
            this.Show();
        }

        private void mnuMainMenuCancelMembership_Click(object sender, EventArgs e)
        {
            this.Hide();
            CloseMembership nextForm = new CloseMembership();
            nextForm.ShowDialog();
            this.Show();
        }

        private void mnuMainMenuRenewMembership_Click(object sender, EventArgs e)
        {
            this.Hide();
            RenewMember nextForm = new RenewMember();
            nextForm.ShowDialog();
            this.Show();
        }

        private void mnuMainMenuAddFunds_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFunds nextForm = new AddFunds();
            nextForm.ShowDialog();
            this.Show();
        }

        private void mnuMainMenuScheduleClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleClass nextForm = new ScheduleClass();
            nextForm.ShowDialog();
            this.Show();
        }

        private void mnuMainMenuCancelClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            CancelClass nextForm = new CancelClass();
            nextForm.ShowDialog();
            this.Show();
        }

        private void mnuMainMenuBookClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookClass nextForm = new BookClass();
            nextForm.ShowDialog();
            this.Show();
        }

        private void mnuMainMenuCancelBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            CancelBooking nextForm = new CancelBooking();
            nextForm.ShowDialog();
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuMainMenuGenerateRevenue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Yearly nextForm = new Yearly();
            nextForm.ShowDialog();
            this.Show();
        }

        
    }
}
