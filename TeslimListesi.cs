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
    public partial class TeslimListesi : Form
    {
        public TeslimListesi()
        {
            InitializeComponent();
        }
        string read = "D://Teslim.csv";

        private void TeslimListesi_Load(object sender, EventArgs e)
        {
            string[] oku = File.ReadAllLines(read);
            for (int i = 0; i < oku.Length; i++)
            {
                listBox1.Items.Add(oku[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
