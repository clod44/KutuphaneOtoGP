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
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {

            try
            {

                string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "AddUser.csv");
                string veri = 
                    txtTC.Text + ";" +
                    txtAd.Text + ";" +
                    txtSoyad.Text + ";" +
                    txtTel.Text + ";" +
                    txtMail.Text + ";" +
                    txtAdres.Text
                    ;
                StreamWriter Add = File.AppendText(FilePath);
                Add.WriteLine(veri);
                Add.Close();

                MessageBox.Show("Üye Kaydı Tamamlandı.");
                
                txtTC.Clear();
                txtAd.Clear();
                txtSoyad.Clear();
                txtTel.Clear();
                txtMail.Clear();
                txtAdres.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Değerleri Doğru Bir şekilde giriniz.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
