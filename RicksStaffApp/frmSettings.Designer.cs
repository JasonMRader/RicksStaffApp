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
            btnNewAction = new Button();
            flowSettingDisplay = new FlowLayoutPanel();
            label2 = new Label();
            label5 = new Label();
            txtActivityName = new TextBox();
            txtActivityRating = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label19 = new Label();
            btnAddActivity = new Button();
            btnLoadActivities = new Button();
            panel2 = new Panel();
            panel5 = new Panel();
            dtpShiftDate = new DateTimePicker();
            cbIsAmShift = new CheckBox();
            btnLoadShifts = new Button();
            btnAddShift = new Button();
            rdoActivitiesView = new RadioButton();
            rdoShifts = new RadioButton();
            rdoPositions = new RadioButton();
            panel1 = new Panel();
            btnAddItem = new Button();
            txtNewRating = new TextBox();
            txtNewName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            lblCreateNew = new Label();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            flowSettingDisplay.AutoScroll = true;
            flowSettingDisplay.BackColor = Color.FromArgb(37, 42, 64);
            flowSettingDisplay.FlowDirection = FlowDirection.TopDown;
            flowSettingDisplay.Location = new Point(12, 69);
            flowSettingDisplay.Margin = new Padding(3, 0, 3, 3);
            flowSettingDisplay.Name = "flowSettingDisplay";
            flowSettingDisplay.Padding = new Padding(10, 15, 0, 0);
            flowSettingDisplay.Size = new Size(326, 674);
            flowSettingDisplay.TabIndex = 2;
            flowSettingDisplay.WrapContents = false;
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
            // txtActivityName
            // 
            txtActivityName.Location = new Point(23, 45);
            txtActivityName.Name = "txtActivityName";
            txtActivityName.Size = new Size(100, 23);
            txtActivityName.TabIndex = 5;
            // 
            // txtActivityRating
            // 
            txtActivityRating.Location = new Point(23, 93);
            txtActivityRating.Name = "txtActivityRating";
            txtActivityRating.Size = new Size(100, 23);
            txtActivityRating.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(21, 26);
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
            label8.Location = new Point(21, 75);
            label8.Name = "label8";
            label8.Size = new Size(108, 15);
            label8.TabIndex = 4;
            label8.Text = "Base Rating Impact";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(8, 22);
            label19.Name = "label19";
            label19.Size = new Size(31, 15);
            label19.TabIndex = 4;
            label19.Text = "Date";
            // 
            // btnAddActivity
            // 
            btnAddActivity.Location = new Point(21, 122);
            btnAddActivity.Name = "btnAddActivity";
            btnAddActivity.Size = new Size(100, 23);
            btnAddActivity.TabIndex = 6;
            btnAddActivity.Text = "Add";
            btnAddActivity.UseVisualStyleBackColor = true;
            btnAddActivity.Click += btnAddActivity_Click;
            // 
            // btnLoadActivities
            // 
            btnLoadActivities.Location = new Point(21, 161);
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
            panel2.Location = new Point(1125, 325);
            panel2.Name = "panel2";
            panel2.Size = new Size(145, 206);
            panel2.TabIndex = 7;
            panel2.Visible = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(37, 42, 64);
            panel5.Controls.Add(dtpShiftDate);
            panel5.Controls.Add(cbIsAmShift);
            panel5.Controls.Add(btnLoadShifts);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(btnAddShift);
            panel5.Location = new Point(1132, 537);
            panel5.Name = "panel5";
            panel5.Size = new Size(145, 206);
            panel5.TabIndex = 9;
            panel5.Visible = false;
            // 
            // dtpShiftDate
            // 
            dtpShiftDate.Format = DateTimePickerFormat.Short;
            dtpShiftDate.Location = new Point(3, 45);
            dtpShiftDate.Name = "dtpShiftDate";
            dtpShiftDate.Size = new Size(98, 23);
            dtpShiftDate.TabIndex = 8;
            // 
            // cbIsAmShift
            // 
            cbIsAmShift.AutoSize = true;
            cbIsAmShift.FlatStyle = FlatStyle.Flat;
            cbIsAmShift.ForeColor = Color.White;
            cbIsAmShift.Location = new Point(8, 93);
            cbIsAmShift.Name = "cbIsAmShift";
            cbIsAmShift.Size = new Size(74, 19);
            cbIsAmShift.TabIndex = 7;
            cbIsAmShift.Text = "AM Shift?";
            cbIsAmShift.UseVisualStyleBackColor = true;
            // 
            // btnLoadShifts
            // 
            btnLoadShifts.Location = new Point(22, 161);
            btnLoadShifts.Name = "btnLoadShifts";
            btnLoadShifts.Size = new Size(100, 23);
            btnLoadShifts.TabIndex = 6;
            btnLoadShifts.Text = "Load";
            btnLoadShifts.UseVisualStyleBackColor = true;
            btnLoadShifts.Click += btnLoadShifts_Click;
            // 
            // btnAddShift
            // 
            btnAddShift.Location = new Point(22, 122);
            btnAddShift.Name = "btnAddShift";
            btnAddShift.Size = new Size(100, 23);
            btnAddShift.TabIndex = 6;
            btnAddShift.Text = "Add";
            btnAddShift.UseVisualStyleBackColor = true;
            btnAddShift.Click += btnAddShift_Click;
            // 
            // rdoActivitiesView
            // 
            rdoActivitiesView.Appearance = Appearance.Button;
            rdoActivitiesView.FlatAppearance.BorderSize = 0;
            rdoActivitiesView.FlatAppearance.CheckedBackColor = Color.FromArgb(37, 42, 64);
            rdoActivitiesView.FlatStyle = FlatStyle.Flat;
            rdoActivitiesView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdoActivitiesView.ForeColor = Color.FromArgb(0, 126, 249);
            rdoActivitiesView.Location = new Point(12, 36);
            rdoActivitiesView.Margin = new Padding(3, 3, 0, 0);
            rdoActivitiesView.Name = "rdoActivitiesView";
            rdoActivitiesView.Size = new Size(163, 33);
            rdoActivitiesView.TabIndex = 10;
            rdoActivitiesView.TabStop = true;
            rdoActivitiesView.Text = "Activities";
            rdoActivitiesView.TextAlign = ContentAlignment.MiddleCenter;
            rdoActivitiesView.UseVisualStyleBackColor = true;
            rdoActivitiesView.CheckedChanged += rdoActivitiesView_CheckedChanged;
            // 
            // rdoShifts
            // 
            rdoShifts.Appearance = Appearance.Button;
            rdoShifts.FlatAppearance.BorderSize = 0;
            rdoShifts.FlatAppearance.CheckedBackColor = Color.FromArgb(37, 42, 64);
            rdoShifts.FlatStyle = FlatStyle.Flat;
            rdoShifts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdoShifts.ForeColor = Color.FromArgb(0, 126, 249);
            rdoShifts.Location = new Point(972, 13);
            rdoShifts.Margin = new Padding(0, 3, 0, 0);
            rdoShifts.Name = "rdoShifts";
            rdoShifts.Size = new Size(104, 33);
            rdoShifts.TabIndex = 10;
            rdoShifts.TabStop = true;
            rdoShifts.Text = "Shifts";
            rdoShifts.TextAlign = ContentAlignment.MiddleCenter;
            rdoShifts.UseVisualStyleBackColor = true;
            rdoShifts.Visible = false;
            rdoShifts.CheckedChanged += rdoShifts_CheckedChanged;
            // 
            // rdoPositions
            // 
            rdoPositions.Appearance = Appearance.Button;
            rdoPositions.FlatAppearance.BorderSize = 0;
            rdoPositions.FlatAppearance.CheckedBackColor = Color.FromArgb(37, 42, 64);
            rdoPositions.FlatStyle = FlatStyle.Flat;
            rdoPositions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdoPositions.ForeColor = Color.FromArgb(0, 126, 249);
            rdoPositions.Location = new Point(175, 36);
            rdoPositions.Margin = new Padding(0, 3, 0, 0);
            rdoPositions.Name = "rdoPositions";
            rdoPositions.Size = new Size(163, 33);
            rdoPositions.TabIndex = 10;
            rdoPositions.TabStop = true;
            rdoPositions.Text = "Positions";
            rdoPositions.TextAlign = ContentAlignment.MiddleCenter;
            rdoPositions.UseVisualStyleBackColor = true;
            rdoPositions.CheckedChanged += rdoPositions_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddItem);
            panel1.Controls.Add(txtNewRating);
            panel1.Controls.Add(txtNewName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblCreateNew);
            panel1.Location = new Point(366, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 674);
            panel1.TabIndex = 11;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(167, 204, 237);
            btnAddItem.FlatAppearance.BorderSize = 0;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Location = new Point(41, 177);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(397, 43);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "Create Activity";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // txtNewRating
            // 
            txtNewRating.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewRating.Location = new Point(209, 118);
            txtNewRating.Name = "txtNewRating";
            txtNewRating.Size = new Size(229, 29);
            txtNewRating.TabIndex = 1;
            // 
            // txtNewName
            // 
            txtNewName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewName.Location = new Point(209, 77);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(229, 29);
            txtNewName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(41, 118);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 0;
            label3.Text = "Rating Impact:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(107, 77);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // lblCreateNew
            // 
            lblCreateNew.AutoSize = true;
            lblCreateNew.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreateNew.ForeColor = Color.White;
            lblCreateNew.Location = new Point(155, 9);
            lblCreateNew.Name = "lblCreateNew";
            lblCreateNew.Size = new Size(195, 30);
            lblCreateNew.TabIndex = 0;
            lblCreateNew.Text = "Create New Activity";
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1290, 755);
            Controls.Add(panel1);
            Controls.Add(rdoPositions);
            Controls.Add(rdoShifts);
            Controls.Add(rdoActivitiesView);
            Controls.Add(flowSettingDisplay);
            Controls.Add(btnNewAction);
            Controls.Add(panel2);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSettings";
            Text = "frmSettings";
            Load += frmSettings_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnNewAction;
        private FlowLayoutPanel flowSettingDisplay;
        private Label label2;
        private Label label5;
        private TextBox txtActivityName;
        private TextBox txtActivityRating;
        private Label label7;
        private Label label8;
        private Label label19;
        private Button btnAddActivity;
        private Button btnLoadActivities;
        private Panel panel2;
        private Panel panel5;
        private Button btnLoadShifts;
        private Button btnAddShift;
        private CheckBox cbIsAmShift;
        private DateTimePicker dtpShiftDate;
        private RadioButton rdoActivitiesView;
        private RadioButton rdoShifts;
        private RadioButton rdoPositions;
        private Panel panel1;
        private Label lblCreateNew;
        private Button btnAddItem;
        private TextBox txtNewRating;
        private TextBox txtNewName;
        private Label label3;
        private Label label1;
    }
}