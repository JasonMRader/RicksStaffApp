﻿//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RicksStaffApp
{
    public class EmployeeShift
    {
        public EmployeeShift()
        {
            Incidents = new List<Incident>();
            //Start at 6?
            //ShiftRating = 6;
            Shift = new Shift();
            Employee = new Employee();
            ShiftRating = _shiftRating;
        }
        public EmployeeShift(Employee employee, Shift shift) : this()
        {
            Employee = employee;
            Shift = shift;
            ShiftRating = _shiftRating;
        }
        public int ID { get; set; }
        public Employee Employee { get; set; }
        public Shift Shift { get; set; }
        public int ShiftID { get; set; }    
        public Position Position { get; set; }
        public string DateString { get; set; }
        public int PositionID { get; set; }
        private float _shiftRating;
        public string EmployeeName { get {return this.Employee.FullName; } }
        //public float ShiftRating
        //{
        //    get { return _shiftRating; }
        //}
        public void UpdateShiftRating()
        {
            float totalRatingChange = 0;

            if (Incidents.Count > 0)
            {
                foreach (Incident incident in Incidents)
                {
                    totalRatingChange += incident.IncidentRatingChange;
                }

                _shiftRating = 6 + totalRatingChange;
            }
            else
            {
                _shiftRating = 6;
            }
        }

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

                    _shiftRating = value + totalRatingChange;
                }
                else
                {
                    _shiftRating = 6; // set ShiftRating to 6 if there are no incidents
                }
            }
        }
        public List<Incident> Incidents { get; set; }
        public Image RatingDisplay { get; set; }
        public void AddIncident(Incident incident)
        {
            incident.EmployeeShiftID = this.ID;
            Incidents.Add(incident);
            ShiftRating = _shiftRating;
        }

    }
    //public static void AssignShiftToEmployeeShifts(List<EmployeeShift> employeeShifts, List<Shift> shifts)
    //{
    //    // Create a dictionary to efficiently lookup shifts by their ID
    //    Dictionary<int, Shift> shiftLookup = shifts.ToDictionary(shift => shift.ID);
    //    // Iterate over the employee shifts
    //    foreach (EmployeeShift employeeShift in employeeShifts)
    //    {
            
    //    }
    //}
}