using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Performance_Class_Library.FilterAndSortClasses
{
    public class ShiftTimeSpecification : ISpecification<Shift>
    {
        private readonly bool _isAM;
        private readonly bool _isPM;

        public ShiftTimeSpecification(bool isAM, bool isPM)
        {
            _isAM = isAM;
            _isPM = isPM;
        }

        public bool IsSatisfiedBy(Shift shift)
        {
            return (_isAM && shift.IsAm) || (_isPM && shift.IsPm);
        }
    }

}
