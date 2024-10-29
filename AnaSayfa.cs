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

        private void Uye_Ekle_Click(object sender, EventArgs e)
        {
            UyeEkle uyeeklefrm = new UyeEkle();
            uyeeklefrm.ShowDialog();
        }

        private void Kitap_Ekle_Click(object sender, EventArgs e)
        {
            KitapEkle kitapeklefrm = new KitapEkle();
            kitapeklefrm.ShowDialog();
        }

        private void UyeListele_Click(object sender, EventArgs e)
        {
            UyeListele uyelistfrm = new UyeListele();
            uyelistfrm.ShowDialog();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.BackColor = Color.White;

        }

        private void KitapListele_Click(object sender, EventArgs e)
        {
            KitapListele kitapfrm = new KitapListele();
            kitapfrm.ShowDialog();
        }

        private void Kitap_Teslim_Click(object sender, EventArgs e)
        {
            KitapTeslim teslmfrm = new KitapTeslim();
            teslmfrm.ShowDialog();
        }

        private void Kitap_Sorgula_Click(object sender, EventArgs e)
        {
            kitapsorgulama frm = new kitapsorgulama();
            frm.ShowDialog();
        }

        private void TeslimListesi_Click(object sender, EventArgs e)
        {
            TeslimListesi tes = new TeslimListesi();
            tes.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close the app
            Application.Exit();
        }
    }
}
