namespace ConferencePlanner.WinUi
{
    partial class AddEditConferenceCategoryScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditConferenceCategoryScreen));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.CategoryCodeLabel = new System.Windows.Forms.Label();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryCodeTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new ConferencePlanner.WinUi.ButonCircular();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(105, 34);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(248, 121);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.AutoSize = true;
            this.CategoryNameLabel.Location = new System.Drawing.Point(206, 184);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(39, 15);
            this.CategoryNameLabel.TabIndex = 1;
            this.CategoryNameLabel.Text = "Name";
            // 
            // CategoryCodeLabel
            // 
            this.CategoryCodeLabel.AutoSize = true;
            this.CategoryCodeLabel.Location = new System.Drawing.Point(206, 240);
            this.CategoryCodeLabel.Name = "CategoryCodeLabel";
            this.CategoryCodeLabel.Size = new System.Drawing.Size(35, 15);
            this.CategoryCodeLabel.TabIndex = 2;
            this.CategoryCodeLabel.Text = "Code";
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(172, 202);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.CategoryNameTextBox.TabIndex = 3;
            // 
            // CategoryCodeTextBox
            // 
            this.CategoryCodeTextBox.Location = new System.Drawing.Point(172, 258);
            this.CategoryCodeTextBox.Name = "CategoryCodeTextBox";
            this.CategoryCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.CategoryCodeTextBox.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(185, 308);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 49);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // AddEditConferenceCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 414);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CategoryCodeTextBox);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.CategoryCodeLabel);
            this.Controls.Add(this.CategoryNameLabel);
            this.Controls.Add(this.pictureBox);
            this.Name = "AddEditConferenceCategory";
            this.Text = "Add/Modify Category";
            this.Load += new System.EventHandler(this.AddEditConferenceCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label CategoryNameLabel;
        private System.Windows.Forms.Label CategoryCodeLabel;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox CategoryCodeTextBox;
        private ButonCircular SaveButton;
    }
}