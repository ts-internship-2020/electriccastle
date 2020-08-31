namespace ConferencePlanner.WinUi
{
    partial class NewDistrictForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDistrictForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.DistrictNameLabel = new System.Windows.Forms.Label();
            this.DistrictCodLabel = new System.Windows.Forms.Label();
            this.DistrictNameTextBox = new System.Windows.Forms.TextBox();
            this.DistrictCodeTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new ConferencePlanner.WinUi.ButonCircular();
            this.errorProviderDistrictName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDistrictCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDistrictName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDistrictCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(106, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(103, 119);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // DistrictNameLabel
            // 
            this.DistrictNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DistrictNameLabel.AutoSize = true;
            this.DistrictNameLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DistrictNameLabel.Location = new System.Drawing.Point(25, 167);
            this.DistrictNameLabel.Name = "DistrictNameLabel";
            this.DistrictNameLabel.Size = new System.Drawing.Size(44, 17);
            this.DistrictNameLabel.TabIndex = 2;
            this.DistrictNameLabel.Text = "Name";
            // 
            // DistrictCodLabel
            // 
            this.DistrictCodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DistrictCodLabel.AutoSize = true;
            this.DistrictCodLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DistrictCodLabel.Location = new System.Drawing.Point(25, 209);
            this.DistrictCodLabel.Name = "DistrictCodLabel";
            this.DistrictCodLabel.Size = new System.Drawing.Size(39, 17);
            this.DistrictCodLabel.TabIndex = 3;
            this.DistrictCodLabel.Text = "Code";
            // 
            // DistrictNameTextBox
            // 
            this.DistrictNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DistrictNameTextBox.Location = new System.Drawing.Point(106, 161);
            this.DistrictNameTextBox.Name = "DistrictNameTextBox";
            this.DistrictNameTextBox.Size = new System.Drawing.Size(136, 23);
            this.DistrictNameTextBox.TabIndex = 4;
            this.DistrictNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DistrictNameTextBox_Validating);
            // 
            // DistrictCodeTextBox
            // 
            this.DistrictCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DistrictCodeTextBox.Location = new System.Drawing.Point(106, 203);
            this.DistrictCodeTextBox.Name = "DistrictCodeTextBox";
            this.DistrictCodeTextBox.Size = new System.Drawing.Size(136, 23);
            this.DistrictCodeTextBox.TabIndex = 5;
            this.DistrictCodeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DistrictCodeTextBox_Validating);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(106, 296);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(113, 40);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // errorProviderDistrictName
            // 
            this.errorProviderDistrictName.ContainerControl = this;
            // 
            // errorProviderDistrictCode
            // 
            this.errorProviderDistrictCode.ContainerControl = this;
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.Location = new System.Drawing.Point(106, 246);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(121, 23);
            this.CountryComboBox.TabIndex = 7;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CountryLabel.Location = new System.Drawing.Point(25, 252);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(57, 17);
            this.CountryLabel.TabIndex = 8;
            this.CountryLabel.Text = "Country";
            // 
            // NewDistrictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 348);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.CountryComboBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DistrictCodeTextBox);
            this.Controls.Add(this.DistrictNameTextBox);
            this.Controls.Add(this.DistrictCodLabel);
            this.Controls.Add(this.DistrictNameLabel);
            this.Controls.Add(this.pictureBox);
            this.Name = "NewDistrictForm";
            this.Text = "District";
            this.Activated += new System.EventHandler(this.NewDistrictForm_Activated);
            this.Load += new System.EventHandler(this.NewDistrictForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDistrictName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDistrictCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label DistrictNameLabel;
        private System.Windows.Forms.Label DistrictCodLabel;
        private System.Windows.Forms.TextBox DistrictNameTextBox;
        private System.Windows.Forms.TextBox DistrictCodeTextBox;
        private ButonCircular SaveButton;
        private System.Windows.Forms.ErrorProvider errorProviderDistrictName;
        private System.Windows.Forms.ErrorProvider errorProviderCod;
        private System.Windows.Forms.ErrorProvider errorProviderDistrictCode;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.ComboBox CountryComboBox;
    }
}