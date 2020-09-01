namespace ConferencePlanner.WinUi
{
    partial class EditSpeakerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSpeakerForm));
            this.editSpeakerPictureBox = new System.Windows.Forms.PictureBox();
            this.editSpeakerCode = new System.Windows.Forms.Label();
            this.editSpeakerName = new System.Windows.Forms.Label();
            this.editSpeakerRating = new System.Windows.Forms.Label();
            this.editSpeakerNationnality = new System.Windows.Forms.Label();
            this.editSpeakerPicture = new System.Windows.Forms.Label();
            this.editSpeakerCodeTextBox = new System.Windows.Forms.TextBox();
            this.editSpeakerNameTextBox = new System.Windows.Forms.TextBox();
            this.editSpeakerRatingTextBox = new System.Windows.Forms.TextBox();
            this.editSpeakerNationalityTextBox = new System.Windows.Forms.TextBox();
            this.editSpeakerPictureTextBox = new System.Windows.Forms.TextBox();
            this.errorProviderEditSpeakerCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEditSpeakerName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEditSpeakerRating = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEditSpeakerNationality = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEditSpeakerPicture = new System.Windows.Forms.ErrorProvider(this.components);
            this.butonCircular1 = new ConferencePlanner.WinUi.ButonCircular();
            ((System.ComponentModel.ISupportInitialize)(this.editSpeakerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditSpeakerCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditSpeakerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditSpeakerRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditSpeakerNationality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditSpeakerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // editSpeakerPictureBox
            // 
            this.editSpeakerPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editSpeakerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("editSpeakerPictureBox.Image")));
            this.editSpeakerPictureBox.Location = new System.Drawing.Point(72, 82);
            this.editSpeakerPictureBox.Name = "editSpeakerPictureBox";
            this.editSpeakerPictureBox.Size = new System.Drawing.Size(332, 212);
            this.editSpeakerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editSpeakerPictureBox.TabIndex = 0;
            this.editSpeakerPictureBox.TabStop = false;
            // 
            // editSpeakerCode
            // 
            this.editSpeakerCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSpeakerCode.AutoSize = true;
            this.editSpeakerCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editSpeakerCode.Location = new System.Drawing.Point(478, 82);
            this.editSpeakerCode.Name = "editSpeakerCode";
            this.editSpeakerCode.Size = new System.Drawing.Size(47, 17);
            this.editSpeakerCode.TabIndex = 1;
            this.editSpeakerCode.Text = "Code :";
            // 
            // editSpeakerName
            // 
            this.editSpeakerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSpeakerName.AutoSize = true;
            this.editSpeakerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editSpeakerName.Location = new System.Drawing.Point(478, 126);
            this.editSpeakerName.Name = "editSpeakerName";
            this.editSpeakerName.Size = new System.Drawing.Size(52, 17);
            this.editSpeakerName.TabIndex = 2;
            this.editSpeakerName.Text = "Name :";
            // 
            // editSpeakerRating
            // 
            this.editSpeakerRating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSpeakerRating.AutoSize = true;
            this.editSpeakerRating.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editSpeakerRating.Location = new System.Drawing.Point(478, 171);
            this.editSpeakerRating.Name = "editSpeakerRating";
            this.editSpeakerRating.Size = new System.Drawing.Size(56, 17);
            this.editSpeakerRating.TabIndex = 3;
            this.editSpeakerRating.Text = "Rating :";
            // 
            // editSpeakerNationnality
            // 
            this.editSpeakerNationnality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSpeakerNationnality.AutoSize = true;
            this.editSpeakerNationnality.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editSpeakerNationnality.Location = new System.Drawing.Point(478, 220);
            this.editSpeakerNationnality.Name = "editSpeakerNationnality";
            this.editSpeakerNationnality.Size = new System.Drawing.Size(85, 17);
            this.editSpeakerNationnality.TabIndex = 4;
            this.editSpeakerNationnality.Text = "Nationality: ";
            this.editSpeakerNationnality.Click += new System.EventHandler(this.label3_Click);
            // 
            // editSpeakerPicture
            // 
            this.editSpeakerPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSpeakerPicture.AutoSize = true;
            this.editSpeakerPicture.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editSpeakerPicture.Location = new System.Drawing.Point(478, 266);
            this.editSpeakerPicture.Name = "editSpeakerPicture";
            this.editSpeakerPicture.Size = new System.Drawing.Size(89, 17);
            this.editSpeakerPicture.TabIndex = 5;
            this.editSpeakerPicture.Text = "Picture Link :";
            // 
            // editSpeakerCodeTextBox
            // 
            this.editSpeakerCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSpeakerCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editSpeakerCodeTextBox.Location = new System.Drawing.Point(585, 82);
            this.editSpeakerCodeTextBox.Name = "editSpeakerCodeTextBox";
            this.editSpeakerCodeTextBox.Size = new System.Drawing.Size(171, 25);
            this.editSpeakerCodeTextBox.TabIndex = 6;
            this.editSpeakerCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editSpeakerCodeTextBox.TextChanged += new System.EventHandler(this.editSpeakerCodeTextBox_TextChanged);
            this.editSpeakerCodeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.editSpeakerCodeTextBox_Validating);
            // 
            // editSpeakerNameTextBox
            // 
            this.editSpeakerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSpeakerNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editSpeakerNameTextBox.Location = new System.Drawing.Point(585, 125);
            this.editSpeakerNameTextBox.Name = "editSpeakerNameTextBox";
            this.editSpeakerNameTextBox.Size = new System.Drawing.Size(171, 25);
            this.editSpeakerNameTextBox.TabIndex = 7;
            this.editSpeakerNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editSpeakerNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.editSpeakerNameTextBox_Validating);
            // 
            // editSpeakerRatingTextBox
            // 
            this.editSpeakerRatingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSpeakerRatingTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editSpeakerRatingTextBox.Location = new System.Drawing.Point(585, 171);
            this.editSpeakerRatingTextBox.Name = "editSpeakerRatingTextBox";
            this.editSpeakerRatingTextBox.Size = new System.Drawing.Size(171, 25);
            this.editSpeakerRatingTextBox.TabIndex = 8;
            this.editSpeakerRatingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editSpeakerRatingTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.editSpeakerRatingTextBox_Validating);
            // 
            // editSpeakerNationalityTextBox
            // 
            this.editSpeakerNationalityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSpeakerNationalityTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editSpeakerNationalityTextBox.Location = new System.Drawing.Point(585, 220);
            this.editSpeakerNationalityTextBox.Name = "editSpeakerNationalityTextBox";
            this.editSpeakerNationalityTextBox.Size = new System.Drawing.Size(171, 25);
            this.editSpeakerNationalityTextBox.TabIndex = 9;
            this.editSpeakerNationalityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editSpeakerNationalityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.editSpeakerNationalityTextBox_Validating);
            // 
            // editSpeakerPictureTextBox
            // 
            this.editSpeakerPictureTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSpeakerPictureTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editSpeakerPictureTextBox.Location = new System.Drawing.Point(585, 266);
            this.editSpeakerPictureTextBox.Name = "editSpeakerPictureTextBox";
            this.editSpeakerPictureTextBox.Size = new System.Drawing.Size(171, 25);
            this.editSpeakerPictureTextBox.TabIndex = 10;
            this.editSpeakerPictureTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editSpeakerPictureTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.editSpeakerPictureTextBox_Validating);
            // 
            // errorProviderEditSpeakerCode
            // 
            this.errorProviderEditSpeakerCode.ContainerControl = this;
            // 
            // errorProviderEditSpeakerName
            // 
            this.errorProviderEditSpeakerName.ContainerControl = this;
            // 
            // errorProviderEditSpeakerRating
            // 
            this.errorProviderEditSpeakerRating.ContainerControl = this;
            // 
            // errorProviderEditSpeakerNationality
            // 
            this.errorProviderEditSpeakerNationality.ContainerControl = this;
            // 
            // errorProviderEditSpeakerPicture
            // 
            this.errorProviderEditSpeakerPicture.ContainerControl = this;
            // 
            // butonCircular1
            // 
            this.butonCircular1.BackColor = System.Drawing.Color.Lime;
            this.butonCircular1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.butonCircular1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butonCircular1.Location = new System.Drawing.Point(632, 350);
            this.butonCircular1.Name = "butonCircular1";
            this.butonCircular1.Size = new System.Drawing.Size(94, 39);
            this.butonCircular1.TabIndex = 11;
            this.butonCircular1.Text = "SAVE";
            this.butonCircular1.UseVisualStyleBackColor = false;
            this.butonCircular1.Click += new System.EventHandler(this.butonCircular1_Click);
            // 
            // EditSpeakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(860, 463);
            this.Controls.Add(this.butonCircular1);
            this.Controls.Add(this.editSpeakerPictureTextBox);
            this.Controls.Add(this.editSpeakerNationalityTextBox);
            this.Controls.Add(this.editSpeakerRatingTextBox);
            this.Controls.Add(this.editSpeakerNameTextBox);
            this.Controls.Add(this.editSpeakerCodeTextBox);
            this.Controls.Add(this.editSpeakerPicture);
            this.Controls.Add(this.editSpeakerNationnality);
            this.Controls.Add(this.editSpeakerRating);
            this.Controls.Add(this.editSpeakerName);
            this.Controls.Add(this.editSpeakerCode);
            this.Controls.Add(this.editSpeakerPictureBox);
            this.Name = "EditSpeakerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditSpeakerForm";
            this.Load += new System.EventHandler(this.EditSpeakerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editSpeakerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditSpeakerCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditSpeakerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditSpeakerRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditSpeakerNationality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditSpeakerPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label editSpeakerCode;
        private System.Windows.Forms.Label editSpeakerName;
        private System.Windows.Forms.Label editSpeakerRating;
        private System.Windows.Forms.Label editSpeakerNationnality;
        private System.Windows.Forms.Label editSpeakerPicture;
        private System.Windows.Forms.TextBox editSpeakerCodeTextBox;
        private System.Windows.Forms.TextBox editSpeakerNameTextBox;
        private System.Windows.Forms.TextBox editSpeakerRatingTextBox;
        private System.Windows.Forms.TextBox editSpeakerNationalityTextBox;
        private System.Windows.Forms.TextBox editSpeakerPictureTextBox;
        private System.Windows.Forms.PictureBox editSpeakerPictureBox;
        private System.Windows.Forms.ErrorProvider errorProviderEditSpeakerCode;
        private System.Windows.Forms.ErrorProvider errorProviderEditSpeakerName;
        private System.Windows.Forms.ErrorProvider errorProviderEditSpeakerRating;
        private System.Windows.Forms.ErrorProvider errorProviderEditSpeakerNationality;
        private System.Windows.Forms.ErrorProvider errorProviderEditSpeakerPicture;
        private ButonCircular saveEditSpeaker;
        private ButonCircular butonCircular1;
    }
}