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
    public partial class Train : Form
    {
        private int trainID = 0;
        private string trainNo = null;
        private int deptStaID = 0;
        private int arrStaID = 0;
        private DateTime deptTime;
        private DateTime arrTime;
        public Train()
        {
            InitializeComponent();
        }

        private void Train_Load(object sender, EventArgs e)
        {
            TrainHandler trainHandler = new TrainHandler();
            trainHandler.set_Table(dataGridView1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            schedule.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Stations stations = new Stations();
            stations.Show();
        }

        private void trainIDTB_TextChanged(object sender, EventArgs e)
        { 
            try
            {
                trainID = int.Parse(trainIDTB.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("The string is not a valid integer.");
            }
        }

        private void trainNumberTB_TextChanged(object sender, EventArgs e)
        {
            trainNo = trainNumberTB.Text;

        }

        private void deptStatIDTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                deptStaID = int.Parse(deptStatIDTB.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("The string is not a valid integer.");
            }

        }

        private void arriStatIDTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                arrStaID = int.Parse(arriStatIDTB.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("The string is not a valid integer.");
            }

        }

        private void deptTimeTB_TextChanged(object sender, EventArgs e)
        {
            deptTime = DateTime.Parse(deptTimeTB.Text);
        }

        private void arrTimeTB_TextChanged(object sender, EventArgs e)
        {
            arrTime = DateTime.Parse(arrTimeTB.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool filled_out = false;
            bool succ = false;

            TrainHandler trainHandler = new TrainHandler();
            filled_out = trainHandler.setTrain(trainID, trainNo, deptStaID, arrStaID, deptTime, arrTime);

            if(filled_out)
            {
                succ = trainHandler.add_Train();
                if (!succ) {
                    Console.WriteLine("add didnt work!!");
                }
                else
                {
                    trainHandler.set_Table(dataGridView1);
                    Console.WriteLine("add worked!!");
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool succ = false;
            TrainHandler trainHandler = new TrainHandler();

            succ = trainHandler.delete_Train(trainID);
            if (succ) {
                Console.WriteLine("delete success");
                trainHandler.set_Table(dataGridView1);
            } else
            {
                Console.WriteLine("delete not success");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool succ = false;
            TrainHandler trainHandler = new TrainHandler();
            succ = trainHandler.updateTrain(trainID, trainNo, deptStaID, arrStaID, deptTime, arrTime);
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
    }
}
