//using Microsoft.Office.Interop.Excel;

using System.Data.SQLite;
using System.Data;
using System.Drawing.Drawing2D;
//using Microsoft.Office.Interop.Excel;
//using Microsoft.Office.Interop.Excel;

namespace RicksStaffApp
{
    public static class UIHelper
    {
        //Make factory Pattern? at least more modular
        public static Color GoodColor = Color.FromArgb(192, 223, 161);
        public static Color BadColor = Color.FromArgb(226, 163, 199);
        public static Color NeutralColor = Color.FromArgb(184, 184, 243);
        public static Color DefaultButton = Color.FromArgb(167, 204, 237);
        public static Color RatingTen = Color.FromArgb(0, 255, 0);
        public static Color RatingNine = Color.FromArgb(100, 255, 0);
        public static Color RatingEight = Color.FromArgb(150, 255, 0);
        public static Color RatingSeven = Color.FromArgb(200, 255, 0);
        public static Color RatingSix = Color.FromArgb(215, 255, 0);
        public static Color RatingFive = Color.FromArgb(255, 255, 0);
        public static Color RatingFour = Color.FromArgb(255, 220, 0);
        public static Color RatingThree = Color.FromArgb(255, 180, 0);
        public static Color RatingTwo = Color.FromArgb(255, 125, 0);
        public static Color RatingOne = Color.FromArgb(255, 40, 0);
        public static Color RatingZero = Color.FromArgb(255, 0, 0);
        public static Font WeekDayDisplay = new Font("Bahnschrift SemiBold", 14, FontStyle.Bold);
        public static Font DateDisplay = new Font("Bahnschrift SemiLight SemiConde", 12, FontStyle.Bold);
        public static Font ButtonDisplay = new Font("Gill Sans MT", 12, FontStyle.Regular);
        public static Font RatingDisplay = new Font("MS Reference Sans Serif", 12, FontStyle.Bold);
        //replace image method
        static Image stars = Image.FromFile("C:\\Users\\Jason\\OneDrive\\Source\\Repos\\RicksStaffApp\\RicksStaffApp\\Resources\\5 Stars.png");
        public static string ToOrdinalString(this DateTime date)
        {
            var day = date.Day;
            var dayString = day.ToString();

            // Add the correct suffix to the day.
            string suffix = string.Empty;
            if (day % 100 >= 11 && day % 100 <= 13)
                suffix = "th";
            else if (day % 10 == 1)
                suffix = "st";
            else if (day % 10 == 2)
                suffix = "nd";
            else if (day % 10 == 3)
                suffix = "rd";
            else
                suffix = "th";

            // Format the date.
            return string.Format("{0} {1}{2}, {3}", date.ToString("MMM"), dayString, suffix, date.ToString("yy"));
        }

        //static Image StarsTest = Properties.Resources._2_5_StarsTest;
        //static Image StarsDisplayed = Properties.Resources._5_Stars;
        private static Panel CreatePanel(int width, int height)
        {
            Panel panel = new Panel();
            panel.Width = width;
            panel.Height = height;
            panel.BackColor = MyColors.LightHighlight;
            panel.BorderStyle = BorderStyle.None;
            panel.Margin = new Padding(0);
            panel.Padding = new Padding(0);

            return panel;
        }
        private static FlowLayoutPanel CreateFlowPanel(int width, int height)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            //panel.Width = width;
            //panel.Height = height;
            panel.BackColor = MyColors.LightHighlight;
            panel.BorderStyle = BorderStyle.None;
            panel.Margin = new Padding(0);
            panel.Padding = new Padding(0);
            panel.AutoSize = true;
            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.MaximumSize = new Size(width-30, 0);
            panel.MinimumSize = new Size(width-30, 0);
            return panel;
        }
        private static Button CreateButtonTemplate (int width, int height, string buttonText)
        {
            Button button = new Button();
            button.Text = buttonText;
            button.Size = new Size(width, height);
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = DefaultButton;
            button.Margin = new Padding(0, 0, 0, 0);
            return button;
        }
        private static Label CreateLabel (int width, int height, string text)
        {
            Label label = new Label();
            label.Text = text;
            label.Width = width;
            label.Height = height;
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleCenter;
            return label;
        }
        //public static Image AssignColor (Image starsImage, float rating)
        //{
        //    Bitmap resultImage = new Bitmap(starsImage.Width, starsImage.Height);
        //    Color starColor;

        //    using (Graphics graphics = Graphics.FromImage(resultImage))
        //    {
        //        // Draw the starsImage onto the resultImage
        //        graphics.DrawImage(starsImage, Point.Empty);

        //        // Define the region that corresponds to the stars inside the image
        //        GraphicsPath starsRegion = new GraphicsPath();
        //        starsRegion.AddPolygon(new[]
        //        {
        //    new Point(13, 0),
        //    new Point(16, 8),
        //    new Point(24, 9),
        //    new Point(18, 15),
        //    new Point(20, 23),
        //    new Point(13, 19),
        //    new Point(6, 23),
        //    new Point(8, 15),
        //    new Point(2, 9),
        //    new Point(10, 8)
        //});

        //        // Create a region from the stars path
        //        Region starsRegionMask = new Region(starsRegion);

        //        // Set the clipping region of the graphics object to the stars region
        //        graphics.SetClip(starsRegionMask, CombineMode.Intersect);

        //        // Apply the corresponding color based on the rating
                
        //        if (rating >= 10 || rating >= 9.5)
        //        {
        //            starColor = RatingTen;
        //        }
        //        else if (rating < 9.5 && rating >= 8.5)
        //        {
        //            starColor = RatingNine;
        //        }
        //        // Add more cases for other ratings and their corresponding colors

