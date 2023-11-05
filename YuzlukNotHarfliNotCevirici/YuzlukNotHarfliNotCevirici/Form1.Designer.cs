namespace YuzlukNotHarfliNotCevirici
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
            this.btnCevir = new System.Windows.Forms.Button();
            this.txtYuzlukNok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCevir
            // 
            this.btnCevir.Location = new System.Drawing.Point(138, 66);
            this.btnCevir.Name = "btnCevir";
            this.btnCevir.Size = new System.Drawing.Size(75, 23);
            this.btnCevir.TabIndex = 0;
            this.btnCevir.Text = "Çevir";
            this.btnCevir.UseVisualStyleBackColor = true;
            this.btnCevir.Click += new System.EventHandler(this.btnCevir_Click);
            // 
            // txtYuzlukNok
            // 
            this.txtYuzlukNok.Location = new System.Drawing.Point(113, 40);
            this.txtYuzlukNok.Name = "txtYuzlukNok";
            this.txtYuzlukNok.Size = new System.Drawing.Size(100, 20);
            this.txtYuzlukNok.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yüzlük not: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 141);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYuzlukNok);
            this.Controls.Add(this.btnCevir);
            this.Name = "Form1";
            this.Text = "Yüzlük Not -> Harfli Not";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCevir;
        private System.Windows.Forms.TextBox txtYuzlukNok;
        private System.Windows.Forms.Label label1;
    }
}

