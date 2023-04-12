using Dapper;
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

namespace RicksStaffApp
{
    public class SqliteDataAccess
    {
        //public static List<Employee> LoadEmployees()
        //{
        //    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        var output = cnn.Query<Employee>("select * from Employee", new DynamicParameters());
        //        return output.ToList();
        //    }
        //}
        //public static void SaveEmpolyee(Employee employee)
        //{
        //    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        cnn.Execute("insert into Employee (FirstName, LastName) values (@FirstName, @LastName)", employee);
        //    }
        //}

        //TODO: do i need to close these connections?

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
        public static List<Employee> LoadEmployees()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var employeeDictionary = new Dictionary<int, Employee>();
                cnn.Query<Employee, Position, Employee>(
                    "select e.ID, e.FirstName, e.LastName, p.ID, p.Name " +
                    "from Employee e " +
                    "left join EmployeePositions ep on e.ID = ep.EmployeeID " +
                    "left join Positions p on ep.PositionID = p.ID",
                    (employee, position) =>
                    {
                        if (!employeeDictionary.TryGetValue(employee.ID, out var emp))
                        {
                            emp = employee;
                            emp.Positions = new List<Position>();
                            employeeDictionary.Add(emp.ID, emp);
                        }
                        if (position != null)
                            emp.Positions.Add(position);
                        return emp;
                    },
                    splitOn: "ID");

                return employeeDictionary.Values.ToList();
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

        public static List<Position> LoadPositions()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Position>("select * from Positions", new DynamicParameters());
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

