using Dapper;
using RicksStaffApp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
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

        public static void SaveEmployee(Employee employee)
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

        public static void SavePosition(Position position)
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
        public static void SaveIncident(Incident incident)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Incidents (Title, Description, Date) values (@Title, @Description, @Date)", incident);
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
        public static void SaveActivity(Activity activity)
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

        public static void SaveActivityModifier(ActivityModifier modifier)
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




    }

}
//// Update the employee in the Employee table
//cnn.Execute("update Employee set FirstName = @FirstName, LastName = @LastName where Id = @Id",
//    new { FirstName = employee.FirstName, LastName = employee.LastName, Id = employee.ID });
