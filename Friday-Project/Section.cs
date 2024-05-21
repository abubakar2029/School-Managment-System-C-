using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Friday_Project
{
    public partial class Section : Form
    {
        string connectionString = "Data  Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UafDB;Integrated Security=True;Encrypt=False;";

        public Section()
        {
            InitializeComponent();
        }

        private void showRecords_Click(object sender, EventArgs e)
        {
            display();


        }

        private void add_Section_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO SECTION (SectionId, StudentName, Section) VALUES (@SectionId, @StudentName, @Section)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@SectionId", sectionIdTextBox.Text);
                    cmd.Parameters.AddWithValue("@StudentName", studentNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Section", sectionTextBox.Text);

                    cmd.ExecuteNonQuery();
                 //   MessageBox.Show("Section Record Added Successfully", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            display();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void updateSection_Section(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE SECTION SET StudentName = @StudentName, Section = @Section WHERE SectionId = @SectionId";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@SectionId", sectionIdTextBox.Text);
                    cmd.Parameters.AddWithValue("@StudentName", studentNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Section", sectionTextBox.Text);

                    cmd.ExecuteNonQuery();
//                    MessageBox.Show("Section Record Updated Successfully", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            display();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void deleteSection_Section(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UafDB;Integrated Security=True;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM SECTION WHERE SectionId = @SectionId";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@SectionId", sectionIdTextBox.Text);

                    cmd.ExecuteNonQuery();
                  //  MessageBox.Show("Section Record Deleted Successfully", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            display();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void display()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM SECTION;";
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
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
