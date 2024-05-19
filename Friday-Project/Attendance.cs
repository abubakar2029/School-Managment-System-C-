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
    public partial class Attendance : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UafDB;Integrated Security=True;Encrypt=False;";
        public Attendance()
        {
            InitializeComponent();
        }

        private void add_attendance_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Attendance (AId, StudentName, Status) VALUES (@AId, @StudentName, @Status)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@AId", int.Parse(aIdTextBox.Text));
                    cmd.Parameters.AddWithValue("@StudentName", studentNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Status", statusComboBox.Text);

                    cmd.ExecuteNonQuery();
                //    MessageBox.Show("Attendance Record Added Successfully", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void updateAttendance_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Attendance SET StudentName = @StudentName, Status = @Status WHERE AId = @AId";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@AId", int.Parse(aIdTextBox.Text));
                    cmd.Parameters.AddWithValue("@StudentName", studentNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Status", statusComboBox.Text);

                    cmd.ExecuteNonQuery();
                 //   MessageBox.Show("Attendance Record Updated Successfully", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void showRecords_Click(object sender, EventArgs e)
        {
            display();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void display()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Attendance;";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        private void deleteRecord_Click(object sender, EventArgs e)
        {
            SqlConnection connection= new SqlConnection(connectionString);
            connection.Open();
            string query = "DELETE FROM Attendance WHERE AId=@AId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AId", aIdTextBox.Text);
            command.ExecuteNonQuery();
            display();
        }
    }
}
