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
        int goodShiftCount = 0;
        int badShiftCount = 0;
        int averageShiftCount = 0;
        int totalShiftCount = 0;
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
            (goodShiftCount, badShiftCount, averageShiftCount) = (0, 0, 0);
            totalShiftCount = employeeShifts.Count;
            foreach (EmployeeShift employeeShift in employeeShifts)
            {
                UIHelper.CreateEmployeeShiftOverviewPanel(employeeShift, flowEmployeeShifts);
                if (employeeShift.ShiftRating <= 5.5)
                {
                    badShiftCount++;
                }
                if (employeeShift.ShiftRating >= 6.5)
                {
                    goodShiftCount++;
                }
                else
                {
                    averageShiftCount++;
                }
            }
            lblTotalShifts.Text = totalShiftCount.ToString();
            lblGoodShifts.Text = goodShiftCount.ToString();
            lblAverageShifts.Text = averageShiftCount.ToString();
            lblPoorShifts.Text = badShiftCount.ToString();
            double goodPercentage = (Double)goodShiftCount / totalShiftCount;
            double averagePercentage = (Double)averageShiftCount / totalShiftCount;
            double badPercentage = (Double)badShiftCount / totalShiftCount;
            lblGoodShiftPercent.Text = goodPercentage.ToString("0.00" + "%");
            lblAverageShiftPercent.Text = averagePercentage.ToString("0.00" + "%");
            lblBadShiftPercent.Text = badPercentage.ToString("0.00" + "%");
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
