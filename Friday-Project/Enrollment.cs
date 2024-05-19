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
    public partial class Enrollment : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UafDB;Integrated Security=True;Encrypt=False;";
        public Enrollment()
        {
            InitializeComponent();
        }

        private void showRecords_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM ;";
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

        private void updateEnrollment_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE ENROLLMENTS SET StudentName = @StudentName, Section = @Section, EnrollDate = @EnrollDate WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Id", enrollmentIdTextBox.Text);
                    cmd.Parameters.AddWithValue("@StudentName", studentNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Section", sectionTextBox.Text);
                    cmd.Parameters.AddWithValue("@EnrollDate", enrollDatePicker.Value.Date);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Enrollment Record Updated Successfully", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void deleteEnrollment_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM [Table] WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Id", enrollmentIdTextBox.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Enrollment Record Deleted Successfully", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void add_Enrollment_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO ENROLLMENTS (Id, StudentName, Section, EnrollDate) VALUES (@Id, @StudentName, @Section, @EnrollDate)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Id", enrollmentIdTextBox.Text);
                    cmd.Parameters.AddWithValue("@StudentName", studentNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Section", sectionTextBox.Text);
                    cmd.Parameters.AddWithValue("@EnrollDate", enrollDatePicker.Value.Date);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Enrollment Record Added Successfully", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
