using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksStaffApp
{
    public static class UIHelper
    {
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
