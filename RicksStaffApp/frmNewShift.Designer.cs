namespace RicksStaffApp
{
    partial class frmNewShift
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
            lblShiftDateDisplay = new Label();
            label1 = new Label();
            dtpShiftDate = new DateTimePicker();
            flowEmployeeShiftDisplay = new FlowLayoutPanel();
            pnlNewShiftDisplay = new Panel();
            btnGetExcelEmployees = new Button();
            SuspendLayout();
            // 
            // lblShiftDateDisplay
            // 
            lblShiftDateDisplay.AutoSize = true;
            lblShiftDateDisplay.ForeColor = Color.White;
            lblShiftDateDisplay.Location = new Point(22, 69);
            lblShiftDateDisplay.Name = "lblShiftDateDisplay";
            lblShiftDateDisplay.Size = new Size(96, 15);
            lblShiftDateDisplay.TabIndex = 1;
            lblShiftDateDisplay.Text = "Shift On Date Of:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(373, 102);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 3;
            label1.Text = "Quick Add Incident";
            // 
            // dtpShiftDate
            // 
            dtpShiftDate.Location = new Point(124, 63);
            dtpShiftDate.Name = "dtpShiftDate";
            dtpShiftDate.Size = new Size(200, 23);
            dtpShiftDate.TabIndex = 5;
            dtpShiftDate.ValueChanged += dtpShiftDate_ValueChanged;
            // 
            // flowEmployeeShiftDisplay
            // 
            flowEmployeeShiftDisplay.AutoScroll = true;
            flowEmployeeShiftDisplay.BackColor = Color.FromArgb(37, 42, 64);
            flowEmployeeShiftDisplay.Location = new Point(22, 120);
            flowEmployeeShiftDisplay.Name = "flowEmployeeShiftDisplay";
            flowEmployeeShiftDisplay.Size = new Size(475, 630);
            flowEmployeeShiftDisplay.TabIndex = 6;
            // 
            // pnlNewShiftDisplay
            // 
            pnlNewShiftDisplay.BackColor = Color.FromArgb(69, 105, 144);
            pnlNewShiftDisplay.Location = new Point(503, 120);
            pnlNewShiftDisplay.Name = "pnlNewShiftDisplay";
            pnlNewShiftDisplay.Size = new Size(775, 630);
            pnlNewShiftDisplay.TabIndex = 7;
            // 
            // btnGetExcelEmployees
            // 
            btnGetExcelEmployees.BackColor = Color.FromArgb(167, 204, 237);
            btnGetExcelEmployees.FlatAppearance.BorderSize = 0;
            btnGetExcelEmployees.FlatStyle = FlatStyle.Flat;
            btnGetExcelEmployees.Location = new Point(503, 69);
            btnGetExcelEmployees.Name = "btnGetExcelEmployees";
            btnGetExcelEmployees.Size = new Size(236, 45);
            btnGetExcelEmployees.TabIndex = 8;
            btnGetExcelEmployees.Text = "Load Employees";
            btnGetExcelEmployees.UseVisualStyleBackColor = false;
            btnGetExcelEmployees.Click += btnGetExcelEmployees_Click;
            // 
            // frmNewShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1300, 775);
            Controls.Add(btnGetExcelEmployees);
            Controls.Add(pnlNewShiftDisplay);
            Controls.Add(flowEmployeeShiftDisplay);
            Controls.Add(dtpShiftDate);
            Controls.Add(label1);
            Controls.Add(lblShiftDateDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNewShift";
            Text = "frmNewShift";
            Load += frmNewShift_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblShiftDateDisplay;
        private Label label1;
        private DateTimePicker dtpShiftDate;
        private FlowLayoutPanel flowEmployeeShiftDisplay;
        private Panel pnlNewShiftDisplay;
        private Button btnGetExcelEmployees;
    }
}