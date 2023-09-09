using Microsoft.Office.Interop.Excel;
using Staff_Performance_Class_Library;
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
        private DateTime shiftDate;
        private bool isAm;
        ExcelShift ExcelShift = new ExcelShift();
        //public event System.Action ShiftCreated;
        public frmExcelDownload(DateTime shiftDate, bool isAm)
        {
            this.shiftDate = shiftDate;
            this.isAm = isAm;
            InitializeComponent();
            this.Shown += frmExcelDownload_Shown;

        }
        public frmExcelDownload(ExcelShift excelShift)
        {

            //this.shiftDate = excelShift.newShift.DateAsDateTime;
            //this.isAm = excelShift.;
            this.ExcelShift = excelShift;
            InitializeComponent();
            //this.Shown += frmExcelDownload_Shown;

        }
        //Shift newShift = new Shift();
        //List<Employee> allEmployees = new List<Employee>();
        List<Employee> employeesOnShift = new List<Employee>();
        List<EmployeeShift> employeeShifts = new List<EmployeeShift>();
        List<Employee> newEmployees = new List<Employee>();
        List<EmployeeShift> newEmployeeShifts = new List<EmployeeShift>();
        List<Position> AllPositionList = new List<Position>();
        Shift newShift = new Shift();
        List<string> ignoredCells = new List<string>();
        string ignoreHost = "Host Card";
        string ignoreBar = "PM BAR PM";
        string ignoreBanquet = "Banquet Bartender 1";
        string ignoreBanquetBar = "Banquet Server 1";
        List<string> newEmployeeNamesStrings = new List<string>();
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

        //private void frmExcelDownload_Load(object sender, EventArgs e)
        //{
        //    //newShift.DateString = DateTime.Now.ToString("MM/dd/yyyy");
        //    List<Employee> allEmployees = DataSingleton.Instance.Employees;
        //    dtpShiftDate.Value = shiftDate;
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Filter = "Excel files (*.xlsx;*.xls)|*.xlsx;*.xls|All files (*.*)|*.*";
        //    openFileDialog.RestoreDirectory = true;
        //    //List<Employee> allEmployees = SqliteDataAccess.LoadEmployees(); // Assuming you have a method to get all employees from the database
        //    //List<Employee> employeesOnShift = new List<Employee>();
        //    List<string> newEmployeeNamesStrings = new List<string>();


        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string filePath = openFileDialog.FileName;

        //        // Load the Excel file into a new Application instance
        //        Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
        //        Workbook workbook = null;

        //        try
        //        {
        //            workbook = excelApp.Workbooks.Open(filePath);

        //            // Get the names from the first worksheet (A5:A24) with the "Server" column
        //            Worksheet worksheet1 = workbook.Sheets[1];
        //            Microsoft.Office.Interop.Excel.Range range1 = worksheet1.Range["B2:B100"];


        //            for (int i = 1; i <= range1.Rows.Count; i++)
        //            {
        //                string fullName = (range1.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
        //                if (!string.IsNullOrWhiteSpace(fullName))
        //                {
        //                    string fullNameCleaned = Regex.Replace(fullName.ToLower().Trim(), @"\s+", " ");
        //                    int threshold = 2;

        //                    //Employee matchedEmployee = allEmployees.FirstOrDefault(e => e.FullName == fullName);
        //                    Employee matchedEmployee = allEmployees.FirstOrDefault(e =>
        //                    {
        //                        string dbFullNameCleaned = Regex.Replace(e.FullName.ToLower().Trim(), @"\s+", " ");
        //                        int distance = LevenshteinDistance(fullNameCleaned, dbFullNameCleaned);
        //                        return distance <= threshold;
        //                    });

        //                    if (matchedEmployee != null)
        //                    {
        //                        employeesOnShift.Add(matchedEmployee);
        //                        //lbEmployees.Items.Add($"{fullName,-20} Server");
        //                    }
        //                    else
        //                    {
        //                        if (fullName != ignoreBanquet)
        //                        {
        //                            newEmployeeNamesStrings.Add(fullName);
        //                            //lbEmployees.Items.Add($"{fullName,-20} Server (New)");
        //                        }

        //                    }
        //                }
        //            }

        //            // ... Repeat this process for other worksheets and columns if needed
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("An error occurred while loading the Excel file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        finally
        //        {
        //            // Close the workbook and release the Excel Application object
        //            //if (workbook != null)
        //            //{
        //            //    workbook.Close(false);
        //            //}
        //            if (workbook != null)
        //            {
        //                workbook.Close(false);
        //                Marshal.ReleaseComObject(workbook);
        //            }

        //            excelApp.Quit();
        //            Marshal.ReleaseComObject(excelApp);
        //        }
        //    }
        //    //UIHelper.CreateEmployeePanels(existingEmployees, flowExistingStaff);
        //    UIHelper.CreateOldEmployeePanelsExcel(employeesOnShift, flowExistingStaff);
        //    List<Employee> newEmployees = new List<Employee>();
        //    foreach (string fullName in newEmployeeNamesStrings)
        //    {
        //        if (fullName != ignoreHost & fullName != ignoreBar & fullName != ignoreBanquet & fullName != ignoreBanquetBar)
        //        {
        //            Employee newEmp = new Employee(fullName);
        //            newEmployees.Add(newEmp);
        //        }

        //    }
        //    //UIHelper.CreateEmployeePanels(newEmployees, flowNewStaff);
        //    UIHelper.CreateNewEmployeePanelsExcel(newEmployees, employeesOnShift, flowNewStaff, flowExistingStaff);


        //}
        private void frmExcelDownload_Load(object sender, EventArgs e)
        {
            ignoredCells = SqliteDataAccess.LoadExcelIgnore();
            dtpShiftDate.Value = shiftDate;
            newShift.Date = DateOnly.FromDateTime(dtpShiftDate.Value);
            newShift.IsAm = isAm;
            AllPositionList = SqliteDataAccess.LoadPositions();
            
            
            if (isAm == true) { lblAmPm.Text = "AM"; }
            else { lblAmPm.Text = "PM"; }

            
        }
        private void frmExcelDownload_Shown(object sender, EventArgs e)
        {
            List<Employee> allEmployees = DataSingleton.Instance.Employees;
            var filePath = GetFilePathFromUser();
            if (!string.IsNullOrWhiteSpace(filePath))
            {
                ProcessExcelFile(allEmployees, filePath);

            }
            UpdateUI();
        }

        private string GetFilePathFromUser()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx;*.xls)|*.xlsx;*.xls|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            return (openFileDialog.ShowDialog() == DialogResult.OK) ? openFileDialog.FileName : string.Empty;
        }

        private void ProcessExcelFile(List<Employee> allEmployees, string filePath)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = null;

            try
            {
                workbook = excelApp.Workbooks.Open(filePath);
                GetEmployeeDataFromExcel(allEmployees, workbook);
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
        private void GetEmployeeDataFromExcel(List<Employee> allEmployees, Workbook workbook)
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
                    if (!ignoredCells.Contains(fullName))
                    {
                        ProcessSingleEmployee(fullName, allEmployees, newEmployeeNamesStrings, "Server");
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
                    ProcessSingleEmployee(fullName, allEmployees, newEmployeeNamesStrings, "Busser");
                }
                Marshal.ReleaseComObject(rangeBusser);
                rangeBusser = null;
                Microsoft.Office.Interop.Excel.Range rangeHost = worksheet2.Range["D2:D10"];
                for (int i = 1; i <= rangeHost.Rows.Count; i++)
                {
                    string fullName = (rangeHost.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
                    ProcessSingleEmployee(fullName, allEmployees, newEmployeeNamesStrings, "Host");
                }
                Marshal.ReleaseComObject(rangeHost);
                rangeHost = null;
                Microsoft.Office.Interop.Excel.Range rangeRunner = worksheet2.Range["G2:G10"];
                for (int i = 1; i <= rangeRunner.Rows.Count; i++)
                {
                    string fullName = (rangeRunner.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
                    ProcessSingleEmployee(fullName, allEmployees, newEmployeeNamesStrings, "Runner");
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

        private void ProcessRange(Microsoft.Office.Interop.Excel.Range range, List<Employee> allEmployees, string role)
        {
            Microsoft.Office.Interop.Excel.Range cell = null;

            try
            {
                for (int i = 1; i <= range.Rows.Count; i++)
                {
                    cell = (Microsoft.Office.Interop.Excel.Range)range.Cells[i, 1];
                    string fullName = cell.Value2?.ToString();
                    ProcessSingleEmployee(fullName, allEmployees, newEmployeeNamesStrings, role);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while processing the {role} range: " + ex.Message);
            }
            finally
            {
                if (cell != null)
                {
                    Marshal.ReleaseComObject(cell);
                    cell = null;
                }

                if (range != null)
                {
                    Marshal.ReleaseComObject(range);
                    range = null;
                }
            }
        }

        //private void GetEmployeeDataFromExcel(List<Employee> allEmployees, Workbook workbook)
        //{
        //    //Worksheet worksheet1 = workbook.Sheets[1];
        //    //Microsoft.Office.Interop.Excel.Range range1 = worksheet1.Range["B2:B100"];
        //    //List<string> newEmployeeNamesStrings = new List<string>();
        //    Worksheet worksheet1 = (Worksheet)workbook.Sheets[1];
        //    Microsoft.Office.Interop.Excel.Range range1 = worksheet1.Range["B2:B100"];
        //    // ... your logic here ...
        //    for (int i = 1; i <= range1.Rows.Count; i++)
        //    {
        //        string fullName = (range1.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
        //        ProcessSingleEmployee(fullName, allEmployees, newEmployeeNamesStrings, "Server");
        //    }

        //    // Finally, release the objects in reverse order
        //    Marshal.ReleaseComObject(range1);
        //    range1 = null;

        //    Marshal.ReleaseComObject(workbook.Sheets[1]); //release the Sheets object
        //    worksheet1 = null;


            
        //    Worksheet worksheet2 = (Worksheet)workbook.Sheets[2];
        //    Microsoft.Office.Interop.Excel.Range rangeBusser = worksheet2.Range["A2:A10"];
        //    for (int i = 1; i <= rangeBusser.Rows.Count; i++)
        //    {
        //        string fullName = (rangeBusser.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
        //        ProcessSingleEmployee(fullName, allEmployees, newEmployeeNamesStrings, "Busser");
        //    }
        //    Marshal.ReleaseComObject(rangeBusser);
        //    rangeBusser = null;
        //    Microsoft.Office.Interop.Excel.Range rangeHost = worksheet2.Range["D2:D10"];
        //    for (int i = 1; i <= rangeHost.Rows.Count; i++)
        //    {
        //        string fullName = (rangeHost.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
        //        ProcessSingleEmployee(fullName, allEmployees, newEmployeeNamesStrings, "Host");
        //    }
        //    Marshal.ReleaseComObject(rangeHost);
        //    rangeHost = null;
        //    Microsoft.Office.Interop.Excel.Range rangeRunner = worksheet2.Range["G2:G10"];
        //    for (int i = 1; i <= rangeRunner.Rows.Count; i++)
        //    {
        //        string fullName = (rangeRunner.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
        //        ProcessSingleEmployee(fullName, allEmployees, newEmployeeNamesStrings, "Runner");
        //    }
        //    Marshal.ReleaseComObject(rangeRunner);
        //    rangeRunner = null;

        //    Marshal.ReleaseComObject(workbook.Sheets[2]); //release the Sheets object
        //    worksheet2 = null;
        //}
        public Position GetPositionByName(string name)
        {
            return AllPositionList.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            //retur position = AllPositionList.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            //return position?.ID ?? -1; 
        }
        private void ProcessSingleEmployee(string fullName, List<Employee> allEmployees, List<string> newEmployeeNamesStrings, string positionName)
        {
            if (!string.IsNullOrWhiteSpace(fullName))
            {
                string fullNameCleaned = Regex.Replace(fullName.ToLower().Trim(), @"\s+", " ");
                int threshold = 2;
                Employee matchedEmployee = allEmployees.FirstOrDefault(e =>
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
        private void CreateNewEmployeeAndEmployeeShift(string fullName, string positionName)
        {
            Employee newEmp = new Employee();
            newEmp = new Employee(fullName);
            newEmp.Positions.Add(GetPositionByName(positionName));
            newEmployees.Add(newEmp);
            EmployeeShift employeeShift = new EmployeeShift(newEmp, newShift)
            {
                Position = GetPositionByName(positionName),
                Shift = newShift,
                Employee = newEmp
            };
            //employeeShift.Employee.Positions.Add(employeeShift.Position);
            newEmployeeShifts.Add(employeeShift);
        }

        private void UpdateUI()
        {
            CreateEmployeeShiftPanels(employeeShifts, flowExistingStaff);
            
            List<Employee> newEmployees = new List<Employee>();

            

            CreateNewEmployeePanelsExcel(flowNewStaff, flowExistingStaff);
        }
        
        private void CreateEmployeeShift(string positionName, Employee employee)
        {
            
                EmployeeShift employeeShift = new EmployeeShift(employee, newShift)
                {
                    Position = GetPositionByName(positionName),
                    Shift = newShift,
                    Employee = employee
                };
            employeeShift.Employee.Positions.Add(employeeShift.Position);
            employeeShifts.Add(employeeShift);
            
        }
        private void AddEmployeePositionFromEmployeeShift(EmployeeShift employeeShift)
        {
            employeeShift.Employee.Positions.Add(employeeShift.Position);
        }
        public delegate void ShiftCreatedEventHandler(Object sender, EventArgs e);
        public event EventHandler<ShiftEventArgs> ShiftCreated;
        protected virtual void OnShiftCreation(Shift newShift)
        {
            ShiftCreated?.Invoke(this, new ShiftEventArgs(newShift));
        }
        private void btnCreateShift_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Employee employee in employeesOnShift)
                {
                    if (SqliteDataAccess.IsDuplicateEmployee(employee.FirstName, employee.LastName) == false)
                    {
                        employee.ID = SqliteDataAccess.AddEmployee(employee);
                    }
                }              
                                
                newShift.ID = SqliteDataAccess.AddShift(newShift);                                              

                foreach (EmployeeShift es in employeeShifts)
                {
                    es.Shift = newShift;


                    es.ID = SqliteDataAccess.AddEmployeeShift(es);
                    //shiftToAdd.EmployeeShifts.Add(es);
                }
                Shift shiftToAdd = SqliteDataAccess.LoadShiftAndAllChildren(newShift.IsAm, newShift.DateString);
                OnShiftCreation(shiftToAdd);                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Whoops!: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
                this.Dispose(true);
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpShiftDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelCreateShift_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
        }

        private void btnTestLoad_Click(object sender, EventArgs e)
        {
            UpdateUI();
        }
        private void CreateNewEmployeePanelsExcel( FlowLayoutPanel flowNewEmployeeDisplay, FlowLayoutPanel flowExistingEmployees)
        {
            // Clear existing panels
            flowNewEmployeeDisplay.Controls.Clear();

            // Loop through employee list and create a panel for each employee
            foreach (EmployeeShift es in newEmployeeShifts)
            {
                Panel empPanelContainer = new Panel();
                empPanelContainer.Size = new Size(350, 22);
                empPanelContainer.BackColor = MyColors.LightHighlight;
                empPanelContainer.Margin = new Padding(2, 2, 2, 2);

                PictureBox positionPB = UIHelper.CreatePositionPictureBox(22, 22, es.Position);
                empPanelContainer.Controls.Add(positionPB);


                FlowLayoutPanel empPanel = UIHelper.CreateFlowPanel(180, 22);

                empPanel.Margin = new Padding(1, 1, 1, 1);
                //empPanel.Padding = new Padding(10, 1, 1, 1);
                // Create label for employee name
                System.Windows.Forms.Label lblName = UIHelper.CreateLabel(160, 20, es.Employee.FullName);
                lblName.Margin = new Padding(20, 0, 0, 0);
                empPanel.Controls.Add(lblName);

                // Create panels for employee positions

                empPanelContainer.Controls.Add(empPanel);
                //int remainingWidth = empPanel.Parent.ClientSize.Width - lblName.Width - emp.Positions.Count * pnlPos.Width;


                System.Windows.Forms.Button btnAddEmployee = UIHelper.CreateButtonTemplate(160, 22, "Add Employee");

                btnAddEmployee.Location = new System.Drawing.Point(185, 0);
                //TODO: handle duplicate check some other way
                btnAddEmployee.Click += (sender, e) =>
                {
                    if (SqliteDataAccess.IsDuplicateEmployee(es.Employee.FirstName, es.Employee.LastName) == false)
                    {
                        employeesOnShift.Add(es.Employee);
                        employeeShifts.Add(es);
                        //CreateEmployeeShift("Server", es);
                        CreateEmployeeShiftPanels(employeeShifts, flowExistingEmployees);
                        //CreateOldEmployeePanelsExcel(existingEmployeeList, flowExistingEmployees);
                        newEmployeeShifts.Remove(es);
                        CreateNewEmployeePanelsExcel(flowNewEmployeeDisplay, flowExistingEmployees);
                    }
                    else
                    {
                        MessageBox.Show(es.Employee.FullName + "already exists");
                        newEmployeeShifts.Remove(es);
                        CreateNewEmployeePanelsExcel(flowNewEmployeeDisplay, flowExistingEmployees);
                    }


                };

                empPanel.Parent.Controls.Add(btnAddEmployee);


                flowNewEmployeeDisplay.Controls.Add(empPanelContainer);
            }
        }
        private void OLDCreateNewEmployeePanelsExcel(List<Employee> newEmployeeList, List<Employee> existingEmployeeList, FlowLayoutPanel flowNewEmployeeDisplay, FlowLayoutPanel flowExistingEmployees, Position position)
        {
            // Clear existing panels
            flowNewEmployeeDisplay.Controls.Clear();

            // Loop through employee list and create a panel for each employee
            foreach (Employee emp in newEmployeeList)
            {
                Panel empPanelContainer = new Panel();
                empPanelContainer.Size = new Size(350, 22);
                empPanelContainer.BackColor = MyColors.LightHighlight;
                empPanelContainer.Margin = new Padding(2, 2, 2, 2);


                FlowLayoutPanel empPanel = UIHelper.CreateFlowPanel(180, 22);

                empPanel.Margin = new Padding(10, 1, 1, 1);
                empPanel.Padding = new Padding (10, 1, 1, 1);

                // Create label for employee name
                System.Windows.Forms.Label lblName = UIHelper.CreateLabel(150, 20, emp.FullName);
                lblName.Margin = new Padding(20, 0, 0, 0);
                empPanel.Controls.Add(lblName);

                // Create panels for employee positions

                empPanelContainer.Controls.Add(empPanel);
                //int remainingWidth = empPanel.Parent.ClientSize.Width - lblName.Width - emp.Positions.Count * pnlPos.Width;


                System.Windows.Forms.Button btnAddEmployee = UIHelper.CreateButtonTemplate(160, 22, "Add Employee");

                btnAddEmployee.Location = new System.Drawing.Point(185, 0);
                //TODO: handle duplicate check some other way
                btnAddEmployee.Click += (sender, e) =>
                {
                    if (SqliteDataAccess.IsDuplicateEmployee(emp.FirstName, emp.LastName) == false)
                    {
                        existingEmployeeList.Add(emp);
                        CreateEmployeeShift("Server", emp);
                        CreateEmployeeShiftPanels(employeeShifts, flowExistingEmployees);
                        //CreateOldEmployeePanelsExcel(existingEmployeeList, flowExistingEmployees);
                        newEmployeeList.Remove(emp);
                        CreateNewEmployeePanelsExcel(flowNewEmployeeDisplay, flowExistingEmployees);
                    }
                    else
                    {
                        MessageBox.Show(emp.FullName + "already exists");
                        newEmployeeList.Remove(emp);
                        CreateNewEmployeePanelsExcel(flowNewEmployeeDisplay, flowExistingEmployees);
                    }


                };

                empPanel.Parent.Controls.Add(btnAddEmployee);


                flowNewEmployeeDisplay.Controls.Add(empPanelContainer);
            }
        }
        private static void CreateEmployeeShiftPanels(List<EmployeeShift> employeeShifts, FlowLayoutPanel flowEmployeeDisplay)
        {
            // Clear existing panels
            flowEmployeeDisplay.Controls.Clear();

            // Loop through employee list and create a panel for each employee
            foreach (EmployeeShift emp in employeeShifts)
            {
                Panel empPanelContainer = new Panel();
                empPanelContainer.Size = new Size(180, 25);
                empPanelContainer.BackColor = MyColors.LightHighlight;
                empPanelContainer.Margin = new Padding(2, 2, 2, 2);


                FlowLayoutPanel empPanel = UIHelper.CreateFlowPanel(180, 25);

                empPanel.Margin = new Padding(10, 1, 1, 1);
                empPanel.Padding = new Padding(10, 1, 1, 1);
                PictureBox pbPosition = UIHelper.CreatePositionPictureBox(25,25, emp.Position);
                empPanelContainer.Controls.Add(pbPosition);

                System.Windows.Forms.Label lblName = UIHelper.CreateLabel(150, 25, emp.Employee.FullName);
                //lblName.Margin = new Padding(20,0,0,0);
                empPanel.Controls.Add(lblName);

                // Create panels for employee positions


                // Add the employee panel to the container panel
                empPanelContainer.Controls.Add(empPanel);
                //int remainingWidth = empPanel.Parent.ClientSize.Width - lblName.Width - emp.Positions.Count * pnlPos.Width;

                // Add the delete button to the container panel
                System.Windows.Forms.Button btnDelete = UIHelper.CreateButtonTemplate(16, 16, "X");

                //btnDelete.AutoSize = true;
                btnDelete.Margin = new Padding(0, 0, 0, 0);
                btnDelete.Location = new System.Drawing.Point(410, 0);
                btnDelete.Font = new System.Drawing.Font(btnDelete.Font.FontFamily, 6);
                btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                btnDelete.Click += (sender, e) =>
                {
                    // Prompt user to confirm deletion
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Delete employee from database
                        SqliteDataAccess.DeleteEmployee(emp.ID);

                        // Remove employee from list
                        employeeShifts.Remove(emp);

                        // Update UI
                        //CreateEmployeePanels();
                    }
                };

                empPanel.Parent.Controls.Add(btnDelete);
                //empPanelContainer.Controls.Add(btnDelete);

                flowEmployeeDisplay.Controls.Add(empPanelContainer);
            }
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
