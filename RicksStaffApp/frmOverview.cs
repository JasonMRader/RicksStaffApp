﻿using System;
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

        List<Shift> ShiftList = new List<Shift>();
        List<Employee> employeeList = new List<Employee>();
        List<Position> positionList = new List<Position>();
        List<Incident> incidentList = new List<Incident>();
        private frmAddNewEmployee frmAddNewEmployee;
        int goodShiftCount = 0;
        int badShiftCount = 0;
        int averageShiftCount = 0;
        int totalShiftCount = 0;
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
            cboViewType.SelectedIndex = 0;
            cboSortBy.SelectedIndex = 0;
            cboTimeFrame.SelectedIndex = 0;
            positionList = SqliteDataAccess.LoadPositions();
            lbPositions.Items.Add("All Positions");
            foreach (Position position in positionList)
            {
                cboPositions.Items.Add(position.Name);
                lbPositions.Items.Add(position.Name);
            }
            cboPositions.SelectedIndex = 0;
            employeeList.Clear();
            employeeList = SqliteDataAccess.TestLoadEmployees();
            ShiftList.Clear();
            ShiftList = SqliteDataAccess.LoadShifts();
            var rankedShifts = ShiftList.OrderByDescending(shift => shift.AverageRating).Take(10).ToList();
            UIHelper.CreateShiftRankingPanel(rankedShifts, flowShiftRankings);
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
            List<Employee> HighestGoodShiftRation = new List<Employee>();
            foreach (Employee employee in employeeList)
            {
                employee.AddIncidentsFromShifts();
                employee.UpdateOverallRating();
                incidentList.AddRange(employee.Incidents);
            }
            employeeList = employeeList.OrderBy(emp => emp.FullName).ToList();
            UIHelper.CreateEmployeePanels(employeeList, flowEmployeeDisplay, pnlEmployeeStats, lblMainWindowDescription, btnReset);
            UIHelper.CreateIncidentFrequencyPanels(incidentList, flowMostFrequentIncidents);
            var EmployeesByRating = employeeList.OrderByDescending(emp => emp.OverallRating).Take(10).ToList();
            var EmployeesByGoodShiftRatio = employeeList.OrderByDescending(emp => emp.GoodShiftPercentage).Take(10).ToList();
            UIHelper.CreateEmployeeOverviewPanels(EmployeesByRating, flowEmployeeRankings, pnlEmployeeStats, lblMainWindowDescription, btnReset);
            UIHelper.CreateEmployeeGoodShiftRatioPanels(EmployeesByGoodShiftRatio, flowGoodShiftRankings);
            //UIHelper.ConfigureFlowLayoutPanel(flowGoodShiftRankings);
            //UIHelper.ConfigureFlowLayoutPanel(flowEmployeeDisplay);

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

        private void cboViewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboViewType.SelectedIndex == 0)
            {
                flowEmployeeRankings.Controls.Clear();
                var EmployeesByRating = employeeList.OrderByDescending(emp => emp.OverallRating).Take(10).ToList();
                UIHelper.CreateEmployeeOverviewPanels(EmployeesByRating, flowEmployeeRankings, pnlEmployeeStats, lblMainWindowDescription, btnReset);
            }
            if (cboViewType.SelectedIndex == 1)
            {
                flowEmployeeRankings.Controls.Clear();
                List<EmployeeShift> employeeShifts = new List<EmployeeShift>();
                foreach (Employee employee in employeeList)
                {
                    foreach (EmployeeShift employeeShift in employee.EmployeeShifts)
                    {
                        employeeShift.Employee = employee;
                        employeeShifts.Add(employeeShift);
                    }
                }
                var employeeShiftRanking = employeeShifts.OrderByDescending(employeeShift => employeeShift.ShiftRating).Take(15).ToList();
                foreach (EmployeeShift employeeShift in employeeShiftRanking)
                {
                    UIHelper.CreateEmployeeShiftRankingPanel(employeeShift, flowEmployeeRankings);
                }

            }
        }


    }
}
