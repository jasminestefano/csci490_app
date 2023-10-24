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
    public partial class Stations : Form
    {
        public Stations()
        {
            InitializeComponent();
        }

        private void Stations_Load(object sender, EventArgs e)
        {

            string connectionString = "Server=localhost;Database=train_station;User=root;Password=12345;";;
            string station_query = "SELECT * FROM Stations;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand station_command = new MySqlCommand(station_query, connection);

            // try to fill grid
            try
            {
                connection.Open();

                // fill grid with station info
                MySqlDataAdapter station_adapter = new MySqlDataAdapter(station_command);
                DataTable dataTable_station = new DataTable();
                station_adapter.Fill(dataTable_station);

                dataGridView1.DataSource = dataTable_station;




                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            schedule.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Train train = new Train();
            train.Show();
        }
    }
}
