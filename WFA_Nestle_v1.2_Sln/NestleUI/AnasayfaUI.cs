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
    public partial class AnasayfaUI : Form
    {
        NestleBLL.KontrolPaneli.KullaniciGirisi KullanHakkinda = new NestleBLL.KontrolPaneli.KullaniciGirisi();
        public AnasayfaUI()
        {
            InitializeComponent();
        }
        /// <summary>
        /// FORM SAĞ ÜST KÖŞESİNDEKİ X- KAPATMA TUSUNU PASİF HALE GETİRİR.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = 0x200;
                return myCp;
            }
        }
        private void personelİslemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Personel_IslemleriUI pi = new Personel_IslemleriUI();
            pi.Dock = DockStyle.Fill;
            pi.TopLevel = false;
            pi.FormBorderStyle = FormBorderStyle.None;
            AnasayfaPanel.Controls.Add(pi);
            pi.Show();
        }

        private void basvuruİslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Basvuru_IslemleriUI bi = new Basvuru_IslemleriUI();
            bi.Dock = DockStyle.Fill;
            bi.TopLevel = false;
            bi.FormBorderStyle = FormBorderStyle.None;
            AnasayfaPanel.Controls.Add(bi);
            bi.Show();
        }

        private void depoİslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Depo_IslemleriUI di = new Depo_IslemleriUI();
            di.Dock = DockStyle.Fill;
            di.TopLevel = false;
            di.FormBorderStyle = FormBorderStyle.None;
            AnasayfaPanel.Controls.Add(di);
            di.Show();
        }

        private void sevkiyatİslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sevkiyat_IslemleriUI si = new Sevkiyat_IslemleriUI();
            si.Dock = DockStyle.Fill;
            si.TopLevel = false;
            si.FormBorderStyle = FormBorderStyle.None;
            AnasayfaPanel.Controls.Add(si);
            si.Show();
        }

        private void satisIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Satis_IslemleriUI si = new Satis_IslemleriUI();
            si.Dock = DockStyle.Fill;
            si.TopLevel = false;
            si.FormBorderStyle = FormBorderStyle.None;
            AnasayfaPanel.Controls.Add(si);
            si.Show();
        }


        private void urunIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uretim_IslemleriUI ui = new Uretim_IslemleriUI();
            ui.Dock = DockStyle.Fill;
            ui.TopLevel = false;
            ui.FormBorderStyle = FormBorderStyle.None;
            AnasayfaPanel.Controls.Add(ui);
            ui.Show();
        }

        private void CikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnasayfaUI_Load(object sender, EventArgs e)
        {
            lblHakkimda.Text = KullanHakkinda.Hakkimda();
            lblSlogan.Text = KullanHakkinda.Slogan();
        }

        private void NestleTurkiyeMenuItem_Click(object sender, EventArgs e)
        {
            HakkindaUI hui = new HakkindaUI();
            hui.Dock = DockStyle.Fill;
            hui.TopLevel = false;
            hui.FormBorderStyle = FormBorderStyle.None;
            AnasayfaPanel.Controls.Add(hui);
            hui.Show();
        }
    }
}
