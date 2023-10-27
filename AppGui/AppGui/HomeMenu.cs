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
                string query = "SELECT * from Passengers";
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
    }
}
