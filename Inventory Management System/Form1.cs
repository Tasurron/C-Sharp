using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Linq.Expressions;
namespace LogReg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T3FKTDS\SQLEXPRESS;Initial Catalog=players;Integrated Security=True;");
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (first_name.Text != "" && last_name.Text != "" && date.Text != "" && gender.Text != "" && email.Text != ""
                    && address.Text != "" && password.Text != "" && con_password.Text != "")
                {
                    if (password.Text == con_password.Text)
                    {
                        int v = check(email.Text);
                        if (v != 1)
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("insert into RegistrationTbl values(@f_name,@l_name,@b_date,@gender,@email,@address,@password)", connection);
                            command.Parameters.AddWithValue("@f_name", first_name.Text);
                            command.Parameters.AddWithValue("@l_name", last_name.Text);
                            command.Parameters.AddWithValue("@b_date", Convert.ToDateTime(date.Text));
                            command.Parameters.AddWithValue("@gender", gender.Text);
                            command.Parameters.AddWithValue("@email", email.Text);
                            command.Parameters.AddWithValue("@address", address.Text);
                            command.Parameters.AddWithValue("@password", password.Text);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Registration Sucsessful!");
                            first_name.Text = "";
                            last_name.Text = "";
                            gender.Text = "";
                            address.Text = "";
                            email.Text = "";
                            password.Text = "";
                            con_password.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("You are already registered");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password does not match");
                    }
                }
                else
                {
                    MessageBox.Show("Fill in the blanks!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int check(string email)
        {
            connection.Open();
            string query = "select count(*) from  RegistrationTbl where email='" + email + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;
        }

        private void check_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pass.Checked)
            {
                password.UseSystemPasswordChar = false;
                con_password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
                con_password.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
