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
            DateTime date = DateTime.Now.AddDays(-13);

            for (int i = 0; i < 14; i++)
            {
                Panel panel = new Panel();
                panel.Size = new Size(74, 65);
                panel.Margin = new Padding(7, 5, 7, 5);
                panel.BackColor = Color.White;

                System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                lbl.Text = date.ToString("ddd") + ", " + date.ToString("M");
                lbl.Size = new Size(74, 25);
                lbl.Location = new System.Drawing.Point(0, 0);

                System.Windows.Forms.Button btnAM = new System.Windows.Forms.Button();
                btnAM.Size = new Size(74, 20);
                btnAM.Location = new System.Drawing.Point(0, 25);
                btnAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnAM.FlatAppearance.BorderSize = 0;
                

                System.Windows.Forms.Button btnPM = new System.Windows.Forms.Button();
                btnPM.Size = new Size(74, 20);
                btnPM.Location = new System.Drawing.Point(0, 45);
                btnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnPM.FlatAppearance.BorderSize = 0;

                // Find if there's a shift on this date
                Shift shift = shifts.Find(s => s.DateAsDateTime.Date == date.Date);
                if (shift != null)
                {
                    if (shift.IsAm == true)
                    {
                        btnAM.BackColor = UIHelper.DefaultButton;
                        btnAM.Text = "AM";
                    }
                    else
                    {
                        btnAM.BackColor = Color.FromArgb(128, 25, 128);
                        btnAM.Text = "Create AM";
                    }
                    if (shift.IsPm == true)
                    {
                        btnPM.BackColor = UIHelper.DefaultButton;
                        btnPM.Text = "PM";
                    }
                    else
                    {
                        btnPM.BackColor = Color.FromArgb(128, 25, 128);
                        btnPM.Text = "Create PM";
                    }

                }
                

                date = date.AddDays(1);
                panel.Controls.Add(lbl);
                panel.Controls.Add(btnAM);
                panel.Controls.Add(btnPM);

                flowShiftDates.Controls.Add(panel);
            }

        }



        private void dtpShiftDate_ValueChanged(object sender, EventArgs e)
        {
            //List <EmployeeShift> employeeShifts = new List <EmployeeShift>();
            UIHelper.CreateEmployeeShiftPanels(shifts, flowEmployeeShiftDisplay, DateOnly.FromDateTime(dtpShiftDate.Value), pnlNewShiftDisplay);
            shifts = SqliteDataAccess.LoadShifts();

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
