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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KutuphaneOtoGP
{
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }
        public static int selectedLine = 0;
        private void Personeller_Load(object sender, EventArgs e)
        {
            personelleriOku();
            textBox_username.Clear();
            textBox_username.Enabled = false;
            textBox_password.Clear();
            textBox_password.Enabled = false;
            textBox_aciklama.Clear();
            textBox_aciklama.Enabled = false;
            for (int i = 0;  i < checkedListBox_yetkiler.Items.Count; i++)
                checkedListBox_yetkiler.SetItemChecked(i, false);
            checkedListBox_yetkiler.Enabled = false;
            button_kaydet.Enabled = false;
            label_warning.Visible = true;

        }

        private void personelleriOku()
        {
            listView_personeller.Items.Clear();
            string personellerPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "Personeller.csv");
            string[] personeller = File.ReadAllLines(personellerPath);

            //her satır için
            foreach (string personel in personeller)
            {
                //satırı diziye çevir
                string[] veriler = personel.Split(';');
                if (veriler.Length > 0)
                {
                    //sadece 1.ve 3.veriyi göster. username ve açıklama
                    ListViewItem item = new ListViewItem(new string[] { veriler[0], veriler[2] });
                    item.Tag = veriler;
                    listView_personeller.Items.Add(item);
                }
            }
        }
        private void listView_personeller_DoubleClick(object sender, EventArgs e)
        {
            //secilen list iteminin degerlerini al
            if (listView_personeller.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_personeller.SelectedItems[0];
                selectedLine = selectedItem.Index;
                string[] veriler = selectedItem.Tag as string[];

                //tamamlama tabini güncelle
                textBox_username.Text = veriler[0];
                textBox_password.Text = veriler[1];
                textBox_aciklama.Text = veriler[2];

                // ilk 3 veriyi geç
                string[] yetkiler = veriler.Skip(3).ToArray();

                // yetkiler cehckbox listini güncelle
                for (int i = 0; i < yetkiler.Length && i < checkedListBox_yetkiler.Items.Count; i++)
                {
                    checkedListBox_yetkiler.SetItemChecked(i, yetkiler[i] == "1");
                }



                textBox_username.Enabled = true;
                textBox_password.Enabled = true;
                textBox_aciklama.Enabled = true;
                checkedListBox_yetkiler.Enabled = true;
                button_kaydet.Enabled = true;
                label_warning.Visible = false;
            }
            //sonraki tabi ac
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            string personellerPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "Personeller.csv");

            if (File.Exists(personellerPath))
            {
                string[] satirlar = File.ReadAllLines(personellerPath);

                if (satirlar.Length > 0)
                {
                    // Güncellenmiş verileri al
                    string[] guncellenmisVeriler = new string[checkedListBox_yetkiler.Items.Count + 3];
                    //username,password,aciklama
                    guncellenmisVeriler[0] = textBox_username.Text;
                    guncellenmisVeriler[1] = textBox_password.Text;
                    guncellenmisVeriler[2] = textBox_aciklama.Text;
                    //yetkileri 1 ve 0 olarak oku
                    for (int i = 0; i < checkedListBox_yetkiler.Items.Count; i++)
                    {
                        guncellenmisVeriler[i + 3] = checkedListBox_yetkiler.GetItemChecked(i) ? "1" : "0";
                    }

                    // İlgili satırdaki verileri güncelle
                    satirlar[selectedLine] = string.Join(";", guncellenmisVeriler);

                    // Dosyaya güncellenmiş verileri yaz
                    File.WriteAllLines(personellerPath, satirlar);

                    MessageBox.Show("personeller güncellendi!");
                    personelleriOku();
                }
            }
        }

        private void button_yeniHesap_Click(object sender, EventArgs e)
        {
            string personellerPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "Personeller.csv");

            string veri =
                "newuser;" +
                "newpassword;" +
                "needs a description;" +
                "0;" +
                "0;" +
                "0;" +
                "0;" + 
                "0;" +
                "0"
                ;
            StreamWriter Add = File.AppendText(personellerPath);
            Add.WriteLine(veri);
            Add.Close();

            MessageBox.Show("Yeni Personel Eklendi. Yetkilerden Aktif hale getirin");
            personelleriOku();
        }
    }
}
