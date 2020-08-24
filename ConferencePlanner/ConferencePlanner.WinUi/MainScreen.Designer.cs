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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.TabOrganizer = new System.Windows.Forms.TabPage();
            this.OrganizerGrid = new System.Windows.Forms.DataGridView();
            this.OrganizerNextButton = new System.Windows.Forms.Button();
            this.OrganizerPreviousButton = new System.Windows.Forms.Button();
            this.AddConferenceButton = new System.Windows.Forms.Button();
            this.OrganizerEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.OrganizerStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.OrganizerFilterButton = new System.Windows.Forms.Button();
            this.TabParticipant = new System.Windows.Forms.TabPage();
            this.ConferencesParticipant = new System.Windows.Forms.DataGridView();
            this.FilterParticipants = new System.Windows.Forms.Button();
            this.DatePickerParticipantEnd = new System.Windows.Forms.DateTimePicker();
            this.DatePickerParticipantStart = new System.Windows.Forms.DateTimePicker();
            this.ColumnNameConferenceParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStartDateParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndDateParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTypeParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoryParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddressParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSpeakerParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAttend = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnJoinButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnWithdrawButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NextButtonParticipant = new System.Windows.Forms.Button();
            this.BackButtonParticipant = new System.Windows.Forms.Button();
            this.TabControrConferences = new System.Windows.Forms.TabControl();
            this.ColumnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabOrganizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizerGrid)).BeginInit();
            this.TabOrganizer.SuspendLayout();
            this.TabParticipant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConferencesParticipant)).BeginInit();
            this.TabParticipant.SuspendLayout();
            this.TabControrConferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabOrganizer
            // 
            this.TabOrganizer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabOrganizer.BackgroundImage")));
            // 
            // OrganizerGrid
            // 
            this.OrganizerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrganizerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrganizerGrid.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.OrganizerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrganizerGrid.Location = new System.Drawing.Point(24, 85);
            this.OrganizerGrid.Name = "OrganizerGrid";
            this.OrganizerGrid.Size = new System.Drawing.Size(755, 242);
            this.OrganizerGrid.TabIndex = 4;
            this.OrganizerGrid.Text = "dataGridView1";
            this.TabOrganizer.Controls.Add(this.OrganizerNextButton);
            this.TabOrganizer.Controls.Add(this.OrganizerPreviousButton);
            this.TabOrganizer.Controls.Add(this.OrganizerGrid);
            this.TabOrganizer.Controls.Add(this.AddConferenceButton);
            this.TabOrganizer.Controls.Add(this.OrganizerEndDatePicker);
            this.TabOrganizer.Controls.Add(this.OrganizerStartDatePicker);
            this.TabOrganizer.Controls.Add(this.OrganizerFilterButton);
            this.TabOrganizer.Location = new System.Drawing.Point(4, 24);
            this.TabOrganizer.Name = "TabOrganizer";
            this.TabOrganizer.Padding = new System.Windows.Forms.Padding(3);
            this.TabOrganizer.Size = new System.Drawing.Size(800, 370);
            this.TabOrganizer.TabIndex = 1;
            this.TabOrganizer.Text = "Organizers";
            this.TabOrganizer.UseVisualStyleBackColor = true;
            // 
            // OrganizerNextButton
            // 
            this.OrganizerNextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrganizerNextButton.Location = new System.Drawing.Point(144, 333);
            this.OrganizerNextButton.Name = "OrganizerNextButton";
            this.OrganizerNextButton.Size = new System.Drawing.Size(97, 34);
            this.OrganizerNextButton.TabIndex = 6;
            this.OrganizerNextButton.Text = "Next Page";
            this.OrganizerNextButton.UseVisualStyleBackColor = true;
            // 
            // OrganizerPreviousButton
            // 
            this.OrganizerPreviousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrganizerPreviousButton.Location = new System.Drawing.Point(24, 333);
            this.OrganizerPreviousButton.Name = "OrganizerPreviousButton";
            this.OrganizerPreviousButton.Size = new System.Drawing.Size(102, 33);
            this.OrganizerPreviousButton.TabIndex = 5;
            this.OrganizerPreviousButton.Text = "Previous Page";
            this.OrganizerPreviousButton.UseVisualStyleBackColor = true;
            // 
            // AddConferenceButton
            // 
            this.AddConferenceButton.Location = new System.Drawing.Point(24, 42);
            this.AddConferenceButton.Name = "AddConferenceButton";
            this.AddConferenceButton.Size = new System.Drawing.Size(102, 37);
            this.AddConferenceButton.TabIndex = 3;
            this.AddConferenceButton.Text = "Add Conference";
            this.AddConferenceButton.UseVisualStyleBackColor = true;
            this.AddConferenceButton.Click += new System.EventHandler(this.AddConferenceButton_Click);
            // 
            // OrganizerEndDatePicker
            // 
            this.OrganizerEndDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrganizerEndDatePicker.Location = new System.Drawing.Point(467, 56);
            this.OrganizerEndDatePicker.Name = "OrganizerEndDatePicker";
            this.OrganizerEndDatePicker.Size = new System.Drawing.Size(200, 23);
            this.OrganizerEndDatePicker.TabIndex = 2;
            // 
            // OrganizerStartDatePicker
            // 
            this.OrganizerStartDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrganizerStartDatePicker.Location = new System.Drawing.Point(467, 27);
            this.OrganizerStartDatePicker.Name = "OrganizerStartDatePicker";
            this.OrganizerStartDatePicker.Size = new System.Drawing.Size(200, 23);
            this.OrganizerStartDatePicker.TabIndex = 1;
            // 
            // OrganizerFilterButton
            // 
            this.OrganizerFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrganizerFilterButton.Location = new System.Drawing.Point(673, 38);
            this.OrganizerFilterButton.Name = "OrganizerFilterButton";
            this.OrganizerFilterButton.Size = new System.Drawing.Size(62, 31);
            this.OrganizerFilterButton.TabIndex = 0;
            this.OrganizerFilterButton.Text = "Filter";
            this.OrganizerFilterButton.UseVisualStyleBackColor = true;
            // 
            // TabParticipant
            // 
            this.TabParticipant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabParticipant.BackgroundImage")));
            // 
            // ConferencesParticipant
            // 
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
            this.ConferencesParticipant.Location = new System.Drawing.Point(10, 80);
            this.ConferencesParticipant.Name = "ConferencesParticipant";
            this.ConferencesParticipant.Size = new System.Drawing.Size(781, 255);
            this.ConferencesParticipant.TabIndex = 3;
            this.ConferencesParticipant.Text = "dataGridView1";
            this.ConferencesParticipant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConferencesParticipant_CellContentClick);
            this.TabParticipant.Controls.Add(this.FilterParticipants);
            this.TabParticipant.Controls.Add(this.DatePickerParticipantEnd);
            this.TabParticipant.Controls.Add(this.DatePickerParticipantStart);
            this.TabParticipant.Controls.Add(this.ConferencesParticipant);
            this.TabParticipant.Controls.Add(this.NextButtonParticipant);
            this.TabParticipant.Controls.Add(this.BackButtonParticipant);
            this.TabParticipant.Location = new System.Drawing.Point(4, 24);
            this.TabParticipant.Name = "TabParticipant";
            this.TabParticipant.Padding = new System.Windows.Forms.Padding(3);
            this.TabParticipant.Size = new System.Drawing.Size(800, 370);
            this.TabParticipant.TabIndex = 0;
            this.TabParticipant.Text = "Participants";
            this.TabParticipant.UseVisualStyleBackColor = true;
            // 
            // FilterParticipants
            // 
            this.FilterParticipants.BackColor = System.Drawing.Color.DarkSalmon;
            this.FilterParticipants.ForeColor = System.Drawing.Color.Navy;
            this.FilterParticipants.Location = new System.Drawing.Point(10, 22);
            this.FilterParticipants.Name = "FilterParticipants";
            this.FilterParticipants.Size = new System.Drawing.Size(85, 35);
            this.FilterParticipants.TabIndex = 6;
            this.FilterParticipants.Text = "Filter";
            this.FilterParticipants.UseVisualStyleBackColor = false;
            this.FilterParticipants.Click += new System.EventHandler(this.FilterParticipants_Click);
            // 
            // DatePickerParticipantEnd
            // 
            this.DatePickerParticipantEnd.Location = new System.Drawing.Point(113, 51);
            this.DatePickerParticipantEnd.Name = "DatePickerParticipantEnd";
            this.DatePickerParticipantEnd.Size = new System.Drawing.Size(200, 23);
            this.DatePickerParticipantEnd.TabIndex = 5;
            // 
            // DatePickerParticipantStart
            // 
            this.DatePickerParticipantStart.Location = new System.Drawing.Point(113, 22);
            this.DatePickerParticipantStart.Name = "DatePickerParticipantStart";
            this.DatePickerParticipantStart.Size = new System.Drawing.Size(200, 23);
            this.DatePickerParticipantStart.TabIndex = 4;
            this.DatePickerParticipantStart.ValueChanged += new System.EventHandler(this.DatePickerParticipantStart_ValueChanged);
            // 
            // ColumnNameConferenceParticipant
            // 
            this.ColumnNameConferenceParticipant.HeaderText = "Name";
            this.ColumnNameConferenceParticipant.Name = "ColumnNameConferenceParticipant";
            this.ColumnNameConferenceParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnStartDateParticipant
            // 
            this.ColumnStartDateParticipant.HeaderText = "Start Date";
            this.ColumnStartDateParticipant.Name = "ColumnStartDateParticipant";
            this.ColumnStartDateParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnEndDateParticipant
            // 
            this.ColumnEndDateParticipant.HeaderText = "End Date";
            this.ColumnEndDateParticipant.Name = "ColumnEndDateParticipant";
            this.ColumnEndDateParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnTypeParticipant
            // 
            this.ColumnTypeParticipant.HeaderText = "Type";
            this.ColumnTypeParticipant.Name = "ColumnTypeParticipant";
            this.ColumnTypeParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnCategoryParticipant
            // 
            this.ColumnCategoryParticipant.HeaderText = "Category";
            this.ColumnCategoryParticipant.Name = "ColumnCategoryParticipant";
            this.ColumnCategoryParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnAddressParticipant
            // 
            this.ColumnAddressParticipant.HeaderText = "Address";
            this.ColumnAddressParticipant.Name = "ColumnAddressParticipant";
            this.ColumnAddressParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnSpeakerParticipant
            // 
            this.ColumnSpeakerParticipant.HeaderText = "Speaker";
            this.ColumnSpeakerParticipant.Name = "ColumnSpeakerParticipant";
            this.ColumnSpeakerParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnAttend
            // 
            this.ColumnAttend.HeaderText = "Attend";
            this.ColumnAttend.Name = "ColumnAttend";
            this.ColumnAttend.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnJoinButton
            // 
            this.ColumnJoinButton.HeaderText = "Join";
            this.ColumnJoinButton.Name = "ColumnJoinButton";
            this.ColumnJoinButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnWithdrawButton
            // 
            this.ColumnWithdrawButton.HeaderText = "Withdraw";
            this.ColumnWithdrawButton.Name = "ColumnWithdrawButton";
            this.ColumnWithdrawButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NextButtonParticipant
            // 
            this.NextButtonParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButtonParticipant.BackColor = System.Drawing.Color.DarkSalmon;
            this.NextButtonParticipant.ForeColor = System.Drawing.Color.Navy;
            this.NextButtonParticipant.Location = new System.Drawing.Point(653, 341);
            this.NextButtonParticipant.Name = "NextButtonParticipant";
            this.NextButtonParticipant.Size = new System.Drawing.Size(75, 23);
            this.NextButtonParticipant.TabIndex = 2;
            this.NextButtonParticipant.Text = "Next";
            this.NextButtonParticipant.UseVisualStyleBackColor = false;
            this.NextButtonParticipant.Click += new System.EventHandler(this.NextButtonParticipant_Click);
            // 
            // BackButtonParticipant
            // 
            this.BackButtonParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButtonParticipant.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackButtonParticipant.ForeColor = System.Drawing.Color.Navy;
            this.BackButtonParticipant.Location = new System.Drawing.Point(542, 341);
            this.BackButtonParticipant.Name = "BackButtonParticipant";
            this.BackButtonParticipant.Size = new System.Drawing.Size(75, 23);
            this.BackButtonParticipant.TabIndex = 1;
            this.BackButtonParticipant.Text = "Back";
            this.BackButtonParticipant.UseVisualStyleBackColor = false;
            this.BackButtonParticipant.Click += new System.EventHandler(this.BackButtonParticipant_Click);
            // 
            // TabControrConferences
            // 
            this.TabControrConferences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControrConferences.Controls.Add(this.TabParticipant);
            this.TabControrConferences.Controls.Add(this.TabOrganizer);
            this.TabControrConferences.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TabControrConferences.Location = new System.Drawing.Point(-2, 2);
            this.TabControrConferences.Name = "TabControrConferences";
            this.TabControrConferences.SelectedIndex = 2;
            this.TabControrConferences.Size = new System.Drawing.Size(808, 398);
            this.TabControrConferences.TabIndex = 0;
            // 
            // ColumnState
            // 
            this.ColumnState.HeaderText = "State";
            this.ColumnState.Name = "ColumnState";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 404);
            this.Controls.Add(this.TabControrConferences);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrganizerGrid)).EndInit();
            this.TabOrganizer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrganizerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConferencesParticipant)).EndInit();
            this.TabParticipant.ResumeLayout(false);
            this.TabControrConferences.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TabOrganizer;
        private System.Windows.Forms.TabPage TabParticipant;
        private System.Windows.Forms.TabControl TabControrConferences;
        private System.Windows.Forms.Button NextButtonParticipant;
        private System.Windows.Forms.Button BackButtonParticipant;
        private System.Windows.Forms.DataGridView ConferencesParticipant;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.DateTimePicker DatePickerParticipantStart;
        private System.Windows.Forms.Button FilterParticipants;
        private System.Windows.Forms.DateTimePicker DatePickerParticipantEnd;
        private System.Windows.Forms.DateTimePicker OrganizerStartDatePicker;
        private System.Windows.Forms.Button OrganizerFilterButton;
        private System.Windows.Forms.DateTimePicker OrganizerEndDatePicker;
        private System.Windows.Forms.Button AddConferenceButton;
        private System.Windows.Forms.DataGridView OrganizerGrid;
        private System.Windows.Forms.Button OrganizerPreviousButton;
        private System.Windows.Forms.Button OrganizerNextButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNameConferenceParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStartDateParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndDateParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoryParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddressParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpeakerParticipant;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnAttend;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnJoinButton;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnWithdrawButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnState;
    }
}