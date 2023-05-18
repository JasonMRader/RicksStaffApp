namespace RicksStaffApp
{
    partial class frmExcelDownload
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
            panel1 = new Panel();
            dtpShiftDate = new DateTimePicker();
            btnCreateShift = new Button();
            label3 = new Label();
            label2 = new Label();
            flowExistingStaff = new FlowLayoutPanel();
            flowNewStaff = new FlowLayoutPanel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.Controls.Add(dtpShiftDate);
            panel1.Controls.Add(btnCreateShift);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(flowExistingStaff);
            panel1.Controls.Add(flowNewStaff);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 624);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dtpShiftDate
            // 
            dtpShiftDate.CalendarMonthBackground = SystemColors.InactiveBorder;
            dtpShiftDate.Location = new Point(267, 22);
            dtpShiftDate.Name = "dtpShiftDate";
            dtpShiftDate.Size = new Size(200, 23);
            dtpShiftDate.TabIndex = 6;
            // 
            // btnCreateShift
            // 
            btnCreateShift.BackColor = Color.FromArgb(167, 204, 237);
            btnCreateShift.FlatAppearance.BorderSize = 0;
            btnCreateShift.FlatStyle = FlatStyle.Flat;
            btnCreateShift.Location = new Point(620, 17);
            btnCreateShift.Name = "btnCreateShift";
            btnCreateShift.Size = new Size(121, 36);
            btnCreateShift.TabIndex = 5;
            btnCreateShift.Text = "Create Shift";
            btnCreateShift.UseVisualStyleBackColor = false;
            btnCreateShift.Click += btnCreateShift_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(142, 102);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Existing";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(539, 102);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "New Staff";
            // 
            // flowExistingStaff
            // 
            flowExistingStaff.BackColor = Color.FromArgb(37, 42, 64);
            flowExistingStaff.Location = new Point(3, 120);
            flowExistingStaff.Name = "flowExistingStaff";
            flowExistingStaff.Size = new Size(375, 501);
            flowExistingStaff.TabIndex = 2;
            // 
            // flowNewStaff
            // 
            flowNewStaff.AutoScroll = true;
            flowNewStaff.BackColor = Color.FromArgb(37, 42, 64);
            flowNewStaff.Location = new Point(391, 120);
            flowNewStaff.Name = "flowNewStaff";
            flowNewStaff.Size = new Size(375, 501);
            flowNewStaff.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 8);
            label1.Name = "label1";
            label1.Size = new Size(174, 45);
            label1.TabIndex = 0;
            label1.Text = "Excel Data";
            // 
            // frmExcelDownload
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 105, 144);
            ClientSize = new Size(775, 630);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmExcelDownload";
            Padding = new Padding(3);
            Text = "frmExcelDownload";
            Load += frmExcelDownload_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowNewStaff;
        private FlowLayoutPanel flowExistingStaff;
        private Label label3;
        private Label label2;
        private Button btnCreateShift;
        private DateTimePicker dtpShiftDate;
    }
}