using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public static List<string[]> uyeBilgileri = new List<string[]>();
        public static int selectedValue;


        public void liste()
        {
            string read = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "AddUser.csv");
            string[] oku = File.ReadAllLines(read);
            if (oku.Length > 0)
            {
                string ilkSatir = listBox1.SelectedItem.ToString();
                selectedValue = listBox1.SelectedIndex;
                //ilkSatir = ilkSatir.Replace("  ", " ");
                //ilkSatir = ilkSatir.Replace("    ", " ");
                string[] parcalar = ilkSatir.Split(';');

                for (int i = 0; i < parcalar.Length; i++)
                {
                    uyeBilgileri.Add(parcalar);
                    tc = parcalar[0];
                    ad = parcalar[1];
                    soyad = parcalar[2];
                    tel = parcalar[3];
                    e_mail = parcalar[4];
                    adres = parcalar[5];
                }

            }
        }
        public void oku()
        {
            listBox1.Items.Clear();
            string read = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "AddUser.csv");
            read.Split(';');
            string[] filepath = File.ReadAllLines(read);
            for (int i = 0; i < filepath.Length; i++)
            {
                listBox1.Items.Add(filepath[i]);
            }
            //int satirSayisi = filepath.Length;
            //string[] tcNo = new string[satirSayisi];
            //string[] ad = new string[satirSayisi];
            //string[] soyad = new string[satirSayisi];
            //string[] tel = new string[satirSayisi];
            //string[] mail = new string[satirSayisi];
            //string[] adres = new string[satirSayisi];
            //for (int i = 0; i < satirSayisi; i++)
            //{
            //    string[] ayrilmis = filepath[i].Split(';');
            //    tcNo[i] = ayrilmis[0];
            //    ad[i] = ayrilmis[1];
            //    soyad[i] = ayrilmis[2];
            //    tel[i] = ayrilmis[3];
            //    mail[i] = ayrilmis[4];
            //    adres[i] = ayrilmis[5];

            //}





            //int maxtc = tcNo.Max(w => w.Length) + 1;
            //int maxad = ad.Max(w => w.Length) + 1;
            //int maxsoyad = soyad.Max(w => w.Length) + 1;
            //int maxtel = soyad.Max(w => w.Length) + 1;
            //int maxmail = soyad.Max(w => w.Length) + 1;
            //int maxadres = soyad.Max(w => w.Length) + 1;
            //for (int i = 0; i < satirSayisi; i++)
            //{
            //    string tccum = tcNo[i] + Strings.Space(maxtc - tcNo.Length);
            //    string adcum = ad[i] + Strings.Space(maxad - ad.Length);
            //    string soyadcum = soyad[i] + Strings.Space(maxsoyad - soyad.Length);
            //    string telcum = tel[i] + Strings.Space(maxtel - tel.Length);
            //    string mailcum = mail[i] + Strings.Space(maxmail - mail.Length);
            //    string adrescum = adres[i] + Strings.Space(maxadres - adres.Length);
            //    listBox1.Items.Add(tccum + adcum + soyadcum + telcum + mailcum + adrescum).ToString();
            //}




        }

        private void button1_Click(object sender, EventArgs e)
        {
            liste();
            Guncelle updfrm = new Guncelle();
            updfrm.ShowDialog();
            oku();
        }

        private void UyeListele_Load(object sender, EventArgs e)
        {
            oku();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}


