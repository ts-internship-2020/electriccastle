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
            this.SpeakerName = new System.Windows.Forms.Label();
            this.SpeakerNationality = new System.Windows.Forms.Label();
            this.SpeakerRating = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SpeakerNameText = new System.Windows.Forms.TextBox();
            this.SpeakerNationalityText = new System.Windows.Forms.TextBox();
            this.SpeakerRatingText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SpeakerName
            // 
            this.SpeakerName.AutoSize = true;
            this.SpeakerName.Location = new System.Drawing.Point(266, 99);
            this.SpeakerName.Name = "SpeakerName";
            this.SpeakerName.Size = new System.Drawing.Size(45, 15);
            this.SpeakerName.TabIndex = 0;
            this.SpeakerName.Text = "Name :";
            this.SpeakerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SpeakerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // SpeakerNationality
            // 
            this.SpeakerNationality.AutoSize = true;
            this.SpeakerNationality.Location = new System.Drawing.Point(266, 135);
            this.SpeakerNationality.Name = "SpeakerNationality";
            this.SpeakerNationality.Size = new System.Drawing.Size(71, 15);
            this.SpeakerNationality.TabIndex = 1;
            this.SpeakerNationality.Text = "Nationality :";
            this.SpeakerNationality.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SpeakerNationality.Click += new System.EventHandler(this.label2_Click);
            // 
            // SpeakerRating
            // 
            this.SpeakerRating.AutoSize = true;
            this.SpeakerRating.Location = new System.Drawing.Point(266, 170);
            this.SpeakerRating.Name = "SpeakerRating";
            this.SpeakerRating.Size = new System.Drawing.Size(47, 15);
            this.SpeakerRating.TabIndex = 2;
            this.SpeakerRating.Text = "Rating :";
            this.SpeakerRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 110);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SpeakerNameText
            // 
            this.SpeakerNameText.Location = new System.Drawing.Point(351, 96);
            this.SpeakerNameText.Name = "SpeakerNameText";
            this.SpeakerNameText.Size = new System.Drawing.Size(100, 23);
            this.SpeakerNameText.TabIndex = 4;
            this.SpeakerNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SpeakerNationalityText
            // 
            this.SpeakerNationalityText.Location = new System.Drawing.Point(351, 135);
            this.SpeakerNationalityText.Name = "SpeakerNationalityText";
            this.SpeakerNationalityText.Size = new System.Drawing.Size(100, 23);
            this.SpeakerNationalityText.TabIndex = 5;
            // 
            // SpeakerRatingText
            // 
            this.SpeakerRatingText.Location = new System.Drawing.Point(351, 170);
            this.SpeakerRatingText.Name = "SpeakerRatingText";
            this.SpeakerRatingText.Size = new System.Drawing.Size(100, 23);
            this.SpeakerRatingText.TabIndex = 6;
            // 
            // SpeakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 305);
            this.Controls.Add(this.SpeakerRatingText);
            this.Controls.Add(this.SpeakerNationalityText);
            this.Controls.Add(this.SpeakerNameText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SpeakerRating);
            this.Controls.Add(this.SpeakerNationality);
            this.Controls.Add(this.SpeakerName);
            this.Name = "SpeakerForm";
            this.Text = "SpeakerForm";
            this.Load += new System.EventHandler(this.SpeakerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SpeakerName;
        private System.Windows.Forms.Label SpeakerNationality;
        private System.Windows.Forms.Label SpeakerRating;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SpeakerNameText;
        private System.Windows.Forms.TextBox SpeakerNationalityText;
        private System.Windows.Forms.TextBox SpeakerRatingText;
    }
}