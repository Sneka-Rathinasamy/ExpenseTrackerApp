using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExpenseTrackerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Add categories to ComboBox
            cmbCategory.Items.AddRange(new string[] { "Food", "Travel", "Shopping", "Bills", "Other" });

            // Wire up CellClick event manually if not in designer
            dgvExpenses.CellClick += dgvExpenses_CellClick;

            // Load data initially
            LoadExpenses();
        }

        // Connection string
        private string connectionString = "Data Source=SNEKA\\SQLEXPRESS;Initial Catalog=ExpenseDB;Integrated Security=sspi";

        // Load all expenses into DataGridView
        private void LoadExpenses()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT Id, Date, Category, Amount, Description FROM Expenses";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvExpenses.DataSource = dt;

                    // Hide Id column
                    dgvExpenses.Columns["Id"].Visible = false;
                }
            }
        }

        // Add button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Expenses (Date, Category, Amount, Description) VALUES (@Date, @Category, @Amount, @Description)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                        cmd.Parameters.AddWithValue("@Category", cmbCategory.SelectedItem);
                        cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
                        cmd.Parameters.AddWithValue("@Description", txtExpenseName.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Expense added successfully!");
                ClearFields();
                LoadExpenses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Update button click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvExpenses.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvExpenses.SelectedRows[0].Cells["Id"].Value);

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "UPDATE Expenses SET Date=@Date, Category=@Category, Amount=@Amount, Description=@Description WHERE Id=@Id";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                            cmd.Parameters.AddWithValue("@Category", cmbCategory.SelectedItem);
                            cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
                            cmd.Parameters.AddWithValue("@Description", txtExpenseName.Text);
                            cmd.Parameters.AddWithValue("@Id", id);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Expense updated successfully!");
                    ClearFields();
                    LoadExpenses();
                }
                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Delete button click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvExpenses.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvExpenses.SelectedRows[0].Cells["Id"].Value);

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "DELETE FROM Expenses WHERE Id=@Id";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Expense deleted successfully!");
                    ClearFields();
                    LoadExpenses();
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // View All button click
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadExpenses();
        }

        // DataGridView row click - populate fields
        private void dgvExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvExpenses.Rows[e.RowIndex];

                txtExpenseName.Text = row.Cells["Description"].Value.ToString();
                txtAmount.Text = row.Cells["Amount"].Value.ToString();
                cmbCategory.SelectedItem = row.Cells["Category"].Value.ToString();
                dtpDate.Value = Convert.ToDateTime(row.Cells["Date"].Value);
            }
        }

        // Clear input fields
        private void ClearFields()
        {
            txtExpenseName.Clear();
            txtAmount.Clear();
            cmbCategory.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
        }
    }
}
