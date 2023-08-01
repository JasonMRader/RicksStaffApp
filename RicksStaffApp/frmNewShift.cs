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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RicksStaffApp
{
    public partial class frmNewShift : Form
    {
        List<Shift> shifts = new List<Shift>();
        DateTime startDate = DateTime.Now;
        List<Position> AllPositions = new List<Position>();
        public frmNewShift()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmServerShift frmServerShift = new frmServerShift();
            frmServerShift.ShowDialog();
        }


        private Panel currentHighlightedPanel = null;
        private void refreshShiftPanels(DateTime startDate)
        {
            flowShiftDates.Controls.Clear();

            for (int i = 0; i < 14; i++)
            {

                Panel panel = new Panel();
                panel.Size = new Size(74, 65);
                panel.Margin = new Padding(4, 5, 4, 5);
                panel.BackColor = MyColors.LightHighlight;
                panel.BorderStyle = BorderStyle.FixedSingle;
                //panel. = date;

                System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                lbl.Text = startDate.ToString("ddd") + ", " + startDate.ToString("M");
                lbl.Size = new Size(74, 25);
                lbl.Location = new System.Drawing.Point(0, 0);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 8);

                System.Windows.Forms.Button btnAM = new System.Windows.Forms.Button();
                btnAM.Tag = startDate;
                btnAM.Size = new Size(74, 20);
                btnAM.Location = new System.Drawing.Point(0, 25);
                btnAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnAM.FlatAppearance.BorderSize = 0;
                btnAM.BackColor = Color.LightGray;
                btnAM.Text = "Create AM";


                System.Windows.Forms.Button btnPM = new System.Windows.Forms.Button();
                btnPM.Tag = startDate;
                btnPM.Size = new Size(74, 20);
                btnPM.Location = new System.Drawing.Point(0, 45);
                btnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnPM.FlatAppearance.BorderSize = 0;
                btnPM.BackColor = Color.LightGray;
                btnPM.Text = "Create PM";

                // Find if there's a shift on this date
                Shift shift = shifts.Find(s => s.DateAsDateTime.Date == startDate.Date);
                if (shift != null)
                {
                    if (shift.IsAm == true)
                    {
                        btnAM.BackColor = UIHelper.DefaultButton;
                        btnAM.Text = "AM";
                        btnAM.Click -= btnGetExcelEmployees_Click;
                        btnAM.Click += (s, e) =>
                        {
                            var btn = (System.Windows.Forms.Button)s;
                            CreateEmployeeShiftPanels(shift, flowEmployeeShiftDisplay, DateOnly.FromDateTime((DateTime)btn.Tag), pnlNewShiftDisplay);
                            dtpShiftDate.Value = (DateTime)btn.Tag;
                            if (currentHighlightedPanel != null)
                            {
                                currentHighlightedPanel.BackColor = MyColors.LightHighlight;
                            }

                            // Highlight the current panel
                            panel.BackColor = Color.Yellow; // Set the desired highlight color
                            currentHighlightedPanel = panel;
                        };
                    }
                    else
                    {
                        btnAM.Click += (s, e) =>
                        {
                            var btn = (System.Windows.Forms.Button)s;
                            DateTime shiftDate = (DateTime)btn.Tag;
                            bool isAm = true; // AM shift
                            dtpShiftDate.Value = shiftDate;
                            flowEmployeeShiftDisplay.Controls.Clear();
                            OpenExcelDownloadForm(shiftDate, isAm);
                            if (currentHighlightedPanel != null)
                            {
                                currentHighlightedPanel.BackColor = MyColors.LightHighlight;
                            }

                            // Highlight the current panel
                            panel.BackColor = Color.Yellow; // Set the desired highlight color
                            currentHighlightedPanel = panel;
                        };
                    }
                    if (shift.IsPm == true)
                    {
                        btnPM.BackColor = UIHelper.DefaultButton;
                        btnPM.Text = "PM";
                        btnPM.Click -= btnGetExcelEmployees_Click;
                        btnPM.Click += (s, e) =>
                        {
                            var btn = (System.Windows.Forms.Button)s;
                            CreateEmployeeShiftPanels(shift, flowEmployeeShiftDisplay, DateOnly.FromDateTime((DateTime)btn.Tag), pnlNewShiftDisplay);
                            dtpShiftDate.Value = (DateTime)btn.Tag;
                            if (currentHighlightedPanel != null)
                            {
                                currentHighlightedPanel.BackColor = MyColors.LightHighlight;
                            }

                            // Highlight the current panel
                            panel.BackColor = Color.Yellow; // Set the desired highlight color
                            currentHighlightedPanel = panel;
                        };
                    }
                    else
                    {
                        btnPM.Click += (s, e) =>
                        {
                            var btn = (System.Windows.Forms.Button)s;
                            DateTime shiftDate = (DateTime)btn.Tag;
                            bool isAm = false; // PM shift
                            dtpShiftDate.Value = shiftDate;
                            flowEmployeeShiftDisplay.Controls.Clear();
                            OpenExcelDownloadForm(shiftDate, isAm);
                            if (currentHighlightedPanel != null)
                            {
                                currentHighlightedPanel.BackColor = MyColors.LightHighlight;
                            }

                            // Highlight the current panel
                            panel.BackColor = Color.Yellow; // Set the desired highlight color
                            currentHighlightedPanel = panel;
                        };
                    }

                }
                else
                {
                    btnAM.Click += (s, e) =>
                    {
                        var btn = (System.Windows.Forms.Button)s;
                        DateTime shiftDate = (DateTime)btn.Tag;
                        bool isAm = true; // AM shift
                        flowEmployeeShiftDisplay.Controls.Clear();
                        OpenExcelDownloadForm(shiftDate, isAm);
                        dtpShiftDate.Value = (DateTime)btn.Tag;
                        if (currentHighlightedPanel != null)
                        {
                            currentHighlightedPanel.BackColor = MyColors.LightHighlight;
                        }

                        // Highlight the current panel
                        panel.BackColor = Color.Yellow; // Set the desired highlight color
                        currentHighlightedPanel = panel;
                    };
                    btnPM.Click += (s, e) =>
                    {
                        var btn = (System.Windows.Forms.Button)s;
                        DateTime shiftDate = (DateTime)btn.Tag;
                        flowEmployeeShiftDisplay.Controls.Clear();
                        bool isAm = false; // PM shift
                        OpenExcelDownloadForm(shiftDate, isAm);
                        dtpShiftDate.Value = (DateTime)btn.Tag;
                        if (currentHighlightedPanel != null)
                        {
                            currentHighlightedPanel.BackColor = MyColors.LightHighlight;
                        }

                        // Highlight the current panel
                        panel.BackColor = Color.Yellow; // Set the desired highlight color
                        currentHighlightedPanel = panel;
                    };
                }



                startDate = startDate.AddDays(1);
                panel.Controls.Add(lbl);
                panel.Controls.Add(btnAM);
                panel.Controls.Add(btnPM);

                flowShiftDates.Controls.Add(panel);
            }
        }
       
        private void frmNewShift_Load(object sender, EventArgs e)
        {
            
            shifts = SqliteDataAccess.LoadShifts();
            AllPositions = SqliteDataAccess.LoadPositions();
            //DateTime date = DateTime.Now;
            startDate = DateTime.Now.AddDays(-13);
            Shift shift = shifts.Find(s => s.DateAsDateTime.Date == startDate.Date);
            //UIHelper.CreateShiftPanels(shifts, flowEmployeeShiftDisplay);
            if (shift != null)
            {
                CreateEmployeeShiftPanels(shift, flowEmployeeShiftDisplay, DateOnly.FromDateTime(dtpShiftDate.Value), pnlNewShiftDisplay);
            }
            else
            {
                System.Windows.Forms.Label lblNoShifts = new System.Windows.Forms.Label();
                lblNoShifts.Text = "No Shifts For This Day";
                lblNoShifts.ForeColor = Color.White;
                lblNoShifts.AutoSize = true;
                lblNoShifts.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20, FontStyle.Bold);
                flowEmployeeShiftDisplay.Controls.Add((Control)lblNoShifts);

            }

            UIHelper.CreatePositionOverviewPanels(flowPositions, AllPositions);
            refreshShiftPanels(startDate);


        }
        private static void UpdateEmployeeShiftPanel (EmployeeShift employeeShift, FlowLayoutPanel flowDisplay)
        {
            foreach (Control c in flowDisplay.Controls)
            {
                if (c.Tag == employeeShift)
                {
                    c.BackColor = Color.White;
                }
            }
        }
        private void CreateEmployeeShiftPanels(Shift shift, FlowLayoutPanel flowEmployeeDisplay, DateOnly shiftDate, Panel secondPanel)
        {
            //TODO pass in one shift, not a list of shifts
            flowEmployeeDisplay.Controls.Clear();
            //foreach (Shift shift in shiftList)
            //{
            //    //MessageBox.Show(shift.Date.ToString());
            if (shift.Date == shiftDate)
            {
                shift.EmployeeShifts = shift.EmployeeShifts.OrderBy(es => es.Employee.FullName).ToList();

                foreach (EmployeeShift es in shift.EmployeeShifts)
                {
                    es.UpdateShiftRating();
                    FlowLayoutPanel empShiftContainer = UIHelper.CreateFlowPanel(470, 30);
                    empShiftContainer.Tag = es;
                    empShiftContainer.MinimumSize = new Size(470, 30);
                    empShiftContainer.MaximumSize = new Size(470, 1000);
                    empShiftContainer.Margin = new Padding(0, 0, 0, 5);

                    System.Windows.Forms.Label lblName = UIHelper.CreateLabel(100, 30, es.Employee.FullName);
                    empShiftContainer.Controls.Add(lblName);

                    //Label lblPos = CreateLabel(60, 30, es.Position.Name);                        
                    //empShiftContainer.Controls.Add(lblPos);
                    PictureBox pbPosition = UIHelper.CreatePositionPictureBox(30, 30, es.Position);
                    empShiftContainer.Controls.Add(pbPosition);

                    System.Windows.Forms.Label lblShiftRating = UIHelper.CreateLabel(25, 30, es.ShiftRating.ToString());
                    empShiftContainer.Controls.Add(lblShiftRating);

                    PictureBox pbRating = UIHelper.CreateRatingPictureBox(90, 30, es.ShiftRating);
                    empShiftContainer.Controls.Add(pbRating);

                    System.Windows.Forms.Button btnIncidents = UIHelper.CreateButtonTemplate(65, 30, "Incidents");
                    FlowLayoutPanel incidentContainer = UIHelper.CreateFlowPanel(470, 30);
                    bool btnClicked = false;
                    btnIncidents.Click += (sender, e) =>
                    {
                        btnClicked = !btnClicked;
                        if (btnClicked)
                        {
                            UIHelper.CreateIncidentPanels_REPLACE(es.Incidents, incidentContainer, shift);
                            empShiftContainer.Controls.Add(incidentContainer);
                        }
                        else
                        {
                            incidentContainer.Controls.Clear();
                            empShiftContainer.Controls.Remove(incidentContainer);
                        }

                    };
                    empShiftContainer.Controls.Add(btnIncidents);

                    System.Windows.Forms.Button btnAddIncidents = UIHelper.CreateButtonTemplate(65, 30, "Add/Edit");
                    btnAddIncidents.Click += (sender, e) =>
                    {
                        secondPanel.Controls.Clear();
                        frmServerShift frmServerShift = new frmServerShift(es);
                        frmServerShift.EmployeeShiftUpdated += FrmServerShift_EmployeeShiftUpdated;
                        //frmServerShift.EmployeeShiftToEdit = es;
                        frmServerShift.TopLevel = false;
                        secondPanel.Controls.Add(frmServerShift);
                        
                        frmServerShift.Show();
                    };
                    empShiftContainer.Controls.Add(btnAddIncidents);

                    flowEmployeeDisplay.Controls.Add(empShiftContainer);

                }

            }
            //}


        }
        private void FrmServerShift_EmployeeShiftUpdated(EmployeeShift employeeShift)
        {
            UpdateEmployeeShiftPanel(employeeShift, flowEmployeeShiftDisplay);
        }

        private void CalendarShiftClicked(object sender, EventArgs e)
        {
            DateTime date = dtpShiftDate.Value;
            Shift shift = shifts.Find(s => s.DateAsDateTime.Date == date.Date);
            // Code to execute when the button is clicked
            CreateEmployeeShiftPanels(shift, flowEmployeeShiftDisplay, DateOnly.FromDateTime(dtpShiftDate.Value), pnlNewShiftDisplay);
        }

        private void dtpShiftDate_ValueChanged(object sender, EventArgs e)
        {
            //List <EmployeeShift> employeeShifts = new List <EmployeeShift>();
            //UIHelper.CreateEmployeeShiftPanels(shifts, flowEmployeeShiftDisplay, DateOnly.FromDateTime(dtpShiftDate.Value), pnlNewShiftDisplay);
            shifts = SqliteDataAccess.LoadShifts();

        }
        private void OpenExcelDownloadForm(DateTime shiftDate, bool isAm)
        {
            frmExcelDownload frmExcelDownload = new frmExcelDownload(shiftDate, isAm);
            //frmExcelDownload.ShiftCreated += refreshShiftPanels;
            pnlNewShiftDisplay.Controls.Clear();
            frmExcelDownload.TopLevel = false;
            pnlNewShiftDisplay.Controls.Add(frmExcelDownload);
            frmExcelDownload.Show();
            //frmExcelDownload.ShiftCreated -= refreshShiftPanels;
        }
        private void btnGetExcelEmployees_Click(object sender, EventArgs e)
        {
            //frmExcelDownload frmExcelDownload = new frmExcelDownload();
            //pnlNewShiftDisplay.Controls.Clear();
            //frmExcelDownload.TopLevel = false;
            //pnlNewShiftDisplay.Controls.Add(frmExcelDownload);
            //frmExcelDownload.Show();
        }



        private void btnForwardDate_Click(object sender, EventArgs e)
        {
            if (startDate < DateTime.Now.AddDays(-14))
            {
                startDate = startDate.AddDays(14);
                refreshShiftPanels(startDate);
            }

        }

        private void btnBackDate_Click(object sender, EventArgs e)
        {
            startDate = startDate.AddDays(-14);
            refreshShiftPanels(startDate);
        }
    }
}
