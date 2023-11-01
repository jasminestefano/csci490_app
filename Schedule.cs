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
        int schedID;
        int trainID;
        int statID;
        DateTime arrTime;
        DateTime deptTime;

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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Train train = new Train();
            train.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Stations stations = new Stations();
            stations.Show();
            this.Close();
        }

        //
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                schedID = int.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("The string is not a valid integer.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                trainID = int.Parse(textBox2.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("The string is not a valid integer.");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            

            try
            {
                statID = int.Parse(textBox3.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("The string is not a valid integer.");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            deptTime = DateTime.Parse(textBox5.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            arrTime = DateTime.Parse(textBox4.Text);
        }

        //add button
        private void button1_Click(object sender, EventArgs e)
        {
            bool filled_out = false;
            bool succ = false;

            ScheduleHandler handler = new ScheduleHandler();
            filled_out = handler.setSchedule(schedID, trainID, statID, deptTime, arrTime);

            if (filled_out)
            {
                succ = handler.add_Schedule();
                if (!succ)
                {
                    Console.WriteLine("add didnt work!!");
                }
                else
                {
                    handler.set_Table(dataGridView1);
                    Console.WriteLine("add worked!!");
                }
            }
        }
        //update button
        private void button2_Click(object sender, EventArgs e)
        {

            bool succ = false;
            ScheduleHandler handler = new ScheduleHandler();
            succ = handler.updateSchedule(schedID, trainID, statID, deptTime, arrTime);
            if (succ)
            {
                Console.WriteLine("update success");
                handler.set_Table(dataGridView1);

            }
            else
            {
                Console.WriteLine("update not success");
            }
        }
        //delete button
        private void button3_Click_1(object sender, EventArgs e)
        {
            bool succ = false;
            ScheduleHandler handler = new ScheduleHandler();

            succ = handler.delete_Schedule(schedID);
            if (succ)
            {
                Console.WriteLine("delete success");
                handler.set_Table(dataGridView1);
            }
            else
            {
                Console.WriteLine("delete not success");
            }

        }
    }
}
