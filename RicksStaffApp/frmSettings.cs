using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RicksStaffApp
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }
        Panel pnlNewRating = new Panel();
        FlowLayoutPanel flpAdditionAction = new FlowLayoutPanel();
        Label lblNewRating = new Label();
             
            
                      
         
               

        
        

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnNewAction_Click(object sender, EventArgs e)
        {
            frmNewActivity frmNewActivity = new frmNewActivity();
            frmNewActivity.ShowDialog();
        }
    }
}
