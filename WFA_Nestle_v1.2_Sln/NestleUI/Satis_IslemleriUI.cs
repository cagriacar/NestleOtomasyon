using NestleBLL.EF_Context;
using System;
using System.Collections;
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
    public partial class Satis_IslemleriUI : Form
    {
        NestleBLL.Satis.Satis_Islemleri Satis = new NestleBLL.Satis.Satis_Islemleri();
        NestleBLL.Satis.Teklif_İslemleri.Teklif_İslemleri Teklif = new NestleBLL.Satis.Teklif_İslemleri.Teklif_İslemleri();
        public Satis_IslemleriUI()
        {
            InitializeComponent();
        }
        private void btnTeklifVer_Click(object sender, EventArgs e)
        {
            btnKayitEkle.Enabled = true;

            AnasayfaUI a = new AnasayfaUI();
            tabControl1.SelectedTab=tabPage1;
        }

        private void Satis_IslemleriUI_Load(object sender, EventArgs e)
        {
            SatisBilgileri();
            TeklifBilgileri();
            cmbSatisDurumu();
            cmbUrunBilgisi();

            


        }
        void ToplamTutar()
        {
            int satisAdet = (int)nudSatAdet.Value;
            int urunFiyat = (int)cmbUrun.SelectedValue;

            lblToplamTutar.Text = Satis.toplamTutar(satisAdet, urunFiyat)+" TL";
        }
        void SatisBilgileri()
        {
            dgvSatis.DataSource=Satis.SatisBilgisi();
        }
        void TeklifBilgileri()
        {
            dgvTeklifGoruntule.DataSource = Teklif.TeklifBilgisi();
            dgvTeklifBilgi.DataSource = Teklif.TeklifBilgisi();

        }
        void cmbTeklifSatis()
        {

            try
            {
                if (cmbUrun.SelectedIndex != -1)
                {
                    int deger = Satis.cmbUrunStokBilgisi((int)cmbTeklifUrun.SelectedValue);

                    ArrayList liste = new ArrayList();
                    for (int i = 1; i <= deger; i++)
                    {
                        liste.Add(i);
                    }
                    cmbTeklifSatisMiktari.DataSource = liste;
                }

            }
            catch (Exception)
            {


            }
        }
        void cmbSatisDurumu()
        {
            cmbSatis.DataSource = Satis.cmbSatisDurum();
            cmbSatis.DisplayMember = "satisDurumu";
            cmbSatis.ValueMember = "satisDurumu_id";
        }
        void cmbUrunBilgisi()
        {
          
                cmbUrun.DataSource = Satis.cmbUrunBilgi();
                cmbUrun.DisplayMember = "urun_adi";
                cmbUrun.ValueMember = "urun_id";

            cmbTeklifUrun.DataSource = Satis.cmbUrunBilgi();
            cmbTeklifUrun.DisplayMember = "urun_adi";
            cmbTeklifUrun.ValueMember = "urun_id";

       



        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            if (cmbSatis.Text=="Teklif Ver")
            {
                MessageBox.Show("Kayıt Eklemeden Önce Teklif Veriniz!");
                btnTeklifVer.Enabled = true;
                btnKayitEkle.Enabled = false;
            }
            else
            {
                tbl_Satis satis = new tbl_Satis
                {
                    FirmaAdi = txtFirmaAdi.Text,
                    SatisTarihi = Convert.ToDateTime(dtpSatisTarihi.Value),
                    TeslimAdresi = txtAdres.Text,
                    TeslimSehir = txtil.Text,
                    TeslimUlke = txtUlke.Text,
                    TeslimTarihi = Convert.ToDateTime(dtpTeslimTarihi.Value),
                    urun_id = (int)cmbUrun.SelectedValue,
                    satAdet = (int)nudSatAdet.Value,
                    satisDurumu_id = (int)cmbSatis.SelectedValue,
                    SatisTutari=Convert.ToDecimal(lblToplamTutar.Text)
                };
                Satis.Add(satis);
                SatisBilgileri();
            }
        }

        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                nudStokBilgi.Value = Satis.cmbUrunStokBilgisi((int)cmbUrun.SelectedValue);
                nudSatAdet.Maximum = nudStokBilgi.Value;
                if (nudStokBilgi.Value!=0)
                {
                    nudSatAdet.Enabled = true;
                    
                }
             
                ToplamTutar();
            }
            catch (Exception)
            {
            }
        }

        private void nudSatAdet_ValueChanged(object sender, EventArgs e)
        {
            ToplamTutar();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            tbl_Satis satis = new tbl_Satis
            {
                satis_id = (int)dgvSatis.CurrentRow.Cells[0].Value,
                FirmaAdi = txtFirmaAdi.Text,
                TeslimAdresi = txtAdres.Text,
                TeslimSehir = txtil.Text,
                TeslimUlke = txtUlke.Text,
                TeslimTarihi = dtpTeslimTarihi.Value,
                

            };
            Satis.Update(satis);
            SatisBilgileri();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int satID = (int)dgvSatis.CurrentRow.Cells[0].Value;
            Satis.Remove(satID);
            SatisBilgileri();
        }

        private void dgvSatis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFirmaAdi.Text = dgvSatis.CurrentRow.Cells[1].Value.ToString();
           
            txtAdres.Text= dgvSatis.CurrentRow.Cells[3].Value.ToString();
            txtil.Text= dgvSatis.CurrentRow.Cells[4].Value.ToString();
            txtUlke.Text= dgvSatis.CurrentRow.Cells[5].Value.ToString();
            dtpTeslimTarihi.Value = Convert.ToDateTime(dgvSatis.CurrentRow.Cells[6].Value);
       


        }

        private void txtMusteriSorgula_TextChanged(object sender, EventArgs e)
        {
            dgvSatis.DataSource = Satis.SatisSorgula(txtMusteriSorgula.Text);
        }

 

        private void btnTeklifKayit_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Teklif teklif = new tbl_Teklif
                {
                    teklifNo = txtTeklifNo.Text,
                    tekFirmaAdi = txtTeklifFirma.Text,
                    urun_id = (int)cmbTeklifUrun.SelectedValue,
                    tekUrunMiktar = (int)cmbTeklifSatisMiktari.SelectedValue,
                    teklifTutar = Convert.ToDecimal(txtTeklifTutar.Text),
                };
                Teklif.Add(teklif);
                TeklifBilgileri();
            }
            catch (Exception)
            {

                MessageBox.Show("TeklifNo Benzersiz girilmelidir.");
                
            }
         
        }

        private void cmbTeklifUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                cmbTeklifSatis();
        }

        private void cmbTeklifSatisMiktari_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTeklifTutar.Text = Teklif.toplamTutar((int)cmbTeklifUrun.SelectedValue, (int)cmbTeklifSatisMiktari.SelectedValue).ToString();
        }

        private void btnTeklifSil_Click(object sender, EventArgs e)
        {
            try
            {
                int teklifID = (int)dgvTeklifGoruntule.CurrentRow.Cells[0].Value;
                Teklif.Remove(teklifID);
                TeklifBilgileri();
            }
            catch (Exception)
            {

                MessageBox.Show("Silme İşlemin0de HATA oluştu ! ");
                ;
            }
        }

        private void dgvTeklifGoruntule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTeklifNo.Text = dgvTeklifGoruntule.CurrentRow.Cells[1].Value.ToString();
            txtTeklifFirma.Text= dgvTeklifGoruntule.CurrentRow.Cells[2].Value.ToString();
            cmbTeklifUrun.Text = dgvTeklifGoruntule.CurrentRow.Cells[3].Value.ToString();
            cmbTeklifSatisMiktari.Text= dgvTeklifGoruntule.CurrentRow.Cells[4].Value.ToString();
            txtTeklifTutar.Text = dgvTeklifGoruntule.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnTeklifGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Teklif teklif = new tbl_Teklif
                {
                    teklif_id = (int)dgvTeklifGoruntule.CurrentRow.Cells[0].Value,
                    teklifNo = txtTeklifNo.Text,
                    tekFirmaAdi = txtTeklifFirma.Text,
                    urun_id = (int)cmbTeklifUrun.SelectedValue,
                    tekUrunMiktar = (int)cmbTeklifSatisMiktari.SelectedValue,
                    teklifTutar = Convert.ToDecimal(txtTeklifTutar.Text),


                };
                Teklif.Update(teklif);
                TeklifBilgileri();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata ! ");
            }
        }

        private void txtTeklifNoSorgula_TextChanged(object sender, EventArgs e)
        {
            dgvTeklifBilgi.DataSource = Teklif.TeklifSorgula(txtTeklifNoSorgula.Text);
        }
    }
}
