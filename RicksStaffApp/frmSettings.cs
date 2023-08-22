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
        Label lblNewActivityRating = new Label();
        List<Activity> activityList = new List<Activity>();
        List<Position> positionList = new List<Position>();
        List<Shift> shiftList = new List<Shift>();
        Position excelPosition = new Position();









        private void frmSettings_Load(object sender, EventArgs e)
        {
            rdoActivitiesView.Checked = true;
            positionList.Clear();
            positionList = SqliteDataAccess.LoadPositions();
            foreach (Position position in positionList)
            {
                cboExcelPosition.Items.Add(position);
            }
        }

        private void btnNewAction_Click(object sender, EventArgs e)
        {
            frmNewActivity frmNewActivity = new frmNewActivity();
            frmNewActivity.ShowDialog();
        }
        //Testing Below Here


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





        private void btnLoadShifts_Click(object sender, EventArgs e)
        {
            shiftList.Clear();
            shiftList = SqliteDataAccess.LoadShifts();
            UIHelper.CreateShiftPanels(shiftList, flowSettingDisplay);
        }





        private void rdoActivitiesView_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoActivitiesView.Checked == true)
            {
                activityList.Clear();
                activityList = SqliteDataAccess.LoadActivities();
                UIHelper.CreateActivityPanels(activityList, flowSettingDisplay);
                lblCreateNew.Text = "Create New Activity";
                txtNewRating.Visible = true;
                lblNewBaseRating.Visible = true;
                btnAddItem.Text = "Create Activity";
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

            if (rdoActivitiesView.Checked)
            {
                Activity activity = new Activity();
                activity.Name = txtNewName.Text;
                activity.BaseRatingImpact = Int32.Parse(txtNewRating.Text);
                SqliteDataAccess.AddActivity(activity);
                activityList.Clear();
                activityList = SqliteDataAccess.LoadActivities();
                UIHelper.CreateActivityPanels(activityList, flowSettingDisplay);
            }
            if (rdoPositions.Checked)
            {
                Position position = new Position();
                position.Name = txtNewName.Text;
                SqliteDataAccess.AddPosition(position);
                List<Position> positions = SqliteDataAccess.LoadPositions();
                UIHelper.CreatePositionPanels(flowSettingDisplay, positions);

            }
        }

        private void rdoPositions_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPositions.Checked == true)
            {
                //List<Position> positions = SqliteDataAccess.LoadPositions();
                UIHelper.CreatePositionPanels(flowSettingDisplay, positionList);
                lblCreateNew.Text = "Create New Position";
                txtNewRating.Visible = false;
                lblNewBaseRating.Visible = false;
                btnAddItem.Text = "Create Position";
                UpdateExcelControlsForPosition(excelPosition);
            }
        }
        private void SetExcelRangeText(object sender, EventArgs e)
        {
            //lblExcelRange.Text = cboStartingLetter.Text + nudStartingNumber.Value.ToString() + ":" + cboEndingLetter.Text + nudEndingNumber.Value.ToString();
            excelPosition.SetExcelRange(cboStartingLetter.Text + nudStartingNumber.Value.ToString(), cboEndingLetter.Text + nudEndingNumber.Value.ToString());
            lblExcelRange.Text = excelPosition.ExcelRange.ToString();
        }

        private void cboStartingLetter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SetExcelRangeText();
        }

        private void cboExcelPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            excelPosition = cboExcelPosition.SelectedItem as Position;
            UpdateExcelControlsForPosition(excelPosition);
        }

        private void btnSavePosition_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.UpdatePosition(excelPosition);
        }
        private string GetExcelCellLetter(string cellAddress)
        {
            return new string(cellAddress.TakeWhile(char.IsLetter).ToArray());
        }

        private int GetExcelCellNumber(string cellAddress)
        {
            return int.Parse(new string(cellAddress.SkipWhile(char.IsLetter).ToArray()));
        }
        private void UpdateExcelControlsForPosition(Position position)
        {
            if (position == null || position.ExcelRange == null)
                return;

            // Set starting cell controls
            cboStartingLetter.Text = GetExcelCellLetter(position.ExcelStartCell);
            nudStartingNumber.Value = GetExcelCellNumber(position.ExcelStartCell);

            // Set ending cell controls
            cboEndingLetter.Text = GetExcelCellLetter(position.ExcelEndCell);
            nudEndingNumber.Value = GetExcelCellNumber(position.ExcelEndCell);
        }
    }
}
