using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksStaffApp.Properties
{
    public interface IDisplayable
    {
        public abstract List<Control> CreateControls();
    }
}
