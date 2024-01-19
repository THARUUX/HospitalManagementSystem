using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace CsharpProjectThree
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            dashboard MAIN = new dashboard();
            MAIN.Show();
            this.Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=THARUUX-NEO-DEV\SQLEXPRESS;Initial Catalog=hospital_sector;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO doctors VALUES ('"+textBox1.Text+"', '"+comboBox1.Text+"', '"+textBox3.Text+"', '"+comboBox2.Text+"', '"+textBox2.Text+"')";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Succesfully Added !");
            }
        }
    }
}
