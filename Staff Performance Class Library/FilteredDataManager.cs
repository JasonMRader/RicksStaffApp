using Staff_Performance_Class_Library.FilterAndSortClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Performance_Class_Library
{
    public class FilteredDataManager
    {
        private readonly EmployeeShiftFilter _employeeShiftFilter;
        private readonly DataSingleton _dataSingleton;

        public FilteredDataManager(DateTime startDate, DateTime endDate, bool isAM, bool isPM, List<Position> positions)
        {
            _dataSingleton = DataSingleton.Instance;
            _employeeShiftFilter = new EmployeeShiftFilter(startDate, endDate, isAM, isPM, positions);
        }

        public List<Employee> GetFilteredEmployees()
        {
            return _dataSingleton.Employees
                .Where(employee => employee.EmployeeShifts.Any(_employeeShiftFilter.IsSatisfiedBy))
                .ToList();
        }

        public List<Shift> GetFilteredShifts()
        {
            return _dataSingleton.Shifts
                .Where(shift => shift.EmployeeShifts.Any(_employeeShiftFilter.IsSatisfiedBy))
                .ToList();
        }

        public List<EmployeeShift> GetFilteredEmployeeShifts()
        {
            return _dataSingleton.EmployeeShifts
                .Where(_employeeShiftFilter.IsSatisfiedBy)
                .ToList();
        }

    }
}
