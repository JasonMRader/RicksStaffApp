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
    public partial class frmDatePicker : Form
    {
        private bool isDragging = false;
        private Point lastLocation;
        public DateTime DatePickerStartDate { get; private set; }
        public DateTime DatePickerEndDate { get; private set; }
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
        public frmDatePicker()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.DatePickerStartDate = calStart.SelectionStart;
            this.DatePickerEndDate = calEnd.SelectionStart;
            this.Close();
        }

        private void calStart_DateChanged(object sender, DateRangeEventArgs e)
        {
            calEnd.SelectionStart = calStart.SelectionStart;
        }

        private void calEnd_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void frmDatePicker_Load(object sender, EventArgs e)
        {

        }
    }
}
