﻿using Dapper;
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
        //public static List<Employee> LoadEmployees()
        //{
        //    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        var employeeDictionary = new Dictionary<int, Employee>();
        //        cnn.Query<Employee, Position, Employee>(
        //            "select e.ID, e.FirstName, e.LastName, p.ID as PositionID, p.Name " +
        //            "from Employee e " +
        //            "left join EmployeePositions ep on e.ID = ep.EmployeeID " +
        //            "left join Positions p on ep.PositionID = p.ID",
        //            (employee, position) =>
        //            {
        //                if (!employeeDictionary.TryGetValue(employee.ID, out var emp))
        //                {
        //                    emp = employee;
        //                    emp.Positions = new List<Position>();
        //                    emp.EmployeeShifts = new List<EmployeeShift>();
        //                    employeeDictionary.Add(emp.ID, emp);
        //                }
        //                if (position != null)
        //                    emp.Positions.Add(position);
        //                return emp;
        //            },
        //            splitOn: "PositionID");

        //        var employees = employeeDictionary.Values.ToList();

        //        foreach (var employee in employees)
        //        {
        //            string employeeShiftsQuery = 
        //                @"SELECT es.ID, es.EmployeeID, es.ShiftID, es.PositionID,
        //                s.ID as ShiftID, s.DateString, s.IsAm,
        //                p.ID as PositionID, p.Name
        //                FROM EmployeeShift es
        //                JOIN Shift s ON es.ShiftID = s.ID
        //                JOIN Positions p ON es.PositionID = p.ID
        //                WHERE es.EmployeeID = @EmployeeID";
        //            var employeeShifts = cnn.Query<EmployeeShift, Shift, Position, EmployeeShift>(employeeShiftsQuery,
        //                (employeeShift, shift, position) =>
        //                {
        //                    employeeShift.Shift = shift;
        //                    employeeShift.Position = position;
        //                    return employeeShift;
        //                },
        //                new { EmployeeID = employee.ID },
        //                splitOn: "ShiftID,PositionID")
        //                .AsList();

        //            employee.EmployeeShifts = employeeShifts;
        //        }

        //        return employeeDictionary.Values.ToList();
        //    }


        //}

        //public static List<Employee> LoadEmployees()
        //{
        //    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        var employeeDictionary = new Dictionary<int, Employee>();
        //        cnn.Query<Employee, Position, Employee>(
        //            "select e.ID, e.FirstName, e.LastName, p.ID as PositionID, p.Name " +
        //            "from Employee e " +
        //            "left join EmployeePositions ep on e.ID = ep.EmployeeID " +
        //            "left join Positions p on ep.PositionID = p.ID",
        //            (employee, position) =>
        //            {
        //                if (!employeeDictionary.TryGetValue(employee.ID, out var emp))
        //                {
        //                    emp = employee;
        //                    emp.Positions = new List<Position>();
        //                    employeeDictionary.Add(emp.ID, emp);
        //                }
        //                if (position != null)
        //                    emp.Positions.Add(position);
        //                return emp;
        //            },
        //            splitOn: "PositionID");

        //        return employeeDictionary.Values.ToList();
        //    }
        //}




        //public static List<Employee> LoadEmployees()
        //{
        //    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        var employeeDictionary = new Dictionary<int, Employee>();
        //        cnn.Query<Employee, Position, Employee>(
        //            "select e.ID, e.FirstName, e.LastName, p.ID as PositionID, p.Name " +
        //            "from Employee e " +
        //            "left join EmployeePositions ep on e.ID = ep.EmployeeID " +
        //            "left join Positions p on ep.PositionID = p.ID",
        //            (employee, position) =>
        //            {
        //                if (!employeeDictionary.TryGetValue(employee.ID, out var emp))
        //                {
        //                    emp = employee;
        //                    emp.Positions = new List<Position>();
        //                    emp.EmployeeShifts = new List<EmployeeShift>();
        //                    employeeDictionary.Add(emp.ID, emp);
        //                }
        //                if (position != null)
        //                    emp.Positions.Add(position);
        //                return emp;
        //            },
        //            splitOn: "PositionID");

        //        var employees = employeeDictionary.Values.ToList();

        //        foreach (var employee in employees)
        //        {
        //            //string employeeShiftsQuery =
        //            //    @"SELECT es.ID, es.EmployeeID, es.ShiftID, es.PositionID,
        //            //    s.ID as ShiftID, s.DateString, s.IsAm,
        //            //    p.ID as PositionID, p.Name,
        //            //    i.ID as IncidentID, i.Note, i.EmployeeShiftID
        //            //    FROM EmployeeShift es
        //            //    JOIN Shift s ON es.ShiftID = s.ID
        //            //    JOIN Positions p ON es.PositionID = p.ID
        //            //    LEFT JOIN Incident i ON es.ID = i.EmployeeShiftID
        //            //    WHERE es.EmployeeID = @EmployeeID";
        //            string employeeShiftsQuery =
        //                @"SELECT es.ID, es.EmployeeID, es.ShiftID, es.PositionID,
        //                s.ID as ShiftID, s.DateString, s.IsAm,
        //                p.ID as PositionID, p.Name,
        //                i.ID as IncidentID, i.Note, i.EmployeeShiftID as IncidentEmployeeShiftID
        //                FROM EmployeeShift es
        //                JOIN Shift s ON es.ShiftID = s.ID
        //                JOIN Positions p ON es.PositionID = p.ID
        //                LEFT JOIN Incident i ON es.ID = i.EmployeeShiftID
        //                WHERE es.EmployeeID = @EmployeeID";


        //            var employeeShiftsDictionary = new Dictionary<int, EmployeeShift>();

        //            cnn.Query<EmployeeShift, Shift, Position, Incident, EmployeeShift>(employeeShiftsQuery,
        //                (employeeShift, shift, position, incident) =>
        //                {
        //                    if (!employeeShiftsDictionary.TryGetValue(employeeShift.ID, out var currentEmployeeShift))
        //                    {
        //                        currentEmployeeShift = employeeShift;
        //                        currentEmployeeShift.Shift = shift;
        //                        currentEmployeeShift.Position = position;
        //                        currentEmployeeShift.Incidents = new List<Incident>();
        //                        employeeShiftsDictionary.Add(currentEmployeeShift.ID, currentEmployeeShift);
        //                    }
        //                    //if (incident != null && incident.ID != default)
        //                    if (incident != null && incident.ID != default && !currentEmployeeShift.Incidents.Any(i => i.ID == incident.ID))
        //                    {
        //                        currentEmployeeShift.Incidents.Add(incident);
        //                    }

        //                    return currentEmployeeShift;
        //                },
        //                new { EmployeeID = employee.ID },
        //                //splitOn: "ShiftID,PositionID,IncidentID")
        //                splitOn: "ShiftID,PositionID,IncidentEmployeeShiftID")

        //                .Distinct().AsList();

        //            employee.EmployeeShifts = employeeShiftsDictionary.Values.ToList();
        //        }

        //        return employeeDictionary.Values.ToList();
        //    }
        //}

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

        //Incident Methods
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
        public static void DeleteIncidentsByEmployeeShiftID(int employeeShiftID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from Incident where EmployeeShiftID = @EmployeeShiftID", new { EmployeeShiftID = employeeShiftID });
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
                //cnn.Open();

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

        //public static List<Shift> LoadShifts()
        //{
        //    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        string query = "SELECT * FROM Shift";
        //        var shifts = cnn.Query<Shift>(query).AsList();

        //        string employeeShiftQuery = @"
        //    SELECT es.*, e.*, p.*, i.*, a.*, am.*
        //    FROM EmployeeShift es
        //    INNER JOIN Employee e ON es.EmployeeID = e.ID
        //    INNER JOIN Positions p ON es.PositionID = p.ID
        //    LEFT JOIN Incident i ON es.ID = i.EmployeeShiftID
        //    LEFT JOIN Activity a ON i.ID = a.ID
        //    LEFT JOIN ActivityModifier am ON a.ID = am.ActivityID
        //    WHERE es.ShiftID = @ShiftID";

        //        foreach (var shift in shifts)
        //        {
        //            var employeeShiftsDictionary = new Dictionary<int, EmployeeShift>();

        //            var employeeShifts = cnn.Query<EmployeeShift, Employee, Position, Incident, ActivityModifier, EmployeeShift>(employeeShiftQuery,
        //                (employeeShift, employee, position, incident, activityModifier) =>
        //                {
        //                    if (!employeeShiftsDictionary.TryGetValue(employeeShift.ID, out var currentEmployeeShift))
        //                    {
        //                        currentEmployeeShift = employeeShift;
        //                        currentEmployeeShift.Employee = employee;
        //                        currentEmployeeShift.Position = position;
        //                        currentEmployeeShift.Incidents = new List<Incident>();
        //                        employeeShiftsDictionary.Add(currentEmployeeShift.ID, currentEmployeeShift);
        //                    }

        //                    if (incident != null && incident.ID != default)
        //                    {
        //                        incident.ActivityModifiers = incident.ActivityModifiers ?? new List<ActivityModifier>();
        //                        if (activityModifier != null && activityModifier.ID != default)
        //                        {
        //                            incident.ActivityModifiers.Add(activityModifier);
        //                        }

        //                        if (!currentEmployeeShift.Incidents.Exists(x => x.ID == incident.ID))
        //                        {
        //                            currentEmployeeShift.Incidents.Add(incident);
        //                        }
        //                    }

        //                    return currentEmployeeShift;
        //                },
        //                new { ShiftID = shift.ID },
        //                splitOn: "ID,ID,ID,ID").Distinct().AsList();

        //            shift.EmployeeShifts = employeeShifts;
        //        }
        //        return shifts;
        //    }
        //}

        //    foreach (var shift in shifts)
        //        {
        //            var employeeShiftsDictionary = new Dictionary<int, EmployeeShift>();

        //            var employeeShifts = cnn.Query<EmployeeShift, Employee, Position, Incident, Activity, ActivityModifier, EmployeeShift>(employeeShiftQuery,
        //                (employeeShift, employee, position, incident, activity, activityModifier) =>
        //                {
        //                    if (!employeeShiftsDictionary.TryGetValue(employeeShift.ID, out var currentEmployeeShift))
        //                    {
        //                        currentEmployeeShift = employeeShift;
        //                        currentEmployeeShift.Employee = employee;
        //                        currentEmployeeShift.Position = position;
        //                        currentEmployeeShift.Incidents = new List<Incident>();
        //                        employeeShiftsDictionary.Add(currentEmployeeShift.ID, currentEmployeeShift);
        //                    }

        //                    if (incident != null && incident.ID != default)
        //                    {
        //                        if (activity != null && activity.ID != default)
        //                        {
        //                            incident.Name = activity.Name;
        //                            incident.AdjustedRatingChange = activity.AdjustedRatingChange;
        //                            incident.BaseRatingImpact = activity.BaseRatingImpact;
        //                            incident.ActivityModifiers = incident.ActivityModifiers ?? new List<ActivityModifier>();

        //                            if (activityModifier != null)
        //                            {
        //                                incident.ActivityModifiers.Add(activityModifier);
        //                            }
        //                        }
        //                        currentEmployeeShift.Incidents.Add(incident);
        //                    }

        //                    return currentEmployeeShift;
        //                },
        //                new { ShiftID = shift.ID },
        //                splitOn: "ID,ID,ID,ID,ActivityID,ID").Distinct().AsList();

        //            shift.EmployeeShifts = employeeShifts;
        //        }

        //        return shifts;
        //    }
        //}


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
                    INNER JOIN Positions p ON es.PositionID = p.ID
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
                Incident.AssignActivitiesToIncidents(shifts, activities);
                return shifts;
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
                    "left join EmployeePositions ep on e.ID = ep.EmployeeID " +
                    "left join Positions p on ep.PositionID = p.ID",
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
                        JOIN Positions p ON es.PositionID = p.ID
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
        //EmployeeShift Methods
        //public static List<EmployeeShift> LoadEmployeeShifts(Employee employee)
        //{
        //    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        string employeeShiftsQuery =
        //            @"SELECT es.ID, es.EmployeeID, es.ShiftID, es.PositionID,
        //    s.ID as ShiftID, s.DateString, s.IsAm,
        //    p.ID as PositionID, p.Name,
        //    i.ID as IncidentID, i.Note, i.EmployeeShiftID as IncidentEmployeeShiftID
        //    FROM EmployeeShift es
        //    JOIN Shift s ON es.ShiftID = s.ID
        //    JOIN Positions p ON es.PositionID = p.ID
        //    LEFT JOIN Incident i ON es.ID = i.EmployeeShiftID
        //    WHERE es.EmployeeID = @EmployeeID";

        //        var employeeShiftsDictionary = new Dictionary<int, EmployeeShift>();

        //        cnn.Query<EmployeeShift, Shift, Position, Incident, EmployeeShift>(employeeShiftsQuery,
        //            (employeeShift, shift, position, incident) =>
        //            {
        //                if (!employeeShiftsDictionary.TryGetValue(employeeShift.ID, out var currentEmployeeShift))
        //                {
        //                    currentEmployeeShift = employeeShift;
        //                    currentEmployeeShift.Shift = shift;
        //                    currentEmployeeShift.Position = position;
        //                    currentEmployeeShift.Incidents = new List<Incident>();
        //                    employeeShiftsDictionary.Add(currentEmployeeShift.ID, currentEmployeeShift);
        //                }
        //                if (incident != null && incident.ID != default && !currentEmployeeShift.Incidents.Any(i => i.ID == incident.ID))
        //                {
        //                    currentEmployeeShift.Incidents.Add(incident);
        //                }

        //                return currentEmployeeShift;
        //            },
        //            new { EmployeeID = employee.ID },
        //            splitOn: "ShiftID,PositionID,IncidentEmployeeShiftID")

        //            .Distinct().AsList();

        //        return employeeShiftsDictionary.Values.ToList();
        //    }
        //}
        //TODO attempting to fix the load employee shifts method to include the new incident class
        //public static List<EmployeeShift> LoadEmployeeShifts(Employee employee)
        //{
        //    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        string employeeShiftsQuery =
        //            @"SELECT es.ID, es.EmployeeID, es.ShiftID, es.PositionID,
        //    s.ID as ShiftID, s.DateString, s.IsAm,
        //    p.ID as PositionID, p.Name,
        //    i.ID as IncidentID, i.Note, i.EmployeeShiftID as IncidentEmployeeShiftID
        //    FROM EmployeeShift es
        //    JOIN Shift s ON es.ShiftID = s.ID
        //    JOIN Positions p ON es.PositionID = p.ID
        //    LEFT JOIN Incident i ON es.ID = i.EmployeeShiftID
        //    WHERE es.EmployeeID = @EmployeeID";

        //        var employeeShiftsDictionary = new Dictionary<int, EmployeeShift>();

        //        cnn.Query<EmployeeShift, Shift, Position, Incident, EmployeeShift>(employeeShiftsQuery,
        //            (employeeShift, shift, position, incident) =>
        //            {
        //                if (!employeeShiftsDictionary.TryGetValue(employeeShift.ID, out var currentEmployeeShift))
        //                {
        //                    currentEmployeeShift = employeeShift;
        //                    currentEmployeeShift.Shift = shift;
        //                    currentEmployeeShift.Position = position;
        //                    currentEmployeeShift.Incidents = new List<Incident>();
        //                    employeeShiftsDictionary.Add(currentEmployeeShift.ID, currentEmployeeShift);
        //                }
        //                if (incident != null && incident.ID != default && !currentEmployeeShift.Incidents.Any(i => i.ID == incident.ID))
        //                {
        //                    currentEmployeeShift.Incidents.Add(incident);
        //                }

        //                return currentEmployeeShift;
        //            },
        //            new { EmployeeID = employee.ID },
        //            splitOn: "ID,ID,ID") // Changed from "ShiftID,PositionID,IncidentEmployeeShiftID" to "ID,ID,ID"
        //            .Distinct().AsList();

        //        return employeeShiftsDictionary.Values.ToList();
        //    }
        //}
        public static List<EmployeeShift> LoadEmployeeShifts(Employee employee)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string employeeShiftsQuery =
                    @"SELECT es.*, s.*, p.*, i.*
            FROM EmployeeShift es
            JOIN Shift s ON es.ShiftID = s.ID
            JOIN Positions p ON es.PositionID = p.ID
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
                    cnn.Execute("insert into EmployeeShift (EmployeeID, ShiftID, ShiftRating, PositionID) values (@EmployeeID, @ShiftID, @ShiftRating, @PositionID)",
                        new { EmployeeID = employeeShift.Employee.ID, ShiftID = employeeShift.Shift.ID, ShiftRating = employeeShift.ShiftRating, employeeShift.PositionID });
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
        //public static void LoadEmployeeShifts()
        //{
        //    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        var shiftDictionary = new Dictionary<int, EmployeeShift>();
        //        var query = cnn.Query<EmployeeShift, Employee, Shift, EmployeeShift>(
        //                            "select es.ID, es.EmployeeId, e.Name, es.ShiftRating, s.ID, s.Date, s.AmShift " +
        //                            "from EmployeeShift es " +
        //                            "inner join Employee e on es.EmployeeId = e.ID " +
        //                            "inner join Shift s on es.ShiftId = s.ID",
        //                                          (employeeShift, employee, shift) =>
        //                                          {
        //                                              if (!shiftDictionary.TryGetValue(shift.ID, out var es))
        //                                              {
        //                                                  es = employeeShift;
        //                                                  es.Employee = employee;
        //                                                  es.Shift = shift;
        //                                                  es.Incidents = new List<Incident>();
        //                                                  shiftDictionary.Add(es.ID, es);
        //                                              }
        //                                              return es;
        //                                          },
        //                                                         splitOn: "EmployeeId,ShiftId");
        //        var shifts = shiftDictionary.Values.ToList();
        //        var incidentDictionary = new Dictionary<int, Incident>();
        //        cnn.Query<Incident, EmployeeShift, Incident>(
        //                            "select i.ID, i.Description, i.RatingChange, i.Date, i.EmployeeShiftId " +
        //                            "from Incident i " +
        //                            "inner join EmployeeShift es on i.EmployeeShiftId = es.ID",
        //                                          (incident, employeeShift) =>
        //                                          {
        //                                              if (!incidentDictionary.TryGetValue(incident.ID, out var i))
        //                                              {
        //                                                  i = incident;
        //                                                  i.EmployeeShift = employeeShift;
        //                                                  incidentDictionary.Add(i.ID, i);
        //                                              }
        //                                              shift.Incidents.Add(i);
        //                                              return i;
        //                                          },
        //                                                         splitOn: "EmployeeShiftId");
        //        //return shifts;
        //    }
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
        //}
    //write a method to load the employee shifts
    
    }

}
//// Update the employee in the Employee table
//cnn.Execute("update Employee set FirstName = @FirstName, LastName = @LastName where Id = @Id",
//    new { FirstName = employee.FirstName, LastName = employee.LastName, Id = employee.ID });
