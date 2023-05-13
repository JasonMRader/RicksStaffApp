namespace RicksStaffApp
{
    partial class frmAddNewEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnAddEmployee = new Button();
            label1 = new Label();
            label2 = new Label();
            clbPositions = new CheckedListBox();
            flowEmployeeDisplay = new FlowLayoutPanel();
            label3 = new Label();
            btnCloseAddEmployee = new Button();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(12, 71);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(198, 29);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(12, 140);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(198, 29);
            txtLastName.TabIndex = 1;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(167, 204, 237);
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.ForeColor = Color.Black;
            btnAddEmployee.Location = new Point(12, 187);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(421, 27);
            btnAddEmployee.TabIndex = 2;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 103);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // clbPositions
            // 
            clbPositions.CheckOnClick = true;
            clbPositions.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clbPositions.FormattingEnabled = true;
            clbPositions.Location = new Point(226, 55);
            clbPositions.Name = "clbPositions";
            clbPositions.Size = new Size(198, 114);
            clbPositions.TabIndex = 4;
            // 
            // flowEmployeeDisplay
            // 
            flowEmployeeDisplay.AutoScroll = true;
            flowEmployeeDisplay.AutoSize = true;
            flowEmployeeDisplay.BackColor = Color.FromArgb(37, 42, 64);
            flowEmployeeDisplay.Dock = DockStyle.Bottom;
            flowEmployeeDisplay.Location = new Point(0, 225);
            flowEmployeeDisplay.MaximumSize = new Size(450, 450);
            flowEmployeeDisplay.MinimumSize = new Size(427, 450);
            flowEmployeeDisplay.Name = "flowEmployeeDisplay";
            flowEmployeeDisplay.Size = new Size(450, 450);
            flowEmployeeDisplay.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 5);
            label3.Name = "label3";
            label3.Size = new Size(236, 32);
            label3.TabIndex = 3;
            label3.Text = "Add New Employees";
            // 
            // btnCloseAddEmployee
            // 
            btnCloseAddEmployee.BackColor = Color.FromArgb(167, 204, 237);
            btnCloseAddEmployee.FlatAppearance.BorderSize = 0;
            btnCloseAddEmployee.FlatStyle = FlatStyle.Flat;
            btnCloseAddEmployee.ForeColor = Color.Black;
            btnCloseAddEmployee.Location = new Point(351, -2);
            btnCloseAddEmployee.Name = "btnCloseAddEmployee";
            btnCloseAddEmployee.Size = new Size(99, 23);
            btnCloseAddEmployee.TabIndex = 9;
            btnCloseAddEmployee.Text = "Finished";
            btnCloseAddEmployee.UseVisualStyleBackColor = false;
            btnCloseAddEmployee.Click += btnCloseAddEmployee_Click;
            // 
            // frmAddNewEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 42, 64);
            ClientSize = new Size(450, 675);
            Controls.Add(label1);
            Controls.Add(clbPositions);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(flowEmployeeDisplay);
            Controls.Add(label2);
            Controls.Add(btnCloseAddEmployee);
            Controls.Add(txtLastName);
            Controls.Add(btnAddEmployee);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddNewEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddNewEmployee";
            Load += frmAddNewEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnAddEmployee;
        private Label label1;
        private Label label2;
        private CheckedListBox clbPositions;
        private FlowLayoutPanel flowEmployeeDisplay;
        private Button btnCloseAddEmployee;
        private Label label3;
    }
}