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
            this.pictureSpeaker = new System.Windows.Forms.PictureBox();
            this.speakerNameText = new System.Windows.Forms.Label();
            this.speakerRatingText = new System.Windows.Forms.Label();
            this.speakerNationalityText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeaker)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureSpeaker
            // 
            this.pictureSpeaker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureSpeaker.Location = new System.Drawing.Point(161, 24);
            this.pictureSpeaker.Name = "pictureSpeaker";
            this.pictureSpeaker.Size = new System.Drawing.Size(285, 196);
            this.pictureSpeaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSpeaker.TabIndex = 3;
            this.pictureSpeaker.TabStop = false;
            this.pictureSpeaker.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // speakerNameText
            // 
            this.speakerNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.speakerNameText.AutoSize = true;
            this.speakerNameText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speakerNameText.Location = new System.Drawing.Point(73, 244);
            this.speakerNameText.Name = "speakerNameText";
            this.speakerNameText.Size = new System.Drawing.Size(38, 15);
            this.speakerNameText.TabIndex = 4;
            this.speakerNameText.Text = "label1";
            // 
            // speakerRatingText
            // 
            this.speakerRatingText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.speakerRatingText.AutoSize = true;
            this.speakerRatingText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speakerRatingText.Location = new System.Drawing.Point(287, 244);
            this.speakerRatingText.Name = "speakerRatingText";
            this.speakerRatingText.Size = new System.Drawing.Size(38, 15);
            this.speakerRatingText.TabIndex = 5;
            this.speakerRatingText.Text = "label2";
            // 
            // speakerNationalityText
            // 
            this.speakerNationalityText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.speakerNationalityText.AutoSize = true;
            this.speakerNationalityText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speakerNationalityText.Location = new System.Drawing.Point(480, 244);
            this.speakerNationalityText.Name = "speakerNationalityText";
            this.speakerNationalityText.Size = new System.Drawing.Size(38, 15);
            this.speakerNationalityText.TabIndex = 6;
            this.speakerNationalityText.Text = "label3";
            // 
            // SpeakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 305);
            this.Controls.Add(this.speakerNationalityText);
            this.Controls.Add(this.speakerRatingText);
            this.Controls.Add(this.speakerNameText);
            this.Controls.Add(this.pictureSpeaker);
            this.Name = "SpeakerForm";
            this.ShowIcon = false;
            this.Text = "   Speaker details";
            this.Load += new System.EventHandler(this.SpeakerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeaker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureSpeaker;
        private System.Windows.Forms.Label speakerNameText;
        private System.Windows.Forms.Label speakerRatingText;
        private System.Windows.Forms.Label speakerNationalityText;
    }
}