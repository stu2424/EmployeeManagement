using System;
using System.Windows.Forms;
using Npgsql;

namespace EmployeeManagementUI
{
    public partial class AddEmployeeForm : Form
    {
        private Form1 mainForm;

        public AddEmployeeForm(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string position = txtPosition.Text.Trim();
            string department = txtDepartment.Text.Trim();
            DateTime dateHired = dtpDateHired.Value;
            decimal salary = 0;
            decimal.TryParse(txtSalary.Text.Trim(), out salary);
            string status = txtStatus.Text.Trim();
            string contact = txtContact.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("First Name and Last Name are required.");
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
                        cmd.Parameters.AddWithValue("firstname", firstName);
                        cmd.Parameters.AddWithValue("lastname", lastName);
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
                mainForm.LoadEmployees(); // refresh the DataGridView in Form1
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
