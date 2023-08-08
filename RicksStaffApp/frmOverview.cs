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

        private bool _isAM;
        private bool _isPM;
        private bool _isAMPM;

        public bool IsAM
        {
            get { return _isAM; }
            set
            {
                _isAM = value;
                if (value)
                {
                    IsPM = false;
                    IsAMPM = false;
                }
            }
        }

        public bool IsPM
        {
            get { return _isPM; }
            set
            {
                _isPM = value;
                if (value)
                {
                    IsAM = false;
                    IsAMPM = false;
                }
            }
        }

        public bool IsAMPM
        {
            get { return _isAMPM; }
            set
            {
                _isAMPM = value;
                if (value)
                {
                    IsAM = false;
                    IsPM = false;
                }
            }
        }


        DateTime StartDate;
        DateTime EndDate;

        bool isLoadScreen = true;

        private async Task UpdateAllLists()
        {
            AllPositionList = SqliteDataAccess.LoadPositions();
            AllEmployeeList.Clear();
            AllEmployeeList = SqliteDataAccess.TestLoadEmployees();
            AllShiftList.Clear();
            AllShiftList = SqliteDataAccess.LoadShifts();
            AllIncidentList.Clear();
            foreach (Employee employee in AllEmployeeList)
            {
                employee.AddIncidentsFromShifts();
                employee.UpdateOverallRating();
                AllIncidentList.AddRange(employee.Incidents);
            }
        }
        private static void CreateLoadingScreen(FlowLayoutPanel flowDisplay, Panel LoadScreen)
        {

            LoadScreen.Size = flowDisplay.Size;
            LoadScreen.BackColor = flowDisplay.BackColor;
            LoadScreen.Location = flowDisplay.Location;
            LoadScreen.Visible = true;


        }
        private static void RemoveLoadScreens(Panel LoadScreen, Panel LoadScreenTwo, Panel LoadScreenThree, Panel LoadScreenFour)
        {
            LoadScreen.Visible = false;
            LoadScreenTwo.Visible = false;
            LoadScreenThree.Visible = false;
            LoadScreenFour.Visible = false;
        }
        //private async static Task CreateEmployeeOverviewPanelsTest(List<Employee> employeeList, FlowLayoutPanel flowEmployeeDisplay, Panel parentPanel, Label lblMain, System.Windows.Forms.Button btnReset)
        //{
        //    // Clear existing panels
        //    flowEmployeeDisplay.SuspendLayout();
        //    flowEmployeeDisplay.Controls.Clear();
        //    List<Panel> panelsAdded = new List<Panel>();

        //    // Loop through employee list and create a panel for each employee
        //    foreach (Employee emp in employeeList)
        //    {
        //        emp.UpdateOverallRating();
        //        Panel empPanelContainer = UIHelper.CreatePanel(410, 40);
        //        empPanelContainer.Visible = false;
        //        empPanelContainer.Margin = new Padding(15, 7, 15, 0);


        //        FlowLayoutPanel empPanel = UIHelper.CreateFlowPanel(410, 40);
        //        empPanel.Margin = new Padding(1, 1, 1, 1);

        //        System.Windows.Forms.Button btnName = UIHelper.CreateButtonTemplate(170, 40, emp.FullName);
        //        btnName.Font = new Font("Arial", 12, FontStyle.Bold);
        //        btnName.Click += (sender, e) =>
        //        {
        //            foreach (Control control in parentPanel.Controls)
        //            {
        //                if (control is Form form)
        //                {
        //                    parentPanel.Controls.Remove(form);
        //                    form.Dispose();
        //                }
        //                else
        //                {
        //                    control.Visible = false;
        //                }


        //            }
        //            //parentPanel.Controls.Clear();
        //            lblMain.Text = emp.FullName;
        //            btnReset.Visible = true;
        //            frmViewEmployee viewEmployeeForm = new frmViewEmployee(emp);
        //            viewEmployeeForm.TopLevel = false;
        //            viewEmployeeForm.FormBorderStyle = FormBorderStyle.None;
        //            viewEmployeeForm.Dock = DockStyle.Fill;
        //            parentPanel.Controls.Add(viewEmployeeForm);
        //            viewEmployeeForm.Show();
        //        };

        //        empPanel.Controls.Add(btnName);
        //        // Create panels for employee positions

        //        PictureBox pbRating = UIHelper.CreateRatingPictureBox(160, 40, emp.OverallRating);
        //        //pbRating.BorderStyle = BorderStyle.Fixed3D;
        //        empPanel.Controls.Add(pbRating);

        //        empPanelContainer.Controls.Add(empPanel);

        //        Label lblRating = new Label();
        //        //lblRating.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        //        lblRating.Font = new Font("Arial", 12, FontStyle.Bold);
        //        lblRating.Margin = new Padding(0);
        //        lblRating.Location = new Point(410, 0);
        //        lblRating.Size = new Size(50, 40);
        //        lblRating.TextAlign = ContentAlignment.MiddleCenter;

        //        lblRating.Text = emp.OverallRating.ToString("F1");

        //        empPanel.Controls.Add(lblRating);

        //        //flowEmployeeDisplay.Controls.Add(empPanelContainer);
        //        panelsAdded.Add(empPanelContainer);
        //    }

        //    foreach (Panel panel in panelsAdded)
        //    {
        //        flowEmployeeDisplay.Controls.Add((Panel)panel);
        //        panel.Visible = true;
        //    }
        //    flowEmployeeDisplay.ResumeLayout();
        //}
        private async static Task<List<Panel>> CreateEmployeeOverviewPanelsTest(List<Employee> employeeList, FlowLayoutPanel flowEmployeeDisplay, Panel parentPanel, Label lblMain, System.Windows.Forms.Button btnReset)
        {

            flowEmployeeDisplay.Controls.Clear();
            List<Panel> panelsAdded = new List<Panel>();

            // Loop through employee list and create a panel for each employee
            foreach (Employee emp in employeeList)
            {
                emp.UpdateOverallRating();
                Panel empPanelContainer = UIHelper.CreatePanel(410, 40);

                empPanelContainer.Margin = new Padding(15, 7, 15, 0);
                empPanelContainer.Location = new Point(15, 7);


                FlowLayoutPanel empPanel = UIHelper.CreateFlowPanel(410, 40);
                empPanel.Margin = new Padding(1, 1, 1, 1);

                System.Windows.Forms.Button btnName = UIHelper.CreateButtonTemplate(170, 40, emp.FullName);
                btnName.Font = new Font("Arial", 12, FontStyle.Bold);
                btnName.Click += (sender, e) =>
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Form form)
                        {
                            parentPanel.Controls.Remove(form);
                            form.Dispose();
                        }
                        else
                        {
                            control.Visible = false;
                        }


                    }
                    //parentPanel.Controls.Clear();
                    lblMain.Text = emp.FullName;
                    btnReset.Visible = true;
                    frmViewEmployee viewEmployeeForm = new frmViewEmployee(emp);
                    viewEmployeeForm.TopLevel = false;
                    viewEmployeeForm.FormBorderStyle = FormBorderStyle.None;
                    viewEmployeeForm.Dock = DockStyle.Fill;
                    parentPanel.Controls.Add(viewEmployeeForm);
                    viewEmployeeForm.Show();
                };
                empPanel.Controls.Add(btnName);


                PictureBox pbRating = UIHelper.CreateRatingPictureBox(160, 40, emp.OverallRating);

                empPanel.Controls.Add(pbRating);

                empPanelContainer.Controls.Add(empPanel);

                Label lblRating = new Label();

                lblRating.Font = new Font("Arial", 12, FontStyle.Bold);
                lblRating.Margin = new Padding(0);
                lblRating.Location = new Point(410, 0);
                lblRating.Size = new Size(50, 40);
                lblRating.TextAlign = ContentAlignment.MiddleCenter;

                lblRating.Text = emp.OverallRating.ToString("F1");

                empPanel.Controls.Add(lblRating);


                panelsAdded.Add(empPanelContainer);
            }



            return panelsAdded;
        }

        private frmViewEmployee frmViewEmployee;

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
        private async Task RefreshDataAndView()
        {
            if (rdoViewEmployees.Checked)
            {
                await UpdateAndSortAllList();
            }
            if (rdoViewEmployeeShifts.Checked)
            {
                refreshAllEmployeeShiftList();
                await UpdateAndSortAllEmployeeShifts();
            }




        }
        private async Task UpdateAndSortAllList()
        {
            await UpdateAllLists();

            if (rdoHighestRated.Checked == true)
            {
                AllEmployeeList = AllEmployeeList.OrderByDescending(emp => emp.OverallRating).Take(100).ToList();
            }
            if (rdoLowestRated.Checked == true)
            {
                AllEmployeeList = AllEmployeeList.OrderBy(emp => emp.OverallRating).Take(100).ToList();
            }
            if (rdoAlphabeticalOrChronological.Checked == true)
            {
                AllEmployeeList = AllEmployeeList.OrderBy(emp => emp.FullName).Take(100).ToList();
            }

        }
        private async Task UpdateAndSortAllEmployeeShifts()
        {
            await UpdateAllLists();

            if (rdoHighestRated.Checked == true)
            {
                AllEmployeeShiftList = AllEmployeeShiftList.OrderByDescending(emp => emp.ShiftRating).Take(100).ToList();
            }
            if (rdoLowestRated.Checked == true)
            {
                AllEmployeeShiftList = AllEmployeeShiftList.OrderBy(emp => emp.ShiftRating).Take(100).ToList();
            }
            if (rdoAlphabeticalOrChronological.Checked == true)
            {
                AllEmployeeShiftList = AllEmployeeShiftList.OrderByDescending(emp => emp.Shift.DateAsDateTime).Take(100).ToList();
            }

        }
        
        private void UpdateFilteredListsForTimeFrame()
        {
            
            if (rdoAllTime.Checked)
            {
                FilteredEmployeeList =  new List<Employee>(AllEmployeeList);
                FilteredEmployeeShiftList = new List<EmployeeShift>(AllEmployeeShiftList);
                FilteredShiftList = new List<Shift>(AllShiftList);                
                FilteredPositionList = new List<Position>(AllPositionList);
                FilteredIncidentList = new List<Incident>(AllIncidentList);
              

            }
            else
            {
                HashSet<Employee> employeesInTimePeriod = new HashSet<Employee>();
                employeesInTimePeriod.Clear();

                foreach (var shift in AllShiftList)
                {
                    if (shift.DateAsDateTime >= StartDate && shift.DateAsDateTime <= EndDate)
                    {
                        FilteredShiftList.Add(shift);
                        foreach (var employeeShift in shift.EmployeeShifts)
                        {
                            employeesInTimePeriod.Add(employeeShift.Employee);
                            FilteredEmployeeShiftList.Add(employeeShift);
                            FilteredIncidentList.AddRange(employeeShift.Incidents);
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
                        employee.UpdateOverallRating();
                    }
                }
            }
        }
        private async void UpdateIncidentPanel()
        {
            List<Panel> IncidentPanelsToAdd = await UIHelper.CreateIncidentFrequencyPanels(FilteredIncidentList);
            foreach (var panel in IncidentPanelsToAdd)
            {
                flowMostFrequentIncidents.Controls.Add(panel);
            }
        }
        private void UpdateRatioPanels()
        {
            var EmployeesByGoodShiftRatio = FilteredEmployeeList.OrderByDescending(emp => emp.GoodShiftPercentage).Take(100).ToList();
            UIHelper.CreateEmployeeGoodShiftRatioPanels(EmployeesByGoodShiftRatio, flowGoodShiftRankings);
        }    
        private void UpdateShiftRankPanel()
        {
            var rankedShifts = FilteredShiftList.OrderByDescending(shift => shift.AverageRating).Take(100).ToList();
            UIHelper.CreateShiftRankingPanel(rankedShifts, flowShiftRankings);
        }
        private void SortFilteredEmployeeList()
        {
            if (rdoHighestRated.Checked == true)
            {
                FilteredEmployeeList = FilteredEmployeeList.OrderByDescending(emp => emp.OverallRating).ToList();
            }
            if (rdoLowestRated.Checked == true)
            {
                FilteredEmployeeList = FilteredEmployeeList.OrderBy(emp => emp.OverallRating).ToList();
            }
            if (rdoAlphabeticalOrChronological.Checked == true)
            {
                FilteredEmployeeList = FilteredEmployeeList.OrderBy(emp => emp.FullName).ToList();
            }
            UIHelper.CreateEmployeeOverviewPanels(FilteredEmployeeList, flowEmployeeRankings, pnlEmployeeStats, lblMainWindowDescription, btnReset);
        }
        private void SortFilteredEmployeeShiftList()
        {
            flowEmployeeRankings.Controls.Clear();
            List<EmployeeShift> employeeShifts = new List<EmployeeShift>();
            foreach (Employee employee in FilteredEmployeeList)
            {
                foreach (EmployeeShift employeeShift in employee.EmployeeShifts)
                {
                    employeeShift.Employee = employee;
                    employeeShifts.Add(employeeShift);
                }
            }
            var employeeShiftRanking = SortEmployeeShifts(FilteredEmployeeShiftList);
            foreach (EmployeeShift employeeShift in employeeShiftRanking)
            {
                UIHelper.CreateEmployeeShiftRankingPanel(employeeShift, flowEmployeeRankings);
            }
        }
            
        private async Task refreshViewFiltered()
        {
            FilteredEmployeeList.Clear();
            FilteredEmployeeShiftList.Clear();
            FilteredIncidentList.Clear();
            FilteredShiftList.Clear();
            flowMostFrequentIncidents.Controls.Clear();
            UpdateFilteredListsForTimeFrame();
            
            UpdateIncidentPanel();
            
            UpdateRatioPanels();
            UpdateShiftRankPanel();

            
            if (rdoViewEmployees.Checked == true)
            {
                SortFilteredEmployeeList();
            }
            if (!rdoViewEmployees.Checked)
            {
                SortFilteredEmployeeShiftList();
                rdoAlphabeticalOrChronological.Text = "Most Recent";
            }

        }
        private List<EmployeeShift> SortEmployeeShifts(List<EmployeeShift> employeeShifts)
        {
            List<EmployeeShift> SortedEmployeeShifts = new List<EmployeeShift>();
            if (rdoHighestRated.Checked == true)
            {
                SortedEmployeeShifts = employeeShifts.OrderByDescending(emp => emp.ShiftRating).Take(100).ToList();
            }
            if (rdoLowestRated.Checked == true)
            {
                SortedEmployeeShifts = employeeShifts.OrderBy(emp => emp.ShiftRating).Take(100).ToList();
            }
            if (rdoAlphabeticalOrChronological.Checked == true)
            {
                SortedEmployeeShifts = employeeShifts.OrderByDescending(emp => emp.Shift.DateAsDateTime).Take(100).ToList();
            }
            return SortedEmployeeShifts;

        }


        private async void frmOverview_Load(object sender, EventArgs e)
        {
            //CreateLoadingScreen(flowEmployeeRankings, pnlEmployeeLoadScreen);
            //CreateLoadingScreen(flowMostFrequentIncidents, pnlIncidentLoadScreen);
            //CreateLoadingScreen(flowShiftRankings, pnlShiftLoadScreen);
            //CreateLoadingScreen(flowGoodShiftRankings, pnlRatioLoadScreen);


            frmViewEmployee = new frmViewEmployee();

            rdoViewEmployees.Checked = true;
            rdoHighestRated.Checked = true;
            rdoAllTime.Checked = true;
            //cboViewType.SelectedIndex = 0;
            //cboSortBy.SelectedIndex = 0;
            //cboTimeFrame.SelectedIndex = 0;

            cboPositions.Items.Add("All Positions");
            foreach (Position position in AllPositionList)
            {
                cboPositions.Items.Add(position.Name);
                lbPositions.Items.Add(position.Name);
            }
            cboPositions.SelectedIndex = 0;
            //***************************THIS ONE CHANGED
            //refreshViewAllTime();
            
            await UpdateAndSortAllList();
            
            
            refreshAllEmployeeShiftList();
            await UpdateAndSortAllEmployeeShifts();
            refreshViewFiltered();
            UIHelper.CreatePositionOverviewPanels(flowPositions, AllPositionList);





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

            //RemoveLoadScreens(pnlEmployeeLoadScreen, pnlIncidentLoadScreen, pnlRatioLoadScreen, pnlShiftLoadScreen);
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
                refreshViewFiltered();
                //if (rdoAllTime.Checked)
                //{
                //    //refreshViewAllTime();
                //    refreshViewFiltered();
                //}
                //else
                //{
                //    refreshViewFiltered();
                //}

                //flowEmployeeRankings.Controls.Clear();
                //var EmployeesByRating = AllEmployeeList.OrderByDescending(emp => emp.OverallRating).ToList();
                //UIHelper.CreateEmployeeOverviewPanels(EmployeesByRating, flowEmployeeRankings, pnlEmployeeStats, lblMainWindowDescription, btnReset);
                rdoAlphabeticalOrChronological.Text = "Alphabetical";
            }
            if (rdoViewEmployeeShifts.Checked)
            {
                //flowEmployeeRankings.Controls.Clear();
                refreshAllEmployeeShiftList();
                refreshViewFiltered();
                //if (rdoAllTime.Checked)
                //{
                //    refreshViewAllTime();
                //}
                //else
                //{
                //    refreshViewFiltered();
                //}


                //var employeeShiftRanking = AllEmployeeShiftList.OrderByDescending(employeeShift => employeeShift.ShiftRating).Take(15).ToList();
                //foreach (EmployeeShift employeeShift in employeeShiftRanking)
                //{
                //    UIHelper.CreateEmployeeShiftRankingPanel(employeeShift, flowEmployeeRankings);
                //}
                rdoAlphabeticalOrChronological.Text = "Most Recent";
            }
        }
        private void refreshAllEmployeeShiftList()
        {
            foreach (Employee employee in AllEmployeeList)
            {
                foreach (EmployeeShift employeeShift in employee.EmployeeShifts)
                {
                    employeeShift.Employee = employee;
                    AllEmployeeShiftList.Add(employeeShift);
                }
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


                refreshViewFiltered();
            }


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


                refreshViewFiltered();
            }

        }

        private void rdoThisMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThisMonth.Checked)
            {
                DateTime today = DateTime.Now;


                StartDate = new DateTime(today.Year, today.Month, 1);


                EndDate = StartDate.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(59);

                refreshViewFiltered();
            }

        }

        private void rdoLastMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLastMonth.Checked)
            {
                DateTime todayLastMonth = DateTime.Now.AddMonths(-1);


                StartDate = new DateTime(todayLastMonth.Year, todayLastMonth.Month, 1);


                EndDate = StartDate.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(59);

                refreshViewFiltered();
            }


        }

        private void rdoLastThreeMonths_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLastThreeMonths.Checked)
            {
                DateTime todayLastMonth = DateTime.Now.AddMonths(-3);


                StartDate = DateTime.Today.AddDays(-90);


                EndDate = DateTime.Today;

                refreshViewFiltered();
            }

        }

        private void rdoCustomTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCustomTime.Checked)
            {

                //using (var datePickerForm = new frmDatePicker())
                //{
                //    var result = datePickerForm.ShowDialog();
                //    if (result == DialogResult.OK)
                //    {
                //        StartDate = datePickerForm.DatePickerStartDate;
                //        EndDate = datePickerForm.DatePickerEndDate;
                //    }
                //    refreshView();
                //    //lblTest1.Text = StartDate.ToString("d");
                //    //lblTest2.Text = EndDate.ToString("d");

                //}
            }
            else
            {
                rdoCustomTime.Text = "Custom";
            }

        }

        private void rdoAllTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAllTime.Checked)
            {
                //pnlShiftLoadScreen.Visible = true;
                //pnlEmployeeLoadScreen.Visible = true;
                //pnlIncidentLoadScreen.Visible = true;
                //pnlRatioLoadScreen.Visible = true;
                //FilteredEmployeeList.Clear();
                //FilteredEmployeeList = AllEmployeeList;
                //refreshViewAllTime();
                refreshViewFiltered();
                //RemoveLoadScreens(pnlEmployeeLoadScreen, pnlIncidentLoadScreen, pnlRatioLoadScreen, pnlShiftLoadScreen);

            }


        }

        private void rdoHighestRated_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHighestRated.Checked)
            {
                refreshViewFiltered();
            }


        }

        private void rdoLowestRated_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLowestRated.Checked)
            {
                refreshViewFiltered();
            }
            //if (rdoAllTime.Checked == true)
            //{
            //    refreshViewAllTime();
                
            //}
            //else
            //{
            //    refreshViewFiltered();
            //}
        }

        private void rdoAlphabeticalOrChronological_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAlphabeticalOrChronological.Checked)
            {
                refreshViewFiltered();
            }
            //if (rdoAllTime.Checked == true)
            //{
            //    refreshViewAllTime();

            //}
            //else
            //{
            //    refreshViewFiltered();
            //}
        }

        private void rdoCustomTimeMouseClick(object sender, MouseEventArgs e)
        {
            if (rdoCustomTime.Checked)
            {
                using (var datePickerForm = new frmDatePicker())
                {
                    var result = datePickerForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        StartDate = datePickerForm.DatePickerStartDate;
                        EndDate = datePickerForm.DatePickerEndDate;
                    }
                    refreshViewFiltered();
                    //lblTest1.Text = StartDate.ToString("d");
                    //lblTest2.Text = EndDate.ToString("d");
                    rdoCustomTime.Text = StartDate.ToString("d") + " - " + EndDate.ToString("d");
                }
            }
            else
            {
                //rdoCustomTime.Text = "Custom";
            }
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

        private void rdoViewEmployeeShifts_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoAMPM_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAMPM.Checked == true)
            {
                IsAMPM = true;
            }
        }

        private void rdoAM_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAM.Checked == true)
            {
                IsAM = true;
            }
        }

        private void rdoPM_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPM.Checked == true)
            {
                IsPM = true;
            }

        }


        //public IEnumerable<Data> FilterDataThisWeek(IEnumerable<Data> allData)
        //{
        //    // Get today's date


        //    // Filter data between this week's start and today
        //    return allData.Where(data => data.Date >= thisWeekStart && data.Date <= today);
        //}
        //private async void refreshViewAllTime()
        //{
        //    flowEmployeeRankings.Controls.Clear();

        //    if (rdoViewEmployees.Checked)
        //    {

        //        flowMostFrequentIncidents.Controls.Clear();
        //        flowShiftRankings.Controls.Clear();
        //        flowGoodShiftRankings.Controls.Clear();


        //        await RefreshDataAndView();

        //        List<Panel> EmployeePanelsToAdd = await CreateEmployeeOverviewPanelsTest(AllEmployeeList, flowEmployeeRankings, pnlEmployeeStats, lblMainWindowDescription, btnReset);
        //        List<Panel> IncidentPanelsToAdd = await UIHelper.CreateIncidentFrequencyPanels(AllIncidentList);
        //        var EmployeesByGoodShiftRatio = AllEmployeeList.OrderByDescending(emp => emp.GoodShiftPercentage).Take(100).ToList();
        //        var rankedShifts = AllShiftList.OrderByDescending(shift => shift.AverageRating).Take(100).ToList();
        //        List<Panel> RatioPanelsToAdd = await UIHelper.CreateEmployeeGoodShiftRatioPanelsAsync(EmployeesByGoodShiftRatio);
        //        List<Panel> ShiftRankingPanelsToAdd = await UIHelper.CreateShiftRankingPanelAsync(rankedShifts);

        //        foreach (var panel in EmployeePanelsToAdd)
        //        {
        //            flowEmployeeRankings.Controls.Add(panel);
        //        }

        //        foreach (var panel in IncidentPanelsToAdd)
        //        {
        //            flowMostFrequentIncidents.Controls.Add(panel);
        //        }
        //        foreach (var panel in RatioPanelsToAdd)
        //        {
        //            flowGoodShiftRankings.Controls.Add(panel);
        //        }
        //        foreach (var panel in ShiftRankingPanelsToAdd)
        //        {
        //            flowShiftRankings.Controls.Add(panel);
        //        }


        //    }
        //    if (rdoViewEmployeeShifts.Checked)
        //    {
        //        List<EmployeeShift> employeeShifts = new List<EmployeeShift>();
        //        await RefreshDataAndView();
        //        foreach (Employee employee in AllEmployeeList)
        //        {
        //            foreach (EmployeeShift employeeShift in employee.EmployeeShifts)
        //            {
        //                employeeShift.Employee = employee;
        //                employeeShifts.Add(employeeShift);
        //            }
        //        }
        //        //var employeeShiftRanking = employeeShifts.OrderByDescending(employeeShift => employeeShift.ShiftRating).Take(15).ToList();
        //        foreach (EmployeeShift employeeShift in AllEmployeeShiftList)
        //        {
        //            UIHelper.CreateEmployeeShiftRankingPanel(employeeShift, flowEmployeeRankings);
        //        }
        //        rdoAlphabeticalOrChronological.Text = "Most Recent";
        //    }



        //}
    }

}
