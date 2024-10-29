using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace KutuphaneOtoGP
{
    public partial class UyeListele : Form
    {
        public UyeListele()
        {
            InitializeComponent();
        }


        public static string tc, ad, soyad, e_mail, adres, tel;
        public static int selectedLine = 0;

        private void UyeListele_Load(object sender, EventArgs e)
        {
            oku();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void oku()
        {
            listView1.Items.Clear();
            string read = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "AddUser.csv");
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


        //iki kere tıklandığında edit penceresini aç
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listView1.HitTest(e.Location).Item;

            if (item != null)
            {
                if (item.SubItems.Count == 0) return;
                //değerleri geçici olarak elinde tut
                selectedLine = listView1.Items.IndexOf(item);
                tc = item.SubItems[0].Text;
                ad = item.SubItems[1].Text;
                soyad = item.SubItems[2].Text;
                tel = item.SubItems[3].Text;
                e_mail = item.SubItems[4].Text;
                adres = item.SubItems[5].Text;

                //edit penceresini aç
                Guncelle updfrm = new Guncelle();
                updfrm.ShowDialog();
                oku();
            }
        }


    }

}


