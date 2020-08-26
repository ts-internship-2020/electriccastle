namespace ConferencePlanner.WinUi
{
    partial class SpeakerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeakerForm));
            this.speakerNameLabel = new System.Windows.Forms.Label();
            this.speakerRatingLabel = new System.Windows.Forms.Label();
            this.speakerNationalityLabel = new System.Windows.Forms.Label();
            this.pictureSpeaker = new System.Windows.Forms.PictureBox();
            this.speakerNameText = new System.Windows.Forms.TextBox();
            this.speakerRatingText = new System.Windows.Forms.TextBox();
            this.speakerNationalityText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeaker)).BeginInit();
            this.SuspendLayout();
            // 
            // speakerNameLabel
            // 
            this.speakerNameLabel.AutoSize = true;
            this.speakerNameLabel.Location = new System.Drawing.Point(266, 99);
            this.speakerNameLabel.Name = "speakerNameLabel";
            this.speakerNameLabel.Size = new System.Drawing.Size(45, 15);
            this.speakerNameLabel.TabIndex = 0;
            this.speakerNameLabel.Text = "Name :";
            this.speakerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.speakerNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // speakerRatingLabel
            // 
            this.speakerRatingLabel.AutoSize = true;
            this.speakerRatingLabel.Location = new System.Drawing.Point(266, 135);
            this.speakerRatingLabel.Name = "speakerRatingLabel";
            this.speakerRatingLabel.Size = new System.Drawing.Size(47, 15);
            this.speakerRatingLabel.TabIndex = 1;
            this.speakerRatingLabel.Text = "Rating :";
            this.speakerRatingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.speakerRatingLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // speakerNationalityLabel
            // 
            this.speakerNationalityLabel.AutoSize = true;
            this.speakerNationalityLabel.Location = new System.Drawing.Point(266, 170);
            this.speakerNationalityLabel.Name = "speakerNationalityLabel";
            this.speakerNationalityLabel.Size = new System.Drawing.Size(71, 15);
            this.speakerNationalityLabel.TabIndex = 2;
            this.speakerNationalityLabel.Text = "Nationality :";
            this.speakerNationalityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.speakerNationalityLabel.Click += new System.EventHandler(this.SpeakerRating_Click);
            // 
            // pictureSpeaker
            // 
            this.pictureSpeaker.Location = new System.Drawing.Point(23, 67);
            this.pictureSpeaker.Name = "pictureSpeaker";
            this.pictureSpeaker.Size = new System.Drawing.Size(181, 127);
            this.pictureSpeaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSpeaker.TabIndex = 3;
            this.pictureSpeaker.TabStop = false;
            this.pictureSpeaker.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // speakerNameText
            // 
            this.speakerNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.speakerNameText.Location = new System.Drawing.Point(351, 96);
            this.speakerNameText.Name = "speakerNameText";
            this.speakerNameText.Size = new System.Drawing.Size(100, 23);
            this.speakerNameText.TabIndex = 4;
            this.speakerNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // speakerRatingText
            // 
            this.speakerRatingText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.speakerRatingText.Location = new System.Drawing.Point(351, 135);
            this.speakerRatingText.Name = "speakerRatingText";
            this.speakerRatingText.Size = new System.Drawing.Size(100, 23);
            this.speakerRatingText.TabIndex = 5;
            // 
            // speakerNationalityText
            // 
            this.speakerNationalityText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.speakerNationalityText.Location = new System.Drawing.Point(351, 170);
            this.speakerNationalityText.Name = "speakerNationalityText";
            this.speakerNationalityText.Size = new System.Drawing.Size(100, 23);
            this.speakerNationalityText.TabIndex = 6;
            // 
            // SpeakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(593, 305);
            this.Controls.Add(this.speakerNationalityText);
            this.Controls.Add(this.speakerRatingText);
            this.Controls.Add(this.speakerNameText);
            this.Controls.Add(this.pictureSpeaker);
            this.Controls.Add(this.speakerNationalityLabel);
            this.Controls.Add(this.speakerRatingLabel);
            this.Controls.Add(this.speakerNameLabel);
            this.Name = "SpeakerForm";
            this.Text = "SpeakerForm";
            this.Load += new System.EventHandler(this.SpeakerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeaker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label speakerNameLabel;
        private System.Windows.Forms.Label speakerRatingLabel;
        private System.Windows.Forms.Label speakerNationalityLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox speakerNameText;
        private System.Windows.Forms.TextBox speakerRatingText;
        private System.Windows.Forms.TextBox speakerNationalityText;
        private System.Windows.Forms.PictureBox pictureSpeaker;
    }
}