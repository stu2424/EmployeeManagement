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

            // Form
            this.ClientSize = new System.Drawing.Size(360, 400);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Employee - Letlhakane Sub Land Board HR Prototype";
            this.BackColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(380, 440);

            var labelFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            var textFont = new System.Drawing.Font("Segoe UI", 10F);

            // Helper methods
            void StyleTextBox(System.Windows.Forms.Control tb, int x, int y)
            {
                tb.Font = textFont;
                tb.Size = new System.Drawing.Size(200, 25);
                tb.Location = new System.Drawing.Point(x, y);
                tb.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
                tb.BackColor = System.Drawing.Color.WhiteSmoke;
                tb.ForeColor = System.Drawing.Color.Black;
            }

            void StyleButton(System.Windows.Forms.Button btn, string text, int x, int y, System.Drawing.Color backColor, System.Windows.Forms.AnchorStyles anchor)
            {
                btn.Text = text;
                btn.Font = labelFont;
                btn.Size = new System.Drawing.Size(100, 35);
                btn.Location = new System.Drawing.Point(x, y);
                btn.BackColor = backColor;
                btn.ForeColor = System.Drawing.Color.White;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Anchor = anchor;
            }

            // Textboxes
            StyleTextBox(txtFirstName, 120, 20);
            StyleTextBox(txtLastName, 120, 60);
            StyleTextBox(txtPosition, 120, 100);
            StyleTextBox(txtDepartment, 120, 140);
            StyleTextBox(dtpDateHired, 120, 180);
            StyleTextBox(txtSalary, 120, 220);
            StyleTextBox(txtStatus, 120, 260);
            StyleTextBox(txtContact, 120, 300);

            // Buttons
            StyleButton(btnSave, "Save", 50, 340, System.Drawing.Color.MediumSeaGreen, System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            StyleButton(btnCancel, "Cancel", 170, 340, System.Drawing.Color.IndianRed, System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);

            // Hook events
            btnSave.Click += new System.EventHandler(this.btnSave_Click);
            btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Add controls
            this.Controls.Add(txtFirstName);
            this.Controls.Add(txtLastName);
            this.Controls.Add(txtPosition);
            this.Controls.Add(txtDepartment);
            this.Controls.Add(dtpDateHired);
            this.Controls.Add(txtSalary);
            this.Controls.Add(txtStatus);
            this.Controls.Add(txtContact);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnCancel);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
