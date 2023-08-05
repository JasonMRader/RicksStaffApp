namespace RicksStaffApp
{
    public partial class frmServerShift : Form
    {
        public string EmployeeNameLabel = null;
        List<Activity> ActivityList = new List<Activity>();
        public EmployeeShift EmployeeShiftToEdit = new EmployeeShift();
        private bool isDragging = false;
        private Point lastLocation;

        //public event Action IncidentsChanged;

        public frmServerShift()
        {
            InitializeComponent();
        }
        public frmServerShift(EmployeeShift employeeShift)
        {
            EmployeeShiftToEdit = employeeShift;
            InitializeComponent();
        }
        public delegate void EmployeeShiftUpdatedEventHandler(EmployeeShift employeeShift);


        public event EmployeeShiftUpdatedEventHandler EmployeeShiftUpdated;
        private void btnDone_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.UpdatePositionFromEmployeeShift(EmployeeShiftToEdit);
            SqliteDataAccess.SaveEmployeeShiftIncidents(EmployeeShiftToEdit);
            EmployeeShiftUpdated?.Invoke(EmployeeShiftToEdit);
            this.Close();
            this.Dispose();
            //string s = "";
            //foreach (Incident i in EmployeeShiftToEdit.Incidents)
            //{
            //    s += i.Name + " ";
            //}
            //MessageBox.Show(s);
        }



        private void frmServerShift_Load(object sender, EventArgs e)
        {

            ActivityList.Clear();
            ActivityList = SqliteDataAccess.LoadActivities();
            picShiftRating.Image = UIHelper.GetStars(EmployeeShiftToEdit.ShiftRating);
            picShiftRating.SizeMode = PictureBoxSizeMode.Zoom;
            //UIHelper.CreateActivityPanelsForEmpShift(EmployeeShiftToEdit.Incidents, ActivityList, flowActivityDisplay, flowIncidentToAdd);
            RefreshIncidents();
            CreateActivityPanelsForEmpShift(EmployeeShiftToEdit, ActivityList, flowActivityDisplay, flowIncidentToAdd);
            //UIHelper.CreateIncidentPanelForEmpShift(EmployeeShiftToEdit.Incidents, flowIncidentToAdd);

            EmployeeShiftToEdit.Employee.Positions = SqliteDataAccess.AssignPositionsToEmployee(EmployeeShiftToEdit.Employee);
            lblEmpolyeeName.Text = EmployeeShiftToEdit.EmployeeName;
            CreatePositionsForEmployeeShift(flowPositions, EmployeeShiftToEdit.Employee.Positions);
        }
        private void CreatePositionsForEmployeeShift(FlowLayoutPanel flowDisplay, List<Position> positions)
        {
            flowDisplay.Controls.Clear();
            int buttonWidth = ((flowDisplay.Width - 15) / (positions.Count + 1)) - ((positions.Count + 1) + 2);

            foreach (Position position in positions)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Appearance = Appearance.Button;
                radioButton.Margin = new Padding(2, 0, 0, 0);
                radioButton.BackColor = Color.FromArgb(167, 204, 237);

                radioButton.TextAlign = ContentAlignment.MiddleCenter;
                radioButton.FlatStyle = FlatStyle.Flat;
                radioButton.FlatAppearance.CheckedBackColor = Color.FromArgb(15, 217, 252);
                radioButton.Size = new Size(buttonWidth, 24);
                radioButton.Text = position.Name;
                radioButton.Tag = position;
                if (EmployeeShiftToEdit.Position.ID == position.ID)
                {
                    radioButton.Checked = true;
                }

                radioButton.CheckedChanged += (sender, e) =>
                {
                    RadioButton rb = sender as RadioButton;
                    if (rb != null && rb.Checked)
                    {
                        Position pos = rb.Tag as Position;
                        if (pos != null)
                        {
                            EmployeeShiftToEdit.Position = pos;
                        }
                    }
                };
                flowDisplay.Controls.Add(radioButton);
            }
        }

        private FlowLayoutPanel CreateActivityFlowLayoutPanel(Activity activity, int width, FlowLayoutPanel flowToAddTo)
        {
            int firstContainer = (int)(width - 35);
            int nameWidth = (int)width / 3;
            int ratingWidth = (int)width / 10;
            int modPanelWidth = (int)width / 3;
            FlowLayoutPanel activityPanelContainer = new FlowLayoutPanel();
            //activityPanelContainer.Size = new Size(430, 30);
            activityPanelContainer.AutoSize = true;
            activityPanelContainer.MinimumSize = new Size(width, 30);
            activityPanelContainer.MaximumSize = new Size(width, 200);
            activityPanelContainer.BackColor = MyColors.LightHighlight;
            activityPanelContainer.Margin = new Padding(0, 0, 0, 5);


            FlowLayoutPanel activityPanel = new FlowLayoutPanel();
            activityPanel.FlowDirection = FlowDirection.LeftToRight;
            activityPanel.WrapContents = false;
            activityPanel.AutoSize = true;
            activityPanel.MaximumSize = new Size(firstContainer, 30);
            activityPanel.MinimumSize = new Size(firstContainer, 0);

            PictureBox picUpDown = new PictureBox();
            picUpDown.Size = new Size(30, 30);
            picUpDown.Margin = new Padding(15, 3, 0, 0);


            activityPanel.BackColor = UIHelper.GetBackColor(activity.BaseRatingImpact);
            picUpDown.Image = UIHelper.GetArrowImage(activity.BaseRatingImpact);

            activityPanel.Margin = new Padding(1, 1, 1, 1);

            //// Create label for employee name
            Label lblName = new Label();
            lblName.Text = activity.Name;
            lblName.AutoSize = false;
            lblName.Size = new Size(nameWidth, 30);
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.Margin = new Padding(0, 0, 5, 0);
            activityPanel.Controls.Add(lblName);


            activityPanel.Controls.Add(picUpDown);

            Label lblBaseRating = new Label();
            lblBaseRating.Text = activity.BaseRatingDisplay;
            lblBaseRating.AutoSize = false;
            lblBaseRating.Size = new Size(ratingWidth, 30);
            lblBaseRating.TextAlign = ContentAlignment.MiddleCenter;
            lblBaseRating.Margin = new Padding(0, 0, 0, 0);
            activityPanel.Controls.Add(lblBaseRating);

            activityPanelContainer.Controls.Add(activityPanel);


            activityPanelContainer.Controls.Add(activityPanel);

            Button btnAddToEmpShift = new Button();
            btnAddToEmpShift.Text = "+";
            btnAddToEmpShift.Margin = new Padding(2, 2, 0, 0);
            btnAddToEmpShift.Location = new Point(410, 0);
            btnAddToEmpShift.ForeColor = Color.Black;
            btnAddToEmpShift.Font = new Font(btnAddToEmpShift.Font.FontFamily, 10);
            btnAddToEmpShift.TextAlign = ContentAlignment.MiddleCenter;
            btnAddToEmpShift.FlatStyle = FlatStyle.Flat;
            btnAddToEmpShift.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddToEmpShift.FlatAppearance.BorderSize = 0;
            btnAddToEmpShift.Click += (sender, e) =>
            {
                Incident incident = new Incident(activity);
                incident.EmployeeShiftID = EmployeeShiftToEdit.ID;
                //EmployeeShiftToEdit.AddIncident(incident);
                SqliteDataAccess.AddIncident(incident);
                //EmployeeShiftToEdit.Incidents = SqliteDataAccess.LoadIncidentsForEmployeeShift(EmployeeShiftToEdit);
                //EmployeeShiftToEdit.UpdateShiftRating();
                //AddOneIncidentForEmpShift(incident, flowToAddTo);
                RefreshIncidents();
                //UpdateRatingPicture();

                //RefreshListbox();

                //incident.ActivityID = ID;
                //incident.DateString = 
                //incident.Note = txtIncidentNote.Text;
                //incident.EmployeeShiftID = Int32.Parse(txtIncident_EmployeeID.Text);

                //CreateIncidentPanelForEmpShift(flowToAdd);
                //SqliteDataAccess.AddIncident(incident);




            };
            btnAddToEmpShift.Size = new Size(27, 27);
            activityPanelContainer.Controls.Add(btnAddToEmpShift);
            return activityPanelContainer;
        }
        //private class IncidentDisplayPanel
        //{
        //    public Incident PanelIncident { get; set; }
        //    public FlowLayoutPanel pnlContainer 
        //    {
        //        set 
        //        {
        //            this.pnlContainer.AutoSize = true;
        //            MinimumSize = new Size(containerWidth, 30);
        //            pnlContainer.MaximumSize = new Size(containerWidth, 200);
        //            pnlContainer.BackColor = MyColors.LightHighlight;
        //            pnlContainer.Margin = new Padding(0, 0, 0, 5);
        //        }
        //    }
        //    //public pnlContainer {set{} }
        //    public FlowLayoutPanel incidentPanel = new FlowLayoutPanel();
        //    public Label lblName = new Label();            
        //    public Label lblBaseRating = new Label();           
        //    public Button btnNote = new Button();           
        //    public FlowLayoutPanel flowNote = new FlowLayoutPanel();    
        //    public TextBox txt = new TextBox();   
        //    public Button btnSaveNote = UIHelper.CreateButtonTemplate(150, 30, "Save Note");    
        //    public Button btnDelete = new Button();

        //}
        //private void AddOneIncidentForEmpShift(List<Incident> incidents, FlowLayoutPanel flowDisplay)
        //{

        //    for (int i = incidents.Count - 1; i >= 0; i--)
        //    {
        //        var inc = incidents[i];
        //        int currentIncID = i;
        //        int containerWidth = flowDisplay.Width;
        //        int firstContainer = (int)(containerWidth - 40);
        //        int nameWidth = (int)containerWidth / 4;
        //        int ratingWidth = (int)containerWidth / 9;
        //        int modPanelWidth = (int)containerWidth / 3;
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
        //        incidentPanel.BackColor = UIHelper.GetBackColor(inc.BaseRatingImpact);

        //        Label lblName = UIHelper.CreateLabel(nameWidth, 30, inc.Name);                
        //        incidentPanel.Controls.Add(lblName);

        //        Label lblBaseRating = UIHelper.CreateLabel(ratingWidth, 30, inc.BaseRatingDisplay);                               
        //        incidentPanel.Controls.Add(lblBaseRating);

        //        Button btnNote = new Button();
        //        if (inc.Note != null)
        //        {
        //            btnNote.Text = "View Note";
        //        }
        //        else
        //        {
        //            btnNote.Text = "Add Note";
        //        }

        //        btnNote.Size = new Size(70, 30);
        //        btnNote.FlatStyle = FlatStyle.Flat;
        //        btnNote.TextAlign = ContentAlignment.MiddleCenter;
        //        btnNote.Margin = new Padding(0);

        //        bool btnClicked = false;

        //        FlowLayoutPanel flowNote = new FlowLayoutPanel();
        //        flowNote.MinimumSize = new Size(containerWidth - 30, 90);

        //        TextBox txt = new TextBox();
        //        txt.Multiline = true;
        //        txt.WordWrap = true;
        //        txt.Size = new Size(containerWidth - 30, 60);

        //        Button btnSaveNote = UIHelper.CreateButtonTemplate(150, 30, "Save Note");
        //        btnSaveNote.Click += (sender, e) =>
        //        {
        //            inc.Note = txt.Text;
        //        };

        //        btnNote.Click += (sender, e) =>
        //        {
        //            btnClicked = !btnClicked;
        //            if (btnClicked)
        //            {
        //                txt.Text = inc.Note;
        //                flowNote.Controls.Add(txt);
        //                pnlContainer.Controls.Add(flowNote);
        //                btnNote.Text = "Hide";
        //                flowNote.Controls.Add(btnSaveNote);
        //            }
        //            else
        //            {
        //                if (inc.Note != null)
        //                {
        //                    btnNote.Text = "View Note";
        //                }
        //                else
        //                {
        //                    btnNote.Text = "Add Note";
        //                }
        //                flowNote.Controls.Clear();
        //                pnlContainer.Controls.Remove(flowNote);
        //            }

        //        };
        //        incidentPanel.Controls.Add(btnNote);


        //        pnlContainer.Controls.Add(incidentPanel);
        //        Button btnDelete = new Button();
        //        btnDelete.Text = "X";
        //        btnDelete.Size = new Size(30, 30);
        //        btnDelete.FlatStyle = FlatStyle.Flat;
        //        btnDelete.FlatAppearance.BorderSize = 0;
        //        btnDelete.Margin = new Padding(2, 2, 0, 0);
        //        btnDelete.Tag = i;

        //        // Attach the click event to the delete button
        //        btnDelete.Click += (sender, e) =>
        //        {
        //            // Remove the pnlContainer from the flowDisplay

        //            // Find the incident to remove from the EmployeeShiftToEdit.Incidents list
        //            //Incident incidentToRemove = EmployeeShiftToEdit.Incidents.FirstOrDefault(i => i == inc);
        //            //int incidentToRemove = (int)btnDelete.Tag;
        //            // Remove the incident from the EmployeeShiftToEdit.Incidents list
        //            //if (incidentToRemove != null)
        //            //{
        //                //SqliteDataAccess.DeleteIncident(incidentToRemove);
        //                EmployeeShiftToEdit.Incidents.RemoveAt(currentIncID);

        //                EmployeeShiftToEdit.UpdateShiftRating();
        //                UpdateRatingPicture();
        //            //}


        //        };
        //        pnlContainer.Controls.Add(btnDelete);

        //        flowDisplay.Controls.Add(pnlContainer);


        //    }
        //    //RefreshIncidents();
        //    //flowDisplay.Controls.Remove(pnlContainer);
        //    RefreshListbox();

        //    // Add the delete button to the pnlContainer


        //}
        private void AddOneIncidentForEmpShift(Incident inc, FlowLayoutPanel flowDisplay)
        {



            int currentIncID = inc.ID;
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
            incidentPanel.BackColor = UIHelper.GetBackColor(inc.BaseRatingImpact);

            Label lblName = UIHelper.CreateLabel(nameWidth, 30, inc.Name);
            incidentPanel.Controls.Add(lblName);

            Label lblBaseRating = UIHelper.CreateLabel(ratingWidth, 30, inc.BaseRatingDisplay);
            incidentPanel.Controls.Add(lblBaseRating);

            Button btnNote = new Button();
            if (inc.Note != null)
            {
                btnNote.Text = "View Note";
            }
            else
            {
                btnNote.Text = "Add Note";
            }

            btnNote.Size = new Size(70, 30);
            btnNote.FlatStyle = FlatStyle.Flat;
            btnNote.TextAlign = ContentAlignment.MiddleCenter;
            btnNote.Margin = new Padding(0);

            bool btnClicked = false;

            FlowLayoutPanel flowNote = new FlowLayoutPanel();
            flowNote.MinimumSize = new Size(containerWidth - 30, 90);

            TextBox txt = new TextBox();
            txt.Multiline = true;
            txt.WordWrap = true;
            txt.Size = new Size(containerWidth - 30, 60);

            Button btnSaveNote = UIHelper.CreateButtonTemplate(150, 30, "Save Note");
            btnSaveNote.Click += (sender, e) =>
            {
                inc.Note = txt.Text;
            };

            btnNote.Click += (sender, e) =>
            {
                btnClicked = !btnClicked;
                if (btnClicked)
                {
                    txt.Text = inc.Note;
                    flowNote.Controls.Add(txt);
                    pnlContainer.Controls.Add(flowNote);
                    btnNote.Text = "Hide";
                    flowNote.Controls.Add(btnSaveNote);
                }
                else
                {
                    if (inc.Note != null)
                    {
                        btnNote.Text = "View Note";
                    }
                    else
                    {
                        btnNote.Text = "Add Note";
                    }
                    flowNote.Controls.Clear();
                    pnlContainer.Controls.Remove(flowNote);
                }

            };
            incidentPanel.Controls.Add(btnNote);


            pnlContainer.Controls.Add(incidentPanel);
            Button btnDelete = new Button();
            btnDelete.Text = "X";
            btnDelete.Size = new Size(30, 30);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Margin = new Padding(2, 2, 0, 0);
            btnDelete.Tag = currentIncID;

            // Attach the click event to the delete button
            btnDelete.Click += (sender, e) =>
            {
                // Remove the pnlContainer from the flowDisplay

                // Find the incident to remove from the EmployeeShiftToEdit.Incidents list
                //Incident incidentToRemove = EmployeeShiftToEdit.Incidents.FirstOrDefault(i => i == inc);
                Incident incidentToRemove = EmployeeShiftToEdit.Incidents.FirstOrDefault(incident => incident.ID == currentIncID);
                // Remove the incident from the EmployeeShiftToEdit.Incidents list
                //if (incidentToRemove != null)
                //{
                SqliteDataAccess.DeleteIncident(currentIncID);
                //EmployeeShiftToEdit.Incidents = SqliteDataAccess.LoadIncidentsForEmployeeShift(EmployeeShiftToEdit);
                //EmployeeShiftToEdit.Incidents.Remove(incidentToRemove);


                RefreshIncidents();
                //}


            };
            pnlContainer.Controls.Add(btnDelete);

            flowDisplay.Controls.Add(pnlContainer);



            //RefreshIncidents();
            //flowDisplay.Controls.Remove(pnlContainer);
            //RefreshListbox();

            // Add the delete button to the pnlContainer


        }
        private void RefreshIncidents()
        {
            EmployeeShiftToEdit.Incidents = SqliteDataAccess.LoadIncidentsForEmployeeShift(EmployeeShiftToEdit);
            EmployeeShiftToEdit.UpdateShiftRating();
            UpdateRatingPicture();
            flowIncidentToAdd.Controls.Clear();
            //AddOneIncidentForEmpShift(EmployeeShiftToEdit.Incidents, flowIncidentToAdd);

            foreach (Incident i in EmployeeShiftToEdit.Incidents)
            {
                AddOneIncidentForEmpShift(i, flowIncidentToAdd);
            }
        }
        //private void RefreshListbox()
        //{
        //    lbIncidents.Items.Clear();
        //    foreach (Incident i in EmployeeShiftToEdit.Incidents)
        //    {
        //        lbIncidents.Items.Add(i.Name + " ...... " + i.IncidentRatingChange);
        //    }
        //}
        private void CreateActivityPanelsForEmpShift(EmployeeShift employeeShift, List<Activity> activityList, FlowLayoutPanel flowFormDisplay, FlowLayoutPanel flowToAdd)
        {
            // Clear existing panels
            //flowFormDisplay.Controls.Clear();
            ////CreateIncidentPanelForEmpShift(employeeShift, flowToAdd);
            ////AddOneIncidentForEmpShift(EmployeeShiftToEdit.Incidents, flowIncidentToAdd);
            //foreach (Incident inc in employeeShift.Incidents)
            //{
            //    AddOneIncidentForEmpShift(inc, flowToAdd);
            //}


            foreach (Activity activity in activityList)
            {
                FlowLayoutPanel activityPanelContainer = CreateActivityFlowLayoutPanel(activity, flowFormDisplay.Width - 30, flowToAdd);

                flowFormDisplay.Controls.Add(activityPanelContainer);
            }


        }
        private static void CreateIncidentPanelForEmpShift(EmployeeShift employeeShift, FlowLayoutPanel flowDisplay)
        {
            int containerWidth = flowDisplay.Width;
            int firstContainer = (int)(containerWidth - 40);
            int nameWidth = (int)containerWidth / 4;
            int ratingWidth = (int)containerWidth / 9;
            int modPanelWidth = (int)containerWidth / 3;
            flowDisplay.Controls.Clear();
            foreach (Incident inc in employeeShift.Incidents)
            {

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
                incidentPanel.BackColor = UIHelper.GetBackColor(inc.BaseRatingImpact);

                Label lblName = new Label();
                lblName.Text = inc.Name;
                lblName.AutoSize = false;
                lblName.Size = new Size(nameWidth, 30);
                lblName.TextAlign = ContentAlignment.MiddleCenter;
                incidentPanel.Controls.Add(lblName);

                Label lblBaseRating = new Label();
                lblBaseRating.Text = inc.BaseRatingDisplay;
                lblBaseRating.AutoSize = false;
                lblBaseRating.Size = new Size(ratingWidth, 30);
                lblBaseRating.TextAlign = ContentAlignment.MiddleCenter;
                incidentPanel.Controls.Add(lblBaseRating);

                Button btnNote = new Button();
                if (inc.Note != null)
                {
                    btnNote.Text = "View Note";
                }
                else
                {
                    btnNote.Text = "Add Note";
                }

                btnNote.Size = new Size(70, 30);
                btnNote.FlatStyle = FlatStyle.Flat;
                btnNote.TextAlign = ContentAlignment.MiddleCenter;
                btnNote.Margin = new Padding(0);

                bool btnClicked = false;

                FlowLayoutPanel flowNote = new FlowLayoutPanel();
                flowNote.MinimumSize = new Size(containerWidth - 30, 90);

                TextBox txt = new TextBox();
                txt.Multiline = true;
                txt.WordWrap = true;
                txt.Size = new Size(containerWidth - 30, 60);

                Button btnSaveNote = UIHelper.CreateButtonTemplate(150, 30, "Save Note");
                btnSaveNote.Click += (sender, e) =>
                {
                    inc.Note = txt.Text;
                };

                btnNote.Click += (sender, e) =>
                {
                    btnClicked = !btnClicked;
                    if (btnClicked)
                    {
                        txt.Text = inc.Note;
                        flowNote.Controls.Add(txt);
                        pnlContainer.Controls.Add(flowNote);
                        btnNote.Text = "Hide";
                        flowNote.Controls.Add(btnSaveNote);
                    }
                    else
                    {
                        if (inc.Note != null)
                        {
                            btnNote.Text = "View Note";
                        }
                        else
                        {
                            btnNote.Text = "Add Note";
                        }
                        flowNote.Controls.Clear();
                        pnlContainer.Controls.Remove(flowNote);
                    }

                };
                incidentPanel.Controls.Add(btnNote);


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
                    // Find the incident to remove from the EmployeeShiftToEdit.Incidents list
                    Incident incidentToRemove = employeeShift.Incidents.FirstOrDefault(i => i == inc);

                    // Remove the incident from the EmployeeShiftToEdit.Incidents list
                    if (incidentToRemove != null)
                    {
                        employeeShift.Incidents.Remove(incidentToRemove);
                    }
                };

                // Add the delete button to the pnlContainer
                pnlContainer.Controls.Add(btnDelete);

                flowDisplay.Controls.Add(pnlContainer);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void UpdateRatingPicture(object sender, ControlEventArgs e)
        //{
        //    picShiftRating.Image = UIHelper.GetStars(EmployeeShiftToEdit.ShiftRating);
        //}
        private void UpdateRatingPicture()
        {
            picShiftRating.Image = UIHelper.GetStars(EmployeeShiftToEdit.ShiftRating);
        }
        private void refreshActivityList(List<Activity> activities)
        {
            flowActivityDisplay.Controls.Clear();
            foreach (Activity activity in activities)
            {
                FlowLayoutPanel activityPanelContainer = CreateActivityFlowLayoutPanel(activity, flowActivityDisplay.Width - 30, flowIncidentToAdd);

                flowActivityDisplay.Controls.Add(activityPanelContainer);
            }
        }

        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAll.Checked)
            {
                refreshActivityList(ActivityList);
            }

        }

        private void rdoGood_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGood.Checked)
            {
                List<Activity> goodActivities = new List<Activity>();
                foreach (Activity activity in ActivityList)
                {
                    if (activity.BaseRatingImpact > 0)
                    {
                        goodActivities.Add(activity);
                    }
                }
                refreshActivityList(goodActivities);
            }

        }

        private void rdoBad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBad.Checked)
            {
                List<Activity> badActivities = new List<Activity>();
                foreach (Activity activity in ActivityList)
                {
                    if (activity.BaseRatingImpact < 0)
                    {
                        badActivities.Add(activity);
                    }
                }
                refreshActivityList(badActivities);
            }

        }
    }

}
