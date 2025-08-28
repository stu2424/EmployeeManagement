using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace EmployeeManagementUI
{
    public partial class Form1 : Form
    {
        private string _username;
        private string _fullname;

        public Form1(string username, string fullname)
        {
            InitializeComponent();
            _username = username ?? string.Empty;
            _fullname = fullname ?? string.Empty;
            LoadEmployees();
        }

        // Make LoadEmployees public so child forms can refresh
        public void LoadEmployees()
        {
            try
            {
                string connString = "Host=localhost;Username=postgres;Password=postgres;Database=EmployeeDB";
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM employees ORDER BY employeeid";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        DataTable dt = new DataTable();
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        da.Fill(dt);
                        dgvEmployees.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }

        // Add Employee
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addForm = new AddEmployeeForm(this);
            addForm.ShowDialog();
        }

        // Update Employee
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                var row = dgvEmployees.CurrentRow;
                int employeeId = row.Cells["employeeid"].Value != null ? Convert.ToInt32(row.Cells["employeeid"].Value) : 0;
                string firstname = row.Cells["firstname"].Value?.ToString() ?? string.Empty;
                string lastname = row.Cells["lastname"].Value?.ToString() ?? string.Empty;
                string position = row.Cells["position"].Value?.ToString() ?? string.Empty;
                string department = row.Cells["department"].Value?.ToString() ?? string.Empty;
                DateTime dateHired = row.Cells["datehired"].Value != null ? Convert.ToDateTime(row.Cells["datehired"].Value) : DateTime.MinValue;
                decimal salary = row.Cells["salary"].Value != null ? Convert.ToDecimal(row.Cells["salary"].Value) : 0;
                string status = row.Cells["status"].Value?.ToString() ?? string.Empty;
                string contact = row.Cells["contact"].Value?.ToString() ?? string.Empty;

                UpdateEmployeeForm updateForm = new UpdateEmployeeForm(
                    this,
                    employeeId,
                    firstname,
                    lastname,
                    position,
                    department,
                    dateHired,
                    salary,
                    status,
                    contact
                );

                updateForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an employee to update.");
            }
        }

        // Refresh Employee Grid
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        // Delete Employee
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                var row = dgvEmployees.CurrentRow;
                int employeeId = row.Cells["employeeid"].Value != null ? Convert.ToInt32(row.Cells["employeeid"].Value) : 0;

                var confirm = MessageBox.Show(
                    "Are you sure you want to delete this employee?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo
                );

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        string connString = "Host=localhost;Username=postgres;Password=postgres;Database=EmployeeDB";
                        using (var conn = new NpgsqlConnection(connString))
                        {
                            conn.Open();
                            string query = "DELETE FROM employees WHERE employeeid = @id";
                            using (var cmd = new NpgsqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("id", employeeId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Employee deleted successfully.");
                        LoadEmployees(); // refresh after deletion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting employee: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.");
            }
        }
    }
}
