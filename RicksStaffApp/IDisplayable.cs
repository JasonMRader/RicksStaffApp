using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksStaffApp
{
    public interface IDisplayable
    {
        public abstract List<Control> CreateControls();
        //public abstract FlowLayoutPanel CreateFlowLayoutPanel();
        public abstract FlowLayoutPanel CreateFlowLayoutPanel(int width, FlowLayoutPanel flow, EmployeeShift employeeShift);
        //public abstract Label CreateLabel();
    }
}
