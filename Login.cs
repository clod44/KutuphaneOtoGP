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

        string loginp = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "loginpage.csv");

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(loginp))
            {
                MessageBox.Show("Login file not found.");
                return;
            }

            string[] lines = File.ReadAllLines(loginp);

            foreach (string log in lines)
            {
                string[] columns = log.Split(';');
                if (columns.Length != 2)
                {
                    MessageBox.Show("Incorrect file format.");
                    continue;
                }

                string username = columns[0];
                string password = columns[1];

                if (nameTXT.Text == username && passTXT.Text == password)
                {
                    MessageBox.Show("Giriş Başarılı");
                    AnaSayfa anasayfafrm = new AnaSayfa();
                    this.Hide();
                    anasayfafrm.ShowDialog();
                    return;
                }
            }

            MessageBox.Show("Tekrar Deneyiniz...");
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