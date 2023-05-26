namespace RicksStaffApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExitApp = new Button();
            pnlForm1 = new Panel();
            pnlButtonSelected = new Panel();
            label1 = new Label();
            rdoSettings = new RadioButton();
            rdoNewShiftForm = new RadioButton();
            rdoOverviewForm = new RadioButton();
            btnOpenTestForm = new Button();
            pnlNav = new Panel();
            panel1 = new Panel();
            pnlForm1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExitApp
            // 
            btnExitApp.FlatAppearance.BorderSize = 0;
            btnExitApp.FlatStyle = FlatStyle.Flat;
            btnExitApp.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExitApp.ForeColor = Color.FromArgb(250, 250, 250);
            btnExitApp.Location = new Point(1267, -3);
            btnExitApp.Name = "btnExitApp";
            btnExitApp.Size = new Size(30, 30);
            btnExitApp.TabIndex = 0;
            btnExitApp.Text = "X";
            btnExitApp.UseVisualStyleBackColor = true;
            btnExitApp.Click += btnExitApp_Click;
            // 
            // pnlForm1
            // 
            pnlForm1.BackColor = Color.FromArgb(24, 30, 54);
            pnlForm1.Controls.Add(pnlButtonSelected);
            pnlForm1.Controls.Add(label1);
            pnlForm1.Controls.Add(rdoSettings);
            pnlForm1.Controls.Add(rdoNewShiftForm);
            pnlForm1.Controls.Add(rdoOverviewForm);
            pnlForm1.Location = new Point(0, 30);
            pnlForm1.Margin = new Padding(3, 0, 3, 3);
            pnlForm1.Name = "pnlForm1";
            pnlForm1.Size = new Size(1300, 50);
            pnlForm1.TabIndex = 3;
            pnlForm1.MouseDown += Form1_MouseDown;
            pnlForm1.MouseMove += Form1_MouseMove;
            pnlForm1.MouseUp += Form1_MouseUp;
            // 
            // pnlButtonSelected
            // 
            pnlButtonSelected.BackColor = Color.FromArgb(0, 126, 149);
            pnlButtonSelected.Location = new Point(0, 0);
            pnlButtonSelected.Name = "pnlButtonSelected";
            pnlButtonSelected.Size = new Size(174, 3);
            pnlButtonSelected.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(788, -3);
            label1.Name = "label1";
            label1.Size = new Size(219, 50);
            label1.TabIndex = 1;
            label1.Text = "Staff Rating";
            label1.MouseDown += Form1_MouseDown;
            label1.MouseMove += Form1_MouseMove;
            label1.MouseUp += Form1_MouseUp;
            // 
            // rdoSettings
            // 
            rdoSettings.Appearance = Appearance.Button;
            rdoSettings.BackColor = Color.FromArgb(24, 30, 54);
            rdoSettings.Dock = DockStyle.Left;
            rdoSettings.FlatAppearance.BorderSize = 0;
            rdoSettings.FlatAppearance.CheckedBackColor = Color.FromArgb(46, 51, 73);
            rdoSettings.FlatStyle = FlatStyle.Flat;
            rdoSettings.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdoSettings.ForeColor = Color.FromArgb(0, 126, 249);
            rdoSettings.Location = new Point(348, 0);
            rdoSettings.Name = "rdoSettings";
            rdoSettings.Size = new Size(174, 50);
            rdoSettings.TabIndex = 0;
            rdoSettings.Text = "Settings";
            rdoSettings.TextAlign = ContentAlignment.MiddleCenter;
            rdoSettings.UseVisualStyleBackColor = false;
            rdoSettings.CheckedChanged += rdoSettings_CheckedChanged;
            // 
            // rdoNewShiftForm
            // 
            rdoNewShiftForm.Appearance = Appearance.Button;
            rdoNewShiftForm.BackColor = Color.FromArgb(24, 30, 54);
            rdoNewShiftForm.Dock = DockStyle.Left;
            rdoNewShiftForm.FlatAppearance.BorderSize = 0;
            rdoNewShiftForm.FlatAppearance.CheckedBackColor = Color.FromArgb(46, 51, 73);
            rdoNewShiftForm.FlatStyle = FlatStyle.Flat;
            rdoNewShiftForm.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdoNewShiftForm.ForeColor = Color.FromArgb(0, 126, 249);
            rdoNewShiftForm.Location = new Point(174, 0);
            rdoNewShiftForm.Name = "rdoNewShiftForm";
            rdoNewShiftForm.Size = new Size(174, 50);
            rdoNewShiftForm.TabIndex = 0;
            rdoNewShiftForm.Text = "Shifts";
            rdoNewShiftForm.TextAlign = ContentAlignment.MiddleCenter;
            rdoNewShiftForm.UseVisualStyleBackColor = false;
            rdoNewShiftForm.CheckedChanged += rdoNewShiftForm_CheckedChanged;
            // 
            // rdoOverviewForm
            // 
            rdoOverviewForm.Appearance = Appearance.Button;
            rdoOverviewForm.BackColor = Color.FromArgb(24, 30, 54);
            rdoOverviewForm.Checked = true;
            rdoOverviewForm.Dock = DockStyle.Left;
            rdoOverviewForm.FlatAppearance.BorderSize = 0;
            rdoOverviewForm.FlatAppearance.CheckedBackColor = Color.FromArgb(46, 51, 73);
            rdoOverviewForm.FlatStyle = FlatStyle.Flat;
            rdoOverviewForm.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdoOverviewForm.ForeColor = Color.FromArgb(0, 126, 249);
            rdoOverviewForm.Location = new Point(0, 0);
            rdoOverviewForm.Name = "rdoOverviewForm";
            rdoOverviewForm.Size = new Size(174, 50);
            rdoOverviewForm.TabIndex = 0;
            rdoOverviewForm.TabStop = true;
            rdoOverviewForm.Text = "Overview";
            rdoOverviewForm.TextAlign = ContentAlignment.MiddleCenter;
            rdoOverviewForm.UseVisualStyleBackColor = false;
            rdoOverviewForm.CheckedChanged += rdoOverviewForm_CheckedChanged;
            // 
            // btnOpenTestForm
            // 
            btnOpenTestForm.BackColor = Color.FromArgb(192, 255, 255);
            btnOpenTestForm.FlatStyle = FlatStyle.Flat;
            btnOpenTestForm.Location = new Point(12, 1);
            btnOpenTestForm.Name = "btnOpenTestForm";
            btnOpenTestForm.Size = new Size(40, 23);
            btnOpenTestForm.TabIndex = 1;
            btnOpenTestForm.Text = "Test Form";
            btnOpenTestForm.UseVisualStyleBackColor = false;
            btnOpenTestForm.Click += btnOpenTestForm_Click;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(46, 51, 73);
            pnlNav.Dock = DockStyle.Bottom;
            pnlNav.Location = new Point(0, 80);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(1300, 755);
            pnlNav.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(btnOpenTestForm);
            panel1.Controls.Add(btnExitApp);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 30);
            panel1.TabIndex = 5;
            panel1.MouseDown += Form1_MouseDown;
            panel1.MouseMove += Form1_MouseMove;
            panel1.MouseUp += Form1_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 44, 54);
            ClientSize = new Size(1300, 835);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(pnlNav);
            Controls.Add(pnlForm1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            pnlForm1.ResumeLayout(false);
            pnlForm1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private Button btnExitApp;
        private Panel pnlForm1;
        private RadioButton rdoNewShiftForm;
        private RadioButton rdoOverviewForm;
        private RadioButton rdoSettings;
        private Panel pnlNav;
        private Label label1;
        private Panel panel1;
        private Panel pnlButtonSelected;
        private Button btnOpenTestForm;
    }
}