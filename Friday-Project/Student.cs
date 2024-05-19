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

namespace Friday_Project
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton3_CheckedChanged_1(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dobPicker.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dobPicker.CustomFormat = "";
            }
        }

        private void add_Student_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UafDB;Integrated Security=True;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO STUDENTS (FullName, Password, Email, DoB, Gender, ContactNo) VALUES (@FullName, @Password, @Email, @DoB, @Gender, @ContactNo)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@FullName", fullName.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordBox.Text);
                    cmd.Parameters.AddWithValue("@Email", emailId.Text);
                    cmd.Parameters.AddWithValue("@DoB", dobPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@Gender", genderComboBox.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", contactNo.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Record Sent for Approval", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void showRecords_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UafDB;Integrated Security=True;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM STUDENTS";
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

        private void Student_Load(object sender, EventArgs e) { }

        private void updateRecord(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UafDB;Integrated Security=True;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE STUDENTS SET FullName = @FullName, Password = @Password, DoB = @DoB, Gender = @Gender, ContactNo = @ContactNo WHERE Email = @Email";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@FullName", fullName.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordBox.Text);
                    cmd.Parameters.AddWithValue("@Email", emailId.Text); // Email to identify which record to update
                    cmd.Parameters.AddWithValue("@DoB", dobPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@Gender", genderComboBox.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", contactNo.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Record Updated Successfully", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }


        private void deleteRecord(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UafDB;Integrated Security=True;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM STUDENTS WHERE Email = @Email";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Email", emailId.Text); // Email to identify which record to delete

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Record Deleted Successfully", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void contactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
