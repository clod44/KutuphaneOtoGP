using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtoGP
{
    public partial class KitapTeslim : Form
    {
        public KitapTeslim()
        {
            InitializeComponent();
        }
        public string uye = "D://AddUser.csv";
        public string kitap = "D://AddBook.csv";
        public string okuu;
        public string[] columns;
        private void kitapara_TextChanged(object sender, EventArgs e)
        {
            var Streamreader = new StreamReader(kitap);
            string[] lines = File.ReadAllLines(kitap);
            string selectedLine = "";
            string selectedValue = kitapara.Text;

            // Seçilen öğeye göre ilgili satırı buluyoruz.
            foreach (string line in lines)
            {
                string[] columns = line.Split(';');
                if (columns[1] == selectedValue)
                {
                    selectedLine = line;
                    break;
                }

            }
            if (!string.IsNullOrEmpty(selectedLine))
            {
                columns = selectedLine.Split(';');

                kitapara.Text = columns[1];
                yazarTXT.Text = columns[2];
                dilTXT.Text = columns[5];
                label10.Text = columns[0];
                label14.Text = columns[7];
            }
            Streamreader.Close();
        }

        private void ara_TextChanged(object sender, EventArgs e)
        {
            var Streamreader = new StreamReader(uye);
            string[] lines = File.ReadAllLines(uye);
            string selectedLine = "";
            string selectedValue = ara.Text;

            // Seçilen öğeye göre ilgili satırı buluyoruz.
            foreach (string line in lines)
            {
                string[] columns = line.Split(';');
                if (columns[0] == selectedValue)
                {
                    selectedLine = line;
                    break;
                }


            }
            if (!string.IsNullOrEmpty(selectedLine))
            {
                string[] columns = selectedLine.Split(';');

                tcTXT.Text = columns[0];
                adTXT.Text = columns[1];
                soyadTXT.Text = columns[2];
                telTXT.Text = columns[3];
            }
        }

        private void btngun_Click(object sender, EventArgs e)
        {
            TimeSpan gunfarki = DateTime.Parse(iadeTXT.Text) - DateTime.Parse(TeslimTXT.Text);
            int gunhesap = gunfarki.Days;
            gunlbl.Text = gunhesap.ToString();
        }

        //void KitapGuncelle()
        //{
        //    //MessageBox.Show(columns.ToString());

        //    string kitapId = columns[0];
        //    string kitapAdi = columns[1];
        //    string kitapYazar = columns[2];
        //    string kitapYil = columns[3];
        //    string kitapSayfa = columns[4];
        //    string kitapDil = columns[5];
        //    string kitapYayinEvi = columns[6];
        //    string kitapDurum = "DOLU";
        //    string kitapKonu = columns[8];


        //    string dosyaYolu = "E://AddBook.csv"; // CSV dosya yolunu burada belirtin

        //    if (File.Exists(dosyaYolu))
        //    {
        //        string[] satirlar = File.ReadAllLines(dosyaYolu);
        //        if (satirlar.Length > 0)
        //        {
        //            // Güncellenmiş verileri al
        //            string[] guncellenmisVeriler = new string[9];
        //            guncellenmisVeriler[0] = kitapId;
        //            guncellenmisVeriler[1] = kitapAdi;
        //            guncellenmisVeriler[2] = kitapYazar;
        //            guncellenmisVeriler[3] = kitapYil;
        //            guncellenmisVeriler[4] = kitapSayfa;
        //            guncellenmisVeriler[5] = kitapDil;
        //            guncellenmisVeriler[6] = kitapYayinEvi;
        //            guncellenmisVeriler[7] = kitapDurum;
        //            guncellenmisVeriler[8] = kitapKonu;
        //            satirlar[Convert.ToInt32(kitapId)] = string.Join(";", guncellenmisVeriler);

        //            // Dosyaya güncellenmiş verileri yaz
        //            File.WriteAllLines(dosyaYolu, satirlar);

        //            MessageBox.Show("Veriler güncellendi!");

        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("CSV dosyası bulunamadı!");
        //    }
        //}

        void KitapGuncelle()
        {


            string kitapId = columns[0];
            string kitapAdi = columns[1];
            string kitapYazar = columns[2];
            string kitapYil = columns[3];
            string kitapSayfa = columns[4];
            string kitapDil = columns[5];
            string kitapYayinEvi = columns[6];
            string kitapDurum = "DOLU";
            string kitapKonu = columns[8];
            int kitapIdValue = Convert.ToInt32(kitapId);

            string dosyaYolu = "D://AddBook.csv";

            if (File.Exists(dosyaYolu))
            {

                string[] satirlar = File.ReadAllLines(dosyaYolu);
                if (satirlar.Length >= kitapIdValue)
                {
                    // Güncellenmiş verileri al
                    string[] guncellenmisVeriler = new string[9];
                    guncellenmisVeriler[0] = kitapId;
                    guncellenmisVeriler[1] = kitapAdi;
                    guncellenmisVeriler[2] = kitapYazar;
                    guncellenmisVeriler[3] = kitapYil;
                    guncellenmisVeriler[4] = kitapSayfa;
                    guncellenmisVeriler[5] = kitapDil;
                    guncellenmisVeriler[6] = kitapYayinEvi;
                    guncellenmisVeriler[7] = kitapDurum;
                    guncellenmisVeriler[8] = kitapKonu;
                    satirlar[Convert.ToInt32(kitapId) - 1] = string.Join(";", guncellenmisVeriler);

                    File.WriteAllLines(dosyaYolu, satirlar);

                    //MessageBox.Show("Veriler güncellendi!");
                }
                else
                {
                    MessageBox.Show("Kitap ID'si geçerli değil!");
                }
            }


        }

        private void teslim_Click(object sender, EventArgs e)
        {

        }

        private void KitapTeslim_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string oku = uye;
                okuu = kitap;
                string teslim = "D://Teslim.csv";
                if (columns[7] == null)
                {
                    return;
                }
                if (columns[7] == "DOLU")
                {
                    MessageBox.Show("Başka bir kitap seçiniz.");
                }
                else
                {


                    KitapGuncelle();

                    string[] lines = File.ReadAllLines(teslim);

                    int lastLineNumber = lines.Length;

                    string newLine = $"{lastLineNumber + 1} " + IDtxt.Text; // Burada textBox1, girilen veriyi tutan TextBox kontrolüdür.

                    using (StreamWriter sw = File.AppendText(teslim))
                    {
                        sw.Write(newLine + ";");
                    }

                    StreamWriter sww = File.AppendText(teslim);
                    sww.Write(tcTXT.Text + ";");
                    sww.Write(adTXT.Text + ";");
                    sww.Write(soyadTXT.Text + ";");
                    sww.Write(telTXT.Text + ";");
                    sww.Write(kitapara.Text + ";");
                    sww.Write(yazarTXT.Text + ";");
                    sww.Write(dilTXT.Text + ";");
                    sww.Write(gunlbl.Text + ";");
                    sww.Write(TeslimTXT.Text + ";");
                    sww.WriteLine(iadeTXT.Text);

                    sww.Close();
                    // Seçilen öğeye göre ilgili satırı buluyoruz.

                    var Streamreader = new StreamReader(kitap);
                    string[] liness = File.ReadAllLines(kitap);
                    string selectedLine = "";
                    string selectedValue = kitapara.Text;
                    foreach (string line in liness)
                    {
                        string[] columns = line.Split(';');
                        if (columns[1] == selectedValue)
                        {
                            StreamWriter yaz = File.AppendText(columns[7]);
                            yaz.Write("dolu");
                            yaz.Close();

                            break;
                        }
                    }
                    MessageBox.Show("Kitap Teslimi Başarıılı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Gerekli Doldurmaları Yapınız!!!");
            }


        }
    }

}
