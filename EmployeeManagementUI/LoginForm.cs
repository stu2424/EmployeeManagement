using System;
using System.Windows.Forms;
using Npgsql;

namespace EmployeeManagementUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Please enter username and password.";
                return;
            }

            try
            {
                string connString = "Host=localhost;Username=postgres;Password=postgres;Database=EmployeeDB";
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT fullname FROM hr_users WHERE username = @username AND password = @password";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);

                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string fullname = result.ToString() ?? "Unknown";
                            this.Hide();
                            Form1 mainForm = new Form1(username, fullname);
                            mainForm.Show();
                        }
                        else
                        {
                            lblMessage.Text = "Invalid username or password.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }
    }
}
