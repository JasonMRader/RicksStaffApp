using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RicksStaffApp
{
    public partial class frmOverview : Form
    {

        List<Employee> employeeList = new List<Employee>();
        private frmAddNewEmployee frmAddNewEmployee;
        public frmOverview()
        {
            InitializeComponent();

        }

        private void frmAddNewEmployee_FormClosed(object? sender, EventArgs e)
        {
            foreach (Control control in pnlEmployeeDisplay.Controls)
            {
                control.Visible = true;
            }
        }

        private void frmOverview_Load(object sender, EventArgs e)
        {

            employeeList.Clear();
            employeeList = SqliteDataAccess.TestLoadEmployees();
            string[] names = employeeList.Select(e => e.FullName).ToArray();
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(names);
            txtBxEmployeeSearch.AutoCompleteCustomSource = autoComplete;
            txtBxEmployeeSearch.Validated += (sender, e) =>
            {
                // This code will run when the TextBox loses focus.
                // The user's input can be retrieved with textBox1.Text.
                string selectedName = txtBxEmployeeSearch.Text;

                // Find the employee with the matching name.
                Employee selectedEmployee = employeeList.FirstOrDefault(emp => emp.FullName == selectedName);

                if (selectedEmployee != null)
                {
                    pnlEmployeeStats.Controls.Clear();

                    frmViewEmployee viewEmployeeForm = new frmViewEmployee();
                    viewEmployeeForm.TopLevel = false;
                    viewEmployeeForm.FormBorderStyle = FormBorderStyle.None;
                    viewEmployeeForm.Dock = DockStyle.Fill;
                    pnlEmployeeStats.Controls.Add(viewEmployeeForm);
                    viewEmployeeForm.Show();
                }
            };
            //foreach (Employee employee in employeeList)
            //{
            //    employee.EmployeeShifts = SqliteDataAccess.LoadEmployeeShifts(employee);
            //}

            foreach (Employee employee in employeeList)
            {
                employee.AddIncidentsFromShifts();
                employee.UpdateOverallRating();
            }
            employeeList = employeeList.OrderBy(emp => emp.FullName).ToList();
            UIHelper.CreateEmployeePanels(employeeList, flowEmployeeDisplay, pnlEmployeeStats, lblMainWindowDescription, btnReset);
            var sortedEmployees = employeeList.OrderByDescending(emp => emp.OverallRating).Take(10).ToList();
            UIHelper.CreateEmployeeOverviewPanels(sortedEmployees, flowEmployeeRankings, pnlEmployeeStats, lblMainWindowDescription, btnReset);
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            //frmAddNewEmployee frmAddNewEmployee = new frmAddNewEmployee();
            frmAddNewEmployee = new frmAddNewEmployee();
            frmAddNewEmployee.FormClosed += frmAddNewEmployee_FormClosed;
            foreach (Control control in pnlEmployeeDisplay.Controls)
            {
                control.Visible = false;
            }
            frmAddNewEmployee.TopLevel = false;
            pnlEmployeeDisplay.Controls.Add(frmAddNewEmployee);
            frmAddNewEmployee.Show();

        }

        private void txtBxEmployeeSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //pnlEmployeeStats.Controls.Clear();
            foreach (Control control in pnlEmployeeStats.Controls)
            {
                if (control is frmViewEmployee)
                {
                    control.Dispose();
                }
                else
                {
                    control.Visible = true;
                }
                
            }
            lblMainWindowDescription.Text = "Overview";
            btnReset.Visible = false;

            //FlowLayoutPanel flowEmployeeDisplay = new FlowLayoutPanel();
            //flowEmployeeDisplay.Size = new System.Drawing.Size(501, 553);
            //flowEmployeeDisplay.Location = new System.Drawing.Point(127, 62);
            //pnlEmployeeStats.Controls.Add(flowEmployeeDisplay);

            //Label lblOverviewDisplay = new Label();
            //lblOverviewDisplay.Text = "Highest Rated";
            //lblOverviewDisplay.Font = new Font("Segoe UI", 16);
            //lblOverviewDisplay.Location = new System.Drawing.Point(286, 19);
            //lblOverviewDisplay.AutoSize = true;
            //lblOverviewDisplay.ForeColor = Color.FromArgb(255, 255, 255);
            //pnlEmployeeStats.Controls.Add(lblOverviewDisplay);

            //var sortedEmployees = employeeList.OrderByDescending(emp => emp.OverallRating).Take(10).ToList();
            //UIHelper.CreateEmployeeOverviewPanels(sortedEmployees, flowEmployeeDisplay, pnlEmployeeStats, lblMainWindowDescription, btnReset);
        }
    }
}
