using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Performance_Class_Library
{
    public class DataSingleton
    {
        private static DataSingleton instance;
        public List<Employee> Employees { get; private set; }
        public List<Shift> Shifts { get; private set; }
        //public List<Incident> Incidents { get; private set; }
        public List<Position> Positions { get; private set; }     
        public List<EmployeeShift> EmployeeShifts { get ; private set; }
        public List<Activity> Activities { get; private set; }
        public List<string> ignoredExcelCells { get; private set; }
        // ... other lists

        private DataSingleton()
        {
            Employees = new List<Employee>();
            Shifts = new List<Shift>();
            //Incidents = new List<Incident>();
            Positions = new List<Position>();
            EmployeeShifts = new List<EmployeeShift>();
            Activities = new List<Activity>();
            ignoredExcelCells = new List<string>();
            
            LoadDataFromDatabase();
        }

        public static DataSingleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataSingleton();
                return instance;
            }
        }

        private void LoadDataFromDatabase()
        {
            Employees = SqliteDataAccess.LoadEmployees();
            Shifts = SqliteDataAccess.LoadShifts();
            Positions = SqliteDataAccess.LoadPositions();
            //Incidents
            //EmployeeShifts = SqliteDataAccess.LoadEmployeeShifts();
            Activities = SqliteDataAccess.LoadActivities();
            ignoredExcelCells = SqliteDataAccess.LoadExcelIgnore();

            BuildEmployeeShifts();
        }
        private void BuildEmployeeShifts()
        {
            EmployeeShifts.Clear();
            foreach (Employee employee in Employees)
            {
                foreach (EmployeeShift employeeShift in employee.EmployeeShifts)
                {
                    employeeShift.Employee = employee;
                    EmployeeShifts.Add(employeeShift);
                }
            }
        }

        public void SaveDataToDatabase()
        {
            // Save the data in the lists back to the database
        }
    }
}
