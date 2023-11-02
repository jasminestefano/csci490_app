using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGui;
using AppGui.Repository;
using AppGui.Services;
using AppGui.Models;
using MySql.Data.MySqlClient;

namespace AppGui
{
    public partial class HomeMenu : Form
    {
        public HomeMenu()
        {
            InitializeComponent();
        }

        private void HomeMenu_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
                var customerRepository = new CustomerRepository();
                string query = "SELECT * from Trains";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = customerRepository._connection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                infoList.DataSource = bindingSource;
                
         
        }

        private void infoList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookTicketBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking booking = new Booking();
            booking.Show();
        }

        private void viewScheduleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeMenu homeMenu = new HomeMenu();
            homeMenu.Show();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingMenu settingMenu = new SettingMenu();
            settingMenu.Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
