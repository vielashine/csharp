namespace MetinselToplama
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
            this.txtMetin1 = new System.Windows.Forms.TextBox();
            this.txtMetin2 = new System.Windows.Forms.TextBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.btnBirlestir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMetin1
            // 
            this.txtMetin1.Location = new System.Drawing.Point(94, 34);
            this.txtMetin1.Name = "txtMetin1";
            this.txtMetin1.Size = new System.Drawing.Size(100, 20);
            this.txtMetin1.TabIndex = 0;
            // 
            // txtMetin2
            // 
            this.txtMetin2.Location = new System.Drawing.Point(94, 60);
            this.txtMetin2.Name = "txtMetin2";
            this.txtMetin2.Size = new System.Drawing.Size(100, 20);
            this.txtMetin2.TabIndex = 1;
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(94, 115);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            this.txtSonuc.Size = new System.Drawing.Size(100, 20);
            this.txtSonuc.TabIndex = 2;
            // 
            // btnBirlestir
            // 
            this.btnBirlestir.Location = new System.Drawing.Point(105, 86);
            this.btnBirlestir.Name = "btnBirlestir";
            this.btnBirlestir.Size = new System.Drawing.Size(75, 23);
            this.btnBirlestir.TabIndex = 3;
            this.btnBirlestir.Text = "Birleştir";
            this.btnBirlestir.UseVisualStyleBackColor = true;
            this.btnBirlestir.Click += new System.EventHandler(this.btnBirlestir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 190);
            this.Controls.Add(this.btnBirlestir);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtMetin2);
            this.Controls.Add(this.txtMetin1);
            this.Name = "Form1";
            this.Text = "Metinsel Birleştirme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetin1;
        private System.Windows.Forms.TextBox txtMetin2;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button btnBirlestir;
    }
}

