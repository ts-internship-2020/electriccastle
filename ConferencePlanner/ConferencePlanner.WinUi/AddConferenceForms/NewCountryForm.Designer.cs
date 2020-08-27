namespace ConferencePlanner.WinUi
{
    partial class NewCountryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCountryForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CountryNameTv = new System.Windows.Forms.Label();
            this.CountryCodTv = new System.Windows.Forms.Label();
            this.InsertCountry = new System.Windows.Forms.Label();
            this.CoutryNameTb = new System.Windows.Forms.TextBox();
            this.CountryCodTb = new System.Windows.Forms.TextBox();
            this.AddCountryFromButton = new ConferencePlanner.WinUi.ButonCircular();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 67);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CountryNameTv
            // 
            this.CountryNameTv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryNameTv.AutoSize = true;
            this.CountryNameTv.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CountryNameTv.Location = new System.Drawing.Point(36, 142);
            this.CountryNameTv.Name = "CountryNameTv";
            this.CountryNameTv.Size = new System.Drawing.Size(44, 17);
            this.CountryNameTv.TabIndex = 1;
            this.CountryNameTv.Text = "Name";
            // 
            // CountryCodTv
            // 
            this.CountryCodTv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryCodTv.AutoSize = true;
            this.CountryCodTv.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CountryCodTv.Location = new System.Drawing.Point(36, 183);
            this.CountryCodTv.Name = "CountryCodTv";
            this.CountryCodTv.Size = new System.Drawing.Size(32, 17);
            this.CountryCodTv.TabIndex = 2;
            this.CountryCodTv.Text = "Cod";
            // 
            // InsertCountry
            // 
            this.InsertCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertCountry.AutoSize = true;
            this.InsertCountry.Location = new System.Drawing.Point(101, 94);
            this.InsertCountry.Name = "InsertCountry";
            this.InsertCountry.Padding = new System.Windows.Forms.Padding(3);
            this.InsertCountry.Size = new System.Drawing.Size(120, 21);
            this.InsertCountry.TabIndex = 3;
            this.InsertCountry.Text = "Insert a new country";
            this.InsertCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoutryNameTb
            // 
            this.CoutryNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoutryNameTb.Location = new System.Drawing.Point(126, 142);
            this.CoutryNameTb.Name = "CoutryNameTb";
            this.CoutryNameTb.Size = new System.Drawing.Size(165, 23);
            this.CoutryNameTb.TabIndex = 4;
            // 
            // CountryCodTb
            // 
            this.CountryCodTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryCodTb.Location = new System.Drawing.Point(126, 183);
            this.CountryCodTb.Name = "CountryCodTb";
            this.CountryCodTb.Size = new System.Drawing.Size(165, 23);
            this.CountryCodTb.TabIndex = 5;
            // 
            // AddCountryFromButton
            // 
            this.AddCountryFromButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCountryFromButton.Location = new System.Drawing.Point(111, 249);
            this.AddCountryFromButton.Name = "AddCountryFromButton";
            this.AddCountryFromButton.Size = new System.Drawing.Size(100, 44);
            this.AddCountryFromButton.TabIndex = 6;
            this.AddCountryFromButton.Text = "Add country";
            this.AddCountryFromButton.UseVisualStyleBackColor = true;
            // 
            // NewCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 305);
            this.Controls.Add(this.AddCountryFromButton);
            this.Controls.Add(this.CountryCodTb);
            this.Controls.Add(this.CoutryNameTb);
            this.Controls.Add(this.InsertCountry);
            this.Controls.Add(this.CountryCodTv);
            this.Controls.Add(this.CountryNameTv);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NewCountryForm";
            this.Text = "NewCountryForm";
            this.Load += new System.EventHandler(this.NewCountryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CountryNameTv;
        private System.Windows.Forms.Label CountryCodTv;
        private System.Windows.Forms.Label InsertCountry;
        private System.Windows.Forms.TextBox CoutryNameTb;
        private System.Windows.Forms.TextBox CountryCodTb;
        private ButonCircular AddCountryFromButton;
    }
}