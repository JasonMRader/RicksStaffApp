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
        private bool isDragging = false;
        private Point lastLocation;


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
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
            foreach(EmployeeShift es in ThisEmployee.EmployeeShifts)
            {
                MessageBox.Show(es.PositionID.ToString());
            }



            cboFirstEmployeeTime.SelectedIndex = 0;
            cboSeondEmployeeTime.SelectedIndex = 2;


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
