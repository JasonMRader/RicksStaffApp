namespace RicksStaffApp
{
    partial class frmDatePicker
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
            panel1 = new Panel();
            btnDone = new Button();
            label2 = new Label();
            label1 = new Label();
            calEnd = new MonthCalendar();
            calStart = new MonthCalendar();
            btnCancel = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.Controls.Add(btnDone);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(calEnd);
            panel1.Controls.Add(calStart);
            panel1.Location = new Point(12, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 264);
            panel1.TabIndex = 0;
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.FromArgb(167, 204, 237);
            btnDone.DialogResult = DialogResult.OK;
            btnDone.FlatAppearance.BorderSize = 0;
            btnDone.FlatStyle = FlatStyle.Flat;
            btnDone.Location = new Point(11, 221);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(472, 34);
            btnDone.TabIndex = 2;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(356, 14);
            label2.Name = "label2";
            label2.Size = new Size(31, 25);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(102, 14);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 1;
            label1.Text = "From";
            // 
            // calEnd
            // 
            calEnd.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            calEnd.Location = new Point(256, 48);
            calEnd.MaxSelectionCount = 1;
            calEnd.Name = "calEnd";
            calEnd.TabIndex = 0;
            calEnd.DateChanged += calEnd_DateChanged;
            // 
            // calStart
            // 
            calStart.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            calStart.Location = new Point(11, 48);
            calStart.MaxSelectionCount = 1;
            calStart.Name = "calStart";
            calStart.TabIndex = 0;
            calStart.DateChanged += calStart_DateChanged;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(474, 9);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(31, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "X";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(143, 9);
            label3.Name = "label3";
            label3.Size = new Size(246, 25);
            label3.TabIndex = 1;
            label3.Text = "Choose Custom Date Range";
            // 
            // frmDatePicker
            // 
            AcceptButton = btnDone;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            CancelButton = btnCancel;
            ClientSize = new Size(515, 325);
            Controls.Add(btnCancel);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDatePicker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDatePicker";
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnDone;
        private Label label2;
        private Label label1;
        private MonthCalendar calEnd;
        private MonthCalendar calStart;
        private Button btnCancel;
        private Label label3;
    }
}