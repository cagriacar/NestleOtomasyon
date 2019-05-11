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
    public partial class Sevkiyat_IslemleriUI : Form
    {
        NestleBLL.Sevkiyat.Sevkiyat_Islemleri Sevkiyat = new NestleBLL.Sevkiyat.Sevkiyat_Islemleri();
        public Sevkiyat_IslemleriUI()
        {
            InitializeComponent();
        }

        private void Sevkiyat_IslemleriUI_Load(object sender, EventArgs e)
        {
            BilgileriDoldur();
        }
        void BilgileriDoldur()
        {
            dgvSevkiyat.DataSource= Sevkiyat.SevkiyatBilgileri();


            cmbFirmaAdi.DataSource = Sevkiyat.cmbFirma();
            cmbFirmaAdi.DisplayMember = "FirmaAdi";
            cmbFirmaAdi.ValueMember = "satis_id";


            cmbSevkiyatTuru.DataSource = Sevkiyat.cmbSevkiyatTuru();
            cmbSevkiyatTuru.DisplayMember = "lojistikTuru";
            cmbSevkiyatTuru.ValueMember = "lojistik_id";


            cmbUrunAdi.DataSource = Sevkiyat.cmbUrunAdi();
            cmbUrunAdi.DisplayMember = "urun_adi";
            cmbUrunAdi.ValueMember = "urun_id";
        }

        private void btnSevkiyatTamamla_Click(object sender, EventArgs e)
        {
            tbl_Sevkiyat sevkiyat = new tbl_Sevkiyat
            {
                satis_id = (int)cmbFirmaAdi.SelectedValue,
                lojistik_id = (int)cmbSevkiyatTuru.SelectedValue,  
                urun_id = (int)cmbUrunAdi.SelectedValue,
                sevAdres=txtSevkiyatAdres.Text

            };
            Sevkiyat.Add(sevkiyat);
            BilgileriDoldur();
        }

        private void btnSevDuzenle_Click(object sender, EventArgs e)
        {
            tbl_Sevkiyat sevkiyat = new tbl_Sevkiyat
            {
                sev_id = (int)dgvSevkiyat.CurrentRow.Cells[0].Value,

                satis_id = (int)cmbFirmaAdi.SelectedValue,
                lojistik_id = (int)cmbSevkiyatTuru.SelectedValue,
                urun_id = (int)cmbUrunAdi.SelectedValue,
                sevAdres = txtSevkiyatAdres.Text

            };
            Sevkiyat.Update(sevkiyat);
            BilgileriDoldur();
        }

        private void btnSevSil_Click(object sender, EventArgs e)
        {

            int sevID = (int)dgvSevkiyat.CurrentRow.Cells[0].Value;
            Sevkiyat.Remove(sevID);
            BilgileriDoldur();
        }

        private void dgvSevkiyat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbFirmaAdi.Text = dgvSevkiyat.CurrentRow.Cells[1].Value.ToString();
            cmbSevkiyatTuru.Text = dgvSevkiyat.CurrentRow.Cells[2].Value.ToString();
            cmbUrunAdi.Text = dgvSevkiyat.CurrentRow.Cells[3].Value.ToString();
            txtSevkiyatAdres.Text = dgvSevkiyat.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