        //        // Fill the clipped region with the corresponding color
        //        using (Brush brush = new SolidBrush(starColor))
        //        {
        //            graphics.FillRegion(brush, graphics.Clip);
        //        }
        //    }
        //    return resultImage;
        //}
        public static Image GetStars(float rating)
        {
            Image starsImage;
            //Color starColor = Color.White;
            switch (rating)
            {
                case float r when r >= 10 || r >= 9.5:
                    starsImage = Properties.Resources.TenStars;
                    //starColor = RatingTen;
                    break;
                case float r when r < 9.5 && r >= 8.5:
                    starsImage = Properties.Resources.NineStars;
                    //starColor = RatingNine;
                    break;
                case float r when r < 8.5 && r >= 7.5:
                    starsImage = Properties.Resources.EightStars;
                    //starColor = RatingEight;
                    break;
                case float r when r < 7.5 && r >= 6.5:
                    starsImage = Properties.Resources.SevenStars;
                    //starColor = RatingSeven;
                    break;
                case float r when r < 6.5 && r >= 5.5:
                    starsImage = Properties.Resources.SixStars;
                    //starColor = RatingSix;
                    break;
                case float r when r < 5.5 && r >= 4.5:
                    starsImage = Properties.Resources.FiveStars;
                    //starColor = RatingFive;
                    break;
                case float r when r < 4.5 && r >= 3.5:
                    starsImage = Properties.Resources.FourStars;
                    //starColor = RatingFour;
                    break;
                case float r when r < 3.5 && r >= 2.5:
                    starsImage = Properties.Resources.ThreeStars;
                    //starColor = RatingThree;
                    break;
                case float r when r < 2.5 && r >= 1.5:
                    starsImage = Properties.Resources.TwoStars;
                    //starColor = RatingTwo;
                    break;
                case float r when r < 1.5 && r >= 0.5:
                    starsImage = Properties.Resources.OneStar;
                    //starColor = RatingOne;
                    break;
                case float r when r < 0.5:
                    starsImage = Properties.Resources.NoStarsZero;
                    //starColor = RatingZero;
                    break;
                default:
                    starsImage = Properties.Resources.No_Stars; // Set a default image if the rating doesn't match any of the above cases
                    //starColor = RatingZero;
                    break;
            }
            return starsImage;
        //    Bitmap resultImage = new Bitmap(starsImage.Width, starsImage.Height);

        //    using (Graphics graphics = Graphics.FromImage(resultImage))
        //    {
        //        // Draw the starsImage onto the resultImage
        //        graphics.DrawImage(starsImage, Point.Empty);

        //        // Define the region that corresponds to the stars inside the image
        //        GraphicsPath starsRegion = new GraphicsPath();
        //        starsRegion.AddPolygon(new[]
        //        {
        //    new Point(13, 0),
        //    new Point(16, 8),
        //    new Point(24, 9),
        //    new Point(18, 15),
        //    new Point(20, 23),
        //    new Point(13, 19),
        //    new Point(6, 23),
        //    new Point(8, 15),
        //    new Point(2, 9),
        //    new Point(10, 8)
        //});

        //        // Create a region from the stars path
        //        Region starsRegionMask = new Region(starsRegion);

        //        // Set the clipping region of the graphics object to the stars region
        //        graphics.SetClip(starsRegionMask, CombineMode.Intersect);

        //        // Apply the corresponding color based on the rating
        //        //Color starColor;
        //        if (rating >= 10 || rating >= 9.5)
        //        {
        //            starColor = RatingTen;
        //        }
        //        if (rating < 9.5 && rating >= 8.5)
        //        {
        //            starColor = RatingNine;
        //        }
        //        if (rating < 8.5 && rating >= 7.5)
        //        {
        //            starColor = RatingEight;
        //        }
        //        if ( rating < 7.5 && rating >= 6.5)
        //        {
        //            starColor = RatingSeven;
        //        }
        //        else
        //        {
        //            starColor = RatingSix;
        //        }
        //        // Add more cases for other ratings and their corresponding colors

        //        // Fill the clipped region with the corresponding color
        //        using (Brush brush = new SolidBrush(starColor))
        //        {
        //            graphics.FillRegion(brush, graphics.Clip);
        //        }
        //    }
            
            //using (Graphics graphics = Graphics.FromImage(StarsDisplayed))
            //using (Brush brush = new SolidBrush(starColor))
            //{
            //    graphics.FillRectangle(brush, 0, 0, StarsDisplayed.Width, StarsDisplayed.Height);
            //}
            //    Bitmap resultImage = new Bitmap(StarsDisplayed.Width, StarsDisplayed.Height);
            //    using (Graphics graphics = Graphics.FromImage(resultImage))
            //    {
            //        graphics.DrawImage(StarsDisplayed, Point.Empty); // Draw the stars image onto the result image

            //        // Define the region that corresponds to the stars inside the image
            //        GraphicsPath starsRegion = new GraphicsPath();
            //        starsRegion.AddPolygon(new[]
            //        {
            //    new Point(2, 29),
            //    new Point(17, 28),
            //    new Point(23, 45),
            //    new Point(15, 61),
            //    new Point(2, 56),
            //});

            //        // Create a region from the stars path
            //        Region starsRegionMask = new Region(starsRegion);

            //        // Set the clipping region of the graphics object to the stars region
            //        graphics.SetClip(starsRegionMask, CombineMode.Intersect);

            //        // Fill the clipped region with the desired color
            //        using (Brush brush = new SolidBrush(RatingTen))
            //        {
            //            graphics.FillRegion(brush, graphics.Clip);
            //        }
            //    }

            //    return resultImage;

            //    //return StarsDisplayed;
        }
        private static PictureBox CreateRatingPictureBox (int width, int height, float rating)
        {
            PictureBox pictureBox = new PictureBox ();
            pictureBox.Width = width; 
            pictureBox.Height = height;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = GetStars(rating);
            pictureBox.Margin = new Padding(0, 0, 0, 0);
            pictureBox.Padding = new Padding(0, 0, 0, 0);
            return pictureBox;
        }

        //add panel for each incident in EmployeeShift with a label that has the name of the activity and a label that has the rating change
        public static Color GetBackColor(int rating)
        {
            Color backcolor = new Color();
            if (rating > 0)
            {
                backcolor = GoodColor;
                //picUpDown.Image = Properties.Resources.Up_Arrow1;
            }
            else
            {
                backcolor = BadColor;
                //picUpDown.Image = Properties.Resources.Down_Arrow;
            }
            return backcolor;
        }
        public static Image GetRatingImage(int rating)
        {
            if (rating > 0)
            {
                return Properties.Resources.Up_Arrow1;
            }
            if (rating < 0)
            {
                return Properties.Resources.Down_Arrow;
            }
            else
            {
                return null;
            }
        }
        public static Label CreateNameLable(string display)
        {
            Label lblLable = new Label();
            lblLable.Text = display;
            lblLable.Size = new Size(70, 30);
            lblLable.ForeColor = Color.Black;
            lblLable.TextAlign = ContentAlignment.MiddleCenter;
            return lblLable;
        }
        //public static void UpdateIncidentList()

