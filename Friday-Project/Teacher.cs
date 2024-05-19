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

namespace Friday_Project
{
    public partial class Teacher : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UafDB;Integrated Security=True;Encrypt=False;";

        public Teacher()
        {
            InitializeComponent();
        }

        private void add_Teacher_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Teachers (FullName, Email, Password, Gender, StartingDate, ContactNo) VALUES (@FullName, @Email, @Password, @Gender, @StartingDate, @ContactNo)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FullName", fullNameTextBox.Text);
                    command.Parameters.AddWithValue("@Email", emailId.Text);
                    command.Parameters.AddWithValue("@Password", passwordBox.Text);
                    command.Parameters.AddWithValue("@Gender", genderComboBox.Text);
                    command.Parameters.AddWithValue("@StartingDate", dobPicker.Value);
                    command.Parameters.AddWithValue("@ContactNo", contactNo.Text);
                    command.ExecuteNonQuery();
                    Display();
                    //    MessageBox.Show("Teacher added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void updateteacher_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Teachers SET FullName = @FullName, Email = @Email, Password = @Password, Gender = @Gender, StartingDate = @StartingDate, ContactNo = @ContactNo WHERE Email = @Email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FullName", fullNameTextBox.Text);
                    command.Parameters.AddWithValue("@Email", emailId.Text);
                    command.Parameters.AddWithValue("@Password", passwordBox.Text);
                    command.Parameters.AddWithValue("@Gender", genderComboBox.Text);
                    command.Parameters.AddWithValue("@StartingDate", dobPicker.Value);
                    command.Parameters.AddWithValue("@ContactNo", contactNo.Text);
                    command.ExecuteNonQuery();
                    Display();
                    //    MessageBox.Show("Teacher updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void deleteTeacherRecord_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Teachers WHERE Email = @Email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", emailId.Text);

                    command.ExecuteNonQuery();
                    Display();
                 //   MessageBox.Show("Teacher deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void showRecords_Click(object sender, EventArgs e)
        {
            Display();
            
        }

        private void Display()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Teachers";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    teachersDataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
