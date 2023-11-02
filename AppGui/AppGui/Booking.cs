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

namespace AppGui
{
    public partial class Booking : Form
    {
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
    }
}
