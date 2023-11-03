using AppGui.Models;
using AppGui.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppGui
{
    public partial class SettingMenu : Form
    {
        public SettingMenu()
        {
            InitializeComponent();
            CustomerServices customerServices = new CustomerServices();
            CustomerModel customerModel = new CustomerModel();
            string email = Login.email;
            List<CustomerModel> list = customerServices.GetCustomerInfo(email);
            foreach (CustomerModel model in list)
            {
                FirstNameChange.Text = model.Firstname;
                LastNameChange.Text = model.Lastname;
                PasswordChange.Text = model.password;
            }
            EmailChange.Text = Login.email;
           

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

        private void updateInfo_Click(object sender, EventArgs e)
        {
            string firstname = FirstNameChange.Text;
            string lastname = LastNameChange.Text;
            string password = PasswordChange.Text;  
            string email = EmailChange.Text;
            string target = Login.email;
            CustomerServices customerServices = new CustomerServices();
            customerServices.updateInformation(firstname,lastname,password,email,target);
            checkUpdate.Text = "Updated!";
        }
    }
}
