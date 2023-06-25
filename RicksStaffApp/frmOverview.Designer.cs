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
            panel1 = new Panel();
            cboViewType = new ComboBox();
            cboSortBy = new ComboBox();
            lbPositions = new ListBox();
            lbTimeFrame = new ListBox();
            cboTimeFrame = new ComboBox();
            cboPositions = new ComboBox();
            lblMainWindowDescription = new Label();
            btnReset = new Button();
            rdoViewEmployees = new RadioButton();
            rdoViewEmployeeShifts = new RadioButton();
            panel2 = new Panel();
            panel3 = new Panel();
            rdoHighestRated = new RadioButton();
            rdoAlphabeticalOrChronological = new RadioButton();
            rdoLowestRated = new RadioButton();
            panel5 = new Panel();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            rdoAllTime = new RadioButton();
            flowPositions = new FlowLayoutPanel();
            btnGoSearch = new Button();
            pnlEmployeeStats.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // flowEmployeeRankings
            // 
            flowEmployeeRankings.AutoScroll = true;
            flowEmployeeRankings.BackColor = Color.FromArgb(37, 42, 64);
            flowEmployeeRankings.Location = new Point(26, 171);
            flowEmployeeRankings.Name = "flowEmployeeRankings";
            flowEmployeeRankings.Size = new Size(440, 574);
            flowEmployeeRankings.TabIndex = 2;
            // 
            // flowEmployeeDisplay
            // 
            flowEmployeeDisplay.AutoScroll = true;
            flowEmployeeDisplay.BackColor = Color.FromArgb(37, 42, 64);
            flowEmployeeDisplay.Location = new Point(251, 3);
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
            txtBxEmployeeSearch.BackColor = Color.FromArgb(74, 79, 99);
            txtBxEmployeeSearch.BorderStyle = BorderStyle.None;
            txtBxEmployeeSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxEmployeeSearch.ForeColor = Color.White;
            txtBxEmployeeSearch.Location = new Point(1042, 99);
            txtBxEmployeeSearch.Name = "txtBxEmployeeSearch";
            txtBxEmployeeSearch.PlaceholderText = "Search Employees";
            txtBxEmployeeSearch.Size = new Size(195, 25);
            txtBxEmployeeSearch.TabIndex = 3;
            txtBxEmployeeSearch.TextChanged += txtBxEmployeeSearch_TextChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Position", "Server", "Busser", "Runner", "Host", "Barback", "Valet", "Bartender" });
            comboBox3.Location = new Point(292, 2);
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
            btnAddEmployee.Location = new Point(328, 0);
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
            pnlEmployeeStats.Location = new Point(483, 145);
            pnlEmployeeStats.Margin = new Padding(8);
            pnlEmployeeStats.Name = "pnlEmployeeStats";
            pnlEmployeeStats.Size = new Size(800, 600);
            pnlEmployeeStats.TabIndex = 0;
            pnlEmployeeStats.Paint += panel2_Paint;
            // 
            // flowMostFrequentIncidents
            // 
            flowMostFrequentIncidents.AutoScroll = true;
            flowMostFrequentIncidents.BackColor = Color.FromArgb(37, 42, 64);
            flowMostFrequentIncidents.Location = new Point(13, 70);
            flowMostFrequentIncidents.Name = "flowMostFrequentIncidents";
            flowMostFrequentIncidents.Size = new Size(240, 525);
            flowMostFrequentIncidents.TabIndex = 12;
            // 
            // flowShiftRankings
            // 
            flowShiftRankings.AutoScroll = true;
            flowShiftRankings.BackColor = Color.FromArgb(37, 42, 64);
            flowShiftRankings.Location = new Point(279, 68);
            flowShiftRankings.Name = "flowShiftRankings";
            flowShiftRankings.Padding = new Padding(0, 10, 0, 0);
            flowShiftRankings.Size = new Size(240, 527);
            flowShiftRankings.TabIndex = 11;
            // 
            // flowGoodShiftRankings
            // 
            flowGoodShiftRankings.AutoScroll = true;
            flowGoodShiftRankings.BackColor = Color.FromArgb(37, 42, 64);
            flowGoodShiftRankings.Location = new Point(548, 68);
            flowGoodShiftRankings.Name = "flowGoodShiftRankings";
            flowGoodShiftRankings.Padding = new Padding(0, 10, 0, 0);
            flowGoodShiftRankings.Size = new Size(240, 527);
            flowGoodShiftRankings.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(351, 34);
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
            label3.Location = new Point(28, 34);
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
            label1.Location = new Point(593, 34);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 8;
            label1.Text = "Good Shift Rankings";
            // 
            // panel1
            // 
            panel1.Controls.Add(cboViewType);
            panel1.Controls.Add(cboSortBy);
            panel1.Controls.Add(lbPositions);
            panel1.Controls.Add(btnAddEmployee);
            panel1.Controls.Add(lbTimeFrame);
            panel1.Controls.Add(cboTimeFrame);
            panel1.Controls.Add(cboPositions);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(flowEmployeeDisplay);
            panel1.Location = new Point(2, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(18, 32);
            panel1.TabIndex = 17;
            // 
            // cboViewType
            // 
            cboViewType.BackColor = Color.FromArgb(74, 79, 99);
            cboViewType.FlatStyle = FlatStyle.Flat;
            cboViewType.ForeColor = Color.White;
            cboViewType.FormattingEnabled = true;
            cboViewType.Items.AddRange(new object[] { "Employees", "Employee Shifts" });
            cboViewType.Location = new Point(14, 3);
            cboViewType.Name = "cboViewType";
            cboViewType.Size = new Size(60, 23);
            cboViewType.TabIndex = 12;
            cboViewType.Visible = false;
            cboViewType.SelectedIndexChanged += cboViewType_SelectedIndexChanged;
            // 
            // cboSortBy
            // 
            cboSortBy.BackColor = Color.FromArgb(74, 79, 99);
            cboSortBy.FlatStyle = FlatStyle.Flat;
            cboSortBy.ForeColor = Color.White;
            cboSortBy.FormattingEnabled = true;
            cboSortBy.Items.AddRange(new object[] { "Highest Rated", "Lowest Rated", "Most Recent", "Alphabetical" });
            cboSortBy.Location = new Point(80, 3);
            cboSortBy.Name = "cboSortBy";
            cboSortBy.Size = new Size(50, 23);
            cboSortBy.TabIndex = 12;
            cboSortBy.Visible = false;
            cboSortBy.SelectedIndexChanged += cboViewType_SelectedIndexChanged;
            // 
            // lbPositions
            // 
            lbPositions.BackColor = Color.FromArgb(74, 79, 99);
            lbPositions.BorderStyle = BorderStyle.None;
            lbPositions.ForeColor = Color.White;
            lbPositions.FormattingEnabled = true;
            lbPositions.ItemHeight = 15;
            lbPositions.Location = new Point(202, 3);
            lbPositions.Name = "lbPositions";
            lbPositions.Size = new Size(43, 15);
            lbPositions.TabIndex = 16;
            lbPositions.Visible = false;
            // 
            // lbTimeFrame
            // 
            lbTimeFrame.BackColor = Color.FromArgb(74, 79, 99);
            lbTimeFrame.BorderStyle = BorderStyle.None;
            lbTimeFrame.ForeColor = Color.White;
            lbTimeFrame.FormattingEnabled = true;
            lbTimeFrame.ItemHeight = 15;
            lbTimeFrame.Items.AddRange(new object[] { "All Time", "This Week", "Last Week", "This Month", "Last Month", "Other" });
            lbTimeFrame.Location = new Point(136, 10);
            lbTimeFrame.Name = "lbTimeFrame";
            lbTimeFrame.Size = new Size(49, 15);
            lbTimeFrame.TabIndex = 13;
            lbTimeFrame.Visible = false;
            lbTimeFrame.SelectedIndexChanged += lbTimeFrame_SelectedIndexChanged;
            // 
            // cboTimeFrame
            // 
            cboTimeFrame.BackColor = Color.FromArgb(74, 79, 99);
            cboTimeFrame.FlatStyle = FlatStyle.Flat;
            cboTimeFrame.ForeColor = Color.White;
            cboTimeFrame.FormattingEnabled = true;
            cboTimeFrame.Items.AddRange(new object[] { "All Time", "This Week", "Last Week", "This Month", "Last Month", "Custom" });
            cboTimeFrame.Location = new Point(371, 1);
            cboTimeFrame.Name = "cboTimeFrame";
            cboTimeFrame.Size = new Size(72, 23);
            cboTimeFrame.TabIndex = 1;
            cboTimeFrame.Visible = false;
            // 
            // cboPositions
            // 
            cboPositions.BackColor = Color.FromArgb(74, 79, 99);
            cboPositions.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPositions.FlatStyle = FlatStyle.Flat;
            cboPositions.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboPositions.ForeColor = Color.White;
            cboPositions.FormattingEnabled = true;
            cboPositions.Location = new Point(493, 1);
            cboPositions.Name = "cboPositions";
            cboPositions.Size = new Size(51, 23);
            cboPositions.TabIndex = 1;
            cboPositions.Visible = false;
            // 
            // lblMainWindowDescription
            // 
            lblMainWindowDescription.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMainWindowDescription.ForeColor = Color.White;
            lblMainWindowDescription.Location = new Point(629, 91);
            lblMainWindowDescription.Name = "lblMainWindowDescription";
            lblMainWindowDescription.Size = new Size(400, 35);
            lblMainWindowDescription.TabIndex = 0;
            lblMainWindowDescription.Text = "Overview";
            lblMainWindowDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(167, 204, 237);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(504, 99);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(119, 27);
            btnReset.TabIndex = 3;
            btnReset.Text = "Back to Overview";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Visible = false;
            btnReset.Click += btnReset_Click;
            // 
            // rdoViewEmployees
            // 
            rdoViewEmployees.Appearance = Appearance.Button;
            rdoViewEmployees.BackColor = Color.FromArgb(167, 204, 237);
            rdoViewEmployees.FlatAppearance.BorderSize = 0;
            rdoViewEmployees.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            rdoViewEmployees.FlatStyle = FlatStyle.Flat;
            rdoViewEmployees.Location = new Point(15, 15);
            rdoViewEmployees.Margin = new Padding(0);
            rdoViewEmployees.Name = "rdoViewEmployees";
            rdoViewEmployees.Size = new Size(204, 24);
            rdoViewEmployees.TabIndex = 18;
            rdoViewEmployees.TabStop = true;
            rdoViewEmployees.Text = "Employees";
            rdoViewEmployees.TextAlign = ContentAlignment.MiddleCenter;
            rdoViewEmployees.UseVisualStyleBackColor = false;
            rdoViewEmployees.CheckedChanged += rdoViewEmployees_CheckedChanged;
            // 
            // rdoViewEmployeeShifts
            // 
            rdoViewEmployeeShifts.Appearance = Appearance.Button;
            rdoViewEmployeeShifts.BackColor = Color.FromArgb(167, 204, 237);
            rdoViewEmployeeShifts.FlatAppearance.BorderSize = 0;
            rdoViewEmployeeShifts.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            rdoViewEmployeeShifts.FlatStyle = FlatStyle.Flat;
            rdoViewEmployeeShifts.Location = new Point(221, 15);
            rdoViewEmployeeShifts.Margin = new Padding(2, 0, 0, 0);
            rdoViewEmployeeShifts.Name = "rdoViewEmployeeShifts";
            rdoViewEmployeeShifts.Size = new Size(203, 24);
            rdoViewEmployeeShifts.TabIndex = 18;
            rdoViewEmployeeShifts.TabStop = true;
            rdoViewEmployeeShifts.Text = "Employee Shifts";
            rdoViewEmployeeShifts.TextAlign = ContentAlignment.MiddleCenter;
            rdoViewEmployeeShifts.UseVisualStyleBackColor = false;
            rdoViewEmployeeShifts.CheckedChanged += rdoViewEmployeeShifts_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 42, 64);
            panel2.Controls.Add(rdoViewEmployees);
            panel2.Controls.Add(rdoViewEmployeeShifts);
            panel2.Location = new Point(26, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 49);
            panel2.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 64);
            panel3.Controls.Add(rdoHighestRated);
            panel3.Controls.Add(rdoAlphabeticalOrChronological);
            panel3.Controls.Add(rdoLowestRated);
            panel3.Location = new Point(26, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(440, 35);
            panel3.TabIndex = 20;
            // 
            // rdoHighestRated
            // 
            rdoHighestRated.Appearance = Appearance.Button;
            rdoHighestRated.BackColor = Color.FromArgb(167, 204, 237);
            rdoHighestRated.FlatAppearance.BorderSize = 0;
            rdoHighestRated.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            rdoHighestRated.FlatStyle = FlatStyle.Flat;
            rdoHighestRated.Location = new Point(15, 0);
            rdoHighestRated.Margin = new Padding(0);
            rdoHighestRated.Name = "rdoHighestRated";
            rdoHighestRated.Size = new Size(135, 24);
            rdoHighestRated.TabIndex = 18;
            rdoHighestRated.TabStop = true;
            rdoHighestRated.Text = "Highest Rated";
            rdoHighestRated.TextAlign = ContentAlignment.MiddleCenter;
            rdoHighestRated.UseVisualStyleBackColor = false;
            // 
            // rdoAlphabeticalOrChronological
            // 
            rdoAlphabeticalOrChronological.Appearance = Appearance.Button;
            rdoAlphabeticalOrChronological.BackColor = Color.FromArgb(167, 204, 237);
            rdoAlphabeticalOrChronological.FlatAppearance.BorderSize = 0;
            rdoAlphabeticalOrChronological.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            rdoAlphabeticalOrChronological.FlatStyle = FlatStyle.Flat;
            rdoAlphabeticalOrChronological.Location = new Point(289, 0);
            rdoAlphabeticalOrChronological.Margin = new Padding(2, 0, 0, 0);
            rdoAlphabeticalOrChronological.Name = "rdoAlphabeticalOrChronological";
            rdoAlphabeticalOrChronological.Size = new Size(135, 24);
            rdoAlphabeticalOrChronological.TabIndex = 18;
            rdoAlphabeticalOrChronological.TabStop = true;
            rdoAlphabeticalOrChronological.Text = "Alphabetical";
            rdoAlphabeticalOrChronological.TextAlign = ContentAlignment.MiddleCenter;
            rdoAlphabeticalOrChronological.UseVisualStyleBackColor = false;
            // 
            // rdoLowestRated
            // 
            rdoLowestRated.Appearance = Appearance.Button;
            rdoLowestRated.BackColor = Color.FromArgb(167, 204, 237);
            rdoLowestRated.FlatAppearance.BorderSize = 0;
            rdoLowestRated.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            rdoLowestRated.FlatStyle = FlatStyle.Flat;
            rdoLowestRated.Location = new Point(152, 0);
            rdoLowestRated.Margin = new Padding(2, 0, 0, 0);
            rdoLowestRated.Name = "rdoLowestRated";
            rdoLowestRated.Size = new Size(135, 24);
            rdoLowestRated.TabIndex = 18;
            rdoLowestRated.TabStop = true;
            rdoLowestRated.Text = "Lowest Rated";
            rdoLowestRated.TextAlign = ContentAlignment.MiddleCenter;
            rdoLowestRated.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(84, 84, 120);
            panel5.Controls.Add(radioButton6);
            panel5.Controls.Add(radioButton5);
            panel5.Controls.Add(radioButton3);
            panel5.Controls.Add(radioButton4);
            panel5.Controls.Add(radioButton2);
            panel5.Controls.Add(radioButton1);
            panel5.Controls.Add(rdoAllTime);
            panel5.Location = new Point(2, 25);
            panel5.Name = "panel5";
            panel5.Size = new Size(737, 41);
            panel5.TabIndex = 21;
            // 
            // radioButton6
            // 
            radioButton6.Appearance = Appearance.Button;
            radioButton6.BackColor = Color.FromArgb(167, 204, 237);
            radioButton6.FlatAppearance.BorderSize = 0;
            radioButton6.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            radioButton6.FlatStyle = FlatStyle.Flat;
            radioButton6.Location = new Point(603, 10);
            radioButton6.Margin = new Padding(2, 10, 0, 0);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(96, 24);
            radioButton6.TabIndex = 27;
            radioButton6.TabStop = true;
            radioButton6.Text = "Custom";
            radioButton6.TextAlign = ContentAlignment.MiddleCenter;
            radioButton6.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            radioButton5.Appearance = Appearance.Button;
            radioButton5.BackColor = Color.FromArgb(167, 204, 237);
            radioButton5.FlatAppearance.BorderSize = 0;
            radioButton5.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            radioButton5.FlatStyle = FlatStyle.Flat;
            radioButton5.Location = new Point(505, 10);
            radioButton5.Margin = new Padding(2, 10, 0, 0);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(96, 24);
            radioButton5.TabIndex = 27;
            radioButton5.TabStop = true;
            radioButton5.Text = "Last 3 Months";
            radioButton5.TextAlign = ContentAlignment.MiddleCenter;
            radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.Appearance = Appearance.Button;
            radioButton3.BackColor = Color.FromArgb(167, 204, 237);
            radioButton3.FlatAppearance.BorderSize = 0;
            radioButton3.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            radioButton3.FlatStyle = FlatStyle.Flat;
            radioButton3.Location = new Point(309, 10);
            radioButton3.Margin = new Padding(2, 5, 0, 0);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(96, 24);
            radioButton3.TabIndex = 25;
            radioButton3.TabStop = true;
            radioButton3.Text = "This Month";
            radioButton3.TextAlign = ContentAlignment.MiddleCenter;
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.Appearance = Appearance.Button;
            radioButton4.BackColor = Color.FromArgb(167, 204, 237);
            radioButton4.FlatAppearance.BorderSize = 0;
            radioButton4.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            radioButton4.FlatStyle = FlatStyle.Flat;
            radioButton4.Location = new Point(407, 10);
            radioButton4.Margin = new Padding(2, 5, 0, 0);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(96, 24);
            radioButton4.TabIndex = 26;
            radioButton4.TabStop = true;
            radioButton4.Text = "Last Month";
            radioButton4.TextAlign = ContentAlignment.MiddleCenter;
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.Appearance = Appearance.Button;
            radioButton2.BackColor = Color.FromArgb(167, 204, 237);
            radioButton2.FlatAppearance.BorderSize = 0;
            radioButton2.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.Location = new Point(211, 10);
            radioButton2.Margin = new Padding(2, 5, 0, 0);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(96, 24);
            radioButton2.TabIndex = 28;
            radioButton2.TabStop = true;
            radioButton2.Text = "Last Week";
            radioButton2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.Appearance = Appearance.Button;
            radioButton1.BackColor = Color.FromArgb(167, 204, 237);
            radioButton1.FlatAppearance.BorderSize = 0;
            radioButton1.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            radioButton1.FlatStyle = FlatStyle.Flat;
            radioButton1.Location = new Point(113, 10);
            radioButton1.Margin = new Padding(2, 5, 0, 0);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(96, 24);
            radioButton1.TabIndex = 23;
            radioButton1.TabStop = true;
            radioButton1.Text = "This Week";
            radioButton1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // rdoAllTime
            // 
            rdoAllTime.Appearance = Appearance.Button;
            rdoAllTime.BackColor = Color.FromArgb(167, 204, 237);
            rdoAllTime.FlatAppearance.BorderSize = 0;
            rdoAllTime.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            rdoAllTime.FlatStyle = FlatStyle.Flat;
            rdoAllTime.Location = new Point(15, 10);
            rdoAllTime.Margin = new Padding(0, 5, 0, 0);
            rdoAllTime.Name = "rdoAllTime";
            rdoAllTime.Size = new Size(96, 24);
            rdoAllTime.TabIndex = 22;
            rdoAllTime.TabStop = true;
            rdoAllTime.Text = "All Time";
            rdoAllTime.TextAlign = ContentAlignment.MiddleCenter;
            rdoAllTime.UseVisualStyleBackColor = false;
            // 
            // flowPositions
            // 
            flowPositions.BackColor = Color.FromArgb(84, 84, 120);
            flowPositions.Location = new Point(739, 25);
            flowPositions.Name = "flowPositions";
            flowPositions.Padding = new Padding(15, 10, 0, 0);
            flowPositions.Size = new Size(559, 41);
            flowPositions.TabIndex = 22;
            // 
            // btnGoSearch
            // 
            btnGoSearch.BackColor = Color.FromArgb(167, 204, 237);
            btnGoSearch.FlatAppearance.BorderSize = 0;
            btnGoSearch.FlatStyle = FlatStyle.Flat;
            btnGoSearch.Location = new Point(1246, 99);
            btnGoSearch.Name = "btnGoSearch";
            btnGoSearch.Size = new Size(40, 23);
            btnGoSearch.TabIndex = 23;
            btnGoSearch.Text = "Go";
            btnGoSearch.UseVisualStyleBackColor = false;
            // 
            // frmOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1300, 775);
            Controls.Add(btnGoSearch);
            Controls.Add(flowPositions);
            Controls.Add(panel5);
            Controls.Add(flowEmployeeRankings);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(txtBxEmployeeSearch);
            Controls.Add(btnReset);
            Controls.Add(lblMainWindowDescription);
            Controls.Add(pnlEmployeeStats);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1320, 820);
            Name = "frmOverview";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmOverview";
            TopMost = true;
            Load += frmOverview_Load;
            pnlEmployeeStats.ResumeLayout(false);
            pnlEmployeeStats.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private ListBox lbPositions;
        private FlowLayoutPanel flowMostFrequentIncidents;
        private Label label3;
        private Panel panel1;
        private RadioButton rdoViewEmployees;
        private RadioButton rdoViewEmployeeShifts;
        private Panel panel2;
        private Panel panel3;
        private RadioButton rdoHighestRated;
        private RadioButton rdoAlphabeticalOrChronological;
        private RadioButton rdoLowestRated;
        private Panel panel5;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton1;
        private RadioButton rdoAllTime;
        private RadioButton radioButton2;
        private FlowLayoutPanel flowPositions;
        private RadioButton radioButton6;
        private Button btnGoSearch;
    }
}