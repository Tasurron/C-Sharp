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

namespace LogReg
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T3FKTDS\SQLEXPRESS;Initial Catalog=players;Integrated Security=True;");
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user_name.Text != "" && password.Text != "")
            {
                string query = "select count(*) from RegistrationTbl where email='" + user_name.Text + "'and " +
                    "password='" + password.Text + "'";
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand(query, connection);
                int v = (int)command.ExecuteScalar();
                if (v != 1)
                {
                    MessageBox.Show("Error username or password", "Error!");
                }
                else
                {
                    MessageBox.Show("Welcome to your profile!");
                    user_name.Text = "";
                    password.Text = "";

                    CURD curd = new CURD();
                    this.Hide();
                    curd.Show();
                }
            }
            else
            {
                MessageBox.Show("Fill in the blanks");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
