using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RicksStaffApp
{
    public class Employee
    {
        public Employee()
        {
            Positions = new List<Position>();
            EmployeeShifts = new List<EmployeeShift>();
            Incidents = new List<Incident>();
            //OverallRating = 6;
        }
        public Employee(string fullName) : this()
        {
            SetNamesFromFullName(fullName);
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string FullNameAbbreviated
        {
            get
            {
                return FirstName + " " + LastName[0] + ".";
            }
        }
        //public string fullNameCleaned = Regex.Replace(this.FullName.ToLower().Trim(), @"\s+", " ");

        public float OverallRating { get; set; }
        public List<Position> Positions { get; set; }

        public List<EmployeeShift> EmployeeShifts { get; set; }
        public void AddEmployeeShift(EmployeeShift newShift)
        {
            if (!EmployeeShifts.Any(shift => shift.ID == newShift.ID))
            {
                EmployeeShifts.Add(newShift);
            }
        }
        public List<Incident> Incidents { get; set; }
        private float _timespanRating;
        public bool MatchesFirstName(string name)
        {
            return string.Equals(FirstName, name, StringComparison.OrdinalIgnoreCase);
        }
        

        public override string ToString()
        {
            return FullName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Employee))
                return false;

            return ((Employee)obj).ID == ID;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
        //TODO fix the create shift without activity problem
        public void AddIncidentsFromShifts()
        {
            foreach (EmployeeShift shift in EmployeeShifts)
            {
                foreach (Incident incident in shift.Incidents)
                {
                    Incident newIncident = new Incident()
                    {
                        Name = incident.Name,
                        //IncidentRatingChange = incident.IncidentRatingChange,
                        BaseRatingImpact = incident.BaseRatingImpact,
                        ActivityModifiers = incident.ActivityModifiers,
                        Date = incident.Date,
                        Note = incident.Note
                    };
                    Incidents.Add(newIncident);
                }
            }
        }

        
        public void UpdateOverallRating()
        {
            float totalRating = 0; // initialize total rating to default value

            foreach (EmployeeShift employeeShift in EmployeeShifts)
            {
                employeeShift.UpdateShiftRating(); // update shift rating
                totalRating += employeeShift.ShiftRating; // add shift rating to total rating
            }

            OverallRating = totalRating / (EmployeeShifts.Count); // divide total rating by number of shifts plus default value to get average
        }
        public float GetPositionRating(string positionName)
        {
            // Get shifts that match the given position name
            var shiftsForPosition = EmployeeShifts
                .Where(s => s.Position.Name == positionName)
                .ToList();

            // If there are no shifts for the given position, return 0 or throw an exception
            if (!shiftsForPosition.Any())
            {
                // Optionally: throw new Exception("No shifts for the given position.");
                return 0;
            }

            // Calculate and return the average rating for shifts of the given position
            return shiftsForPosition.Average(s => s.ShiftRating);
        }

        public float GetRatingForPeriod(DateTime startDate, DateTime endDate)
        {
            // Filter shifts for the given period
            var shiftsForPeriod = EmployeeShifts
                .Where(s => s.Shift.DateAsDateTime >= startDate && s.Shift.DateAsDateTime <= endDate)
                .ToList();

            // If there are no shifts for the given period, return 0 or throw an exception
            if (!shiftsForPeriod.Any())
            {
                //throw new Exception("No shifts for the given period.");
                return 0;
            }

            // Calculate and return the average rating for the given period
            return shiftsForPeriod.Average(s => s.ShiftRating);
        }
        public void SetNamesFromFullName(string fullName)
        {
            if (!string.IsNullOrWhiteSpace(fullName))
            {
                string[] nameParts = fullName.Trim().Split(' ');

                if (nameParts.Length >= 1)
                {
                    FirstName = nameParts[0];

                    if (nameParts.Length >= 2)
                    {
                        LastName = nameParts[nameParts.Length - 1];
                    }
                }
            }
        }
        public float GoodShiftPercentage
        {
            get
            {
                if (EmployeeShifts.Count == 0) return 0;
                var goodShifts = EmployeeShifts.Count(shift => shift.ShiftRating >= 6.5);
                return (float)goodShifts / EmployeeShifts.Count;
            }
        }

        public float AverageShiftPercentage
        {
            get
            {
                if (EmployeeShifts.Count == 0) return 0;
                var averageShifts = EmployeeShifts.Count(shift => shift.ShiftRating > 5.5 && shift.ShiftRating < 6.5);
                return (float)averageShifts / EmployeeShifts.Count;
            }
        }

        public float BadShiftPercentage
        {
            get
            {
                if (EmployeeShifts.Count == 0) return 0;
                var badShifts = EmployeeShifts.Count(shift => shift.ShiftRating <= 5.5);
                return (float)badShifts / EmployeeShifts.Count;
            }
        }
        public int TotalGoodShifts
        {
            get
            {
                return EmployeeShifts.Count(shift => shift.ShiftRating >= 6.5);
            }
        }

        public int TotalAverageShifts
        {
            get
            {
                return EmployeeShifts.Count(shift => shift.ShiftRating > 5.5 && shift.ShiftRating < 6.5);
            }
        }

        public int TotalBadShifts
        {
            get
            {
                return EmployeeShifts.Count(shift => shift.ShiftRating <= 5.5);
            }
        }
    }
}
