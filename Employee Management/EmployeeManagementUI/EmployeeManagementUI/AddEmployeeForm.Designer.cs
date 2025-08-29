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
            this.components = new System.ComponentModel.Container();

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

            // Form
            this.Text = "Add Employee - Letlhakane Sub Land Board HR Prototype";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(520, 540);
            this.BackColor = System.Drawing.Color.White;

            // Common fonts
            var labelFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            var textFont = new System.Drawing.Font("Segoe UI", 10F);

            // Labels styling
            void StyleLabel(System.Windows.Forms.Label lbl, string text, int x, int y)
            {
                lbl.Text = text;
                lbl.Font = labelFont;
                lbl.AutoSize = true;
                lbl.Location = new System.Drawing.Point(x, y);
                lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            }

            StyleLabel(lblFirstName, "First Name:", 30, 30);
            StyleLabel(lblLastName, "Last Name:", 30, 70);
            StyleLabel(lblPosition, "Position:", 30, 110);
            StyleLabel(lblDepartment, "Department:", 30, 150);
            StyleLabel(lblDateHired, "Date Hired:", 30, 190);
            StyleLabel(lblSalary, "Salary:", 30, 230);
            StyleLabel(lblStatus, "Status:", 30, 270);
            StyleLabel(lblContact, "Contact:", 30, 310);

            // Textboxes styling
            void StyleTextBox(System.Windows.Forms.Control tb, int x, int y)
            {
                tb.Font = textFont;
                tb.Size = new System.Drawing.Size(300, 25);
                tb.Location = new System.Drawing.Point(x, y);
                tb.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
                tb.BackColor = System.Drawing.Color.WhiteSmoke;
                tb.ForeColor = System.Drawing.Color.Black;
            }

            StyleTextBox(txtFirstName, 150, 27);
            StyleTextBox(txtLastName, 150, 67);
            StyleTextBox(txtPosition, 150, 107);
            StyleTextBox(txtDepartment, 150, 147);
            StyleTextBox(dtpDateHired, 150, 187);
            StyleTextBox(txtSalary, 150, 227);
            StyleTextBox(txtStatus, 150, 267); txtStatus.Text = "Active";
            StyleTextBox(txtContact, 150, 307);

            // Buttons styling
            void StyleButton(System.Windows.Forms.Button btn, string text, int x, int y, System.Drawing.Color backColor)
            {
                btn.Text = text;
                btn.Font = labelFont;
                btn.Size = new System.Drawing.Size(120, 35);
                btn.Location = new System.Drawing.Point(x, y);
                btn.BackColor = backColor;
                btn.ForeColor = System.Drawing.Color.White;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }

            StyleButton(btnSave, "Save", 100, 370, System.Drawing.Color.MediumSeaGreen);
            StyleButton(btnCancel, "Cancel", 260, 370, System.Drawing.Color.IndianRed);

            // Add controls
            this.Controls.Add(lblFirstName); this.Controls.Add(txtFirstName);
            this.Controls.Add(lblLastName); this.Controls.Add(txtLastName);
            this.Controls.Add(lblPosition); this.Controls.Add(txtPosition);
            this.Controls.Add(lblDepartment); this.Controls.Add(txtDepartment);
            this.Controls.Add(lblDateHired); this.Controls.Add(dtpDateHired);
            this.Controls.Add(lblSalary); this.Controls.Add(txtSalary);
            this.Controls.Add(lblStatus); this.Controls.Add(txtStatus);
            this.Controls.Add(lblContact); this.Controls.Add(txtContact);
            this.Controls.Add(btnSave); this.Controls.Add(btnCancel);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
