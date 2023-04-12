namespace RicksStaffApp
{
    public static class UIHelper
    {
        public static Color GoodColor = Color.FromArgb(192, 223, 161);
        public static Color BadColor = Color.FromArgb(226, 163, 199);
        public static Color NeutralColor = Color.FromArgb(184, 184, 243);
        public static void CreateShiftPanels(List<Shift> shiftList, FlowLayoutPanel flowEmployeeDisplay)
        {
            // Clear existing panels
            flowEmployeeDisplay.Controls.Clear();

            // Loop through employee list and create a panel for each employee
            foreach (Shift shift in shiftList)
            {
                FlowLayoutPanel activityPanelContainer = new FlowLayoutPanel();
                //activityPanelContainer.Size = new Size(430, 30);
                activityPanelContainer.AutoSize = true;
                activityPanelContainer.MinimumSize = new Size(470, 30);
                activityPanelContainer.MaximumSize = new Size(470, 200);
                activityPanelContainer.BackColor = MyColors.LightHighlight;
                activityPanelContainer.Margin = new Padding(0, 0, 0, 5);


                FlowLayoutPanel shiftPanel = new FlowLayoutPanel();
                shiftPanel.FlowDirection = FlowDirection.LeftToRight;
                shiftPanel.WrapContents = false;
                shiftPanel.AutoSize = true;
                shiftPanel.MaximumSize = new Size(200, 0);
                shiftPanel.MinimumSize = new Size(200, 0);
                shiftPanel.BackColor = MyColors.LightHighlight;
                shiftPanel.Margin = new Padding(1, 1, 1, 1);

                //// Create label for employee name
                Label lblName = new Label();
                lblName.Text = shift.Date.ToString("MM/dd/yyyy");
                lblName.AutoSize = false;
                lblName.Size = new Size(125, 30);
                lblName.TextAlign = ContentAlignment.MiddleCenter;
                shiftPanel.Controls.Add(lblName);

                

                

                


                activityPanelContainer.Controls.Add(shiftPanel);
                
                //foreach (Position pos in emp.Positions)
                //{
                //    Panel pnlPos = new Panel();
                //    pnlPos.Size = new Size(60, 30);
                //    pnlPos.BackColor = MyColors.PositionColor;
                //    Label lblPos = new Label();
                //    lblPos.Text = pos.Name;
                //    lblPos.Font = new Font(lblPos.Font.FontFamily, 10);
                //    lblPos.AutoSize = false;
                //    lblPos.Size = new Size(60, 30);
                //    lblPos.TextAlign = ContentAlignment.MiddleCenter;
                //    pnlPos.Controls.Add(lblPos);
                //    empPanel.Controls.Add(pnlPos);
                //}
                System.Windows.Forms.Button btnDelete = new System.Windows.Forms.Button();
                btnDelete.Text = "X";
                btnDelete.Margin = new Padding(0, 0, 0, 0);
                btnDelete.Location = new Point(410, 0);
                btnDelete.ForeColor = Color.Black;
                btnDelete.Font = new Font(btnDelete.Font.FontFamily, 10);
                btnDelete.TextAlign = ContentAlignment.MiddleCenter;
                btnDelete.FlatStyle = FlatStyle.Flat;
                btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                btnDelete.FlatAppearance.BorderSize = 0;
                btnDelete.Click += (sender, e) =>
                {
                    // Prompt user to confirm deletion
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this shift?", "Delete Shift", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Delete employee from database
                        SqliteDataAccess.DeleteShift(shift.ID);

                        // Remove employee from list
                        shiftList.Remove(shift);

                        // Update UI
                        CreateShiftPanels(shiftList, flowEmployeeDisplay);
                    }
                    };
                    btnDelete.Size = new Size(27, 27);
                    shiftPanel.Parent.Controls.Add(btnDelete);

                    flowEmployeeDisplay.Controls.Add(activityPanelContainer);
                
            }
        }
        public static void CreateActivityPanels(List<Activity> activityList, FlowLayoutPanel flowEmployeeDisplay)
        {
            // Clear existing panels
            flowEmployeeDisplay.Controls.Clear();

            // Loop through employee list and create a panel for each employee
            foreach (Activity activity in activityList)
            {
                FlowLayoutPanel activityPanelContainer = new FlowLayoutPanel();
                //activityPanelContainer.Size = new Size(430, 30);
                activityPanelContainer.AutoSize = true;
                activityPanelContainer.MinimumSize = new Size(470, 30);
                activityPanelContainer.MaximumSize = new Size(470, 200);
                activityPanelContainer.BackColor = MyColors.LightHighlight;
                activityPanelContainer.Margin = new Padding(0, 0, 0, 5);


                FlowLayoutPanel activityPanel = new FlowLayoutPanel();
                activityPanel.FlowDirection = FlowDirection.LeftToRight;
                activityPanel.WrapContents = false;
                activityPanel.AutoSize = true;
                activityPanel.MaximumSize = new Size(200, 0);
                activityPanel.MinimumSize = new Size(200, 0);
                activityPanel.BackColor = MyColors.LightHighlight;
                activityPanel.Margin = new Padding(1, 1, 1, 1);

                //// Create label for employee name
                Label lblName = new Label();
                lblName.Text = activity.Name + "  (ID " + activity.ID.ToString() + ")";
                lblName.AutoSize = false;
                lblName.Size = new Size(125, 30);
                lblName.TextAlign = ContentAlignment.MiddleCenter;
                activityPanel.Controls.Add(lblName);

                Label lblBaseRating = new Label();
                lblBaseRating.Text = activity.BaseRatingImpact.ToString();
                lblBaseRating.AutoSize = false;
                lblBaseRating.Size = new Size(25, 30);
                lblBaseRating.TextAlign = ContentAlignment.MiddleCenter;
                activityPanel.Controls.Add(lblBaseRating);

                Panel panel = new Panel();
                panel.Size = new Size(230, 30);
                panel.BackColor = MyColors.NeutralColor;
                Label modNumber = new Label();
                modNumber.Text = activity.ActivityModifiers.Count.ToString() + "  Modifiers";
                modNumber.AutoSize = false;
                modNumber.Size = new Size(100, 29);
                modNumber.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(modNumber);

                if (activity.ActivityModifiers.Count > 0)
                {
                    System.Windows.Forms.Button btnViewMods = new System.Windows.Forms.Button();
                    btnViewMods.Text = "View Mods";
                    btnViewMods.BackColor = Color.Black;
                    btnViewMods.Margin = new Padding(0, 0, 0, 0);
                    //btnViewMods.Location = new Point(410, 0);
                    btnViewMods.ForeColor = Color.LightBlue;
                    btnViewMods.Font = new Font(btnViewMods.Font.FontFamily, 10);
                    btnViewMods.TextAlign = ContentAlignment.MiddleCenter;
                    btnViewMods.FlatStyle = FlatStyle.Flat;
                    btnViewMods.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                    btnViewMods.Location = new Point(101, 1);
                    btnViewMods.FlatAppearance.BorderSize = 0;
                    btnViewMods.Click += (sender, e) =>
                    {
                       foreach (var mod in activity.ActivityModifiers)
                        {
                            CheckBox ck = new CheckBox();
                            ck.Text = mod.Name;
                            activityPanelContainer.Controls.Add(ck);
                        }
                    };
                    btnViewMods.Size = new Size(100, 27);
                    panel.Controls.Add(btnViewMods);
                }


                activityPanelContainer.Controls.Add(activityPanel);
                activityPanelContainer.Controls.Add(panel);
                //foreach (Position pos in emp.Positions)
                //{
                //    Panel pnlPos = new Panel();
                //    pnlPos.Size = new Size(60, 30);
                //    pnlPos.BackColor = MyColors.PositionColor;
                //    Label lblPos = new Label();
                //    lblPos.Text = pos.Name;
                //    lblPos.Font = new Font(lblPos.Font.FontFamily, 10);
                //    lblPos.AutoSize = false;
                //    lblPos.Size = new Size(60, 30);
                //    lblPos.TextAlign = ContentAlignment.MiddleCenter;
                //    pnlPos.Controls.Add(lblPos);
                //    empPanel.Controls.Add(pnlPos);
                //}
                System.Windows.Forms.Button btnDelete = new System.Windows.Forms.Button();
                btnDelete.Text = "X";
                btnDelete.Margin = new Padding(0, 0, 0, 0);
                btnDelete.Location = new Point(410, 0);
                btnDelete.ForeColor = Color.Black;
                btnDelete.Font = new Font(btnDelete.Font.FontFamily, 10);
                btnDelete.TextAlign = ContentAlignment.MiddleCenter;
                btnDelete.FlatStyle = FlatStyle.Flat;
                btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                btnDelete.FlatAppearance.BorderSize = 0;
                btnDelete.Click += (sender, e) =>
                {
                    // Prompt user to confirm deletion
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this activity?", "Delete Activity", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Delete employee from database
                        SqliteDataAccess.DeleteActivity(activity.ID);

                        // Remove employee from list
                        activityList.Remove(activity);

                        // Update UI
                        CreateActivityPanels(activityList, flowEmployeeDisplay);
                    }
                };
                btnDelete.Size = new Size(27, 27);
                activityPanel.Parent.Controls.Add(btnDelete);

                flowEmployeeDisplay.Controls.Add(activityPanelContainer);
            }
        }
    
    public static void CreateEmployeePanels(List<Employee> employeeList, FlowLayoutPanel flowEmployeeDisplay)
        {
            // Clear existing panels
            flowEmployeeDisplay.Controls.Clear();

            // Loop through employee list and create a panel for each employee
            foreach (Employee emp in employeeList)
            {
                Panel empPanelContainer = new Panel();
                empPanelContainer.Size = new Size(430, 30);
                empPanelContainer.BackColor = MyColors.LightHighlight;
                empPanelContainer.Margin = new Padding(0, 0, 0, 5);


                FlowLayoutPanel empPanel = new FlowLayoutPanel();
                empPanel.FlowDirection = FlowDirection.LeftToRight;
                empPanel.WrapContents = false;
                empPanel.AutoSize = true;
                empPanel.MaximumSize = new Size(400, 0);
                empPanel.MinimumSize = new Size(400, 0);
                empPanel.BackColor = MyColors.LightHighlight;
                empPanel.Margin = new Padding(1, 1, 1, 1);

                //// Create label for employee name
                //Label lblName = new Label();
                //lblName.Text = emp.FullName;
                //lblName.AutoSize = false;
                //lblName.Size = new Size(150, 16);
                //lblName.TextAlign = ContentAlignment.MiddleCenter;
                //empPanel.Controls.Add(lblName);
                // Create button for employee name
                Button btnName = new Button();
                btnName.Text = emp.FullName;
                btnName.Size = new Size(150, 30);
                btnName.TextAlign = ContentAlignment.MiddleCenter;
                btnName.FlatStyle = FlatStyle.Flat;


                // Add event handler for button click
                btnName.Click += (sender, e) =>
                {
                    // Open frmViewEmployee form with clicked employee as a parameter
                    frmViewEmployee viewEmployeeForm = new frmViewEmployee(emp);
                    viewEmployeeForm.ShowDialog();
                };

                empPanel.Controls.Add(btnName);


                // Create panels for employee positions
                foreach (Position pos in emp.Positions)
                {
                    Panel pnlPos = new Panel();
                    pnlPos.Size = new Size(60, 30);
                    pnlPos.BackColor = MyColors.PositionColor;
                    Label lblPos = new Label();
                    lblPos.Text = pos.Name;
                    lblPos.Font = new Font(lblPos.Font.FontFamily, 10);
                    lblPos.AutoSize = false;
                    lblPos.Size = new Size(60, 30);
                    lblPos.TextAlign = ContentAlignment.MiddleCenter;
                    pnlPos.Controls.Add(lblPos);
                    empPanel.Controls.Add(pnlPos);
                }

                // Add the employee panel to the container panel
                empPanelContainer.Controls.Add(empPanel);
                Panel pnlRating = new Panel();
                pnlRating.Size = new Size(30, 30);
                pnlRating.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                pnlRating.Margin = new Padding(0);
                pnlRating.Location = new Point(410, 0);
                Label lblRating = new Label();
                lblRating.Text = emp.OverallRating.ToString("F1");
                pnlRating.Controls.Add(lblRating);
                empPanelContainer.Controls.Add(pnlRating);

                // Add the delete button to the container panel
                //System.Windows.Forms.Button btnDelete = new System.Windows.Forms.Button();
                //btnDelete.Text = "X";
                //btnDelete.Margin = new Padding(0, 0, 0, 0);
                //btnDelete.Location = new Point(410, 0);
                //btnDelete.ForeColor = Color.Black;
                //btnDelete.Font = new Font(btnDelete.Font.FontFamily, 10);
                //btnDelete.TextAlign = ContentAlignment.MiddleCenter;
                //btnDelete.FlatStyle = FlatStyle.Flat;
                //btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                //btnDelete.FlatAppearance.BorderSize = 0;
                //btnDelete.Click += (sender, e) =>
                //{
                //    // Prompt user to confirm deletion
                //    DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //    if (result == DialogResult.Yes)
                //    {
                //        // Delete employee from database
                //        SqliteDataAccess.DeleteEmployee(emp.ID);

                //        // Remove employee from list
                //        employeeList.Remove(emp);

                //        // Update UI
                //        CreateEmployeePanels(employeeList, flowEmployeeDisplay);
                //    }
                //};
                //btnDelete.Size = new Size(27, 27);
                //empPanel.Parent.Controls.Add(btnDelete);

                flowEmployeeDisplay.Controls.Add(empPanelContainer);
            }
        }
    }

    //    public static void CreateEmployeePanels(List<Employee> employeeList, FlowLayoutPanel flowEmployeeDisplay)
    //    {
    //        // Clear existing panels
    //        flowEmployeeDisplay.Controls.Clear();

    //        // Loop through employee list and create a panel for each employee
    //        foreach (Employee emp in employeeList)
    //        {
    //            Panel empPanelContainer = new Panel();
    //            empPanelContainer.Size = new Size(430, 30);
    //            empPanelContainer.BackColor = MyColors.LightHighlight;
    //            empPanelContainer.Margin = new Padding(0, 0, 0, 5);


    //            FlowLayoutPanel empPanel = new FlowLayoutPanel();
    //            empPanel.FlowDirection = FlowDirection.LeftToRight;
    //            empPanel.WrapContents = false;
    //            empPanel.AutoSize = true;
    //            empPanel.MaximumSize = new Size(400, 0);
    //            empPanel.MinimumSize = new Size(400, 0);
    //            empPanel.BackColor = MyColors.LightHighlight;
    //            empPanel.Margin = new Padding(1, 1, 1, 1);

    //            //// Create label for employee name
    //            //Label lblName = new Label();
    //            //lblName.Text = emp.FullName;
    //            //lblName.AutoSize = false;
    //            //lblName.Size = new Size(150, 16);
    //            //lblName.TextAlign = ContentAlignment.MiddleCenter;
    //            //empPanel.Controls.Add(lblName);
    //            // Create button for employee name
    //            Button btnName = new Button();
    //            btnName.Text = emp.FullName;
    //            btnName.Size = new Size(150, 30);
    //            btnName.TextAlign = ContentAlignment.MiddleCenter;
    //            btnName.FlatStyle = FlatStyle.Flat;


    //            // Add event handler for button click
    //            btnName.Click += (sender, e) =>
    //            {
    //                // Open frmViewEmployee form with clicked employee as a parameter
    //                frmViewEmployee viewEmployeeForm = new frmViewEmployee(emp);
    //                viewEmployeeForm.ShowDialog();
    //            };

    //            empPanel.Controls.Add(btnName);


    //            // Create panels for employee positions
    //            foreach (Position pos in emp.Positions)
    //            {
    //                Panel pnlPos = new Panel();
    //                pnlPos.Size = new Size(60, 30);
    //                pnlPos.BackColor = MyColors.PositionColor;
    //                Label lblPos = new Label();
    //                lblPos.Text = pos.Name;
    //                lblPos.Font = new Font(lblPos.Font.FontFamily, 10);
    //                lblPos.AutoSize = false;
    //                lblPos.Size = new Size(60, 30);
    //                lblPos.TextAlign = ContentAlignment.MiddleCenter;
    //                pnlPos.Controls.Add(lblPos);
    //                empPanel.Controls.Add(pnlPos);
    //            }

    //            // Add the employee panel to the container panel
    //            empPanelContainer.Controls.Add(empPanel);
    //            Panel pnlRating = new Panel();
    //            pnlRating.Size = new Size(30, 30);
    //            pnlRating.Anchor = AnchorStyles.Right | AnchorStyles.Top;
    //            pnlRating.Margin = new Padding(0);
    //            pnlRating.Location = new Point(410, 0);
    //            Label lblRating = new Label();
    //            lblRating.Text = emp.OverallRating.ToString("F1");
    //            pnlRating.Controls.Add(lblRating);
    //            empPanelContainer.Controls.Add(pnlRating);

    //            // Add the delete button to the container panel
    //            //System.Windows.Forms.Button btnDelete = new System.Windows.Forms.Button();
    //            //btnDelete.Text = "X";
    //            //btnDelete.Margin = new Padding(0, 0, 0, 0);
    //            //btnDelete.Location = new Point(410, 0);
    //            //btnDelete.ForeColor = Color.Black;
    //            //btnDelete.Font = new Font(btnDelete.Font.FontFamily, 10);
    //            //btnDelete.TextAlign = ContentAlignment.MiddleCenter;
    //            //btnDelete.FlatStyle = FlatStyle.Flat;
    //            //btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    //            //btnDelete.FlatAppearance.BorderSize = 0;
    //            //btnDelete.Click += (sender, e) =>
    //            //{
    //            //    // Prompt user to confirm deletion
    //            //    DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    //            //    if (result == DialogResult.Yes)
    //            //    {
    //            //        // Delete employee from database
    //            //        SqliteDataAccess.DeleteEmployee(emp.ID);

    //            //        // Remove employee from list
    //            //        employeeList.Remove(emp);

    //            //        // Update UI
    //            //        CreateEmployeePanels(employeeList, flowEmployeeDisplay);
    //            //    }
    //            //};
    //            //btnDelete.Size = new Size(27, 27);
    //            //empPanel.Parent.Controls.Add(btnDelete);

    //            flowEmployeeDisplay.Controls.Add(empPanelContainer);
    //        }
    //    }
    //}

}
