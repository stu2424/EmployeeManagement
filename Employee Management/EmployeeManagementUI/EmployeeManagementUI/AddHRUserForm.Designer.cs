namespace EmployeeManagementUI
{
    partial class AddHRUserForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Labels
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 20);
            this.lblUsername.Text = "Username:";

            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(20, 60);
            this.lblFullname.Text = "Full Name:";

            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 100);
            this.lblPassword.Text = "Password:";

            // Textboxes
            this.txtUsername.Location = new System.Drawing.Point(120, 20);
            this.txtUsername.Size = new System.Drawing.Size(180, 22);

            this.txtFullname.Location = new System.Drawing.Point(120, 60);
            this.txtFullname.Size = new System.Drawing.Size(180, 22);

            this.txtPassword.Location = new System.Drawing.Point(120, 100);
            this.txtPassword.Size = new System.Drawing.Size(180, 22);
            this.txtPassword.UseSystemPasswordChar = true;

            // Buttons
            this.btnSave.Location = new System.Drawing.Point(50, 150);
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Location = new System.Drawing.Point(160, 150);
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(320, 220);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Text = "Add HR User";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
