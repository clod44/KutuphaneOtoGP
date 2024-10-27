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
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            StreamWriter sign = File.AppendText("D://loginpage.csv");
            sign.Write(txtName.Text + ";");
            sign.Write(txtSurname.Text + ";");
            sign.Write(txtUsername.Text + ";");
            sign.Write(txtPassw.Text + ";");
            sign.WriteLine(txtMail.Text);
            sign.Close();
            MessageBox.Show("Kayıt Başarıyla Tamamlandı.");
        }


    }
}
