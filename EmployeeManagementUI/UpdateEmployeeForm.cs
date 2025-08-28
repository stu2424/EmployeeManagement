using System;
using System.Windows.Forms;
using Npgsql;

namespace EmployeeManagementUI
{
    public partial class UpdateEmployeeForm : Form
    {
        private int employeeId;
        private Form1 parentForm;

        public UpdateEmployeeForm(Form1 form, int employeeId, string firstname, string lastname, string position,
                                  string department, DateTime dateHired, decimal salary, string status, string contact)
        {
            InitializeComponent();
            this.parentForm = form;
            this.employeeId = employeeId;

            // Populate fields
            txtFirstName.Text = firstname;
            txtLastName.Text = lastname;
            txtPosition.Text = position;
            txtDepartment.Text = department;
            dtpDateHired.Value = dateHired;
            txtSalary.Text = salary.ToString();
            txtStatus.Text = status;
            txtContact.Text = contact;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE employees 
                                     SET firstname=@firstname, lastname=@lastname, position=@position,
                                         department=@department, datehired=@datehired, salary=@salary,
                                         status=@status, contact=@contact
                                     WHERE employeeid=@employeeid";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("firstname", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("lastname", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("position", txtPosition.Text.Trim());
                        cmd.Parameters.AddWithValue("department", txtDepartment.Text.Trim());
                        cmd.Parameters.AddWithValue("datehired", dtpDateHired.Value.Date);
                        cmd.Parameters.AddWithValue("salary", decimal.Parse(txtSalary.Text.Trim()));
                        cmd.Parameters.AddWithValue("status", txtStatus.Text.Trim());
                        cmd.Parameters.AddWithValue("contact", txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("employeeid", employeeId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee updated successfully!");
                        parentForm.LoadEmployees(); // refresh grid in Form1
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
