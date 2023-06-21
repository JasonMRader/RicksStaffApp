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
            lbPositions = new ListBox();
            panel1 = new Panel();
            rdoViewEmployees = new RadioButton();
            rdoViewEmployeeShifts = new RadioButton();
            panel2 = new Panel();
            panel3 = new Panel();
            radioButton1 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            pnlEmployeeDisplay.SuspendLayout();
            pnlEmployeeStats.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            flowEmployeeDisplay.Location = new Point(323, 7);
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
            txtBxEmployeeSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxEmployeeSearch.ForeColor = Color.White;
            txtBxEmployeeSearch.Location = new Point(26, 5);
            txtBxEmployeeSearch.Name = "txtBxEmployeeSearch";
            txtBxEmployeeSearch.PlaceholderText = "Search Employees";
            txtBxEmployeeSearch.Size = new Size(440, 22);
            txtBxEmployeeSearch.TabIndex = 3;
            txtBxEmployeeSearch.TextChanged += txtBxEmployeeSearch_TextChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Position", "Server", "Busser", "Runner", "Host", "Barback", "Valet", "Bartender" });
            comboBox3.Location = new Point(364, 3);
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
            btnAddEmployee.Location = new Point(398, 2);
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
            flowMostFrequentIncidents.AutoScroll = true;
            flowMostFrequentIncidents.BackColor = Color.FromArgb(37, 42, 64);
            flowMostFrequentIncidents.Location = new Point(13, 44);
            flowMostFrequentIncidents.Name = "flowMostFrequentIncidents";
            flowMostFrequentIncidents.Size = new Size(240, 600);
            flowMostFrequentIncidents.TabIndex = 12;
            // 
            // flowShiftRankings
            // 
            flowShiftRankings.AutoScroll = true;
            flowShiftRankings.BackColor = Color.FromArgb(37, 42, 64);
            flowShiftRankings.Location = new Point(279, 42);
            flowShiftRankings.Name = "flowShiftRankings";
            flowShiftRankings.Padding = new Padding(0, 10, 0, 0);
            flowShiftRankings.Size = new Size(240, 600);
            flowShiftRankings.TabIndex = 11;
            // 
            // flowGoodShiftRankings
            // 
            flowGoodShiftRankings.AutoScroll = true;
            flowGoodShiftRankings.BackColor = Color.FromArgb(37, 42, 64);
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
            cboViewType.Location = new Point(14, 3);
            cboViewType.Name = "cboViewType";
            cboViewType.Size = new Size(60, 23);
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
            cboTimeFrame.Location = new Point(252, 91);
            cboTimeFrame.Name = "cboTimeFrame";
            cboTimeFrame.Size = new Size(214, 23);
            cboTimeFrame.TabIndex = 1;
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
            // lblMainWindowDescription
            // 
            lblMainWindowDescription.AutoSize = true;
            lblMainWindowDescription.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMainWindowDescription.ForeColor = Color.White;
            lblMainWindowDescription.Location = new Point(808, 41);
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
            cboPositions.Location = new Point(26, 91);
            cboPositions.Name = "cboPositions";
            cboPositions.Size = new Size(220, 23);
            cboPositions.TabIndex = 1;
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
            lbTimeFrame.SelectedIndexChanged += lbTimeFrame_SelectedIndexChanged;
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
            lbPositions.Size = new Size(67, 15);
            lbPositions.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(cboViewType);
            panel1.Controls.Add(cboSortBy);
            panel1.Controls.Add(lbPositions);
            panel1.Controls.Add(btnAddEmployee);
            panel1.Controls.Add(lbTimeFrame);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(flowEmployeeDisplay);
            panel1.Location = new Point(824, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 32);
            panel1.TabIndex = 17;
            // 
            // rdoViewEmployees
            // 
            rdoViewEmployees.Appearance = Appearance.Button;
            rdoViewEmployees.BackColor = Color.FromArgb(167, 204, 237);
            rdoViewEmployees.FlatAppearance.BorderSize = 0;
            rdoViewEmployees.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            rdoViewEmployees.FlatStyle = FlatStyle.Flat;
            rdoViewEmployees.Location = new Point(0, 0);
            rdoViewEmployees.Margin = new Padding(0);
            rdoViewEmployees.Name = "rdoViewEmployees";
            rdoViewEmployees.Size = new Size(219, 24);
            rdoViewEmployees.TabIndex = 18;
            rdoViewEmployees.TabStop = true;
            rdoViewEmployees.Text = "Employees";
            rdoViewEmployees.TextAlign = ContentAlignment.MiddleCenter;
            rdoViewEmployees.UseVisualStyleBackColor = false;
            // 
            // rdoViewEmployeeShifts
            // 
            rdoViewEmployeeShifts.Appearance = Appearance.Button;
            rdoViewEmployeeShifts.BackColor = Color.FromArgb(167, 204, 237);
            rdoViewEmployeeShifts.FlatAppearance.BorderSize = 0;
            rdoViewEmployeeShifts.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            rdoViewEmployeeShifts.FlatStyle = FlatStyle.Flat;
            rdoViewEmployeeShifts.Location = new Point(220, 0);
            rdoViewEmployeeShifts.Margin = new Padding(0);
            rdoViewEmployeeShifts.Name = "rdoViewEmployeeShifts";
            rdoViewEmployeeShifts.Size = new Size(219, 24);
            rdoViewEmployeeShifts.TabIndex = 18;
            rdoViewEmployeeShifts.TabStop = true;
            rdoViewEmployeeShifts.Text = "Employee Shifts";
            rdoViewEmployeeShifts.TextAlign = ContentAlignment.MiddleCenter;
            rdoViewEmployeeShifts.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(rdoViewEmployees);
            panel2.Controls.Add(rdoViewEmployeeShifts);
            panel2.Location = new Point(27, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 30);
            panel2.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.Controls.Add(radioButton1);
            panel3.Controls.Add(radioButton3);
            panel3.Controls.Add(radioButton2);
            panel3.Location = new Point(26, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(440, 30);
            panel3.TabIndex = 20;
            // 
            // radioButton1
            // 
            radioButton1.Appearance = Appearance.Button;
            radioButton1.BackColor = Color.FromArgb(167, 204, 237);
            radioButton1.FlatAppearance.BorderSize = 0;
            radioButton1.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            radioButton1.FlatStyle = FlatStyle.Flat;
            radioButton1.Location = new Point(1, 0);
            radioButton1.Margin = new Padding(0);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(146, 24);
            radioButton1.TabIndex = 18;
            radioButton1.TabStop = true;
            radioButton1.Text = "Highest Rated";
            radioButton1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.Appearance = Appearance.Button;
            radioButton3.BackColor = Color.FromArgb(167, 204, 237);
            radioButton3.FlatAppearance.BorderSize = 0;
            radioButton3.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            radioButton3.FlatStyle = FlatStyle.Flat;
            radioButton3.Location = new Point(295, 0);
            radioButton3.Margin = new Padding(0);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(146, 24);
            radioButton3.TabIndex = 18;
            radioButton3.TabStop = true;
            radioButton3.Text = "Alphabetical";
            radioButton3.TextAlign = ContentAlignment.MiddleCenter;
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.Appearance = Appearance.Button;
            radioButton2.BackColor = Color.FromArgb(167, 204, 237);
            radioButton2.FlatAppearance.BorderSize = 0;
            radioButton2.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.Location = new Point(148, 0);
            radioButton2.Margin = new Padding(0);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(146, 24);
            radioButton2.TabIndex = 18;
            radioButton2.TabStop = true;
            radioButton2.Text = "Lowest Rated";
            radioButton2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // frmOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1300, 775);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(txtBxEmployeeSearch);
            Controls.Add(cboTimeFrame);
            Controls.Add(panel1);
            Controls.Add(cboPositions);
            Controls.Add(btnReset);
            Controls.Add(lblMainWindowDescription);
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
            pnlEmployeeStats.ResumeLayout(false);
            pnlEmployeeStats.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
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
        private ListBox lbPositions;
        private FlowLayoutPanel flowMostFrequentIncidents;
        private Label label3;
        private Panel panel1;
        private RadioButton rdoViewEmployees;
        private RadioButton rdoViewEmployeeShifts;
        private Panel panel2;
        private Panel panel3;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
    }
}