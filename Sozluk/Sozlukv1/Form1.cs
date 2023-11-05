using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;

namespace Sozlukv1
{
    public partial class Form1 : Form
    {
        // Sözlük nesnesi 
        Hashtable sozluk = new Hashtable();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sözlüğe kelime çiftleri ekleniyor
            sozluk.Add("elma", "apple");
            sozluk.Add("muz", "banana");
            sozluk.Add("masa", "table");
            sozluk.Add("araba", "car");
            sozluk.Add("kitap", "book");
            sozluk.Add("kalem", "pen");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (sozluk.Contains(txtAranacak.Text))
            {
                MessageBox.Show(sozluk[txtAranacak.Text].ToString());
            }
            else
            {
                MessageBox.Show("Kelime sözlükte bulunamadı!");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Sözlüğe yeni kelime çiftini ekle
            sozluk.Add(txtTurkcesi.Text, txtIngilizcesi.Text);
            
            // Sözlük metin kutularının içlerini temizle
            txtTurkcesi.Clear();
            txtIngilizcesi.Clear();
    }
    }
}
