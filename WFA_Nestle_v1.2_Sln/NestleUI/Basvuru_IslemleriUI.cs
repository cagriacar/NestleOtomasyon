using NestleBLL.EF_Context;
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
    public partial class Basvuru_IslemleriUI : Form
    {
        NestleBLL.Basvuru.Basvuru_Islemleri basvuru= new NestleBLL.Basvuru.Basvuru_Islemleri();

        public Basvuru_IslemleriUI()
        {
            InitializeComponent();
        }

        private void Basvuru_IslemleriUI_Load(object sender, EventArgs e)
        {
            getir();
        }

        private void getir()
        {
            dgvBasvuruBilgileri.DataSource = basvuru.BasvuruBilgileri();
            dgvBasvuruGoruntule.DataSource = basvuru.BasvuruBilgileri();
        }

        private void dgvBasvuruGoruntule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pbBasvuruPic.ImageLocation = dgvBasvuruGoruntule.CurrentRow.Cells[13].Value.ToString();
            pbBasvuruPic.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            txtBasvuruResim.Text = dosyayolu;
        }

        private void btnBasvuruEkle_Click(object sender, EventArgs e)
        {
            tbl_BasvuruForm ekleBasvuru = new tbl_BasvuruForm
            {
                basvuruAdi = txtBasvuruAd.Text,
                basvuruSoyadi = txtBasvuruSoyad.Text,
                basvuruDogumTarihi = dtpBasvuruDogumTarihi.Value,
                basvuruCinsiyet = cmbBasvuruCinsiyet.Text,
                basvuruTelefon = txtBasvuruTelefon.Text,
                basvuruMail = txtBasvuruEmail.Text,
                basvuruYabanciDil = txtBasvuruYabanciDil.Text,
                basvuruAskerlikDurumu = cmbBasvuruAskerlikDurumu.Text,
                basvuruMedeniDurum = cmbBasvuruMedeniDurum.Text,
                basvuruEgitim = cmbBasvuruEgitimDurumu.Text,
                basvuruDeneyim = txtBasvuruDeneyim.Text,
                basvuruAdres = txtBasvuruAdres.Text,
                basvuruResim = txtBasvuruResim.Text
            };
            basvuru.Add(ekleBasvuru);
            getir();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in tabPage1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
            }
        }

        private void btnBasvuruSil_Click(object sender, EventArgs e)
        {
            int basvuruID = (int)dgvBasvuruBilgileri.CurrentRow.Cells[0].Value;
            basvuru.Remove(basvuruID);
            getir();
        }

        private void dgvBasvuruBilgileri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBasvuruAd.Text = dgvBasvuruBilgileri.CurrentRow.Cells[1].Value.ToString();
            txtBasvuruSoyad.Text = dgvBasvuruBilgileri.CurrentRow.Cells[2].Value.ToString();
            dtpBasvuruDogumTarihi.Value = Convert.ToDateTime(dgvBasvuruBilgileri.CurrentRow.Cells[3].Value);
            cmbBasvuruCinsiyet.Text = dgvBasvuruBilgileri.CurrentRow.Cells[4].Value.ToString();
            txtBasvuruTelefon.Text = dgvBasvuruBilgileri.CurrentRow.Cells[5].Value.ToString();
            txtBasvuruEmail.Text = dgvBasvuruBilgileri.CurrentRow.Cells[6].Value.ToString();
            txtBasvuruYabanciDil.Text = dgvBasvuruBilgileri.CurrentRow.Cells[7].Value.ToString();
            cmbBasvuruAskerlikDurumu.Text = dgvBasvuruBilgileri.CurrentRow.Cells[8].Value.ToString();
            cmbBasvuruMedeniDurum.Text = dgvBasvuruBilgileri.CurrentRow.Cells[9].Value.ToString();
            cmbBasvuruEgitimDurumu.Text = dgvBasvuruBilgileri.CurrentRow.Cells[10].Value.ToString();
            txtBasvuruDeneyim.Text = dgvBasvuruBilgileri.CurrentRow.Cells[11].Value.ToString();
            txtBasvuruAdres.Text = dgvBasvuruBilgileri.CurrentRow.Cells[12].Value.ToString();
            txtBasvuruResim.Text = dgvBasvuruBilgileri.CurrentRow.Cells[13].Value.ToString();
        }

        private void btnBasvuruDuzenle_Click(object sender, EventArgs e)
        {
            tbl_BasvuruForm bs = new tbl_BasvuruForm
            {
                basvuru_id = (int)dgvBasvuruBilgileri.CurrentRow.Cells[0].Value,
                basvuruAdi = txtBasvuruAd.Text,
                basvuruSoyadi = txtBasvuruSoyad.Text,
                basvuruDogumTarihi = dtpBasvuruDogumTarihi.Value,
                basvuruCinsiyet = cmbBasvuruCinsiyet.Text,
                basvuruTelefon = txtBasvuruTelefon.Text,
                basvuruMail = txtBasvuruEmail.Text,
                basvuruYabanciDil = txtBasvuruYabanciDil.Text,
                basvuruAskerlikDurumu = cmbBasvuruAskerlikDurumu.Text,
                basvuruMedeniDurum = cmbBasvuruMedeniDurum.Text,
                basvuruEgitim = cmbBasvuruEgitimDurumu.Text,
                basvuruDeneyim = txtBasvuruDeneyim.Text,
                basvuruAdres = txtBasvuruAdres.Text,
                basvuruResim = txtBasvuruResim.Text
            };
            basvuru.Update(bs);
            getir();
        }

        private void txtBasvuruFiltre_TextChanged(object sender, EventArgs e)
        {
            dgvBasvuruGoruntule.DataSource = basvuru.BasvuruFiltre(txtBasvuruFiltre.Text);
        }

        private void cbBasvuruAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBasvuruAdi.Checked)
            {
                dgvBasvuruGoruntule.DataSource = basvuru.BasvuruSiralaAZ();
                cbBasvuruAdiZa.Enabled = false;
            }
            else if (cbBasvuruAdiZa.Checked)
            {
                dgvBasvuruGoruntule.DataSource = basvuru.BasvuruSiralaZA();
                cbBasvuruAdi.Enabled = false;
            }
            else
            {
                cbBasvuruAdi.Enabled = true;
                cbBasvuruAdiZa.Enabled = true;
                getir();
            }
        }
    }
}
