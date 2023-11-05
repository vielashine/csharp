using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;

namespace SayisalLoto
{
    public partial class Form1 : Form
    {
        ArrayList kullanilanSayilar = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SayilariUret();
        }

        private void lnkYenile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SayilariUret();
        }

        private void SayilariUret()
        {
            DegerleriSifirla();

            // Altı tane rastgele sayı üretiliyor
            int[] sayilar = new int[6];
            for (int i = 0; i < 6; i++)
            {
                sayilar[i] = RastgeleSayiUret();
            }

            // Üretilen sayılar ekrana yazdırılıyor
            lblSayi1.Text = sayilar[0].ToString();
            lblSayi2.Text = sayilar[1].ToString();
            lblSayi3.Text = sayilar[2].ToString();
            lblSayi4.Text = sayilar[3].ToString();
            lblSayi5.Text = sayilar[4].ToString();
            lblSayi6.Text = sayilar[5].ToString();
        }

        private void DegerleriSifirla()
        {
            // Değişkenler sıfırlanıyor
            kullanilanSayilar.Clear();

            // Etiketler boşaltılıyor
            lblSayi1.Text = "";
            lblSayi2.Text = "";
            lblSayi3.Text = "";
            lblSayi4.Text = "";
            lblSayi5.Text = "";
            lblSayi6.Text = "";
        }

        private int RastgeleSayiUret()
        {
            int sayi =0;
            Random rnd = new Random();
            
            // Daha önce çıkmamış bir rastgele
            // sayı üretiliyor
            while (true)
            {
                sayi= rnd.Next(1, 49);
                if (!kullanilanSayilar.Contains(sayi))
                {
                    kullanilanSayilar.Add(sayi);
                    break;
                }
            }
            return sayi;
        }

 
    }
}
