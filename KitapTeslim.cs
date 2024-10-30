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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KutuphaneOtoGP
{
    public partial class KitapTeslim : Form
    {
        public KitapTeslim()
        {
            InitializeComponent();
        }
        public string uyelerPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "AddUser.csv");
        public string kitaplarPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "AddBook.csv");
        public static string[] seciliUye = null;
        public static string[] seciliKitap = null;
        private void KitapTeslim_Load(object sender, EventArgs e)
        {
            //datepickerları güncelle
            dateTimePicker_bugun.Value = DateTime.Now;
            dateTimePicker_teslimTarih.MinDate = dateTimePicker_bugun.Value;
            //secili user ve kirabu sıfırla
            seciliUye = null;
            seciliKitap = null;
            kitaplariFiltrele();
            uyeleriFiltrele();
        }

        private void uyeleriFiltrele()
        {
            //hep küçük harf kullan ki karşılaştırmada sıkıntı çıkmasın
            string TC = textBox_TC.Text.ToLower();
            string Ad = textBox_Ad.Text.ToLower();
            string Soyad = textBox_Soyad.Text.ToLower();
            string Telefon = textBox_Telefon.Text.ToLower();
            string Email = textBox_Email.Text.ToLower();

            //uyeleri oku
            listView_uyeler.Items.Clear();
            string[] filepath = File.ReadAllLines(uyelerPath);

            //her satır için
            foreach (string line in filepath)
            {

                //satırı diziye çevir
                string[] veriler = line.Split(';');
                if (veriler.Length > 0)
                {
                    /*
                    id
                    ad
                    yazar
                    yıl
                    sayfa
                    dil
                    yayınevi   
                    konu
                    durum
                    */

                    //önce verilere bak ki yazıdımız şeyleri içeriyormu diye
                    string veriTC = veriler[0].ToLower();
                    string veriAd = veriler[1].ToLower();
                    string veriSoyad = veriler[2].ToLower();
                    string veriTelefon = veriler[3].ToLower();
                    string veriEmail = veriler[4].ToLower();

                    bool listedeGoster = false;
                    if (TC.Length > 0 && veriTC.Contains(TC))
                        listedeGoster = true;

                    if (Ad.Length > 0 && veriAd.Contains(Ad))
                        listedeGoster = true;

                    if (Soyad.Length > 0 && veriSoyad.Contains(Soyad))
                        listedeGoster = true;

                    if (Telefon.Length > 0 && veriTelefon.Contains(Telefon))
                        listedeGoster = true;

                    if (Email.Length > 0 && veriEmail.Contains(Email))
                        listedeGoster = true;
                    if ((TC + Ad + Soyad + Telefon + Email).Length == 0)
                        listedeGoster = true;
                        
                    //herhangi bir veri benziyorsa göster
                        if (listedeGoster)
                    {
                        ListViewItem item = new ListViewItem(veriler);
                        listView_uyeler.Items.Add(item);
                    }
                }
            }
        }
        private void kitaplariFiltrele()
        {
            string kitapID = textBox_kitapId.Text.ToLower();
            string kitapAd = textBox_kitapAd.Text.ToLower();
            string kitapYazar = textBox_kitapYazar.Text.ToLower();
            string kitapBaskıYili = textBox_kitapBaskiYili.Text.ToLower();
            string kitapDil = textBox_kitapDil.Text.ToLower();
            string kitapYayinevi = textBox_kitapYayinevi.Text.ToLower();
            string kitapDurum = textBox_kitapDurum.Text.ToLower();

            listView_kitaplar.Items.Clear();
            string[] filepath = File.ReadAllLines(kitaplarPath);

            foreach (string line in filepath)
            {
                string[] veriler = line.Split(';');
                if (veriler.Length > 0)
                {
                    string veriKitapID = veriler[0].ToLower();
                    string veriKitapAd = veriler[1].ToLower();
                    string veriKitapYazar = veriler[2].ToLower();
                    string veriBaskiYili = veriler[3].ToLower();
                    string veriDil = veriler[4].ToLower();
                    string veriYayinevi = veriler[5].ToLower();
                    string veriDurum = veriler[7].ToLower();

                    bool listedeGoster = false;

                    if (kitapID.Length > 0 && veriKitapID.Contains(kitapID))
                        listedeGoster = true;

                    if (kitapAd.Length > 0 && veriKitapAd.Contains(kitapAd))
                        listedeGoster = true;

                    if (kitapYazar.Length > 0 && veriKitapYazar.Contains(kitapYazar))
                        listedeGoster = true;

                    if (kitapBaskıYili.Length > 0 && veriBaskiYili.Contains(kitapBaskıYili))
                        listedeGoster = true;

                    if (kitapDil.Length > 0 && veriDil.Contains(kitapDil))
                        listedeGoster = true;

                    if (kitapYayinevi.Length > 0 && veriYayinevi.Contains(kitapYayinevi))
                        listedeGoster = true;

                    if (kitapDurum.Length > 0 && veriDurum.Contains(kitapDurum))
                        listedeGoster = true;
                    
                    if ((kitapID + kitapAd + kitapYazar + kitapBaskıYili + kitapDil + kitapYayinevi + kitapDurum).Length == 0) 
                        listedeGoster = true;

                    if (listedeGoster)
                    {
                        ListViewItem item = new ListViewItem(veriler);
                        listView_kitaplar.Items.Add(item);
                    }
                }
            }
        }


        private void btn_uyeAra_Click(object sender, EventArgs e)
        {
            uyeleriFiltrele();
        }

        private void button_kitapAra_Click(object sender, EventArgs e)
        {
            kitaplariFiltrele();
        }

        private void dateTimePicker_teslimTarih_ValueChanged(object sender, EventArgs e)
        {
            DateTime baslangic = dateTimePicker_bugun.Value;
            DateTime teslim = dateTimePicker_teslimTarih.Value;
            int gunFarkı = (int)(teslim - baslangic).TotalDays;
            label_teslimGunu.Text = gunFarkı.ToString();
        }

        private void listView_uyeler_DoubleClick(object sender, EventArgs e)
        {
            //secilen list iteminin degerlerini al
            if (listView_uyeler.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_uyeler.SelectedItems[0];
                seciliUye = new string[]
                {
                    selectedItem.SubItems[0].Text,   //tc
                    selectedItem.SubItems[1].Text,   //ad
                    selectedItem.SubItems[2].Text,   //soyad
                    selectedItem.SubItems[3].Text,   //telefon
                    selectedItem.SubItems[4].Text,   //email
                    selectedItem.SubItems[5].Text,   //adres
                };

                //tamamlama tabini güncelle
                label_uye.Text = string.Join(" - ", seciliUye);

                //sonraki tabi ac
                tabControl1.SelectedTab = tabControl1.TabPages[1];
            }
        }
        private void listView_kitaplar_DoubleClick(object sender, EventArgs e)
        {

            //secilen list iteminin degerlerini al
            if (listView_kitaplar.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_kitaplar.SelectedItems[0];
                seciliKitap = new string[]
                {
                    selectedItem.SubItems[0].Text,   //id
                    selectedItem.SubItems[1].Text,   //ad
                    selectedItem.SubItems[2].Text,   //yazar
                    selectedItem.SubItems[3].Text,   //baskı yılı  
                    selectedItem.SubItems[4].Text,   //dil
                    selectedItem.SubItems[5].Text,   //yayınevi
                    selectedItem.SubItems[6].Text,   //durum
                };

                //tamamlama tabini güncelle
                label_kitap.Text = string.Join(" - ", seciliKitap);

                //sonraki tabi ac
                tabControl1.SelectedTab = tabControl1.TabPages[2];
            }
        }

        private void button_onayla_Click(object sender, EventArgs e)
        {

            //kitap ve user seçilmediyse çık:
            if (seciliUye == null || seciliKitap == null)
            {
                MessageBox.Show("Uye yada kitap seçili değil!");
                return;
            }


            //ödünç islemini yap:
            //1-ödünç kaydı oluştur
            //2-kitabın durumunu güncelle

            //ödünç kaydı oluşturma:
            string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "Teslim.csv");
            string[] lines = File.ReadAllLines(FilePath);
            int lastLineNumber = lines.Length;
            //yeni teslim ids otomatik hesaplanır. son satır indexi + 1
            int teslimId = lastLineNumber + 1;
            string veri =
                teslimId + ";" +      //teslim id
                seciliUye[0] + ";" +  //uye id(TC)
                seciliKitap[0] + ";" + //kitap id                                                  
                dateTimePicker_bugun.Value.Ticks + ";" + //baslangıc zamanı (9123684914 gibi bişey)
                dateTimePicker_teslimTarih.Value.Ticks + ";" + //teslimzamanı (9423684914 gibi bişey)
                0  //uyenin kitabı teslim ettiği zaman (henuz etmedi)
                ;

            StreamWriter Add = File.AppendText(FilePath);
            Add.WriteLine(veri);
            Add.Close();
            MessageBox.Show("Kitap Teslim kaydı oluşturuldu");




            //kitabın durmunu guncelle
            string dosyaYolu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "AddBook.csv");

            if (File.Exists(dosyaYolu))
            {
                //her satır 1 kitap
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                //tüm kitaplara bak ve ID lerini karşılaştır:
                for (int i = 0; i < satirlar.Length; i++)
                {
                    string kitap = satirlar[i];
                    string[] kitapverileri = kitap.Split(";");
                    string kitapId = kitapverileri[0];

                    //eger idler eşit değilse bir sonrakine geç
                    if (kitapId != seciliKitap[0])
                        continue;

                    //idler eşit ise:
                    //ilgili kitabın durumunu değiştir
                    kitapverileri[7] = "ODUNC VERILDI";

                    //yeni kitap verilerini tüm kitapların verilerine kaydet
                    satirlar[i] = string.Join(";", kitapverileri);
                    MessageBox.Show("Kitap durumu güncellendi");
                    //looptan çık
                    break;
                }

                //yeni kitaplığı dosyaya kaydet
                File.WriteAllLines(dosyaYolu, satirlar);
                this.Close();
            }
        }
    }

}
