namespace RicksStaffApp
{
    partial class frmServerShift
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
            lblEmpolyeeName = new Label();
            btnDone = new Button();
            panel2 = new Panel();
            listView1 = new ListView();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblEmpolyeeName);
            panel1.Controls.Add(btnDone);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 580);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += Form1_MouseDown;
            panel1.MouseMove += Form1_MouseMove;
            panel1.MouseUp += Form1_MouseUp;
            // 
            // lblEmpolyeeName
            // 
            lblEmpolyeeName.AutoSize = true;
            lblEmpolyeeName.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpolyeeName.ForeColor = Color.White;
            lblEmpolyeeName.Location = new Point(297, 18);
            lblEmpolyeeName.Name = "lblEmpolyeeName";
            lblEmpolyeeName.Size = new Size(263, 45);
            lblEmpolyeeName.TabIndex = 1;
            lblEmpolyeeName.Text = "Employee Name";
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.FromArgb(167, 204, 237);
            btnDone.FlatStyle = FlatStyle.Flat;
            btnDone.Location = new Point(704, 529);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(160, 34);
            btnDone.TabIndex = 0;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 42, 64);
            panel2.Location = new Point(273, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(652, 422);
            panel2.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(37, 42, 64);
            listView1.Location = new Point(17, 92);
            listView1.Name = "listView1";
            listView1.Size = new Size(250, 422);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 74);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 4;
            label1.Text = "Choose Actions:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(273, 74);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 4;
            label2.Text = "Edit Actions:";
            // 
            // frmServerShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 105, 144);
            ClientSize = new Size(950, 600);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmServerShift";
            Padding = new Padding(10);
            Text = "frmServerShift";
            Load += frmServerShift_Load;
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
        public Label lblEmpolyeeName;
        private Label label2;
        private Label label1;
        private ListView listView1;
        private Panel panel2;
    }
}