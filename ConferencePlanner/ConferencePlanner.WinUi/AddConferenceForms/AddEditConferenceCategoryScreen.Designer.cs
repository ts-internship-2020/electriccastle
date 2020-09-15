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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditConferenceCategoryScreen));
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.CategoryCodeLabel = new System.Windows.Forms.Label();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryCodeTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new ConferencePlanner.WinUi.ButonCircular();
            this.CategoryNameTextBoxErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CategoryCodeTextBoxErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNameTextBoxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryCodeTextBoxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.AutoSize = true;
            this.CategoryNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.CategoryNameLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CategoryNameLabel.Location = new System.Drawing.Point(85, 203);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(44, 17);
            this.CategoryNameLabel.TabIndex = 1;
            this.CategoryNameLabel.Text = "Name";
            // 
            // CategoryCodeLabel
            // 
            this.CategoryCodeLabel.AutoSize = true;
            this.CategoryCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CategoryCodeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CategoryCodeLabel.Location = new System.Drawing.Point(85, 258);
            this.CategoryCodeLabel.Name = "CategoryCodeLabel";
            this.CategoryCodeLabel.Size = new System.Drawing.Size(39, 17);
            this.CategoryCodeLabel.TabIndex = 2;
            this.CategoryCodeLabel.Text = "Code";
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(202, 197);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.CategoryNameTextBox.TabIndex = 3;
            this.CategoryNameTextBox.TextChanged += new System.EventHandler(this.CategoryNameTextBox_TextChanged);
            this.CategoryNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CategoryNameTextBox_Validating);
            // 
            // CategoryCodeTextBox
            // 
            this.CategoryCodeTextBox.Location = new System.Drawing.Point(202, 258);
            this.CategoryCodeTextBox.Name = "CategoryCodeTextBox";
            this.CategoryCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.CategoryCodeTextBox.TabIndex = 4;
            this.CategoryCodeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CategoryCodeTextBox_Validating);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Tomato;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Location = new System.Drawing.Point(144, 324);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(115, 49);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save category";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CategoryNameTextBoxErrorProvider
            // 
            this.CategoryNameTextBoxErrorProvider.ContainerControl = this;
            // 
            // CategoryCodeTextBoxErrorProvider
            // 
            this.CategoryCodeTextBoxErrorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(137, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Insert new category";
            // 
            // AddEditConferenceCategoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CategoryCodeTextBox);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.CategoryCodeLabel);
            this.Controls.Add(this.CategoryNameLabel);
            this.Name = "AddEditConferenceCategoryScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Category";
            this.Activated += new System.EventHandler(this.AddEditConferenceCategoryScreen_Activated);
            this.Load += new System.EventHandler(this.AddEditConferenceCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNameTextBoxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryCodeTextBoxErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CategoryNameLabel;
        private System.Windows.Forms.Label CategoryCodeLabel;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.TextBox CategoryCodeTextBox;
        private ButonCircular SaveButton;
        private System.Windows.Forms.ErrorProvider CategoryNameTextBoxErrorProvider;
        private System.Windows.Forms.ErrorProvider CategoryCodeTextBoxErrorProvider;
        private System.Windows.Forms.Label label1;
    }
}