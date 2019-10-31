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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] arabalar = {"mercedes","ferrari","bugatti","lamborghini","audi","seat","honda","alfa romeo" };
        private void BtnSoneleman_Click(object sender, EventArgs e)
        {
            int uzunluk = arabalar.Length-1; // Dizinin toplam eleman sayısı bulundu.
            string sonEleman = arabalar[uzunluk]; // Dizinin son elemanı bulundu.
            lbox1.Items.Add(sonEleman); // Dizinin son elemanı listbox'a eklendi.
        }

        Random rnd = new Random();// Radom sınıfı çağırıldı
        private void BtnRastgeleEleman_Click(object sender, EventArgs e)
        {
            
            int rndDeger = rnd.Next(0, arabalar.Length); // rndDeger değişkenine dizinin sınırları içerisinde bir değer atandı.
            this.Text = arabalar[rndDeger]; //Random olarak oluşturulan rndDeger indexine ait değer Formun Textine yazdırıldı.
        }
        int i = 0; // i değişkeni oluşturuldu.
        int[] sayilar = {10,20,30,40,50 }; // sayilar dizisi oluşturuldu.
        private void BtnElemanEkle_Click(object sender, EventArgs e)
        {
            //butona her tıklandığında dizideki değerleri tek tek listbox'a yazdırıp o anki toplamı formun textine yazdıracak.
            int toplam = 0; // anlık toplam değişkeni oluşturuldu.
            if (i<sayilar.Length) // i'nci index kontrolü yapıldı. Eğer i değeri sayilar listesinin uzunluğundan küçükse aşağıdaki işlemleri yap
            {
                lbox1.Items.Add(sayilar[i]); // listbox'a sayilar listesinin i'nci indexinin değerini ekle
                toplam += sayilar[i]; // toplam değişkeni= toplam değişkeni ve sayilar listesinin o anki i'nci indexinin değerinin toplamı
                i++; //sıradakine geçmek için i değerini 1 artır.
            }
            else
            {
                MessageBox.Show("Dizinin son elemanın ekledin"); // Eğer i değeri sayilar lisesinin index değerinden büyükse uyarı mesajı ver.
            }
            this.Text = toplam.ToString(); // Son olarak toplam değişkenini formun textine yazdır.
            
        }
    }
}
