using Staff_Performance_Class_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RicksStaffApp
{
    public partial class frmAddNewEmployee : Form
    {
        List<Employee> employeeList = new List<Employee>();
        List<Position> positionList = new List<Position>();



        public frmAddNewEmployee()
        {
            InitializeComponent();
        }

        private void CreateEmployeePanels()
        {
            // Clear existing panels
            flowEmployeeDisplay.Controls.Clear();

            // Loop through employee list and create a panel for each employee
            foreach (Employee emp in employeeList)
            {
                Panel empPanelContainer = new Panel();
                empPanelContainer.Size = new Size(425, 17);
                empPanelContainer.BackColor = MyColors.LightHighlight;
                empPanelContainer.Margin = new Padding(0, 0, 0, 5);


                FlowLayoutPanel empPanel = new FlowLayoutPanel();
                empPanel.FlowDirection = FlowDirection.LeftToRight;
                empPanel.WrapContents = false;
                empPanel.AutoSize = true;
                empPanel.MaximumSize = new Size(405, 0);
                empPanel.MinimumSize = new Size(405, 0);
                empPanel.BackColor = MyColors.LightHighlight;
                empPanel.Margin = new Padding(1, 1, 1, 1);

                // Create label for employee name
                Label lblName = new Label();
                lblName.Text = emp.FullName;
                lblName.AutoSize = false;
                lblName.Size = new Size(150, 16);
                lblName.TextAlign = ContentAlignment.MiddleCenter;
                empPanel.Controls.Add(lblName);

                // Create panels for employee positions
                foreach (Position pos in emp.Positions)
                {
                    Panel pnlPos = new Panel();
                    pnlPos.Size = new Size(60, 16);
                    pnlPos.BackColor = MyColors.PositionColor;
                    Label lblPos = new Label();
                    lblPos.Text = pos.Name;
                    lblPos.Font = new Font(lblPos.Font.FontFamily, 8);
                    lblPos.AutoSize = false;
                    lblPos.Size = new Size(60, 16);
                    lblPos.TextAlign = ContentAlignment.MiddleCenter;
                    pnlPos.Controls.Add(lblPos);
                    empPanel.Controls.Add(pnlPos);
                }

                // Add the employee panel to the container panel
                empPanelContainer.Controls.Add(empPanel);
                //int remainingWidth = empPanel.Parent.ClientSize.Width - lblName.Width - emp.Positions.Count * pnlPos.Width;

                // Add the delete button to the container panel
                System.Windows.Forms.Button btnDelete = new System.Windows.Forms.Button();
                btnDelete.Text = "X";
                //btnDelete.AutoSize = true;
                btnDelete.Margin = new Padding(0, 0, 0, 0);
                btnDelete.Location = new Point(410, 0);
                btnDelete.ForeColor = Color.Black;
                btnDelete.Font = new Font(btnDelete.Font.FontFamily, 6);
                btnDelete.TextAlign = ContentAlignment.MiddleCenter;
                btnDelete.FlatStyle = FlatStyle.Flat;
                btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                btnDelete.FlatAppearance.BorderSize = 0;
                btnDelete.Click += (sender, e) =>
                {
                    // Prompt user to confirm deletion
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Delete employee from database
                        SqliteDataAccess.DeleteEmployee(emp.ID);

                        // Remove employee from list
                        employeeList.Remove(emp);

                        // Update UI
                        CreateEmployeePanels();
                    }
                };
                btnDelete.Size = new Size(16, 16);
                empPanel.Parent.Controls.Add(btnDelete);
                //empPanelContainer.Controls.Add(btnDelete);

                flowEmployeeDisplay.Controls.Add(empPanelContainer);
            }
        }

        private void LoadEmployeeList()
        {
            employeeList.Clear();
            employeeList = SqliteDataAccess.LoadEmployees();


            CreateEmployeePanels();
        }
        private void LoadPositionList()

        {
            positionList = SqliteDataAccess.LoadPositions();
            WireUpPositionList();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            for (int i = 0; i < clbPositions.CheckedItems.Count; i++)
            {
                Position position = (Position)clbPositions.CheckedItems[i];
                employee.Positions.Add(position);
            }

            SqliteDataAccess.AddEmployee(employee);
            LoadEmployeeList();

        }


        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            LoadEmployeeList();
            CreateEmployeePanels();
        }




        private void WireUpPositionList()
        {
            clbPositions.DataSource = null;
            clbPositions.DataSource = positionList;
            clbPositions.DisplayMember = "Name";
            clbPositions.ValueMember = "ID";

        }

        private void frmAddNewEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployeeList();
            LoadPositionList();
        }
        private void lbEmployees_Format(object sender, ListControlConvertEventArgs e)
        {
            Employee employee = (Employee)e.ListItem;
            e.Value = employee.FullName;
            string positions = string.Join(", ", employee.Positions.Select(p => p.Name));
            e.Value += " - " + positions;
        }
        public event EventHandler FormClosed;

        private void btnCloseAddEmployee_Click(object sender, EventArgs e)
        {
            FormClosed?.Invoke(this, e);
            this.Close();
        }
    }
}
