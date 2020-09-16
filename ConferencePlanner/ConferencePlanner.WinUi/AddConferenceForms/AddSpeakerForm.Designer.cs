namespace ConferencePlanner.WinUi
{
    partial class AddSpeakerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSpeakerForm));
            this.newSpeakerCode = new System.Windows.Forms.Label();
            this.newSpeakerName = new System.Windows.Forms.Label();
            this.newSpeakerRating = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newSpeakerPicture = new System.Windows.Forms.Label();
            this.newSpeakerCodeTextBox = new System.Windows.Forms.TextBox();
            this.newSpeakerNameTextBox = new System.Windows.Forms.TextBox();
            this.newSpeakerRatingTextBox = new System.Windows.Forms.TextBox();
            this.newSpeakerNationalityTextBox = new System.Windows.Forms.TextBox();
            this.newSpeakerPictureTextBox = new System.Windows.Forms.TextBox();
            this.errorProviderAddSpeakerCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAddSpeakerName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAddSpeakerRating = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAddSpeakerNationality = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAddSpeakerPicture = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveAddSpeaker = new ConferencePlanner.WinUi.ButonCircular();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddSpeakerCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddSpeakerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddSpeakerRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddSpeakerNationality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddSpeakerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // newSpeakerCode
            // 
            this.newSpeakerCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSpeakerCode.AutoSize = true;
            this.newSpeakerCode.BackColor = System.Drawing.Color.Transparent;
            this.newSpeakerCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newSpeakerCode.ForeColor = System.Drawing.SystemColors.Info;
            this.newSpeakerCode.Location = new System.Drawing.Point(458, 97);
            this.newSpeakerCode.Name = "newSpeakerCode";
            this.newSpeakerCode.Size = new System.Drawing.Size(47, 17);
            this.newSpeakerCode.TabIndex = 0;
            this.newSpeakerCode.Text = "Code :";
            this.newSpeakerCode.Click += new System.EventHandler(this.newSpeakerName_Click);
            // 
            // newSpeakerName
            // 
            this.newSpeakerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSpeakerName.AutoSize = true;
            this.newSpeakerName.BackColor = System.Drawing.Color.Transparent;
            this.newSpeakerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newSpeakerName.ForeColor = System.Drawing.SystemColors.Info;
            this.newSpeakerName.Location = new System.Drawing.Point(458, 144);
            this.newSpeakerName.Name = "newSpeakerName";
            this.newSpeakerName.Size = new System.Drawing.Size(52, 17);
            this.newSpeakerName.TabIndex = 1;
            this.newSpeakerName.Text = "Name :";
            // 
            // newSpeakerRating
            // 
            this.newSpeakerRating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSpeakerRating.AutoSize = true;
            this.newSpeakerRating.BackColor = System.Drawing.Color.Transparent;
            this.newSpeakerRating.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newSpeakerRating.ForeColor = System.Drawing.SystemColors.Info;
            this.newSpeakerRating.Location = new System.Drawing.Point(458, 195);
            this.newSpeakerRating.Name = "newSpeakerRating";
            this.newSpeakerRating.Size = new System.Drawing.Size(56, 17);
            this.newSpeakerRating.TabIndex = 2;
            this.newSpeakerRating.Text = "Rating :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(458, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nationality :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // newSpeakerPicture
            // 
            this.newSpeakerPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSpeakerPicture.AutoSize = true;
            this.newSpeakerPicture.BackColor = System.Drawing.Color.Transparent;
            this.newSpeakerPicture.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newSpeakerPicture.ForeColor = System.Drawing.Color.Transparent;
            this.newSpeakerPicture.Location = new System.Drawing.Point(458, 291);
            this.newSpeakerPicture.Name = "newSpeakerPicture";
            this.newSpeakerPicture.Size = new System.Drawing.Size(89, 17);
            this.newSpeakerPicture.TabIndex = 4;
            this.newSpeakerPicture.Text = "Picture Link :";
            // 
            // newSpeakerCodeTextBox
            // 
            this.newSpeakerCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSpeakerCodeTextBox.BackColor = System.Drawing.Color.Azure;
            this.newSpeakerCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newSpeakerCodeTextBox.Location = new System.Drawing.Point(602, 89);
            this.newSpeakerCodeTextBox.Name = "newSpeakerCodeTextBox";
            this.newSpeakerCodeTextBox.Size = new System.Drawing.Size(152, 25);
            this.newSpeakerCodeTextBox.TabIndex = 6;
            this.newSpeakerCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newSpeakerCodeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.newSpeakerCodeTextBox_Validating);
            // 
            // newSpeakerNameTextBox
            // 
            this.newSpeakerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSpeakerNameTextBox.BackColor = System.Drawing.Color.Azure;
            this.newSpeakerNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newSpeakerNameTextBox.Location = new System.Drawing.Point(602, 136);
            this.newSpeakerNameTextBox.Name = "newSpeakerNameTextBox";
            this.newSpeakerNameTextBox.Size = new System.Drawing.Size(152, 25);
            this.newSpeakerNameTextBox.TabIndex = 7;
            this.newSpeakerNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newSpeakerNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.newSpeakerNameTextBox_Validating);
            // 
            // newSpeakerRatingTextBox
            // 
            this.newSpeakerRatingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSpeakerRatingTextBox.BackColor = System.Drawing.Color.Azure;
            this.newSpeakerRatingTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newSpeakerRatingTextBox.Location = new System.Drawing.Point(602, 187);
            this.newSpeakerRatingTextBox.Name = "newSpeakerRatingTextBox";
            this.newSpeakerRatingTextBox.Size = new System.Drawing.Size(152, 25);
            this.newSpeakerRatingTextBox.TabIndex = 8;
            this.newSpeakerRatingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newSpeakerRatingTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.newSpeakerRatingTextBox_Validating);
            // 
            // newSpeakerNationalityTextBox
            // 
            this.newSpeakerNationalityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSpeakerNationalityTextBox.BackColor = System.Drawing.Color.Azure;
            this.newSpeakerNationalityTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newSpeakerNationalityTextBox.Location = new System.Drawing.Point(602, 237);
            this.newSpeakerNationalityTextBox.Name = "newSpeakerNationalityTextBox";
            this.newSpeakerNationalityTextBox.Size = new System.Drawing.Size(152, 25);
            this.newSpeakerNationalityTextBox.TabIndex = 9;
            this.newSpeakerNationalityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newSpeakerNationalityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.newSpeakerNationalityTextBox_Validating);
            // 
            // newSpeakerPictureTextBox
            // 
            this.newSpeakerPictureTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSpeakerPictureTextBox.BackColor = System.Drawing.Color.Azure;
            this.newSpeakerPictureTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newSpeakerPictureTextBox.Location = new System.Drawing.Point(602, 288);
            this.newSpeakerPictureTextBox.Name = "newSpeakerPictureTextBox";
            this.newSpeakerPictureTextBox.Size = new System.Drawing.Size(152, 25);
            this.newSpeakerPictureTextBox.TabIndex = 10;
            this.newSpeakerPictureTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newSpeakerPictureTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.newSpeakerPictureTextBox_Validating);
            // 
            // errorProviderAddSpeakerCode
            // 
            this.errorProviderAddSpeakerCode.ContainerControl = this;
            // 
            // errorProviderAddSpeakerName
            // 
            this.errorProviderAddSpeakerName.ContainerControl = this;
            // 
            // errorProviderAddSpeakerRating
            // 
            this.errorProviderAddSpeakerRating.ContainerControl = this;
            // 
            // errorProviderAddSpeakerNationality
            // 
            this.errorProviderAddSpeakerNationality.ContainerControl = this;
            // 
            // errorProviderAddSpeakerPicture
            // 
            this.errorProviderAddSpeakerPicture.ContainerControl = this;
            // 
            // saveAddSpeaker
            // 
            this.saveAddSpeaker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAddSpeaker.BackColor = System.Drawing.SystemColors.Window;
            this.saveAddSpeaker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveAddSpeaker.Location = new System.Drawing.Point(555, 337);
            this.saveAddSpeaker.Name = "saveAddSpeaker";
            this.saveAddSpeaker.Size = new System.Drawing.Size(91, 45);
            this.saveAddSpeaker.TabIndex = 11;
            this.saveAddSpeaker.Text = "SAVE";
            this.saveAddSpeaker.UseVisualStyleBackColor = false;
            this.saveAddSpeaker.Click += new System.EventHandler(this.saveAddSpeaker_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(555, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Insert new speaker";
            // 
            // AddSpeakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveAddSpeaker);
            this.Controls.Add(this.newSpeakerPictureTextBox);
            this.Controls.Add(this.newSpeakerNationalityTextBox);
            this.Controls.Add(this.newSpeakerRatingTextBox);
            this.Controls.Add(this.newSpeakerNameTextBox);
            this.Controls.Add(this.newSpeakerCodeTextBox);
            this.Controls.Add(this.newSpeakerPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newSpeakerRating);
            this.Controls.Add(this.newSpeakerName);
            this.Controls.Add(this.newSpeakerCode);
            this.Name = "AddSpeakerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Add new speaker";
            this.Load += new System.EventHandler(this.NewSpeaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddSpeakerCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddSpeakerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddSpeakerRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddSpeakerNationality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddSpeakerPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newSpeakerCode;
        private System.Windows.Forms.Label newSpeakerName;
        private System.Windows.Forms.Label newSpeakerRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label newSpeakerPicture;
        private System.Windows.Forms.PictureBox newSpeakerPictureBox;
        private System.Windows.Forms.TextBox newSpeakerCodeTextBox;
        private System.Windows.Forms.TextBox newSpeakerNameTextBox;
        private System.Windows.Forms.TextBox newSpeakerRatingTextBox;
        private System.Windows.Forms.TextBox newSpeakerNationalityTextBox;
        private System.Windows.Forms.TextBox newSpeakerPictureTextBox;
        private System.Windows.Forms.ErrorProvider errorProviderAddSpeakerCode;
        private System.Windows.Forms.ErrorProvider errorProviderAddSpeakerName;
        private System.Windows.Forms.ErrorProvider errorProviderAddSpeakerRating;
        private System.Windows.Forms.ErrorProvider errorProviderAddSpeakerNationality;
        private System.Windows.Forms.ErrorProvider errorProviderAddSpeakerPicture;
        private ButonCircular saveAddSpeaker;
        private System.Windows.Forms.Label label2;
    }
}