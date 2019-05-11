using NestleBLL.EF_Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestleBLL.Satis
{
  public  class Satis_Islemleri
    {

        NestleDataContext ctx = new NestleDataContext();

        public IList SatisBilgisi()
        {
            var satisListe = ctx.tbl_Satis.Select(x => new {
                SatisID = x.satis_id,
                Firma_Adi=x.FirmaAdi,
                Satis_Tarihi=x.SatisTarihi,
                Teslim_Adres=x.TeslimAdresi,
                Sehir=x.TeslimSehir,
                Ulke=x.TeslimUlke,
                Teslim_Tarihi=x.TeslimTarihi,
                UrunAdi=x.tbl_UrunBilgisi.urun_adi,
                Adet=x.satAdet,
                Satis_Tutari = x.SatisTutari,
                Satis_Durumu =x.tbl_SatisDurumu.satisDurumu
            }).ToList();
            return satisListe;
        }

        public IList cmbSatisDurum()
        {
            return ctx.tbl_SatisDurumus.ToList();
        }
        public IList cmbUrunBilgi()
        {
            return ctx.tbl_UrunBilgisis.ToList();
        }
        public int cmbUrunStokBilgisi(int id)
        {
           return ctx.tbl_UrunBilgisis.FirstOrDefault(x => x.urun_id == id).urunMiktari;
          
        }

        public void Add(tbl_Satis satEkle)
        {
            ctx.tbl_Satis.InsertOnSubmit(satEkle);
            ctx.SubmitChanges();

        }
        public void Update(tbl_Satis satisGuncelle)
        {
            tbl_Satis satisgun = ctx.tbl_Satis.SingleOrDefault(x => x.satis_id == satisGuncelle.satis_id);
            satisgun.FirmaAdi = satisGuncelle.FirmaAdi;
            satisgun.TeslimAdresi = satisGuncelle.TeslimAdresi;
            satisgun.TeslimSehir = satisGuncelle.TeslimSehir;
            satisgun.TeslimUlke = satisGuncelle.TeslimUlke;
            satisgun.TeslimTarihi = satisGuncelle.TeslimTarihi;
           
            ctx.SubmitChanges();

        }
        public void Remove(int satID)
        {
            tbl_Satis satis = ctx.tbl_Satis.SingleOrDefault(sat => sat.satis_id == satID);
            ctx.tbl_Satis.DeleteOnSubmit(satis);
            ctx.SubmitChanges();
        }
        public string toplamTutar(int satisAdet,int urunID)
        {
            var urunFiyat = ctx.tbl_UrunBilgisis.FirstOrDefault(x => x.urun_id == urunID).urunFiyati;
            string toplamTutar = (satisAdet * urunFiyat).ToString();
            return toplamTutar;
        }
        public IList SatisSorgula(string yazi)
        {

            var satSorgula = ctx.tbl_Satis.Where(x => x.FirmaAdi.Contains(yazi)).Select(x => new
            {
              
                SatisID = x.satis_id,
                Firma_Adi = x.FirmaAdi,
                Satis_Tarihi = x.SatisTarihi,
                Teslim_Adres = x.TeslimAdresi,
                Sehir = x.TeslimSehir,
                Ulke = x.TeslimUlke,
                Teslim_Tarihi = x.TeslimTarihi,
                UrunAdi = x.tbl_UrunBilgisi.urun_adi,
                Adet = x.satAdet,
                Satis_Tutari = x.SatisTutari,
                Satis_Durumu = x.tbl_SatisDurumu.satisDurumu
            }).ToList();
            return satSorgula;
        }

        

    }
}
