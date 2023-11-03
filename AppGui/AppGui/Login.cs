using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AppGui;
using AppGui.Repository;
using AppGui.Services;
using AppGui.Models;
namespace AppGui
{
    public partial class Login : Form
    {
        public static string email;
        public static string password;
        private string defaultEmailBox = "Email";
        private string defaultPassBox = "Password";
        public Login()
        {
            InitializeComponent();
            emailTextbox.Text = defaultEmailBox;
            emailTextbox.ForeColor = System.Drawing.Color.Gray;
            emailTextbox.GotFocus += txtEmail_GotFocus;
            emailTextbox.LostFocus += txtEmail_LostFocus;


            passTextBox.Text = defaultPassBox;
            passTextBox.ForeColor = System.Drawing.Color.Gray;
            passTextBox.GotFocus += txtPassword_GotFocus;
            passTextBox.LostFocus += txtPassword_LostFocus;
            /*
            exitBtn.BackColor = Color.Transparent;
            exitBtn.MouseEnter += button1_MouseEnter;
            exitBtn.MouseLeave += button1_MouseLeave;

            exitBtn.FlatAppearance.BorderSize = 0;
            */

        }

        public static bool validateLogin(string email, string password)
        {
            CustomerRepository customerRepo = new CustomerRepository();
            CustomerServices services = new CustomerServices();
            bool validation = services.validateLogin(email, password);
            return validation;
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateMenu createMenu = new CreateMenu();
            createMenu.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
     
       
            email = emailTextbox.Text;
            password = passTextBox.Text;

            bool validate = validateLogin(email, password);
            if (validate)
            {
               
                this.Hide();
                HomeMenu h = new HomeMenu();
                h.Show();
            }
            else
            {
                displayIncorrect.Text = "Incorrect Login";
                emailTextbox.Text = "";
                passTextBox.Text = "";
            }

        }
        private void txtPassword_GotFocus(object sender, EventArgs e)
        {
            if (passTextBox.Text == defaultPassBox)
            {
                passTextBox.Text = "";
                passTextBox.PasswordChar = '*';
                passTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void txtPassword_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passTextBox.Text))
            {
                passTextBox.Text = defaultPassBox;
                passTextBox.PasswordChar = '\u0000';
                passTextBox.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void txtEmail_GotFocus(object sender, EventArgs e)
        {
            if (emailTextbox.Text == defaultEmailBox)
            {
                emailTextbox.Text = "";
                emailTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void txtEmail_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextbox.Text))
            {
                emailTextbox.Text = defaultEmailBox;
                emailTextbox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void displayIncorrect_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
