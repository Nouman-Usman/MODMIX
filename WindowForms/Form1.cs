using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_MODMIX_
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ConnectDB();
        }

        private void Ok_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow form1 = new MainWindow();
            form1.Show();
        }
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow form1 = new MainWindow();
            form1.Show();

        }
        
    }
}
