using Microsoft.Data.SqlClient;
using System.Data;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {

        private int selectedId = -1; // Variable to store the selected student ID

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void getAllStudents()
        {
            using (SqlConnection conn = Database.DB.GetConnection())
            {
                conn.Open();
                string selectSqlQuery = "SELECT * FROM StudentDataTable;";
                SqlDataAdapter adapter = new SqlDataAdapter(selectSqlQuery, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                StudentGrid.DataSource = dt;
                StudentGrid.Columns["ID"].Visible = false; // Hide the ID column
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAge.Text) || string.IsNullOrEmpty(txtCourse.Text) || string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtGender.Text)) {
                MessageBox.Show("All the Inputs fields are Required");
                return;
                
            
            
            
            }



            try
            {
                using (SqlConnection conn = Database.DB.GetConnection())
                {
                    conn.Open();
                    string addSqlQuery = "INSERT INTO StudentDataTable(FULL_NAME, AGE, GENDER, COURSE) VALUES (@FN, @AGE, @GENDER, @COURSE);";
                    SqlCommand cmd = new SqlCommand(addSqlQuery, conn);
                    cmd.Parameters.AddWithValue("@FN", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@AGE", int.Parse(txtAge.Text));
                    cmd.Parameters.AddWithValue("@GENDER", txtGender.Text);
                    cmd.Parameters.AddWithValue("@COURSE", txtCourse.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add student.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Add operation completed.");
            }
            getAllStudents();
            ClearFields(); // Clear the input fields after adding
        }

        private void StudentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = StudentGrid.Rows[e.RowIndex];

                txtAge.Text = row.Cells["AGE"].Value.ToString();
                txtFullName.Text = row.Cells["FULL_NAME"].Value.ToString();
                txtGender.Text = row.Cells["gender"].Value.ToString();
                txtCourse.Text = row.Cells["COURSE"].Value.ToString();

                selectedId = Convert.ToInt32(row.Cells["ID"].Value); // Store the selected student ID

            }
        }

        public void ClearFields()
        {
            txtFullName.Clear();
            txtAge.Clear();
            txtGender.Text = string.Empty;
            txtCourse.Text = string.Empty;
            selectedId = -1; // Reset the selected ID


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Database.DB.GetConnection())
                {
                    conn.Open();
                    string updateSqlQuery = "UPDATE StudentDataTable SET FULL_NAME = @FN, AGE = @AGE, GENDER = @GENDER, COURSE = @COURSE WHERE ID = @id";
                    SqlCommand cmd = new SqlCommand(updateSqlQuery, conn);
                    cmd.Parameters.AddWithValue("@FN", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@AGE", int.Parse(txtAge.Text));
                    cmd.Parameters.AddWithValue("@GENDER", txtGender.Text);
                    cmd.Parameters.AddWithValue("@COURSE", txtCourse.Text);
                    cmd.Parameters.AddWithValue("@id", selectedId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student updated successfully.");
                        getAllStudents(); // Refresh the grid
                        ClearFields(); // Clear the input fields after update
                    }
                    else
                    {
                        MessageBox.Show("No rows updated. Check the selected record.");
                    }
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Database.DB.GetConnection()) {
                    conn.Open();
                    string deleteSqlQuery = "DELETE FROM StudentDataTable WHERE ID = @id";
                    SqlCommand cmd = new SqlCommand(deleteSqlQuery, conn);
                    cmd.Parameters.AddWithValue("@id", selectedId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0) {
                        MessageBox.Show("Student deleted successfully.");
                        getAllStudents(); // Refresh the grid
                        ClearFields(); // Clear the input fields after deletion
                    }
                    else {
                        MessageBox.Show("No rows deleted. Check the selected record.");



                    }



                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
