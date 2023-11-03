using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGui.Services;
namespace AppGui
{
    public partial class CreateMenu : Form
    {
        public static string firstName;
        public static string lastName;
        public static string email;
        public static string password;
        CustomerServices customerServices = new CustomerServices();

        
        public CreateMenu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EnterFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            firstName= EnterFirstName.Text;
            lastName= EnterLastName.Text;
            email= EnterEmail.Text;
            password= EnterPassword.Text;

            bool validateEmail = customerServices.validateEmail(email);
            bool validatePassword = customerServices.validatePassword(password);
            if(validateEmail && validatePassword) {
                customerServices.registerAccount(firstName, lastName,email,password);
                this.Hide();
                Login l = new Login();
                l.Show();
                //testing
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
