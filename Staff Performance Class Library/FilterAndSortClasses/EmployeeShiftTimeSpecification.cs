using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Performance_Class_Library.FilterAndSortClasses
{
    public class EmployeeShiftTimeSpecification : ISpecification<EmployeeShift>
    {
        private readonly bool _isAM;
        private readonly bool _isPM;

        public EmployeeShiftTimeSpecification(bool isAM, bool isPM)
        {
            _isAM = isAM;
            _isPM = isPM;
        }

        public bool IsSatisfiedBy(EmployeeShift employeeShift)
        {
            return (_isAM && employeeShift.Shift.IsAm) || (_isPM && employeeShift.Shift.IsPm);
        }
    }
}
