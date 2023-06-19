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
            flowIncidentToAdd = new FlowLayoutPanel();
            flowActivityDisplay = new FlowLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            lblEmpolyeeName = new Label();
            btnDone = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(flowIncidentToAdd);
            panel1.Controls.Add(flowActivityDisplay);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblEmpolyeeName);
            panel1.Controls.Add(btnDone);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 624);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // flowIncidentToAdd
            // 
            flowIncidentToAdd.BackColor = Color.FromArgb(37, 42, 64);
            flowIncidentToAdd.FlowDirection = FlowDirection.TopDown;
            flowIncidentToAdd.Location = new Point(303, 92);
            flowIncidentToAdd.Name = "flowIncidentToAdd";
            flowIncidentToAdd.Size = new Size(450, 460);
            flowIncidentToAdd.TabIndex = 6;
            // 
            // flowActivityDisplay
            // 
            flowActivityDisplay.AutoScroll = true;
            flowActivityDisplay.BackColor = Color.FromArgb(37, 42, 64);
            flowActivityDisplay.Location = new Point(17, 92);
            flowActivityDisplay.Name = "flowActivityDisplay";
            flowActivityDisplay.Size = new Size(280, 460);
            flowActivityDisplay.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(284, 74);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 4;
            label2.Text = "Edit Incident:";
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
            // lblEmpolyeeName
            // 
            lblEmpolyeeName.AutoSize = true;
            lblEmpolyeeName.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpolyeeName.ForeColor = Color.White;
            lblEmpolyeeName.Location = new Point(254, -1);
            lblEmpolyeeName.Name = "lblEmpolyeeName";
            lblEmpolyeeName.Size = new Size(263, 45);
            lblEmpolyeeName.TabIndex = 1;
            lblEmpolyeeName.Text = "Employee Name";
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.FromArgb(167, 204, 237);
            btnDone.FlatStyle = FlatStyle.Flat;
            btnDone.Location = new Point(579, 558);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(160, 34);
            btnDone.TabIndex = 0;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // frmServerShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 105, 144);
            ClientSize = new Size(775, 630);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmServerShift";
            Padding = new Padding(3);
            Text = "frmServerShift";
            Load += frmServerShift_Load;
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
        private FlowLayoutPanel flowActivityDisplay;
        private FlowLayoutPanel flowIncidentToAdd;
    }
}