using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksStaffApp
{
    public class DataSingleton
    {
        private static DataSingleton instance;
        public List<Employee> Employees { get; private set; }
        public List<Shift> Shifts { get; private set; }
        public List<Incident> Incidents { get; private set; }
        public List<string> ignoredExcelCells { get; private set; }
        // ... other lists

        private DataSingleton()
        {
            Employees = new List<Employee>();
            Shifts = new List<Shift>();
            Incidents = new List<Incident>();
            // ... initialize other lists
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
            ignoredExcelCells = SqliteDataAccess.LoadExcelIgnore();
        }

        public void SaveDataToDatabase()
        {
            // Save the data in the lists back to the database
        }
    }
}
