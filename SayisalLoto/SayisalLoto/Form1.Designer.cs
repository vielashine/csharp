namespace SayisalLoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lnkYenile = new System.Windows.Forms.LinkLabel();
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.lblSayi3 = new System.Windows.Forms.Label();
            this.lblSayi4 = new System.Windows.Forms.Label();
            this.lblSayi5 = new System.Windows.Forms.Label();
            this.lblSayi6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnkYenile
            // 
            this.lnkYenile.AutoSize = true;
            this.lnkYenile.Location = new System.Drawing.Point(224, 9);
            this.lnkYenile.Name = "lnkYenile";
            this.lnkYenile.Size = new System.Drawing.Size(36, 13);
            this.lnkYenile.TabIndex = 0;
            this.lnkYenile.TabStop = true;
            this.lnkYenile.Text = "Yenile";
            this.lnkYenile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkYenile_LinkClicked);
            // 
            // lblSayi1
            // 
            this.lblSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi1.Location = new System.Drawing.Point(80, 77);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(32, 32);
            this.lblSayi1.TabIndex = 1;
            this.lblSayi1.Text = "49";
            this.lblSayi1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi2
            // 
            this.lblSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi2.Location = new System.Drawing.Point(143, 77);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(32, 32);
            this.lblSayi2.TabIndex = 1;
            this.lblSayi2.Text = "49";
            this.lblSayi2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi3
            // 
            this.lblSayi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi3.Location = new System.Drawing.Point(208, 77);
            this.lblSayi3.Name = "lblSayi3";
            this.lblSayi3.Size = new System.Drawing.Size(32, 32);
            this.lblSayi3.TabIndex = 1;
            this.lblSayi3.Text = "49";
            this.lblSayi3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi4
            // 
            this.lblSayi4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi4.Location = new System.Drawing.Point(271, 77);
            this.lblSayi4.Name = "lblSayi4";
            this.lblSayi4.Size = new System.Drawing.Size(32, 32);
            this.lblSayi4.TabIndex = 1;
            this.lblSayi4.Text = "49";
            this.lblSayi4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi5
            // 
            this.lblSayi5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi5.Location = new System.Drawing.Point(333, 77);
            this.lblSayi5.Name = "lblSayi5";
            this.lblSayi5.Size = new System.Drawing.Size(32, 32);
            this.lblSayi5.TabIndex = 1;
            this.lblSayi5.Text = "49";
            this.lblSayi5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi6
            // 
            this.lblSayi6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi6.Location = new System.Drawing.Point(395, 77);
            this.lblSayi6.Name = "lblSayi6";
            this.lblSayi6.Size = new System.Drawing.Size(32, 32);
            this.lblSayi6.TabIndex = 1;
            this.lblSayi6.Text = "49";
            this.lblSayi6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(512, 184);
            this.Controls.Add(this.lblSayi6);
            this.Controls.Add(this.lblSayi5);
            this.Controls.Add(this.lblSayi4);
            this.Controls.Add(this.lblSayi3);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblSayi1);
            this.Controls.Add(this.lnkYenile);
            this.Name = "Form1";
            this.Text = "Sayısal Loto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkYenile;
        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.Label lblSayi3;
        private System.Windows.Forms.Label lblSayi4;
        private System.Windows.Forms.Label lblSayi5;
        private System.Windows.Forms.Label lblSayi6;
    }
}

