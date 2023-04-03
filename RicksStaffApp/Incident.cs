using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksStaffApp
{
    public class Incident : Activity
    {
        public int IncidentID { get; set; }
        public int ActivityID { get; set; }
        public DateOnly Date { get; set; }
        public string? Note { get; set; }
        public int IncidentRatingChange { get; set; } // add TotalRatingChange property
    }
}

