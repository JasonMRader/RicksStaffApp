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

            GetEmployeeShiftGoodBadDistribution(ThisEmployee.EmployeeShifts);

            picBoxEmployeeRating.Image = UIHelper.GetStars(ThisEmployee.OverallRating);
            lblRating.Text = ThisEmployee.OverallRating.ToString("0.00");
            cboSeondEmployeeTime.SelectedIndex = 0;
            UIHelper.CreateIncidentFrequencyPanels(ThisEmployee.Incidents, flowFrequentIncidents);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
