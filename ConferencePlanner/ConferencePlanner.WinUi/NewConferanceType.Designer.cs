namespace ConferencePlanner.WinUi
{
    partial class NewConferanceType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewConferanceType));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodeType = new System.Windows.Forms.TextBox();
            this.txtNameType = new System.Windows.Forms.TextBox();
            this.btSaveType = new ConferencePlanner.WinUi.ButonCircular();
            this.errorProviderCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type name";
            // 
            // txtCodeType
            // 
            this.txtCodeType.Location = new System.Drawing.Point(158, 68);
            this.txtCodeType.Name = "txtCodeType";
            this.txtCodeType.Size = new System.Drawing.Size(100, 23);
            this.txtCodeType.TabIndex = 2;
            this.txtCodeType.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodeType_Validating);
            // 
            // txtNameType
            // 
            this.txtNameType.Location = new System.Drawing.Point(158, 124);
            this.txtNameType.Name = "txtNameType";
            this.txtNameType.Size = new System.Drawing.Size(100, 23);
            this.txtNameType.TabIndex = 3;
            this.txtNameType.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameType_Validating);
            // 
            // btSaveType
            // 
            this.btSaveType.BackColor = System.Drawing.Color.Tomato;
            this.btSaveType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btSaveType.Location = new System.Drawing.Point(92, 206);
            this.btSaveType.Name = "btSaveType";
            this.btSaveType.Size = new System.Drawing.Size(119, 32);
            this.btSaveType.TabIndex = 4;
            this.btSaveType.Text = "Upload type";
            this.btSaveType.UseVisualStyleBackColor = false;
            this.btSaveType.Click += new System.EventHandler(this.btSaveType_Click);
            // 
            // errorProviderCode
            // 
            this.errorProviderCode.ContainerControl = this;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // NewConferanceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(308, 288);
            this.Controls.Add(this.btSaveType);
            this.Controls.Add(this.txtNameType);
            this.Controls.Add(this.txtCodeType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewConferanceType";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Type";
            this.Activated += new System.EventHandler(this.NewConferanceType_Activated);
            this.Load += new System.EventHandler(this.NewConferanceType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodeType;
        private System.Windows.Forms.TextBox txtNameType;
        private ButonCircular btSaveType;
        private System.Windows.Forms.ErrorProvider errorProviderCode;
        private System.Windows.Forms.ErrorProvider errorProviderName;
    }
}