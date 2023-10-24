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

namespace ProjFinal
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=train_station;User=root;Password=12345;";
            string schedule_query = "SELECT * FROM TrainSchedules;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand schedule_command = new MySqlCommand(schedule_query, connection);

            // try to fill grid
            try
            {
                connection.Open();

                // fill grid with schedule info
                MySqlDataAdapter schedule_adapter = new MySqlDataAdapter(schedule_command);
                DataTable dataTable_schedule = new DataTable();
                schedule_adapter.Fill(dataTable_schedule);

                dataGridView1.DataSource = dataTable_schedule;


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Train train = new Train();
            train.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Stations stations = new Stations();
            stations.Show();
        }


    }
}
