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


            SqliteDataAccess.SaveActivity(activity);

        }

        private void btnLoadActivities_Click(object sender, EventArgs e)
        {

            activityList.Clear();
            activityList = SqliteDataAccess.LoadActivities();
            UIHelper.CreateActivityPanels(activityList, flowSettingDisplay);
        }

        private void btnAddIncident_Click(object sender, EventArgs e)
        {

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

            SqliteDataAccess.SaveActivityModifier(modifier);
        }
    }
}
