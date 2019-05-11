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
    public partial class Personel_IslemleriUI : Form
    {
        NestleBLL.Personel.Personel_Islemleri Personel = new NestleBLL.Personel.Personel_Islemleri();

        public Personel_IslemleriUI()
        {
            InitializeComponent();
        }

        private void Personel_IslemleriUI_Load(object sender, EventArgs e)
        {
            getir();
            DepartmanCmb();
        }

        private void getir()
        {
            dgvPersonelListesi.DataSource = Personel.PersonelBilgileri();
            dgvPersonelGoruntule.DataSource = Personel.PersonelBilgileri();
        }
   
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            tbl_PersonelBilgileri personel = new tbl_PersonelBilgileri
            {
                perAdi = tbxPersonelName.Text,
                perSoyadi = tbxPersonelSurname.Text,
                perDogumTarihi = dtpPersonelBirthDate.Value,
                perTcno = tbxPersonelTCNo.Text,
                perUnvan = tbxPersonelTitle.Text,
                perTelefon = tbxPersonelPhoneNumber.Text,
                perMail = tbxPersonelMail.Text,
                perUlke = tbxPersonelCountry.Text,
                peril = tbxPersonelCity.Text,
                perilce = tbxPersonelTown.Text,
                perAdres = tbxPersonelAddress.Text,
                perResim = tbxPersonelPic.Text,
                departman_id = Convert.ToInt32(cmbPersonelDepartment.SelectedValue)
            };
            Personel.Add(personel);
            getir();

        }

        private void btnPersonelDuzenle_Click(object sender, EventArgs e)
        {
            tbl_PersonelBilgileri personel = new tbl_PersonelBilgileri
            {
                per_id= (int)dgvPersonelListesi.CurrentRow.Cells[0].Value,
                perAdi = tbxPersonelName.Text,
                perSoyadi = tbxPersonelSurname.Text,
                perDogumTarihi = dtpPersonelBirthDate.Value,
                perTcno = tbxPersonelTCNo.Text,
                perUnvan = tbxPersonelTitle.Text,
                perTelefon = tbxPersonelPhoneNumber.Text,
                perMail = tbxPersonelMail.Text,
                perUlke = tbxPersonelCountry.Text,
                peril = tbxPersonelCity.Text,
                perilce = tbxPersonelTown.Text,
                perAdres = tbxPersonelAddress.Text,
                perResim = tbxPersonelPic.Text,
                departman_id = Convert.ToInt32(cmbPersonelDepartment.SelectedValue)
            };
            Personel.Update(personel);
            getir();
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
           

            int perID = (int)dgvPersonelListesi.CurrentRow.Cells[0].Value;
            Personel.Remove(perID);
               getir();
        }

        private void dgvPersonelListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxPersonelName.Text = dgvPersonelListesi.CurrentRow.Cells[1].Value.ToString();
            tbxPersonelSurname.Text = dgvPersonelListesi.CurrentRow.Cells[2].Value.ToString();
            dtpPersonelBirthDate.Value = Convert.ToDateTime(dgvPersonelListesi.CurrentRow.Cells[3].Value);
            tbxPersonelTCNo.Text = dgvPersonelListesi.CurrentRow.Cells[4].Value.ToString();
            tbxPersonelTitle.Text = dgvPersonelListesi.CurrentRow.Cells[5].Value.ToString();
            tbxPersonelPhoneNumber.Text = dgvPersonelListesi.CurrentRow.Cells[6].Value.ToString();
            tbxPersonelMail.Text = dgvPersonelListesi.CurrentRow.Cells[7].Value.ToString();
            tbxPersonelCountry.Text = dgvPersonelListesi.CurrentRow.Cells[8].Value.ToString();
            tbxPersonelCity.Text = dgvPersonelListesi.CurrentRow.Cells[9].Value.ToString();
            tbxPersonelTown.Text = dgvPersonelListesi.CurrentRow.Cells[10].Value.ToString();
            tbxPersonelAddress.Text = dgvPersonelListesi.CurrentRow.Cells[11].Value.ToString();
            tbxPersonelPic.Text = dgvPersonelListesi.CurrentRow.Cells[12].Value.ToString();
            cmbPersonelDepartment.Text = dgvPersonelListesi.CurrentRow.Cells[13].Value.ToString();
        }

        private void btnPersonelPicLoader_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            tbxPersonelPic.Text = dosyayolu;
        }

        private void DepartmanCmb()
        {
            cmbPersonelDepartment.DataSource = Personel.CmbDepartman();
            cmbPersonelDepartment.DisplayMember = "departmanAdi";
            cmbPersonelDepartment.ValueMember = "departman_id";
        }

        private void tbxPersonelAra_TextChanged(object sender, EventArgs e)
        {
            dgvPersonelGoruntule.DataSource = Personel.PersonelAra(tbxPersonelAra.Text);
        }

        private void dgvPersonelGoruntule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pbPersonelResim.ImageLocation = dgvPersonelGoruntule.CurrentRow.Cells[12].Value.ToString();
            pbPersonelResim.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private void cbPersonelAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPersonelAdi.Checked)
            {
                dgvPersonelGoruntule.DataSource = Personel.PersonelAdiSiralamaAZ();
                cbPersonelAdiZa.Enabled = false;
            }
            else if (cbPersonelAdiZa.Checked)
            {
                dgvPersonelGoruntule.DataSource = Personel.PersonelAdiSiralamaZA();
                cbPersonelAdi.Enabled = false;
            }
            else
            {
                cbPersonelAdi.Enabled = true;
                cbPersonelAdiZa.Enabled = true;
                getir();
            }
        }
    }
}
