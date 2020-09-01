namespace ConferencePlanner.WinUi
{
    partial class NewCityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCityForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CityNameTv = new System.Windows.Forms.Label();
            this.CityCodeTv = new System.Windows.Forms.Label();
            this.CityNameTb = new System.Windows.Forms.TextBox();
            this.CityCodTb = new System.Windows.Forms.TextBox();
            this.butonCircular1 = new ConferencePlanner.WinUi.ButonCircular();
            this.errorProviderCityName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCityCod = new System.Windows.Forms.ErrorProvider(this.components);
            this.CityDistrictNameTv = new System.Windows.Forms.Label();
            this.DistrictNameTb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCityName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCityCod)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(103, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 129);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert a new city";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CityNameTv
            // 
            this.CityNameTv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityNameTv.AutoSize = true;
            this.CityNameTv.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CityNameTv.Location = new System.Drawing.Point(32, 172);
            this.CityNameTv.Name = "CityNameTv";
            this.CityNameTv.Size = new System.Drawing.Size(44, 17);
            this.CityNameTv.TabIndex = 2;
            this.CityNameTv.Text = "Name";
            // 
            // CityCodeTv
            // 
            this.CityCodeTv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityCodeTv.AutoSize = true;
            this.CityCodeTv.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CityCodeTv.Location = new System.Drawing.Point(32, 225);
            this.CityCodeTv.Name = "CityCodeTv";
            this.CityCodeTv.Size = new System.Drawing.Size(32, 17);
            this.CityCodeTv.TabIndex = 3;
            this.CityCodeTv.Text = "Cod";
            // 
            // CityNameTb
            // 
            this.CityNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityNameTb.Location = new System.Drawing.Point(123, 172);
            this.CityNameTb.Name = "CityNameTb";
            this.CityNameTb.Size = new System.Drawing.Size(150, 23);
            this.CityNameTb.TabIndex = 4;
            // 
            // CityCodTb
            // 
            this.CityCodTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityCodTb.Location = new System.Drawing.Point(123, 225);
            this.CityCodTb.Name = "CityCodTb";
            this.CityCodTb.Size = new System.Drawing.Size(150, 23);
            this.CityCodTb.TabIndex = 5;
            // 
            // butonCircular1
            // 
            this.butonCircular1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butonCircular1.BackColor = System.Drawing.Color.Tomato;
            this.butonCircular1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.butonCircular1.Location = new System.Drawing.Point(103, 325);
            this.butonCircular1.Name = "butonCircular1";
            this.butonCircular1.Size = new System.Drawing.Size(100, 51);
            this.butonCircular1.TabIndex = 6;
            this.butonCircular1.Text = "Upload city";
            this.butonCircular1.UseVisualStyleBackColor = false;
            this.butonCircular1.Click += new System.EventHandler(this.butonCircular1_Click);
            // 
            // errorProviderCityName
            // 
            this.errorProviderCityName.ContainerControl = this;
            // 
            // errorProviderCityCod
            // 
            this.errorProviderCityCod.ContainerControl = this;
            // 
            // CityDistrictNameTv
            // 
            this.CityDistrictNameTv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityDistrictNameTv.AutoSize = true;
            this.CityDistrictNameTv.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CityDistrictNameTv.Location = new System.Drawing.Point(32, 280);
            this.CityDistrictNameTv.Name = "CityDistrictNameTv";
            this.CityDistrictNameTv.Size = new System.Drawing.Size(50, 17);
            this.CityDistrictNameTv.TabIndex = 7;
            this.CityDistrictNameTv.Text = "District";
            // 
            // DistrictNameTb
            // 
            this.DistrictNameTb.FormattingEnabled = true;
            this.DistrictNameTb.Location = new System.Drawing.Point(123, 280);
            this.DistrictNameTb.Name = "DistrictNameTb";
            this.DistrictNameTb.Size = new System.Drawing.Size(150, 23);
            this.DistrictNameTb.TabIndex = 8;
            // 
            // NewCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 388);
            this.Controls.Add(this.DistrictNameTb);
            this.Controls.Add(this.CityDistrictNameTv);
            this.Controls.Add(this.butonCircular1);
            this.Controls.Add(this.CityCodTb);
            this.Controls.Add(this.CityNameTb);
            this.Controls.Add(this.CityCodeTv);
            this.Controls.Add(this.CityNameTv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NewCityForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "City";
            this.Load += new System.EventHandler(this.NewCityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCityName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCityCod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CityNameTv;
        private System.Windows.Forms.Label CityCodeTv;
        private System.Windows.Forms.TextBox CityNameTb;
        private System.Windows.Forms.TextBox CityCodTb;
        private ButonCircular butonCircular1;
        private System.Windows.Forms.ErrorProvider errorProviderCityName;
        private System.Windows.Forms.ErrorProvider errorProviderCityCod;
        private System.Windows.Forms.ComboBox DistrictNameTb;
        private System.Windows.Forms.Label CityDistrictNameTv;
    }
}