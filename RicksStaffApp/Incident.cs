using RicksStaffApp.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksStaffApp
{
    public class Incident : Activity, IDisplayable
    {
        //TODO add modifier ID to Incident in DB
        public Incident(Activity activity)
        {
            // Copy the properties from the activity object
            //ID = activity.ID;
            Name = activity.Name;
            ActivityID = activity.ID;
            
            BaseRatingImpact = activity.BaseRatingImpact;
            ActivityModifiers = activity.ActivityModifiers;
            ActiveActivityModifiers = new List<ActivityModifier>();
            //_incidentRatingChange = activity.BaseRatingImpact;
        }
        public Incident()
        {
            //AdjustedRatingChange = 0;
            List<ActivityModifier> list = new List<ActivityModifier>();
            ActiveActivityModifiers = new List<ActivityModifier>();
            //_incidentRatingChange = 0;
        }
        public int IncidentID { get; set; }
        public int ActivityID { get; set; }
        public DateOnly Date { get; set; }
        public string? Note { get; set; }
        //public int IncidentRatingChange { get; set; }
        public int EmployeeShiftID { get; set; }
        //private int _incidentRatingChange { get; set; } // add TotalRatingChange property
        public List<ActivityModifier>? ActiveActivityModifiers { get; set; }
        public int IncidentRatingChange
        {
            get
            {
                int totalRatingChange = BaseRatingImpact;

                if (ActiveActivityModifiers != null && ActiveActivityModifiers.Count > 0)
                {
                    foreach (ActivityModifier am in ActiveActivityModifiers)
                    {
                        totalRatingChange += am.RatingAdjustment;
                    }
                }

                return totalRatingChange;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Incident other = (Incident)obj;
            return ID == other.ID;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
        //public int IncidentRatingChange
        //{
        //    get
        //    {
        //        return _incidentRatingChange;
        //    }
        //    set
        //    {
        //        _incidentRatingChange = value;
        //        UpdateIncidentRatingChange(); // Call the method to update _incidentRatingChange based on modifiers
        //    }
        //}

        //// ...

        //// Method to update _incidentRatingChange based on modifiers
        //private void UpdateIncidentRatingChange()
        //{
        //    if (ActiveActivityModifiers != null && ActiveActivityModifiers.Count > 0)
        //    {
        //        int totalRatingChange = 0;

        //        foreach (ActivityModifier am in ActiveActivityModifiers)
        //        {
        //            totalRatingChange += am.RatingAdjustment;
        //        }

        //        _incidentRatingChange += totalRatingChange;
        //    }
        //}
        //public int IncidentRatingChange
        //{
        //    get
        //    {
        //        return _incidentRatingChange;
        //    }
        //    set
        //    {
        //        if (ActiveActivityModifiers != null && ActiveActivityModifiers.Count > 0)
        //        {
        //            int totalRatingChange = 0;

        //            foreach (ActivityModifier am in ActiveActivityModifiers)
        //            {
        //                totalRatingChange += am.RatingAdjustment;
        //            }

        //            _incidentRatingChange = value + totalRatingChange;
        //        }
        //        else
        //        {
        //            _incidentRatingChange = value; // Set the value to BaseRatingImpact if the list is null or empty
        //        }
        //    }
        //}

        public string DateString
        {
            get { return Date.ToString("MM/dd/yyyy"); }
            set
            {
                var dateTime = DateTime.Parse(value);

                Date = DateOnly.FromDateTime(dateTime);
            }
            //set { Date = DateOnly.Parse(value, IFormatProvider? provider); }
        }
        //TODO remove assign activities for effecency
        public static void AssignActivitiesToIncidents(List<Shift> shifts, List<Activity> activities)
        {
            // Create a dictionary to efficiently lookup activities by their ID
            Dictionary<int, Activity> activityLookup = activities.ToDictionary(activity => activity.ID);

            // Iterate over the shifts
            foreach (Shift shift in shifts)
            {
                // Iterate over the employee shifts in the current shift
                foreach (EmployeeShift employeeShift in shift.EmployeeShifts)
                {
                    // Iterate over the incidents in the current employee shift
                    foreach (Incident incident in employeeShift.Incidents)
                    {
                        // Check if the incident's ActivityID is in the activityLookup dictionary
                        if (activityLookup.TryGetValue(incident.ActivityID, out Activity activity))
                        {
                            // Assign the activity properties to the incident
                            incident.Name = activity.Name;
                            //incident.AdjustedRatingChange = activity.AdjustedRatingChange;
                            incident.BaseRatingImpact = activity.BaseRatingImpact;
                            incident.ActivityModifiers = activity.ActivityModifiers;
                        }
                    }
                }
            }
        }
        public static void AssignActivitiesToEmployeeIncidents(List<Employee> employees, List<Activity> activities)
        {
            // Create a dictionary to efficiently lookup activities by their ID
            Dictionary<int, Activity> activityLookup = activities.ToDictionary(activity => activity.ID);

            // Iterate over the shifts
            foreach (Employee employee in employees)
            {
                // Iterate over the employee shifts in the current shift
                foreach (EmployeeShift employeeShift in employee.EmployeeShifts)
                {
                    // Iterate over the incidents in the current employee shift
                    foreach (Incident incident in employeeShift.Incidents)
                    {
                        // Check if the incident's ActivityID is in the activityLookup dictionary
                        if (activityLookup.TryGetValue(incident.ActivityID, out Activity activity))
                        {
                            // Assign the activity properties to the incident
                            incident.Name = activity.Name;
                            //incident.AdjustedRatingChange = activity.AdjustedRatingChange;
                            incident.BaseRatingImpact = activity.BaseRatingImpact;
                            incident.ActivityModifiers = activity.ActivityModifiers;
                        }
                    }
                }
            }
        }

        public List<Control> CreateControls()
        {
            List<Control> controls = new List<Control>();
            Label lblIncidentName = UIHelper.CreateNameLable(Name);
            //lblIncidentName.Text = Name;
            //lblIncidentName.Size = new Size(70, 30);
            //lblIncidentName.ForeColor = Color.Black;
            //lblIncidentName.TextAlign = ContentAlignment.MiddleCenter;
            controls.Add(lblIncidentName);

            PictureBox picUpDown = new PictureBox();
            picUpDown.Size = new Size(30, 30);
            picUpDown.Margin = new Padding(15, 3, 0, 0);
            picUpDown.Image = UIHelper.GetRatingImage(IncidentRatingChange);
            controls.Add(picUpDown);

            Label lblIncidentRating = new Label();
            lblIncidentRating.Size = new Size(30, 30);
            lblIncidentRating.TextAlign = ContentAlignment.MiddleCenter;
            lblIncidentRating.Text = BaseRatingImpact.ToString();
            controls.Add(lblIncidentRating);
            return controls;
        }

        public FlowLayoutPanel CreateFlowLayoutPanel()
        {
            FlowLayoutPanel incidentPanel = new FlowLayoutPanel();
            
            incidentPanel.AutoSize = true;
            incidentPanel.BackColor = UIHelper.GetBackColor(IncidentRatingChange);
            
            List<Control> controls = CreateControls();
            foreach (Control control in controls)
            {
                incidentPanel.Controls.Add(control);
            }
            return incidentPanel;
            
        }
        //public Label CreateLable()
        //{
        //    Label lblLable = new Label();
        //    lblLable.Text = Name;
        //    lblLable.Size = new Size(70, 30);
        //    lblLable.ForeColor = Color.Black;
        //    lblLable.TextAlign = ContentAlignment.MiddleCenter;
        //    return lblLable;
        //}
    }
}

