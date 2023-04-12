//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RicksStaffApp
{
    public class EmployeeShift
    {
        public EmployeeShift()
        {
            Incidents = new List<Incident>();
            //Start at 6?
            ShiftRating = 6;
            Shift = new Shift();
            Employee = new Employee();
        }
        public int ID { get; set; }
        public Employee Employee { get; set; }
        public Shift Shift { get; set; }
        public Position Position { get; set; }
        public int PositionID { get; set; }
        private float _shiftRating;
        public string EmployeeName { get {return this.Employee.FullName; } }
        public float ShiftRating 
        {
            get { return _shiftRating; }
            set
            {
                if (Incidents.Count > 0)
                {
                    float totalRatingChange = 0;

                    foreach (Incident incident in Incidents)
                    {
                        totalRatingChange += incident.IncidentRatingChange;
                    }

                    _shiftRating = totalRatingChange;
                }
                else
                {
                    _shiftRating = 6; // set ShiftRating to 6 if there are no incidents
                }
            }
        }
        public List<Incident> Incidents { get; set; }
        
    }
}