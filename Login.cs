using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.LinkLabel;

namespace KutuphaneOtoGP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string loginp = "D://loginpage.csv";

        private void button1_Click(object sender, EventArgs e)
        {
            string[] read = File.ReadAllLines(loginp);
            foreach (string log in read)
            {
                string[] columns = log.Split(';');
                if (nameTXT.Text == columns[2])
                {
                    if (passTXT.Text == columns[3])
                    {
                        MessageBox.Show("Giriþ Baþarýlý");
                        AnaSayfa anasayfafrm = new AnaSayfa();
                        this.Hide();
                        anasayfafrm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tekrar Deneyiniz...");
                    }
                }

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signin signfrm = new signin();
            signfrm.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}