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


namespace MainProj
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            GetMenuItems();
            PopulateMenuStrip();

        }
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
        }

        private void PopulateMenuStrip()
        {
            List<string> items = GetMenuItems();

            foreach (string item in items)
            {

                ToolStripMenuItem dropdownItem = new ToolStripMenuItem(item);
                dropdownItem.Click += DropdownItem_Click;
                selectDepartureStationToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            MessageBox.Show($"You clicked: {clickedItem.Text}");
        }

        private void DropdownItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            MessageBox.Show($"You selected: {clickedItem.Text}");
        }


    }
}
