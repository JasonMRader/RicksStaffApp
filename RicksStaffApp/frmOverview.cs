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
        private frmAddNewEmployee frmAddNewEmployee;
        public frmOverview()
        {
            InitializeComponent();

        }

        private void frmAddNewEmployee_FormClosed(object? sender, EventArgs e)
        {
            foreach (Control control in pnlEmployeeDisplay.Controls)
            {
                control.Visible = true;
            }
        }

        private void frmOverview_Load(object sender, EventArgs e)
        {

            employeeList.Clear();
            employeeList = SqliteDataAccess.LoadEmployees();
            //foreach (Employee employee in employeeList)
            //{
            //    employee.EmployeeShifts = SqliteDataAccess.LoadEmployeeShifts(employee);
            //}


            UIHelper.CreateEmployeePanels(employeeList, flowEmployeeDisplay, pnlEmployeeStats);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            //frmAddNewEmployee frmAddNewEmployee = new frmAddNewEmployee();
            frmAddNewEmployee = new frmAddNewEmployee();
            frmAddNewEmployee.FormClosed += frmAddNewEmployee_FormClosed;
            foreach (Control control in pnlEmployeeDisplay.Controls)
            {
                control.Visible = false;
            }
            frmAddNewEmployee.TopLevel = false;
            pnlEmployeeDisplay.Controls.Add(frmAddNewEmployee);
            frmAddNewEmployee.Show();

        }
    }
}
