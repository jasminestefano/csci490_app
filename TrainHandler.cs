using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


    }
}
