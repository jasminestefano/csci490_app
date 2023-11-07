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
        int statID = 0;
        string stationName = null;
        string location = null;

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
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Train train = new Train();
            train.Show();
            this.Close();
        }

        private void statIDTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                statID = int.Parse(statIDTB.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("The string is not a valid integer.");
            }
        }

        private void statNameTB_TextChanged(object sender, EventArgs e)
        {
            stationName = statNameTB.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            location = textBox3.Text;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool filled_out = false;
            bool succ = false;
            StationHandler handler = new StationHandler();
            filled_out = handler.setStation(statID, stationName, location);

            if (filled_out)
            {
                Console.WriteLine("its filled out");
                succ = handler.add_Station();
                if (succ)
                {
                    Console.WriteLine("add success");
                    handler.set_Table(dataGridView1);
                }
                else
                {
                    Console.WriteLine("add fail");
                }

            }
            else
            {
                Console.WriteLine("not filled out");
            }



        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            bool succ = false;
            StationHandler trainHandler = new StationHandler();
            succ = trainHandler.updateStation(statID, stationName, location);
            if (succ)
            {
                Console.WriteLine("update success");
                trainHandler.set_Table(dataGridView1);

            }
            else
            {
                Console.WriteLine("update not success");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool succ = false;
            StationHandler trainHandler = new StationHandler();

            succ = trainHandler.delete_Station(statID);
            if (succ)
            {
                Console.WriteLine("delete success");
                trainHandler.set_Table(dataGridView1);
            }
            else
            {
                Console.WriteLine("delete not success");
            }
        }
    }
}
