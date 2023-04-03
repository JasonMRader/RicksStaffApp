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
            panel1 = new Panel();
            label3 = new Label();
            btnCloseAddEmployee = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(8, 113);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(198, 29);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(8, 174);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(198, 29);
            txtLastName.TabIndex = 1;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(167, 204, 237);
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.ForeColor = Color.Black;
            btnAddEmployee.Location = new Point(8, 329);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(198, 43);
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
            label1.Location = new Point(6, 85);
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
            label2.Location = new Point(6, 145);
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
            clbPositions.Location = new Point(8, 211);
            clbPositions.Name = "clbPositions";
            clbPositions.Size = new Size(198, 114);
            clbPositions.TabIndex = 4;
            // 
            // flowEmployeeDisplay
            // 
            flowEmployeeDisplay.BackColor = Color.FromArgb(37, 42, 64);
            flowEmployeeDisplay.Location = new Point(220, 73);
            flowEmployeeDisplay.Name = "flowEmployeeDisplay";
            flowEmployeeDisplay.Size = new Size(435, 664);
            flowEmployeeDisplay.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.Controls.Add(flowEmployeeDisplay);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(clbPositions);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(btnAddEmployee);
            panel1.Location = new Point(4, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 745);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(99, 135, 174);
            label3.Location = new Point(8, 16);
            label3.Name = "label3";
            label3.Size = new Size(236, 32);
            label3.TabIndex = 3;
            label3.Text = "Add New Employees";
            // 
            // btnCloseAddEmployee
            // 
            btnCloseAddEmployee.FlatAppearance.BorderSize = 0;
            btnCloseAddEmployee.FlatStyle = FlatStyle.Flat;
            btnCloseAddEmployee.ForeColor = Color.White;
            btnCloseAddEmployee.Location = new Point(649, -1);
            btnCloseAddEmployee.Name = "btnCloseAddEmployee";
            btnCloseAddEmployee.Size = new Size(30, 23);
            btnCloseAddEmployee.TabIndex = 9;
            btnCloseAddEmployee.Text = "X";
            btnCloseAddEmployee.UseVisualStyleBackColor = true;
            btnCloseAddEmployee.Click += btnCloseAddEmployee_Click;
            // 
            // frmAddNewEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 105, 144);
            ClientSize = new Size(675, 777);
            Controls.Add(btnCloseAddEmployee);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddNewEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddNewEmployee";
            Load += frmAddNewEmployee_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnAddEmployee;
        private Label label1;
        private Label label2;
        private CheckedListBox clbPositions;
        private FlowLayoutPanel flowEmployeeDisplay;
        private Panel panel1;
        private Button btnCloseAddEmployee;
        private Label label3;
    }
}