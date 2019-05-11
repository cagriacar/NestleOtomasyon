
using NestleBLL.Depolama;
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
    public partial class Depo_IslemleriUI : Form
    {
        Depo_Islemleri Depolama = new Depo_Islemleri();

        public Depo_IslemleriUI()
        {
            InitializeComponent();
        }
        
        private void Depo_IslemleriUI_Load(object sender, EventArgs e)
        {
            getir();
            DepoAdiCmb();

        }
        private void getir()
        {
            dgvDepoUrunBilgisi.DataSource = Depolama.DepoUrunBilgisi();
            dgvDepoGirisBilgi.DataSource = Depolama.DepoBilgisi();
        }
        private void DepoAdiCmb()
        {
            cmbDepoAdi.DataSource = Depolama.cmbDepoAdi();
            cmbDepoAdi.DisplayMember = "depoAdi";
            cmbDepoAdi.ValueMember = "depo_id";
        }

        private void txtDepoUrunAdi_TextChanged(object sender, EventArgs e)
        {
            dgvDepoUrunBilgisi.DataSource = Depolama.UrunAra(txtDepoUrunAdi.Text);
        }

        private void btnDepoListele_Click(object sender, EventArgs e)
        {
            dgvDepoUrunBilgisi.DataSource = Depolama.cmbDepoListele(cmbDepoAdi.Text);
        }

        private void btnTumListe_Click(object sender, EventArgs e)
        {
            getir();
        }

        private void btnDepoEkle_Click(object sender, EventArgs e)
        {
             tbl_Depolama ekleDepo = new tbl_Depolama
             {
                 depoAdi=txtDepoAdi.Text,
                 depoAdres=txtDepoAdres.Text
            };
            Depolama.Add(ekleDepo);
            getir();
        }

        private void btnDepoSil_Click(object sender, EventArgs e)
        {
            int depoID = (int)dgvDepoGirisBilgi.CurrentRow.Cells[0].Value;
            Depolama.Remove(depoID);
            getir();
        }

        private void btnDepoDuzenle_Click(object sender, EventArgs e)
        {
            tbl_Depolama guncelDepo = new tbl_Depolama
            {
                depo_id= (int)dgvDepoGirisBilgi.CurrentRow.Cells[0].Value,
            depoAdi = txtDepoAdi.Text,
                depoAdres = txtDepoAdres.Text
            };
            Depolama.Update(guncelDepo);
            getir();
        }

        private void dgvDepoGirisBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDepoAdi.Text = dgvDepoGirisBilgi.CurrentRow.Cells[1].Value.ToString();
            txtDepoAdres.Text = dgvDepoGirisBilgi.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void txtDepoSorgula_TextChanged(object sender, EventArgs e)
        {
            dgvDepoGirisBilgi.DataSource = Depolama.DepoSorgula(txtDepoSorgula.Text);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in tabPage2.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
            }
        }
    }
}
