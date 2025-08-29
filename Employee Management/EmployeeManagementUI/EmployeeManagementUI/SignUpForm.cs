using System;
using System.Windows.Forms;
using Npgsql;

namespace EmployeeManagementUI
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string fullname = txtFullname.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(fullname))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO hr_users (username, password, fullname)
                                     VALUES (@username, @password, @fullname)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        // Hash the password before storing
                        cmd.Parameters.AddWithValue("password", PasswordHelper.HashPassword(password));
                        cmd.Parameters.AddWithValue("fullname", fullname);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("User registered successfully!");
                this.Close();
            }
            catch (PostgresException pgEx) when (pgEx.SqlState == "23505") // unique violation
            {
                MessageBox.Show("Username already exists.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering user: " + ex.Message);
            }
        }
    }
}
