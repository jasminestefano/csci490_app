using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjFinal
{
    internal class TrainHandler
    {
        private int trainID = 0;
        private string trainNo = null;
        private int deptStaID = 0;
        private int arrStaID = 0;
        private DateTime deptTime;
        private DateTime arrTime;
        public string connectionString = "Server=localhost;Database=train_station;User=root;Password=12345;";


        public bool setTrain(int trainID, string trainno, int dept, int arr, DateTime depttime, DateTime arrtime)
        {

            if (trainno == null)
            {
                return false;
            }

            if (trainID == 0)
            {
                return false;
            }

            if (dept == 0)
            {
                return false;
            }

            if (arr == 0)
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

            this.trainID = trainID;
            this.trainNo = trainno;
            this.deptStaID = dept;
            this.arrStaID = arr;
            this.deptTime = depttime;
            this.arrTime = arrtime;

            return true;
        }

        public bool add_Train()
        {
            int affectedRows = 0; 

            string query = "INSERT INTO trains VALUES (@TrainId, @TrainNumber, @DepartureStationID, @ArrivalStationID, @DepartureTime, @ArrivalTime);";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.Add("@TrainId", MySqlDbType.Int32).Value = this.trainID;
                command.Parameters.Add("@TrainNumber", MySqlDbType.VarChar).Value = this.trainNo;
                command.Parameters.Add("@DepartureStationID", MySqlDbType.Int32).Value = this.deptStaID;
                command.Parameters.Add("@ArrivalStationID", MySqlDbType.Int32).Value = this.arrStaID;
                command.Parameters.Add("@DepartureTime", MySqlDbType.DateTime).Value = this.deptTime;
                command.Parameters.Add("@ArrivalTime", MySqlDbType.DateTime).Value = this.arrTime;

                affectedRows = command.ExecuteNonQuery(); 

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  // Log the exception or handle it accordingly
            }
            return affectedRows > 0;
        }

        public bool delete_Train(int id)
        {
            int rowsAffected = 0;
            string query = "DELETE FROM trains WHERE TrainId = @TrainId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Assuming your column value is a string
                    cmd.Parameters.AddWithValue("@TrainId", id);

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
            string train_query = "SELECT * FROM Trains;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand train_command = new MySqlCommand(train_query, connection);

            // try to fill grid
            try
            {
                connection.Open();

                // fill grid with train info
                MySqlDataAdapter train_adapter = new MySqlDataAdapter(train_command);
                DataTable dataTable_trains = new DataTable();
                train_adapter.Fill(dataTable_trains);

                dataGridView.DataSource = dataTable_trains;


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        public bool updateTrain(int trainid, string trainno, int dept, int arr, DateTime depttime, DateTime arrtime)
        {
            int rowsAffected = 0;
            string query = "UPDATE Trains " +
                "SET TrainNumber = @trainno, " +
                "DepartureStationID = @dept, " +
                "ArrivalStationID = @arr," +
                "DepartureTime = @depttime, " +
                "ArrivalTime = @arrtime " +
                "WHERE TrainID = @trainID";

            GetTrainById(trainid);
            set_Attr(trainno, dept, arr, depttime, arrtime);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@trainID", this.trainID);
                    cmd.Parameters.AddWithValue("@trainno", this.trainNo);
                    cmd.Parameters.AddWithValue("@dept", this.deptStaID);
                    cmd.Parameters.AddWithValue("@arr", this.arrStaID);
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
                            this.trainID = reader.GetInt32("TrainId");
                            this.trainNo = reader.GetString("TrainNumber");
                            this.deptStaID = reader.GetInt32("DepartureStationID");
                            this.arrStaID = reader.GetInt32("ArrivalStationID");
                            this.deptTime = reader.GetDateTime("DepartureTime");
                            this.arrTime = reader.GetDateTime("ArrivalTime");
                        }
                    }
                }
            }
        }

        public void set_Attr(string trainno, int dept, int arr, DateTime depttime, DateTime arrtime)
        {
            if (!string.IsNullOrEmpty(trainno) && !trainno.Equals(this.trainNo, StringComparison.Ordinal))
            {
                this.trainNo = trainno;
                Console.WriteLine("number diff");
            }

            if (dept != 0 && dept != this.deptStaID) // Assuming dept is non-negative. Adjust condition as necessary.
            {
                this.deptStaID = dept;
                Console.WriteLine("dept diff");
            }

            if (arr != 0 && arr != this.arrStaID) // Assuming arr is non-negative. Adjust condition as necessary.
            {
                this.arrStaID = arr;
                Console.WriteLine("arr diff");
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
