using Staff_Performance_Class_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RicksStaffApp
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }
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
        private void btnLoadEmployees_Click(object sender, EventArgs e)
        {
            //AllEmployeeList = SqliteDataAccess.TestLoadEmployees();
            RefreshDataAndView();
        }

        private void btnLoadShifts_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadEmployeeShifts_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadIncidents_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadActivities_Click(object sender, EventArgs e)
        {

        }
        //private async static Task<List<Panel>> CreateEmployeeOverviewPanelsTest(List<Employee> employeeList, FlowLayoutPanel flowEmployeeDisplay, Panel parentPanel, Label lblMain, System.Windows.Forms.Button btnReset)
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
        //        //empPanelContainer.Visible = false;
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

        //    //foreach (Panel panel in panelsAdded)
        //    //{
        //    //    //flowEmployeeDisplay.Controls.Add((Panel)panel);
        //    //    panel.Visible = true;
        //    //}
        //    flowEmployeeDisplay.ResumeLayout();
        //    return panelsAdded;
        //}
        private async static Task<List<Panel>> CreateEmployeeOverviewPanelsTest(List<Employee> employeeList)
        {
            // Clear existing panels
            
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
        private async Task RefreshDataAndView()
        {
            await GetData();
            List<Panel> panelsAdded = new List<Panel>();
            panelsAdded = await CreateEmployeeOverviewPanelsTest(AllEmployeeList);
            //UIHelper.CreateIncidentFrequencyPanels(AllIncidentList, flowMostFrequentIncidents);
            foreach (Panel panel in panelsAdded)
            {
                flowEmployeeRankingsTest.Controls.Add(panel);
                
            }
            
            var EmployeesByGoodShiftRatio = AllEmployeeList.OrderByDescending(emp => emp.GoodShiftPercentage).Take(100).ToList();
            var rankedShifts = AllShiftList.OrderByDescending(shift => shift.AverageRating).Take(100).ToList();

            //UIHelper.CreateEmployeeGoodShiftRatioPanels(EmployeesByGoodShiftRatio, flowGoodShiftRankings);
            //UIHelper.CreateShiftRankingPanel(rankedShifts, flowShiftRankings);
        }
        private async Task GetData()
        {
            await UpdateAllLists();



        }
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
        private async void refreshViewAllTime()
        {

            await RefreshDataAndView();

            //await CreateEmployeeOverviewPanelsTest(AllEmployeeList, flowEmployeeRankingsTest, pnlEmployeeStatsTest, lblMainWindowDescriptionTest, btnResetTest);


        }
    }

}
