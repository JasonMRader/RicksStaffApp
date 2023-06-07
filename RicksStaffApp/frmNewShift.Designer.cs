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
            dtpShiftDate = new DateTimePicker();
            flowEmployeeShiftDisplay = new FlowLayoutPanel();
            pnlNewShiftDisplay = new Panel();
            btnGetExcelEmployees = new Button();
            flowShiftDates = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // dtpShiftDate
            // 
            dtpShiftDate.CalendarMonthBackground = SystemColors.ScrollBar;
            dtpShiftDate.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dtpShiftDate.Location = new Point(22, 79);
            dtpShiftDate.Name = "dtpShiftDate";
            dtpShiftDate.Size = new Size(475, 36);
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
            pnlNewShiftDisplay.BackColor = Color.FromArgb(37, 42, 64);
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
            btnGetExcelEmployees.Location = new Point(1115, 91);
            btnGetExcelEmployees.Name = "btnGetExcelEmployees";
            btnGetExcelEmployees.Size = new Size(163, 23);
            btnGetExcelEmployees.TabIndex = 8;
            btnGetExcelEmployees.Text = "Load Employees";
            btnGetExcelEmployees.UseVisualStyleBackColor = false;
            btnGetExcelEmployees.Visible = false;
            btnGetExcelEmployees.Click += btnGetExcelEmployees_Click;
            // 
            // flowShiftDates
            // 
            flowShiftDates.BackColor = Color.FromArgb(37, 42, 64);
            flowShiftDates.Location = new Point(22, 1);
            flowShiftDates.Name = "flowShiftDates";
            flowShiftDates.Padding = new Padding(13, 0, 0, 0);
            flowShiftDates.Size = new Size(1256, 75);
            flowShiftDates.TabIndex = 9;
            // 
            // frmNewShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1300, 775);
            Controls.Add(flowShiftDates);
            Controls.Add(btnGetExcelEmployees);
            Controls.Add(pnlNewShiftDisplay);
            Controls.Add(flowEmployeeShiftDisplay);
            Controls.Add(dtpShiftDate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNewShift";
            Text = "frmNewShift";
            Load += frmNewShift_Load;
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dtpShiftDate;
        private FlowLayoutPanel flowEmployeeShiftDisplay;
        private Panel pnlNewShiftDisplay;
        private Button btnGetExcelEmployees;
        private FlowLayoutPanel flowShiftDates;
    }
}