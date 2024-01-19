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

namespace CsharpProjectThree
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Entry DATA = new Entry();
            DATA.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Login LOGIN = new Login();
                LOGIN.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=THARUUX-NEO-DEV\SQLEXPRESS;Initial Catalog=hospital_sector;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Connection Error");
                }

                string query = "SELECT * FROM doctors";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = table;
            }        

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=THARUUX-NEO-DEV\SQLEXPRESS;Initial Catalog=hospital_sector;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Connection Error");
                }

                string query = "SELECT * FROM doctors";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = table;
            }       
        }
    }
}
