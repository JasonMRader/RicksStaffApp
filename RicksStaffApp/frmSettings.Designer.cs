namespace RicksStaffApp
{
    partial class frmSettings
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
            label1 = new Label();
            btnNewAction = new Button();
            flowSettingDisplay = new FlowLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtActivityName = new TextBox();
            txtActivityRating = new TextBox();
            txtIncidentDate = new TextBox();
            txtIncidentNote = new TextBox();
            txtIncident_ActivityID = new TextBox();
            txtActivityMod_ActivityID = new TextBox();
            txtActivityModName = new TextBox();
            txtActivityModRatingAdjustment = new TextBox();
            txtShiftDate = new TextBox();
            txtShiftEmployeeList = new TextBox();
            txtEmployeeShiftEmployeeName = new TextBox();
            txtEmployeeShift_ShiftID = new TextBox();
            txtEmployeeShiftEmployeeRating = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            txtEmployeeShiftIncidents = new TextBox();
            btnAddActivity = new Button();
            btnLoadActivities = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            btnLoadIncidents = new Button();
            btnAddIncident = new Button();
            panel4 = new Panel();
            btnLoadActivitiyMods = new Button();
            btnAddActivityMod = new Button();
            panel5 = new Panel();
            btnLoadShifts = new Button();
            btnAddShift = new Button();
            panel6 = new Panel();
            btnLoadEmployeeShifts = new Button();
            btnAddEmployeeShift = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 0;
            label1.Text = "Actions";
            // 
            // btnNewAction
            // 
            btnNewAction.BackColor = Color.FromArgb(167, 204, 237);
            btnNewAction.FlatAppearance.BorderSize = 0;
            btnNewAction.FlatStyle = FlatStyle.Flat;
            btnNewAction.ForeColor = Color.FromArgb(5, 48, 97);
            btnNewAction.Location = new Point(1134, 12);
            btnNewAction.Name = "btnNewAction";
            btnNewAction.Size = new Size(136, 39);
            btnNewAction.TabIndex = 1;
            btnNewAction.Text = "Add New";
            btnNewAction.UseVisualStyleBackColor = false;
            btnNewAction.Click += btnNewAction_Click;
            // 
            // flowSettingDisplay
            // 
            flowSettingDisplay.AutoSize = true;
            flowSettingDisplay.BackColor = Color.FromArgb(37, 42, 64);
            flowSettingDisplay.FlowDirection = FlowDirection.TopDown;
            flowSettingDisplay.Location = new Point(3, 3);
            flowSettingDisplay.Name = "flowSettingDisplay";
            flowSettingDisplay.Size = new Size(475, 674);
            flowSettingDisplay.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(flowSettingDisplay);
            panel1.Location = new Point(12, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 680);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 6);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 4;
            label2.Text = "Activity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 6);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 4;
            label3.Text = "Incident";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 6);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 4;
            label4.Text = "ActivityMod";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(41, 6);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 4;
            label5.Text = "Shift";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 6);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 4;
            label6.Text = "EmployeeShift";
            // 
            // txtActivityName
            // 
            txtActivityName.Location = new Point(15, 104);
            txtActivityName.Name = "txtActivityName";
            txtActivityName.Size = new Size(100, 23);
            txtActivityName.TabIndex = 5;
            // 
            // txtActivityRating
            // 
            txtActivityRating.Location = new Point(15, 152);
            txtActivityRating.Name = "txtActivityRating";
            txtActivityRating.Size = new Size(100, 23);
            txtActivityRating.TabIndex = 5;
            // 
            // txtIncidentDate
            // 
            txtIncidentDate.Location = new Point(10, 106);
            txtIncidentDate.Name = "txtIncidentDate";
            txtIncidentDate.Size = new Size(100, 23);
            txtIncidentDate.TabIndex = 5;
            // 
            // txtIncidentNote
            // 
            txtIncidentNote.Location = new Point(10, 151);
            txtIncidentNote.Name = "txtIncidentNote";
            txtIncidentNote.Size = new Size(100, 23);
            txtIncidentNote.TabIndex = 5;
            // 
            // txtIncident_ActivityID
            // 
            txtIncident_ActivityID.Location = new Point(8, 196);
            txtIncident_ActivityID.Name = "txtIncident_ActivityID";
            txtIncident_ActivityID.Size = new Size(100, 23);
            txtIncident_ActivityID.TabIndex = 5;
            // 
            // txtActivityMod_ActivityID
            // 
            txtActivityMod_ActivityID.Location = new Point(12, 107);
            txtActivityMod_ActivityID.Name = "txtActivityMod_ActivityID";
            txtActivityMod_ActivityID.Size = new Size(100, 23);
            txtActivityMod_ActivityID.TabIndex = 5;
            // 
            // txtActivityModName
            // 
            txtActivityModName.Location = new Point(12, 151);
            txtActivityModName.Name = "txtActivityModName";
            txtActivityModName.Size = new Size(100, 23);
            txtActivityModName.TabIndex = 5;
            // 
            // txtActivityModRatingAdjustment
            // 
            txtActivityModRatingAdjustment.Location = new Point(12, 196);
            txtActivityModRatingAdjustment.Name = "txtActivityModRatingAdjustment";
            txtActivityModRatingAdjustment.Size = new Size(100, 23);
            txtActivityModRatingAdjustment.TabIndex = 5;
            // 
            // txtShiftDate
            // 
            txtShiftDate.Location = new Point(13, 106);
            txtShiftDate.Name = "txtShiftDate";
            txtShiftDate.Size = new Size(100, 23);
            txtShiftDate.TabIndex = 5;
            // 
            // txtShiftEmployeeList
            // 
            txtShiftEmployeeList.Location = new Point(13, 151);
            txtShiftEmployeeList.Name = "txtShiftEmployeeList";
            txtShiftEmployeeList.Size = new Size(100, 23);
            txtShiftEmployeeList.TabIndex = 5;
            // 
            // txtEmployeeShiftEmployeeName
            // 
            txtEmployeeShiftEmployeeName.Location = new Point(8, 104);
            txtEmployeeShiftEmployeeName.Name = "txtEmployeeShiftEmployeeName";
            txtEmployeeShiftEmployeeName.Size = new Size(100, 23);
            txtEmployeeShiftEmployeeName.TabIndex = 5;
            // 
            // txtEmployeeShift_ShiftID
            // 
            txtEmployeeShift_ShiftID.Location = new Point(8, 151);
            txtEmployeeShift_ShiftID.Name = "txtEmployeeShift_ShiftID";
            txtEmployeeShift_ShiftID.Size = new Size(100, 23);
            txtEmployeeShift_ShiftID.TabIndex = 5;
            // 
            // txtEmployeeShiftEmployeeRating
            // 
            txtEmployeeShiftEmployeeRating.Location = new Point(8, 196);
            txtEmployeeShiftEmployeeRating.Name = "txtEmployeeShiftEmployeeRating";
            txtEmployeeShiftEmployeeRating.Size = new Size(100, 23);
            txtEmployeeShiftEmployeeRating.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 85);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 4;
            label7.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, 134);
            label8.Name = "label8";
            label8.Size = new Size(108, 15);
            label8.TabIndex = 4;
            label8.Text = "Base Rating Impact";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(8, 85);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 4;
            label9.Text = "Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(10, 132);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 4;
            label10.Text = "Note";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(8, 178);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 4;
            label12.Text = "ActivityID";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(12, 85);
            label15.Name = "label15";
            label15.Size = new Size(58, 15);
            label15.TabIndex = 4;
            label15.Text = "ActivityID";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(12, 134);
            label16.Name = "label16";
            label16.Size = new Size(39, 15);
            label16.TabIndex = 4;
            label16.Text = "Name";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(12, 178);
            label17.Name = "label17";
            label17.Size = new Size(106, 15);
            label17.TabIndex = 4;
            label17.Text = "Rating Adjustment";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(13, 85);
            label19.Name = "label19";
            label19.Size = new Size(31, 15);
            label19.TabIndex = 4;
            label19.Text = "Date";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(13, 134);
            label20.Name = "label20";
            label20.Size = new Size(93, 15);
            label20.TabIndex = 4;
            label20.Text = "Employees (List)";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.White;
            label21.Location = new Point(8, 82);
            label21.Name = "label21";
            label21.Size = new Size(53, 15);
            label21.TabIndex = 4;
            label21.Text = "Employe";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = Color.White;
            label23.Location = new Point(8, 134);
            label23.Name = "label23";
            label23.Size = new Size(45, 15);
            label23.TabIndex = 4;
            label23.Text = "Shift ID";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = Color.White;
            label24.Location = new Point(8, 177);
            label24.Name = "label24";
            label24.Size = new Size(117, 15);
            label24.TabIndex = 4;
            label24.Text = "EmployeeShiftRating";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label25.ForeColor = Color.White;
            label25.Location = new Point(8, 229);
            label25.Name = "label25";
            label25.Size = new Size(84, 15);
            label25.TabIndex = 4;
            label25.Text = "Incidents (List)";
            // 
            // txtEmployeeShiftIncidents
            // 
            txtEmployeeShiftIncidents.Location = new Point(8, 247);
            txtEmployeeShiftIncidents.Name = "txtEmployeeShiftIncidents";
            txtEmployeeShiftIncidents.Size = new Size(100, 23);
            txtEmployeeShiftIncidents.TabIndex = 5;
            // 
            // btnAddActivity
            // 
            btnAddActivity.Location = new Point(21, 306);
            btnAddActivity.Name = "btnAddActivity";
            btnAddActivity.Size = new Size(100, 23);
            btnAddActivity.TabIndex = 6;
            btnAddActivity.Text = "Add";
            btnAddActivity.UseVisualStyleBackColor = true;
            btnAddActivity.Click += btnAddActivity_Click;
            // 
            // btnLoadActivities
            // 
            btnLoadActivities.Location = new Point(21, 345);
            btnLoadActivities.Name = "btnLoadActivities";
            btnLoadActivities.Size = new Size(100, 23);
            btnLoadActivities.TabIndex = 6;
            btnLoadActivities.Text = "Load";
            btnLoadActivities.UseVisualStyleBackColor = true;
            btnLoadActivities.Click += btnLoadActivities_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 42, 64);
            panel2.Controls.Add(btnLoadActivities);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnAddActivity);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtActivityName);
            panel2.Controls.Add(txtActivityRating);
            panel2.Location = new Point(502, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(145, 400);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 64);
            panel3.Controls.Add(btnLoadIncidents);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnAddIncident);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtIncident_ActivityID);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtIncidentDate);
            panel3.Controls.Add(txtIncidentNote);
            panel3.Location = new Point(657, 108);
            panel3.Name = "panel3";
            panel3.Size = new Size(145, 400);
            panel3.TabIndex = 8;
            // 
            // btnLoadIncidents
            // 
            btnLoadIncidents.Location = new Point(21, 345);
            btnLoadIncidents.Name = "btnLoadIncidents";
            btnLoadIncidents.Size = new Size(100, 23);
            btnLoadIncidents.TabIndex = 6;
            btnLoadIncidents.Text = "Load";
            btnLoadIncidents.UseVisualStyleBackColor = true;
            btnLoadIncidents.Click += btnLoadIncidents_Click;
            // 
            // btnAddIncident
            // 
            btnAddIncident.Location = new Point(21, 306);
            btnAddIncident.Name = "btnAddIncident";
            btnAddIncident.Size = new Size(100, 23);
            btnAddIncident.TabIndex = 6;
            btnAddIncident.Text = "Add";
            btnAddIncident.UseVisualStyleBackColor = true;
            btnAddIncident.Click += btnAddIncident_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(37, 42, 64);
            panel4.Controls.Add(btnLoadActivitiyMods);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(btnAddActivityMod);
            panel4.Controls.Add(txtActivityModRatingAdjustment);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(txtActivityModName);
            panel4.Controls.Add(txtActivityMod_ActivityID);
            panel4.Location = new Point(812, 108);
            panel4.Name = "panel4";
            panel4.Size = new Size(145, 400);
            panel4.TabIndex = 9;
            // 
            // btnLoadActivitiyMods
            // 
            btnLoadActivitiyMods.Location = new Point(18, 345);
            btnLoadActivitiyMods.Name = "btnLoadActivitiyMods";
            btnLoadActivitiyMods.Size = new Size(100, 23);
            btnLoadActivitiyMods.TabIndex = 6;
            btnLoadActivitiyMods.Text = "Load";
            btnLoadActivitiyMods.UseVisualStyleBackColor = true;
            // 
            // btnAddActivityMod
            // 
            btnAddActivityMod.Location = new Point(18, 306);
            btnAddActivityMod.Name = "btnAddActivityMod";
            btnAddActivityMod.Size = new Size(100, 23);
            btnAddActivityMod.TabIndex = 6;
            btnAddActivityMod.Text = "Add";
            btnAddActivityMod.UseVisualStyleBackColor = true;
            btnAddActivityMod.Click += btnAddActivityMod_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(37, 42, 64);
            panel5.Controls.Add(btnLoadShifts);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(label20);
            panel5.Controls.Add(btnAddShift);
            panel5.Controls.Add(txtShiftEmployeeList);
            panel5.Controls.Add(txtShiftDate);
            panel5.Location = new Point(967, 108);
            panel5.Name = "panel5";
            panel5.Size = new Size(145, 400);
            panel5.TabIndex = 9;
            // 
            // btnLoadShifts
            // 
            btnLoadShifts.Location = new Point(24, 345);
            btnLoadShifts.Name = "btnLoadShifts";
            btnLoadShifts.Size = new Size(100, 23);
            btnLoadShifts.TabIndex = 6;
            btnLoadShifts.Text = "Load";
            btnLoadShifts.UseVisualStyleBackColor = true;
            // 
            // btnAddShift
            // 
            btnAddShift.Location = new Point(24, 306);
            btnAddShift.Name = "btnAddShift";
            btnAddShift.Size = new Size(100, 23);
            btnAddShift.TabIndex = 6;
            btnAddShift.Text = "Add";
            btnAddShift.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(37, 42, 64);
            panel6.Controls.Add(btnLoadEmployeeShifts);
            panel6.Controls.Add(txtEmployeeShiftIncidents);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(txtEmployeeShiftEmployeeRating);
            panel6.Controls.Add(label21);
            panel6.Controls.Add(txtEmployeeShift_ShiftID);
            panel6.Controls.Add(btnAddEmployeeShift);
            panel6.Controls.Add(txtEmployeeShiftEmployeeName);
            panel6.Controls.Add(label23);
            panel6.Controls.Add(label24);
            panel6.Controls.Add(label25);
            panel6.Location = new Point(1122, 108);
            panel6.Name = "panel6";
            panel6.Size = new Size(145, 400);
            panel6.TabIndex = 9;
            // 
            // btnLoadEmployeeShifts
            // 
            btnLoadEmployeeShifts.Location = new Point(21, 345);
            btnLoadEmployeeShifts.Name = "btnLoadEmployeeShifts";
            btnLoadEmployeeShifts.Size = new Size(100, 23);
            btnLoadEmployeeShifts.TabIndex = 6;
            btnLoadEmployeeShifts.Text = "Load";
            btnLoadEmployeeShifts.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployeeShift
            // 
            btnAddEmployeeShift.Location = new Point(21, 306);
            btnAddEmployeeShift.Name = "btnAddEmployeeShift";
            btnAddEmployeeShift.Size = new Size(100, 23);
            btnAddEmployeeShift.TabIndex = 6;
            btnAddEmployeeShift.Text = "Add";
            btnAddEmployeeShift.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1290, 755);
            Controls.Add(panel1);
            Controls.Add(btnNewAction);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSettings";
            Text = "frmSettings";
            Load += frmSettings_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNewAction;
        private FlowLayoutPanel flowSettingDisplay;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtActivityName;
        private TextBox txtActivityRating;
        private TextBox txtIncidentDate;
        private TextBox txtIncidentNote;
        private TextBox txtIncident_ActivityID;
        private TextBox txtActivityMod_ActivityID;
        private TextBox txtActivityModName;
        private TextBox txtActivityModRatingAdjustment;
        private TextBox txtShiftDate;
        private TextBox txtShiftEmployeeList;
        private TextBox txtEmployeeShiftEmployeeName;
        private TextBox txtEmployeeShift_ShiftID;
        private TextBox txtEmployeeShiftEmployeeRating;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label23;
        private Label label24;
        private Label label25;
        private TextBox txtEmployeeShiftIncidents;
        private Button btnAddActivity;
        private Button btnLoadActivities;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button btnLoadIncidents;
        private Button btnAddIncident;
        private Button btnLoadActivitiyMods;
        private Button btnAddActivityMod;
        private Button btnLoadShifts;
        private Button btnAddShift;
        private Button btnLoadEmployeeShifts;
        private Button btnAddEmployeeShift;
    }
}