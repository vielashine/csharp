using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// SQL Server veri kaynağıyla çalışabilmek için
using System.Data.SqlClient;

namespace UrunYonetcisi
{
    public partial class Form1 : Form
    {
// Dataset nesnesi oluşturuluyor
DataSet dsUrunler = new DataSet();
DataRow seciliKayit;
string baglantiMetni = "Data Source=.\\SQLExpress;" +
        "Initial Catalog=MusteriIliskileri;" +
        "User Id=sa;Pwd=p@r0l@";
SqlConnection baglanti;
SqlDataAdapter adaptor;

        public Form1()
        {
            InitializeComponent();
        }

private void Form1_Load(object sender, EventArgs e)
{
    baglanti =
        new SqlConnection(baglantiMetni);

    // SQL sunucu veri adaptörü oluşturuluyor
    adaptor =
        new SqlDataAdapter("SELECT * FROM Urunler", baglanti);
    
    // Dataset nesnesi yapılandırılıyor
    adaptor.Fill(dsUrunler, "tblUrunler");

    // Veri üzeride işlem yapılıyor
    foreach (DataRow satir in dsUrunler.Tables[0].Rows)
    {
         lstUrunler.Items.Add(satir["UrunAdi"]);
    }

    if (lstUrunler.Items.Count>0)
    {
        lstUrunler.SelectedIndex = 0;
    }
}

private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
{
    // seçilen ürün satırı alınıyor
    DataRow[] satirlar 
        = dsUrunler.Tables[0].Select("UrunAdi='" 
        + lstUrunler.SelectedItem.ToString() + "'");

    seciliKayit=satirlar[0];
    
    // bilgiler ekranda gösteriliyor
    txtUrunNo.Text = seciliKayit[0].ToString();
    txtUrunAdi.Text = seciliKayit[1].ToString();
    txtAlisFiyati.Text = seciliKayit[2].ToString();
    txtSatisFiyati.Text = seciliKayit[3].ToString();
    txtStokMiktari.Text = seciliKayit[4].ToString();
    txtAciklama.Text = seciliKayit[5].ToString();
}

private void txtUrunAdi_TextChanged(object sender, EventArgs e)
{
    seciliKayit[1] = txtUrunAdi.Text;
}

private void txtAlisFiyati_TextChanged(object sender, EventArgs e)
{
    seciliKayit[2] = decimal.Parse(txtAlisFiyati.Text);
}

private void txtSatisFiyati_TextChanged(object sender, EventArgs e)
{
    seciliKayit[3] = decimal.Parse(txtSatisFiyati.Text);
}

private void txtStokMiktari_TextChanged(object sender, EventArgs e)
{
    seciliKayit[4] = int.Parse(txtStokMiktari.Text);
}

private void txtAciklama_TextChanged(object sender, EventArgs e)
{
    seciliKayit[5] = txtAciklama.Text;
}

private void Form1_FormClosed(object sender, FormClosedEventArgs e)
{
    SqlCommandBuilder komutYapici
        = new SqlCommandBuilder(adaptor);
    adaptor.Update(dsUrunler.Tables[0].GetChanges());
}
    }
}
