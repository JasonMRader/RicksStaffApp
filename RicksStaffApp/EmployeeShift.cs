﻿namespace RicksStaffApp
{
    public class EmployeeShift 
    {
        public EmployeeShift()
        {
            Incidents = new List<Incident>();
            ShiftRating = 0;
        }
        public int ID { get; set; }
        public Employee Employee { get; set; }
        public Position Position { get; set; }
        public float ShiftRating { get; set; }
        public List<Incident> Incidents { get; set; }
        public void UpdateShiftRating()
        {
            float totalRatingChange = 0; // initialize total rating change to 0

            foreach (Incident incident in Incidents)
            {
                totalRatingChange += incident.IncidentRatingChange; // add rating change for incident to total rating change
            }

            ShiftRating = ShiftRating + totalRatingChange; // add total rating change to shift rating
        }
    }
}