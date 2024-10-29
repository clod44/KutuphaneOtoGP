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
        public static string id, kitapad, yazar, yil, sayfa, dil, yayinevi, durum, konu;
        public static int selectedLine;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void oku()
        {
            listView1.Items.Clear();
            string read = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "AddBook.csv");
            string[] filepath = File.ReadAllLines(read);

            //her satır için
            foreach (string line in filepath)
            {
                //satırı diziye çevir
                string[] veriler = line.Split(';');
                if (veriler.Length > 0)
                {
                    //diziyi listeye ekle
                    ListViewItem item = new ListViewItem(veriler);
                    listView1.Items.Add(item);
                }
            }
        }
        private void KitapListele_Load(object sender, EventArgs e)
        {
            oku();
        }




        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //seçilen list satırını al
            ListViewItem item = listView1.HitTest(e.Location).Item;

            if (item != null)
            {
                if (item.SubItems.Count == 0) return;
                //değerleri geçici olarak elinde tut
                selectedLine = listView1.Items.IndexOf(item);
                id = item.SubItems[0].Text;
                kitapad = item.SubItems[1].Text;
                yazar = item.SubItems[2].Text;
                yil = item.SubItems[3].Text;
                sayfa = item.SubItems[4].Text;
                dil = item.SubItems[5].Text;
                yayinevi = item.SubItems[6].Text;
                durum = item.SubItems[7].Text;
                konu = item.SubItems[8].Text;

                //edit penceresini aç
                KitapGuncelle kitapfrm = new KitapGuncelle();
                kitapfrm.ShowDialog();
                oku();
            }
        }
    }
}
