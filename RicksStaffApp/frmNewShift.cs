using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RicksStaffApp
{
    public partial class frmNewShift : Form
    {
        List<Shift> shifts = new List<Shift>();
        public frmNewShift()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmServerShift frmServerShift = new frmServerShift();
            frmServerShift.ShowDialog();
        }

        private void btnExcelLoad_Click(object sender, EventArgs e)
        {            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx;*.xls)|*.xlsx;*.xls|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook = null;

                try
                {
                    workbook = excelApp.Workbooks.Open(filePath);

                    // Get the names from the first worksheet (A5:A24) with the "Server" column
                    Worksheet worksheet1 = workbook.Sheets[1];
                    Microsoft.Office.Interop.Excel.Range range1 = worksheet1.Range["A5:A24"];
                    for (int i = 1; i <= range1.Rows.Count; i++)
                    {
                        string name = (range1.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
                        if (!string.IsNullOrWhiteSpace(name))
                        {
                            lbEmployees.Items.Add($"{name,-20} Server");
                        }
                    }

                    // Get the names from the second worksheet (A4:A8) with the "Busser" column
                    Worksheet worksheet2 = workbook.Sheets[2];
                    Microsoft.Office.Interop.Excel.Range range2 = worksheet2.Range["A4:A8"];
                    for (int i = 1; i <= range2.Rows.Count; i++)
                    {
                        string name = (range2.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
                        if (!string.IsNullOrWhiteSpace(name))
                        {
                            lbEmployees.Items.Add($"{name,-20} Busser");
                        }
                    }

                    // Get the names from the second worksheet (D4:D8) with the "Foodrunner" column
                    Microsoft.Office.Interop.Excel.Range range3 = worksheet2.Range["D4:D8"];
                    for (int i = 1; i <= range3.Rows.Count; i++)
                    {
                        string name = (range3.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
                        if (!string.IsNullOrWhiteSpace(name))
                        {
                            lbEmployees.Items.Add($"{name,-20} Foodrunner");
                        }
                    }
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

            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string filePath = openFileDialog.FileName;

            //    // Load the Excel file into a new Application instance
            //    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            //    Workbook workbook = null;

            //    try
            //    {
            //        workbook = excelApp.Workbooks.Open(filePath);

            //        // Get the range of cells A5:A24 in the first worksheet
            //        Worksheet worksheet = workbook.Sheets[1];
            //        Microsoft.Office.Interop.Excel.Range range = worksheet.Range["A5:A24"];

            //        // Loop through the cells in the range and add their values to lbEmployees
            //        for (int i = 1; i <= range.Rows.Count; i++)
            //        {
            //            string name = (range.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString();
            //            if (!string.IsNullOrWhiteSpace(name))
            //            {
            //                lbEmployees.Items.Add(name);
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("An error occurred while loading the Excel file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    finally
            //    {
            //        // Close the workbook and release the Excel Application object
            //        if (workbook != null)
            //        {
            //            workbook.Close(false);
            //        }
            //        excelApp.Quit();
            //        Marshal.ReleaseComObject(excelApp);
            //    }
            //}

        }

        private void frmNewShift_Load(object sender, EventArgs e)
        {
            shifts = SqliteDataAccess.LoadShifts();
            UIHelper.CreateShiftPanels(shifts, flowEmployeeShiftDisplay);
        }

        private void lbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEmployees.SelectedIndex != -1)
            {
                string employeeName = lbEmployees.SelectedItem.ToString().Split(' ')[0]; // get the selected employee's name
                frmServerShift frm = new frmServerShift(); // create a new instance of the frmServerShift form
                frm.EmployeeNameLabel = employeeName; // set the employee name label on the frmServerShift form
                frm.ShowDialog(); // show the frmServerShift form
            }
        }

        private void dtpShiftDate_ValueChanged(object sender, EventArgs e)
        {
            //List <EmployeeShift> employeeShifts = new List <EmployeeShift>();
            UIHelper.CreateEmployeeShiftPanels(shifts, flowEmployeeShiftDisplay, DateOnly.FromDateTime(dtpShiftDate.Value), pnlNewShiftDisplay);


        }

        private void btnGetExcelEmployees_Click(object sender, EventArgs e)
        {
            frmExcelDownload frmExcelDownload = new frmExcelDownload();
            pnlNewShiftDisplay.Controls.Clear();
            frmExcelDownload.TopLevel= false;
            pnlNewShiftDisplay.Controls.Add(frmExcelDownload);
            frmExcelDownload.Show();
        }
    }
}
