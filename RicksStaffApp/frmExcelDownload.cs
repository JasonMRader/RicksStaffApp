using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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
        List<Employee> allEmployees = SqliteDataAccess.LoadEmployees();
        string ignoreHost = "Host Card";
        string ignoreBar = "PM BAR PM";
        string ignoreBanquet = "Banquet Bartender 1";
        string ignoreBanquetBar = "Banquet Server 1";
        private void frmExcelDownload_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx;*.xls)|*.xlsx;*.xls|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            //List<Employee> allEmployees = SqliteDataAccess.LoadEmployees(); // Assuming you have a method to get all employees from the database
            List<Employee> existingEmployees = new List<Employee>();
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
                            Employee matchedEmployee = allEmployees.FirstOrDefault(e => e.FullName == fullName);
                            if (matchedEmployee != null)
                            {
                                existingEmployees.Add(matchedEmployee);
                                lbEmployees.Items.Add($"{fullName,-20} Server");
                            }
                            else
                            {
                                if (fullName != ignoreBanquet)
                                {
                                    newEmployeeNamesStrings.Add(fullName);
                                    lbEmployees.Items.Add($"{fullName,-20} Server (New)");
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
                    if (workbook != null)
                    {
                        workbook.Close(false);
                    }
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
            }
            UIHelper.CreateEmployeePanels(existingEmployees, flowExistingStaff);
            List<Employee> newEmployees = new List<Employee>();
            foreach (string fullName in newEmployeeNamesStrings)
            {
                if (fullName != ignoreHost & fullName != ignoreBar)
                {
                    Employee newEmp = new Employee(fullName);
                    newEmployees.Add(newEmp);
                }

            }
            UIHelper.CreateEmployeePanels(newEmployees, flowNewStaff);

            // Now you can use the existingEmployees list for existing employees and newEmployeeNames list to create new employees and add them to the database.
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
