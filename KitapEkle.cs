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
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "AddBook.csv");
            string[] lines = File.ReadAllLines(FilePath);

            int lastLineNumber = lines.Length;

            //yemi kitap ids otomatik hesaplanır. son satır indexi + 1
            int id = lastLineNumber + 1; 
            string veri =
                id + ";" +
                txtKitapAd.Text + ";" +
                txtYazar.Text + ";" +
                txtYil.Text + ";" +
                txtSayfa.Text + ";" +
                txtDil.Text + ";" +
                txtYayinevi.Text + ";" +
                textBox1.Text + ";" +
                txtKonu.Text;

            StreamWriter Add = File.AppendText(FilePath);
            Add.WriteLine(veri);
            Add.Close();

            MessageBox.Show("Kitap Başarılı bir şekilde eklendi.");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
