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

        private void frmViewEmployee_Load(object sender, EventArgs e)
        {
            lblEmployeeName.Text = ThisEmployee.FullName;
            cboFirstEmployeeTime.DrawMode = DrawMode.OwnerDrawFixed;

            cboFirstEmployeeTime.SelectedIndex = 0;
            cboSeondEmployeeTime.SelectedIndex = 2;
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
