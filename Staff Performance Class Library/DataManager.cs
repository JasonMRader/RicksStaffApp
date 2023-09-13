using Staff_Performance_Class_Library.FilterAndSortClasses;

namespace Staff_Performance_Class_Library
{
    public class DataManager
    {
        private readonly EmployeeShiftFilter? _employeeShiftFilter;
        private readonly DataSingleton _dataSingleton;

       
        public DataManager()
        {
            _dataSingleton = DataSingleton.Instance;
            _employeeShiftFilter = null;  
        }

       
        public DataManager(DateTime startDate, DateTime endDate, bool isAM, bool isPM, List<Position> positions)
        {
            _dataSingleton = DataSingleton.Instance;
            _employeeShiftFilter = new EmployeeShiftFilter(startDate, endDate, isAM, isPM, positions);
        }

        public List<Employee> GetEmployees()
        {
            if (_employeeShiftFilter == null)
                return _dataSingleton.Employees;

            return _dataSingleton.Employees
                .Where(employee => employee.EmployeeShifts.Any(_employeeShiftFilter.IsSatisfiedBy))
                .ToList();
        }

        public List<Shift> GetShifts()
        {
            if (_employeeShiftFilter == null)
                return _dataSingleton.Shifts;

            return _dataSingleton.Shifts
                .Where(shift => shift.EmployeeShifts.Any(_employeeShiftFilter.IsSatisfiedBy))
                .ToList();
        }

        public List<EmployeeShift> GetEmployeeShifts()
        {
            if (_employeeShiftFilter == null)
                return _dataSingleton.EmployeeShifts;

            return _dataSingleton.EmployeeShifts
                .Where(_employeeShiftFilter.IsSatisfiedBy)
                .ToList();
        }
    }

}
