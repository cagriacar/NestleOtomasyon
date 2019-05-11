using NestleBLL.EF_Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestleBLL.Satis.Teklif_İslemleri
{
   public class Teklif_İslemleri
    {
        NestleDataContext ctx = new NestleDataContext();

        public IList TeklifBilgisi()
        {
            var teklifListe = ctx.tbl_Teklifs.Select(x => new {
                TeklifID = x.teklif_id,
                TeklifNo = x.teklifNo,
                FirmaAdi = x.tekFirmaAdi,
                UrunAdi = x.tbl_UrunBilgisi.urun_adi,
                UrunMiktari = x.tekUrunMiktar,
                TeklifTutar = x.teklifTutar,
              
            }).ToList();
            return teklifListe;
        }
        public decimal toplamTutar(int id,int satisMiktar)
        {
            decimal urunFiyat= ctx.tbl_UrunBilgisis.FirstOrDefault(x => x.urun_id == id).urunFiyati;
            decimal toplamTutar = urunFiyat * satisMiktar;
            return toplamTutar;

        }

        public void Add(tbl_Teklif teklifEkle)
        {
            ctx.tbl_Teklifs.InsertOnSubmit(teklifEkle);
            ctx.SubmitChanges();

        }
        public void Update(tbl_Teklif teklifGuncelle)
        {
            tbl_Teklif teklifGuncel = ctx.tbl_Teklifs.SingleOrDefault(x => x.teklif_id == teklifGuncelle.teklif_id);
            teklifGuncel.teklifNo = teklifGuncelle.teklifNo;
            teklifGuncel.tekFirmaAdi = teklifGuncelle.tekFirmaAdi;
            teklifGuncel.urun_id = teklifGuncelle.urun_id;
            teklifGuncel.tekUrunMiktar = teklifGuncelle.tekUrunMiktar;
            teklifGuncel.teklifTutar = teklifGuncelle.teklifTutar;

            ctx.SubmitChanges();

        }
        public void Remove(int teklifID)
        {
            tbl_Teklif teklif = ctx.tbl_Teklifs.SingleOrDefault(tek => tek.teklif_id == teklifID);
            ctx.tbl_Teklifs.DeleteOnSubmit(teklif);
            ctx.SubmitChanges();
        }
        
                public IList TeklifSorgula(string yazi)
        {

            var teklifsorgula = ctx.tbl_Teklifs.Where(x => x.teklifNo.Contains(yazi)).Select(x => new
            {
                TeklifID = x.teklif_id,
                TeklifNo = x.teklifNo,
                FirmaAdi = x.tekFirmaAdi,
                UrunAdi = x.tbl_UrunBilgisi.urun_adi,
                UrunMiktari = x.tekUrunMiktar,
                TeklifTutar = x.teklifTutar,

            }).ToList();
            return teklifsorgula;
        }
    }
}
