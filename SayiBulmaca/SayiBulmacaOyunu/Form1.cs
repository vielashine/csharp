using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SayiBulmacaOyunu
{
    public partial class Form1 : Form
    {
    int tutulan = 0;
    int denemeSayisi = 0;

        public Form1()
        {
            InitializeComponent();
        }

    private void btnTamam_Click(object sender, EventArgs e)
    {
        int tahmin = int.Parse(txtTahmin.Text);
        
        denemeSayisi++;
        
        if (tahmin>tutulan)
        {
            MessageBox.Show("Daha küçük");
        }
        else if (tahmin<tutulan)
        {
            MessageBox.Show("Daha büyük");
        }
        else
        {
            // Kullanıcı tutulanı bildi
            KazanmaIslemi();
        }

        // Metin kutusundaki yazıları seç
        txtTahmin.SelectAll();

        // İmleci metin kutusuna konumlandır
        txtTahmin.Focus();
    }

    private void KazanmaIslemi()
    {
        MessageBox.Show("Tebrikler "
                    + denemeSayisi.ToString()
                    + " denemede bildiniz.");

        DialogResult cevap;
        cevap = MessageBox.Show("Yeni oyun?", "Sayı Tahmin Oyunu",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

        if (cevap == DialogResult.Yes)
        {
            // Yeni oyun için hazırlık yapılıyor
            DegiskenleriSifirla();
            txtTahmin.Clear();
            SayiTut();
        }
        else
        {
            // Uygulamayı sonlandırır
            this.Close();
        }
    }

    private void DegiskenleriSifirla()
    {
        // Değişkenler sıfırlanıyor
        tutulan = 0;
        denemeSayisi = 0;
    }

    private void SayiTut()
    {
        // Yeni bir sayı tutuyor
        Random r = new Random();
        tutulan = r.Next(1, 100);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        SayiTut();
    }
    }
}
