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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }
        Panel pnlNewRating = new Panel();
        FlowLayoutPanel flpAdditionAction = new FlowLayoutPanel();
        Label lblNewRating = new Label();
        List<Activity> activityList = new List<Activity>();
        List<Shift> shiftList = new List<Shift>();









        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnNewAction_Click(object sender, EventArgs e)
        {
            frmNewActivity frmNewActivity = new frmNewActivity();
            frmNewActivity.ShowDialog();
        }
        //Testing Below Here
        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();

            activity.Name = txtActivityName.Text;
            activity.BaseRatingImpact = Int32.Parse(txtActivityRating.Text);


            SqliteDataAccess.AddActivity(activity);

        }

        private void btnLoadActivities_Click(object sender, EventArgs e)
        {

            activityList.Clear();
            activityList = SqliteDataAccess.LoadActivities();
            UIHelper.CreateActivityPanels(activityList, flowSettingDisplay);
        }

        private void btnAddIncident_Click(object sender, EventArgs e)
        {
            Incident incident = new Incident();
            incident.ActivityID = Int32.Parse(txtIncident_ActivityID.Text);
            incident.DateString = dtpIncidentDate.Text;
            incident.Note = txtIncidentNote.Text;
            incident.EmployeeShiftID = Int32.Parse(txtIncident_EmployeeID.Text);

            SqliteDataAccess.AddIncident(incident);


        }

        private void btnLoadIncidents_Click(object sender, EventArgs e)
        {

        }

        private void btnAddActivityMod_Click(object sender, EventArgs e)
        {
            ActivityModifier modifier = new ActivityModifier();
            modifier.Name = txtActivityModName.Text;
            modifier.ActivityID = Int32.Parse(txtActivityMod_ActivityID.Text);
            modifier.RatingAdjustment = Int32.Parse(txtActivityModRatingAdjustment.Text);

            SqliteDataAccess.AddActivityModifier(modifier);
        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            Shift s = new Shift();
            s.Date = DateOnly.FromDateTime(dtpShiftDate.Value);
            if (cbIsAmShift.Checked)
            {
                s.IsAm = true;
            }
            else
            {
                s.IsAm = false;
            }
            SqliteDataAccess.AddShift(s);
        }

        private void btnLoadShifts_Click(object sender, EventArgs e)
        {
            shiftList.Clear();
            shiftList = SqliteDataAccess.LoadShifts();
            UIHelper.CreateShiftPanels(shiftList, flowSettingDisplay);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            dtpTestOutput.Value = DateTime.Parse(txtTestInput.Text);
        }

        private void btnAddEmployeeShift_Click(object sender, EventArgs e)
        {
            EmployeeShift empShift = new EmployeeShift();
            empShift.PositionID = Decimal.ToInt32(nudPositionID.Value); 
            empShift.Shift.ID = Int32.Parse(txtEmployeeShift_ShiftID.Text);
            empShift.Employee.ID = Int32.Parse(txtEmployeeIDShiftEmployeeName.Text);


            SqliteDataAccess.AddEmployeeShift(empShift);
        }
    }
}
