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
        List<Employee> employees = new List<Employee>();
        List<Shift> shifts = new List<Shift>();
        List<EmployeeShift> employeeShifts = new List<EmployeeShift>();
        List<Incident> incidents = new List<Incident>();
        List<Activity> activitys = new List<Activity>();
        private void btnLoadEmployees_Click(object sender, EventArgs e)
        {
            employees = SqliteDataAccess.TestLoadEmployees();
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
    }
}
