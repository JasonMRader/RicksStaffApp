using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksStaffApp
{
    public class Shift
    {
        public Shift() { }
        public int ID { get; set; }
        public DateOnly Date { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
