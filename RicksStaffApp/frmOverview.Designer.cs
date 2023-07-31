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
            pnlRatioLoadScreen = new Panel();
            flowMostFrequentIncidents = new FlowLayoutPanel();
            pnlShiftLoadScreen = new Panel();
            flowShiftRankings = new FlowLayoutPanel();
            pnlIncidentLoadScreen = new Panel();
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
            rdoCustomTime = new RadioButton();
            rdoLastThreeMonths = new RadioButton();
            rdoThisMonth = new RadioButton();
            rdoLastMonth = new RadioButton();
            rdoLastWeek = new RadioButton();
            rdoThisWeek = new RadioButton();
            rdoAllTime = new RadioButton();
            flowPositions = new FlowLayoutPanel();
            btnGoSearch = new Button();
            lblTest1 = new Label();
            lblTest2 = new Label();
            pnlEmployeeLoadScreen = new Panel();
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
            txtBxEmployeeSearch.Enabled = false;
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
            pnlEmployeeStats.Controls.Add(pnlRatioLoadScreen);
            pnlEmployeeStats.Controls.Add(flowMostFrequentIncidents);
            pnlEmployeeStats.Controls.Add(pnlShiftLoadScreen);
            pnlEmployeeStats.Controls.Add(flowShiftRankings);
            pnlEmployeeStats.Controls.Add(pnlIncidentLoadScreen);
            pnlEmployeeStats.Controls.Add(flowGoodShiftRankings);
            pnlEmployeeStats.Controls.Add(label2);
            pnlEmployeeStats.Controls.Add(label3);
            pnlEmployeeStats.Controls.Add(label1);
            pnlEmployeeStats.Location = new Point(483, 145);
            pnlEmployeeStats.Margin = new Padding(8);
            pnlEmployeeStats.Name = "pnlEmployeeStats";
            pnlEmployeeStats.Size = new Size(800, 600);
            pnlEmployeeStats.TabIndex = 0;
            // 
            // pnlRatioLoadScreen
            // 
            pnlRatioLoadScreen.Location = new Point(303, 11);
            pnlRatioLoadScreen.Name = "pnlRatioLoadScreen";
            pnlRatioLoadScreen.Size = new Size(18, 44);
            pnlRatioLoadScreen.TabIndex = 25;
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
            // pnlShiftLoadScreen
            // 
            pnlShiftLoadScreen.Location = new Point(279, 11);
            pnlShiftLoadScreen.Name = "pnlShiftLoadScreen";
            pnlShiftLoadScreen.Size = new Size(18, 44);
            pnlShiftLoadScreen.TabIndex = 25;
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
            // pnlIncidentLoadScreen
            // 
            pnlIncidentLoadScreen.Location = new Point(238, 11);
            pnlIncidentLoadScreen.Name = "pnlIncidentLoadScreen";
            pnlIncidentLoadScreen.Size = new Size(18, 44);
            pnlIncidentLoadScreen.TabIndex = 25;
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
            rdoHighestRated.CheckedChanged += rdoHighestRated_CheckedChanged;
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
            rdoAlphabeticalOrChronological.CheckedChanged += rdoAlphabeticalOrChronological_CheckedChanged;
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
            rdoLowestRated.CheckedChanged += rdoLowestRated_CheckedChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(84, 84, 120);
            panel5.Controls.Add(rdoCustomTime);
            panel5.Controls.Add(rdoLastThreeMonths);
            panel5.Controls.Add(rdoThisMonth);
            panel5.Controls.Add(rdoLastMonth);
            panel5.Controls.Add(rdoLastWeek);
            panel5.Controls.Add(rdoThisWeek);
            panel5.Controls.Add(rdoAllTime);
            panel5.Location = new Point(2, 25);
            panel5.Name = "panel5";
            panel5.Size = new Size(737, 49);
            panel5.TabIndex = 21;
            // 
            // rdoCustomTime
            // 
            rdoCustomTime.Appearance = Appearance.Button;
            rdoCustomTime.BackColor = Color.FromArgb(167, 204, 237);
            rdoCustomTime.FlatAppearance.BorderSize = 0;
            rdoCustomTime.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            rdoCustomTime.FlatStyle = FlatStyle.Flat;
            rdoCustomTime.Location = new Point(568, 10);
            rdoCustomTime.Margin = new Padding(2, 10, 0, 0);
            rdoCustomTime.Name = "rdoCustomTime";
            rdoCustomTime.Size = new Size(131, 24);
            rdoCustomTime.TabIndex = 27;
            rdoCustomTime.TabStop = true;
            rdoCustomTime.Text = "Custom";
            rdoCustomTime.TextAlign = ContentAlignment.MiddleCenter;
            rdoCustomTime.UseVisualStyleBackColor = false;
            rdoCustomTime.CheckedChanged += rdoCustomTime_CheckedChanged;
            rdoCustomTime.MouseClick += rdoCustomTimeMouseClick;
            // 
            // rdoLastThreeMonths
            // 
            rdoLastThreeMonths.Appearance = Appearance.Button;
            rdoLastThreeMonths.BackColor = Color.FromArgb(167, 204, 237);
            rdoLastThreeMonths.FlatAppearance.BorderSize = 0;
            rdoLastThreeMonths.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            rdoLastThreeMonths.FlatStyle = FlatStyle.Flat;
            rdoLastThreeMonths.Location = new Point(476, 10);
            rdoLastThreeMonths.Margin = new Padding(2, 10, 0, 0);
            rdoLastThreeMonths.Name = "rdoLastThreeMonths";
            rdoLastThreeMonths.Size = new Size(90, 24);
            rdoLastThreeMonths.TabIndex = 27;
            rdoLastThreeMonths.TabStop = true;
            rdoLastThreeMonths.Text = "Last 90 Days";
            rdoLastThreeMonths.TextAlign = ContentAlignment.MiddleCenter;
            rdoLastThreeMonths.UseVisualStyleBackColor = false;
            rdoLastThreeMonths.CheckedChanged += rdoLastThreeMonths_CheckedChanged;
            // 
            // rdoThisMonth
            // 
            rdoThisMonth.Appearance = Appearance.Button;
            rdoThisMonth.BackColor = Color.FromArgb(167, 204, 237);
            rdoThisMonth.FlatAppearance.BorderSize = 0;
            rdoThisMonth.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            rdoThisMonth.FlatStyle = FlatStyle.Flat;
            rdoThisMonth.Location = new Point(292, 10);
            rdoThisMonth.Margin = new Padding(2, 5, 0, 0);
            rdoThisMonth.Name = "rdoThisMonth";
            rdoThisMonth.Size = new Size(90, 24);
            rdoThisMonth.TabIndex = 25;
            rdoThisMonth.TabStop = true;
            rdoThisMonth.Text = "This Month";
            rdoThisMonth.TextAlign = ContentAlignment.MiddleCenter;
            rdoThisMonth.UseVisualStyleBackColor = false;
            rdoThisMonth.CheckedChanged += rdoThisMonth_CheckedChanged;
            // 
            // rdoLastMonth
            // 
            rdoLastMonth.Appearance = Appearance.Button;
            rdoLastMonth.BackColor = Color.FromArgb(167, 204, 237);
            rdoLastMonth.FlatAppearance.BorderSize = 0;
            rdoLastMonth.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            rdoLastMonth.FlatStyle = FlatStyle.Flat;
            rdoLastMonth.Location = new Point(384, 10);
            rdoLastMonth.Margin = new Padding(2, 5, 0, 0);
            rdoLastMonth.Name = "rdoLastMonth";
            rdoLastMonth.Size = new Size(90, 24);
            rdoLastMonth.TabIndex = 26;
            rdoLastMonth.TabStop = true;
            rdoLastMonth.Text = "Last Month";
            rdoLastMonth.TextAlign = ContentAlignment.MiddleCenter;
            rdoLastMonth.UseVisualStyleBackColor = false;
            rdoLastMonth.CheckedChanged += rdoLastMonth_CheckedChanged;
            // 
            // rdoLastWeek
            // 
            rdoLastWeek.Appearance = Appearance.Button;
            rdoLastWeek.BackColor = Color.FromArgb(167, 204, 237);
            rdoLastWeek.FlatAppearance.BorderSize = 0;
            rdoLastWeek.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            rdoLastWeek.FlatStyle = FlatStyle.Flat;
            rdoLastWeek.Location = new Point(199, 10);
            rdoLastWeek.Margin = new Padding(2, 5, 0, 0);
            rdoLastWeek.Name = "rdoLastWeek";
            rdoLastWeek.Size = new Size(90, 24);
            rdoLastWeek.TabIndex = 28;
            rdoLastWeek.TabStop = true;
            rdoLastWeek.Text = "Last Week";
            rdoLastWeek.TextAlign = ContentAlignment.MiddleCenter;
            rdoLastWeek.UseVisualStyleBackColor = false;
            rdoLastWeek.CheckedChanged += rdoLastWeek_CheckedChanged;
            // 
            // rdoThisWeek
            // 
            rdoThisWeek.Appearance = Appearance.Button;
            rdoThisWeek.BackColor = Color.FromArgb(167, 204, 237);
            rdoThisWeek.FlatAppearance.BorderSize = 0;
            rdoThisWeek.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            rdoThisWeek.FlatStyle = FlatStyle.Flat;
            rdoThisWeek.Location = new Point(107, 10);
            rdoThisWeek.Margin = new Padding(2, 5, 0, 0);
            rdoThisWeek.Name = "rdoThisWeek";
            rdoThisWeek.Size = new Size(90, 24);
            rdoThisWeek.TabIndex = 23;
            rdoThisWeek.TabStop = true;
            rdoThisWeek.Text = "This Week";
            rdoThisWeek.TextAlign = ContentAlignment.MiddleCenter;
            rdoThisWeek.UseVisualStyleBackColor = false;
            rdoThisWeek.CheckedChanged += rdoThisWeek_CheckedChanged;
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
            rdoAllTime.Size = new Size(90, 24);
            rdoAllTime.TabIndex = 22;
            rdoAllTime.TabStop = true;
            rdoAllTime.Text = "All Time";
            rdoAllTime.TextAlign = ContentAlignment.MiddleCenter;
            rdoAllTime.UseVisualStyleBackColor = false;
            rdoAllTime.CheckedChanged += rdoAllTime_CheckedChanged;
            // 
            // flowPositions
            // 
            flowPositions.BackColor = Color.FromArgb(84, 84, 120);
            flowPositions.Location = new Point(739, 25);
            flowPositions.Name = "flowPositions";
            flowPositions.Padding = new Padding(15, 7, 0, 0);
            flowPositions.Size = new Size(559, 49);
            flowPositions.TabIndex = 22;
            // 
            // btnGoSearch
            // 
            btnGoSearch.BackColor = Color.FromArgb(167, 204, 237);
            btnGoSearch.Enabled = false;
            btnGoSearch.FlatAppearance.BorderSize = 0;
            btnGoSearch.FlatStyle = FlatStyle.Flat;
            btnGoSearch.Location = new Point(1246, 99);
            btnGoSearch.Name = "btnGoSearch";
            btnGoSearch.Size = new Size(40, 23);
            btnGoSearch.TabIndex = 23;
            btnGoSearch.Text = "Go";
            btnGoSearch.UseVisualStyleBackColor = false;
            // 
            // lblTest1
            // 
            lblTest1.AutoSize = true;
            lblTest1.ForeColor = Color.White;
            lblTest1.Location = new Point(138, 69);
            lblTest1.Name = "lblTest1";
            lblTest1.Size = new Size(38, 15);
            lblTest1.TabIndex = 24;
            lblTest1.Text = "label4";
            lblTest1.Visible = false;
            // 
            // lblTest2
            // 
            lblTest2.AutoSize = true;
            lblTest2.ForeColor = Color.White;
            lblTest2.Location = new Point(204, 69);
            lblTest2.Name = "lblTest2";
            lblTest2.Size = new Size(38, 15);
            lblTest2.TabIndex = 24;
            lblTest2.Text = "label4";
            lblTest2.Visible = false;
            // 
            // pnlEmployeeLoadScreen
            // 
            pnlEmployeeLoadScreen.Location = new Point(2, 173);
            pnlEmployeeLoadScreen.Name = "pnlEmployeeLoadScreen";
            pnlEmployeeLoadScreen.Size = new Size(18, 44);
            pnlEmployeeLoadScreen.TabIndex = 25;
            // 
            // frmOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1300, 775);
            Controls.Add(pnlEmployeeLoadScreen);
            Controls.Add(lblTest2);
            Controls.Add(lblTest1);
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
        private RadioButton rdoLastThreeMonths;
        private RadioButton rdoLastMonth;
        private RadioButton rdoThisMonth;
        private RadioButton rdoThisWeek;
        private RadioButton rdoAllTime;
        private RadioButton rdoLastWeek;
        private FlowLayoutPanel flowPositions;
        private RadioButton rdoCustomTime;
        private Button btnGoSearch;
        private Label lblTest1;
        private Label lblTest2;
        private Panel pnlEmployeeLoadScreen;
        private Panel pnlIncidentLoadScreen;
        private Panel pnlShiftLoadScreen;
        private Panel pnlRatioLoadScreen;
    }
}