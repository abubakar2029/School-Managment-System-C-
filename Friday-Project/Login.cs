using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Friday_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox1.Height = 50;
            username.Text = "admin.ali@example.com";
            passwordBox.Text = "admin123";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UafDB;Integrated Security=True;Encrypt=False;";
            string email = username.Text;
            string password = passwordBox.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "";
                    SqlCommand command = new SqlCommand();

                    if (comboBox1.Text == "Admin")
                    {
                        query = "SELECT FullName FROM Admin WHERE Email = @Email AND Password = @Password";
                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);
                    }
                    else if (comboBox1.Text == "Student")
                    {
                        query = "SELECT FullName, IsApproved FROM Students WHERE Email = @Email AND Password = @Password";
                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);
                    }
                    else if (comboBox1.Text == "Faculty")
                    {
                        query = "SELECT FullName, IsApproved FROM Faculty WHERE Email = @Email AND Password = @Password";
                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                   
                        if (dataTable.Rows.Count > 0)
                        {
                            DataRow row1 = dataTable.Rows[0];
                            string fullName = row1["FullName"].ToString();
                            bool isApproved = comboBox1.Text == "Admin" || Convert.ToBoolean(row1["IsApproved"]);

                            if (isApproved)
                            {
                                MessageBox.Show($"Welcome {fullName}!");
                                Main mainForm = new Main();
                                mainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Your account is not approved yet.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = showPass.Checked ? '\0' : '*';
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
