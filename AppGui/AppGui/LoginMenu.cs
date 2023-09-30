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
    public partial class LoginMenu : Form
    {
        public static string email;
        public static string password;
        private string defaultEmailBox = "Email";
        private string defaultPassBox = "Password";
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
