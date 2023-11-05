namespace IsimCekilisi
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
            this.btnCekilisYap = new System.Windows.Forms.Button();
            this.txtCekilenler = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCekilisYap
            // 
            this.btnCekilisYap.Location = new System.Drawing.Point(135, 69);
            this.btnCekilisYap.Name = "btnCekilisYap";
            this.btnCekilisYap.Size = new System.Drawing.Size(75, 23);
            this.btnCekilisYap.TabIndex = 0;
            this.btnCekilisYap.Text = "Çekiliş Yap";
            this.btnCekilisYap.UseVisualStyleBackColor = true;
            this.btnCekilisYap.Click += new System.EventHandler(this.btnCekilisYap_Click);
            // 
            // txtCekilenler
            // 
            this.txtCekilenler.Location = new System.Drawing.Point(93, 110);
            this.txtCekilenler.Multiline = true;
            this.txtCekilenler.Name = "txtCekilenler";
            this.txtCekilenler.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCekilenler.Size = new System.Drawing.Size(175, 115);
            this.txtCekilenler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 312);
            this.Controls.Add(this.txtCekilenler);
            this.Controls.Add(this.btnCekilisYap);
            this.Name = "Form1";
            this.Text = "İsim Çekilişi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCekilisYap;
        private System.Windows.Forms.TextBox txtCekilenler;
    }
}

