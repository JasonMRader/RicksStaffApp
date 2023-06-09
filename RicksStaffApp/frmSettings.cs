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
        //TODO fix the create shift without activity problem


        private void btnLoadIncidents_Click(object sender, EventArgs e)
        {

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





        private void rdoActivitiesView_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoActivitiesView.Checked)
            {
                activityList.Clear();
                activityList = SqliteDataAccess.LoadActivities();
                UIHelper.CreateActivityPanels(activityList, flowSettingDisplay);
            }
        }

        private void rdoShifts_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoShifts.Checked)
            {
                shiftList.Clear();
                shiftList = SqliteDataAccess.LoadShifts();
                UIHelper.CreateShiftPanels(shiftList, flowSettingDisplay);
            }

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();

            activity.Name = txtNewName.Text;
            activity.BaseRatingImpact = Int32.Parse(txtNewRating.Text);


            SqliteDataAccess.AddActivity(activity);
            activityList.Clear();
            activityList = SqliteDataAccess.LoadActivities();
            UIHelper.CreateActivityPanels(activityList, flowSettingDisplay);
        }
    }
}
