using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpProjectThree
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //if (usernameInput.Text == "admin" && passwortInput.Text == "admin123")
            //{
                dashboard MAIN = new dashboard();
                MAIN.Show();
                this.Hide();
            //}
            //else
            //{
               // MessageBox.Show("Username or Password was incorrect", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
