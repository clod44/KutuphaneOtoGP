using Microsoft.VisualBasic;
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
    public partial class KitapListele : Form
    {
        public KitapListele()
        {
            InitializeComponent();
        }
        public static List<string[]> kitapBilgileri = new List<string[]>();
        public static string kitapıd, kitapad, yazar, yil, sayfa, dil, yayinevi, durum, konu;
        public static int selectedValue;


        public void liste()
        {
            string read = "D://AddBook.csv";
            string[] oku = File.ReadAllLines(read);
            if (oku.Length > 0)
            {
                string ilkSatir = listBox1.SelectedItem.ToString();
                selectedValue = listBox1.SelectedIndex;
                //ilkSatir = ilkSatir.Replace("  ", " ");
                //ilkSatir = ilkSatir.Replace("    ", " ");
                string[] parcalar = ilkSatir.Split(';');

                kitapBilgileri.Add(parcalar);
                kitapıd = parcalar[0];
                kitapad = parcalar[1];
                yazar = parcalar[2];
                yil = parcalar[3];
                sayfa = parcalar[4];
                dil = parcalar[5];
                yayinevi = parcalar[6];
                durum = parcalar[7];
                konu = parcalar[8];

            }
        }



        public void oku()
        {

            listBox1.Items.Clear();
            string read = "D://AddBook.csv";
            read.Split(';');
            string[] filepath = File.ReadAllLines(read);
            for (int i = 0; i < filepath.Length; i++)
            {
                listBox1.Items.Add(filepath[i]);
            }

        }
        private void KitapListele_Load(object sender, EventArgs e)
        {
            oku();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            liste();
            KitapGuncelle kitapfrm = new KitapGuncelle();
            kitapfrm.ShowDialog();
            oku();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
