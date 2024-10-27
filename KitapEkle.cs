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
            string read = "D://AddBook.csv";
            string[] lines = File.ReadAllLines(read);

            int lastLineNumber = lines.Length;

            string newLine = $"{lastLineNumber + 1}" + ID.Text; // Burada textBox1, girilen veriyi tutan TextBox kontrolüdür.

            using (StreamWriter sw = File.AppendText(read))
            {
                sw.Write(newLine + ";");
            }


            StreamWriter add = File.AppendText(read);
            add.Write(txtKitapAd.Text + ";");
            add.Write(txtYazar.Text + ";");
            add.Write(txtYil.Text + ";");
            add.Write(txtSayfa.Text + ";");
            add.Write(txtDil.Text + ";");
            add.Write(txtYayinevi.Text + ";");
            add.Write(textBox1.Text + ";");
            add.WriteLine(txtKonu.Text);
            add.Close();
            MessageBox.Show("Kitap Başarılı bir şekilde eklendi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
