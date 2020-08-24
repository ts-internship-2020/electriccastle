namespace ConferencePlanner.WinUi
{
    partial class TestareFctButoane
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
            this.join = new System.Windows.Forms.Button();
            this.attend = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // join
            // 
            this.join.Location = new System.Drawing.Point(696, 38);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(75, 23);
            this.join.TabIndex = 0;
            this.join.Text = "join";
            this.join.UseVisualStyleBackColor = true;
            this.join.Click += new System.EventHandler(this.join_Click);
            // 
            // attend
            // 
            this.attend.Location = new System.Drawing.Point(696, 89);
            this.attend.Name = "attend";
            this.attend.Size = new System.Drawing.Size(75, 23);
            this.attend.TabIndex = 1;
            this.attend.Text = "attend";
            this.attend.UseVisualStyleBackColor = true;
            this.attend.Click += new System.EventHandler(this.attend_Click);
            // 
            // withdraw
            // 
            this.withdraw.Location = new System.Drawing.Point(696, 140);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(75, 23);
            this.withdraw.TabIndex = 2;
            this.withdraw.Text = "withdraw";
            this.withdraw.UseVisualStyleBackColor = true;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // TestareFctButoane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.attend);
            this.Controls.Add(this.join);
            this.Name = "TestareFctButoane";
            this.Text = "TestareFctButoane";
            this.Load += new System.EventHandler(this.TestareFctButoane_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button join;
        private System.Windows.Forms.Button attend;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Label label1;
    }
}