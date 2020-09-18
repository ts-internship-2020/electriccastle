namespace ConferencePlanner.WinUi
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.TabOrganizer = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrganizerTabEntriesTextBox = new System.Windows.Forms.TextBox();
            this.OrganizerFilterButton = new ConferencePlanner.WinUi.ButonCircular();
            this.OrganizerNextButton = new ConferencePlanner.WinUi.ButonCircular();
            this.OrganizerPreviousButton = new ConferencePlanner.WinUi.ButonCircular();
            this.AddConferenceButton = new ConferencePlanner.WinUi.ButonCircular();
            this.OrganizerTabEndDateLabel = new System.Windows.Forms.Label();
            this.OrganizerTabStartDateLabel = new System.Windows.Forms.Label();
            this.OrganizerGrid = new System.Windows.Forms.DataGridView();
            this.OrganizerEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.OrganizerStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.TabParticipant = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.entryPageTextBox = new System.Windows.Forms.TextBox();
            this.entryPageLabel = new System.Windows.Forms.Label();
            this.BackButtonParticipant = new ConferencePlanner.WinUi.ButonCircular();
            this.NextButtonParticipant = new ConferencePlanner.WinUi.ButonCircular();
            this.FilterParticipants = new ConferencePlanner.WinUi.ButonCircular();
            this.DatePickerParticipantEnd = new System.Windows.Forms.DateTimePicker();
            this.DatePickerParticipantStart = new System.Windows.Forms.DateTimePicker();
            this.ConferencesParticipant = new System.Windows.Forms.DataGridView();
            this.ColumnNameConferenceParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStartDateParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndDateParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTypeParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoryParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddressParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSpeakerParticipant = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnAttend = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnJoinButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnWithdrawButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControrConferences = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TabOrganizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizerGrid)).BeginInit();
            this.TabParticipant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConferencesParticipant)).BeginInit();
            this.TabControrConferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabOrganizer
            // 
            this.TabOrganizer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabOrganizer.BackgroundImage")));
            this.TabOrganizer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabOrganizer.Controls.Add(this.label3);
            this.TabOrganizer.Controls.Add(this.label2);
            this.TabOrganizer.Controls.Add(this.OrganizerTabEntriesTextBox);
            this.TabOrganizer.Controls.Add(this.OrganizerFilterButton);
            this.TabOrganizer.Controls.Add(this.OrganizerNextButton);
            this.TabOrganizer.Controls.Add(this.OrganizerPreviousButton);
            this.TabOrganizer.Controls.Add(this.AddConferenceButton);
            this.TabOrganizer.Controls.Add(this.OrganizerTabEndDateLabel);
            this.TabOrganizer.Controls.Add(this.OrganizerTabStartDateLabel);
            this.TabOrganizer.Controls.Add(this.OrganizerGrid);
            this.TabOrganizer.Controls.Add(this.OrganizerEndDatePicker);
            this.TabOrganizer.Controls.Add(this.OrganizerStartDatePicker);
            this.TabOrganizer.ImageIndex = 1;
            this.TabOrganizer.Location = new System.Drawing.Point(4, 54);
            this.TabOrganizer.Name = "TabOrganizer";
            this.TabOrganizer.Padding = new System.Windows.Forms.Padding(4);
            this.TabOrganizer.Size = new System.Drawing.Size(795, 336);
            this.TabOrganizer.TabIndex = 1;
            this.TabOrganizer.Text = "Organizers";
            this.TabOrganizer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(668, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Filter using both dates";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Entries per Page";
            // 
            // OrganizerTabEntriesTextBox
            // 
            this.OrganizerTabEntriesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrganizerTabEntriesTextBox.Location = new System.Drawing.Point(118, 306);
            this.OrganizerTabEntriesTextBox.Name = "OrganizerTabEntriesTextBox";
            this.OrganizerTabEntriesTextBox.Size = new System.Drawing.Size(27, 23);
            this.OrganizerTabEntriesTextBox.TabIndex = 14;
            this.OrganizerTabEntriesTextBox.TextChanged += new System.EventHandler(this.OrganizerTabTextBox_TextChanged);
            // 
            // OrganizerFilterButton
            // 
            this.OrganizerFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrganizerFilterButton.BackColor = System.Drawing.Color.OrangeRed;
            this.OrganizerFilterButton.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.OrganizerFilterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrganizerFilterButton.Location = new System.Drawing.Point(680, 34);
            this.OrganizerFilterButton.Name = "OrganizerFilterButton";
            this.OrganizerFilterButton.Size = new System.Drawing.Size(98, 36);
            this.OrganizerFilterButton.TabIndex = 12;
            this.OrganizerFilterButton.Text = "FILTER";
            this.OrganizerFilterButton.UseVisualStyleBackColor = false;
            this.OrganizerFilterButton.Click += new System.EventHandler(this.OrganizerFilterButton_Click);
            // 
            // OrganizerNextButton
            // 
            this.OrganizerNextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OrganizerNextButton.BackColor = System.Drawing.Color.OrangeRed;
            this.OrganizerNextButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrganizerNextButton.Location = new System.Drawing.Point(716, 299);
            this.OrganizerNextButton.Name = "OrganizerNextButton";
            this.OrganizerNextButton.Size = new System.Drawing.Size(62, 34);
            this.OrganizerNextButton.TabIndex = 11;
            this.OrganizerNextButton.Text = ">";
            this.OrganizerNextButton.UseVisualStyleBackColor = false;
            this.OrganizerNextButton.Click += new System.EventHandler(this.OrganizerNextButton_Click);
            // 
            // OrganizerPreviousButton
            // 
            this.OrganizerPreviousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OrganizerPreviousButton.BackColor = System.Drawing.Color.OrangeRed;
            this.OrganizerPreviousButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrganizerPreviousButton.Location = new System.Drawing.Point(659, 299);
            this.OrganizerPreviousButton.Name = "OrganizerPreviousButton";
            this.OrganizerPreviousButton.Size = new System.Drawing.Size(62, 34);
            this.OrganizerPreviousButton.TabIndex = 10;
            this.OrganizerPreviousButton.Text = "<";
            this.OrganizerPreviousButton.UseVisualStyleBackColor = false;
            this.OrganizerPreviousButton.Click += new System.EventHandler(this.OrganizerPreviousButton_Click);
            // 
            // AddConferenceButton
            // 
            this.AddConferenceButton.BackColor = System.Drawing.Color.OrangeRed;
            this.AddConferenceButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddConferenceButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.AddConferenceButton.Location = new System.Drawing.Point(24, 24);
            this.AddConferenceButton.Name = "AddConferenceButton";
            this.AddConferenceButton.Size = new System.Drawing.Size(156, 45);
            this.AddConferenceButton.TabIndex = 9;
            this.AddConferenceButton.Text = "Add Conference";
            this.AddConferenceButton.UseVisualStyleBackColor = false;
            this.AddConferenceButton.Click += new System.EventHandler(this.AddConferenceButton_Click_1);
            // 
            // OrganizerTabEndDateLabel
            // 
            this.OrganizerTabEndDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrganizerTabEndDateLabel.AutoSize = true;
            this.OrganizerTabEndDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrganizerTabEndDateLabel.ForeColor = System.Drawing.Color.White;
            this.OrganizerTabEndDateLabel.Location = new System.Drawing.Point(401, 63);
            this.OrganizerTabEndDateLabel.Name = "OrganizerTabEndDateLabel";
            this.OrganizerTabEndDateLabel.Size = new System.Drawing.Size(57, 15);
            this.OrganizerTabEndDateLabel.TabIndex = 8;
            this.OrganizerTabEndDateLabel.Text = "End Date:";
            // 
            // OrganizerTabStartDateLabel
            // 
            this.OrganizerTabStartDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrganizerTabStartDateLabel.AutoSize = true;
            this.OrganizerTabStartDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrganizerTabStartDateLabel.ForeColor = System.Drawing.Color.White;
            this.OrganizerTabStartDateLabel.Location = new System.Drawing.Point(401, 34);
            this.OrganizerTabStartDateLabel.Name = "OrganizerTabStartDateLabel";
            this.OrganizerTabStartDateLabel.Size = new System.Drawing.Size(61, 15);
            this.OrganizerTabStartDateLabel.TabIndex = 7;
            this.OrganizerTabStartDateLabel.Text = "Start Date:";
            // 
            // OrganizerGrid
            // 
            this.OrganizerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrganizerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrganizerGrid.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.OrganizerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrganizerGrid.Location = new System.Drawing.Point(6, 86);
            this.OrganizerGrid.Name = "OrganizerGrid";
            this.OrganizerGrid.Size = new System.Drawing.Size(772, 210);
            this.OrganizerGrid.TabIndex = 4;
            this.OrganizerGrid.Text = "dataGridView1";
            this.OrganizerGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrganizerGrid_CellClick);
            this.OrganizerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrganizerGrid_CellContentClick);
            this.OrganizerGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.OrganizerGrid_DataBindingComplete);
            // 
            // OrganizerEndDatePicker
            // 
            this.OrganizerEndDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrganizerEndDatePicker.Location = new System.Drawing.Point(466, 57);
            this.OrganizerEndDatePicker.Name = "OrganizerEndDatePicker";
            this.OrganizerEndDatePicker.Size = new System.Drawing.Size(200, 23);
            this.OrganizerEndDatePicker.TabIndex = 2;
            this.OrganizerEndDatePicker.ValueChanged += new System.EventHandler(this.OrganizerEndDatePicker_ValueChanged);
            // 
            // OrganizerStartDatePicker
            // 
            this.OrganizerStartDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrganizerStartDatePicker.Location = new System.Drawing.Point(466, 28);
            this.OrganizerStartDatePicker.Name = "OrganizerStartDatePicker";
            this.OrganizerStartDatePicker.Size = new System.Drawing.Size(200, 23);
            this.OrganizerStartDatePicker.TabIndex = 1;
            this.OrganizerStartDatePicker.ValueChanged += new System.EventHandler(this.OrganizerStartDatePicker_ValueChanged);
            // 
            // TabParticipant
            // 
            this.TabParticipant.BackColor = System.Drawing.Color.Transparent;
            this.TabParticipant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabParticipant.BackgroundImage")));
            this.TabParticipant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabParticipant.Controls.Add(this.label5);
            this.TabParticipant.Controls.Add(this.label4);
            this.TabParticipant.Controls.Add(this.label1);
            this.TabParticipant.Controls.Add(this.entryPageTextBox);
            this.TabParticipant.Controls.Add(this.entryPageLabel);
            this.TabParticipant.Controls.Add(this.BackButtonParticipant);
            this.TabParticipant.Controls.Add(this.NextButtonParticipant);
            this.TabParticipant.Controls.Add(this.FilterParticipants);
            this.TabParticipant.Controls.Add(this.DatePickerParticipantEnd);
            this.TabParticipant.Controls.Add(this.DatePickerParticipantStart);
            this.TabParticipant.Controls.Add(this.ConferencesParticipant);
            this.TabParticipant.ForeColor = System.Drawing.Color.Black;
            this.TabParticipant.ImageIndex = 2;
            this.TabParticipant.Location = new System.Drawing.Point(4, 54);
            this.TabParticipant.Name = "TabParticipant";
            this.TabParticipant.Padding = new System.Windows.Forms.Padding(4);
            this.TabParticipant.Size = new System.Drawing.Size(795, 336);
            this.TabParticipant.TabIndex = 0;
            this.TabParticipant.Text = "Participants";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(389, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "End date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(389, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Start date";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(661, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filter using both dates";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // entryPageTextBox
            // 
            this.entryPageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.entryPageTextBox.Location = new System.Drawing.Point(116, 308);
            this.entryPageTextBox.Name = "entryPageTextBox";
            this.entryPageTextBox.Size = new System.Drawing.Size(27, 23);
            this.entryPageTextBox.TabIndex = 11;
            this.entryPageTextBox.Text = "5";
            this.entryPageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.entryPageTextBox.TextChanged += new System.EventHandler(this.entryPageTextBox_TextChanged);
            // 
            // entryPageLabel
            // 
            this.entryPageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.entryPageLabel.AutoSize = true;
            this.entryPageLabel.BackColor = System.Drawing.Color.Transparent;
            this.entryPageLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.entryPageLabel.ForeColor = System.Drawing.Color.White;
            this.entryPageLabel.Location = new System.Drawing.Point(6, 309);
            this.entryPageLabel.Name = "entryPageLabel";
            this.entryPageLabel.Size = new System.Drawing.Size(108, 17);
            this.entryPageLabel.TabIndex = 10;
            this.entryPageLabel.Text = "Entries per Page";
            // 
            // BackButtonParticipant
            // 
            this.BackButtonParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButtonParticipant.BackColor = System.Drawing.Color.OrangeRed;
            this.BackButtonParticipant.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButtonParticipant.ForeColor = System.Drawing.Color.Black;
            this.BackButtonParticipant.Location = new System.Drawing.Point(664, 299);
            this.BackButtonParticipant.Name = "BackButtonParticipant";
            this.BackButtonParticipant.Size = new System.Drawing.Size(62, 34);
            this.BackButtonParticipant.TabIndex = 9;
            this.BackButtonParticipant.Text = "<";
            this.BackButtonParticipant.UseVisualStyleBackColor = false;
            this.BackButtonParticipant.Click += new System.EventHandler(this.BackButtonParticipant_Click);
            // 
            // NextButtonParticipant
            // 
            this.NextButtonParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButtonParticipant.BackColor = System.Drawing.Color.OrangeRed;
            this.NextButtonParticipant.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NextButtonParticipant.ForeColor = System.Drawing.Color.Black;
            this.NextButtonParticipant.Location = new System.Drawing.Point(723, 299);
            this.NextButtonParticipant.Name = "NextButtonParticipant";
            this.NextButtonParticipant.Size = new System.Drawing.Size(62, 34);
            this.NextButtonParticipant.TabIndex = 8;
            this.NextButtonParticipant.Text = ">";
            this.NextButtonParticipant.UseVisualStyleBackColor = false;
            this.NextButtonParticipant.Click += new System.EventHandler(this.NextButtonParticipant_Click);
            // 
            // FilterParticipants
            // 
            this.FilterParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterParticipants.BackColor = System.Drawing.Color.OrangeRed;
            this.FilterParticipants.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.FilterParticipants.ForeColor = System.Drawing.Color.White;
            this.FilterParticipants.Location = new System.Drawing.Point(664, 36);
            this.FilterParticipants.Name = "FilterParticipants";
            this.FilterParticipants.Size = new System.Drawing.Size(107, 36);
            this.FilterParticipants.TabIndex = 7;
            this.FilterParticipants.Text = "Filter";
            this.FilterParticipants.UseVisualStyleBackColor = false;
            this.FilterParticipants.Click += new System.EventHandler(this.FilterParticipants_Click);
            // 
            // DatePickerParticipantEnd
            // 
            this.DatePickerParticipantEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePickerParticipantEnd.Location = new System.Drawing.Point(458, 52);
            this.DatePickerParticipantEnd.Name = "DatePickerParticipantEnd";
            this.DatePickerParticipantEnd.Size = new System.Drawing.Size(200, 23);
            this.DatePickerParticipantEnd.TabIndex = 5;
            this.DatePickerParticipantEnd.ValueChanged += new System.EventHandler(this.DatePickerParticipantEnd_ValueChanged);
            // 
            // DatePickerParticipantStart
            // 
            this.DatePickerParticipantStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePickerParticipantStart.Location = new System.Drawing.Point(458, 23);
            this.DatePickerParticipantStart.Name = "DatePickerParticipantStart";
            this.DatePickerParticipantStart.Size = new System.Drawing.Size(200, 23);
            this.DatePickerParticipantStart.TabIndex = 4;
            this.DatePickerParticipantStart.ValueChanged += new System.EventHandler(this.DatePickerParticipantStart_ValueChanged);
            // 
            // ConferencesParticipant
            // 
            this.ConferencesParticipant.AllowUserToAddRows = false;
            this.ConferencesParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConferencesParticipant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConferencesParticipant.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.ConferencesParticipant.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ConferencesParticipant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConferencesParticipant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNameConferenceParticipant,
            this.ColumnStartDateParticipant,
            this.ColumnEndDateParticipant,
            this.ColumnTypeParticipant,
            this.ColumnCategoryParticipant,
            this.ColumnAddressParticipant,
            this.ColumnSpeakerParticipant,
            this.ColumnAttend,
            this.ColumnJoinButton,
            this.ColumnWithdrawButton,
            this.ColumnState});
            this.ConferencesParticipant.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConferencesParticipant.Location = new System.Drawing.Point(6, 78);
            this.ConferencesParticipant.Name = "ConferencesParticipant";
            this.ConferencesParticipant.Size = new System.Drawing.Size(779, 219);
            this.ConferencesParticipant.TabIndex = 3;
            this.ConferencesParticipant.Text = "dataGridView1";
            this.ConferencesParticipant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConferencesParticipant_CellContentClick);
            // 
            // ColumnNameConferenceParticipant
            // 
            this.ColumnNameConferenceParticipant.HeaderText = "Name";
            this.ColumnNameConferenceParticipant.Name = "ColumnNameConferenceParticipant";
            this.ColumnNameConferenceParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnStartDateParticipant
            // 
            this.ColumnStartDateParticipant.FillWeight = 54.16244F;
            this.ColumnStartDateParticipant.HeaderText = "Start Date";
            this.ColumnStartDateParticipant.Name = "ColumnStartDateParticipant";
            this.ColumnStartDateParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnEndDateParticipant
            // 
            this.ColumnEndDateParticipant.FillWeight = 54.16244F;
            this.ColumnEndDateParticipant.HeaderText = "End Date";
            this.ColumnEndDateParticipant.Name = "ColumnEndDateParticipant";
            this.ColumnEndDateParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnTypeParticipant
            // 
            this.ColumnTypeParticipant.FillWeight = 54.16244F;
            this.ColumnTypeParticipant.HeaderText = "Type";
            this.ColumnTypeParticipant.Name = "ColumnTypeParticipant";
            this.ColumnTypeParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnCategoryParticipant
            // 
            this.ColumnCategoryParticipant.FillWeight = 54.16244F;
            this.ColumnCategoryParticipant.HeaderText = "Category";
            this.ColumnCategoryParticipant.Name = "ColumnCategoryParticipant";
            this.ColumnCategoryParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnAddressParticipant
            // 
            this.ColumnAddressParticipant.FillWeight = 54.16244F;
            this.ColumnAddressParticipant.HeaderText = "Address";
            this.ColumnAddressParticipant.Name = "ColumnAddressParticipant";
            this.ColumnAddressParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnSpeakerParticipant
            // 
            this.ColumnSpeakerParticipant.FillWeight = 54.16244F;
            this.ColumnSpeakerParticipant.HeaderText = "Speaker";
            this.ColumnSpeakerParticipant.Name = "ColumnSpeakerParticipant";
            this.ColumnSpeakerParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnSpeakerParticipant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnAttend
            // 
            this.ColumnAttend.FillWeight = 54.16244F;
            this.ColumnAttend.HeaderText = "Attend";
            this.ColumnAttend.Name = "ColumnAttend";
            this.ColumnAttend.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnJoinButton
            // 
            this.ColumnJoinButton.FillWeight = 54.16244F;
            this.ColumnJoinButton.HeaderText = "Join";
            this.ColumnJoinButton.Name = "ColumnJoinButton";
            this.ColumnJoinButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnWithdrawButton
            // 
            this.ColumnWithdrawButton.FillWeight = 54.16244F;
            this.ColumnWithdrawButton.HeaderText = "Withdraw";
            this.ColumnWithdrawButton.Name = "ColumnWithdrawButton";
            this.ColumnWithdrawButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnState
            // 
            this.ColumnState.FillWeight = 54.16244F;
            this.ColumnState.HeaderText = "State";
            this.ColumnState.Name = "ColumnState";
            this.ColumnState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TabControrConferences
            // 
            this.TabControrConferences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControrConferences.Controls.Add(this.TabParticipant);
            this.TabControrConferences.Controls.Add(this.TabOrganizer);
            this.TabControrConferences.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TabControrConferences.ImageList = this.imageList1;
            this.TabControrConferences.ItemSize = new System.Drawing.Size(500, 50);
            this.TabControrConferences.Location = new System.Drawing.Point(2, 12);
            this.TabControrConferences.Name = "TabControrConferences";
            this.TabControrConferences.SelectedIndex = 2;
            this.TabControrConferences.Size = new System.Drawing.Size(803, 394);
            this.TabControrConferences.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "637-512.png");
            this.imageList1.Images.SetKeyName(1, "events-icon-png-217527-free-icons-library-schedule-of-events-png-512_512.jpg");
            this.imageList1.Images.SetKeyName(2, "participant-png-png-image-participant-png-512_512.png");
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 404);
            this.Controls.Add(this.TabControrConferences);
            this.Name = "MainScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Main Page";
            this.Activated += new System.EventHandler(this.MainScreen_Activated);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.TabOrganizer.ResumeLayout(false);
            this.TabOrganizer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizerGrid)).EndInit();
            this.TabParticipant.ResumeLayout(false);
            this.TabParticipant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConferencesParticipant)).EndInit();
            this.TabControrConferences.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TabOrganizer;
        private System.Windows.Forms.TabPage TabParticipant;
        private System.Windows.Forms.TabControl TabControrConferences;
        private System.Windows.Forms.Button backButtonParticipant;
        private System.Windows.Forms.DataGridView ConferencesParticipant;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.DateTimePicker DatePickerParticipantStart;
        private System.Windows.Forms.DateTimePicker DatePickerParticipantEnd;
        private System.Windows.Forms.DateTimePicker OrganizerStartDatePicker;
        private System.Windows.Forms.DateTimePicker OrganizerEndDatePicker;
        private System.Windows.Forms.DataGridView OrganizerGrid;
        private System.Windows.Forms.Label OrganizerTabEndDateLabel;
        private System.Windows.Forms.Label OrganizerTabStartDateLabel;
        private ButonCircular FilterParticipants;
        private ButonCircular NextButtonParticipant1;
        private ButonCircular OrganizerNextButton;
        private ButonCircular OrganizerPreviousButton;
        private ButonCircular AddConferenceButton;
        private ButonCircular butonCircular3;
        private ButonCircular BackButtonParticipant1;
        private ButonCircular BackButtonParticipant;
        private ButonCircular NextButtonParticipant;
        private ButonCircular OrganizerFilterButton1;
        private ButonCircular OrganizerFilterButton;
        private System.Windows.Forms.Label entryPageLabel;
        private System.Windows.Forms.TextBox entryPageTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNameConferenceParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStartDateParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndDateParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoryParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddressParticipant;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnSpeakerParticipant;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnAttend;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnJoinButton;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnWithdrawButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrganizerTabEntriesTextBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}