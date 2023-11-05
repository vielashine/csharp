using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YuzlukNotHarfliNotCevirici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            int not = int.Parse(txtYuzlukNok.Text);
            string mesaj = "";

            if (not >= 0 && not <= 49)
            {
                mesaj = "F";
            }
            else if (not >= 50 && not <= 59)
            {
                mesaj = "DD";
            }
            else if (not >= 60 && not <= 69)
            {
                mesaj = "DC";
            }
            else if (not >= 70 && not <= 74)
            {
                mesaj = "CC";
            }
            else if (not >= 75 && not <= 79)
            {
                mesaj = "CB";
            }
            else if (not >= 80 && not <= 84)
            {
                mesaj = "BB";
            }
            else if (not >= 85 && not <= 89)
            {
                mesaj = "BA";
            }
            else if (not >= 90 && not <= 100)
            {
                mesaj = "AA";
            }
            else
            {
                mesaj = "Hatalı değer!";
            }

            MessageBox.Show(mesaj);
        }
    }
}
