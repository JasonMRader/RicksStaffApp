using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Performance_Class_Library.FilterAndSortClasses
{
    public class ShiftDateSpecification : ISpecification<Shift>
    {
        private readonly DateTime _startDate;
        private readonly DateTime _endDate;

        public ShiftDateSpecification(DateTime startDate, DateTime endDate)
        {
            _startDate = startDate;
            _endDate = endDate;
        }

        public bool IsSatisfiedBy(Shift shift)
        {
            return shift.DateAsDateTime >= _startDate && shift.DateAsDateTime <= _endDate;
        }
    }

}