        public static void CreateIncidentFrequencyPanels(List<Incident> incidentList, FlowLayoutPanel flowDisplay)
        {
            var groupedIncidents = incidentList.GroupBy(i => i.Name);
            var sortedIncidents = groupedIncidents.OrderByDescending(g => g.Count());
            

            foreach (var group in sortedIncidents)
            {
                var positiveIncident = group.Where(i => i.IncidentRatingChange > 0);
                var negativeIncident = group.Where(i => i.IncidentRatingChange < 0);

                Panel incidentPanel = CreateFlowPanel(200, 50);
                incidentPanel.MinimumSize = new Size(200, 50);
                incidentPanel.Margin = new Padding(0, 2, 2, 0);
                Label incidentLabel = CreateLabel(140, 50, group.Key);
                Label incidentFrequency = CreateLabel(45, 50, group.Count().ToString() + "X");
                incidentLabel.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold); 
                incidentFrequency.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
                if (group.FirstOrDefault().IncidentRatingChange > 0)
                {
                    incidentPanel.BackColor = GoodColor;
                }
                else if (group.FirstOrDefault().IncidentRatingChange < 0)
                {
                    incidentPanel.BackColor = BadColor;
                }
                else
                {
                    incidentPanel.BackColor = NeutralColor;
                }
                //if (positiveIncident.Count() > 0)
                //{
                //    incidentPanel.BackColor = GoodColor;
                //}
                //if (negativeIncident.Count() > 0)
                //{
                //    incidentPanel.BackColor = BadColor;
                //}
                //else
                //{
                //    incidentPanel.BackColor = NeutralColor;
                //}
                
                
                incidentPanel.Controls.Add(incidentLabel);
                incidentPanel.Controls.Add(incidentFrequency);
                flowDisplay.Controls.Add(incidentPanel);
            }
        }

        public static void CreateIncidentPanels_REPLACE(List<Incident> incidentList, FlowLayoutPanel flowDisplay, List<Shift> shifts)
        {
            List<Activity> activities = SqliteDataAccess.LoadActivities();
            Incident.AssignActivitiesToIncidents_REPLACE(shifts, activities);
            // Clear existing panels
            //flowEmployeeDisplay.Controls.Clear();

            foreach (Incident incident in incidentList)
            {
                FlowLayoutPanel incidentPanel = incident.CreateFlowLayoutPanel();


                flowDisplay.Controls.Add(incidentPanel);


            }
        }
        public static void CreateIncidentPanels(List<Incident> incidentList, FlowLayoutPanel flowDisplay)
        {
            List<Activity> activities = SqliteDataAccess.LoadActivities();
            Incident.AssignActivitiesToIncidents(incidentList, activities);
            // Clear existing panels
            //flowDisplay.Controls.Clear();


            foreach (Incident incident in incidentList)
            {
                FlowLayoutPanel incidentPanel = incident.CreateFlowLayoutPanel();
                incidentPanel.AutoSize = false;
                incidentPanel.Width = 425;
                incidentPanel.Height = 30;


                flowDisplay.Controls.Add(incidentPanel);


            }
        }
        public static void CreateShiftPanels(List<Shift> shiftList, FlowLayoutPanel flowEmployeeDisplay)
        {
            // Clear existing panels
            flowEmployeeDisplay.Controls.Clear();

            // Loop through employee list and create a panel for each employee
            foreach (Shift shift in shiftList)
            {
                FlowLayoutPanel activityPanelContainer = new FlowLayoutPanel();
                //activityPanelContainer.Size = new Size(430, 30);
                activityPanelContainer.AutoSize = true;
                activityPanelContainer.MinimumSize = new Size(470, 30);
                activityPanelContainer.MaximumSize = new Size(470, 200);
                activityPanelContainer.BackColor = MyColors.LightHighlight;
                activityPanelContainer.Margin = new Padding(0, 0, 0, 5);


                FlowLayoutPanel shiftPanel = new FlowLayoutPanel();
                shiftPanel.FlowDirection = FlowDirection.LeftToRight;
                shiftPanel.WrapContents = false;
                shiftPanel.AutoSize = true;
                shiftPanel.MaximumSize = new Size(200, 0);
                shiftPanel.MinimumSize = new Size(200, 0);
                shiftPanel.BackColor = MyColors.LightHighlight;
                shiftPanel.Margin = new Padding(1, 1, 1, 1);

                //// Create label for employee name
                Label lblName = new Label();
                lblName.Text = shift.Date.ToString("MM/dd/yyyy");
                lblName.AutoSize = false;
                lblName.Size = new Size(125, 30);
                lblName.TextAlign = ContentAlignment.MiddleCenter;
                shiftPanel.Controls.Add(lblName);








                activityPanelContainer.Controls.Add(shiftPanel);

                //foreach (Position pos in emp.Positions)
                //{
                //    Panel pnlPos = new Panel();
                //    pnlPos.Size = new Size(60, 30);
                //    pnlPos.BackColor = MyColors.PositionColor;
                //    Label lblPos = new Label();
                //    lblPos.Text = pos.Name;
                //    lblPos.Font = new Font(lblPos.Font.FontFamily, 10);
                //    lblPos.AutoSize = false;
                //    lblPos.Size = new Size(60, 30);
                //    lblPos.TextAlign = ContentAlignment.MiddleCenter;
                //    pnlPos.Controls.Add(lblPos);
                //    empPanel.Controls.Add(pnlPos);
                //}
                System.Windows.Forms.Button btnDelete = new System.Windows.Forms.Button();
                btnDelete.Text = "X";
                btnDelete.Margin = new Padding(0, 0, 0, 0);
                btnDelete.Location = new Point(410, 0);
                btnDelete.ForeColor = Color.Black;
                btnDelete.Font = new Font(btnDelete.Font.FontFamily, 10);
                btnDelete.TextAlign = ContentAlignment.MiddleCenter;
                btnDelete.FlatStyle = FlatStyle.Flat;
                btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                btnDelete.FlatAppearance.BorderSize = 0;
                btnDelete.Click += (sender, e) =>
                {
                    // Prompt user to confirm deletion
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this shift?", "Delete Shift", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Delete employee from database
                        SqliteDataAccess.DeleteShift(shift.ID);

                        // Remove employee from list
                        shiftList.Remove(shift);

                        // Update UI
                        CreateShiftPanels(shiftList, flowEmployeeDisplay);
                    }
                };
                btnDelete.Size = new Size(27, 27);
                shiftPanel.Parent.Controls.Add(btnDelete);

                flowEmployeeDisplay.Controls.Add(activityPanelContainer);
                foreach (EmployeeShift es in shift.EmployeeShifts)
                {
                    Label lbl = new Label();
                    lbl.Size = new Size(50, 25);
                    lbl.Text = es.Employee.FullName;
                    activityPanelContainer.Controls.Add(lbl);
                }


            }
        }
        public static void CreateActivityPanels(List<Activity> activityList, FlowLayoutPanel flowFormDisplay)
        {
            // Clear existing panels
            flowFormDisplay.Controls.Clear();
            int containerWidth = flowFormDisplay.Width;
            int firstContainer = (int)(containerWidth / 1.1);
            int nameWidth = (int)containerWidth / 4;
            int ratingWidth = (int)containerWidth / 9;
            int modPanelWidth = (int)containerWidth / 3;

            // Loop through employee list and create a panel for each employee
            foreach (Activity activity in activityList)
            {
                FlowLayoutPanel activityPanelContainer = new FlowLayoutPanel();
                //activityPanelContainer.Size = new Size(430, 30);
                activityPanelContainer.AutoSize = true;
                activityPanelContainer.MinimumSize = new Size(containerWidth, 30);
                activityPanelContainer.MaximumSize = new Size(containerWidth, 200);
                activityPanelContainer.BackColor = MyColors.LightHighlight;
                activityPanelContainer.Margin = new Padding(0, 0, 0, 5);


                FlowLayoutPanel activityPanel = new FlowLayoutPanel();
                activityPanel.FlowDirection = FlowDirection.LeftToRight;
                activityPanel.WrapContents = false;
                activityPanel.AutoSize = true;
                activityPanel.MaximumSize = new Size(firstContainer, 30);
                activityPanel.MinimumSize = new Size(firstContainer, 0);
                activityPanel.BackColor = MyColors.LightHighlight;
                activityPanel.Margin = new Padding(1, 1, 1, 1);

                //// Create label for employee name
                Label lblName = new Label();
                lblName.Text = activity.Name + "  (ID " + activity.ID.ToString() + ")";
                lblName.AutoSize = false;
                lblName.Size = new Size(nameWidth, 30);
                lblName.TextAlign = ContentAlignment.MiddleCenter;
                activityPanel.Controls.Add(lblName);

                Label lblBaseRating = new Label();
                lblBaseRating.Text = activity.BaseRatingImpact.ToString();
                lblBaseRating.AutoSize = false;
                lblBaseRating.Size = new Size(ratingWidth, 30);
                lblBaseRating.TextAlign = ContentAlignment.MiddleCenter;
                activityPanel.Controls.Add(lblBaseRating);

                Panel pnlModDisplay = new Panel();
                pnlModDisplay.Size = new Size(modPanelWidth, 30);
                pnlModDisplay.BackColor = MyColors.NeutralColor;
                Label modNumber = new Label();
                modNumber.Text = activity.ActivityModifiers.Count.ToString() + "  Mods";
                modNumber.AutoSize = false;
                modNumber.Size = new Size(((int)modPanelWidth / 3), 29);
                modNumber.TextAlign = ContentAlignment.MiddleCenter;
                pnlModDisplay.Controls.Add(modNumber);
                activityPanel.Controls.Add(pnlModDisplay);
                activityPanelContainer.Controls.Add(activityPanel);
                if (activity.ActivityModifiers.Count > 0)
                {
                    System.Windows.Forms.Button btnViewMods = new System.Windows.Forms.Button();
                    btnViewMods.Text = "View Mods";
                    btnViewMods.BackColor = Color.Black;
                    btnViewMods.Margin = new Padding(0, 0, 0, 0);
                    //btnViewMods.Location = new Point(410, 0);
                    btnViewMods.ForeColor = Color.LightBlue;
                    btnViewMods.Font = new Font(btnViewMods.Font.FontFamily, 10);
                    btnViewMods.TextAlign = ContentAlignment.MiddleCenter;
                    btnViewMods.FlatStyle = FlatStyle.Flat;
                    btnViewMods.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                    btnViewMods.Location = new Point((int)(modPanelWidth / 2.9), 1);
                    btnViewMods.FlatAppearance.BorderSize = 0;
                    btnViewMods.Click += (sender, e) =>
                    {

                        foreach (var mod in activity.ActivityModifiers)
                        {
                            CheckBox ck = new CheckBox();
                            ck.Text = mod.Name;
                            activityPanelContainer.Controls.Add(ck);
                        }
                    };
                    btnViewMods.Size = new Size(modPanelWidth - (int)(modPanelWidth / 2.9), 27);
                    pnlModDisplay.Controls.Add(btnViewMods);
                }





                //foreach (Position pos in emp.Positions)
                //{
                //    Panel pnlPos = new Panel();
                //    pnlPos.Size = new Size(60, 30);
                //    pnlPos.BackColor = MyColors.PositionColor;
                //    Label lblPos = new Label();
                //    lblPos.Text = pos.Name;
                //    lblPos.Font = new Font(lblPos.Font.FontFamily, 10);
                //    lblPos.AutoSize = false;
                //    lblPos.Size = new Size(60, 30);
                //    lblPos.TextAlign = ContentAlignment.MiddleCenter;
                //    pnlPos.Controls.Add(lblPos);
                //    empPanel.Controls.Add(pnlPos);
                //}
                System.Windows.Forms.Button btnDelete = new System.Windows.Forms.Button();
                btnDelete.Text = "X";
                btnDelete.Margin = new Padding(0, 0, 0, 0);
                btnDelete.Location = new Point(410, 0);
                btnDelete.ForeColor = Color.Black;
                btnDelete.Font = new Font(btnDelete.Font.FontFamily, 10);
                btnDelete.TextAlign = ContentAlignment.MiddleCenter;
                btnDelete.FlatStyle = FlatStyle.Flat;
                btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                btnDelete.FlatAppearance.BorderSize = 0;
                btnDelete.Click += (sender, e) =>
                {
                    // Prompt user to confirm deletion
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this activity?", "Delete Activity", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Delete employee from database
                        SqliteDataAccess.DeleteActivity(activity.ID);

                        // Remove employee from list
                        activityList.Remove(activity);

                        // Update UI
                        CreateActivityPanels(activityList, flowFormDisplay);
                    }
                };
                btnDelete.Size = new Size(27, 27);
                activityPanelContainer.Controls.Add(btnDelete);

                flowFormDisplay.Controls.Add(activityPanelContainer);
            }
        }
        //public static void CreateActivityPanelsForEmpShift(List<Incident> incidents ,List<Activity> activityList, FlowLayoutPanel flowFormDisplay, FlowLayoutPanel flowToAdd)
        //{
        //    // Clear existing panels
        //    flowFormDisplay.Controls.Clear();
        //    CreateIncidentPanelForEmpShift(incidents, flowToAdd);

        //    foreach (Activity activity in activityList)
        //    {
        //        FlowLayoutPanel activityPanelContainer = activity.CreateFlowLayoutPanel(flowFormDisplay.Width, flowToAdd);

        //        flowFormDisplay.Controls.Add(activityPanelContainer);
        //    }                      


        //}

        public static void AddOneIncidentForEmpShift(Incident incident, FlowLayoutPanel flowDisplay)
        {
            int containerWidth = flowDisplay.Width;
            int firstContainer = (int)(containerWidth - 40);
            int nameWidth = (int)containerWidth / 4;
            int ratingWidth = (int)containerWidth / 9;
            int modPanelWidth = (int)containerWidth / 3;

            FlowLayoutPanel pnlContainer = new FlowLayoutPanel();
            //activityPanelContainer.Size = new Size(430, 30);
            pnlContainer.AutoSize = true;
            pnlContainer.MinimumSize = new Size(containerWidth, 30);
            pnlContainer.MaximumSize = new Size(containerWidth, 200);
            pnlContainer.BackColor = MyColors.LightHighlight;
            pnlContainer.Margin = new Padding(0, 0, 0, 5);


            FlowLayoutPanel incidentPanel = new FlowLayoutPanel();
            incidentPanel.FlowDirection = FlowDirection.LeftToRight;
            incidentPanel.WrapContents = false;
            incidentPanel.AutoSize = true;
            incidentPanel.MaximumSize = new Size(firstContainer, 30);
            incidentPanel.MinimumSize = new Size(firstContainer, 0);
            incidentPanel.BackColor = GetBackColor(incident.BaseRatingImpact);

            Label lblName = new Label();
            lblName.Text = incident.Name;
            lblName.AutoSize = false;
            lblName.Size = new Size(nameWidth, 30);
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            incidentPanel.Controls.Add(lblName);

            Label lblBaseRating = new Label();
            lblBaseRating.Text = incident.BaseRatingDisplay;
            lblBaseRating.AutoSize = false;
            lblBaseRating.Size = new Size(ratingWidth, 30);
            lblBaseRating.TextAlign = ContentAlignment.MiddleCenter;
            incidentPanel.Controls.Add(lblBaseRating);

            pnlContainer.Controls.Add(incidentPanel);
            Button btnDelete = new Button();
            btnDelete.Text = "X";
            btnDelete.Size = new Size(30, 30);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Margin = new Padding(2, 2, 0, 0);

            // Attach the click event to the delete button
            btnDelete.Click += (sender, e) =>
            {
                // Remove the pnlContainer from the flowDisplay
                flowDisplay.Controls.Remove(pnlContainer);

                // Perform any additional actions needed to delete the incident from the data source
                //DeleteIncident(inc);
            };

            // Add the delete button to the pnlContainer
            pnlContainer.Controls.Add(btnDelete);
            flowDisplay.Controls.Add(pnlContainer);

        }
        public static void RemoveThisIncident()
        {

        }
        //public static void CreateIncidentPanelForEmpShift(List<Incident> incidents, FlowLayoutPanel flowDisplay)
        //{
        //    int containerWidth = flowDisplay.Width;
        //    int firstContainer = (int)(containerWidth - 40);
        //    int nameWidth = (int)containerWidth / 4;
        //    int ratingWidth = (int)containerWidth / 9;
        //    int modPanelWidth = (int)containerWidth / 3;
        //    flowDisplay.Controls.Clear();
        //    foreach (Incident inc in incidents)
        //    {

        //        FlowLayoutPanel pnlContainer = new FlowLayoutPanel();
        //        //activityPanelContainer.Size = new Size(430, 30);
        //        pnlContainer.AutoSize = true;
        //        pnlContainer.MinimumSize = new Size(containerWidth, 30);
        //        pnlContainer.MaximumSize = new Size(containerWidth, 200);
        //        pnlContainer.BackColor = MyColors.LightHighlight;
        //        pnlContainer.Margin = new Padding(0, 0, 0, 5);


        //        FlowLayoutPanel incidentPanel = new FlowLayoutPanel();
        //        incidentPanel.FlowDirection = FlowDirection.LeftToRight;
        //        incidentPanel.WrapContents = false;
        //        incidentPanel.AutoSize = true;
        //        incidentPanel.MaximumSize = new Size(firstContainer, 30);
        //        incidentPanel.MinimumSize = new Size(firstContainer, 0);
        //        incidentPanel.BackColor = GetBackColor(inc.BaseRatingImpact);

        //        Label lblName = new Label();
        //        lblName.Text = inc.Name;
        //        lblName.AutoSize = false;
        //        lblName.Size = new Size(nameWidth, 30);
        //        lblName.TextAlign = ContentAlignment.MiddleCenter;
        //        incidentPanel.Controls.Add(lblName);

        //        Label lblBaseRating = new Label();
        //        lblBaseRating.Text = inc.BaseRatingDisplay;
        //        lblBaseRating.AutoSize = false;
        //        lblBaseRating.Size = new Size(ratingWidth, 30);
        //        lblBaseRating.TextAlign = ContentAlignment.MiddleCenter;
        //        incidentPanel.Controls.Add(lblBaseRating);

        //        pnlContainer.Controls.Add(incidentPanel);
        //        Button btnDelete = new Button();
        //        btnDelete.Text = "X";
        //        btnDelete.Size = new Size(30, 30);
        //        btnDelete.FlatStyle = FlatStyle.Flat;
        //        btnDelete.FlatAppearance.BorderSize = 0;
        //        btnDelete.Margin = new Padding(2, 2, 0, 0);

        //        // Attach the click event to the delete button
        //        btnDelete.Click += (sender, e) =>
        //        {
        //            // Remove the pnlContainer from the flowDisplay
        //            flowDisplay.Controls.Remove(pnlContainer);

        //            // Perform any additional actions needed to delete the incident from the data source
        //            //DeleteIncident(inc);
        //        };

        //        // Add the delete button to the pnlContainer
        //        pnlContainer.Controls.Add(btnDelete);

        //        flowDisplay.Controls.Add(pnlContainer);
        //    }
        //}
        public static void CreateEmployeePanels(List<Employee> employeeList, FlowLayoutPanel flowEmployeeDisplay, Panel parentPanel)
        {
            // Clear existing panels
            flowEmployeeDisplay.Controls.Clear();

            // Loop through employee list and create a panel for each employee
            foreach (Employee emp in employeeList)
            {
                Panel empPanelContainer = CreatePanel(350, 25);                
                empPanelContainer.Margin = new Padding(0, 0, 0, 2);
                
                FlowLayoutPanel empPanel = CreateFlowPanel(350, 25);               
                empPanel.Margin = new Padding(1, 1, 1, 1);

                Button btnName = CreateButtonTemplate(140, 25, emp.FullName);                             
                btnName.Click += (sender, e) =>
                {
                    parentPanel.Controls.Clear();

                    frmViewEmployee viewEmployeeForm = new frmViewEmployee(emp);
                    viewEmployeeForm.TopLevel = false;
                    viewEmployeeForm.FormBorderStyle = FormBorderStyle.None;
                    viewEmployeeForm.Dock = DockStyle.Fill;
                    parentPanel.Controls.Add(viewEmployeeForm);
                    viewEmployeeForm.Show();
                };

                empPanel.Controls.Add(btnName);
                // Create panels for employee positions

                PictureBox pbRating = CreateRatingPictureBox(96, 15, emp.OverallRating);
                Panel RatingPicPanel = CreatePanel(115, 25);
                RatingPicPanel.Margin = new Padding(20, 5, 0, 0);
                RatingPicPanel.Padding = new Padding(15,5,0,5);
                RatingPicPanel.Controls.Add(pbRating);

                empPanel.Controls.Add(RatingPicPanel);

                empPanelContainer.Controls.Add(empPanel);
                
                Label lblRating = new Label();
                lblRating.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                lblRating.Margin = new Padding(0);
                lblRating.Location = new Point(320, 0);
                lblRating.Size = new Size(30, 25);
                lblRating.TextAlign = ContentAlignment.MiddleCenter;
                emp.UpdateOverallRating();
                lblRating.Text = emp.OverallRating.ToString("F1");
               
                empPanelContainer.Controls.Add(lblRating);               

                flowEmployeeDisplay.Controls.Add(empPanelContainer);
            }
        }
        public static void CreateEmployeeOverviewPanels(List<Employee> employeeList, FlowLayoutPanel flowEmployeeDisplay, Panel parentPanel)
        {
            // Clear existing panels
            flowEmployeeDisplay.Controls.Clear();

            // Loop through employee list and create a panel for each employee
            foreach (Employee emp in employeeList)
            {
                Panel empPanelContainer = CreatePanel(500, 50);
                empPanelContainer.Margin = new Padding(0, 0, 0, 2);

                FlowLayoutPanel empPanel = CreateFlowPanel(430, 50);
                empPanel.Margin = new Padding(1, 1, 1, 1);

                Button btnName = CreateButtonTemplate(190, 50, emp.FullName);
                btnName.Font = new Font("Arial", 12, FontStyle.Bold);
                btnName.Click += (sender, e) =>
                {
                    parentPanel.Controls.Clear();

                    frmViewEmployee viewEmployeeForm = new frmViewEmployee(emp);
                    viewEmployeeForm.TopLevel = false;
                    viewEmployeeForm.FormBorderStyle = FormBorderStyle.None;
                    viewEmployeeForm.Dock = DockStyle.Fill;
                    parentPanel.Controls.Add(viewEmployeeForm);
                    viewEmployeeForm.Show();
                };

                empPanel.Controls.Add(btnName);
                // Create panels for employee positions

                PictureBox pbRating = CreateRatingPictureBox(190, 50, emp.OverallRating);
                empPanel.Controls.Add(pbRating);

                empPanelContainer.Controls.Add(empPanel);

                Label lblRating = new Label();
                lblRating.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                lblRating.Font = new Font("Arial", 12, FontStyle.Bold);
                lblRating.Margin = new Padding(0);
                lblRating.Location = new Point(440, 0);
                lblRating.Size = new Size(50, 50);
                lblRating.TextAlign = ContentAlignment.MiddleCenter;
                emp.UpdateOverallRating();
                lblRating.Text = emp.OverallRating.ToString("F1");

                empPanelContainer.Controls.Add(lblRating);

                flowEmployeeDisplay.Controls.Add(empPanelContainer);
            }
        }
        public static void CreateSingleEmployeeShiftPanel(FlowLayoutPanel flowLayoutPanel, List<EmployeeShift> empShifts)
        {
            foreach (EmployeeShift es in empShifts)
            {
                es.UpdateShiftRating();
                FlowLayoutPanel empShiftContainer = CreateFlowPanel(470, 30);

                empShiftContainer.MinimumSize = new Size(470, 30);
                empShiftContainer.MaximumSize = new Size(470, 1000);
                empShiftContainer.Margin = new Padding(0, 0, 0, 5);

                Label lblName = new Label();
                lblName.Text = es.Employee.FullName;
                lblName.Size = new Size(100, 30);
                lblName.TextAlign = ContentAlignment.MiddleCenter;
                empShiftContainer.Controls.Add(lblName);

                Label lblPos = new Label();
                lblPos.Text = es.Position.Name;
                lblPos.Size = new Size(60, 30);
                lblPos.TextAlign = ContentAlignment.MiddleCenter;
                empShiftContainer.Controls.Add(lblPos);

                Label lblShiftRating = new Label();
                //es.UpdateShiftRating();
                lblShiftRating.Text = es.ShiftRating.ToString();
                //foreach(Incident i in es.Incidents)
                //{
                //    es.ShiftRating = es.ShiftRating + in
                //}
                lblShiftRating.Size = new Size(25, 30);
                lblShiftRating.TextAlign = ContentAlignment.MiddleCenter;
                empShiftContainer.Controls.Add(lblShiftRating);

                PictureBox pbRating = new PictureBox();
                pbRating.Size = new Size(90, 30);
                pbRating.SizeMode = PictureBoxSizeMode.Zoom;
                pbRating.Image = GetStars(es.ShiftRating);
                empShiftContainer.Controls.Add(pbRating);

                //Button btnIncidents = CreateButtonTemplate(65, 30, "Incidents");
                //btnIncidents.Click += (sender, e) =>
                //{
                //    CreateIncidentPanels(es.Incidents, empShiftContainer, empShifts);
                //};
                //empShiftContainer.Controls.Add(btnIncidents);

                //Button btnAddIncidents = CreateButtonTemplate(65, 30, "Add/Edit");
                //btnAddIncidents.Click += (sender, e) =>
                //{
                //    //secondPanel.Controls.Clear();
                //    //frmServerShift frmServerShift = new frmServerShift();
                //    //frmServerShift.EmployeeShiftToEdit = es;
                //    //frmServerShift.TopLevel = false;
                //    //secondPanel.Controls.Add(frmServerShift);
                //    //frmServerShift.Show();
                //};
                //empShiftContainer.Controls.Add(btnAddIncidents);

                flowLayoutPanel.Controls.Add(empShiftContainer);

            }
        }
        public static void CreateEmployeeShiftOverviewPanel(EmployeeShift employeeShift, FlowLayoutPanel flowLayoutPanel)
        {

            
            employeeShift.UpdateShiftRating();
            FlowLayoutPanel empShiftContainer = CreateFlowPanel(470, 30);

            empShiftContainer.MinimumSize = new Size(470, 30);
            empShiftContainer.MaximumSize = new Size(470, 1000);
            empShiftContainer.Margin = new Padding(0, 0, 0, 5);

            Label lblWeekday = CreateLabel(75, 30, employeeShift.Shift.DateAsDateTime.ToString("ddd"));
            lblWeekday.Font = WeekDayDisplay;
            empShiftContainer.Controls.Add(lblWeekday);

            Label lblName = CreateLabel(100, 30, employeeShift.Shift.DateAsDateTime.ToOrdinalString());
            lblName.Font = DateDisplay;
            empShiftContainer.Controls.Add(lblName);

            //Label lblPos = CreateLabel(60, 30, employeeShift.Position.Name);
            //empShiftContainer.Controls.Add(lblPos);
            FlowLayoutPanel incidentContainer = CreateFlowPanel(470, 30);
            Button btnIncidents = CreateButtonTemplate(100, 30, employeeShift.Incidents.Count.ToString() + " Incidents");
            btnIncidents.Margin = new Padding(10, 0, 0, 0);
            bool btnClicked = false;
            btnIncidents.Font = ButtonDisplay;
            btnIncidents.Click += (sender, e) =>
            {
                btnClicked = !btnClicked;

                if (btnClicked == true)
                {
                    CreateIncidentPanels(employeeShift.Incidents, incidentContainer);
                    empShiftContainer.Controls.Add(incidentContainer);
                }
                else
                {
                    incidentContainer.Controls.Clear();
                    empShiftContainer.Controls.Remove(incidentContainer);
                }
            };
            empShiftContainer.Controls.Add(btnIncidents);


            PictureBox pbRating = CreateRatingPictureBox(90, 30, employeeShift.ShiftRating);
            pbRating.Margin = new Padding(10, 0, 0, 0);
            empShiftContainer.Controls.Add(pbRating);

            
            

            Label lblShiftRating = CreateLabel(40, 30, employeeShift.ShiftRating.ToString());
            lblShiftRating.Margin = new Padding(5, 0, 0, 0);
            lblShiftRating.Font = RatingDisplay;
            empShiftContainer.Controls.Add(lblShiftRating);

            ////Button btnAddIncidents = CreateButtonTemplate(65, 30, "Add/Edit");
            ////btnAddIncidents.Click += (sender, e) =>
            ////{
            ////    secondPanel.Controls.Clear();
            ////    frmServerShift frmServerShift = new frmServerShift();
            ////    frmServerShift.EmployeeShiftToEdit = employeeShift;
            ////    frmServerShift.TopLevel = false;
            ////    secondPanel.Controls.Add(frmServerShift);
            ////    frmServerShift.Show();
            ////};
            //empShiftContainer.Controls.Add(btnAddIncidents);

            flowLayoutPanel.Controls.Add(empShiftContainer);

            
        }
        public static void CreateEmployeeShiftPanels(List<Shift> shiftList, FlowLayoutPanel flowEmployeeDisplay, DateOnly shiftDate, Panel secondPanel)
        {
            flowEmployeeDisplay.Controls.Clear();
            foreach (Shift shift in shiftList)
            {
                //MessageBox.Show(shift.Date.ToString());
                if (shift.Date == shiftDate)
                {
                    foreach (EmployeeShift es in shift.EmployeeShifts)
                    {
                        es.UpdateShiftRating();
                        FlowLayoutPanel empShiftContainer = CreateFlowPanel(470,30);                       
                      
                        empShiftContainer.MinimumSize = new Size(470, 30);
                        empShiftContainer.MaximumSize = new Size(470, 1000);
                        empShiftContainer.Margin = new Padding(0, 0, 0, 5);

                        Label lblName = CreateLabel(100, 30, es.Employee.FullName);                       
                        empShiftContainer.Controls.Add(lblName);

                        Label lblPos = CreateLabel(60, 30, es.Position.Name);                        
                        empShiftContainer.Controls.Add(lblPos);

                        Label lblShiftRating = CreateLabel(25, 30, es.ShiftRating.ToString());                 
                        empShiftContainer.Controls.Add(lblShiftRating);

                        PictureBox pbRating = CreateRatingPictureBox(90, 30, es.ShiftRating);
                        empShiftContainer.Controls.Add(pbRating);

                        Button btnIncidents = CreateButtonTemplate(65,30,"Incidents");                        
                        btnIncidents.Click += (sender, e) =>
                        {
                            CreateIncidentPanels_REPLACE(es.Incidents, empShiftContainer, shiftList);
                        };
                        empShiftContainer.Controls.Add(btnIncidents);

                        Button btnAddIncidents = CreateButtonTemplate(65, 30, "Add/Edit");                     
                        btnAddIncidents.Click += (sender, e) =>
                        {
                            secondPanel.Controls.Clear();
                            frmServerShift frmServerShift = new frmServerShift();
                            frmServerShift.EmployeeShiftToEdit = es;
                            frmServerShift.TopLevel = false;
                            secondPanel.Controls.Add(frmServerShift);
                            frmServerShift.Show();
                        };
                        empShiftContainer.Controls.Add(btnAddIncidents);

                        flowEmployeeDisplay.Controls.Add(empShiftContainer);
                        
                    }

                }
            }
            

        }
        public static void CreateExcelLoadDisplay()
        {

        }
        public static void CreateOldEmployeePanelsExcel(List<Employee> employeeList, FlowLayoutPanel flowEmployeeDisplay)
        {
            // Clear existing panels
            flowEmployeeDisplay.Controls.Clear();

            // Loop through employee list and create a panel for each employee
            foreach (Employee emp in employeeList)
            {
                Panel empPanelContainer = new Panel();
                empPanelContainer.Size = new Size(180, 22);
                empPanelContainer.BackColor = MyColors.LightHighlight;
                empPanelContainer.Margin = new Padding(2, 2, 2, 2);


                FlowLayoutPanel empPanel = CreateFlowPanel(180, 25);

                empPanel.Margin = new Padding(1, 1, 1, 1);


                Label lblName = CreateLabel(150, 22, emp.FullName);
                
                empPanel.Controls.Add(lblName);

                // Create panels for employee positions
                

                // Add the employee panel to the container panel
                empPanelContainer.Controls.Add(empPanel);
                //int remainingWidth = empPanel.Parent.ClientSize.Width - lblName.Width - emp.Positions.Count * pnlPos.Width;

                // Add the delete button to the container panel
                Button btnDelete = CreateButtonTemplate(16, 16, "X");
               
                //btnDelete.AutoSize = true;
                btnDelete.Margin = new Padding(0, 0, 0, 0);
                btnDelete.Location = new Point(410, 0);               
                btnDelete.Font = new Font(btnDelete.Font.FontFamily, 6);               
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
                        employeeList.Remove(emp);

                        // Update UI
                        //CreateEmployeePanels();
                    }
                };
                
                empPanel.Parent.Controls.Add(btnDelete);
                //empPanelContainer.Controls.Add(btnDelete);

                flowEmployeeDisplay.Controls.Add(empPanelContainer);
            }
        }
        public static void CreateNewEmployeePanelsExcel(List<Employee> newEmployeeList, List<Employee> existingEmployeeList, FlowLayoutPanel flowNewEmployeeDisplay, FlowLayoutPanel flowExistingEmployees)
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


                FlowLayoutPanel empPanel = CreateFlowPanel(180, 22);

                empPanel.Margin = new Padding(1, 1, 1, 1);

                // Create label for employee name
                Label lblName = CreateLabel(150, 20, emp.FullName);                
                empPanel.Controls.Add(lblName);

                // Create panels for employee positions
                
                empPanelContainer.Controls.Add(empPanel);
                //int remainingWidth = empPanel.Parent.ClientSize.Width - lblName.Width - emp.Positions.Count * pnlPos.Width;


                Button btnAddEmployee = CreateButtonTemplate(160, 22, "Add Employee");
               
                btnAddEmployee.Location = new Point(185, 0);
                //TODO: handle duplicate check some other way
                btnAddEmployee.Click += (sender, e) =>
                {
                    if (SqliteDataAccess.IsDuplicateEmployee(emp.FirstName, emp.LastName) == false)
                    {
                        existingEmployeeList.Add(emp);
                        CreateOldEmployeePanelsExcel(existingEmployeeList, flowExistingEmployees);
                        newEmployeeList.Remove(emp);
                        CreateNewEmployeePanelsExcel(newEmployeeList, existingEmployeeList, flowNewEmployeeDisplay, flowExistingEmployees);
                    }
                    else
                    {
                        MessageBox.Show(emp.FullName + "already exists");
                        newEmployeeList.Remove(emp);
                        CreateNewEmployeePanelsExcel(newEmployeeList, existingEmployeeList, flowNewEmployeeDisplay, flowExistingEmployees);
                    }


                    };

                    empPanel.Parent.Controls.Add(btnAddEmployee);
               

                flowNewEmployeeDisplay.Controls.Add(empPanelContainer);
            }
        }
        public static List<EmployeeShift> employeeShifts = new List<EmployeeShift>();

    }
}    
        
    


    

    //    public static void CreateEmployeePanels(List<Employee> employeeList, FlowLayoutPanel flowEmployeeDisplay)
    //    {
    //        // Clear existing panels
    //        flowEmployeeDisplay.Controls.Clear();

    //        // Loop through employee list and create a panel for each employee
    //        foreach (Employee emp in employeeList)
    //        {
    //            Panel empPanelContainer = new Panel();
    //            empPanelContainer.Size = new Size(430, 30);
    //            empPanelContainer.BackColor = MyColors.LightHighlight;
    //            empPanelContainer.Margin = new Padding(0, 0, 0, 5);


    //            FlowLayoutPanel empPanel = new FlowLayoutPanel();
    //            empPanel.FlowDirection = FlowDirection.LeftToRight;
    //            empPanel.WrapContents = false;
    //            empPanel.AutoSize = true;
    //            empPanel.MaximumSize = new Size(400, 0);
    //            empPanel.MinimumSize = new Size(400, 0);
    //            empPanel.BackColor = MyColors.LightHighlight;
    //            empPanel.Margin = new Padding(1, 1, 1, 1);

    //            //// Create label for employee name
    //            //Label lblName = new Label();
    //            //lblName.Text = emp.FullName;
    //            //lblName.AutoSize = false;
    //            //lblName.Size = new Size(150, 16);
    //            //lblName.TextAlign = ContentAlignment.MiddleCenter;
    //            //empPanel.Controls.Add(lblName);
    //            // Create button for employee name
    //            Button btnName = new Button();
    //            btnName.Text = emp.FullName;
    //            btnName.Size = new Size(150, 30);
    //            btnName.TextAlign = ContentAlignment.MiddleCenter;
    //            btnName.FlatStyle = FlatStyle.Flat;


    //            // Add event handler for button click
    //            btnName.Click += (sender, e) =>
    //            {
    //                // Open frmViewEmployee form with clicked employee as a parameter
    //                frmViewEmployee viewEmployeeForm = new frmViewEmployee(emp);
    //                viewEmployeeForm.ShowDialog();
    //            };

    //            empPanel.Controls.Add(btnName);


    //            // Create panels for employee positions
    //            foreach (Position pos in emp.Positions)
    //            {
    //                Panel pnlPos = new Panel();
    //                pnlPos.Size = new Size(60, 30);
    //                pnlPos.BackColor = MyColors.PositionColor;
    //                Label lblPos = new Label();
    //                lblPos.Text = pos.Name;
    //                lblPos.Font = new Font(lblPos.Font.FontFamily, 10);
    //                lblPos.AutoSize = false;
    //                lblPos.Size = new Size(60, 30);
    //                lblPos.TextAlign = ContentAlignment.MiddleCenter;
    //                pnlPos.Controls.Add(lblPos);
    //                empPanel.Controls.Add(pnlPos);
    //            }

    //            // Add the employee panel to the container panel
    //            empPanelContainer.Controls.Add(empPanel);
    //            Panel pnlRating = new Panel();
    //            pnlRating.Size = new Size(30, 30);
    //            pnlRating.Anchor = AnchorStyles.Right | AnchorStyles.Top;
    //            pnlRating.Margin = new Padding(0);
    //            pnlRating.Location = new Point(410, 0);
    //            Label lblRating = new Label();
    //            lblRating.Text = emp.OverallRating.ToString("F1");
    //            pnlRating.Controls.Add(lblRating);
    //            empPanelContainer.Controls.Add(pnlRating);

    //            // Add the delete button to the container panel
    //            //System.Windows.Forms.Button btnDelete = new System.Windows.Forms.Button();
    //            //btnDelete.Text = "X";
    //            //btnDelete.Margin = new Padding(0, 0, 0, 0);
    //            //btnDelete.Location = new Point(410, 0);
    //            //btnDelete.ForeColor = Color.Black;
    //            //btnDelete.Font = new Font(btnDelete.Font.FontFamily, 10);
    //            //btnDelete.TextAlign = ContentAlignment.MiddleCenter;
    //            //btnDelete.FlatStyle = FlatStyle.Flat;
    //            //btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    //            //btnDelete.FlatAppearance.BorderSize = 0;
    //            //btnDelete.Click += (sender, e) =>
    //            //{
    //            //    // Prompt user to confirm deletion
    //            //    DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    //            //    if (result == DialogResult.Yes)
    //            //    {
    //            //        // Delete employee from database
    //            //        SqliteDataAccess.DeleteEmployee(emp.ID);

    //            //        // Remove employee from list
    //            //        employeeList.Remove(emp);

    //            //        // Update UI
    //            //        CreateEmployeePanels(employeeList, flowEmployeeDisplay);
    //            //    }
    //            //};
    //            //btnDelete.Size = new Size(27, 27);
    //            //empPanel.Parent.Controls.Add(btnDelete);

    //            flowEmployeeDisplay.Controls.Add(empPanelContainer);
    //        }
    //    }
    //}


