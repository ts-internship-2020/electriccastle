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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabState = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Organ = new System.Windows.Forms.Label();
            this.txtOrganizer = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btSaveAndNew = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.tabConferance.SuspendLayout();
            this.tabSpeakers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.label4.Location = new System.Drawing.Point(28, 104);
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
            this.tabConferance.Controls.Add(this.tabSpeakers);
            this.tabConferance.Controls.Add(this.tabCategory);
            this.tabConferance.Controls.Add(this.tabState);
            this.tabConferance.Location = new System.Drawing.Point(25, 140);
            this.tabConferance.Name = "tabConferance";
            this.tabConferance.SelectedIndex = 3;
            this.tabConferance.Size = new System.Drawing.Size(767, 185);
            this.tabConferance.TabIndex = 9;
            this.tabConferance.SelectedIndexChanged += new System.EventHandler(this.tabConferance_SelectedIndexChanged);
            this.tabConferance.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabConferance_Selecting);
            this.tabConferance.Validating += new System.ComponentModel.CancelEventHandler(this.tabConferance_Validating);
            // 
            // tabSpeakers
            // 
            this.tabSpeakers.Controls.Add(this.dataGridView1);
            this.tabSpeakers.Location = new System.Drawing.Point(4, 24);
            this.tabSpeakers.Name = "tabSpeakers";
            this.tabSpeakers.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpeakers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabSpeakers.Size = new System.Drawing.Size(759, 157);
            this.tabSpeakers.TabIndex = 1;
            this.tabSpeakers.Text = "Speakers";
            this.tabSpeakers.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Rating,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 151);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Speaker name";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            this.Rating.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nationality";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabCategory
            // 
            this.tabCategory.Controls.Add(this.dataGridView2);
            this.tabCategory.Location = new System.Drawing.Point(4, 24);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabCategory.Size = new System.Drawing.Size(759, 157);
            this.tabCategory.TabIndex = 2;
            this.tabCategory.Text = "Category";
            this.tabCategory.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(753, 151);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.Text = "dataGridView2";
            // 
            // tabState
            // 
            this.tabState.Controls.Add(this.dataGridView3);
            this.tabState.Location = new System.Drawing.Point(4, 24);
            this.tabState.Name = "tabState";
            this.tabState.Size = new System.Drawing.Size(759, 157);
            this.tabState.TabIndex = 3;
            this.tabState.Text = "State";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(753, 151);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.Text = "dataGridView3";
            // 
            // Organ
            // 
            this.Organ.AutoSize = true;
            this.Organ.BackColor = System.Drawing.Color.Transparent;
            this.Organ.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Organ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Organ.Location = new System.Drawing.Point(29, 64);
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
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(495, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(495, 81);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // label2
            // 
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
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(406, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "End Date";
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(159, 331);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(88, 27);
            this.btBack.TabIndex = 18;
            this.btBack.Text = "Back ";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // AddConferance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(804, 370);
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
            this.tabConferance.ResumeLayout(false);
            this.tabSpeakers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabState.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private System.Windows.Forms.TabPage tabState;
        private System.Windows.Forms.Label Organ;
        private System.Windows.Forms.TextBox txtOrganizer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btSaveAndNew;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btBack;
    }
}