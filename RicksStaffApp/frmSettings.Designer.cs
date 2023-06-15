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
            rdoActivitiesView = new RadioButton();
            rdoShifts = new RadioButton();
            rdoPositions = new RadioButton();
            panel1 = new Panel();
            btnAddItem = new Button();
            txtNewRating = new TextBox();
            txtNewName = new TextBox();
            label1 = new Label();
            lblCreateNew = new Label();
            lblNewBaseRating = new Label();
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
            panel1.Controls.Add(lblNewBaseRating);
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
            // lblNewBaseRating
            // 
            lblNewBaseRating.AutoSize = true;
            lblNewBaseRating.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNewBaseRating.ForeColor = Color.White;
            lblNewBaseRating.Location = new Point(45, 118);
            lblNewBaseRating.Name = "lblNewBaseRating";
            lblNewBaseRating.Size = new Size(128, 25);
            lblNewBaseRating.TabIndex = 0;
            lblNewBaseRating.Text = "Rating Impact";
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSettings";
            Text = "frmSettings";
            Load += frmSettings_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnNewAction;
        private FlowLayoutPanel flowSettingDisplay;
        private RadioButton rdoActivitiesView;
        private RadioButton rdoShifts;
        private RadioButton rdoPositions;
        private Panel panel1;
        private Label lblCreateNew;
        private Button btnAddItem;
        private TextBox txtNewRating;
        private TextBox txtNewName;
        //private Label lblNewActivityRating;
        private Label label1;
        private Label lblNewBaseRating;
    }
}