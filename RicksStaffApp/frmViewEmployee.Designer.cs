namespace RicksStaffApp
{
    partial class frmViewEmployee
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
            lblEmployeeName = new Label();
            button3 = new Button();
            button2 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            panel3 = new Panel();
            panel5 = new Panel();
            lblBadShiftPercent = new Label();
            lblAverageShiftPercent = new Label();
            lblGoodShiftPercent = new Label();
            lblTotalShifts = new Label();
            lblTotalShiftsLabelHeader = new Label();
            lblPoorShifts = new Label();
            lblAverageShifts = new Label();
            lblGoodShifts = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            panel4 = new Panel();
            panel8 = new Panel();
            label9 = new Label();
            panel7 = new Panel();
            label8 = new Label();
            panel6 = new Panel();
            label5 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            lblRating = new Label();
            picBoxEmployeeRating = new PictureBox();
            cboSeondEmployeeTime = new ComboBox();
            button1 = new Button();
            flowEmployeeShifts = new FlowLayoutPanel();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxEmployeeRating).BeginInit();
            SuspendLayout();
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmployeeName.ForeColor = Color.White;
            lblEmployeeName.Location = new Point(330, 9);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(90, 37);
            lblEmployeeName.TabIndex = 0;
            lblEmployeeName.Text = "label1";
            lblEmployeeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(167, 204, 237);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(549, 106);
            button3.Name = "button3";
            button3.Size = new Size(107, 33);
            button3.TabIndex = 5;
            button3.Text = "Shifts";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(167, 204, 237);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(442, 106);
            button2.Name = "button2";
            button2.Size = new Size(101, 33);
            button2.TabIndex = 5;
            button2.Text = "Stats";
            button2.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(549, 145);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(107, 23);
            dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(442, 145);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(101, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(9, 110);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 510);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(37, 42, 64);
            panel5.Controls.Add(lblBadShiftPercent);
            panel5.Controls.Add(lblAverageShiftPercent);
            panel5.Controls.Add(lblGoodShiftPercent);
            panel5.Controls.Add(lblTotalShifts);
            panel5.Controls.Add(lblTotalShiftsLabelHeader);
            panel5.Controls.Add(lblPoorShifts);
            panel5.Controls.Add(lblAverageShifts);
            panel5.Controls.Add(lblGoodShifts);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(3, 95);
            panel5.Name = "panel5";
            panel5.Size = new Size(191, 114);
            panel5.TabIndex = 2;
            // 
            // lblBadShiftPercent
            // 
            lblBadShiftPercent.AutoSize = true;
            lblBadShiftPercent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBadShiftPercent.ForeColor = Color.FromArgb(226, 163, 199);
            lblBadShiftPercent.Location = new Point(128, 86);
            lblBadShiftPercent.Name = "lblBadShiftPercent";
            lblBadShiftPercent.Size = new Size(32, 21);
            lblBadShiftPercent.TabIndex = 8;
            lblBadShiftPercent.Text = "8%";
            // 
            // lblAverageShiftPercent
            // 
            lblAverageShiftPercent.AutoSize = true;
            lblAverageShiftPercent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAverageShiftPercent.ForeColor = Color.FromArgb(153, 178, 221);
            lblAverageShiftPercent.Location = new Point(123, 60);
            lblAverageShiftPercent.Name = "lblAverageShiftPercent";
            lblAverageShiftPercent.Size = new Size(41, 21);
            lblAverageShiftPercent.TabIndex = 7;
            lblAverageShiftPercent.Text = "40%";
            // 
            // lblGoodShiftPercent
            // 
            lblGoodShiftPercent.AutoSize = true;
            lblGoodShiftPercent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGoodShiftPercent.ForeColor = Color.FromArgb(192, 223, 161);
            lblGoodShiftPercent.Location = new Point(128, 33);
            lblGoodShiftPercent.Name = "lblGoodShiftPercent";
            lblGoodShiftPercent.Size = new Size(41, 21);
            lblGoodShiftPercent.TabIndex = 6;
            lblGoodShiftPercent.Text = "57%";
            // 
            // lblTotalShifts
            // 
            lblTotalShifts.AutoSize = true;
            lblTotalShifts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalShifts.ForeColor = Color.White;
            lblTotalShifts.Location = new Point(85, 6);
            lblTotalShifts.Name = "lblTotalShifts";
            lblTotalShifts.Size = new Size(37, 21);
            lblTotalShifts.TabIndex = 4;
            lblTotalShifts.Text = "100";
            // 
            // lblTotalShiftsLabelHeader
            // 
            lblTotalShiftsLabelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalShiftsLabelHeader.AutoSize = true;
            lblTotalShiftsLabelHeader.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalShiftsLabelHeader.ForeColor = Color.White;
            lblTotalShiftsLabelHeader.Location = new Point(3, 8);
            lblTotalShiftsLabelHeader.Name = "lblTotalShiftsLabelHeader";
            lblTotalShiftsLabelHeader.Size = new Size(39, 17);
            lblTotalShiftsLabelHeader.TabIndex = 3;
            lblTotalShiftsLabelHeader.Text = "Shifts";
            lblTotalShiftsLabelHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPoorShifts
            // 
            lblPoorShifts.AutoSize = true;
            lblPoorShifts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPoorShifts.ForeColor = Color.FromArgb(226, 163, 199);
            lblPoorShifts.Location = new Point(87, 86);
            lblPoorShifts.Name = "lblPoorShifts";
            lblPoorShifts.Size = new Size(19, 21);
            lblPoorShifts.TabIndex = 2;
            lblPoorShifts.Text = "8";
            // 
            // lblAverageShifts
            // 
            lblAverageShifts.AutoSize = true;
            lblAverageShifts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAverageShifts.ForeColor = Color.FromArgb(153, 178, 221);
            lblAverageShifts.Location = new Point(87, 60);
            lblAverageShifts.Name = "lblAverageShifts";
            lblAverageShifts.Size = new Size(28, 21);
            lblAverageShifts.TabIndex = 2;
            lblAverageShifts.Text = "40";
            // 
            // lblGoodShifts
            // 
            lblGoodShifts.AutoSize = true;
            lblGoodShifts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGoodShifts.ForeColor = Color.FromArgb(192, 223, 161);
            lblGoodShifts.Location = new Point(87, 33);
            lblGoodShifts.Name = "lblGoodShifts";
            lblGoodShifts.Size = new Size(28, 21);
            lblGoodShifts.TabIndex = 2;
            lblGoodShifts.Text = "57";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(3, 88);
            label12.Name = "label12";
            label12.Size = new Size(36, 17);
            label12.TabIndex = 1;
            label12.Text = "Poor";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(3, 62);
            label11.Name = "label11";
            label11.Size = new Size(56, 17);
            label11.TabIndex = 1;
            label11.Text = "Average";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(3, 35);
            label10.Name = "label10";
            label10.Size = new Size(41, 17);
            label10.TabIndex = 1;
            label10.Text = "Good";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(37, 42, 64);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(3, 233);
            panel4.Name = "panel4";
            panel4.Size = new Size(191, 200);
            panel4.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(226, 163, 199);
            panel8.Controls.Add(label9);
            panel8.Location = new Point(9, 136);
            panel8.Name = "panel8";
            panel8.Size = new Size(173, 38);
            panel8.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(67, 9);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 0;
            label9.Text = "Late";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(192, 223, 161);
            panel7.Controls.Add(label8);
            panel7.Location = new Point(9, 92);
            panel7.Name = "panel7";
            panel7.Size = new Size(173, 38);
            panel7.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(9, 9);
            label8.Name = "label8";
            label8.Size = new Size(147, 20);
            label8.TabIndex = 0;
            label8.Text = "Went The Extra Mile";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(192, 223, 161);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(9, 48);
            panel6.Name = "panel6";
            panel6.Size = new Size(173, 38);
            panel6.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(35, 9);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 0;
            label5.Text = "Great Attitude";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 14);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 1;
            label2.Text = "Most Frequent Activites:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 42, 64);
            panel2.Controls.Add(lblRating);
            panel2.Controls.Add(picBoxEmployeeRating);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 65);
            panel2.TabIndex = 1;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRating.ForeColor = SystemColors.ButtonHighlight;
            lblRating.Location = new Point(66, 1);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(61, 25);
            lblRating.TabIndex = 1;
            lblRating.Text = "label1";
            // 
            // picBoxEmployeeRating
            // 
            picBoxEmployeeRating.Image = resourse._5_Stars;
            picBoxEmployeeRating.Location = new Point(25, 32);
            picBoxEmployeeRating.Name = "picBoxEmployeeRating";
            picBoxEmployeeRating.Size = new Size(140, 29);
            picBoxEmployeeRating.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxEmployeeRating.TabIndex = 0;
            picBoxEmployeeRating.TabStop = false;
            // 
            // cboSeondEmployeeTime
            // 
            cboSeondEmployeeTime.BackColor = Color.FromArgb(74, 79, 99);
            cboSeondEmployeeTime.Enabled = false;
            cboSeondEmployeeTime.FlatStyle = FlatStyle.Flat;
            cboSeondEmployeeTime.ForeColor = Color.White;
            cboSeondEmployeeTime.FormattingEnabled = true;
            cboSeondEmployeeTime.Items.AddRange(new object[] { "All Time", "Last 30 Days", "Last 3 Months", "Last 6 Months", "Last Year" });
            cboSeondEmployeeTime.Location = new Point(42, 23);
            cboSeondEmployeeTime.Name = "cboSeondEmployeeTime";
            cboSeondEmployeeTime.Size = new Size(121, 23);
            cboSeondEmployeeTime.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(167, 204, 237);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(693, 13);
            button1.Name = "button1";
            button1.Size = new Size(74, 33);
            button1.TabIndex = 2;
            button1.Text = "Finished";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // flowEmployeeShifts
            // 
            flowEmployeeShifts.Location = new Point(255, 205);
            flowEmployeeShifts.Name = "flowEmployeeShifts";
            flowEmployeeShifts.Size = new Size(475, 415);
            flowEmployeeShifts.TabIndex = 6;
            // 
            // frmViewEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 42, 64);
            ClientSize = new Size(800, 675);
            Controls.Add(cboSeondEmployeeTime);
            Controls.Add(flowEmployeeShifts);
            Controls.Add(button1);
            Controls.Add(lblEmployeeName);
            Controls.Add(button3);
            Controls.Add(panel3);
            Controls.Add(button2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmViewEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmViewEmployee";
            Load += frmViewEmployee_Load;
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxEmployeeRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmployeeName;
        private Button button1;
        private Panel panel2;
        private PictureBox picBoxEmployeeRating;
        private Panel panel3;
        private Panel panel5;
        private Label lblGoodShifts;
        private Panel panel4;
        private Label label2;
        private Label lblPoorShifts;
        private Label lblAverageShifts;
        private Panel panel6;
        private Panel panel8;
        private Label label9;
        private Panel panel7;
        private Label label8;
        private Label label5;
        private Label label12;
        private Label label11;
        private Label label10;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox cboSeondEmployeeTime;
        private Button button2;
        private Button button3;
        private FlowLayoutPanel flowEmployeeShifts;
        private Label lblRating;
        private Label lblBadShiftPercent;
        private Label lblAverageShiftPercent;
        private Label lblGoodShiftPercent;
        private Label lblTotalShifts;
        private Label lblTotalShiftsLabelHeader;
    }
}