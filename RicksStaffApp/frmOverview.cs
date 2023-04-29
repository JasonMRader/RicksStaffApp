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
    public partial class frmOverview : Form
    {

        List<Employee> employeeList = new List<Employee>();
        public frmOverview()
        {
            InitializeComponent();
        }
        private void frmOverview_Load(object sender, EventArgs e)
        {
            //DateTimeOffset dateOnly = new DateTimeOffset(2023, 3, 29, 0, 0, 0, TimeSpan.Zero);
            //long unixTime = dateOnly.ToUnixTimeSeconds();
            employeeList.Clear();
            employeeList = SqliteDataAccess.LoadEmployees();
            //unixTime = 1659081600;
            //dateOnly = DateTimeOffset.FromUnixTimeSeconds(unixTime).Date;

            UIHelper.CreateEmployeePanels(employeeList, flowEmployeeDisplay);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddNewEmployee frmAddNewEmployee = new frmAddNewEmployee();
            frmAddNewEmployee.ShowDialog();
        }
    }
}
