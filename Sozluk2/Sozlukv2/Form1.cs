using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;
using System.IO;

namespace Sozlukv2
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
            DosyadanSozluguYukle();
        }

        private void SozluguDosyayaKaydet()
        {
            StreamWriter yazici = new StreamWriter("Sozluk.txt");
            foreach (string turkce in sozluk.Keys)
            {
                yazici.WriteLine(turkce + "," + sozluk[turkce]);
            }
            yazici.Close();
        }

        private void DosyadanSozluguYukle()
        { 
            //using System.IO
            if (!File.Exists("Sozluk.txt"))
            {
                // Sözlük dosyası yoksa boş bir tane oluştur.
                File.CreateText("Sozluk.txt");
                return;
            }

            // Sözlüğün içindeki kelime çiftleri yükleniyor.
            StreamReader okuyucu = new StreamReader("Sozluk.txt");
            string satir=okuyucu.ReadLine();
            while(satir!=null)
            {
                string[] kelimeler = satir.Split(',');
                sozluk.Add(kelimeler[0], kelimeler[1]);
                satir = okuyucu.ReadLine();
            }
            okuyucu.Close();
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SozluguDosyayaKaydet();
        }
    }
}
