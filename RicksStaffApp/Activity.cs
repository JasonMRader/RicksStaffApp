using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksStaffApp
{
    public class Activity : IDisplayable
    {
        public Activity()
        {
            //AdjustedRatingChange = 0;
            List<ActivityModifier> list = new List<ActivityModifier>();
        }
        public int ID {  get; set; }
        public string Name { get; set; }
        //public int AdjustedRatingChange { get; set; }
        public int BaseRatingImpact { get; set; }
        public string BaseRatingDisplay
        {
            get
            {
                if (BaseRatingImpact > 0)
                {
                    return "+" + BaseRatingImpact.ToString();
                }
                else
                {
                    return BaseRatingImpact.ToString();
                }
                
            }
        }
        
        public List<ActivityModifier>? ActivityModifiers { get; set;}

        public List<Control> CreateControls()
        {
            throw new NotImplementedException();
        }

        public FlowLayoutPanel CreateFlowLayoutPanel(int width, FlowLayoutPanel flowToAddTo, EmployeeShift employeeShift)
        {
            int firstContainer = (int)(width - 35);
            int nameWidth = (int)width / 3;
            int ratingWidth = (int)width / 10;
            int modPanelWidth = (int)width / 3;
            FlowLayoutPanel activityPanelContainer = new FlowLayoutPanel();
            //activityPanelContainer.Size = new Size(430, 30);
            activityPanelContainer.AutoSize = true;
            activityPanelContainer.MinimumSize = new Size(width, 30);
            activityPanelContainer.MaximumSize = new Size(width, 200);
            activityPanelContainer.BackColor = MyColors.LightHighlight;
            activityPanelContainer.Margin = new Padding(0, 0, 0, 5);


            FlowLayoutPanel activityPanel = new FlowLayoutPanel();
            activityPanel.FlowDirection = FlowDirection.LeftToRight;
            activityPanel.WrapContents = false;
            activityPanel.AutoSize = true;
            activityPanel.MaximumSize = new Size(firstContainer, 30);
            activityPanel.MinimumSize = new Size(firstContainer, 0);

            PictureBox picUpDown = new PictureBox();
            picUpDown.Size = new Size(30, 30);
            picUpDown.Margin = new Padding(15, 3, 0, 0);


            activityPanel.BackColor = UIHelper.GetBackColor(BaseRatingImpact);
            picUpDown.Image = UIHelper.GetArrowImage(BaseRatingImpact);

            activityPanel.Margin = new Padding(1, 1, 1, 1);

            //// Create label for employee name
            Label lblName = new Label();
            lblName.Text = Name;
            lblName.AutoSize = false;
            lblName.Size = new Size(nameWidth, 30);
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.Margin = new Padding(0, 0, 5, 0);
            activityPanel.Controls.Add(lblName);


            activityPanel.Controls.Add(picUpDown);

            Label lblBaseRating = new Label();
            lblBaseRating.Text = BaseRatingDisplay;
            lblBaseRating.AutoSize = false;
            lblBaseRating.Size = new Size(ratingWidth, 30);
            lblBaseRating.TextAlign = ContentAlignment.MiddleCenter;
            lblBaseRating.Margin = new Padding(0, 0, 0, 0);
            activityPanel.Controls.Add(lblBaseRating);

            activityPanelContainer.Controls.Add(activityPanel);

            
            activityPanelContainer.Controls.Add(activityPanel);
           
            Button btnAddToEmpShift = new Button();
            btnAddToEmpShift.Text = "+";
            btnAddToEmpShift.Margin = new Padding(2, 2, 0, 0);
            btnAddToEmpShift.Location = new Point(410, 0);
            btnAddToEmpShift.ForeColor = Color.Black;
            btnAddToEmpShift.Font = new Font(btnAddToEmpShift.Font.FontFamily, 10);
            btnAddToEmpShift.TextAlign = ContentAlignment.MiddleCenter;
            btnAddToEmpShift.FlatStyle = FlatStyle.Flat;
            btnAddToEmpShift.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddToEmpShift.FlatAppearance.BorderSize = 0;
            btnAddToEmpShift.Click += (sender, e) =>
            {
                Incident incident = new Incident(this);
                UIHelper.AddOneIncidentForEmpShift(incident, flowToAddTo);
                employeeShift.AddIncident(incident);
                //incident.ActivityID = ID;
                //incident.DateString = 
                //incident.Note = txtIncidentNote.Text;
                //incident.EmployeeShiftID = Int32.Parse(txtIncident_EmployeeID.Text);

                //CreateIncidentPanelForEmpShift(flowToAdd);
                //SqliteDataAccess.AddIncident(incident);




            };
            btnAddToEmpShift.Size = new Size(27, 27);
            activityPanelContainer.Controls.Add(btnAddToEmpShift);
            return activityPanelContainer;
        }
    }
}
