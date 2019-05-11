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
    public partial class Uretim_IslemleriUI : Form
    {
        NestleBLL.Uretim.Urun_Islemleri Uretim = new NestleBLL.Uretim.Urun_Islemleri();
        public Uretim_IslemleriUI()
        {
            InitializeComponent();
        }

        private void Uretim_IslemleriUI_Load(object sender, EventArgs e)
        {
            UrunBilgisiGetir();
            cmbDepo();
            cmbUrunTur();
        }
        void UrunBilgisiGetir()
        {
            dgvUrunBilgisi.DataSource = Uretim.UrunBilgisi();
        }
        void cmbDepo()
        {
            cmbDepoAdi.DataSource = Uretim.cmbDepoAdi();
            cmbDepoAdi.DisplayMember = "depoAdi";
            cmbDepoAdi.ValueMember = "depo_id";
        }
        void cmbUrunTur()
        {
            cmbUrunTuru.DataSource = Uretim.cmbUrunTuru();
            cmbUrunTuru.DisplayMember = "uruntur_adi";
            cmbUrunTuru.ValueMember = "uruntur_id";
        }

        private void txtUrunSorgula_TextChanged(object sender, EventArgs e)
        {
            dgvUrunBilgisi.DataSource = Uretim.UrunSorgula(txtUrunSorgula.Text);
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            tbl_UrunBilgisi uretim = new tbl_UrunBilgisi
            {
                urun_adi = txtUrunAdi.Text,
                uruntur_id = (int)cmbUrunTuru.SelectedValue,
                urunUretimTarihi = dtpUrunTarihi.Value,
                urunFiyati = nudFiyat.Value,
                urunMiktari = (int)nudUrunAdet.Value,
                depo_id = (int)cmbDepoAdi.SelectedValue,
               
            };
            Uretim.Add(uretim);
            UrunBilgisiGetir();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            tbl_UrunBilgisi uretim = new tbl_UrunBilgisi
            {
                urun_id=(int)dgvUrunBilgisi.CurrentRow.Cells[0].Value,
                urun_adi = txtUrunAdi.Text,
                uruntur_id = (int)cmbUrunTuru.SelectedValue,
                urunUretimTarihi = dtpUrunTarihi.Value,
                urunFiyati = nudFiyat.Value,
                urunMiktari = (int)nudUrunAdet.Value,
                depo_id = (int)cmbDepoAdi.SelectedValue,

            };
            Uretim.Update(uretim);
            UrunBilgisiGetir();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            int ureID = (int)dgvUrunBilgisi.CurrentRow.Cells[0].Value;
            Uretim.Remove(ureID);
            UrunBilgisiGetir();
        }

        private void dgvUrunBilgisi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Text = dgvUrunBilgisi.CurrentRow.Cells[1].Value.ToString();
            cmbUrunTuru.Text = dgvUrunBilgisi.CurrentRow.Cells[2].Value.ToString();
            dtpUrunTarihi.Value= Convert.ToDateTime(dgvUrunBilgisi.CurrentRow.Cells[3].Value);
            nudFiyat.Value = (decimal)dgvUrunBilgisi.CurrentRow.Cells[4].Value;
            nudUrunAdet.Value = (int)dgvUrunBilgisi.CurrentRow.Cells[5].Value;
            cmbDepoAdi.Text= dgvUrunBilgisi.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
