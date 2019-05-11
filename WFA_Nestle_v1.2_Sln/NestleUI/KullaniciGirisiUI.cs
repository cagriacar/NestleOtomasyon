using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestleUI
{
    public partial class KullaniciGirisiUI : Form
    {
        NestleBLL.KontrolPaneli.KullaniciGirisi Kullanici_Islemleri = new NestleBLL.KontrolPaneli.KullaniciGirisi();
        public KullaniciGirisiUI()
        {
            InitializeComponent();
        }
        void GirisKontrol(string Kullanici, string sifre)
        {
            bool dogruMu = Kullanici_Islemleri.KullaniciGiris(Kullanici.ToLower(),sifre);
            if (dogruMu)
            {
                this.Hide();
                AnasayfaUI anaForm = new AnasayfaUI();
                anaForm.Show();
            }

            else
                {
                lblSifreKontrol.Text = "Kullanıcı Adı veya Parola Yanlıştır.".ToUpper() ;
                txtKadi.Clear();
                txtParola.Clear();
                }
        }
    private void btnKulllaniciGiris_Click(object sender, EventArgs e)
    {
            GirisKontrol(txtKadi.Text,txtParola.Text);
    }

        private void pbGoster_MouseHover(object sender, EventArgs e)
        {
            txtParola.PasswordChar = '\0';
        }

        private void pbGoster_MouseLeave(object sender, EventArgs e)
        {
            txtParola.PasswordChar = '*';
        }
    }
}
