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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DistrictNameTv = new System.Windows.Forms.Label();
            this.DistrictCodTv = new System.Windows.Forms.Label();
            this.DistrictNameTb = new System.Windows.Forms.TextBox();
            this.DistrictCodTb = new System.Windows.Forms.TextBox();
            this.butonCircular1 = new ConferencePlanner.WinUi.ButonCircular();
            this.errorProviderDistrictName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDistrictCod = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDistrictName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDistrictCod)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 119);
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
            this.label1.Location = new System.Drawing.Point(94, 150);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert a new district";
            // 
            // DistrictNameTv
            // 
            this.DistrictNameTv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DistrictNameTv.AutoSize = true;
            this.DistrictNameTv.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DistrictNameTv.Location = new System.Drawing.Point(25, 194);
            this.DistrictNameTv.Name = "DistrictNameTv";
            this.DistrictNameTv.Size = new System.Drawing.Size(44, 17);
            this.DistrictNameTv.TabIndex = 2;
            this.DistrictNameTv.Text = "Name";
            // 
            // DistrictCodTv
            // 
            this.DistrictCodTv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DistrictCodTv.AutoSize = true;
            this.DistrictCodTv.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DistrictCodTv.Location = new System.Drawing.Point(25, 236);
            this.DistrictCodTv.Name = "DistrictCodTv";
            this.DistrictCodTv.Size = new System.Drawing.Size(32, 17);
            this.DistrictCodTv.TabIndex = 3;
            this.DistrictCodTv.Text = "Cod";
            // 
            // DistrictNameTb
            // 
            this.DistrictNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DistrictNameTb.Location = new System.Drawing.Point(106, 194);
            this.DistrictNameTb.Name = "DistrictNameTb";
            this.DistrictNameTb.Size = new System.Drawing.Size(136, 23);
            this.DistrictNameTb.TabIndex = 4;
            // 
            // DistrictCodTb
            // 
            this.DistrictCodTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DistrictCodTb.Location = new System.Drawing.Point(106, 236);
            this.DistrictCodTb.Name = "DistrictCodTb";
            this.DistrictCodTb.Size = new System.Drawing.Size(136, 23);
            this.DistrictCodTb.TabIndex = 5;
            // 
            // butonCircular1
            // 
            this.butonCircular1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butonCircular1.Location = new System.Drawing.Point(94, 296);
            this.butonCircular1.Name = "butonCircular1";
            this.butonCircular1.Size = new System.Drawing.Size(113, 40);
            this.butonCircular1.TabIndex = 6;
            this.butonCircular1.Text = "Add district";
            this.butonCircular1.UseVisualStyleBackColor = true;
            this.butonCircular1.Click += new System.EventHandler(this.butonCircular1_Click);
            // 
            // errorProviderDistrictName
            // 
            this.errorProviderDistrictName.ContainerControl = this;
            // 
            // errorProviderDistrictCod
            // 
            this.errorProviderDistrictCod.ContainerControl = this;
            // 
            // NewDistrictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 348);
            this.Controls.Add(this.butonCircular1);
            this.Controls.Add(this.DistrictCodTb);
            this.Controls.Add(this.DistrictNameTb);
            this.Controls.Add(this.DistrictCodTv);
            this.Controls.Add(this.DistrictNameTv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NewDistrictForm";
            this.Text = "NewDistrictForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDistrictName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDistrictCod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DistrictNameTv;
        private System.Windows.Forms.Label DistrictCodTv;
        private System.Windows.Forms.TextBox DistrictNameTb;
        private System.Windows.Forms.TextBox DistrictCodTb;
        private ButonCircular butonCircular1;
        private System.Windows.Forms.ErrorProvider errorProviderDistrictName;
        private System.Windows.Forms.ErrorProvider errorProviderCod;
        private System.Windows.Forms.ErrorProvider errorProviderDistrictCod;
    }
}