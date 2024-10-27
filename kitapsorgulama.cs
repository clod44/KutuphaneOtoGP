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

namespace KutuphaneOtoGP
{
    public partial class kitapsorgulama : Form
    {
        public kitapsorgulama()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string arananMetin = ara.Text.ToLower();

            listBox1.Items.Clear();
            string[] read = File.ReadAllLines(oku);
            foreach (var value in read)
            {
                string listeElemani = value.ToLower();

                if (listeElemani.Contains(arananMetin))
                {
                    listBox1.Items.Add(value.Replace(";", " "));
                }
            }
        }
        string oku = "D://AddBook.csv";
        private void kitapsorgulama_Load(object sender, EventArgs e)
        {
            string[] read = File.ReadAllLines(oku);
            for (int i = 0; i < read.Length; i++)
            {
                listBox1.Items.Add(read[i].Replace(";", " "));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().ToLower().Contains(ara.Text.ToLower()))
                {
                    listBox1.SetSelected(i, true);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
