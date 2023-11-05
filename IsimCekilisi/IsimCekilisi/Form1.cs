using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IsimCekilisi
{
    public partial class Form1 : Form
    {
        // isimler dizisi oluşturuluyor
        string[] isimler = new string[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCekilisYap_Click(object sender, EventArgs e)
        {
            // Rastgele sayı üreteci oluşturuluyor
            Random r = new Random();

            // Rastgele bir sayı çekiliyor
            int cekilisNo = r.Next(0, 9);

            // Çekilin sayıya bağlı olarak listeden
            // bir isim seçiliyor ve ekrana yazdırılıyor
            txtCekilenler.Text = isimler[cekilisNo] + "\r\n" 
                                + txtCekilenler.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Diziye isimler ekleniyor
            isimler[0] = "Utkan";
            isimler[1] = "Burhan";
            isimler[2] = "Ayşen";
            isimler[3] = "Eda";
            isimler[4] = "Asuman";
            isimler[5] = "Mina";
            isimler[6] = "İbrahim";
            isimler[7] = "Aydın";
            isimler[8] = "Aleyna";
            isimler[9] = "Jülide";
        }
    }
}
