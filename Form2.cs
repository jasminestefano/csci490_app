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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MainProj;
using System.CodeDom;
using System.Reflection;


namespace MainProj
{
    public partial class Form2 : Form
    {

        private int trainID = 0;
        private string trainNo = null;
        private int deptStaID = 0;
        private int arrStaID = 0;
        private DateTime deptTime;
        private DateTime arrTime;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        public static bool AreAllAttributesDefault<T>(T obj)
        {
            foreach (var prop in typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                var value = prop.GetValue(obj);
                if (value != null)
                {
                    if (value is int intValue && intValue != 0) return false;
                    if (value is double doubleValue && doubleValue != 0) return false;
                    // Add checks for other numeric types if needed.
                    if (!(value is ValueType)) return false;
                }
            }

            foreach (var field in typeof(T).GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                var value = field.GetValue(obj);
                if (value != null)
                {
                    if (value is int intValue && intValue != 0) return false;
                    if (value is double doubleValue && doubleValue != 0) return false;
                    // Add checks for other numeric types if needed.
                    if (!(value is ValueType)) return false;
                }
            }

            return true;
        }


    private void createTrain_TrainIDtb_TextChanged(object sender, EventArgs e)
        {

            try
            {
                trainID = int.Parse(createTrain_TrainIDtb.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("The string is not a valid integer.");
            }
        }

        private void createTrain_TrainNotb_TextChanged(object sender, EventArgs e)
        {
            trainNo = createTrain_TrainNotb.Text;


        }

        private void createTrain_DeptStaIDtb_TextChanged(object sender, EventArgs e)
        {

            try
            {
                deptStaID = int.Parse(createTrain_DeptStaIDtb.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("The string is not a valid integer.");
            }


        }

        private void createTrain_ArrStaIDtb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                arrStaID = int.Parse(createTrain_ArrStaIDtb.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("The string is not a valid integer.");
            }


        }

        private void createTrain_DeptTimetb_TextChanged(object sender, EventArgs e)
        {

            deptTime = DateTime.Parse(createTrain_DeptTimetb.Text);

        }

        private void createTrain_ArrTimetb_TextChanged(object sender, EventArgs e)
        {

            arrTime = DateTime.Parse(createTrain_ArrTimetb.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = "Server=localhost;Database=train_station;User=root;Password=12345;";
            string query = "INSERT INTO trains VALUES (@TrainId, @TrainNumber, @DepartureStationID, @ArrivalStationID, @DepartureTime, @ArrivalTime);";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);


            Train new_train = new Train();
            new_train.TrainId = trainID;
            new_train.TrainNumber = trainNo;
            new_train.DepartureStationID = deptStaID;
            new_train.ArrivalStationID = arrStaID;
            new_train.DepartureTime = deptTime;
            new_train.ArrivalTime = arrTime;

            try
            {
                connection.Open();

                if (!AreAllAttributesDefault(new_train))
                {
                    new_train.add_Train(command);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  // Log the exception or handle it accordingly
            }




        }
    }
}
/*
private List<string> GetMenuItems()
{
    string connectionString = "Server=localhost;Database=train_station;User=root;Password=12345;";
    string query = "SELECT * FROM Stations;";

    List<string> items = new List<string>();

    MySqlConnection connection = new MySqlConnection(connectionString);
    MySqlCommand command = new MySqlCommand(query, connection);

    try
    {
        connection.Open();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    items.Add(reader["StationID"].ToString());
                }
            }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error: {ex.Message}");
    }

    return items;
} */