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

        string personellerPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar", "Personeller.csv");

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(personellerPath))
            {
                MessageBox.Show("Personal bilgi dosyası bulunmamadı. gerekliDosyalar>Personeller.csv");
                return;
            }

            string[] personeller = File.ReadAllLines(personellerPath);


            string password = null;
            string[] geciciUser = new string[8];
            foreach (string personel in personeller)
            {
                string[] veriler = personel.Split(';');
                if (veriler.Length != 0 && veriler.Length != 8)
                {
                    MessageBox.Show("personel dosyası "+ string.Join(" - ",veriler) + " bozuk.");
                }
                                                    

                if (nameTXT.Text == veriler[0])
                {
                    //user bulundu. şifresini kaydet.
                    password = veriler[1];
                    geciciUser = veriler;
                    break;
                }
            }

            //kayıtlı şifre yok yani user bulunamamış.
            if (password == null)
            {
                MessageBox.Show("User yok.");
                return;
            }
            else
            {
                //user bulunduysa sifreyi karsılastır.
                if (password != passTXT.Text)
                {
                    MessageBox.Show("şifre hatalı");
                    return;                           //çık
                }

                MessageBox.Show("Giriş Başarılı");
                AnaSayfa.personel = geciciUser;
                AnaSayfa anasayfafrm = new AnaSayfa();
                anasayfafrm.ShowDialog();
                this.Close();
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signin signfrm = new signin();
            signfrm.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            /*
            gerekli dosyaların varlığını kontrol et. yoksa oluştur.!!!!!!!!!!!
                             
            kutuphaneotogp.exe
            gerekliDosyalar
            - Personeller.csv
            - AddBook.csv
            - AddUser.csv
            -Teslim.csv
            */

            string gerekliDosyalar = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gerekliDosyalar");
            if (!Directory.Exists(gerekliDosyalar))
            {
                Directory.CreateDirectory(gerekliDosyalar);
                MessageBox.Show("veritabanı bulunamadı. gerekliDosyalar Klasörü oluşturuldu ");
            }
            string personeller = Path.Combine(gerekliDosyalar, "Personeller.csv");
            if (!File.Exists(personeller))
            {
                File.Create(personeller).Close();
                StreamWriter Add = File.AppendText(personeller);
                Add.WriteLine("a;a;default admin hesabı;1;1;1;1;1");
                Add.Close();
                MessageBox.Show("personel hesapları dosyası bulunamadı. oluşturuldu. username:'a' password:'a' ");
            }
            string addbook = Path.Combine(gerekliDosyalar, "AddBook.csv");
            if (!File.Exists(addbook))
            {
                File.Create(addbook).Close();
                MessageBox.Show("kitaplar dosyası bulunamadı. oluşturuldu. ");
            }
            string adduser = Path.Combine(gerekliDosyalar, "AddUser.csv");
            if (!File.Exists(adduser))
            {
                File.Create(adduser).Close(); 
                MessageBox.Show("üyeler dosyası bulunamadı. oluşturuldu. ");
            }
            string teslim = Path.Combine(gerekliDosyalar, "Teslim.csv");
            if (!File.Exists(teslim))
            {
                File.Create(teslim).Close();
                MessageBox.Show("teslim dosyası bulunamadı. oluşturuldu. ");
            }
        }
    }
}