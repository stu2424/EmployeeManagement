namespace EmployeeManagementUI
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblMessage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Text = "HR Management Login";
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Height = 60;

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Text = "Username:";
            this.lblUsername.Location = new System.Drawing.Point(30, 80);

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(150, 80);
            this.txtUsername.Size = new System.Drawing.Size(220, 22);
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Text = "Password:";
            this.lblPassword.Location = new System.Drawing.Point(30, 130);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(150, 130);
            this.txtPassword.Size = new System.Drawing.Size(220, 22);
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtPassword.UseSystemPasswordChar = true;

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(80, 180);
            this.btnLogin.Size = new System.Drawing.Size(120, 40);
            this.btnLogin.Text = "Login";
            this.btnLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnLogin.MouseEnter += (s, e) => { btnLogin.BackColor = System.Drawing.Color.SlateBlue; };
            this.btnLogin.MouseLeave += (s, e) => { btnLogin.BackColor = System.Drawing.Color.MediumSlateBlue; };
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // btnSignUp
            this.btnSignUp.Location = new System.Drawing.Point(220, 180);
            this.btnSignUp.Size = new System.Drawing.Size(120, 40);
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnSignUp.MouseEnter += (s, e) => { btnSignUp.BackColor = System.Drawing.Color.SeaGreen; };
            this.btnSignUp.MouseLeave += (s, e) => { btnSignUp.BackColor = System.Drawing.Color.MediumSeaGreen; };
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);

            // lblMessage
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(30, 230);
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;

            // LoginForm
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblMessage);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
