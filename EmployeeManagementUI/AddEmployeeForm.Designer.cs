namespace EmployeeManagementUI
{
    partial class AddEmployeeForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblDateHired;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblContact;

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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblDateHired = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();

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

            // Labels
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 20);
            this.lblFirstName.Text = "First Name:";

            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(20, 60);
            this.lblLastName.Text = "Last Name:";

            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(20, 100);
            this.lblPosition.Text = "Position:";

            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(20, 140);
            this.lblDepartment.Text = "Department:";

            this.lblDateHired.AutoSize = true;
            this.lblDateHired.Location = new System.Drawing.Point(20, 180);
            this.lblDateHired.Text = "Date Hired:";

            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(20, 220);
            this.lblSalary.Text = "Salary:";

            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 260);
            this.lblStatus.Text = "Status:";

            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(20, 300);
            this.lblContact.Text = "Contact:";

            // Textboxes and DateTimePicker
            this.txtFirstName.Location = new System.Drawing.Point(120, 20);
            this.txtFirstName.Size = new System.Drawing.Size(150, 22);

            this.txtLastName.Location = new System.Drawing.Point(120, 60);
            this.txtLastName.Size = new System.Drawing.Size(150, 22);

            this.txtPosition.Location = new System.Drawing.Point(120, 100);
            this.txtPosition.Size = new System.Drawing.Size(150, 22);

            this.txtDepartment.Location = new System.Drawing.Point(120, 140);
            this.txtDepartment.Size = new System.Drawing.Size(150, 22);

            this.dtpDateHired.Location = new System.Drawing.Point(120, 180);
            this.dtpDateHired.Size = new System.Drawing.Size(150, 22);

            this.txtSalary.Location = new System.Drawing.Point(120, 220);
            this.txtSalary.Size = new System.Drawing.Size(150, 22);

            this.txtStatus.Location = new System.Drawing.Point(120, 260);
            this.txtStatus.Size = new System.Drawing.Size(150, 22);
            this.txtStatus.Text = "Active"; // default value

            this.txtContact.Location = new System.Drawing.Point(120, 300);
            this.txtContact.Size = new System.Drawing.Size(150, 22);

            // Buttons
            this.btnSave.Location = new System.Drawing.Point(50, 340);
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Location = new System.Drawing.Point(150, 340);
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // AddEmployeeForm
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblDateHired);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblContact);

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

            this.Name = "AddEmployeeForm";
            this.Text = "Add Employee";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
