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
            lblNewBaseRating = new Label();
            label1 = new Label();
            lblCreateNew = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label8 = new Label();
            listBox1 = new ListBox();
            numericUpDown1 = new NumericUpDown();
            nudEndingNumber = new NumericUpDown();
            nudStartingNumber = new NumericUpDown();
            cboEndingLetter = new ComboBox();
            cboStartingLetter = new ComboBox();
            cboExcelPosition = new ComboBox();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lblExcelRange = new Label();
            label4 = new Label();
            label3 = new Label();
            btnSavePosition = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEndingNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStartingNumber).BeginInit();
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
            panel1.Size = new Size(431, 674);
            panel1.TabIndex = 11;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(167, 204, 237);
            btnAddItem.FlatAppearance.BorderSize = 0;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Location = new Point(12, 181);
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
            txtNewRating.Location = new Point(180, 122);
            txtNewRating.Name = "txtNewRating";
            txtNewRating.Size = new Size(229, 29);
            txtNewRating.TabIndex = 1;
            // 
            // txtNewName
            // 
            txtNewName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewName.Location = new Point(180, 81);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(229, 29);
            txtNewName.TabIndex = 1;
            // 
            // lblNewBaseRating
            // 
            lblNewBaseRating.AutoSize = true;
            lblNewBaseRating.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNewBaseRating.ForeColor = Color.White;
            lblNewBaseRating.Location = new Point(16, 122);
            lblNewBaseRating.Name = "lblNewBaseRating";
            lblNewBaseRating.Size = new Size(128, 25);
            lblNewBaseRating.TabIndex = 0;
            lblNewBaseRating.Text = "Rating Impact";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(78, 81);
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
            lblCreateNew.Location = new Point(126, 13);
            lblCreateNew.Name = "lblCreateNew";
            lblCreateNew.Size = new Size(195, 30);
            lblCreateNew.TabIndex = 0;
            lblCreateNew.Text = "Create New Activity";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSavePosition);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(nudEndingNumber);
            panel2.Controls.Add(nudStartingNumber);
            panel2.Controls.Add(cboEndingLetter);
            panel2.Controls.Add(cboStartingLetter);
            panel2.Controls.Add(cboExcelPosition);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblExcelRange);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(822, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(448, 674);
            panel2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 422);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 23);
            textBox1.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(8, 420);
            label8.Name = "label8";
            label8.Size = new Size(119, 25);
            label8.TabIndex = 6;
            label8.Text = "Excel Ignore:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(140, 461);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(224, 139);
            listBox1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(140, 348);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(43, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // nudEndingNumber
            // 
            nudEndingNumber.Location = new Point(210, 276);
            nudEndingNumber.Name = "nudEndingNumber";
            nudEndingNumber.Size = new Size(49, 23);
            nudEndingNumber.TabIndex = 3;
            nudEndingNumber.ValueChanged += SetExcelRangeText;
            // 
            // nudStartingNumber
            // 
            nudStartingNumber.Location = new Point(210, 214);
            nudStartingNumber.Name = "nudStartingNumber";
            nudStartingNumber.Size = new Size(49, 23);
            nudStartingNumber.TabIndex = 3;
            nudStartingNumber.ValueChanged += SetExcelRangeText;
            // 
            // cboEndingLetter
            // 
            cboEndingLetter.FormattingEnabled = true;
            cboEndingLetter.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" });
            cboEndingLetter.Location = new Point(140, 276);
            cboEndingLetter.Name = "cboEndingLetter";
            cboEndingLetter.Size = new Size(64, 23);
            cboEndingLetter.TabIndex = 2;
            cboEndingLetter.SelectedIndexChanged += SetExcelRangeText;
            // 
            // cboStartingLetter
            // 
            cboStartingLetter.FormattingEnabled = true;
            cboStartingLetter.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" });
            cboStartingLetter.Location = new Point(140, 214);
            cboStartingLetter.Name = "cboStartingLetter";
            cboStartingLetter.Size = new Size(64, 23);
            cboStartingLetter.TabIndex = 2;
            cboStartingLetter.SelectedIndexChanged += SetExcelRangeText;
            // 
            // cboExcelPosition
            // 
            cboExcelPosition.FormattingEnabled = true;
            cboExcelPosition.Location = new Point(140, 81);
            cboExcelPosition.Name = "cboExcelPosition";
            cboExcelPosition.Size = new Size(192, 23);
            cboExcelPosition.TabIndex = 1;
            cboExcelPosition.SelectedIndexChanged += cboExcelPosition_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(140, 15);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 0;
            label2.Text = "Excel Settings";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(22, 348);
            label7.Name = "label7";
            label7.Size = new Size(105, 25);
            label7.TabIndex = 0;
            label7.Text = "Worksheet:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(93, 276);
            label6.Name = "label6";
            label6.Size = new Size(35, 25);
            label6.TabIndex = 0;
            label6.Text = "To:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(69, 209);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 0;
            label5.Text = "From:";
            // 
            // lblExcelRange
            // 
            lblExcelRange.AutoSize = true;
            lblExcelRange.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblExcelRange.ForeColor = Color.White;
            lblExcelRange.Location = new Point(140, 144);
            lblExcelRange.Name = "lblExcelRange";
            lblExcelRange.Size = new Size(163, 25);
            lblExcelRange.TabIndex = 0;
            lblExcelRange.Text = "Select Cells Below";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 144);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 0;
            label4.Text = "Cell Range:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 81);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 0;
            label3.Text = "Position:";
            // 
            // btnSavePosition
            // 
            btnSavePosition.BackColor = Color.FromArgb(167, 204, 237);
            btnSavePosition.FlatAppearance.BorderSize = 0;
            btnSavePosition.FlatStyle = FlatStyle.Flat;
            btnSavePosition.Location = new Point(312, 211);
            btnSavePosition.Name = "btnSavePosition";
            btnSavePosition.Size = new Size(107, 27);
            btnSavePosition.TabIndex = 8;
            btnSavePosition.Text = "Save Changes";
            btnSavePosition.UseVisualStyleBackColor = false;
            btnSavePosition.Click += btnSavePosition_Click;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1290, 755);
            Controls.Add(panel2);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEndingNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStartingNumber).EndInit();
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
        private Panel panel2;
        private NumericUpDown nudEndingNumber;
        private NumericUpDown nudStartingNumber;
        private ComboBox cboEndingLetter;
        private ComboBox cboStartingLetter;
        private ComboBox cboExcelPosition;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label lblExcelRange;
        private Label label4;
        private Label label3;
        private Label label7;
        private TextBox textBox1;
        private Label label8;
        private ListBox listBox1;
        private NumericUpDown numericUpDown1;
        private Button btnSavePosition;
    }
}