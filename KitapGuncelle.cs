using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace KutuphaneOtoGP
{
    public partial class KitapGuncelle : Form
    {
        public KitapGuncelle()
        {
            InitializeComponent();
        }
        public static int selectedLine;
        private void KitapGuncelle_Load(object sender, EventArgs e)
        {
            idTXT.Text = KitapListele.id;
            kitapTXT.Text = KitapListele.kitapad;
            yazarTXT.Text = KitapListele.yazar;
            baskiTXT.Text = KitapListele.yil;
            sayfaTXT.Text = KitapListele.sayfa;
            dilTXT.Text = KitapListele.dil;
            yayinTXT.Text = KitapListele.yayinevi;
            durumTXT.Text = KitapListele.durum;
            konuTXT.Text = KitapListele.konu;
            selectedLine = KitapListele.selectedLine;
            ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dosyaYolu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "AddBook.csv");

            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                if (satirlar.Length > 0)
                {
                    // Güncellenmiş verileri al
                    string[] guncellenmisVeriler = new string[9];
                    guncellenmisVeriler[0] = idTXT.Text;
                    guncellenmisVeriler[1] = kitapTXT.Text;
                    guncellenmisVeriler[2] = yazarTXT.Text;
                    guncellenmisVeriler[3] = baskiTXT.Text;
                    guncellenmisVeriler[4] = sayfaTXT.Text;
                    guncellenmisVeriler[5] = dilTXT.Text;
                    guncellenmisVeriler[6] = yayinTXT.Text;
                    guncellenmisVeriler[7] = durumTXT.Text;
                    guncellenmisVeriler[8] = konuTXT.Text;

                    // İlgili satırdaki verileri güncelle
                    satirlar[selectedLine] = string.Join(";", guncellenmisVeriler);

                    MessageBox.Show(satirlar[selectedLine] + "");
                    // Dosyaya güncellenmiş verileri yaz
                    File.WriteAllLines(dosyaYolu, satirlar);

                    MessageBox.Show("Veriler güncellendi!");
                    this.Close();

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


