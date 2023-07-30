namespace RicksStaffApp
{
    partial class frmTest
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
            btnLoadEmployees = new Button();
            btnLoadShifts = new Button();
            btnLoadEmployeeShifts = new Button();
            btnLoadIncidents = new Button();
            btnLoadActivities = new Button();
            pnlEmployeeStatsTest = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            flowEmployeeRankingsTest = new FlowLayoutPanel();
            lblMainWindowDescriptionTest = new Label();
            btnResetTest = new Button();
            pnlEmployeeStatsTest.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLoadEmployees
            // 
            btnLoadEmployees.Location = new Point(49, 59);
            btnLoadEmployees.Name = "btnLoadEmployees";
            btnLoadEmployees.Size = new Size(117, 23);
            btnLoadEmployees.TabIndex = 0;
            btnLoadEmployees.Text = "Load Employees";
            btnLoadEmployees.UseVisualStyleBackColor = true;
            btnLoadEmployees.Click += btnLoadEmployees_Click;
            // 
            // btnLoadShifts
            // 
            btnLoadShifts.Location = new Point(193, 59);
            btnLoadShifts.Name = "btnLoadShifts";
            btnLoadShifts.Size = new Size(75, 23);
            btnLoadShifts.TabIndex = 0;
            btnLoadShifts.Text = "Load Shifts";
            btnLoadShifts.UseVisualStyleBackColor = true;
            btnLoadShifts.Click += btnLoadShifts_Click;
            // 
            // btnLoadEmployeeShifts
            // 
            btnLoadEmployeeShifts.Location = new Point(288, 59);
            btnLoadEmployeeShifts.Name = "btnLoadEmployeeShifts";
            btnLoadEmployeeShifts.Size = new Size(141, 23);
            btnLoadEmployeeShifts.TabIndex = 0;
            btnLoadEmployeeShifts.Text = "Load Employee Shifts";
            btnLoadEmployeeShifts.UseVisualStyleBackColor = true;
            btnLoadEmployeeShifts.Click += btnLoadEmployeeShifts_Click;
            // 
            // btnLoadIncidents
            // 
            btnLoadIncidents.Location = new Point(476, 59);
            btnLoadIncidents.Name = "btnLoadIncidents";
            btnLoadIncidents.Size = new Size(146, 23);
            btnLoadIncidents.TabIndex = 0;
            btnLoadIncidents.Text = "Load Incidents";
            btnLoadIncidents.UseVisualStyleBackColor = true;
            btnLoadIncidents.Click += btnLoadIncidents_Click;
            // 
            // btnLoadActivities
            // 
            btnLoadActivities.Location = new Point(699, 59);
            btnLoadActivities.Name = "btnLoadActivities";
            btnLoadActivities.Size = new Size(126, 23);
            btnLoadActivities.TabIndex = 1;
            btnLoadActivities.Text = "Load Activities";
            btnLoadActivities.UseVisualStyleBackColor = true;
            btnLoadActivities.Click += btnLoadActivities_Click;
            // 
            // pnlEmployeeStatsTest
            // 
            pnlEmployeeStatsTest.BackColor = Color.FromArgb(37, 42, 64);
            pnlEmployeeStatsTest.Controls.Add(panel2);
            pnlEmployeeStatsTest.Location = new Point(29, 145);
            pnlEmployeeStatsTest.Name = "pnlEmployeeStatsTest";
            pnlEmployeeStatsTest.Size = new Size(475, 507);
            pnlEmployeeStatsTest.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(142, 164, 210);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 30);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(167, 204, 237);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gill Sans MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(207, -1);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 2;
            button1.Text = "3 Incidents";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.EightStars;
            pictureBox1.Location = new Point(330, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(426, 0);
            label2.Name = "label2";
            label2.Size = new Size(30, 30);
            label2.TabIndex = 0;
            label2.Text = "8";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Left;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 30);
            label3.TabIndex = 0;
            label3.Text = "Monday";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(81, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 30);
            label1.TabIndex = 0;
            label1.Text = "May 1st, 23";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowEmployeeRankingsTest
            // 
            flowEmployeeRankingsTest.BackColor = Color.FromArgb(37, 42, 64);
            flowEmployeeRankingsTest.Location = new Point(545, 132);
            flowEmployeeRankingsTest.Name = "flowEmployeeRankingsTest";
            flowEmployeeRankingsTest.Size = new Size(440, 574);
            flowEmployeeRankingsTest.TabIndex = 3;
            // 
            // lblMainWindowDescriptionTest
            // 
            lblMainWindowDescriptionTest.AutoSize = true;
            lblMainWindowDescriptionTest.ForeColor = Color.White;
            lblMainWindowDescriptionTest.Location = new Point(678, 99);
            lblMainWindowDescriptionTest.Name = "lblMainWindowDescriptionTest";
            lblMainWindowDescriptionTest.Size = new Size(38, 15);
            lblMainWindowDescriptionTest.TabIndex = 4;
            lblMainWindowDescriptionTest.Text = "label4";
            // 
            // btnResetTest
            // 
            btnResetTest.Location = new Point(910, 91);
            btnResetTest.Name = "btnResetTest";
            btnResetTest.Size = new Size(75, 23);
            btnResetTest.TabIndex = 5;
            btnResetTest.Text = "Reset";
            btnResetTest.UseVisualStyleBackColor = true;
            // 
            // frmTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1110, 740);
            Controls.Add(btnResetTest);
            Controls.Add(lblMainWindowDescriptionTest);
            Controls.Add(flowEmployeeRankingsTest);
            Controls.Add(pnlEmployeeStatsTest);
            Controls.Add(btnLoadActivities);
            Controls.Add(btnLoadIncidents);
            Controls.Add(btnLoadEmployeeShifts);
            Controls.Add(btnLoadShifts);
            Controls.Add(btnLoadEmployees);
            Name = "frmTest";
            Text = "frmTest";
            pnlEmployeeStatsTest.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoadEmployees;
        private Button btnLoadShifts;
        private Button btnLoadEmployeeShifts;
        private Button btnLoadIncidents;
        private Button btnLoadActivities;
        private Panel pnlEmployeeStatsTest;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowEmployeeRankingsTest;
        private Label lblMainWindowDescriptionTest;
        private Button btnResetTest;
    }
}