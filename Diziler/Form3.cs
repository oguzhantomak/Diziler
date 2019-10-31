using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string[] sehirler = { "istanbul", "edirne", "ankara", "eskişehir", "bursa", "konya", "trabzon", "eskişehir", "sivas" };

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Array.Clear(sehirler, 0, 5);
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            string[] kopyaArray = new string[5];
            Array.Copy(sehirler, kopyaArray, 3);

            Array.Copy(sehirler, 2, kopyaArray, 2, 3);
        }

        private void BtnIndexOf_Click(object sender, EventArgs e)
        {
            int index = Array.IndexOf(sehirler, txtGelenDeger.Text);
            MessageBox.Show("Aradığınız index değeri: " + index);
            MessageBox.Show(string.Format("Aradığınız index değeri: {0}" + index));
            MessageBox.Show($"Aradığınız index değeri: {index}");

            if (index != -1)
            {
                MessageBox.Show("Aradığınız şehir var.");
            }
            else
            {
                MessageBox.Show("Aradığınız şehir listede yok");
            }

            //diğer bir yazım şekli ise;

            MessageBox.Show(index < 0 ? "Dizi içerisinde elean bulunmamaktadır" : "Dizi içerisinde eleman bulunmaktadır");

            // diğer bir yazım şekli ise 2;

            MessageBox.Show($"Dizi içerisinde eleman bulunma{(index < 0 ? "ma" : "")}ktadır {index}");

            index = Array.IndexOf(sehirler, txtGelenDeger.Text, 2);
            index = Array.IndexOf(sehirler, txtGelenDeger.Text, 2,5);


        }

        private void BtnLastIndexOf_Click(object sender, EventArgs e)
        {
            int index = Array.LastIndexOf(sehirler, txtGelenDeger.Text);
            MessageBox.Show($"Dizi içerisinde eleman bulunma{(index < 0 ? "ma" : "")}ktadır {index}");
        }

        private void BtnArrayResize_Click(object sender, EventArgs e)
        {
            Array.Resize<string>(ref sehirler,50);
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            Array.Sort(sehirler);
            Array.Sort(sehirler, 2, 3); // 2 den başla, 3 tanesini değiştir.
        }

        private void BtnReverse_Click(object sender, EventArgs e)
        {
            Array.Reverse(sehirler);
        }
    }
}
