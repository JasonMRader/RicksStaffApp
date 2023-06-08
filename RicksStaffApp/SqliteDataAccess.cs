using Dapper;
using Microsoft.Office.Interop.Excel;
using RicksStaffApp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace RicksStaffApp
{
    public class SqliteDataAccess
    {
       

        //TODO: do i need to close these connections?
        //TODO: connect to the DB less often, use lists I already have loaded
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        //Employee Methods
        public static void AddEmployee(Employee employee)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();

                using (var transaction = cnn.BeginTransaction())
                {
                    // Insert the employee into the Employee table
                    cnn.Execute("insert into Employee (FirstName, LastName) values (@FirstName, @LastName)", employee);

                    // Get the ID of the newly inserted employee
                    int employeeId = cnn.Query<int>("select last_insert_rowid()", new DynamicParameters()).Single();

                    // Insert the employee's positions into the EmployeePosition table
                    foreach (Position position in employee.Positions)
                    {
                        cnn.Execute("insert into EmployeePositions (EmployeeId, PositionId) values (@EmployeeId, @PositionId)",
                            new { EmployeeId = employeeId, PositionId = position.ID });
                    }

                    transaction.Commit();
                }
                cnn.Close();
            }
        }
        public static void DeleteEmployee(int employeeId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Employee WHERE ID = @EmployeeId", new { EmployeeId = employeeId });
                cnn.Execute("DELETE FROM EmployeePositions WHERE EmployeeID = @EmployeeId", new { EmployeeId = employeeId });
            }
        }      
        public static void UpdateEmployee(Employee employee)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //cnn.Open();

                using (var transaction = cnn.BeginTransaction())
                {
                    // Update the employee in the Employee table
                    cnn.Execute("update Employee set FirstName = @FirstName, LastName = @LastName where Id = @Id",
                        new { FirstName = employee.FirstName, LastName = employee.LastName, Id = employee.ID });

                    // Delete all existing entries in the EmployeePosition table for this employee
                    cnn.Execute("delete from EmployeePosition where EmployeeId = @EmployeeId", new { EmployeeId = employee.ID });

                    // Insert the employee's positions into the EmployeePosition table
                    foreach (Position position in employee.Positions)
                    {
                        cnn.Execute("insert into EmployeePosition (EmployeeId, PositionId) values (@EmployeeId, @PositionId)",
                            new { EmployeeId = employee.ID, PositionId = position.ID });
                    }

                    transaction.Commit();
                }
            }
        }
        public static bool IsDuplicateEmployee(string firstName, string lastName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = "SELECT COUNT(*) FROM Employee WHERE FirstName = @FirstName AND LastName = @LastName";
                int count = cnn.ExecuteScalar<int>(sql, new { FirstName = firstName, LastName = lastName });
                return count > 0;
            }
        }
        //Position Methods
        public static List<Position> LoadPositions()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Position>("select * from Position", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void AddPosition(Position position)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Positions (Name) values (@Name)", position);
            }
        }

        //Incident Methods
        public static void AddIncident(Incident incident)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Incident (ActivityID, Note, DateString, EmployeeShiftID) values (@ActivityID, @Note, @DateString, @EmployeeShiftID)", incident);
                incident.ID = cnn.ExecuteScalar<int>("select last_insert_rowid()");
            }
        }       
        public static void DeleteIncident(int incidentId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Incidents WHERE ID = @IncidentId", new { IncidentId = incidentId });
                cnn.Execute("DELETE FROM ActivityModifiers WHERE IncidentID = @IncidentId", new { IncidentId = incidentId });
            }
        }
        public static void DeleteIncidentsByEmployeeShiftID(int employeeShiftID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from Incident where EmployeeShiftID = @EmployeeShiftID", new { EmployeeShiftID = employeeShiftID });
            }
        }
        public static void DeleteIncidentsByEmployeeShifts(int shiftID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // Retrieve the employee shift IDs associated with the shift ID
                List<int> employeeShiftIDs = cnn.Query<int>("SELECT ID FROM EmployeeShift WHERE ShiftID = @ShiftID", new { ShiftID = shiftID }).ToList();

                // Delete the incidents associated with the employee shift IDs
                foreach (int employeeShiftID in employeeShiftIDs)
                {
                    cnn.Execute("DELETE FROM Incident WHERE EmployeeShiftID = @EmployeeShiftID", new { EmployeeShiftID = employeeShiftID });
                }
            }
        }

        public static void SaveEmployeeShiftIncidents(EmployeeShift employeeShift)
        {
            // First, delete all existing incidents associated with the employeeShift
            DeleteIncidentsByEmployeeShiftID(employeeShift.ID);

            // Now, add the updated list of incidents
            foreach (Incident incident in employeeShift.Incidents)
            {
                // If the incident already has an ID, update it, otherwise, add it as a new incident
                if (incident.IncidentID > 0)
                {
                    UpdateIncident(incident);
                }
                else
                {
                    incident.EmployeeShiftID = employeeShift.ID;
                    AddIncident(incident);
                }
            }
        }                     
        public static void UpdateIncident(Incident incident)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update Incident set ActivityID = @ActivityID, Note = @Note, DateString = @DateString where Id = @IncidentId",
            new { ActivityID = incident.ID, Note = incident.Note, DateString = incident.DateString, Id = incident.ID });

                // Delete all existing activity modifiers for this incident
                //cnn.Execute("delete from ActivityModifier where IncidentID = @IncidentID", new { IncidentID = incident.ID });

                // Insert the incident's activity modifiers into the ActivityModifiers table
                //foreach (ActivityModifier modifier in incident.ActivityModifiers)
                //{
                //    cnn.Execute("insert into ActivityModifier (IncidentID, Name, RatingAdjustment) values (@IncidentID, @Name, @RatingAdjustment)",
                //        new { IncidentID = incident.ID, Name = modifier.Name, RatingAdjustment = modifier.RatingAdjustment });
                //}
            }
        }

        //Activity Methods
        public static void AddActivity(Activity activity)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();

                using (var transaction = cnn.BeginTransaction())
                {
                    // Insert the activity into the Activity table
                    cnn.Execute("insert into Activity (Name, BaseRatingImpact) values (@Name, @BaseRatingImpact)", activity);

                    // Get the ID of the newly inserted activity
                    int activityId = cnn.Query<int>("select last_insert_rowid()", new DynamicParameters()).Single();
                    if (activity.ActivityModifiers != null && activity.ActivityModifiers.Count > 0)
                    {
                        foreach (ActivityModifier modifier in activity.ActivityModifiers)
                        {
                            cnn.Execute("insert into ActivityModifier (ActivityId, ModifierId) values (@ActivityId, @ModifierId)",
                                new { ActivityId = activityId, ModifierId = modifier.ID });
                        }
                    }
                    


                    transaction.Commit();
                }
                cnn.Close();
            }
        }
        public static void DeleteActivity(int activityId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Activity WHERE ID = @ActivityId", new { ActivityId = activityId });
                cnn.Execute("DELETE FROM ActivityModifier WHERE ActivityID = @ActivityId", new { ActivityId = activityId });
            }
        }               
        public static List<Activity> LoadActivities()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var activityDictionary = new Dictionary<int, Activity>();
                cnn.Query<Activity, ActivityModifier, Activity>(
                    "select a.ID, a.Name, a.BaseRatingImpact, am.ID, am.Name " +
                    "from Activity a " +
                    "left join ActivityModifier am on a.ID = am.ActivityID",
                    (activity, modifier) =>
                    {
                        if (!activityDictionary.TryGetValue(activity.ID, out var act))
                        {
                            act = activity;
                            act.ActivityModifiers = new List<ActivityModifier>();
                            activityDictionary.Add(act.ID, act);
                        }
                        if (modifier != null)
                        {
                            act.ActivityModifiers.Add(modifier);
                        }
                        return act;
                    },
                    splitOn: "ID");

                return activityDictionary.Values.ToList();
            }
        }

        //Activity Mod Methods
        public static void AddActivityModifier(ActivityModifier modifier)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into ActivityModifier (ActivityId, Name, RatingAdjustment) values (@ActivityId, @Name, @RatingAdjustment)",
                    new { ActivityId = modifier.ActivityID, Name = modifier.Name, RatingAdjustment = modifier.RatingAdjustment });
            }
        }
        public static void DeleteActivityModifier(int modifierId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM ActivityModifier WHERE ID = @ModifierId", new { ModifierId = modifierId });
                cnn.Execute("DELETE FROM ActivityModifier WHERE ModifierID = @ModifierId", new { ModifierId = modifierId });
            }
        }
        public static List<ActivityModifier> LoadActivityModifiers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ActivityModifier>("select * from ActivityModifier", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<ActivityModifier> LoadActivityModifiers(int incidentID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ActivityModifier>("select * from ActivityModifier where IncidentID = @IncidentID", new { IncidentID = incidentID });
                return output.ToList();
            }
        }

        //Shift Methods
        public static int AddShift(Shift shift)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
               
                // Check if a record with the same DateString and IsAm already exists
                string checkExistingShiftQuery = "SELECT COUNT(*) FROM Shift WHERE DateString = @DateString AND IsAm = @IsAm";
                int count = cnn.ExecuteScalar<int>(checkExistingShiftQuery, new { shift.DateString, shift.IsAm });

                // If no such record exists, insert the new shift
                if (count == 0)
                {
                    cnn.Execute("INSERT INTO Shift (DateString, IsAm) VALUES (@DateString, @IsAm)", new { shift.DateString, shift.IsAm });
                    shift.ID = cnn.ExecuteScalar<int>("SELECT last_insert_rowid()");
                }
                else
                {
                    // Optional: You can throw an exception or return a boolean value to indicate that the shift was not added.
                    throw new InvalidOperationException("A shift with the same Date and Am / Pm values already exists.");
                }
                
                return shift.ID;
                
            }

            //foreach (EmployeeShift employeeShift in shift.EmployeeShifts)
            //{
            //    employeeShift.Shift = shift; // Associate the shift with the employee shift
            //    SaveEmployeeShift(employeeShift);
            //}
        }
        public static Shift LoadShift(bool isAm, string dateString)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "SELECT * FROM Shift WHERE IsAm = @IsAm AND DateString = @DateString";
                Shift shift = cnn.QueryFirstOrDefault<Shift>(query, new { IsAm = isAm, DateString = dateString });

                if (shift == null)
                {
                    throw new InvalidOperationException("No shift with the specified Date and Am / Pm values was found.");
                }

                return shift;
            }
        }             
        public static List<Shift> LoadShifts()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "SELECT * FROM Shift";
                var shifts = cnn.Query<Shift>(query).AsList();

                string employeeShiftQuery = @"
                    SELECT es.*, e.*, p.*, i.*
                    FROM EmployeeShift es
                    INNER JOIN Employee e ON es.EmployeeID = e.ID
                    INNER JOIN Position p ON es.PositionID = p.ID
                    LEFT JOIN Incident i ON es.ID = i.EmployeeShiftID   
                    WHERE es.ShiftID = @ShiftID";

                
                foreach (var shift in shifts)
                {
                    var employeeShiftsDictionary = new Dictionary<int, EmployeeShift>();

                    var employeeShifts = cnn.Query<EmployeeShift, Employee, Position, Incident, EmployeeShift>(employeeShiftQuery,
                        (employeeShift, employee, position, incident) =>
                        {
                            // Check if the employee shift is already added to the dictionary
                            if (!employeeShiftsDictionary.TryGetValue(employeeShift.ID, out var currentEmployeeShift))
                            {
                                currentEmployeeShift = employeeShift;
                                currentEmployeeShift.Employee = employee;
                                currentEmployeeShift.Position = position;
                                currentEmployeeShift.Incidents = new List<Incident>();
                                employeeShiftsDictionary.Add(currentEmployeeShift.ID, currentEmployeeShift);
                            }

                            // Add the incident to the employee shift if it exists
                            if (incident != null && incident.ID != default)
                            {
                                currentEmployeeShift.Incidents.Add(incident);
                            }

                            return currentEmployeeShift;
                        },
                        new { ShiftID = shift.ID },
                        splitOn: "ID,ID,ID").Distinct().AsList();

                    shift.EmployeeShifts = employeeShifts;
                }
                List<Activity> activities = LoadActivities();
                Incident.AssignActivitiesToIncidents_REPLACE(shifts, activities);
                return shifts;
            }
        }
        public static List<EmployeeShift> AssignShiftsToEmployeeShifts(List<EmployeeShift> employeeShifts)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = @"
            SELECT es.*, s.*
            FROM EmployeeShift es
            INNER JOIN Shift s ON es.ShiftID = s.ID
            WHERE es.ShiftID IN @ShiftIDs";

                var shiftIDs = employeeShifts.Select(es => es.Shift.ID).Distinct();
                var result = connection.Query<EmployeeShift, Shift, EmployeeShift>(query,
                    (employeeShift, shift) =>
                    {
                        employeeShift.Shift = shift;
                        return employeeShift;
                    },
                    new { ShiftIDs = shiftIDs },
                    splitOn: "ID").ToList();

                return result;
            }
        }

        public static List<Employee> TestLoadEmployees()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "SELECT * FROM Employee";
                var employees = cnn.Query<Employee>(query).AsList();
                /*
                 * es.ID as EmployeeShiftID,
                    s.ID as ShiftID,
                    p.ID as PositionID,
                    i.ID as IncidentID
                 * 
                 */
                string shiftQuery = "SELECT * FROM Shift WHERE ID = @ShiftID";
                string employeeShiftQuery = @"
                    SELECT es.*, s.*, p.*, i.*
                    
                    
                    FROM EmployeeShift es
                    LEFT JOIN Shift s ON es.ShiftID = s.ID
                    INNER JOIN Position p ON es.PositionID = p.ID
                    LEFT JOIN Incident i ON es.ID = i.EmployeeShiftID   
                    WHERE es.EmployeeID = @EmployeeID";
                foreach (var employee in employees)
                {
                    var employeeShiftsDictionary = new Dictionary<int, EmployeeShift>();

                    var employeeShifts = cnn.Query<EmployeeShift, Employee, Position, Incident, EmployeeShift>(employeeShiftQuery,
                        (employeeShift, employee, position, incident) =>
                        {
                            // Check if the employee shift is already added to the dictionary
                            if (!employeeShiftsDictionary.TryGetValue(employeeShift.ID, out var currentEmployeeShift))
                            {
                                currentEmployeeShift = employeeShift;
                                currentEmployeeShift.Employee = employee;
                                
                                currentEmployeeShift.Position = position;
                                currentEmployeeShift.Incidents = new List<Incident>();
                                employeeShiftsDictionary.Add(currentEmployeeShift.ID, currentEmployeeShift);
                            }

                            // Add the incident to the employee shift if it exists
                            if (incident != null && incident.ID != default)
                            {
                                currentEmployeeShift.Incidents.Add(incident);
                            }

                            return currentEmployeeShift;
                        },
                        new { EmployeeID = employee.ID },
                        splitOn: "ID, ID, ID").Distinct().AsList();
                    foreach (var employeeShift in employeeShifts)
                    {
                        // Retrieve the shift object
                        var shift = cnn.QueryFirstOrDefault<Shift>(shiftQuery, new { ShiftID = employeeShift.ShiftID });

                        // Assign the shift to the employeeShift
                        employeeShift.Shift = shift;
                    }



                    employee.EmployeeShifts = employeeShifts;
                }
                //TODO: remove LoadActivities() from here
                List<Activity> activities = LoadActivities();
                

                Incident.AssignActivitiesToEmployeeIncidents(employees, activities);
                return employees;

                
            }
        }
        //TODO -Fix this
        public static List<Employee> LoadEmployees()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //string query = "SELECT * FROM Employee";
                //var employees = cnn.Query<Employee>(query).AsList();

                var employeeDictionary = new Dictionary<int, Employee>();
                cnn.Query<Employee, Position, Employee>(
                    "select e.ID, e.FirstName, e.LastName, p.ID as PositionID, p.Name " +
                    "from Employee e " +
                    "left join EmployeePosition ep on e.ID = ep.EmployeeID " +
                    "left join Position p on ep.PositionID = p.ID",
                    (employee, position) =>
                    {
                        if (!employeeDictionary.TryGetValue(employee.ID, out var emp))
                        {
                            emp = employee;
                            emp.Positions = new List<Position>();
                            emp.EmployeeShifts = new List<EmployeeShift>();
                            employeeDictionary.Add(emp.ID, emp);
                        }
                        if (position != null)
                            emp.Positions.Add(position);
                        return emp;
                    },
                    splitOn: "PositionID");

                var employees = employeeDictionary.Values.ToList();

                foreach (var employee in employees)
                {

                    string employeeShiftsQuery =
                        @"SELECT es.ID, es.EmployeeID, es.ShiftID, es.PositionID,
                        s.ID as ShiftID, s.DateString, s.IsAm,
                        p.ID as PositionID, p.Name,
                        i.ID as IncidentID, i.Note, i.EmployeeShiftID as IncidentEmployeeShiftID
                        FROM EmployeeShift es
                        JOIN Shift s ON es.ShiftID = s.ID
                        JOIN Position p ON es.PositionID = p.ID
                        LEFT JOIN Incident i ON es.ID = i.EmployeeShiftID
                        WHERE es.EmployeeID = @EmployeeID";



                    var employeeShiftsDictionary = new Dictionary<int, EmployeeShift>();

                    cnn.Query<EmployeeShift, Shift, Position, Incident, EmployeeShift>(employeeShiftsQuery,
                        (employeeShift, shift, position, incident) =>
                        {
                            if (!employeeShiftsDictionary.TryGetValue(employeeShift.ID, out var currentEmployeeShift))
                            {
                                currentEmployeeShift = employeeShift;
                                currentEmployeeShift.Employee = employee;
                                currentEmployeeShift.Shift = shift;      
                                currentEmployeeShift.Position = position;
                                currentEmployeeShift.Incidents = new List<Incident>();
                                
                                employeeShiftsDictionary.Add(currentEmployeeShift.ID, currentEmployeeShift);
                            }
                            //if (incident != null && incident.ID != default)
                            if (incident != null && incident.ID != default)
                            {
                                currentEmployeeShift.Incidents.Add(incident);
                            }

                            return currentEmployeeShift;
                        },
                        new { EmployeeID = employee.ID },
                        //splitOn: "ShiftID,PositionID,IncidentID")
                        splitOn: "ShiftID, PositionID, IncidentEmployeeShiftID").Distinct().AsList();

                    employee.EmployeeShifts = employeeShiftsDictionary.Values.ToList();
                }

                return employeeDictionary.Values.ToList();
            }
        }
        public static void UpdateShift(Shift shift)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update Shift set Date = @Date, IsAM = @IsAM where ShiftID = @ShiftID", shift);
            }

            // Delete all existing employee shifts for this shift and add the new ones
            DeleteEmployeeShift(shift.ID);
            foreach (EmployeeShift employeeShift in shift.EmployeeShifts)
            {
                employeeShift.Shift = shift; // Associate the shift with the employee shift
                AddEmployeeShift(employeeShift);
            }
        }
        public static void DeleteShift(int shiftID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE from Shift WHERE ID = @ShiftID", new { ShiftId = shiftID});
                //cnn.Execute("delete from Shift where ShiftID = @ShiftID", shift);
            }
        }
        public static void DeleteShiftAndChildren(int shiftID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // Delete the employee shifts associated with the shift
                DeleteEmployeeShiftsByShiftId(shiftID);

                // Delete the incidents associated with the deleted employee shifts
                DeleteIncidentsByEmployeeShifts(shiftID);

                // Delete the shift
                cnn.Execute("DELETE FROM Shift WHERE ID = @ShiftID", new { ShiftId = shiftID });
            }
        }


        //EmployeeShift Methods
        public static List<EmployeeShift> LoadEmployeeShifts(Employee employee)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string employeeShiftsQuery =
                    @"SELECT es.*, s.*, p.*, i.*
            FROM EmployeeShift es
            JOIN Shift s ON es.ShiftID = s.ID
            JOIN Position p ON es.PositionID = p.ID
            LEFT JOIN Incident i ON es.ID = i.EmployeeShiftID
            WHERE es.EmployeeID = @EmployeeID";

                var employeeShiftsDictionary = new Dictionary<int, EmployeeShift>();

                var employeeShifts = cnn.Query<EmployeeShift, Shift, Position, Incident, EmployeeShift>(
                    employeeShiftsQuery,
                    (employeeShift, shift, position, incident) =>
                    {
                        if (!employeeShiftsDictionary.TryGetValue(employeeShift.ID, out var currentEmployeeShift))
                        {
                            currentEmployeeShift = employeeShift;
                            currentEmployeeShift.Employee = employee;
                            currentEmployeeShift.Shift = shift;
                            currentEmployeeShift.Position = position;
                            currentEmployeeShift.Incidents = new List<Incident>();
                            employeeShiftsDictionary.Add(currentEmployeeShift.ID, currentEmployeeShift);
                        }

                        if (incident != null && incident.ID != default && !currentEmployeeShift.Incidents.Any(i => i.ID == incident.ID))
                        {
                            currentEmployeeShift.Incidents.Add(incident);
                        }

                        return currentEmployeeShift;
                    },
                    new { EmployeeID = employee.ID },
                    splitOn: "ID,ID,ID").Distinct().AsList();

                return employeeShifts;
            }
        }
        public static void AddEmployeeShift(EmployeeShift employeeShift)
        {

            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("insert into EmployeeShift (EmployeeID, ShiftID, PositionID) values (@EmployeeID, @ShiftID, @PositionID)",
                        new { EmployeeID = employeeShift.Employee.ID, ShiftID = employeeShift.Shift.ID, employeeShift.PositionID });
                    //new { EmployeeId = employeeShift.Employee.ID, PositionId = employeeShift.Position.ID, ShiftRating = employeeShift.ShiftRating });
                    employeeShift.ID = cnn.ExecuteScalar<int>("select last_insert_rowid()");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error adding employee shift: " + ex.Message);
            }
        }
        public static void UpdateEmployeeShift(EmployeeShift shift)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update EmployeeShift set EmployeeId = @EmployeeId, PositionId = @PositionId, where ID = @ID",
                    new { EmployeeId = shift.Employee.ID, ID = shift.ID });
                //PositionId = shift.Position.ID, 
            }
        }
        public static void DeleteEmployeeShift(int EmployeeShiftId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from EmployeeShift where ID = @ID", new { ID = EmployeeShiftId });
            }
        }
        public static void DeleteEmployeeShiftsByShiftId(int shiftId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from EmployeeShift where ShiftID = @ShiftID", new { ShiftID = shiftId });
            }

        }
        
    //write a method to load the employee shifts
    
    }

}
//// Update the employee in the Employee table
//cnn.Execute("update Employee set FirstName = @FirstName, LastName = @LastName where Id = @Id",
//    new { FirstName = employee.FirstName, LastName = employee.LastName, Id = employee.ID });
