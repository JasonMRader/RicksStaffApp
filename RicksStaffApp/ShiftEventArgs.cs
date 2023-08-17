using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksStaffApp
{
    public class ShiftEventArgs : EventArgs
    {
        public Shift NewShift { get; set; }
        public ShiftEventArgs(Shift shift)
        {
            NewShift = shift;
        }
    }
}
