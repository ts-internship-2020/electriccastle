﻿namespace ConferencePlanner.WinUi
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.txtButton = new System.Windows.Forms.TextBox();
            this.submitButton = new ConferencePlanner.WinUi.ButonCircular();
            this.errorProviderEmailText = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmailText)).BeginInit();
            this.SuspendLayout();
            // 
            // txtButton
            // 
            this.txtButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtButton.Location = new System.Drawing.Point(82, 67);
            this.txtButton.Name = "txtButton";
            this.txtButton.PlaceholderText = "                Insert your email";
            this.txtButton.Size = new System.Drawing.Size(238, 23);
            this.txtButton.TabIndex = 3;
            this.txtButton.TextChanged += new System.EventHandler(this.txtButton_TextChanged);
            this.txtButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtButton_KeyDown);
            this.txtButton.Validating += new System.ComponentModel.CancelEventHandler(this.txtButton_Validating);
            // 
            // submitButton
            // 
            this.submitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitButton.BackgroundImage")));
            this.submitButton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitButton.Location = new System.Drawing.Point(145, 96);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(104, 29);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // errorProviderEmailText
            // 
            this.errorProviderEmailText.ContainerControl = this;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 219);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.txtButton);
            this.Name = "StartScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Event Skills";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartScreen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmailText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox t;
        private System.Windows.Forms.TextBox txtButton;
        private ButonCircular submitButton1;
        private ButonCircular submitButton;
        private System.Windows.Forms.ErrorProvider errorProviderEmailText;
    }
}