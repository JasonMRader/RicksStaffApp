using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Performance_Class_Library.FilterAndSortClasses
{
    public class EmployeeShiftDateSpecification : ISpecification<EmployeeShift>
    {
        private readonly DateTime _startDate;
        private readonly DateTime _endDate;

        public EmployeeShiftDateSpecification(DateTime startDate, DateTime endDate)
        {
            _startDate = startDate;
            _endDate = endDate;
        }

        public bool IsSatisfiedBy(EmployeeShift employeeShift)
        {
            return employeeShift.Shift.DateAsDateTime >= _startDate && employeeShift.Shift.DateAsDateTime <= _endDate;
        }
    }
}
