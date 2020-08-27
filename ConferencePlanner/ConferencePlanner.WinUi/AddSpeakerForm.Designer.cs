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
            this.newSpeakerCode = new System.Windows.Forms.Label();
            this.newSpeakerName = new System.Windows.Forms.Label();
            this.newSpeakerRating = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newSpeakerPicture = new System.Windows.Forms.Label();
            this.newSpeakerPictureBox = new System.Windows.Forms.PictureBox();
            this.newSpeakerCodeTextBox = new System.Windows.Forms.TextBox();
            this.newSpeakerNameTextBox = new System.Windows.Forms.TextBox();
            this.newSpeakerRatingTextBox = new System.Windows.Forms.TextBox();
            this.newSpeakerNationalityTextBox = new System.Windows.Forms.TextBox();
            this.newSpeakerPictureTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.newSpeakerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // newSpeakerCode
            // 
            this.newSpeakerCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSpeakerCode.AutoSize = true;
            this.newSpeakerCode.BackColor = System.Drawing.Color.Aqua;
            this.newSpeakerCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newSpeakerCode.Location = new System.Drawing.Point(417, 78);
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
            this.newSpeakerName.BackColor = System.Drawing.Color.Aqua;
            this.newSpeakerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newSpeakerName.Location = new System.Drawing.Point(417, 116);
            this.newSpeakerName.Name = "newSpeakerName";
            this.newSpeakerName.Size = new System.Drawing.Size(52, 17);
            this.newSpeakerName.TabIndex = 1;
            this.newSpeakerName.Text = "Name :";
            // 
            // newSpeakerRating
            // 
            this.newSpeakerRating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSpeakerRating.AutoSize = true;
            this.newSpeakerRating.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newSpeakerRating.Location = new System.Drawing.Point(417, 154);
            this.newSpeakerRating.Name = "newSpeakerRating";
            this.newSpeakerRating.Size = new System.Drawing.Size(56, 17);
            this.newSpeakerRating.TabIndex = 2;
            this.newSpeakerRating.Text = "Rating :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(417, 195);
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
            this.newSpeakerPicture.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newSpeakerPicture.Location = new System.Drawing.Point(417, 235);
            this.newSpeakerPicture.Name = "newSpeakerPicture";
            this.newSpeakerPicture.Size = new System.Drawing.Size(89, 17);
            this.newSpeakerPicture.TabIndex = 4;
            this.newSpeakerPicture.Text = "Picture Link :";
            // 
            // newSpeakerPictureBox
            // 
            this.newSpeakerPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newSpeakerPictureBox.Location = new System.Drawing.Point(60, 78);
            this.newSpeakerPictureBox.Name = "newSpeakerPictureBox";
            this.newSpeakerPictureBox.Size = new System.Drawing.Size(251, 174);
            this.newSpeakerPictureBox.TabIndex = 5;
            this.newSpeakerPictureBox.TabStop = false;
            // 
            // newSpeakerCodeTextBox
            // 
            this.newSpeakerCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSpeakerCodeTextBox.BackColor = System.Drawing.Color.Azure;
            this.newSpeakerCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newSpeakerCodeTextBox.Location = new System.Drawing.Point(522, 78);
            this.newSpeakerCodeTextBox.Name = "newSpeakerCodeTextBox";
            this.newSpeakerCodeTextBox.Size = new System.Drawing.Size(152, 25);
            this.newSpeakerCodeTextBox.TabIndex = 6;
            this.newSpeakerCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newSpeakerNameTextBox
            // 
            this.newSpeakerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSpeakerNameTextBox.BackColor = System.Drawing.Color.Azure;
            this.newSpeakerNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newSpeakerNameTextBox.Location = new System.Drawing.Point(522, 116);
            this.newSpeakerNameTextBox.Name = "newSpeakerNameTextBox";
            this.newSpeakerNameTextBox.Size = new System.Drawing.Size(152, 25);
            this.newSpeakerNameTextBox.TabIndex = 7;
            // 
            // newSpeakerRatingTextBox
            // 
            this.newSpeakerRatingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSpeakerRatingTextBox.BackColor = System.Drawing.Color.Azure;
            this.newSpeakerRatingTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newSpeakerRatingTextBox.Location = new System.Drawing.Point(522, 154);
            this.newSpeakerRatingTextBox.Name = "newSpeakerRatingTextBox";
            this.newSpeakerRatingTextBox.Size = new System.Drawing.Size(152, 25);
            this.newSpeakerRatingTextBox.TabIndex = 8;
            // 
            // newSpeakerNationalityTextBox
            // 
            this.newSpeakerNationalityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSpeakerNationalityTextBox.BackColor = System.Drawing.Color.Azure;
            this.newSpeakerNationalityTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newSpeakerNationalityTextBox.Location = new System.Drawing.Point(522, 195);
            this.newSpeakerNationalityTextBox.Name = "newSpeakerNationalityTextBox";
            this.newSpeakerNationalityTextBox.Size = new System.Drawing.Size(152, 25);
            this.newSpeakerNationalityTextBox.TabIndex = 9;
            // 
            // newSpeakerPictureTextBox
            // 
            this.newSpeakerPictureTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSpeakerPictureTextBox.BackColor = System.Drawing.Color.Azure;
            this.newSpeakerPictureTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newSpeakerPictureTextBox.Location = new System.Drawing.Point(522, 235);
            this.newSpeakerPictureTextBox.Name = "newSpeakerPictureTextBox";
            this.newSpeakerPictureTextBox.Size = new System.Drawing.Size(152, 25);
            this.newSpeakerPictureTextBox.TabIndex = 10;
            // 
            // NewSpeaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newSpeakerPictureTextBox);
            this.Controls.Add(this.newSpeakerNationalityTextBox);
            this.Controls.Add(this.newSpeakerRatingTextBox);
            this.Controls.Add(this.newSpeakerNameTextBox);
            this.Controls.Add(this.newSpeakerCodeTextBox);
            this.Controls.Add(this.newSpeakerPictureBox);
            this.Controls.Add(this.newSpeakerPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newSpeakerRating);
            this.Controls.Add(this.newSpeakerName);
            this.Controls.Add(this.newSpeakerCode);
            this.Name = "NewSpeaker";
            this.Text = "NewSpeaker";
            this.Load += new System.EventHandler(this.NewSpeaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newSpeakerPictureBox)).EndInit();
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
    }
}