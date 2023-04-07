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
    public partial class frmNewActivity : Form
    {
        List<ActivityModifier> activityModifiers = new List<ActivityModifier>();
        string ratingMod_1 = string.Empty;
        string ratingMod_2 = string.Empty;
        string ratingMod_3 = string.Empty;

        RadioButton rdoModOption_1 = new RadioButton();

        RadioButton rdoModOption_2 = new RadioButton();
        RadioButton rdoModOption_3 = new RadioButton();
        private bool isDragging = false;
        private Point lastLocation;
        private void ClearModArea()
        {
            foreach (Control c in flowModOptions.Controls)
            {
                c.Visible = false;
            }
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
        public frmNewActivity()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void btnExitAddActivity_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewActivity_Load(object sender, EventArgs e)
        {

        }

        private void txtNewActivityName_TextChanged(object sender, EventArgs e)
        {
            lblNewActivityName.Text = txtNewActivityName.Text;
        }

        private void txtNewActivityBase_TextChanged(object sender, EventArgs e)
        {
            int rating = Int32.Parse(txtNewActivityBase.Text);
            if (rating < -5 || rating > 5)
            {
                MessageBox.Show("The base rating change of an activity cannot be higher than 5 or lower than -5");
                if (rating < -5)
                {
                    txtNewActivityBase.Text = "-5";
                }
                else
                {
                    txtNewActivityBase.Text = "5";
                }
            }
            else
            {


                if (rating < 0)
                {
                    pnlNewActivityName.BackColor = UIHelper.BadColor;
                    pnlNewActivityRating.BackColor = UIHelper.BadColor;
                    lblNewActivityBaseRating.Text = txtNewActivityBase.Text;
                    picUpDown.Image = Properties.Resources.Down_Arrow;
                }
                if (rating > 0)
                {
                    pnlNewActivityName.BackColor = UIHelper.GoodColor;
                    pnlNewActivityRating.BackColor = UIHelper.GoodColor;
                    lblNewActivityBaseRating.Text = "+" + txtNewActivityBase.Text;
                    picUpDown.Image = Properties.Resources.Up_Arrow1;
                }
                if (rating == 0)
                {
                    pnlNewActivityName.BackColor = UIHelper.NeutralColor;
                    pnlNewActivityRating.BackColor = UIHelper.NeutralColor;
                    lblNewActivityBaseRating.Text = txtNewActivityBase.Text;
                    picUpDown.Image = null;
                }
            }



        }

        private void btnBaseUp_Click(object sender, EventArgs e)
        {
            int rating = Int32.Parse(txtNewActivityBase.Text);
            rating += 1;
            txtNewActivityBase.Text = rating.ToString();
        }

        private void btnBaseDown_Click(object sender, EventArgs e)
        {
            int rating = Int32.Parse(txtNewActivityBase.Text);
            rating -= 1;
            txtNewActivityBase.Text = rating.ToString();
        }

        private void txtNewActivityBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                // Get the current value of the textbox
                int value = 0;
                if (!int.TryParse(txtNewActivityBase.Text, out value))
                {
                    // Default to 0 if the textbox doesn't contain a valid integer
                    value = 0;
                }

                // Increment or decrement the value depending on which key was pressed
                if (e.KeyCode == Keys.Up)
                {
                    value++;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    value--;
                }

                // Set the new value back in the textbox
                txtNewActivityBase.Text = value.ToString();

                // Prevent the key from being processed further
                e.Handled = true;
            }
        }

        private void btnAddEitherOrMod_Click(object sender, EventArgs e)
        {
            ClearModArea();
            pnlEitherOr_1.Visible = true;
        }

        private void rdoAdd_2_rdos_CheckedChanged(object sender, EventArgs e)
        {
            flowEitherOr_2.Visible = true;
            pnlEitherOrOption_3.Visible = false;
            //RadioButton modOption_1 = new RadioButton();
            //RadioButton modOption_2 = new RadioButton();
            rdoModOption_1.Location = new Point(1, 15);
            flowModifierPreview.Controls.Add(rdoModOption_1);
            flowModifierPreview.Controls.Add(rdoModOption_2);
            flowModifierPreview.Controls.Remove(rdoModOption_3);
            rdoModOption_1.Margin = new System.Windows.Forms.Padding(0);
            rdoModOption_2.Margin = new System.Windows.Forms.Padding(0);
            rdoModOption_3.Margin = new System.Windows.Forms.Padding(0);
        }

        private void rdoAdd_3_rdos_CheckedChanged(object sender, EventArgs e)
        {
            flowEitherOr_2.Visible = true;
            pnlEitherOrOption_3.Visible = true;
            flowModifierPreview.Controls.Add(rdoModOption_3);
        }

        private void txtEitherOrOption_1Name_TextChanged(object sender, EventArgs e)
        {
            flowModifierPreview.Visible = true;
            rdoModOption_1.Text = txtEitherOrOption_1Name.Text + " (" + nudEitherOr_1_Mod_Adjustment.Value.ToString() + ")";
        }

        private void txtEitherOrName_TextChanged(object sender, EventArgs e)
        {
            lblModPreviewName.Text = txtEitherOrName.Text;
        }

        private void txtEitherOrOption_2Name_TextChanged(object sender, EventArgs e)
        {
            rdoModOption_2.Text = txtEitherOrOption_2Name.Text + " (" + nudEitherOr_2_Mod_Adjustment.Value.ToString() + ")";
        }

        private void txtEitherOrOption_3Name_TextChanged(object sender, EventArgs e)
        {
            rdoModOption_3.Text = txtEitherOrOption_3Name.Text + " (" + nudEitherOr_3_Mod_Adjustment.Value.ToString() + ")";
        }

        private void nudEitherOr_1_Mod_Adjustment_ValueChanged(object sender, EventArgs e)
        {
            rdoModOption_1.Text = txtEitherOrOption_1Name.Text + " (" + nudEitherOr_1_Mod_Adjustment.Value.ToString() + ")";
        }

        private void nudEitherOr_2_Mod_Adjustment_ValueChanged(object sender, EventArgs e)
        {
            rdoModOption_2.Text = txtEitherOrOption_2Name.Text + " (" + nudEitherOr_2_Mod_Adjustment.Value.ToString() + ")";
        }

        private void nudEitherOr_3_Mod_Adjustment_ValueChanged(object sender, EventArgs e)
        {
            rdoModOption_1.Text = txtEitherOrOption_1Name.Text + " (" + nudEitherOr_1_Mod_Adjustment.Value.ToString() + ")";
        }

        private void btnAddModifier_Click(object sender, EventArgs e)
        {
            //// Create a new FlowLayoutPanel to hold the copied controls
            //FlowLayoutPanel pnlNewMod = new FlowLayoutPanel();
            //pnlNewMod.FlowDirection = FlowDirection.LeftToRight;
            //pnlNewMod.AutoSize = true;
            //pnlNewMod.BackColor = Activity.NeutralColor;
            //pnlNewMod.WrapContents = true;
            //pnlNewMod.MaximumSize = new Size(370, 200);

            //// Copy the Label control
            //Label sourceLabel = flowModifierPreview.Controls.OfType<Label>().FirstOrDefault();
            //if (sourceLabel != null)
            //{
            //    Label targetLabel = new Label();
            //    targetLabel.Text = sourceLabel.Text;
            //    targetLabel.AutoSize = false;
            //    targetLabel.TextAlign = ContentAlignment.MiddleCenter;
            //    targetLabel.Size = sourceLabel.Size;
            //    pnlNewMod.Controls.Add(targetLabel);
            //}

            //// Copy the RadioButton controls
            //foreach (RadioButton sourceRadioButton in flowModifierPreview.Controls.OfType<RadioButton>())
            //{
            //    RadioButton targetRadioButton = new RadioButton();
            //    targetRadioButton.Text = sourceRadioButton.Text;
            //    targetRadioButton.AutoSize = true;
            //    targetRadioButton.Margin = new System.Windows.Forms.Padding(0);
            //    targetRadioButton.Checked = sourceRadioButton.Checked;
            //    pnlNewMod.Controls.Add(targetRadioButton);
            //}

            //// Add the copied controls to the form
            //flowNewActivityDisplay.Controls.Add(pnlNewMod);


        }

        private void btnNewCheckMod_Click(object sender, EventArgs e)
        {
            flowModifierPreview.Visible = true;
            ClearModArea();
            pnlCheckMod_1.Visible = true;
            flowCheckBoxOptions_2.Visible = true;
        }

        private void rdo_1_Check_CheckedChanged(object sender, EventArgs e)
        {
            pnlCheckSecond.Visible = false;
            pnlCheckThird.Visible = false;
            pnlCheckFourth.Visible = false;
        }

        private void rdo_2_Check_CheckedChanged(object sender, EventArgs e)
        {
            pnlCheckSecond.Visible = true;
            pnlCheckThird.Visible = false;
            pnlCheckFourth.Visible = false;
        }

        private void rdo_3_Check_CheckedChanged(object sender, EventArgs e)
        {
            pnlCheckSecond.Visible = true;
            pnlCheckThird.Visible = true;
            pnlCheckFourth.Visible = false;
        }

        private void rdo_4_Check_CheckedChanged(object sender, EventArgs e)
        {
            pnlCheckSecond.Visible = true;
            pnlCheckThird.Visible = true;
            pnlCheckFourth.Visible = true;
        }

        private void btnNewSeverityMod_Click(object sender, EventArgs e)
        {
            flowModifierPreview.Visible = true;
        }
    }
}
