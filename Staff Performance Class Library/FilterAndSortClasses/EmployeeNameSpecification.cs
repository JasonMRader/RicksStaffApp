using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Performance_Class_Library.FilterAndSortClasses
{
    public class EmployeeNameSpecification : ISpecification<Employee>
    {
        private readonly string _name;
        public EmployeeNameSpecification(string name)
        {
            _name = name;
        }

        public bool IsSatisfiedBy(Employee employee)
        {
            return employee.FirstName.Contains(_name, StringComparison.OrdinalIgnoreCase);
        }
    }
}
