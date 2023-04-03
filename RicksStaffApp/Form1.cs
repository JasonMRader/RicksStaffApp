using System.DirectoryServices.ActiveDirectory;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace RicksStaffApp
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point lastLocation;


        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(31, 44, 54);
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    ctl.BackColor = Color.FromArgb(31, 44, 54);

                }
            }

            frmOverview overview = new frmOverview();
            overview.TopLevel = false;
            overview.AutoScroll = true;
            pnlNav.Controls.Add(overview);
            overview.Show();
        }

        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {

        }



        private void rdoOverviewForm_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOverviewForm.Checked)
            {
                frmOverview frmOverview = new frmOverview();
                frmOverview.TopLevel = false;
                frmOverview.AutoScroll = true;
                pnlNav.Controls.Add(frmOverview);
                frmOverview.Show();
                pnlButtonSelected.Width = rdoOverviewForm.Width;
                pnlButtonSelected.Top = rdoOverviewForm.Top;
                pnlButtonSelected.Left = rdoOverviewForm.Left;
            }
            else
            {
                pnlNav.Controls.Clear();
            }
        }

        private void rdoNewShiftForm_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNewShiftForm.Checked)
            {
                frmNewShift frmNewShift = new frmNewShift();
                frmNewShift.TopLevel = false;
                frmNewShift.AutoScroll = true;
                pnlNav.Controls.Add(frmNewShift);
                frmNewShift.Show();
                pnlButtonSelected.Width = rdoNewShiftForm.Width;
                pnlButtonSelected.Top = rdoNewShiftForm.Top;
                pnlButtonSelected.Left = rdoNewShiftForm.Left;
            }
            else
            {
                pnlNav.Controls.Clear();
            }
        }

        private void rdoSettings_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSettings.Checked)
            {
                frmSettings frmSettings = new frmSettings();
                frmSettings.TopLevel = false;
                frmSettings.AutoScroll = true;
                pnlNav.Controls.Add(frmSettings);
                frmSettings.Show();
                pnlButtonSelected.Width = rdoSettings.Width;
                pnlButtonSelected.Top = rdoSettings.Top;
                pnlButtonSelected.Left = rdoSettings.Left;
            }
            else
            {
                pnlNav.Controls.Clear();
            }
        }
    }
}