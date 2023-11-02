using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGui
{
    public partial class SettingMenu : Form
    {
        public SettingMenu()
        {
            InitializeComponent();
        }

        private void viewScheduleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeMenu homeMenu = new HomeMenu();
            homeMenu.Show();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingMenu settingMenu = new SettingMenu();
            settingMenu.Show();
        }

        private void lotOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void bookTicketBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking booking = new Booking();
            booking.Show();
        }
    }
}
