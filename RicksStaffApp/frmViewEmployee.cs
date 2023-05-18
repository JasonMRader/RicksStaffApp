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
        public frmViewEmployee(Employee employee)
        {
            ThisEmployee = employee;
            InitializeComponent();
        }
        public frmViewEmployee()
        {
            InitializeComponent();
        }

        private void frmViewEmployee_Load(object sender, EventArgs e)
        {

            lblEmployeeName.Text = ThisEmployee.FullName;
            SqliteDataAccess.LoadEmployeeShifts(ThisEmployee);
            foreach (EmployeeShift employeeShift in ThisEmployee.EmployeeShifts)
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
            lblGoodShifts.Text = goodShiftCount.ToString();
            lblAverageShifts.Text = averageShiftCount.ToString();
            lblPoorShifts.Text = badShiftCount.ToString();
            picBoxEmployeeRating.Image = UIHelper.GetStars(ThisEmployee.OverallRating);
            lblRating.Text = ThisEmployee.OverallRating.ToString();
            cboSeondEmployeeTime.SelectedIndex = 0;
            //UIHelper.CreateSingleEmployeeShiftPanel(flowTest, ThisEmployee.EmployeeShifts);


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
