using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtoGP
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        public static string[] personel = null;
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            if (personel == null)
            {
                MessageBox.Show("Giriş yaparken bir hata oldu. personel hesabı bulunamadı.");
                Application.Exit();
            }
            if (personel[3] == "0")
            {
                MessageBox.Show("Bu personel hesabı henüz aktif edilmemiş.");
                Application.Exit();
            }

        }
        private void Uye_Ekle_Click(object sender, EventArgs e)
        {
            if (personel[5] == "0")
            {
                MessageBox.Show("Yeterli yetki yok");
                return;
            }

            UyeEkle uyeeklefrm = new UyeEkle();
            uyeeklefrm.ShowDialog();
        }

        private void Kitap_Ekle_Click(object sender, EventArgs e)
        {
            if (personel[6] == "0")
            {
                MessageBox.Show("Yeterli yetki yok");
                return;
            }

            KitapEkle kitapeklefrm = new KitapEkle();
            kitapeklefrm.ShowDialog();
        }

        private void UyeListele_Click(object sender, EventArgs e)
        {
            if (personel[5] == "0")
            {
                MessageBox.Show("Yeterli yetki yok");
                return;
            }

            UyeListele uyelistfrm = new UyeListele();
            uyelistfrm.ShowDialog();
        }

        private void KitapListele_Click(object sender, EventArgs e)
        {
            if (personel[6] == "0")
            {
                MessageBox.Show("Yeterli yetki yok");
                return;
            }

            KitapListele kitapfrm = new KitapListele();
            kitapfrm.ShowDialog();
        }

        private void Kitap_Teslim_Click(object sender, EventArgs e)
        {
            if (personel[7] == "0")
            {
                MessageBox.Show("Yeterli yetki yok");
                return;
            }

            KitapTeslim teslmfrm = new KitapTeslim();
            teslmfrm.ShowDialog();
        }

        private void Kitap_Sorgula_Click(object sender, EventArgs e)
        {
            if (personel[6] == "0")
            {
                MessageBox.Show("Yeterli yetki yok");
                return;
            }
            kitapsorgulama frm = new kitapsorgulama();
            frm.ShowDialog();
        }

        private void TeslimListesi_Click(object sender, EventArgs e)
        {
            if (personel[7] == "0")
            {
                MessageBox.Show("Yeterli yetki yok");
                return;
            }
            TeslimListesi tes = new TeslimListesi();
            tes.ShowDialog();
        }

        private void personelAyarlari_Click(object sender, EventArgs e)
        {
            if (personel[4] == "0")
            {
                MessageBox.Show("Yeterli yetki yok");
                return;
            }
            Personeller personeller = new Personeller();
            personeller.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //close the app
            Application.Exit();
        }

       
    }
}
