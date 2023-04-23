using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksStaffApp
{
    public class Activity
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
    }
}
