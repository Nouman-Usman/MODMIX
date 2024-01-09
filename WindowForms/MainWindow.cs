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

namespace Project_MODMIX_
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadDataFromDB();
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }
        private void LoadDataFromDB()
        {
            string connStr = "server=127.0.0.1;user=root;database=user;password=1242;";
            string sqlQuery = "SELECT * FROM nouman";
            //MySqlConnection conn = new MySqlConnection(connStr);
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                try
                {
                    // Open connection
                    connection.Open();
                    // Create command
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        // Execute the query
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            GridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            GridView.EditMode = DataGridViewEditMode.EditProgrammatically;
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            GridView.DataSource = dataTable;
                            GridView.Refresh();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
