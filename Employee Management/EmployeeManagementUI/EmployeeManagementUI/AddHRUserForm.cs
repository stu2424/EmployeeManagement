using System;
using System.Windows.Forms;
using Npgsql;

namespace EmployeeManagementUI
{
    public partial class AddHRUserForm : Form
    {
        public AddHRUserForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string fullname = txtFullname.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            string hashedPassword = PasswordHelper.HashPassword(password);

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO hr_users (username, fullname, password) VALUES (@username, @fullname, @password)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("fullname", fullname);
                        cmd.Parameters.AddWithValue("password", hashedPassword);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("HR user added successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding HR user: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
