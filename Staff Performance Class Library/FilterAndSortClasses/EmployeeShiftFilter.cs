using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Performance_Class_Library.FilterAndSortClasses
{
    public class EmployeeShiftFilter
    {
        private ISpecification<EmployeeShift> _dateSpec;
        private ISpecification<EmployeeShift> _timeSpec;
        private ISpecification<EmployeeShift> _positionSpec;

        public EmployeeShiftFilter(DateTime startDate, DateTime endDate, bool isAM, bool isPM, List<Position> positions)
        {
            _dateSpec = new EmployeeShiftDateSpecification(startDate, endDate);
            _timeSpec = new EmployeeShiftTimeSpecification(isAM, isPM);
            _positionSpec = new EmployeeShiftPositionSpecification(positions);
        }

        public bool IsSatisfiedBy(EmployeeShift employeeShift)
        {
            return _dateSpec.IsSatisfiedBy(employeeShift) &&
                   _timeSpec.IsSatisfiedBy(employeeShift) &&
                   _positionSpec.IsSatisfiedBy(employeeShift);
        }
    }
}
