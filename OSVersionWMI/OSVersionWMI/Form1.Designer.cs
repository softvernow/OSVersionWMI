namespace OSVersionWMI
{
    partial class Form1
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
            this.btnGetOS = new System.Windows.Forms.Button();
            this.txtOSVersion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetOS
            // 
            this.btnGetOS.Location = new System.Drawing.Point(23, 12);
            this.btnGetOS.Name = "btnGetOS";
            this.btnGetOS.Size = new System.Drawing.Size(211, 57);
            this.btnGetOS.TabIndex = 0;
            this.btnGetOS.Text = "Get OS";
            this.btnGetOS.UseVisualStyleBackColor = true;
            this.btnGetOS.Click += new System.EventHandler(this.btnGetOS_Click);
            // 
            // txtOSVersion
            // 
            this.txtOSVersion.Location = new System.Drawing.Point(23, 75);
            this.txtOSVersion.Name = "txtOSVersion";
            this.txtOSVersion.Size = new System.Drawing.Size(211, 20);
            this.txtOSVersion.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 104);
            this.Controls.Add(this.txtOSVersion);
            this.Controls.Add(this.btnGetOS);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetOS;
        private System.Windows.Forms.TextBox txtOSVersion;
    }
}

