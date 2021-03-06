﻿namespace ConferencePlanner.WinUi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCountryForm));
            this.CountryNameTv = new System.Windows.Forms.Label();
            this.CountryCodTv = new System.Windows.Forms.Label();
            this.InsertCountry = new System.Windows.Forms.Label();
            this.CoutryNameTb = new System.Windows.Forms.TextBox();
            this.CountryCodTb = new System.Windows.Forms.TextBox();
            this.AddCountryFromButton = new ConferencePlanner.WinUi.ButonCircular();
            this.errorProviderCountryName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCountryCod = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCountryName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCountryCod)).BeginInit();
            this.SuspendLayout();
            // 
            // CountryNameTv
            // 
            this.CountryNameTv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryNameTv.AutoSize = true;
            this.CountryNameTv.BackColor = System.Drawing.Color.Transparent;
            this.CountryNameTv.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CountryNameTv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CountryNameTv.Location = new System.Drawing.Point(36, 108);
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
            this.CountryCodTv.BackColor = System.Drawing.Color.Transparent;
            this.CountryCodTv.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CountryCodTv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CountryCodTv.Location = new System.Drawing.Point(36, 160);
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
            this.InsertCountry.BackColor = System.Drawing.Color.Transparent;
            this.InsertCountry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsertCountry.Location = new System.Drawing.Point(111, 57);
            this.InsertCountry.Name = "InsertCountry";
            this.InsertCountry.Padding = new System.Windows.Forms.Padding(3);
            this.InsertCountry.Size = new System.Drawing.Size(111, 21);
            this.InsertCountry.TabIndex = 3;
            this.InsertCountry.Text = "Insert new country";
            this.InsertCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoutryNameTb
            // 
            this.CoutryNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoutryNameTb.Location = new System.Drawing.Point(126, 102);
            this.CoutryNameTb.Name = "CoutryNameTb";
            this.CoutryNameTb.Size = new System.Drawing.Size(165, 23);
            this.CoutryNameTb.TabIndex = 4;
            // 
            // CountryCodTb
            // 
            this.CountryCodTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryCodTb.Location = new System.Drawing.Point(126, 159);
            this.CountryCodTb.Name = "CountryCodTb";
            this.CountryCodTb.Size = new System.Drawing.Size(165, 23);
            this.CountryCodTb.TabIndex = 5;
            // 
            // AddCountryFromButton
            // 
            this.AddCountryFromButton.BackColor = System.Drawing.Color.Tomato;
            this.AddCountryFromButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddCountryFromButton.Location = new System.Drawing.Point(111, 235);
            this.AddCountryFromButton.Name = "AddCountryFromButton";
            this.AddCountryFromButton.Size = new System.Drawing.Size(110, 44);
            this.AddCountryFromButton.TabIndex = 6;
            this.AddCountryFromButton.Text = "Save country";
            this.AddCountryFromButton.UseVisualStyleBackColor = false;
            this.AddCountryFromButton.Click += new System.EventHandler(this.AddCountryFromButton_Click);
            // 
            // errorProviderCountryName
            // 
            this.errorProviderCountryName.ContainerControl = this;
            // 
            // errorProviderCountryCod
            // 
            this.errorProviderCountryCod.ContainerControl = this;
            // 
            // NewCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(325, 305);
            this.Controls.Add(this.AddCountryFromButton);
            this.Controls.Add(this.CountryCodTb);
            this.Controls.Add(this.CoutryNameTb);
            this.Controls.Add(this.InsertCountry);
            this.Controls.Add(this.CountryCodTv);
            this.Controls.Add(this.CountryNameTv);
            this.Name = "NewCountryForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Country";
            this.Load += new System.EventHandler(this.NewCountryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCountryName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCountryCod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CountryNameTv;
        private System.Windows.Forms.Label CountryCodTv;
        private System.Windows.Forms.Label InsertCountry;
        private System.Windows.Forms.TextBox CoutryNameTb;
        private System.Windows.Forms.TextBox CountryCodTb;
        private ButonCircular AddCountryFromButton;
        private System.Windows.Forms.ErrorProvider errorProviderCountryName;
        private System.Windows.Forms.ErrorProvider errorProviderCountryCod;
    }
}