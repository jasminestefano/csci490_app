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
            if (!GetTrainById(schID))
            {
                // Handle the case where the schedule does not exist.
                // You might want to log this situation or throw an exception.
                return false;
            }

            SetAttributes(trID, staID, depttime, arrtime);

            string query = @"
            UPDATE TrainSchedules
            SET TrainID = @trID, 
                StationID = @staID,
                DepartureTime = @depttime, 
                ArrivalTime = @arrtime
            WHERE ScheduleID = @schID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@schID", schID);
                    cmd.Parameters.AddWithValue("@trID", trainID);
                    cmd.Parameters.AddWithValue("@staID", statID);
                    cmd.Parameters.AddWithValue("@depttime", deptTime);
                    cmd.Parameters.AddWithValue("@arrtime", arrTime);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (MySqlException ex)
                    {
                        // In a Windows Forms application, you might indeed show a message box.
                        // Consider logging the exception as well.
                        MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        private bool GetTrainById(int id)
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
                            schedID = reader.GetInt32("ScheduleID");
                            trainID = reader.GetInt32("TrainID");
                            statID = reader.GetInt32("StationID");
                            deptTime = reader.GetDateTime("DepartureTime");
                            arrTime = reader.GetDateTime("ArrivalTime");
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        private void SetAttributes(int trID, int staID, DateTime depttime, DateTime arrtime)
        {
            // The assumption here is that if the passed in value is 0 or DateTime.MinValue, no change is made.
            if (trID != 0 && trID != trainID)
            {
                trainID = trID;
            }

            if (staID != 0 && staID != statID)
            {
                statID = staID;
            }

            if (depttime != DateTime.MinValue && depttime != deptTime)
            {
                deptTime = depttime;
            }

            if (arrtime != DateTime.MinValue && arrtime != arrTime)
            {
                arrTime = arrtime;
            }
        }
    }
}
