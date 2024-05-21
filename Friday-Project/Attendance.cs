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
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "DELETE FROM Attendance WHERE AId=@AId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AId", aIdTextBox.Text);
            command.ExecuteNonQuery();
            display();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}


/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static MaterialDesignThemes.Wpf.Theme;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SE412
{
    public partial class Form_search : Form

    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jtc\\source\\repos\\SE412\\SE412\\Database1.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        public Form_search()
        {
            InitializeComponent();
            for (int i = 1; i <= 10; ++i)
            {
                datagrid.Rows.Add("delete", "update");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            con.Open();
            cm = new SqlCommand("SELECT * FROM record WHERE name = @name", con);
            cm.Parameters.AddWithValue("@name", txt_search.Text);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrid.DataSource = dt;
           *//* cm.ExecuteNonQuery();*//*

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = datagrid.Columns[e.ColumnIndex].Name;
            if (colName == "update")
            {
                // Check if cells are not null
                var nameCell = datagrid.Rows[e.RowIndex].Cells["name"].Value;
                var phoneCell = datagrid.Rows[e.RowIndex].Cells["phone"].Value;
                var emailCell = datagrid.Rows[e.RowIndex].Cells["email"].Value;

                if (nameCell != null && phoneCell != null && emailCell != null)
                {
                    Form_update up = new Form_update(this);
                    up.txt_nameup.Text = nameCell.ToString();
                    up.txt_phup.Text = phoneCell.ToString();
                    up.txt_emailup.Text = emailCell.ToString();
                    up.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selected row has missing data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void Form_search_Load(object sender, EventArgs e)
        {

        }

        internal void LoadRecords()
        {
            throw new NotImplementedException();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}*/