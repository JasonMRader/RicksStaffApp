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
    public partial class frmServerShift : Form
    {
        public string EmployeeNameLabel = null;
        List<Activity> ActivityList = new List<Activity>();
        public EmployeeShift EmployeeShiftToEdit = new EmployeeShift();
        private bool isDragging = false;
        private Point lastLocation;


        public frmServerShift()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.SaveEmployeeShiftIncidents(EmployeeShiftToEdit);
            this.Close();
            this.Dispose();
            //string s = "";
            //foreach (Incident i in EmployeeShiftToEdit.Incidents)
            //{
            //    s += i.Name + " ";
            //}
            //MessageBox.Show(s);
        }



        private void frmServerShift_Load(object sender, EventArgs e)
        {
            ActivityList.Clear();
            ActivityList = SqliteDataAccess.LoadActivities();
            picShiftRating.Image = UIHelper.GetStars(EmployeeShiftToEdit.ShiftRating);
            picShiftRating.SizeMode = PictureBoxSizeMode.Zoom;
            //UIHelper.CreateActivityPanelsForEmpShift(EmployeeShiftToEdit.Incidents, ActivityList, flowActivityDisplay, flowIncidentToAdd);
            CreateActivityPanelsForEmpShift(EmployeeShiftToEdit, ActivityList, flowActivityDisplay, flowIncidentToAdd);
            //UIHelper.CreateIncidentPanelForEmpShift(EmployeeShiftToEdit.Incidents, flowIncidentToAdd);


            lblEmpolyeeName.Text = EmployeeShiftToEdit.EmployeeName;
        }
        private void UpdateRatingPicture(object sender, EventArgs e)
        {
            
        }
        private static void CreateActivityPanelsForEmpShift(EmployeeShift employeeShift, List<Activity> activityList, FlowLayoutPanel flowFormDisplay, FlowLayoutPanel flowToAdd)
        {
            // Clear existing panels
            flowFormDisplay.Controls.Clear();
            CreateIncidentPanelForEmpShift(employeeShift, flowToAdd);

            foreach (Activity activity in activityList)
            {
                FlowLayoutPanel activityPanelContainer = activity.CreateFlowLayoutPanel(flowFormDisplay.Width - 30, flowToAdd, employeeShift);

                flowFormDisplay.Controls.Add(activityPanelContainer);
            }


        }
        private static void CreateIncidentPanelForEmpShift(EmployeeShift employeeShift, FlowLayoutPanel flowDisplay)
        {
            int containerWidth = flowDisplay.Width;
            int firstContainer = (int)(containerWidth - 40);
            int nameWidth = (int)containerWidth / 4;
            int ratingWidth = (int)containerWidth / 9;
            int modPanelWidth = (int)containerWidth / 3;
            flowDisplay.Controls.Clear();
            foreach (Incident inc in employeeShift.Incidents)
            {

                FlowLayoutPanel pnlContainer = new FlowLayoutPanel();
                //activityPanelContainer.Size = new Size(430, 30);
                pnlContainer.AutoSize = true;
                pnlContainer.MinimumSize = new Size(containerWidth, 30);
                pnlContainer.MaximumSize = new Size(containerWidth, 200);
                pnlContainer.BackColor = MyColors.LightHighlight;
                pnlContainer.Margin = new Padding(0, 0, 0, 5);


                FlowLayoutPanel incidentPanel = new FlowLayoutPanel();
                incidentPanel.FlowDirection = FlowDirection.LeftToRight;
                incidentPanel.WrapContents = false;
                incidentPanel.AutoSize = true;
                incidentPanel.MaximumSize = new Size(firstContainer, 30);
                incidentPanel.MinimumSize = new Size(firstContainer, 0);
                incidentPanel.BackColor = UIHelper.GetBackColor(inc.BaseRatingImpact);

                Label lblName = new Label();
                lblName.Text = inc.Name;
                lblName.AutoSize = false;
                lblName.Size = new Size(nameWidth, 30);
                lblName.TextAlign = ContentAlignment.MiddleCenter;
                incidentPanel.Controls.Add(lblName);

                Label lblBaseRating = new Label();
                lblBaseRating.Text = inc.BaseRatingDisplay;
                lblBaseRating.AutoSize = false;
                lblBaseRating.Size = new Size(ratingWidth, 30);
                lblBaseRating.TextAlign = ContentAlignment.MiddleCenter;
                incidentPanel.Controls.Add(lblBaseRating);

                Button btnNote = new Button();
                btnNote.Text = "Add Note";
                btnNote.Size = new Size(70, 30);
                btnNote.FlatStyle = FlatStyle.Flat;
                btnNote.TextAlign = ContentAlignment.MiddleCenter;
                btnNote.Margin = new Padding(0);
                bool btnClicked = false;
                FlowLayoutPanel flowNote = new FlowLayoutPanel();
                flowNote.MinimumSize = new Size(containerWidth - 30, 90);
                btnNote.Click += (sender, e) =>
                {
                    btnClicked = !btnClicked;
                    if (btnClicked)
                    {
                        TextBox txt = new TextBox();
                        txt.Multiline = true;
                        txt.WordWrap = true;
                        txt.Size = new Size(containerWidth - 30, 60);
                        flowNote.Controls.Add(txt);
                        pnlContainer.Controls.Add(flowNote);
                    }
                    else
                    {
                        flowNote.Controls.Clear();
                        pnlContainer.Controls.Remove(flowNote);
                    }

                };
                incidentPanel.Controls.Add(btnNote);

                pnlContainer.Controls.Add(incidentPanel);
                Button btnDelete = new Button();
                btnDelete.Text = "X";
                btnDelete.Size = new Size(30, 30);
                btnDelete.FlatStyle = FlatStyle.Flat;
                btnDelete.FlatAppearance.BorderSize = 0;
                btnDelete.Margin = new Padding(2, 2, 0, 0);

                // Attach the click event to the delete button
                btnDelete.Click += (sender, e) =>
                {
                    // Remove the pnlContainer from the flowDisplay
                    flowDisplay.Controls.Remove(pnlContainer);
                    // Find the incident to remove from the EmployeeShiftToEdit.Incidents list
                    Incident incidentToRemove = employeeShift.Incidents.FirstOrDefault(i => i == inc);

                    // Remove the incident from the EmployeeShiftToEdit.Incidents list
                    if (incidentToRemove != null)
                    {
                        employeeShift.Incidents.Remove(incidentToRemove);
                    }
                };

                // Add the delete button to the pnlContainer
                pnlContainer.Controls.Add(btnDelete);

                flowDisplay.Controls.Add(pnlContainer);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateRatingPicture(object sender, ControlEventArgs e)
        {
            picShiftRating.Image = UIHelper.GetStars(EmployeeShiftToEdit.ShiftRating);
        }
    }

}
