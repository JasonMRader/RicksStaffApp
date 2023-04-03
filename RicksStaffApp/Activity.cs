using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksStaffApp
{
    public class Activity
    {
        public Activity() { }
        public int ID {  get; set; }
        public string Name { get; set; }
        public int AdjustedRatingChange { get; set; }
        public int BaseRatingImpact { get; set; }
        public static Color GoodColor = Color.FromArgb(192, 223, 161);
        public static Color BadColor = Color.FromArgb(226, 163, 199);
        public static Color NeutralColor = Color.FromArgb(184, 184, 243);
        public List<ActivityModifier>? ActivityModifiers { get; set;}
    }
}
