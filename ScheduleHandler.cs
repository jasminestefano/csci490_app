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
    internal class ScheduleHandler
    {
        private int schedID = 0;
        private int trainID = 0;
        private int statID = 0;
        private DateTime deptTime;
        private DateTime arrTime;
        public string connectionString = "Server=localhost;Database=train_station;User=root;Password=12345;";


        public bool setSchedule(int schID, int trID, int staID, DateTime depttime, DateTime arrtime)
        {

            if (schID == 0)
            {
                return false;
            }

            if (trID == 0)
            {
                return false;
            }

            if (staID == 0)
            {
                return false;
            }

            if (depttime == DateTime.MinValue)
            {
                return false;
            }

            if (arrtime == DateTime.MinValue)
            {
                return false;
            }

            this.schedID = schID;
            this.trainID = trID;
            this.statID = staID;
            this.deptTime = depttime;
            this.arrTime = arrtime;

            return true;
        }

        public bool add_Schedule()
        {
            int affectedRows = 0;

            string query = "INSERT INTO TrainSchedules VALUES (@schedID, @trainID, @statID, @deptTime, @arrTime);";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.Add("@schedID", MySqlDbType.Int32).Value = this.schedID;
                command.Parameters.Add("@trainID", MySqlDbType.Int32).Value = this.trainID;
                command.Parameters.Add("@statID", MySqlDbType.Int32).Value = this.statID;
                command.Parameters.Add("@depttime", MySqlDbType.DateTime).Value = this.deptTime;
                command.Parameters.Add("@arrTime", MySqlDbType.DateTime).Value = this.arrTime;

                affectedRows = command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  // Log the exception or handle it accordingly
            }
            return affectedRows > 0;
        }

        public bool delete_Schedule(int id)
        {
            int rowsAffected = 0;
            string query = "DELETE FROM TrainSchedules WHERE ScheduleID = @id";

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
            string query = "SELECT * FROM TrainSchedules;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            // try to fill grid
            try
            {
                connection.Open();

                // fill grid with train info
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable= new DataTable();
                adapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        public bool updateSchedule(int schID, int trID, int staID, DateTime depttime, DateTime arrtime)
        {
            int rowsAffected = 0;
            string query = "UPDATE TrainSchedules " +
                "SET ScheduleID = @schID, " +
                "TrainID = @trID, " +
                "StationID = @staID," +
                "ArrivalTime = @depttime, " +
                "DepartureTime = @arrtime " +
                "WHERE ScheduleID = @schID";

            GetTrainById(schID);
            set_Attr(trID, staID, depttime, arrtime);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@schID", this.schedID);
                    cmd.Parameters.AddWithValue("@trID", this.trainID);
                    cmd.Parameters.AddWithValue("@staID", this.statID);
                    cmd.Parameters.AddWithValue("@depttime", this.deptTime);
                    cmd.Parameters.AddWithValue("@arrtime", this.arrTime);

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

        public void GetTrainById(int id)
        {
            string query = "SELECT * FROM TrainSchedules WHERE ScheduleID = @id";
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
                            this.statID = reader.GetInt32("ScheduleID");
                            this.trainID = reader.GetInt32("TrainID");
                            this.statID = reader.GetInt32("StationID");
                            this.deptTime = reader.GetDateTime("DepartureTime");
                            this.arrTime = reader.GetDateTime("ArrivalTime");
                        }
                    }
                }
            }
        }

        public void set_Attr(int trID, int staID, DateTime depttime, DateTime arrtime)
        {

            if (trID != 0 && trID != this.trainID) // Assuming dept is non-negative. Adjust condition as necessary.
            {
                this.trainID = trID;
                Console.WriteLine("train id diff");
            }

            if (staID != 0 && staID != this.statID) // Assuming arr is non-negative. Adjust condition as necessary.
            {
                this.statID = staID;
                Console.WriteLine("station id diff");
            }

            if (depttime != this.deptTime && depttime != DateTime.MinValue)
            {
                this.deptTime = depttime;
                Console.WriteLine("time diff");
            }

            if (arrtime != this.arrTime && arrtime != DateTime.MinValue)
            {
                this.arrTime = arrtime;
                Console.WriteLine("time diff");
            }
        }
    }
}
