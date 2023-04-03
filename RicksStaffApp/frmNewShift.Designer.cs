namespace RicksStaffApp
{
    partial class frmNewShift
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
            button1 = new Button();
            lblShiftDateDisplay = new Label();
            btnExcelLoad = new Button();
            label1 = new Label();
            lbEmployees = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(72, 53);
            button1.Name = "button1";
            button1.Size = new Size(137, 38);
            button1.TabIndex = 0;
            button1.Text = "ToDo Add event to server shift";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblShiftDateDisplay
            // 
            lblShiftDateDisplay.AutoSize = true;
            lblShiftDateDisplay.Location = new Point(552, 65);
            lblShiftDateDisplay.Name = "lblShiftDateDisplay";
            lblShiftDateDisplay.Size = new Size(96, 15);
            lblShiftDateDisplay.TabIndex = 1;
            lblShiftDateDisplay.Text = "Shift On Date Of:";
            // 
            // btnExcelLoad
            // 
            btnExcelLoad.Location = new Point(335, 61);
            btnExcelLoad.Name = "btnExcelLoad";
            btnExcelLoad.Size = new Size(131, 23);
            btnExcelLoad.TabIndex = 2;
            btnExcelLoad.Text = "Load From Excel";
            btnExcelLoad.UseVisualStyleBackColor = true;
            btnExcelLoad.Click += btnExcelLoad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1022, 190);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 3;
            label1.Text = "Quick Add Incident";
            // 
            // lbEmployees
            // 
            lbEmployees.BackColor = Color.FromArgb(37, 42, 64);
            lbEmployees.ForeColor = Color.FromArgb(199, 199, 199);
            lbEmployees.FormattingEnabled = true;
            lbEmployees.ItemHeight = 15;
            lbEmployees.Location = new Point(297, 133);
            lbEmployees.MultiColumn = true;
            lbEmployees.Name = "lbEmployees";
            lbEmployees.Size = new Size(429, 529);
            lbEmployees.TabIndex = 4;
            lbEmployees.SelectedIndexChanged += lbEmployees_SelectedIndexChanged;
            // 
            // frmNewShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1300, 775);
            Controls.Add(lbEmployees);
            Controls.Add(label1);
            Controls.Add(btnExcelLoad);
            Controls.Add(lblShiftDateDisplay);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNewShift";
            Text = "frmNewShift";
            Load += frmNewShift_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblShiftDateDisplay;
        private Button btnExcelLoad;
        private Label label1;
        private ListBox lbEmployees;
    }
}