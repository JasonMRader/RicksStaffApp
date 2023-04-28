namespace RicksStaffApp
{
    partial class frmExcelDownload
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
            lbEmployees = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.Controls.Add(lbEmployees);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 624);
            panel1.TabIndex = 0;
            // 
            // lbEmployees
            // 
            lbEmployees.FormattingEnabled = true;
            lbEmployees.ItemHeight = 15;
            lbEmployees.Location = new Point(25, 111);
            lbEmployees.Name = "lbEmployees";
            lbEmployees.Size = new Size(257, 484);
            lbEmployees.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(37, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(245, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(167, 204, 237);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(546, 17);
            button1.Name = "button1";
            button1.Size = new Size(195, 36);
            button1.TabIndex = 5;
            button1.Text = "Add To Shift";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(359, 84);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 4;
            label3.Text = "Staff In Database";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(145, 84);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 3;
            label2.Text = "Staff From Excel";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(37, 42, 64);
            flowLayoutPanel2.Location = new Point(326, 120);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(180, 490);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(37, 42, 64);
            flowLayoutPanel1.Location = new Point(527, 120);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(214, 490);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(304, 17);
            label1.Name = "label1";
            label1.Size = new Size(174, 45);
            label1.TabIndex = 0;
            label1.Text = "Excel Data";
            // 
            // frmExcelDownload
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 105, 144);
            ClientSize = new Size(775, 630);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmExcelDownload";
            Padding = new Padding(3);
            Text = "frmExcelDownload";
            Load += frmExcelDownload_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label3;
        private Label label2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ListBox lbEmployees;
    }
}