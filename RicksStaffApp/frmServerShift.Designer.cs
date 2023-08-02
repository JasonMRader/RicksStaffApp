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
            flowPositions = new FlowLayoutPanel();
            picShiftRating = new PictureBox();
            flowIncidentToAdd = new FlowLayoutPanel();
            flowActivityDisplay = new FlowLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            lblEmpolyeeName = new Label();
            btnDone = new Button();
            rdoAll = new RadioButton();
            rdoGood = new RadioButton();
            rdoBad = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShiftRating).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(rdoBad);
            panel1.Controls.Add(rdoGood);
            panel1.Controls.Add(rdoAll);
            panel1.Controls.Add(flowPositions);
            panel1.Controls.Add(picShiftRating);
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
            // flowPositions
            // 
            flowPositions.Location = new Point(303, 3);
            flowPositions.Name = "flowPositions";
            flowPositions.Size = new Size(461, 41);
            flowPositions.TabIndex = 8;
            // 
            // picShiftRating
            // 
            picShiftRating.Location = new Point(113, 33);
            picShiftRating.Name = "picShiftRating";
            picShiftRating.Size = new Size(120, 40);
            picShiftRating.SizeMode = PictureBoxSizeMode.CenterImage;
            picShiftRating.TabIndex = 7;
            picShiftRating.TabStop = false;
            // 
            // flowIncidentToAdd
            // 
            flowIncidentToAdd.BackColor = Color.FromArgb(37, 42, 64);
            flowIncidentToAdd.FlowDirection = FlowDirection.TopDown;
            flowIncidentToAdd.Location = new Point(303, 146);
            flowIncidentToAdd.Name = "flowIncidentToAdd";
            flowIncidentToAdd.Size = new Size(450, 406);
            flowIncidentToAdd.TabIndex = 6;
            flowIncidentToAdd.ControlAdded += UpdateRatingPicture;
            // 
            // flowActivityDisplay
            // 
            flowActivityDisplay.AutoScroll = true;
            flowActivityDisplay.BackColor = Color.FromArgb(37, 42, 64);
            flowActivityDisplay.Location = new Point(17, 146);
            flowActivityDisplay.Name = "flowActivityDisplay";
            flowActivityDisplay.Size = new Size(280, 406);
            flowActivityDisplay.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(501, 118);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 4;
            label2.Text = "Edit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 118);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 4;
            label1.Text = "Add";
            // 
            // lblEmpolyeeName
            // 
            lblEmpolyeeName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpolyeeName.ForeColor = Color.White;
            lblEmpolyeeName.Location = new Point(-1, 0);
            lblEmpolyeeName.Name = "lblEmpolyeeName";
            lblEmpolyeeName.Size = new Size(381, 30);
            lblEmpolyeeName.TabIndex = 1;
            lblEmpolyeeName.Text = "Employee Name";
            lblEmpolyeeName.TextAlign = ContentAlignment.MiddleCenter;
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
            // rdoAll
            // 
            rdoAll.Appearance = Appearance.Button;
            rdoAll.BackColor = Color.FromArgb(167, 204, 237);
            rdoAll.FlatAppearance.BorderSize = 0;
            rdoAll.FlatStyle = FlatStyle.Flat;
            rdoAll.Location = new Point(78, 118);
            rdoAll.Name = "rdoAll";
            rdoAll.Size = new Size(69, 24);
            rdoAll.TabIndex = 9;
            rdoAll.TabStop = true;
            rdoAll.Text = "All";
            rdoAll.TextAlign = ContentAlignment.MiddleCenter;
            rdoAll.UseVisualStyleBackColor = false;
            rdoAll.CheckedChanged += rdoAll_CheckedChanged;
            // 
            // rdoGood
            // 
            rdoGood.Appearance = Appearance.Button;
            rdoGood.BackColor = Color.FromArgb(167, 204, 237);
            rdoGood.FlatAppearance.BorderSize = 0;
            rdoGood.FlatStyle = FlatStyle.Flat;
            rdoGood.Location = new Point(153, 118);
            rdoGood.Name = "rdoGood";
            rdoGood.Size = new Size(69, 24);
            rdoGood.TabIndex = 9;
            rdoGood.TabStop = true;
            rdoGood.Text = "Good";
            rdoGood.TextAlign = ContentAlignment.MiddleCenter;
            rdoGood.UseVisualStyleBackColor = false;
            rdoGood.CheckedChanged += rdoGood_CheckedChanged;
            // 
            // rdoBad
            // 
            rdoBad.Appearance = Appearance.Button;
            rdoBad.BackColor = Color.FromArgb(167, 204, 237);
            rdoBad.FlatAppearance.BorderSize = 0;
            rdoBad.FlatStyle = FlatStyle.Flat;
            rdoBad.Location = new Point(228, 118);
            rdoBad.Name = "rdoBad";
            rdoBad.Size = new Size(69, 24);
            rdoBad.TabIndex = 9;
            rdoBad.TabStop = true;
            rdoBad.Text = "Bad";
            rdoBad.TextAlign = ContentAlignment.MiddleCenter;
            rdoBad.UseVisualStyleBackColor = false;
            rdoBad.CheckedChanged += rdoBad_CheckedChanged;
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
            ((System.ComponentModel.ISupportInitialize)picShiftRating).EndInit();
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
        private PictureBox picShiftRating;
        private FlowLayoutPanel flowPositions;
        private RadioButton rdoBad;
        private RadioButton rdoGood;
        private RadioButton rdoAll;
    }
}