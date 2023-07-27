using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RicksStaffApp
{
    public partial class frmOverview : Form
    {

        List<Shift> AllShiftList = new List<Shift>();
        List<Employee> AllEmployeeList = new List<Employee>();
        List<Position> AllPositionList = new List<Position>();
        List<Incident> AllIncidentList = new List<Incident>();
        List<EmployeeShift> AllEmployeeShiftList = new List<EmployeeShift>();

        List<Shift> FilteredShiftList = new List<Shift>();
        List<Employee> FilteredEmployeeList = new List<Employee>();
        List<Position> FilteredPositionList = new List<Position>();
        List<Incident> FilteredIncidentList = new List<Incident>();
        List<EmployeeShift> FilteredEmployeeShiftList = new List<EmployeeShift>();

        DateTime StartDate;
        DateTime EndDate;
        private frmViewEmployee frmViewEmployee;
        private frmAddNewEmployee frmAddNewEmployee;
        int goodShiftCount = 0;
        int badShiftCount = 0;
        int averageShiftCount = 0;
        int totalShiftCount = 0;
        public frmOverview()
        {
            InitializeComponent();

        }
        private IEnumerable<EmployeeShift> QueryEmployeeShift(IEnumerable<EmployeeShift> employeeShift, EmployeeShiftQueryParameters parameters)
        {
            var query = employeeShift.AsQueryable(); // Convert to IQueryable to enable LINQ-to-Objects

            if (!string.IsNullOrEmpty(parameters.Position))
            {
                //query = query.Where(e => e.Position == parameters.Position);
            }

            if (parameters.StartDate.HasValue)
            {
                //query = query.Where(e => e.StartDate >= parameters.StartDate.Value);
            }

            // ... handle other parameters

            return query; // Return the filtered/sorted data
        }

        private void frmAddNewEmployee_FormClosed(object? sender, EventArgs e)
        {
            //foreach (Control control in pnlEmployeeDisplay.Controls)
            //{
            //    control.Visible = true;
            //}
        }
        private void refreshViewAllTime()
        {
            foreach (Employee employee in AllEmployeeList)
            {
                employee.AddIncidentsFromShifts();
                employee.UpdateOverallRating();
                AllIncidentList.AddRange(employee.Incidents);
            }
            AllEmployeeList = AllEmployeeList.OrderBy(emp => emp.FullName).ToList();
            var EmployeesByRating = AllEmployeeList.OrderByDescending(emp => emp.OverallRating).ToList();
            UIHelper.CreateEmployeeOverviewPanels(EmployeesByRating, flowEmployeeRankings, pnlEmployeeStats, lblMainWindowDescription, btnReset);
        }
        private void refreshView()
        {
            FilteredEmployeeList.Clear();
            FilteredEmployeeShiftList.Clear();

            HashSet<Employee> employeesInTimePeriod = new HashSet<Employee>();
            employeesInTimePeriod.Clear();

            foreach (var shift in AllShiftList)
            {
                if (shift.DateAsDateTime >= StartDate && shift.DateAsDateTime <= EndDate)
                {
                    foreach (var employeeShift in shift.EmployeeShifts)
                    {
                        employeesInTimePeriod.Add(employeeShift.Employee);
                        FilteredEmployeeShiftList.Add(employeeShift);
                        //employeeShift.Employee.EmployeeShifts.Add(employeeShift);                      

                    }
                }
            }

            FilteredEmployeeList = employeesInTimePeriod.ToList();
            foreach (var employeeShift in FilteredEmployeeShiftList)
            {
                // Find the corresponding Employee in FilteredEmployeeList
                var employee = FilteredEmployeeList.FirstOrDefault(e => e.ID == employeeShift.Employee.ID);
                if (employee != null)
                {
                    // Add the EmployeeShift to the Employee
                    employee.AddEmployeeShift(employeeShift);
                }
            }
            FilteredEmployeeList = FilteredEmployeeList.OrderByDescending(emp => emp.OverallRating).ToList();
            UIHelper.CreateEmployeeOverviewPanels(FilteredEmployeeList, flowEmployeeRankings, pnlEmployeeStats, lblMainWindowDescription, btnReset);
        }


        private void frmOverview_Load(object sender, EventArgs e)
        {
            frmViewEmployee = new frmViewEmployee();

            rdoViewEmployees.Checked = true;
            rdoHighestRated.Checked = true;
            rdoAllTime.Checked = true;
            cboViewType.SelectedIndex = 0;
            cboSortBy.SelectedIndex = 0;
            cboTimeFrame.SelectedIndex = 0;
            AllPositionList = SqliteDataAccess.LoadPositions();
            cboPositions.Items.Add("All Positions");
            foreach (Position position in AllPositionList)
            {
                cboPositions.Items.Add(position.Name);
                lbPositions.Items.Add(position.Name);
            }
            cboPositions.SelectedIndex = 0;
            AllEmployeeList.Clear();
            AllEmployeeList = SqliteDataAccess.TestLoadEmployees();
            AllShiftList.Clear();
            AllShiftList = SqliteDataAccess.LoadShifts();
            var rankedShifts = AllShiftList.OrderByDescending(shift => shift.AverageRating).Take(100).ToList();
            UIHelper.CreateShiftRankingPanel(rankedShifts, flowShiftRankings);
            //AUTO COMPLETE MAKING IT CRASH? Got stack overflow error when adding a shift
            //string[] names = AllEmployeeList.Select(e => e.FullName).ToArray();
            //AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            //autoComplete.AddRange(names);
            //txtBxEmployeeSearch.AutoCompleteCustomSource = autoComplete;
            //txtBxEmployeeSearch.Validated += (sender, e) =>
            //{
            //    // This code will run when the TextBox loses focus.
            //    // The user's input can be retrieved with textBox1.Text.
            //    string selectedName = txtBxEmployeeSearch.Text;

            //    // Find the employee with the matching name.
            //    Employee selectedEmployee = AllEmployeeList.FirstOrDefault(emp => emp.FullName == selectedName);

            //    if (selectedEmployee != null)
            //    {
            //        pnlEmployeeStats.Controls.Clear();

            //        frmViewEmployee viewEmployeeForm = new frmViewEmployee();
            //        viewEmployeeForm.TopLevel = false;
            //        viewEmployeeForm.FormBorderStyle = FormBorderStyle.None;
            //        viewEmployeeForm.Dock = DockStyle.Fill;
            //        pnlEmployeeStats.Controls.Add(viewEmployeeForm);
            //        viewEmployeeForm.Show();
            //    }
            //};
            //foreach (Employee employee in employeeList)
            //{
            //    employee.EmployeeShifts = SqliteDataAccess.LoadEmployeeShifts(employee);
            //}
            List<Employee> HighestGoodShiftRation = new List<Employee>();

            UIHelper.CreateEmployeePanels(AllEmployeeList, flowEmployeeDisplay, pnlEmployeeStats, lblMainWindowDescription, btnReset);
            UIHelper.CreateIncidentFrequencyPanels(AllIncidentList, flowMostFrequentIncidents);

            var EmployeesByGoodShiftRatio = AllEmployeeList.OrderByDescending(emp => emp.GoodShiftPercentage).Take(100).ToList();

            UIHelper.CreateEmployeeGoodShiftRatioPanels(EmployeesByGoodShiftRatio, flowGoodShiftRankings);
            UIHelper.CreatePositionOverviewPanels(flowPositions, AllPositionList);
            //UIHelper.ConfigureFlowLayoutPanel(flowGoodShiftRankings);
            //UIHelper.ConfigureFlowLayoutPanel(flowEmployeeDisplay);
            lbPositions.SelectedIndex = 0;
            //lbSortBy.SelectedIndex = 0;
            lbTimeFrame.SelectedIndex = 0;
            //lbViewType.SelectedIndex = 0;
            refreshViewAllTime();

        }





        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            //    //frmAddNewEmployee frmAddNewEmployee = new frmAddNewEmployee();
            //    frmAddNewEmployee = new frmAddNewEmployee();
            //    frmAddNewEmployee.FormClosed += frmAddNewEmployee_FormClosed;
            //    foreach (Control control in pnlEmployeeDisplay.Controls)
            //    {
            //        control.Visible = false;
            //    }
            //    frmAddNewEmployee.TopLevel = false;
            //    pnlEmployeeDisplay.Controls.Add(frmAddNewEmployee);
            //    frmAddNewEmployee.Show();

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

        //private void cboViewType_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cboViewType.SelectedIndex == 0)
        //    {
        //        flowEmployeeRankings.Controls.Clear();
        //        var EmployeesByRating = AllEmployeeList.OrderByDescending(emp => emp.OverallRating).Take(10).ToList();
        //        UIHelper.CreateEmployeeOverviewPanels(EmployeesByRating, flowEmployeeRankings, pnlEmployeeStats, lblMainWindowDescription, btnReset);
        //    }
        //    if (cboViewType.SelectedIndex == 1)
        //    {
        //        flowEmployeeRankings.Controls.Clear();
        //        List<EmployeeShift> employeeShifts = new List<EmployeeShift>();
        //        foreach (Employee employee in AllEmployeeList)
        //        {
        //            foreach (EmployeeShift employeeShift in employee.EmployeeShifts)
        //            {
        //                employeeShift.Employee = employee;
        //                employeeShifts.Add(employeeShift);
        //            }
        //        }
        //        var employeeShiftRanking = employeeShifts.OrderByDescending(employeeShift => employeeShift.ShiftRating).Take(15).ToList();
        //        foreach (EmployeeShift employeeShift in employeeShiftRanking)
        //        {
        //            UIHelper.CreateEmployeeShiftRankingPanel(employeeShift, flowEmployeeRankings);
        //        }

        //    }
        //}

        private void lbTimeFrame_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;


            int daysUntilMonday = ((int)DayOfWeek.Monday - (int)today.DayOfWeek + 7) % 7;
            DateTime thisWeekStart = today.AddDays(-daysUntilMonday);

        }

        private void rdoViewEmployees_CheckedChanged(object sender, EventArgs e)
        {
            rdoHighestRated.Checked = true;
            if (rdoViewEmployees.Checked)
            {
                flowEmployeeRankings.Controls.Clear();
                var EmployeesByRating = AllEmployeeList.OrderByDescending(emp => emp.OverallRating).Take(10).ToList();
                UIHelper.CreateEmployeeOverviewPanels(EmployeesByRating, flowEmployeeRankings, pnlEmployeeStats, lblMainWindowDescription, btnReset);
                rdoAlphabeticalOrChronological.Text = "Alphabetical";
            }
            if (rdoViewEmployeeShifts.Checked)
            {
                flowEmployeeRankings.Controls.Clear();
                List<EmployeeShift> employeeShifts = new List<EmployeeShift>();
                foreach (Employee employee in AllEmployeeList)
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
                rdoAlphabeticalOrChronological.Text = "Most Recent";
            }
        }



        private void rdoThisWeek_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThisWeek.Checked)
            {
                DateTime today = DateTime.Now;

                // Calculate the start of the week (Monday at 12:00 AM)
                int daysSinceMonday = (int)today.DayOfWeek - (int)DayOfWeek.Monday;
                if (daysSinceMonday < 0)
                {
                    daysSinceMonday += 7;
                }
                StartDate = today.AddDays(-daysSinceMonday).Date;

                // Calculate the end of the week (Sunday at 11:59 PM)
                int daysUntilSunday = ((int)DayOfWeek.Sunday - (int)today.DayOfWeek + 7) % 7;
                EndDate = today.AddDays(daysUntilSunday).Date.AddHours(23).AddMinutes(59).AddSeconds(59);


                refreshView();
            }
            lblTest1.Text = StartDate.ToString("d");
            lblTest2.Text = EndDate.ToString("d");

        }

        private void rdoLastWeek_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLastWeek.Checked)
            {
                DateTime todayMinusSeven = DateTime.Now.AddDays(-7);

                // Calculate the start of the week (Monday at 12:00 AM)
                int daysSinceMonday = (int)todayMinusSeven.DayOfWeek - (int)DayOfWeek.Monday;
                if (daysSinceMonday < 0)
                {
                    daysSinceMonday += 7;
                }
                StartDate = todayMinusSeven.AddDays(-daysSinceMonday).Date;

                // Calculate the end of the week (Sunday at 11:59 PM)
                int daysUntilSunday = ((int)DayOfWeek.Sunday - (int)todayMinusSeven.DayOfWeek + 7) % 7;
                EndDate = todayMinusSeven.AddDays(daysUntilSunday).Date.AddHours(23).AddMinutes(59).AddSeconds(59);


                refreshView();
            }
            lblTest1.Text = StartDate.ToString("d");
            lblTest2.Text = EndDate.ToString("d");
        }

        private void rdoThisMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThisMonth.Checked)
            {
                DateTime today = DateTime.Now;


                StartDate = new DateTime(today.Year, today.Month, 1);


                EndDate = StartDate.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(59);

                refreshView();
            }
            lblTest1.Text = StartDate.ToString("d");
            lblTest2.Text = EndDate.ToString("d");
        }

        private void rdoLastMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLastMonth.Checked)
            {
                DateTime todayLastMonth = DateTime.Now.AddMonths(-1);


                StartDate = new DateTime(todayLastMonth.Year, todayLastMonth.Month, 1);


                EndDate = StartDate.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(59);

                refreshView();
            }
            lblTest1.Text = StartDate.ToString("d");
            lblTest2.Text = EndDate.ToString("d");
        }

        private void rdoLastThreeMonths_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLastThreeMonths.Checked)
            {
                DateTime todayLastMonth = DateTime.Now.AddMonths(-3);


                StartDate = DateTime.Today.AddDays(-90);


                EndDate = DateTime.Today;

                refreshView();
            }
            lblTest1.Text = StartDate.ToString("d");
            lblTest2.Text = EndDate.ToString("d");
        }

        private void rdoCustomTime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoAllTime_CheckedChanged(object sender, EventArgs e)
        {
            FilteredEmployeeList.Clear();
            FilteredEmployeeList = AllEmployeeList;
            refreshViewAllTime();
        }


        //public IEnumerable<Data> FilterDataThisWeek(IEnumerable<Data> allData)
        //{
        //    // Get today's date


        //    // Filter data between this week's start and today
        //    return allData.Where(data => data.Date >= thisWeekStart && data.Date <= today);
        //}
    }
}
