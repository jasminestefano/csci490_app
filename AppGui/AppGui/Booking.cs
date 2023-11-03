using AppGui.Models;
using AppGui.Repository;
using AppGui.Services;
using MySql.Data.MySqlClient;
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
    public partial class Booking : Form
    {
        public static string firstName;
        public static string lastName;
        public static int trainNumber;
        public Booking()
        {
            InitializeComponent();
            string connectionString = "server=sql9.freesqldatabase.com;userid=sql9649325;password=N98B1iW8Gi;database=sql9649325";
            using (MySqlConnection c = new MySqlConnection(connectionString))
            {
                c.Open();

                var sql = "SELECT * FROM Trains";
                using (MySqlCommand cmd = new MySqlCommand(sql, c))
                {
                    var dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    comboBox.ValueMember = "TrainNumber";
                    comboBox.DisplayMember = "TrainNumber";
                    comboBox.DataSource = dt;
                }
            }
            string email = Login.email;
            CustomerServices customerServices = new CustomerServices();
            CustomerModel customerModel = new CustomerModel();
            List<CustomerModel> list = customerServices.GetCustomerInfo(email);
            foreach (CustomerModel model in list)
            {
                firstName = model.Firstname;
                lastName = model.Lastname;
            }

            var customerRepository = new CustomerRepository();
            string statement = "SELECT * from Booking where FirstName=@newFirst AND LastName = @newLast";
            var command = new MySqlCommand(statement);
            command.Parameters.AddWithValue("@newFirst", firstName);
            command.Parameters.AddWithValue("@newLast", lastName);
            command.Connection = customerRepository._connection;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt2;
            bookingInfo.DataSource = bindingSource;
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

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookBtn_Click(object sender, EventArgs e)
        {
            checkBooking.Text = "Ticket has been booked!";
            string email = Login.email;
            CustomerServices customerServices = new CustomerServices();
            CustomerModel customerModel = new CustomerModel();
            List<CustomerModel> list = customerServices.GetCustomerInfo(email);
            foreach(CustomerModel model in list)
            {
                firstName = model.Firstname;
                lastName = model.Lastname;
            }
            trainNumber = int.Parse(comboBox.Text);
            customerServices.bookTickets(firstName, lastName, trainNumber);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
