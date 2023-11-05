using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HesapMakinesiv1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            // Metin kutularından sayı değerler alınıyor
            int sayi1 = int.Parse(txtSayi1.Text);
            int sayi2 = int.Parse(txtSayi2.Text);

            // Sayılar toplanıyor
            int toplam = sayi1 + sayi2;

            // Sayılar ekrana yazdırılıyor
            lblSonuc.Text = "Sonuç: " + toplam.ToString();
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            // Metin kutularından sayı değerler alınıyor
            int sayi1 = int.Parse(txtSayi1.Text);
            int sayi2 = int.Parse(txtSayi2.Text);

            // Sayılar çıkartılıyor
            int fark = sayi1 - sayi2;

            // Sayılar ekrana yazdırılıyor
            lblSonuc.Text = "Sonuç: " + fark.ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            // Metin kutularından sayı değerler alınıyor
            int sayi1 = int.Parse(txtSayi1.Text);
            int sayi2 = int.Parse(txtSayi2.Text);

            // Sayılar çarpılıyor
            int carpim = sayi1 * sayi2;

            // Sayılar ekrana yazdırılıyor
            lblSonuc.Text = "Sonuç: " + carpim.ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            // Metin kutularından sayı değerler alınıyor
            decimal sayi1 = decimal.Parse(txtSayi1.Text);
            decimal sayi2 = decimal.Parse(txtSayi2.Text);

            // Sayılar bölünüyor
            decimal bolum = sayi1 / sayi2;

            // Sayılar ekrana yazdırılıyor
            lblSonuc.Text = "Sonuç: " + bolum.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
