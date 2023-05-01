using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RicksStaffApp
{
    public partial class frmNewShift : Form
    {
        List<Shift> shifts = new List<Shift>();
        public frmNewShift()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmServerShift frmServerShift = new frmServerShift();
            frmServerShift.ShowDialog();
        }





        private void frmNewShift_Load(object sender, EventArgs e)
        {
            shifts = SqliteDataAccess.LoadShifts();
            //UIHelper.CreateShiftPanels(shifts, flowEmployeeShiftDisplay);
            UIHelper.CreateEmployeeShiftPanels(shifts, flowEmployeeShiftDisplay, DateOnly.FromDateTime(dtpShiftDate.Value), pnlNewShiftDisplay);
        }



        private void dtpShiftDate_ValueChanged(object sender, EventArgs e)
        {
            //List <EmployeeShift> employeeShifts = new List <EmployeeShift>();
            UIHelper.CreateEmployeeShiftPanels(shifts, flowEmployeeShiftDisplay, DateOnly.FromDateTime(dtpShiftDate.Value), pnlNewShiftDisplay);


        }

        private void btnGetExcelEmployees_Click(object sender, EventArgs e)
        {
            frmExcelDownload frmExcelDownload = new frmExcelDownload();
            pnlNewShiftDisplay.Controls.Clear();
            frmExcelDownload.TopLevel = false;
            pnlNewShiftDisplay.Controls.Add(frmExcelDownload);
            frmExcelDownload.Show();
        }
    }
}
