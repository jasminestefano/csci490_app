using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MainProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=train_station;User=root;Password=12345;";
            string schedule_query = "SELECT * FROM TrainSchedules;";
            string train_query = "SELECT * FROM Trains;";
            string station_query = "SELECT * FROM Stations";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand schedule_command = new MySqlCommand(schedule_query, connection);
            MySqlCommand train_command = new MySqlCommand(train_query, connection);
            MySqlCommand station_command = new MySqlCommand(station_query, connection);

            // try to fill grid
            try
            {
                connection.Open();

                // fill grid with schedule info
                MySqlDataAdapter schedule_adapter = new MySqlDataAdapter(schedule_command);
                DataTable dataTable_schedule = new DataTable();
                schedule_adapter.Fill(dataTable_schedule);

                dataGridView1.DataSource = dataTable_schedule;


                // fill grid with train info
                MySqlDataAdapter train_adapter = new MySqlDataAdapter(train_command);
                DataTable dataTable_trains = new DataTable();
                train_adapter.Fill(dataTable_trains);

                dataGridView2.DataSource = dataTable_trains;

                // fill grid with station info
                MySqlDataAdapter station_adapter = new MySqlDataAdapter(station_command);
                DataTable dataTable_station = new DataTable();
                station_adapter.Fill(dataTable_station);

                dataGridView3.DataSource = dataTable_station;




                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            return;
        }

    }
}
