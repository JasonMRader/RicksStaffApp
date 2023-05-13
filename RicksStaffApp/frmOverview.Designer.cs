namespace RicksStaffApp
{
    partial class frmOverview
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
            pnlEmployeeDisplay = new Panel();
            flowEmployeeDisplay = new FlowLayoutPanel();
            btnAddEmployee = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            comboBox3 = new ComboBox();
            label1 = new Label();
            pnlEmployeeStats = new Panel();
            label5 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            pnlEmployeeDisplay.SuspendLayout();
            pnlEmployeeStats.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEmployeeDisplay
            // 
            pnlEmployeeDisplay.BackColor = Color.FromArgb(37, 42, 64);
            pnlEmployeeDisplay.Controls.Add(flowEmployeeDisplay);
            pnlEmployeeDisplay.Controls.Add(btnAddEmployee);
            pnlEmployeeDisplay.Controls.Add(label6);
            pnlEmployeeDisplay.Controls.Add(textBox1);
            pnlEmployeeDisplay.Controls.Add(comboBox3);
            pnlEmployeeDisplay.Controls.Add(label1);
            pnlEmployeeDisplay.Location = new Point(827, 72);
            pnlEmployeeDisplay.Margin = new Padding(8);
            pnlEmployeeDisplay.Name = "pnlEmployeeDisplay";
            pnlEmployeeDisplay.Padding = new Padding(8);
            pnlEmployeeDisplay.Size = new Size(450, 675);
            pnlEmployeeDisplay.TabIndex = 0;
            // 
            // flowEmployeeDisplay
            // 
            flowEmployeeDisplay.AutoScroll = true;
            flowEmployeeDisplay.Location = new Point(11, 112);
            flowEmployeeDisplay.Name = "flowEmployeeDisplay";
            flowEmployeeDisplay.Size = new Size(426, 553);
            flowEmployeeDisplay.TabIndex = 6;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(167, 204, 237);
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.Location = new Point(350, 0);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(100, 23);
            btnAddEmployee.TabIndex = 4;
            btnAddEmployee.Text = "Edit Employees";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(242, 19);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 2;
            label6.Text = "Position";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 23);
            textBox1.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "This Week", "Last Week", "This Month", "Last Month", "Other" });
            comboBox3.Location = new Point(242, 44);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 22);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 2;
            label1.Text = "Search Employees";
            // 
            // pnlEmployeeStats
            // 
            pnlEmployeeStats.BackColor = Color.FromArgb(37, 42, 64);
            pnlEmployeeStats.Controls.Add(label2);
            pnlEmployeeStats.Location = new Point(17, 72);
            pnlEmployeeStats.Margin = new Padding(8);
            pnlEmployeeStats.Name = "pnlEmployeeStats";
            pnlEmployeeStats.Size = new Size(800, 675);
            pnlEmployeeStats.TabIndex = 0;
            pnlEmployeeStats.Paint += panel2_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(247, 15);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 2;
            label5.Text = "Position";
            label5.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(51, 15);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 2;
            label4.Text = "Timeframe";
            label4.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.ScrollBar;
            comboBox2.Enabled = false;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "This Week", "Last Week", "This Month", "Last Month", "Other" });
            comboBox2.Location = new Point(303, 12);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 1;
            comboBox2.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ScrollBar;
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "This Week", "Last Week", "This Month", "Last Month", "Other" });
            comboBox1.Location = new Point(120, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 4);
            label2.Name = "label2";
            label2.Size = new Size(98, 30);
            label2.TabIndex = 0;
            label2.Text = "Overview";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(990, 31);
            label3.Name = "label3";
            label3.Size = new Size(112, 30);
            label3.TabIndex = 1;
            label3.Text = "Employees";
            // 
            // frmOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1300, 775);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(pnlEmployeeStats);
            Controls.Add(comboBox1);
            Controls.Add(pnlEmployeeDisplay);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1320, 820);
            Name = "frmOverview";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmOverview";
            TopMost = true;
            Load += frmOverview_Load;
            pnlEmployeeDisplay.ResumeLayout(false);
            pnlEmployeeDisplay.PerformLayout();
            pnlEmployeeStats.ResumeLayout(false);
            pnlEmployeeStats.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlEmployeeDisplay;
        private Panel pnlEmployeeStats;
        private Panel panel4;
        private Panel panel3;
        private Label label6;
        private TextBox textBox1;
        private ComboBox comboBox3;
        private Label label1;
        private Label label5;
        private Label label4;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Button btnAddEmployee;
        private FlowLayoutPanel flowEmployeeDisplay;
    }
}