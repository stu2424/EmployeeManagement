using System;
using System.Windows.Forms;
using Npgsql;

namespace EmployeeManagementUI
{
    public partial class AddEmployeeForm : Form
    {
        private Form1 parentForm;

        public AddEmployeeForm(Form1 form)
        {
            InitializeComponent();
            parentForm = form;

            // Ensure buttons are connected to event handlers
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Read input values
            string firstname = txtFirstName.Text.Trim();
            string lastname = txtLastName.Text.Trim();
            string position = txtPosition.Text.Trim();
            string department = txtDepartment.Text.Trim();
            DateTime dateHired = dtpDateHired.Value.Date;
            string salaryText = txtSalary.Text.Trim();
            string status = txtStatus.Text.Trim();
            string contact = txtContact.Text.Trim();

            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) ||
                string.IsNullOrEmpty(position) || string.IsNullOrEmpty(department) ||
                string.IsNullOrEmpty(salaryText))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!decimal.TryParse(salaryText, out decimal salary))
            {
                MessageBox.Show("Salary must be a valid number.");
                return;
            }

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO employees 
                                     (firstname, lastname, position, department, datehired, salary, status, contact)
                                     VALUES (@firstname, @lastname, @position, @department, @datehired, @salary, @status, @contact)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("firstname", firstname);
                        cmd.Parameters.AddWithValue("lastname", lastname);
                        cmd.Parameters.AddWithValue("position", position);
                        cmd.Parameters.AddWithValue("department", department);
                        cmd.Parameters.AddWithValue("datehired", dateHired);
                        cmd.Parameters.AddWithValue("salary", salary);
                        cmd.Parameters.AddWithValue("status", status);
                        cmd.Parameters.AddWithValue("contact", contact);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Employee added successfully!");
                parentForm.LoadEmployees();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
