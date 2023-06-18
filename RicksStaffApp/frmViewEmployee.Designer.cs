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
            flowFrequentIncidents = new FlowLayoutPanel();
            panel5 = new Panel();
            label1 = new Label();
            lblBadShiftPercent = new Label();
            lblAverageShiftPercent = new Label();
            lblGoodShiftPercent = new Label();
            lblTotalShifts = new Label();
            lblPoorShifts = new Label();
            lblAverageShifts = new Label();
            lblGoodShifts = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            panel2 = new Panel();
            lblRating = new Label();
            picBoxEmployeeRating = new PictureBox();
            label2 = new Label();
            lblTotalShiftsLabelHeader = new Label();
            cboSeondEmployeeTime = new ComboBox();
            flowEmployeeShifts = new FlowLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxEmployeeRating).BeginInit();
            SuspendLayout();
            // 
            // flowFrequentIncidents
            // 
            flowFrequentIncidents.BackColor = Color.FromArgb(37, 42, 64);
            flowFrequentIncidents.Location = new Point(23, 286);
            flowFrequentIncidents.Name = "flowFrequentIncidents";
            flowFrequentIncidents.Size = new Size(210, 355);
            flowFrequentIncidents.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(37, 42, 64);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(lblBadShiftPercent);
            panel5.Controls.Add(lblAverageShiftPercent);
            panel5.Controls.Add(lblGoodShiftPercent);
            panel5.Controls.Add(lblTotalShifts);
            panel5.Controls.Add(lblPoorShifts);
            panel5.Controls.Add(lblAverageShifts);
            panel5.Controls.Add(lblGoodShifts);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(23, 136);
            panel5.Name = "panel5";
            panel5.Size = new Size(210, 114);
            panel5.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(36, 17);
            label1.TabIndex = 9;
            label1.Text = "Total";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 42, 64);
            panel2.Controls.Add(lblRating);
            panel2.Controls.Add(picBoxEmployeeRating);
            panel2.Location = new Point(23, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 65);
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(62, 268);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 1;
            label2.Text = "Most Frequent Activites";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalShiftsLabelHeader
            // 
            lblTotalShiftsLabelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalShiftsLabelHeader.AutoSize = true;
            lblTotalShiftsLabelHeader.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalShiftsLabelHeader.ForeColor = Color.White;
            lblTotalShiftsLabelHeader.Location = new Point(109, 116);
            lblTotalShiftsLabelHeader.Name = "lblTotalShiftsLabelHeader";
            lblTotalShiftsLabelHeader.Size = new Size(39, 17);
            lblTotalShiftsLabelHeader.TabIndex = 3;
            lblTotalShiftsLabelHeader.Text = "Shifts";
            lblTotalShiftsLabelHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboSeondEmployeeTime
            // 
            cboSeondEmployeeTime.BackColor = Color.FromArgb(74, 79, 99);
            cboSeondEmployeeTime.FlatStyle = FlatStyle.Flat;
            cboSeondEmployeeTime.ForeColor = Color.White;
            cboSeondEmployeeTime.FormattingEnabled = true;
            cboSeondEmployeeTime.Items.AddRange(new object[] { "All Time", "Last 30 Days", "Last 3 Months", "Last 6 Months", "Last Year" });
            cboSeondEmployeeTime.Location = new Point(609, 12);
            cboSeondEmployeeTime.Name = "cboSeondEmployeeTime";
            cboSeondEmployeeTime.Size = new Size(147, 23);
            cboSeondEmployeeTime.TabIndex = 3;
            // 
            // flowEmployeeShifts
            // 
            flowEmployeeShifts.AutoScroll = true;
            flowEmployeeShifts.BackColor = Color.FromArgb(37, 42, 64);
            flowEmployeeShifts.Location = new Point(255, 44);
            flowEmployeeShifts.Name = "flowEmployeeShifts";
            flowEmployeeShifts.Size = new Size(533, 598);
            flowEmployeeShifts.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(101, 12);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 7;
            label3.Text = "Stats";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(450, 12);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 7;
            label4.Text = "Shifts";
            // 
            // frmViewEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(800, 675);
            Controls.Add(label2);
            Controls.Add(flowFrequentIncidents);
            Controls.Add(label4);
            Controls.Add(panel5);
            Controls.Add(lblTotalShiftsLabelHeader);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(cboSeondEmployeeTime);
            Controls.Add(flowEmployeeShifts);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmViewEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmViewEmployee";
            Load += frmViewEmployee_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxEmployeeRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private PictureBox picBoxEmployeeRating;
        private Panel panel5;
        private Label lblGoodShifts;
        private Label label2;
        private Label lblPoorShifts;
        private Label lblAverageShifts;
        private Label label12;
        private Label label11;
        private Label label10;
        private ComboBox cboSeondEmployeeTime;
        private FlowLayoutPanel flowEmployeeShifts;
        private Label lblRating;
        private Label lblBadShiftPercent;
        private Label lblAverageShiftPercent;
        private Label lblGoodShiftPercent;
        private Label lblTotalShifts;
        private Label lblTotalShiftsLabelHeader;
        private FlowLayoutPanel flowFrequentIncidents;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}