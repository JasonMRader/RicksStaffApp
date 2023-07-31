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
        private void GetEmployeeShiftGoodBadDistribution(List<EmployeeShift> employeeShifts)
        {

            foreach (EmployeeShift employeeShift in employeeShifts)
            {
                UIHelper.CreateEmployeeShiftOverviewPanel(employeeShift, flowEmployeeShifts);
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

            //lbAllPositions.DisplayMember = Name;
            //lbAllPositions.ValueMember = Name;
            //lblEmployeeName.Text = ThisEmployee.FullName;
            SqliteDataAccess.LoadEmployeeShifts(ThisEmployee);
            ThisEmployee.AddIncidentsFromShifts();

            GetEmployeeShiftGoodBadDistribution(ThisEmployee.EmployeeShifts);

            picBoxEmployeeRating.Image = UIHelper.GetStars(ThisEmployee.OverallRating);
            lblRating.Text = ThisEmployee.OverallRating.ToString("0.00");

            loadIncidentPanels();

            UIHelper.CreatePositionsForEmployee(flowEmployeePositions, ThisEmployee.Positions);
            //foreach (Position position in AllPositions)
            //{
            //    lbAllPositions.Items.Add(position);
            //}
            foreach (Position position in AllPositions)
            {
                if (!ThisEmployee.Positions.Any(p => p.ID == position.ID))
                {
                    lbAllPositions.Items.Add(position);
                }
            }
            //lbAllPositions.SelectedIndexChanged -= lbAllPositions_SelectedIndexChanged;
            //BindingList<Position> positionList = new BindingList<Position>(AllPositions);

            //lbAllPositions.DataSource = positionList;
            //lbAllPositions.SelectedIndexChanged += lbAllPositions_SelectedIndexChanged;
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
