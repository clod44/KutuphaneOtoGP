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
                StreamWriter Add = File.AppendText(FilePath);
                Add.Write(txtTC.Text + ";");
                Add.Write(txtAd.Text + ";");
                Add.Write(txtSoyad.Text + ";");
                Add.Write(txtTel.Text + ";");
                Add.Write(txtMail.Text + ";");
                Add.WriteLine(txtAdres.Text);
                Add.Close();
                MessageBox.Show("Üye Kaydı Tamamlandı.");
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
