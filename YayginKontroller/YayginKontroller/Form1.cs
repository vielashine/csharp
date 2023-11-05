using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YayginKontroller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region RadioButton


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MesajYaz("int seçildi.");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                MesajYaz("bool seçildi.");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                MesajYaz("decimal seçildi.");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                MesajYaz("char seçildi.");
            }
        } 
        #endregion

        #region CheckBox

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MesajYaz("Türkçe seçeneği işaretlendi.");
            }
            else
            {
                MesajYaz("Türkçe seçeneğinin işareti kaldırıldı.");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                MesajYaz("İngilizce seçeneği işaretlendi.");
            }
            else
            {
                MesajYaz("İngilizce seçeneğinin işareti kaldırıldı.");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                MesajYaz("Fransızca seçeneği işaretlendi.");
            }
            else
            {
                MesajYaz("Fransızca seçeneğinin işareti kaldırıldı.");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                MesajYaz("Almanca seçeneği işaretlendi.");
            }
            else
            {
                MesajYaz("Almanca seçeneğinin işareti kaldırıldı.");
            }
        }

        #endregion

        #region PictureBox
        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult secim = ofd.ShowDialog();
            if (secim == DialogResult.OK)
            {
                pictureBox1.Load(ofd.FileName);
                MesajYaz(ofd.FileName + " görseli yüklendi.");
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            MesajYaz("Resim normal boyutunda.");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            MesajYaz("Resim sündürüldü..");
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            MesajYaz("Resim çerçevesi, resme göre ayarlandı.");
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    #endregion

        #region TabControl
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            MesajYaz(e.TabPage.Text + " sekmesi seçildi."); 
        } 
        #endregion

        #region Panel

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                panel1.Enabled = true;
                MesajYaz("Panel aktifleştirildi.");
            }
        }

        private void radioButton10_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                panel1.Enabled = false;
                MesajYaz("Panel pasifleştirildi.");
            }
        }

        #endregion

        #region DateTimePicker
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label5.Text = "Tarih: " 
                    + dateTimePicker1.Value.ToString();
            MesajYaz("Tarih değişti: " 
                + dateTimePicker1.Value.ToString());
        }
        #endregion

        #region ListBox
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblListBoxSecilen.Text = 
                        listBox1.SelectedItem.ToString();
            MesajYaz("ListBox seçimi değişti: " +
                        listBox1.SelectedItem.ToString());
        }
        #endregion

        #region ComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblComboBoxSecilen.Text = 
                        comboBox1.SelectedItem.ToString();
            MesajYaz("ComboBox seçimi değişti: " +
                        comboBox1.SelectedItem.ToString());
        }
        #endregion

        #region Timer&ProgressBar

        long toplamTik = 0;
        bool ileri = true;

        private void chkTimerAktif_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = chkTimerAktif.Checked;
            MesajYaz("Sayaç durumu değiştirildi: " +
                        timer1.Enabled.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toplamTik++;
            lblTimerToplamTik.Text = toplamTik.ToString();

            if (progressBar1.Value == 30)
            {
                ileri = false;
            }

            if (progressBar1.Value == 0)
            {
                ileri = true;
            }

            if (ileri)
            {
                progressBar1.Value++;
            }
            else
            {
                progressBar1.Value--;
            }
        }

        #endregion

    private void MesajYaz(string mesaj)
    {
        txtMesaj.Text = mesaj
                 + "\r\n" + txtMesaj.Text;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // ListBox öğeleri yükleniyor
        listBox1.Items.Add("Kırmızı");
        listBox1.Items.Add("Mavi");
        listBox1.Items.Add("Sarı");
        listBox1.Items.Add("Yeşil");
        listBox1.Items.Add("Beyaz");
        listBox1.Items.Add("Siyah");
        listBox1.Items.Add("Pembe");
        listBox1.Items.Add("Mor");
        listBox1.Items.Add("Turuncu");
        listBox1.Items.Add("Gri");

        //ComboBox ın öğeleri yükleniyor
        comboBox1.Items.Add("İstanbul");
        comboBox1.Items.Add("İzmit");
        comboBox1.Items.Add("Yalova");
        comboBox1.Items.Add("Bursa");
        comboBox1.Items.Add("Balıkesir");
    }
    }
}
