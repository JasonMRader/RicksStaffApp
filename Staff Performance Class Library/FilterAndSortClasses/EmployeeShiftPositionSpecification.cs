using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Performance_Class_Library.FilterAndSortClasses
{
    internal class EmployeeShiftPositionSpecification : ISpecification<EmployeeShift>
    {
        private readonly List<Position> _desiredPositions;

        public EmployeeShiftPositionSpecification(List<Position> positions)
        {
            _desiredPositions = positions;
        }

        public bool IsSatisfiedBy(EmployeeShift employeeShift)
        {
            return _desiredPositions.Contains(employeeShift.Position);
        }
    }
}
