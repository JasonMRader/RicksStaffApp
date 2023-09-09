
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Staff_Performance_Class_Library
{
    public class ExcelShift
    {
        public ExcelShift(Shift shift)
        {
            newShift = shift;
        }
        public ExcelShift() { }

        public List<Employee> employeesOnShift { get; set; }
        //public List<EmployeeShift> employeeShifts { get; set; }
        public List<Employee> NewEmployees { get; set; }
        public List<EmployeeShift> newEmployeeShifts { get; set; }
        public List<Position> AllPositionList { get; set; }
        public Shift newShift { get; set; }
        //public List<string> ignoredCells { get; set; }
        List<string> newEmployeeNamesStrings { get; set; }



        //*******  1
        public void ProcessExcelFile(string filePath)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = null;

            try
            {
                workbook = excelApp.Workbooks.Open(filePath);
                GetEmployeeDataFromExcel(workbook);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the Excel file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (workbook != null)
                {
                    workbook.Close(false);
                    Marshal.ReleaseComObject(workbook);
                }

                excelApp.Quit();
                Marshal.ReleaseComObject(excelApp);
            }
        }
        //****** 2
        private void GetEmployeeDataFromExcel(Workbook workbook)
        {
            Worksheet worksheet1 = null;
            Microsoft.Office.Interop.Excel.Range range1 = null;

            try
            {
                worksheet1 = (Worksheet)workbook.Sheets[1];
                range1 = worksheet1.Range["B2:B100"];

                for (int i = 1; i <= range1.Rows.Count; i++)
                {
                    string fullName = (range1.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
                    if (!DataSingleton.Instance.ignoredExcelCells.Contains(fullName))
                    {
                        ProcessSingleEmployee(fullName, "Server");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the first sheet: " + ex.Message);
            }
            finally
            {
                if (range1 != null)
                {
                    Marshal.ReleaseComObject(range1);
                    range1 = null;
                }

                if (worksheet1 != null)
                {
                    Marshal.ReleaseComObject(worksheet1);
                    worksheet1 = null;
                }
            }

            Worksheet worksheet2 = null;
            try
            {
                worksheet2 = (Worksheet)workbook.Sheets[2];
                Microsoft.Office.Interop.Excel.Range rangeBusser = worksheet2.Range["A2:A10"];
                for (int i = 1; i <= rangeBusser.Rows.Count; i++)
                {
                    string fullName = (rangeBusser.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
                    ProcessSingleEmployee(fullName, "Busser");
                }
                Marshal.ReleaseComObject(rangeBusser);
                rangeBusser = null;
                Microsoft.Office.Interop.Excel.Range rangeHost = worksheet2.Range["D2:D10"];
                for (int i = 1; i <= rangeHost.Rows.Count; i++)
                {
                    string fullName = (rangeHost.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
                    ProcessSingleEmployee(fullName, "Host");
                }
                Marshal.ReleaseComObject(rangeHost);
                rangeHost = null;
                Microsoft.Office.Interop.Excel.Range rangeRunner = worksheet2.Range["G2:G10"];
                for (int i = 1; i <= rangeRunner.Rows.Count; i++)
                {
                    string fullName = (rangeRunner.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
                    ProcessSingleEmployee(fullName, "Runner");
                }
                Marshal.ReleaseComObject(rangeRunner);
                rangeRunner = null;

                //Marshal.ReleaseComObject(workbook.Sheets[2]); //release the Sheets object
                //worksheet2 = null;
                //worksheet2 = (Worksheet)workbook.Sheets[2];

                //ProcessRange(worksheet2.Range["A2:A10"], allEmployees, "Busser");
                //ProcessRange(worksheet2.Range["D2:D10"], allEmployees, "Host");
                //ProcessRange(worksheet2.Range["G2:G10"], allEmployees, "Runner");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the second sheet: " + ex.Message);
            }
            finally
            {
                if (worksheet2 != null)
                {
                    Marshal.ReleaseComObject(worksheet2);
                    worksheet2 = null;
                }
            }
        }
        // ********  3
        private void ProcessSingleEmployee(string fullName, string positionName)
        {
            if (!string.IsNullOrWhiteSpace(fullName))
            {
                string fullNameCleaned = Regex.Replace(fullName.ToLower().Trim(), @"\s+", " ");
                int threshold = 2;
                Employee matchedEmployee = DataSingleton.Instance.Employees.FirstOrDefault(e =>
                {
                    string dbFullNameCleaned = Regex.Replace(e.FullName.ToLower().Trim(), @"\s+", " ");
                    int distance = LevenshteinDistance(fullNameCleaned, dbFullNameCleaned);
                    return distance <= threshold;
                });

                if (matchedEmployee != null)
                {
                    employeesOnShift.Add(matchedEmployee);
                    CreateEmployeeShift(positionName, matchedEmployee);
                }
                else
                {
                    newEmployeeNamesStrings.Add(fullName);
                    CreateNewEmployeeAndEmployeeShift(fullName, positionName);
                }
            }
        }
        //********* 4
        private void CreateEmployeeShift(string positionName, Employee employee)
        {

            EmployeeShift employeeShift = new EmployeeShift(employee, newShift)
            {
                Position = GetPositionByName(positionName),
                Shift = newShift,
                Employee = employee
            };
            employeeShift.Employee.Positions.Add(employeeShift.Position);
            newShift.EmployeeShifts.Add(employeeShift);

        }
        // ********** 5
        public Position GetPositionByName(string name)
        {
            return AllPositionList.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            //retur position = AllPositionList.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            //return position?.ID ?? -1; 
        }
        public static int LevenshteinDistance(string s, string t)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.IsNullOrEmpty(t) ? 0 : t.Length;
            }

            if (string.IsNullOrEmpty(t))
            {
                return s.Length;
            }

            int[] v0 = new int[t.Length + 1];
            int[] v1 = new int[t.Length + 1];

            for (int i = 0; i < v0.Length; i++)
            {
                v0[i] = i;
            }

            for (int i = 0; i < s.Length; i++)
            {
                v1[0] = i + 1;

                for (int j = 0; j < t.Length; j++)
                {
                    int cost = s[i] == t[j] ? 0 : 1;
                    v1[j + 1] = Math.Min(v1[j] + 1, Math.Min(v0[j + 1] + 1, v0[j] + cost));
                }

                for (int j = 0; j < v0.Length; j++)
                {
                    v0[j] = v1[j];
                }
            }

            return v1[t.Length];
        }
        //********* 6
        private void CreateNewEmployeeAndEmployeeShift(string fullName, string positionName)
        {
            Employee newEmp = new Employee();


            newEmp = new Employee(fullName);
            newEmp.Positions.Add(GetPositionByName(positionName));
            NewEmployees.Add(newEmp);

            EmployeeShift employeeShift = new EmployeeShift(newEmp, newShift)
            {
                Position = GetPositionByName(positionName),
                Shift = newShift,
                Employee = newEmp
            };
            //employeeShift.Employee.Positions.Add(employeeShift.Position);
            newEmployeeShifts.Add(employeeShift);
        }
    }
}
