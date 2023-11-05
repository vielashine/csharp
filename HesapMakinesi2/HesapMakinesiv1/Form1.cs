using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HesapMakinesiv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Topla(int s1, int s2)
        {
            return s1 + s2;
        }

        private int Cikart(int s1, int s2)
        {
            return s1 - s2;
        }

        private int Carp(int s1, int s2)
        {
            return s1 * s2;
        }

        private decimal Bol(int s1, int s2)
        {
            return (decimal)s1 / (decimal)s2;
        }

        private void IslemYap(string islem)
        {
            string sonuc = "";
           
            int sayi1 = int.Parse(txtSayi1.Text);
            int sayi2 = int.Parse(txtSayi2.Text);

            
            switch (islem)
            {
                case "+":
                    int tpl=Topla(sayi1, sayi2);
                    sonuc = tpl.ToString();
                    break;
                case "-":
                    int ckr = Cikart(sayi1, sayi2);
                    sonuc = ckr.ToString();
                    break;
                case "*":
                    int crp = Carp(sayi1, sayi2);
                    sonuc = crp.ToString();
                    break;
                case "/":
                    decimal bol = Bol(sayi1, sayi2);
                    sonuc = bol.ToString();
                    break;
            }

            lblSonuc.Text = "Sonuç: " + sonuc;
        }


        private void btnTopla_Click(object sender, EventArgs e)
        {
            IslemYap("+");
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            IslemYap("-");
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            IslemYap("*");
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            IslemYap("/");
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
