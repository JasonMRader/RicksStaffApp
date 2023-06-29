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
            //lblEmployeeName.Text = ThisEmployee.FullName;
            SqliteDataAccess.LoadEmployeeShifts(ThisEmployee);
            AllPositions = SqliteDataAccess.LoadPositions();

            GetEmployeeShiftGoodBadDistribution(ThisEmployee.EmployeeShifts);

            picBoxEmployeeRating.Image = UIHelper.GetStars(ThisEmployee.OverallRating);
            lblRating.Text = ThisEmployee.OverallRating.ToString("0.00");

            UIHelper.CreateIncidentFrequencyPanels(ThisEmployee.Incidents, flowFrequentIncidents);
            UIHelper.CreatePositionsForEmployee(flowEmployeePositions, ThisEmployee.Positions);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            foreach (Position p in AllPositions)
            {
                lbAllPositions.Items.Add(p.Name);
            }
            lbAllPositions.Visible = true;
        }

        private void lbAllPositions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Add " + lbAllPositions.SelectedIndex + " to " + ThisEmployee.FullName + "'s Positions?");
            DialogResult result = MessageBox.Show("Add " + lbAllPositions.SelectedItem + " to " + ThisEmployee.FullName + "'s Positions?","Add Position", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Delete employee from database
                SqliteDataAccess.UpdateEmployee(ThisEmployee);

                // Remove employee from list
                //employeeList.Remove(emp);

                // Update UI
                lbAllPositions.Visible = false;
                //CreateEmployeePanels();
            }
            if (result == DialogResult.No) 
            {
                lbAllPositions.Visible = false;
            }
        }
    }
}
