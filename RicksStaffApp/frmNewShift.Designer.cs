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
            btnForwardDate = new Button();
            btnBackDate = new Button();
            flowPositions = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // dtpShiftDate
            // 
            dtpShiftDate.CalendarMonthBackground = SystemColors.ScrollBar;
            dtpShiftDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpShiftDate.Location = new Point(953, 94);
            dtpShiftDate.Name = "dtpShiftDate";
            dtpShiftDate.Size = new Size(325, 33);
            dtpShiftDate.TabIndex = 5;
            dtpShiftDate.ValueChanged += dtpShiftDate_ValueChanged;
            // 
            // flowEmployeeShiftDisplay
            // 
            flowEmployeeShiftDisplay.AutoScroll = true;
            flowEmployeeShiftDisplay.BackColor = Color.FromArgb(37, 42, 64);
            flowEmployeeShiftDisplay.Location = new Point(22, 133);
            flowEmployeeShiftDisplay.Name = "flowEmployeeShiftDisplay";
            flowEmployeeShiftDisplay.Size = new Size(475, 630);
            flowEmployeeShiftDisplay.TabIndex = 6;
            // 
            // pnlNewShiftDisplay
            // 
            pnlNewShiftDisplay.BackColor = Color.FromArgb(37, 42, 64);
            pnlNewShiftDisplay.Location = new Point(503, 133);
            pnlNewShiftDisplay.Name = "pnlNewShiftDisplay";
            pnlNewShiftDisplay.Size = new Size(775, 630);
            pnlNewShiftDisplay.TabIndex = 7;
            // 
            // btnGetExcelEmployees
            // 
            btnGetExcelEmployees.BackColor = Color.FromArgb(167, 204, 237);
            btnGetExcelEmployees.FlatAppearance.BorderSize = 0;
            btnGetExcelEmployees.FlatStyle = FlatStyle.Flat;
            btnGetExcelEmployees.Location = new Point(1284, 742);
            btnGetExcelEmployees.Name = "btnGetExcelEmployees";
            btnGetExcelEmployees.Size = new Size(18, 11);
            btnGetExcelEmployees.TabIndex = 8;
            btnGetExcelEmployees.Text = "Load Employees";
            btnGetExcelEmployees.UseVisualStyleBackColor = false;
            btnGetExcelEmployees.Visible = false;
            btnGetExcelEmployees.Click += btnGetExcelEmployees_Click;
            // 
            // flowShiftDates
            // 
            flowShiftDates.BackColor = Color.FromArgb(37, 42, 64);
            flowShiftDates.Location = new Point(62, 12);
            flowShiftDates.Name = "flowShiftDates";
            flowShiftDates.Padding = new Padding(13, 0, 0, 0);
            flowShiftDates.Size = new Size(1176, 75);
            flowShiftDates.TabIndex = 9;
            // 
            // btnForwardDate
            // 
            btnForwardDate.BackColor = Color.FromArgb(37, 42, 64);
            btnForwardDate.FlatAppearance.BorderSize = 0;
            btnForwardDate.FlatStyle = FlatStyle.Flat;
            btnForwardDate.Image = Properties.Resources.ForwardArrow;
            btnForwardDate.Location = new Point(1238, 12);
            btnForwardDate.Name = "btnForwardDate";
            btnForwardDate.Size = new Size(40, 75);
            btnForwardDate.TabIndex = 11;
            btnForwardDate.UseVisualStyleBackColor = false;
            btnForwardDate.Click += btnForwardDate_Click;
            // 
            // btnBackDate
            // 
            btnBackDate.BackColor = Color.FromArgb(37, 42, 64);
            btnBackDate.FlatAppearance.BorderSize = 0;
            btnBackDate.FlatStyle = FlatStyle.Flat;
            btnBackDate.Image = Properties.Resources.BackArrow;
            btnBackDate.Location = new Point(22, 12);
            btnBackDate.Name = "btnBackDate";
            btnBackDate.Size = new Size(40, 75);
            btnBackDate.TabIndex = 12;
            btnBackDate.UseVisualStyleBackColor = false;
            btnBackDate.Click += btnBackDate_Click;
            // 
            // flowPositions
            // 
            flowPositions.BackColor = Color.FromArgb(37, 42, 64);
            flowPositions.Location = new Point(22, 93);
            flowPositions.Name = "flowPositions";
            flowPositions.Padding = new Padding(15, 3, 0, 0);
            flowPositions.Size = new Size(925, 34);
            flowPositions.TabIndex = 13;
            // 
            // frmNewShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1300, 775);
            Controls.Add(flowPositions);
            Controls.Add(dtpShiftDate);
            Controls.Add(btnBackDate);
            Controls.Add(btnForwardDate);
            Controls.Add(flowShiftDates);
            Controls.Add(btnGetExcelEmployees);
            Controls.Add(pnlNewShiftDisplay);
            Controls.Add(flowEmployeeShiftDisplay);
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
        private Button btnForwardDate;
        private Button btnBackDate;
        private FlowLayoutPanel flowPositions;
    }
}