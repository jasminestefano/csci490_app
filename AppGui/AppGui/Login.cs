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
            //emailTextbox.GotFocus += emailTextBox_GotFocus;
            //emailTextbox.LostFocus += emailTextBox_LostFocus;


            passTextBox.Text = defaultPassBox;
            passTextBox.ForeColor = System.Drawing.Color.Gray;
            //passTextBox.GotFocus += txtPassword_GotFocus;
            //passTextBox.LostFocus += txtPassword_LostFocus;
            displayIncorrect.Text = "Testing";
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
                displayIncorrect.Text = "Correct Login";
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
    }
}
