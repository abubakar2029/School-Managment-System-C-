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
    public partial class Course : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UafDB;Integrated Security=True;Encrypt=False;";
        public Course()
        {
            InitializeComponent();

        }

        private void addCourse(object sender, EventArgs e)
        {
            string query = "INSERT INTO COURSES (CourseID, CourseName, CourseDuration) VALUES (@CourseID, @CourseName, @CourseDuration)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CourseID", int.Parse(courseIDTextBox.Text));
                    command.Parameters.AddWithValue("@CourseName", courseNameTextBox.Text);
                    command.Parameters.AddWithValue("@CourseDuration", courseDurationTextBox.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Course added successfully.");
                    DisplayCourses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void updateCourse(object sender, EventArgs e)
        {
            string query = "UPDATE COURSES SET CourseName = @CourseName, CourseDuration = @CourseDuration WHERE CourseID = @CourseID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CourseID", int.Parse(courseIDTextBox.Text));
                    command.Parameters.AddWithValue("@CourseName", courseNameTextBox.Text);
                    command.Parameters.AddWithValue("@CourseDuration", courseDurationTextBox.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Course updated successfully.");
                    DisplayCourses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void deleteCourse(object sender, EventArgs e)
        {
            string query = "DELETE FROM COURSES WHERE CourseID = @CourseID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CourseID", int.Parse(courseIDTextBox.Text));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Course deleted successfully.");
                    DisplayCourses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }


        private void displayCourses(object sender, EventArgs e)
        {
            DisplayCourses();
        }
        private void DisplayCourses()
        {
            string query = "SELECT * FROM COURSES";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    coursesDataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
