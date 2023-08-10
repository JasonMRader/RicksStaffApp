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
    public partial class frmViewEmployee : Form
    {

        Employee ThisEmployee = new Employee();
        List<Position> AllPositions = new List<Position>();
        public frmViewEmployee(Employee employee)
        {
            ThisEmployee = employee;
            InitializeComponent();
        }
        public frmViewEmployee()
        {
            InitializeComponent();
        }
        private static void CreateEmployeeShiftOverviewPanel(EmployeeShift employeeShift, FlowLayoutPanel flowLayoutPanel)
        {


            employeeShift.UpdateShiftRating();
            FlowLayoutPanel empShiftContainer = UIHelper.CreateFlowPanel(470, 30);

            empShiftContainer.MinimumSize = new Size(470, 30);
            empShiftContainer.MaximumSize = new Size(470, 1000);
            empShiftContainer.Margin = new Padding(15, 7, 15, 0);

            PictureBox pbPosition = UIHelper.CreatePositionPictureBox(30, 30, employeeShift.Position);
            empShiftContainer.Controls.Add(pbPosition);

            Label lblWeekday = UIHelper.CreateLabel(50, 30, employeeShift.Shift.DateAsDateTime.ToString("ddd"));
            lblWeekday.Font = UIHelper.WeekDayDisplay;
            empShiftContainer.Controls.Add(lblWeekday);

            Label lblAmPm = UIHelper.CreateLabel(30, 30, employeeShift.AmPmString);
            empShiftContainer.Controls.Add((Label)lblAmPm);

            Label lblName = UIHelper.CreateLabel(100, 30, employeeShift.Shift.DateAsDateTime.ToOrdinalString());
            lblName.Font = UIHelper.DateDisplay;
            empShiftContainer.Controls.Add(lblName);

            //Label lblPos = CreateLabel(60, 30, employeeShift.Position.Name);
            //empShiftContainer.Controls.Add(lblPos);
            FlowLayoutPanel incidentContainer = UIHelper.CreateFlowPanel(470, 30);
            System.Windows.Forms.Button btnIncidents = UIHelper.CreateButtonTemplate(100, 30, employeeShift.Incidents.Count.ToString() + " Incidents");
            btnIncidents.Margin = new Padding(10, 0, 0, 0);
            bool btnClicked = false;
            btnIncidents.Font = UIHelper.ButtonDisplay;
            btnIncidents.Click += (sender, e) =>
            {
                btnClicked = !btnClicked;

                if (btnClicked == true)
                {
                    UIHelper.CreateIncidentPanels(employeeShift.Incidents, incidentContainer);
                    empShiftContainer.Controls.Add(incidentContainer);
                }
                else
                {
                    incidentContainer.Controls.Clear();
                    empShiftContainer.Controls.Remove(incidentContainer);
                }
            };
            empShiftContainer.Controls.Add(btnIncidents);


            PictureBox pbRating = UIHelper.CreateRatingPictureBox(90, 30, employeeShift.ShiftRating);
            pbRating.Margin = new Padding(10, 0, 0, 0);
            empShiftContainer.Controls.Add(pbRating);




            Label lblShiftRating = UIHelper.CreateLabel(40, 30, employeeShift.ShiftRating.ToString());
            lblShiftRating.Margin = new Padding(5, 0, 0, 0);
            lblShiftRating.Font = UIHelper.RatingDisplay;
            empShiftContainer.Controls.Add(lblShiftRating);

            ////Button btnAddIncidents = CreateButtonTemplate(65, 30, "Add/Edit");
            ////btnAddIncidents.Click += (sender, e) =>
            ////{
            ////    secondPanel.Controls.Clear();
            ////    frmServerShift frmServerShift = new frmServerShift();
            ////    frmServerShift.EmployeeShiftToEdit = employeeShift;
            ////    frmServerShift.TopLevel = false;
            ////    secondPanel.Controls.Add(frmServerShift);
            ////    frmServerShift.Show();
            ////};
            //empShiftContainer.Controls.Add(btnAddIncidents);

            flowLayoutPanel.Controls.Add(empShiftContainer);


        }
        private void GetEmployeeShiftGoodBadDistribution(List<EmployeeShift> employeeShifts)
        {

            foreach (EmployeeShift employeeShift in employeeShifts)
            {
                CreateEmployeeShiftOverviewPanel(employeeShift, flowEmployeeShifts);
            }
            lblTotalShifts.Text = employeeShifts.Count.ToString();

            lblGoodShifts.Text = ThisEmployee.TotalGoodShifts.ToString();
            lblAverageShifts.Text = ThisEmployee.TotalAverageShifts.ToString();
            lblPoorShifts.Text = ThisEmployee.TotalBadShifts.ToString();
            lblGoodShiftPercent.Text = ThisEmployee.GoodShiftPercentage.ToString("0.00" + "%");
            lblAverageShiftPercent.Text = ThisEmployee.AverageShiftPercentage.ToString("0.00" + "%");
            lblBadShiftPercent.Text = ThisEmployee.BadShiftPercentage.ToString("0.00" + "%");
        }
        private void frmViewEmployee_Load(object sender, EventArgs e)
        {
            AllPositions = SqliteDataAccess.LoadPositions();

            
            SqliteDataAccess.LoadEmployeeShifts(ThisEmployee);
            ThisEmployee.AddIncidentsFromShifts();

            GetEmployeeShiftGoodBadDistribution(ThisEmployee.EmployeeShifts);

            picBoxEmployeeRating.Image = UIHelper.GetStars(ThisEmployee.OverallRating);
            lblRating.Text = ThisEmployee.OverallRating.ToString("0.00");

            loadIncidentPanels();

            UIHelper.CreatePositionsForEmployee(flowEmployeePositions, ThisEmployee.Positions);
            
            foreach (Position position in AllPositions)
            {
                if (!ThisEmployee.Positions.Any(p => p.ID == position.ID))
                {
                    lbAllPositions.Items.Add(position);
                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async Task loadIncidentPanels()
        {
            List<Panel> employeeIncidentPanels = await UIHelper.CreateIncidentFrequencyPanels(ThisEmployee.Incidents);
            foreach (Panel panel in employeeIncidentPanels)
            {
                flowFrequentIncidents.Controls.Add(panel);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            //foreach (Position p in AllPositions)
            //{
            //    lbAllPositions.Items.Add(p.Name);


            //}
            if (lbAllPositions.Visible == false)
            {
                lbAllPositions.Enabled = true;
                lbAllPositions.Visible = true;
                btnAddPosition.Text = "Cancel";
            }
            else
            {
                lbAllPositions.Enabled = false;
                lbAllPositions.Visible = false;
                btnAddPosition.Text = "Add Position";
            }

        }

        private void lbAllPositions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Add " + lbAllPositions.SelectedIndex + " to " + ThisEmployee.FullName + "'s Positions?");
            Position selectedPosition = (Position)lbAllPositions.SelectedItem;
            DialogResult result = MessageBox.Show("Add " + selectedPosition.Name + " to " + ThisEmployee.FullName + "'s Positions?", "Add Position", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                ThisEmployee.Positions.Add(selectedPosition);
                SqliteDataAccess.UpdateEmployee(ThisEmployee);




                lbAllPositions.Visible = false;
                //lbAllPositions.Items.Clear();

            }
            if (result == DialogResult.No)
            {
                lbAllPositions.Visible = false;
                //lbAllPositions.Items.Clear();
            }
        }
    }
}
