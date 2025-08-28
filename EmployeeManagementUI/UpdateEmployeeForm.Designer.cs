namespace EmployeeManagementUI
{
    partial class UpdateEmployeeForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.DateTimePicker dtpDateHired;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtContact;
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.dtpDateHired = new System.Windows.Forms.DateTimePicker();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Controls setup
            this.txtFirstName.Location = new System.Drawing.Point(120, 20);
            this.txtFirstName.Size = new System.Drawing.Size(200, 22);

            this.txtLastName.Location = new System.Drawing.Point(120, 60);
            this.txtLastName.Size = new System.Drawing.Size(200, 22);

            this.txtPosition.Location = new System.Drawing.Point(120, 100);
            this.txtPosition.Size = new System.Drawing.Size(200, 22);

            this.txtDepartment.Location = new System.Drawing.Point(120, 140);
            this.txtDepartment.Size = new System.Drawing.Size(200, 22);

            this.dtpDateHired.Location = new System.Drawing.Point(120, 180);
            this.dtpDateHired.Size = new System.Drawing.Size(200, 22);

            this.txtSalary.Location = new System.Drawing.Point(120, 220);
            this.txtSalary.Size = new System.Drawing.Size(200, 22);

            this.txtStatus.Location = new System.Drawing.Point(120, 260);
            this.txtStatus.Size = new System.Drawing.Size(200, 22);

            this.txtContact.Location = new System.Drawing.Point(120, 300);
            this.txtContact.Size = new System.Drawing.Size(200, 22);

            this.btnSave.Location = new System.Drawing.Point(50, 340);
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Location = new System.Drawing.Point(170, 340);
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(360, 400);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.dtpDateHired);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Text = "Update Employee";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