        private static string LoadConnectionString (string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        public static void AddIncident(Incident incident)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Incident (ActivityID, Note, DateString, EmployeeShiftID) values (@ActivityID, @Note, @DateString, @EmployeeShiftID)", incident);
                incident.ID = cnn.ExecuteScalar<int>("select last_insert_rowid()");
            }
        }
        //public static List<Incident> LoadIncidents()
        //{
        //    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        var output = cnn.Query<Incident>("select * from Incidents", new DynamicParameters());
        //        List<Incident> incidents = new List<Incident>();
        //        foreach (var item in output)
        //        {
        //            var incidentDate = DateTime.FromBinary(item.Date);
        //            incidents.Add(new Incident
        //            {
        //                ID = item.ID,
        //                Title = item.Title,
        //                Description = item.Description,
        //                Date = new DateOnly(incidentDate.Year, incidentDate.Month, incidentDate.Day),
        //                ActivityModifiers = LoadActivityModifiers(item.ID)
        //            });
        //        }
        //        return incidents;
        //    }
        //}
        public static void DeleteIncident(int incidentId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Incidents WHERE ID = @IncidentId", new { IncidentId = incidentId });
                cnn.Execute("DELETE FROM ActivityModifiers WHERE IncidentID = @IncidentId", new { IncidentId = incidentId });
            }
        }
        public static void UpdateIncident(Incident incident)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update Incidents set ActivityID = @ActivityID, Note = @Note, Date = @Date where Id = @Id",
            new { ActivityID = incident.ActivityID, Note = incident.Note, Date = incident.Date.ToString("yyyy-MM-dd"), Id = incident.ID });

                // Delete all existing activity modifiers for this incident
                cnn.Execute("delete from ActivityModifiers where IncidentID = @IncidentID", new { IncidentID = incident.ID });

                // Insert the incident's activity modifiers into the ActivityModifiers table
                foreach (ActivityModifier modifier in incident.ActivityModifiers)
                {
                    cnn.Execute("insert into ActivityModifiers (IncidentID, Name, RatingAdjustment) values (@IncidentID, @Name, @RatingAdjustment)",
                        new { IncidentID = incident.ID, Name = modifier.Name, RatingAdjustment = modifier.RatingAdjustment });
                }
            }
        }
        //public static void SaveEmployee(Employee employee)
        //{
        //    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        cnn.Open();

        //        using (var transaction = cnn.BeginTransaction())
        //        {
        //            // Insert the employee into the Employee table
        //            cnn.Execute("insert into Employee (FirstName, LastName) values (@FirstName, @LastName)", employee);

        //            // Get the ID of the newly inserted employee
        //            int employeeId = cnn.Query<int>("select last_insert_rowid()", new DynamicParameters()).Single();

        //            // Insert the employee's positions into the EmployeePosition table
        //            foreach (Position position in employee.Positions)
        //            {
        //                cnn.Execute("insert into EmployeePositions (EmployeeId, PositionId) values (@EmployeeId, @PositionId)",
        //                    new { EmployeeId = employeeId, PositionId = position.ID });
        //            }

        //            transaction.Commit();
        //        }
        //    }
        //}
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
        public static void AddShift(Shift shift)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //string convertedString = shift.Date.ToString("MM/dd/yyyy");
                
                cnn.Execute("insert into Shift (DateString, IsAm) values (@DateString, @IsAm)", new {shift.DateString, shift.IsAm });
                shift.ID = cnn.ExecuteScalar<int>("select last_insert_rowid()");
            }

            //foreach (EmployeeShift employeeShift in shift.EmployeeShifts)
            //{
            //    employeeShift.Shift = shift; // Associate the shift with the employee shift
            //    SaveEmployeeShift(employeeShift);
            //}
        }

        public static List<Shift> LoadShifts()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "SELECT * FROM Shift";
                var result = cnn.Query<Shift>(query);
                
                return result.ToList();
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
        public static void AddEmployeeShift(EmployeeShift employeeShift)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into EmployeeShift (EmployeeID, ShiftID, ShiftRating) values (@EmployeeID, @ShiftID, @ShiftRating)", 
                    new { EmployeeID = employeeShift.Employee.ID, ShiftID = employeeShift.Shift.ID, ShiftRating = employeeShift.ShiftRating });
                    //new { EmployeeId = employeeShift.Employee.ID, PositionId = employeeShift.Position.ID, ShiftRating = employeeShift.ShiftRating });
                employeeShift.ID = cnn.ExecuteScalar<int>("select last_insert_rowid()");
            }
        }
        public static void UpdateEmployeeShift(EmployeeShift shift)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update EmployeeShift set EmployeeId = @EmployeeId, PositionId = @PositionId, ShiftRating = @ShiftRating where ID = @ID",
                    new { EmployeeId = shift.Employee.ID, ShiftRating = shift.ShiftRating, ID = shift.ID });
                //PositionId = shift.Position.ID, 
            }
        }
        public static void DeleteEmployeeShift(int shiftId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from EmployeeShift where ID = @ID", new { ID = shiftId });
            }
        }
        //public static List<EmployeeShift> LoadEmployeeShifts()
        //{
        //    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        var shiftDictionary = new Dictionary<int, EmployeeShift>();
        //        var query = cnn.Query<EmployeeShift, Employee, Shift, EmployeeShift>(
        //            "select es.ID, es.EmployeeId, e.Name, es.ShiftRating, s.ID, s.Date, s.AmShift " +
        //            "from EmployeeShift es " +
        //            "inner join Employee e on es.EmployeeId = e.ID " +
        //            "inner join Position p on es.PositionId = p.ID",
        //            (shift, employee, position) =>
        //            {
        //                if (!shiftDictionary.TryGetValue(shift.ID, out var es))
        //                {
        //                    es = shift;
        //                    es.Employee = employee;
        //                    es.Position = position;
        //                    es.Incidents = new List<Incident>();
        //                    shiftDictionary.Add(es.ID, es);
        //                }
        //                return es;
        //            },
        //            splitOn: "EmployeeId,PositionId");

        //        var shifts = shiftDictionary.Values.ToList();
        //        var incidentDictionary = new Dictionary<int, Incident>();
        //        cnn.Query<Incident, EmployeeShift, Incident>(
        //            "select i.ID, i.Description, i.RatingChange, i.Date, i.EmployeeShiftId " +
        //            "from Incident i " +
        //            "inner join EmployeeShift es on i.EmployeeShiftId = es.ID",
        //            (incident, shift) =>
        //            {
        //                if (!incidentDictionary.TryGetValue(incident.ID, out var i))
        //                {
        //                    i = incident;
        //                    i.EmployeeShift = shift;
        //                    incidentDictionary.Add(i.ID, i);
        //                }
        //                shift.Incidents.Add(i);
        //                return i;
        //            },
        //            splitOn: "EmployeeShiftId");

        //        return shifts;
        //    }
        //}
    }

}
//// Update the employee in the Employee table
//cnn.Execute("update Employee set FirstName = @FirstName, LastName = @LastName where Id = @Id",
//    new { FirstName = employee.FirstName, LastName = employee.LastName, Id = employee.ID });
