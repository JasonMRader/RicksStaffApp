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
            flowEmployeeRankings = new FlowLayoutPanel();
            flowEmployeeDisplay = new FlowLayoutPanel();
            txtBxEmployeeSearch = new TextBox();
            comboBox3 = new ComboBox();
            btnAddEmployee = new Button();
            pnlEmployeeStats = new Panel();
            flowMostFrequentIncidents = new FlowLayoutPanel();
            flowShiftRankings = new FlowLayoutPanel();
            flowGoodShiftRankings = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            cboViewType = new ComboBox();
            cboTimeFrame = new ComboBox();
            cboSortBy = new ComboBox();
            lblMainWindowDescription = new Label();
            btnReset = new Button();
            cboPositions = new ComboBox();
            lbTimeFrame = new ListBox();
            lbSortBy = new ListBox();
            lbViewType = new ListBox();
            lbPositions = new ListBox();
            pnlEmployeeDisplay.SuspendLayout();
            pnlEmployeeStats.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEmployeeDisplay
            // 
            pnlEmployeeDisplay.BackColor = Color.FromArgb(46, 51, 73);
            pnlEmployeeDisplay.Controls.Add(flowEmployeeRankings);
            pnlEmployeeDisplay.Location = new Point(17, 119);
            pnlEmployeeDisplay.Margin = new Padding(8);
            pnlEmployeeDisplay.Name = "pnlEmployeeDisplay";
            pnlEmployeeDisplay.Padding = new Padding(8);
            pnlEmployeeDisplay.Size = new Size(450, 639);
            pnlEmployeeDisplay.TabIndex = 0;
            // 
            // flowEmployeeRankings
            // 
            flowEmployeeRankings.AutoScroll = true;
            flowEmployeeRankings.BackColor = Color.FromArgb(37, 42, 64);
            flowEmployeeRankings.Location = new Point(10, 3);
            flowEmployeeRankings.Name = "flowEmployeeRankings";
            flowEmployeeRankings.Padding = new Padding(0, 10, 0, 0);
            flowEmployeeRankings.Size = new Size(440, 638);
            flowEmployeeRankings.TabIndex = 2;
            // 
            // flowEmployeeDisplay
            // 
            flowEmployeeDisplay.AutoScroll = true;
            flowEmployeeDisplay.BackColor = Color.FromArgb(37, 42, 64);
            flowEmployeeDisplay.Location = new Point(61, 4);
            flowEmployeeDisplay.Name = "flowEmployeeDisplay";
            flowEmployeeDisplay.Padding = new Padding(15, 15, 0, 0);
            flowEmployeeDisplay.Size = new Size(35, 19);
            flowEmployeeDisplay.TabIndex = 6;
            flowEmployeeDisplay.Visible = false;
            // 
            // txtBxEmployeeSearch
            // 
            txtBxEmployeeSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBxEmployeeSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBxEmployeeSearch.Location = new Point(17, 0);
            txtBxEmployeeSearch.Name = "txtBxEmployeeSearch";
            txtBxEmployeeSearch.PlaceholderText = "Search Employees";
            txtBxEmployeeSearch.Size = new Size(38, 23);
            txtBxEmployeeSearch.TabIndex = 3;
            txtBxEmployeeSearch.Visible = false;
            txtBxEmployeeSearch.TextChanged += txtBxEmployeeSearch_TextChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Position", "Server", "Busser", "Runner", "Host", "Barback", "Valet", "Bartender" });
            comboBox3.Location = new Point(102, 0);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(28, 23);
            comboBox3.TabIndex = 1;
            comboBox3.Visible = false;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(167, 204, 237);
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.Location = new Point(136, -1);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(37, 23);
            btnAddEmployee.TabIndex = 4;
            btnAddEmployee.Text = "Edit Employees";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Visible = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // pnlEmployeeStats
            // 
            pnlEmployeeStats.BackColor = Color.FromArgb(46, 51, 73);
            pnlEmployeeStats.Controls.Add(flowMostFrequentIncidents);
            pnlEmployeeStats.Controls.Add(flowShiftRankings);
            pnlEmployeeStats.Controls.Add(flowGoodShiftRankings);
            pnlEmployeeStats.Controls.Add(label2);
            pnlEmployeeStats.Controls.Add(label3);
            pnlEmployeeStats.Controls.Add(label1);
            pnlEmployeeStats.Location = new Point(483, 101);
            pnlEmployeeStats.Margin = new Padding(8);
            pnlEmployeeStats.Name = "pnlEmployeeStats";
            pnlEmployeeStats.Size = new Size(800, 675);
            pnlEmployeeStats.TabIndex = 0;
            pnlEmployeeStats.Paint += panel2_Paint;
            // 
            // flowMostFrequentIncidents
            // 
            flowMostFrequentIncidents.BackColor = Color.FromArgb(37, 42, 64);
            flowMostFrequentIncidents.Location = new Point(13, 44);
            flowMostFrequentIncidents.Name = "flowMostFrequentIncidents";
            flowMostFrequentIncidents.Size = new Size(240, 600);
            flowMostFrequentIncidents.TabIndex = 12;
            // 
            // flowShiftRankings
            // 
            flowShiftRankings.BackColor = Color.FromArgb(37, 42, 64);
            flowShiftRankings.Location = new Point(279, 42);
            flowShiftRankings.Name = "flowShiftRankings";
            flowShiftRankings.Padding = new Padding(0, 10, 0, 0);
            flowShiftRankings.Size = new Size(240, 600);
            flowShiftRankings.TabIndex = 11;
            // 
            // flowGoodShiftRankings
            // 
            flowGoodShiftRankings.BackColor = Color.FromArgb(37, 42, 64);
            flowGoodShiftRankings.FlowDirection = FlowDirection.TopDown;
            flowGoodShiftRankings.Location = new Point(548, 42);
            flowGoodShiftRankings.Name = "flowGoodShiftRankings";
            flowGoodShiftRankings.Padding = new Padding(0, 10, 0, 0);
            flowGoodShiftRankings.Size = new Size(240, 600);
            flowGoodShiftRankings.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(279, 18);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 9;
            label2.Text = "Best Shifts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 18);
            label3.Name = "label3";
            label3.Size = new Size(190, 21);
            label3.TabIndex = 8;
            label3.Text = "Most Common Incidents";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(548, 18);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 8;
            label1.Text = "Good Shift Rankings";
            // 
            // cboViewType
            // 
            cboViewType.BackColor = Color.FromArgb(74, 79, 99);
            cboViewType.FlatStyle = FlatStyle.Flat;
            cboViewType.ForeColor = Color.White;
            cboViewType.FormattingEnabled = true;
            cboViewType.Items.AddRange(new object[] { "Employees", "Employee Shifts" });
            cboViewType.Location = new Point(742, 41);
            cboViewType.Name = "cboViewType";
            cboViewType.Size = new Size(157, 23);
            cboViewType.TabIndex = 12;
            cboViewType.Visible = false;
            cboViewType.SelectedIndexChanged += cboViewType_SelectedIndexChanged;
            // 
            // cboTimeFrame
            // 
            cboTimeFrame.BackColor = Color.FromArgb(74, 79, 99);
            cboTimeFrame.FlatStyle = FlatStyle.Flat;
            cboTimeFrame.ForeColor = Color.White;
            cboTimeFrame.FormattingEnabled = true;
            cboTimeFrame.Items.AddRange(new object[] { "All Time", "This Week", "Last Week", "This Month", "Last Month", "Other" });
            cboTimeFrame.Location = new Point(742, 12);
            cboTimeFrame.Name = "cboTimeFrame";
            cboTimeFrame.Size = new Size(157, 23);
            cboTimeFrame.TabIndex = 1;
            cboTimeFrame.Visible = false;
            // 
            // cboSortBy
            // 
            cboSortBy.BackColor = Color.FromArgb(74, 79, 99);
            cboSortBy.FlatStyle = FlatStyle.Flat;
            cboSortBy.ForeColor = Color.White;
            cboSortBy.FormattingEnabled = true;
            cboSortBy.Items.AddRange(new object[] { "Highest Rated", "Lowest Rated", "Most Recent", "Alphabetical" });
            cboSortBy.Location = new Point(579, 12);
            cboSortBy.Name = "cboSortBy";
            cboSortBy.Size = new Size(157, 23);
            cboSortBy.TabIndex = 12;
            cboSortBy.Visible = false;
            cboSortBy.SelectedIndexChanged += cboViewType_SelectedIndexChanged;
            // 
            // lblMainWindowDescription
            // 
            lblMainWindowDescription.AutoSize = true;
            lblMainWindowDescription.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMainWindowDescription.ForeColor = Color.White;
            lblMainWindowDescription.Location = new Point(608, 38);
            lblMainWindowDescription.Name = "lblMainWindowDescription";
            lblMainWindowDescription.Size = new Size(128, 35);
            lblMainWindowDescription.TabIndex = 0;
            lblMainWindowDescription.Text = "Overview";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(167, 204, 237);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(1250, 67);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(33, 23);
            btnReset.TabIndex = 3;
            btnReset.Text = "X";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Visible = false;
            btnReset.Click += btnReset_Click;
            // 
            // cboPositions
            // 
            cboPositions.BackColor = Color.FromArgb(74, 79, 99);
            cboPositions.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPositions.FlatStyle = FlatStyle.Flat;
            cboPositions.ForeColor = Color.White;
            cboPositions.FormattingEnabled = true;
            cboPositions.Location = new Point(927, 12);
            cboPositions.Name = "cboPositions";
            cboPositions.Size = new Size(157, 23);
            cboPositions.TabIndex = 1;
            cboPositions.Visible = false;
            // 
            // lbTimeFrame
            // 
            lbTimeFrame.BackColor = Color.FromArgb(74, 79, 99);
            lbTimeFrame.BorderStyle = BorderStyle.None;
            lbTimeFrame.ForeColor = Color.White;
            lbTimeFrame.FormattingEnabled = true;
            lbTimeFrame.ItemHeight = 15;
            lbTimeFrame.Items.AddRange(new object[] { "All Time", "This Week", "Last Week", "This Month", "Last Month", "Other" });
            lbTimeFrame.Location = new Point(25, 41);
            lbTimeFrame.Name = "lbTimeFrame";
            lbTimeFrame.Size = new Size(105, 75);
            lbTimeFrame.TabIndex = 13;
            // 
            // lbSortBy
            // 
            lbSortBy.BackColor = Color.FromArgb(74, 79, 99);
            lbSortBy.BorderStyle = BorderStyle.None;
            lbSortBy.ForeColor = Color.White;
            lbSortBy.FormattingEnabled = true;
            lbSortBy.ItemHeight = 15;
            lbSortBy.Items.AddRange(new object[] { "Highest Rated", "Lowest Rated", "Most Recent", "Alphabetical" });
            lbSortBy.Location = new Point(139, 41);
            lbSortBy.Name = "lbSortBy";
            lbSortBy.Size = new Size(105, 75);
            lbSortBy.TabIndex = 14;
            // 
            // lbViewType
            // 
            lbViewType.BackColor = Color.FromArgb(74, 79, 99);
            lbViewType.BorderStyle = BorderStyle.None;
            lbViewType.ForeColor = Color.White;
            lbViewType.FormattingEnabled = true;
            lbViewType.ItemHeight = 15;
            lbViewType.Items.AddRange(new object[] { "Employees", "Employee Shifts" });
            lbViewType.Location = new Point(250, 41);
            lbViewType.Name = "lbViewType";
            lbViewType.Size = new Size(105, 75);
            lbViewType.TabIndex = 15;
            // 
            // lbPositions
            // 
            lbPositions.BackColor = Color.FromArgb(74, 79, 99);
            lbPositions.BorderStyle = BorderStyle.None;
            lbPositions.ForeColor = Color.White;
            lbPositions.FormattingEnabled = true;
            lbPositions.ItemHeight = 15;
            lbPositions.Location = new Point(361, 41);
            lbPositions.Name = "lbPositions";
            lbPositions.Size = new Size(105, 75);
            lbPositions.TabIndex = 16;
            // 
            // frmOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1300, 775);
            Controls.Add(lbPositions);
            Controls.Add(lbViewType);
            Controls.Add(lbSortBy);
            Controls.Add(lbTimeFrame);
            Controls.Add(btnReset);
            Controls.Add(comboBox3);
            Controls.Add(txtBxEmployeeSearch);
            Controls.Add(flowEmployeeDisplay);
            Controls.Add(cboViewType);
            Controls.Add(cboSortBy);
            Controls.Add(btnAddEmployee);
            Controls.Add(cboTimeFrame);
            Controls.Add(lblMainWindowDescription);
            Controls.Add(pnlEmployeeStats);
            Controls.Add(cboPositions);
            Controls.Add(pnlEmployeeDisplay);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1320, 820);
            Name = "frmOverview";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmOverview";
            TopMost = true;
            Load += frmOverview_Load;
            pnlEmployeeDisplay.ResumeLayout(false);
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
        private ComboBox cboTimeFrame;
        private Label lblMainWindowDescription;
        private Button btnAddEmployee;
        private FlowLayoutPanel flowEmployeeDisplay;
        private FlowLayoutPanel flowEmployeeRankings;
        private Button btnReset;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowGoodShiftRankings;
        private FlowLayoutPanel flowShiftRankings;
        private ComboBox cboViewType;
        private ComboBox cboSortBy;
        private ComboBox cboPositions;
        private ListBox lbTimeFrame;
        private ListBox lbSortBy;
        private ListBox lbViewType;
        private ListBox lbPositions;
        private FlowLayoutPanel flowMostFrequentIncidents;
        private Label label3;
    }
}