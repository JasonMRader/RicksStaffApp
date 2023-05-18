namespace RicksStaffApp
{
    partial class frmTest
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
            btnLoadEmployees = new Button();
            btnLoadShifts = new Button();
            btnLoadEmployeeShifts = new Button();
            btnLoadIncidents = new Button();
            btnLoadActivities = new Button();
            SuspendLayout();
            // 
            // btnLoadEmployees
            // 
            btnLoadEmployees.Location = new Point(49, 59);
            btnLoadEmployees.Name = "btnLoadEmployees";
            btnLoadEmployees.Size = new Size(117, 23);
            btnLoadEmployees.TabIndex = 0;
            btnLoadEmployees.Text = "Load Employees";
            btnLoadEmployees.UseVisualStyleBackColor = true;
            btnLoadEmployees.Click += btnLoadEmployees_Click;
            // 
            // btnLoadShifts
            // 
            btnLoadShifts.Location = new Point(193, 59);
            btnLoadShifts.Name = "btnLoadShifts";
            btnLoadShifts.Size = new Size(75, 23);
            btnLoadShifts.TabIndex = 0;
            btnLoadShifts.Text = "Load Shifts";
            btnLoadShifts.UseVisualStyleBackColor = true;
            btnLoadShifts.Click += btnLoadShifts_Click;
            // 
            // btnLoadEmployeeShifts
            // 
            btnLoadEmployeeShifts.Location = new Point(288, 59);
            btnLoadEmployeeShifts.Name = "btnLoadEmployeeShifts";
            btnLoadEmployeeShifts.Size = new Size(141, 23);
            btnLoadEmployeeShifts.TabIndex = 0;
            btnLoadEmployeeShifts.Text = "Load Employee Shifts";
            btnLoadEmployeeShifts.UseVisualStyleBackColor = true;
            btnLoadEmployeeShifts.Click += btnLoadEmployeeShifts_Click;
            // 
            // btnLoadIncidents
            // 
            btnLoadIncidents.Location = new Point(476, 59);
            btnLoadIncidents.Name = "btnLoadIncidents";
            btnLoadIncidents.Size = new Size(146, 23);
            btnLoadIncidents.TabIndex = 0;
            btnLoadIncidents.Text = "Load Incidents";
            btnLoadIncidents.UseVisualStyleBackColor = true;
            btnLoadIncidents.Click += btnLoadIncidents_Click;
            // 
            // btnLoadActivities
            // 
            btnLoadActivities.Location = new Point(699, 59);
            btnLoadActivities.Name = "btnLoadActivities";
            btnLoadActivities.Size = new Size(126, 23);
            btnLoadActivities.TabIndex = 1;
            btnLoadActivities.Text = "Load Activities";
            btnLoadActivities.UseVisualStyleBackColor = true;
            btnLoadActivities.Click += btnLoadActivities_Click;
            // 
            // frmTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 740);
            Controls.Add(btnLoadActivities);
            Controls.Add(btnLoadIncidents);
            Controls.Add(btnLoadEmployeeShifts);
            Controls.Add(btnLoadShifts);
            Controls.Add(btnLoadEmployees);
            Name = "frmTest";
            Text = "frmTest";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoadEmployees;
        private Button btnLoadShifts;
        private Button btnLoadEmployeeShifts;
        private Button btnLoadIncidents;
        private Button btnLoadActivities;
    }
}