﻿namespace ConferencePlanner.WinUi
{
    partial class AddConferance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddConferance));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabConferance = new System.Windows.Forms.TabControl();
            this.tabSpeakers = new System.Windows.Forms.TabPage();

            //this.dataGridView1 = new System.Windows.Forms.DataGridView();
            //this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //this.Main = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            //this.IsSpeakerConference = new System.Windows.Forms.DataGridViewCheckBoxColumn();

            this.tabSpeakerGrid = new System.Windows.Forms.DataGridView();
            this.tabSpeakerAddButton = new System.Windows.Forms.Button();

            this.tabCategory = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CategoryName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CategoryCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabType = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.TypeName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NewCountry = new ConferencePlanner.WinUi.ButonCircular();
            this.DGVCountry = new System.Windows.Forms.DataGridView();
            this.CountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NewDistrict = new ConferencePlanner.WinUi.ButonCircular();
            this.DGVDistrict = new System.Windows.Forms.DataGridView();
            this.DictrictName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistrictCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.NewCity = new ConferencePlanner.WinUi.ButonCircular();
            this.DGVCity = new System.Windows.Forms.DataGridView();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organ = new System.Windows.Forms.Label();
            this.txtOrganizer = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btSaveAndNew = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();

            this.tabConferance.SuspendLayout();

            this.tabSpeakerPreviousButton = new System.Windows.Forms.Button();
            this.tabSpeakersNextButton = new System.Windows.Forms.Button();
            this.tabSpeakerColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSpeakerColumnRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSpeakerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSpeakerRatingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSpeakerNationalityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSpeakerMainColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabSpeakerParticipantColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabSpeakerEditColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabSpeakerDeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabConferance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabSpeakerGrid)).BeginInit();

            this.tabSpeakers.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            //this.tabCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCountry)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDistrict)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conference name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(25, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Conferance address";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(172, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 23);
            this.txtName.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(172, 101);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(163, 23);
            this.txtAddress.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(290, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabConferance
            // 
            this.tabConferance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabConferance.Controls.Add(this.tabSpeakers);
            this.tabConferance.Controls.Add(this.tabCategory);
            this.tabConferance.Controls.Add(this.tabType);
            this.tabConferance.Controls.Add(this.tabPage1);
            this.tabConferance.Controls.Add(this.tabPage2);
            this.tabConferance.Controls.Add(this.tabPage3);
            this.tabConferance.Location = new System.Drawing.Point(25, 140);
            this.tabConferance.Name = "tabConferance";
            this.tabConferance.SelectedIndex = 5;
            this.tabConferance.Size = new System.Drawing.Size(761, 185);
            this.tabConferance.TabIndex = 9;
            this.tabConferance.Tag = "Country";
            this.tabConferance.SelectedIndexChanged += new System.EventHandler(this.tabConferance_SelectedIndexChanged);
            this.tabConferance.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabConferance_Selecting);
            this.tabConferance.Validating += new System.ComponentModel.CancelEventHandler(this.tabConferance_Validating);
            // 
            // tabSpeakers
            // 
           // this.tabSpeakers.Controls.Add(this.dataGridView1);
            this.tabSpeakers.Location = new System.Drawing.Point(4, 24);
            this.tabSpeakers.Name = "tabSpeakers";
            this.tabSpeakers.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpeakers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabSpeakers.Size = new System.Drawing.Size(753, 157);
            this.tabSpeakers.TabIndex = 1;
            this.tabSpeakers.Text = "Speakers";
            this.tabSpeakers.UseVisualStyleBackColor = true;
            // 

            // dataGridView1
            // 
            //this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            //this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            //this.Column1,
            //this.Rating,
            //this.Column2,
            //this.Main,
            //this.IsSpeakerConference});
            //this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            //this.dataGridView1.Name = "dataGridView1";
            //this.dataGridView1.Size = new System.Drawing.Size(643, 107);
            //this.dataGridView1.TabIndex = 0;
            //this.dataGridView1.Text = "dataGridView1";
            //this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);

            // tabSpeakerGrid
            // 
            this.tabSpeakerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabSpeakerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabSpeakerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tabSpeakerNameColumn,
            this.tabSpeakerRatingColumn,
            this.tabSpeakerNationalityColumn,
            this.tabSpeakerMainColumn,
            this.tabSpeakerParticipantColumn,
            this.tabSpeakerEditColumn,
            this.tabSpeakerDeleteColumn});
            this.tabSpeakerGrid.Location = new System.Drawing.Point(3, 3);
            this.tabSpeakerGrid.Name = "tabSpeakerGrid";
            this.tabSpeakerGrid.Size = new System.Drawing.Size(747, 122);
            this.tabSpeakerGrid.TabIndex = 0;
            this.tabSpeakerGrid.Text = "dataGridView1";
            this.tabSpeakerGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabSpeakerGrid_CellClick);
            this.tabSpeakerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabSpeakerGrid_CellContentClick);
            this.tabSpeakers.Controls.Add(this.tabSpeakersNextButton);
            this.tabSpeakers.Controls.Add(this.tabSpeakerPreviousButton);
            this.tabSpeakers.Controls.Add(this.tabSpeakerAddButton);
            this.tabSpeakers.Controls.Add(this.tabSpeakerGrid);
            this.tabSpeakers.Location = new System.Drawing.Point(4, 24);
            this.tabSpeakers.Name = "tabSpeakers";
            this.tabSpeakers.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpeakers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabSpeakers.Size = new System.Drawing.Size(753, 157);
            this.tabSpeakers.TabIndex = 1;
            this.tabSpeakers.Text = "Speakers";
            this.tabSpeakers.UseVisualStyleBackColor = true;

            // 
            // tabSpeakerAddButton
            // 
            this.tabSpeakerAddButton.Location = new System.Drawing.Point(14, 131);
            this.tabSpeakerAddButton.Name = "tabSpeakerAddButton";
            this.tabSpeakerAddButton.Size = new System.Drawing.Size(75, 23);
            this.tabSpeakerAddButton.TabIndex = 20;
            this.tabSpeakerAddButton.Text = "Add";
            this.tabSpeakerAddButton.UseVisualStyleBackColor = true;
            this.tabSpeakerAddButton.Click += new System.EventHandler(this.tabSpeakerAddButton_Click);
            // 
            // IsSpeakerConference
            // 
           // this.IsSpeakerConference.HeaderText = "In Conference";
            //this.IsSpeakerConference.Name = "IsSpeakerConference";
            // 
            // tabCategory
            // 
            this.tabCategory.Controls.Add(this.dataGridView2);
            this.tabCategory.Location = new System.Drawing.Point(4, 24);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabCategory.Size = new System.Drawing.Size(753, 157);
            this.tabCategory.TabIndex = 2;
            this.tabCategory.Text = "Category";
            this.tabCategory.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryName,
            this.CategoryCode});
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(682, 117);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.Text = "dataGridView2";
            // 
            // CategoryName
            // 
            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CategoryCode
            // 
            this.CategoryCode.HeaderText = "Category code";
            this.CategoryCode.Name = "CategoryCode";
            this.CategoryCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabType
            // 
            this.tabType.Controls.Add(this.dataGridView3);
            this.tabType.Location = new System.Drawing.Point(4, 24);
            this.tabType.Name = "tabType";
            this.tabType.Size = new System.Drawing.Size(753, 157);
            this.tabType.TabIndex = 3;
            this.tabType.Text = "Type";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeName,
            this.TypeCode});
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(753, 151);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.Text = "dataGridView3";
            // 
            // TypeName
            // 
            this.TypeName.HeaderText = "Type name";
            this.TypeName.Name = "TypeName";
            this.TypeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TypeCode
            // 
            this.TypeCode.HeaderText = "Type Code";
            this.TypeCode.Name = "TypeCode";
            this.TypeCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NewCountry);
            this.tabPage1.Controls.Add(this.DGVCountry);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(753, 157);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Country";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NewCountry
            // 
            this.NewCountry.Location = new System.Drawing.Point(566, 47);
            this.NewCountry.Name = "NewCountry";
            this.NewCountry.Size = new System.Drawing.Size(123, 37);
            this.NewCountry.TabIndex = 1;
            this.NewCountry.Text = "New Country";
            this.NewCountry.UseVisualStyleBackColor = true;
            this.NewCountry.Click += new System.EventHandler(this.NewCountry_Click);
            // 
            // DGVCountry
            // 
            this.DGVCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCountry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountryName,
            this.CountryCod});
            this.DGVCountry.Location = new System.Drawing.Point(4, 4);
            this.DGVCountry.Name = "DGVCountry";
            this.DGVCountry.Size = new System.Drawing.Size(377, 150);
            this.DGVCountry.TabIndex = 0;
            this.DGVCountry.Text = "dataGridView5";
            this.DGVCountry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // CountryName
            // 
            this.CountryName.HeaderText = "Name";
            this.CountryName.Name = "CountryName";
            // 
            // CountryCod
            // 
            this.CountryCod.HeaderText = "Cod";
            this.CountryCod.Name = "CountryCod";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.NewDistrict);
            this.tabPage2.Controls.Add(this.DGVDistrict);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(753, 157);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "District";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NewDistrict
            // 
            this.NewDistrict.Location = new System.Drawing.Point(530, 47);
            this.NewDistrict.Name = "NewDistrict";
            this.NewDistrict.Size = new System.Drawing.Size(105, 36);
            this.NewDistrict.TabIndex = 1;
            this.NewDistrict.Text = "New District";
            this.NewDistrict.UseVisualStyleBackColor = true;
            this.NewDistrict.Click += new System.EventHandler(this.NewDistrict_Click);
            // 
            // DGVDistrict
            // 
            this.DGVDistrict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDistrict.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DictrictName,
            this.DistrictCod});
            this.DGVDistrict.Location = new System.Drawing.Point(4, 4);
            this.DGVDistrict.Name = "DGVDistrict";
            this.DGVDistrict.Size = new System.Drawing.Size(382, 150);
            this.DGVDistrict.TabIndex = 0;
            this.DGVDistrict.Text = "dataGridView7";
            // 
            // DictrictName
            // 
            this.DictrictName.HeaderText = "Name";
            this.DictrictName.Name = "DictrictName";
            // 
            // DistrictCod
            // 
            this.DistrictCod.HeaderText = "Cod";
            this.DistrictCod.Name = "DistrictCod";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.NewCity);
            this.tabPage3.Controls.Add(this.DGVCity);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(753, 157);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "City";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // NewCity
            // 
            this.NewCity.Location = new System.Drawing.Point(490, 20);
            this.NewCity.Name = "NewCity";
            this.NewCity.Size = new System.Drawing.Size(75, 36);
            this.NewCity.TabIndex = 1;
            this.NewCity.Text = "New City";
            this.NewCity.UseVisualStyleBackColor = true;
            this.NewCity.Click += new System.EventHandler(this.NewCity_Click);
            // 
            // DGVCity
            // 
            this.DGVCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CityName,
            this.CityCod});
            this.DGVCity.Location = new System.Drawing.Point(4, 4);
            this.DGVCity.Name = "DGVCity";
            this.DGVCity.Size = new System.Drawing.Size(356, 150);
            this.DGVCity.TabIndex = 0;
            this.DGVCity.Text = "dataGridView6";
            // 
            // CityName
            // 
            this.CityName.HeaderText = "Name";
            this.CityName.Name = "CityName";
            this.CityName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CityCod
            // 
            this.CityCod.HeaderText = "Cod";
            this.CityCod.Name = "CityCod";
            this.CityCod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Organ
            // 
            this.Organ.AutoSize = true;
            this.Organ.BackColor = System.Drawing.Color.Transparent;
            this.Organ.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Organ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Organ.Location = new System.Drawing.Point(25, 64);
            this.Organ.Name = "Organ";
            this.Organ.Size = new System.Drawing.Size(114, 15);
            this.Organ.TabIndex = 10;
            this.Organ.Text = "Organizer name ";
            // 
            // txtOrganizer
            // 
            this.txtOrganizer.Location = new System.Drawing.Point(172, 61);
            this.txtOrganizer.Name = "txtOrganizer";
            this.txtOrganizer.Size = new System.Drawing.Size(163, 23);
            this.txtOrganizer.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(842, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btSaveAndNew
            // 
            this.btSaveAndNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSaveAndNew.Location = new System.Drawing.Point(406, 331);
            this.btSaveAndNew.Name = "btSaveAndNew";
            this.btSaveAndNew.Size = new System.Drawing.Size(101, 27);
            this.btSaveAndNew.TabIndex = 13;
            this.btSaveAndNew.Text = "Save and New";
            this.btSaveAndNew.UseVisualStyleBackColor = true;
            this.btSaveAndNew.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(495, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Location = new System.Drawing.Point(495, 81);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(401, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(401, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "End Date";
            // 
            // btBack
            // 
            this.btBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btBack.Location = new System.Drawing.Point(159, 331);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(88, 27);
            this.btBack.TabIndex = 18;
            this.btBack.Text = "Back ";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(805, 361);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(240, 150);
            this.dataGridView4.TabIndex = 19;
            this.dataGridView4.Text = "dataGridView4";
            // 

            // tabSpeakerPreviousButton
            // 
            this.tabSpeakerPreviousButton.Location = new System.Drawing.Point(584, 131);
            this.tabSpeakerPreviousButton.Name = "tabSpeakerPreviousButton";
            this.tabSpeakerPreviousButton.Size = new System.Drawing.Size(75, 23);
            this.tabSpeakerPreviousButton.TabIndex = 21;
            this.tabSpeakerPreviousButton.Text = "Previous";
            this.tabSpeakerPreviousButton.UseVisualStyleBackColor = true;
            this.tabSpeakerPreviousButton.Click += new System.EventHandler(this.tabSpeakerPreviousButton_Click);
            // 
            // tabSpeakersNextButton
            // 
            this.tabSpeakersNextButton.Location = new System.Drawing.Point(665, 131);
            this.tabSpeakersNextButton.Name = "tabSpeakersNextButton";
            this.tabSpeakersNextButton.Size = new System.Drawing.Size(75, 23);
            this.tabSpeakersNextButton.TabIndex = 22;
            this.tabSpeakersNextButton.Text = "Next";
            this.tabSpeakersNextButton.UseVisualStyleBackColor = true;
            this.tabSpeakersNextButton.Click += new System.EventHandler(this.tabSpeakerNextButton_Click);
            // 
            // tabSpeakerColumnName
            // 
            this.tabSpeakerColumnName.HeaderText = "Name";
            this.tabSpeakerColumnName.Name = "tabSpeakerColumnName";
            this.tabSpeakerColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabSpeakerColumnName.Width = 101;
            // 
            // tabSpeakerColumnRating
            // 
            this.tabSpeakerColumnRating.HeaderText = "Rating";
            this.tabSpeakerColumnRating.Name = "tabSpeakerColumnRating";
            this.tabSpeakerColumnRating.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabSpeakerNameColumn
            // 
            this.tabSpeakerNameColumn.HeaderText = "Name";
            this.tabSpeakerNameColumn.Name = "tabSpeakerNameColumn";
            // 
            // tabSpeakerRatingColumn
            // 
            this.tabSpeakerRatingColumn.HeaderText = "Rating";
            this.tabSpeakerRatingColumn.Name = "tabSpeakerRatingColumn";
            // 
            // tabSpeakerNationalityColumn
            // 
            this.tabSpeakerNationalityColumn.HeaderText = "Nationality";
            this.tabSpeakerNationalityColumn.Name = "tabSpeakerNationalityColumn";
            // 
            // tabSpeakerMainColumn
            // 
            this.tabSpeakerMainColumn.HeaderText = "Main";
            this.tabSpeakerMainColumn.Name = "tabSpeakerMainColumn";
            // 
            // tabSpeakerParticipantColumn
            // 
            this.tabSpeakerParticipantColumn.HeaderText = "Participant";
            this.tabSpeakerParticipantColumn.Name = "tabSpeakerParticipantColumn";
            // 
            // tabSpeakerEditColumn
            // 
            this.tabSpeakerEditColumn.HeaderText = "Edit";
            this.tabSpeakerEditColumn.Name = "tabSpeakerEditColumn";
            // 
            // tabSpeakerDeleteColumn
            // 
            this.tabSpeakerDeleteColumn.HeaderText = "Delete";
            this.tabSpeakerDeleteColumn.Name = "tabSpeakerDeleteColumn";
            // 

            // AddConferance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 370);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btSaveAndNew);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtOrganizer);
            this.Controls.Add(this.Organ);
            this.Controls.Add(this.tabConferance);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddConferance";
            this.Text = "Start Date";
            this.Load += new System.EventHandler(this.AddConferance_Load);
            this.tabConferance.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.tabSpeakerGrid)).EndInit();

            this.tabSpeakers.ResumeLayout(false);
           // ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
           // this.tabCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCountry)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDistrict)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabConferance;
        private System.Windows.Forms.TabPage tabSpeakers;
        private System.Windows.Forms.TabPage tabCategory;
        private System.Windows.Forms.TabPage tabType;
        private System.Windows.Forms.Label Organ;
        private System.Windows.Forms.TextBox txtOrganizer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btSaveAndNew;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView tabSpeakerGrid;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewComboBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewComboBoxColumn CategoryCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCode;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;

        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSpeakerConference;
        private System.Windows.Forms.DataGridView DGVCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryCod;
        private System.Windows.Forms.DataGridView DGVCity;
        private ButonCircular NewCountry;
        private ButonCircular NewDistrict;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.DataGridViewTextBoxColumn DictrictName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistrictCod;
        private ButonCircular NewCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityCod;
        private System.Windows.Forms.DataGridView DGVDistrict;

        private System.Windows.Forms.Button tabSpeakerAddButton;
        private System.Windows.Forms.Button tabSpeakersNextButton;
        private System.Windows.Forms.Button tabSpeakerPreviousButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabSpeakerColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabSpeakerColumnRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabSpeakerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabSpeakerRatingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabSpeakerNationalityColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tabSpeakerMainColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tabSpeakerParticipantColumn;
        private System.Windows.Forms.DataGridViewButtonColumn tabSpeakerEditColumn;
        private System.Windows.Forms.DataGridViewButtonColumn tabSpeakerDeleteColumn;

    }
}