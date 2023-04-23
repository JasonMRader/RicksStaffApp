using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            OverallRating = 6;
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
        public float OverallRating { get; set; }
        public List<Position> Positions { get; set; }

        public List<EmployeeShift> EmployeeShifts { get; set; }
        public List<Incident> Incidents { get; set; }
        public bool MatchesFirstName(string name)
        {
            return string.Equals(FirstName, name, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return FullName;
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
            float totalRating = 6; // initialize total rating to default value

            foreach (EmployeeShift shift in EmployeeShifts)
            {
                totalRating += shift.ShiftRating; // add shift rating to total rating
            }

            OverallRating = totalRating / (EmployeeShifts.Count + 1); // divide total rating by number of shifts plus default value to get average
        }
    }
}
