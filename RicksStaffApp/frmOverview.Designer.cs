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
            txtBxEmployeeSearch = new TextBox();
            comboBox3 = new ComboBox();
            btnAddEmployee = new Button();
            pnlEmployeeStats = new Panel();
            flowGoodShiftRankings = new FlowLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            flowEmployeeRankings = new FlowLayoutPanel();
            comboBox1 = new ComboBox();
            label7 = new Label();
            lblMainWindowDescription = new Label();
            label5 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            btnReset = new Button();
            flowShiftRankings = new FlowLayoutPanel();
            pnlEmployeeDisplay.SuspendLayout();
            pnlEmployeeStats.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEmployeeDisplay
            // 
            pnlEmployeeDisplay.BackColor = Color.FromArgb(46, 51, 73);
            pnlEmployeeDisplay.Controls.Add(flowEmployeeDisplay);
            pnlEmployeeDisplay.Controls.Add(txtBxEmployeeSearch);
            pnlEmployeeDisplay.Controls.Add(comboBox3);
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
            flowEmployeeDisplay.BackColor = Color.FromArgb(37, 42, 64);
            flowEmployeeDisplay.Location = new Point(11, 43);
            flowEmployeeDisplay.Name = "flowEmployeeDisplay";
            flowEmployeeDisplay.Padding = new Padding(15, 15, 0, 0);
            flowEmployeeDisplay.Size = new Size(426, 597);
            flowEmployeeDisplay.TabIndex = 6;
            // 
            // txtBxEmployeeSearch
            // 
            txtBxEmployeeSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBxEmployeeSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBxEmployeeSearch.Location = new Point(11, 11);
            txtBxEmployeeSearch.Name = "txtBxEmployeeSearch";
            txtBxEmployeeSearch.PlaceholderText = "Search Employees";
            txtBxEmployeeSearch.Size = new Size(179, 23);
            txtBxEmployeeSearch.TabIndex = 3;
            txtBxEmployeeSearch.TextChanged += txtBxEmployeeSearch_TextChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Position", "Server", "Busser", "Runner", "Host", "Barback", "Valet", "Bartender" });
            comboBox3.Location = new Point(221, 11);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(133, 23);
            comboBox3.TabIndex = 1;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(167, 204, 237);
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.Location = new Point(1177, 39);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(100, 23);
            btnAddEmployee.TabIndex = 4;
            btnAddEmployee.Text = "Edit Employees";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // pnlEmployeeStats
            // 
            pnlEmployeeStats.BackColor = Color.FromArgb(46, 51, 73);
            pnlEmployeeStats.Controls.Add(flowShiftRankings);
            pnlEmployeeStats.Controls.Add(flowGoodShiftRankings);
            pnlEmployeeStats.Controls.Add(label2);
            pnlEmployeeStats.Controls.Add(label1);
            pnlEmployeeStats.Controls.Add(flowEmployeeRankings);
            pnlEmployeeStats.Controls.Add(comboBox1);
            pnlEmployeeStats.Controls.Add(label7);
            pnlEmployeeStats.Location = new Point(17, 72);
            pnlEmployeeStats.Margin = new Padding(8);
            pnlEmployeeStats.Name = "pnlEmployeeStats";
            pnlEmployeeStats.Size = new Size(800, 675);
            pnlEmployeeStats.TabIndex = 0;
            pnlEmployeeStats.Paint += panel2_Paint;
            // 
            // flowGoodShiftRankings
            // 
            flowGoodShiftRankings.BackColor = Color.FromArgb(37, 42, 64);
            flowGoodShiftRankings.FlowDirection = FlowDirection.TopDown;
            flowGoodShiftRankings.Location = new Point(23, 44);
            flowGoodShiftRankings.Name = "flowGoodShiftRankings";
            flowGoodShiftRankings.Size = new Size(210, 247);
            flowGoodShiftRankings.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(75, 317);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 9;
            label2.Text = "Best Shifts";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 14);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 8;
            label1.Text = "Good Shift Rankings";
            // 
            // flowEmployeeRankings
            // 
            flowEmployeeRankings.BackColor = Color.FromArgb(37, 42, 64);
            flowEmployeeRankings.Location = new Point(255, 43);
            flowEmployeeRankings.Name = "flowEmployeeRankings";
            flowEmployeeRankings.Padding = new Padding(0, 10, 0, 0);
            flowEmployeeRankings.Size = new Size(501, 598);
            flowEmployeeRankings.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(74, 79, 99);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "This Week", "Last Week", "This Month", "Last Month", "Other" });
            comboBox1.Location = new Point(609, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 23);
            comboBox1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(415, 13);
            label7.Name = "label7";
            label7.Size = new Size(136, 25);
            label7.TabIndex = 1;
            label7.Text = "Highest Rated";
            // 
            // lblMainWindowDescription
            // 
            lblMainWindowDescription.AutoSize = true;
            lblMainWindowDescription.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMainWindowDescription.ForeColor = Color.White;
            lblMainWindowDescription.Location = new Point(303, 26);
            lblMainWindowDescription.Name = "lblMainWindowDescription";
            lblMainWindowDescription.Size = new Size(250, 35);
            lblMainWindowDescription.TabIndex = 0;
            lblMainWindowDescription.Text = "Employee Overview";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(144, 9);
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
            label4.Location = new Point(17, 9);
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
            comboBox2.Location = new Point(144, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 1;
            comboBox2.Visible = false;
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
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(167, 204, 237);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(559, 31);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(33, 23);
            btnReset.TabIndex = 3;
            btnReset.Text = "X";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Visible = false;
            btnReset.Click += btnReset_Click;
            // 
            // flowShiftRankings
            // 
            flowShiftRankings.BackColor = Color.FromArgb(37, 42, 64);
            flowShiftRankings.Location = new Point(23, 341);
            flowShiftRankings.Name = "flowShiftRankings";
            flowShiftRankings.Size = new Size(210, 300);
            flowShiftRankings.TabIndex = 11;
            // 
            // frmOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1300, 775);
            Controls.Add(btnReset);
            Controls.Add(btnAddEmployee);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(lblMainWindowDescription);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(pnlEmployeeStats);
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
        private TextBox txtBxEmployeeSearch;
        private ComboBox comboBox3;
        private Label label5;
        private Label label4;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label lblMainWindowDescription;
        private Label label3;
        private Button btnAddEmployee;
        private FlowLayoutPanel flowEmployeeDisplay;
        private FlowLayoutPanel flowEmployeeRankings;
        private Label label7;
        private Button btnReset;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowGoodShiftRankings;
        private FlowLayoutPanel flowShiftRankings;
    }
}