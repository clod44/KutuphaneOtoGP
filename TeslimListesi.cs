using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace KutuphaneOtoGP
{
    public partial class TeslimListesi : Form
    {
        public TeslimListesi()
        {
            InitializeComponent();
        }
        public static string teslimatlarPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "Teslim.csv");
        public static string[] seciliTeslim = null;

        private void TeslimListesi_Load(object sender, EventArgs e)
        {
            button_onayla.Enabled = false;
            seciliTeslim = null;
        }

        private void button_teslimAra_Click(object sender, EventArgs e)
        {
            teslimat_filtrele();
        }

        private void teslimat_filtrele()
        {

            string teslimID = textBox_teslimId.Text.ToLower();
            string TC = textBox_TC.Text.ToLower();
            string kitapID = textBox_kitapID.Text.ToLower();
            listView_teslimatlar.Items.Clear();
            string[] teslimatSatirlari = File.ReadAllLines(teslimatlarPath);

            foreach (string teslimatSatir in teslimatSatirlari)
            {
                string[] veriler = teslimatSatir.Split(';');
                if (veriler.Length > 0)
                {
                    string veriTeslimatID = veriler[0].ToLower();
                    string veriTC = veriler[1].ToLower();
                    string veriKitapID = veriler[2].ToLower();
                    string veriBaslangıcTarihi = veriler[3].ToLower();
                    string veriTeslimatTarihi = veriler[4].ToLower();
                    string veriVerilisTarihi = veriler[5].ToLower();

                    bool listedeGoster = false;

                    if (
                        (veriVerilisTarihi != "0" && checkBox_teslimEdildi.Checked) ||
                        (veriVerilisTarihi == "0" && !checkBox_teslimEdildi.Checked)
                        )
                    {
                        if ((teslimID + TC + kitapID).Length == 0)
                            listedeGoster = true;
                        if (teslimID.Length > 0 && veriTeslimatID.Contains(teslimID))
                            listedeGoster = true;
                        if (TC.Length > 0 && veriTC.Contains(TC))
                            listedeGoster = true;
                        if (kitapID.Length > 0 && veriKitapID.Contains(kitapID))
                            listedeGoster = true;
                    }
                    else
                    {
                        listedeGoster = false;
                    }
                    if (checkBox_teslimBekleniyor.Checked && veriVerilisTarihi == "0")
                    {
                        listedeGoster = long.Parse(veriTeslimatTarihi) < DateTime.Now.Ticks;
                    }
                    if (listedeGoster)
                    {
                        ListViewItem item = new ListViewItem(veriler);
                        listView_teslimatlar.Items.Add(item);
                    }
                }
            }
        }

        private void listView_teslimatlar_DoubleClick(object sender, EventArgs e)
        {
            //secilen list iteminin degerlerini al
            if (listView_teslimatlar.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_teslimatlar.SelectedItems[0];
                //string dizisine çevir
                seciliTeslim = new string[selectedItem.SubItems.Count];
                for (int i = 0; i < seciliTeslim.Length; i++)
                {
                    seciliTeslim[i] = selectedItem.SubItems[i].Text;
                }

                //bilgileri göster
                label_teslimdetay.Text = string.Join(" - ", seciliTeslim);
                dateTimePicker_odunc.Value = new DateTime(long.Parse(seciliTeslim[3]));
                dateTimePicker_teslimEdilmesiGereken.Value = new DateTime(long.Parse(seciliTeslim[4]));
                if (seciliTeslim[5] == "0")
                {
                    dateTimePicker_teslim.Value = DateTime.Now;
                    label_teslimGunFark.Text = "TESLIM EDILMEDI";
                    button_onayla.Enabled = true;
                }
                else
                {
                    dateTimePicker_teslim.Value = new DateTime(long.Parse(seciliTeslim[5]));
                    label_teslimGunFark.Text = "teslim EDILDI";
                    button_onayla.Enabled = false;
                }
                int fark = (int)(dateTimePicker_teslimEdilmesiGereken.Value - dateTimePicker_teslim.Value).TotalDays;
                label_teslimGunFark.Text += " (" + fark + " gün)";
                tabControl1.SelectedTab = tabControl1.TabPages[1];
            }
        }

        private void button_onayla_Click(object sender, EventArgs e)
        {
            //1-teslim verisini güncelleyip teslim tarihini 
            //2-kitabın durumunu MEVCUT olarak güncelle


            //teslim verisini güncelle:
            string TeslimlerPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "Teslim.csv");

            if (File.Exists(TeslimlerPath))
            {
                //her satır 1 Teslim
                string[] satirlar = File.ReadAllLines(TeslimlerPath);

                //tüm teslimlere bak ve ID lerini karşılaştır:
                for (int i = 0; i < satirlar.Length; i++)
                {
                    string teslim = satirlar[i];
                    string[] teslimverileri = teslim.Split(";");
                    string teslimId = teslimverileri[0];

                    //eger idler eşit değilse bir sonrakine geç
                    if (teslimId != seciliTeslim[0])
                        continue;

                    //idler eşit ise:
                    //ilgili teslimin tarihini değiştir
                    teslimverileri[5] = DateTime.Now.Ticks.ToString();

                    //yeni kitap verilerini tüm kitapların verilerine kaydet
                    satirlar[i] = string.Join(";", teslimverileri);
                    MessageBox.Show("teslim durumu güncellendi");
                    //looptan çık
                    break;
                }

                //yeni tesimleri dosyaya kaydet
                File.WriteAllLines(TeslimlerPath, satirlar);
            }



            //kitabın durumunu güncelle
            string kitaplarPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "AddBook.csv");

            if (File.Exists(kitaplarPath))
            {
                //her satır 1 kitap
                string[] satirlar = File.ReadAllLines(kitaplarPath);

                //tüm kitaplara bak ve ID lerini karşılaştır:
                for (int i = 0; i < satirlar.Length; i++)
                {
                    string kitap = satirlar[i];
                    string[] kitapverileri = kitap.Split(";");
                    string kitapId = kitapverileri[0];

                    //eger idler eşit değilse bir sonrakine geç
                    if (kitapId != seciliTeslim[2])
                        continue;

                    //idler eşit ise:
                    //ilgili kitabın durumunu değiştir
                    kitapverileri[7] = "MEVCUT";

                    //yeni kitap verilerini tüm kitapların verilerine kaydet
                    satirlar[i] = string.Join(";", kitapverileri);
                    MessageBox.Show("Kitap durumu güncellendi");
                    //looptan çık
                    break;
                }
                //yeni kitaplığı dosyaya kaydet
                File.WriteAllLines(kitaplarPath, satirlar);
            }
            teslimat_filtrele();
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }
    }
}
