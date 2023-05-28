using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RicksStaffApp
{
    public partial class frmExcelDownload : Form
    {
        public frmExcelDownload()
        {
            InitializeComponent();

        }
        //Shift newShift = new Shift();
        List<Employee> allEmployees = new List<Employee>();
        List<Employee> employeesOnShift = new List<Employee>();
        string ignoreHost = "Host Card";
        string ignoreBar = "PM BAR PM";
        string ignoreBanquet = "Banquet Bartender 1";
        string ignoreBanquetBar = "Banquet Server 1";
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
                    int cost = (s[i] == t[j]) ? 0 : 1;
                    v1[j + 1] = Math.Min(v1[j] + 1, Math.Min(v0[j + 1] + 1, v0[j] + cost));
                }

                for (int j = 0; j < v0.Length; j++)
                {
                    v0[j] = v1[j];
                }
            }

            return v1[t.Length];
        }

        private void frmExcelDownload_Load(object sender, EventArgs e)
        {
            //newShift.DateString = DateTime.Now.ToString("MM/dd/yyyy");
            allEmployees = SqliteDataAccess.LoadEmployees();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx;*.xls)|*.xlsx;*.xls|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            //List<Employee> allEmployees = SqliteDataAccess.LoadEmployees(); // Assuming you have a method to get all employees from the database
            //List<Employee> employeesOnShift = new List<Employee>();
            List<string> newEmployeeNamesStrings = new List<string>();


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Load the Excel file into a new Application instance
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook = null;

                try
                {
                    workbook = excelApp.Workbooks.Open(filePath);

                    // Get the names from the first worksheet (A5:A24) with the "Server" column
                    Worksheet worksheet1 = workbook.Sheets[1];
                    Microsoft.Office.Interop.Excel.Range range1 = worksheet1.Range["B2:B100"];


                    for (int i = 1; i <= range1.Rows.Count; i++)
                    {
                        string fullName = (range1.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
                        if (!string.IsNullOrWhiteSpace(fullName))
                        {
                            string fullNameCleaned = Regex.Replace(fullName.ToLower().Trim(), @"\s+", " ");
                            int threshold = 2;

                            //Employee matchedEmployee = allEmployees.FirstOrDefault(e => e.FullName == fullName);
                            Employee matchedEmployee = allEmployees.FirstOrDefault(e =>
                            {
                                string dbFullNameCleaned = Regex.Replace(e.FullName.ToLower().Trim(), @"\s+", " ");
                                int distance = LevenshteinDistance(fullNameCleaned, dbFullNameCleaned);
                                return distance <= threshold;
                            });

                            if (matchedEmployee != null)
                            {
                                employeesOnShift.Add(matchedEmployee);
                                //lbEmployees.Items.Add($"{fullName,-20} Server");
                            }
                            else
                            {
                                if (fullName != ignoreBanquet)
                                {
                                    newEmployeeNamesStrings.Add(fullName);
                                    //lbEmployees.Items.Add($"{fullName,-20} Server (New)");
                                }

                            }
                        }
                    }

                    // ... Repeat this process for other worksheets and columns if needed
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading the Excel file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close the workbook and release the Excel Application object
                    //if (workbook != null)
                    //{
                    //    workbook.Close(false);
                    //}
                    if (workbook != null)
                    {
                        workbook.Close(false);
                        Marshal.ReleaseComObject(workbook);
                    }

                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
            }
            //UIHelper.CreateEmployeePanels(existingEmployees, flowExistingStaff);
            UIHelper.CreateOldEmployeePanelsExcel(employeesOnShift, flowExistingStaff);
            List<Employee> newEmployees = new List<Employee>();
            foreach (string fullName in newEmployeeNamesStrings)
            {
                if (fullName != ignoreHost & fullName != ignoreBar & fullName != ignoreBanquet & fullName != ignoreBanquetBar)
                {
                    Employee newEmp = new Employee(fullName);
                    newEmployees.Add(newEmp);
                }

            }
            //UIHelper.CreateEmployeePanels(newEmployees, flowNewStaff);
            UIHelper.CreateNewEmployeePanelsExcel(newEmployees, employeesOnShift, flowNewStaff, flowExistingStaff);


        }

        private void btnCreateShift_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Employee employee in employeesOnShift)
                {
                    if (SqliteDataAccess.IsDuplicateEmployee(employee.FirstName, employee.LastName) == false)
                    {
                        SqliteDataAccess.AddEmployee(employee);
                    }
                }

                Shift s = new Shift();
                s.Date = DateOnly.FromDateTime(dtpShiftDate.Value);
                s.IsAm = false;

                int shiftID = SqliteDataAccess.AddShift(s);

                Shift newShift = SqliteDataAccess.LoadShift(s.IsAm, s.DateString);

                foreach (Employee emp in employeesOnShift)
                {
                    //EmployeeShift employeeShift = new EmployeeShift();
                    //employeeShift.PositionID = 1;
                    //employeeShift.Shift.ID = s.ID;
                    //employeeShift.Employee.ID = emp.ID;
                    EmployeeShift employeeShift = new EmployeeShift
                    {
                        PositionID = 1,
                        Shift = newShift,
                        Employee = emp
                    };
                    SqliteDataAccess.AddEmployeeShift(employeeShift);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Whoops!: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpShiftDate_ValueChanged(object sender, EventArgs e)
        {

        }
        /*
private void frmExcelDownload_Load(object sender, EventArgs e)
{
OpenFileDialog openFileDialog = new OpenFileDialog();
openFileDialog.Filter = "Excel files (*.xlsx;*.xls)|*.xlsx;*.xls|All files (*.*)|*.*";
openFileDialog.RestoreDirectory = true;
List<String> firstNames = new List<String>();
firstNames.Clear();

if (openFileDialog.ShowDialog() == DialogResult.OK)
{
string filePath = openFileDialog.FileName;
List<Employee> excelEmployees = new List<Employee>();
// Load the Excel file into a new Application instance
Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
Workbook workbook = null;

try
{
workbook = excelApp.Workbooks.Open(filePath);

// Get the names from the first worksheet (A5:A24) with the "Server" column
Worksheet worksheet1 = workbook.Sheets[1];
Microsoft.Office.Interop.Excel.Range range1 = worksheet1.Range["B2:B100"];

for (int i = 1; i <= range1.Rows.Count; i++)
{
string name = (range1.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
if (!string.IsNullOrWhiteSpace(name))
{
 firstNames.Add(name);


 lbEmployees.Items.Add($"{name,-20} Server");
}
}

// Get the names from the second worksheet (A4:A8) with the "Busser" column
//Worksheet worksheet2 = workbook.Sheets[2];
//Microsoft.Office.Interop.Excel.Range range2 = worksheet2.Range["A4:A8"];
//for (int i = 1; i <= range2.Rows.Count; i++)
//{
//    string name = (range2.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
//    if (!string.IsNullOrWhiteSpace(name))
//    {
//        firstNames.Add(name);
//        lbEmployees.Items.Add($"{name,-20} Busser");
//    }
//}

//// Get the names from the second worksheet (D4:D8) with the "Foodrunner" column
//Microsoft.Office.Interop.Excel.Range range3 = worksheet2.Range["D4:D8"];
//for (int i = 1; i <= range3.Rows.Count; i++)
//{
//    string name = (range3.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
//    if (!string.IsNullOrWhiteSpace(name))
//    {
//        firstNames.Add(name);
//        lbEmployees.Items.Add($"{name,-20} Foodrunner");
//    }
//}
}
catch (Exception ex)
{
MessageBox.Show("An error occurred while loading the Excel file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
finally
{
// Close the workbook and release the Excel Application object
if (workbook != null)
{
workbook.Close(false);
}
excelApp.Quit();
Marshal.ReleaseComObject(excelApp);
}
foreach (string name in firstNames)
{
List<Employee> matchedEmployees = allEmployees.Where(e => e.MatchesFirstName(name)).ToList();
if (matchedEmployees.Count == 1)
{
excelEmployees.Add(matchedEmployees[0]);
}
else if (matchedEmployees.Count > 1)
{ }
}

}
}
*/
    }
}
