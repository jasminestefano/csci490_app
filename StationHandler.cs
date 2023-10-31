using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjFinal
{
    internal class StationHandler
    {
        int statID = 0;
        string stationName = null;
        string location = null;

        public string connectionString = "Server=localhost;Database=train_station;User=root;Password=12345;";

        public bool setStation(int stID, string stName, string loc)
        {

            if (stID == 0)
            {
                return false;
            }

            if (stName == null)
            {
                return false;
            }

            if (loc == null)
            {
                return false;
            }

            this.statID = stID;
            this.stationName = stName;
            this.location = loc;


            return true;
        }

        public bool add_Station()
        {
            int affectedRows = 0;

            string query = "INSERT INTO Stations VALUES (@statID, @name, @location);";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.Add("@statID", MySqlDbType.Int32).Value = this.statID;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = this.stationName;
                command.Parameters.Add("@location", MySqlDbType.VarChar).Value = this.location;

                affectedRows = command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  // Log the exception or handle it accordingly
            }
            return affectedRows > 0;
        }

        public bool delete_Station(int id)
        {
            int rowsAffected = 0;
            string query = "DELETE FROM Stations WHERE StationID = @id";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Assuming your column value is a string
                    cmd.Parameters.AddWithValue("@id", id);

                    try
                    {
                        rowsAffected = cmd.ExecuteNonQuery();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                    return rowsAffected > 0;
                }
            }
        }

        public void set_Table(DataGridView dataGridView)
        {
            string train_query = "SELECT * FROM Stations;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand station_command = new MySqlCommand(train_query, connection);

            // try to fill grid
            try
            {
                connection.Open();

                // fill grid with train info
                MySqlDataAdapter adapter = new MySqlDataAdapter(station_command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        public bool updateStation(int id, string name, string loc)
        {
            int rowsAffected = 0;
            string query = "UPDATE Stations " +
                "SET StationID = @id, " +
                "StationName = @name, " +
                "Location = @loc" +
                "WHERE TrainID = @trainID";

            GetStationById(id);
            set_Attr(name, loc);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", this.statID);
                    cmd.Parameters.AddWithValue("@name", this.stationName);
                    cmd.Parameters.AddWithValue("@loc", this.location);


                    try
                    {
                        rowsAffected = cmd.ExecuteNonQuery();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                    return rowsAffected > 0;
                }
            }
        }

        public void GetStationById(int id)
        {
            string query = "SELECT * FROM trains WHERE TrainId = @id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            this.statID = reader.GetInt32("StationID");
                            this.stationName = reader.GetString("StationName");
                            this.location = reader.GetString("Location");
                        }
                    }
                }
            }
        }

        public void set_Attr(string name, string loc)
        {
            if (!string.IsNullOrEmpty(name) && !name.Equals(this.stationName, StringComparison.Ordinal))
            {
                this.stationName = name;
                Console.WriteLine("name diff");
            }

            if (!string.IsNullOrEmpty(loc) && !loc.Equals(this.location, StringComparison.Ordinal))
            {
                this.location = loc;
                Console.WriteLine("location diff");
            }
        }

    }
}
