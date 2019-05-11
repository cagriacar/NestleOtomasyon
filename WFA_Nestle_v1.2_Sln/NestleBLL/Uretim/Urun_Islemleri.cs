using NestleBLL.EF_Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestleBLL.Uretim
{
   public class Urun_Islemleri
    {
        NestleDataContext ctx = new NestleDataContext();
        public IList UrunBilgisi()
        {
            var urunListe = ctx.tbl_UrunBilgisis.Select(x=>new {
               UrunID= x.urun_id,
               UrunAdi=x.urun_adi,
               UrunTuru=x.tbl_UrunTuru.uruntur_adi,
               UretimTarihi=x.urunUretimTarihi,
               Fiyat=x.urunFiyati,
               Adet=x.urunMiktari,
               Depo=x.tbl_Depolama.depoAdi

            }).ToList();
            return urunListe;
        }
        public IList cmbDepoAdi()
        {
            return ctx.tbl_Depolamas.ToList();
        }
        public IList cmbUrunTuru()
        {
            return ctx.tbl_UrunTurus.ToList();
        }
        public IList UrunSorgula(string yazi)
        {

            var urunSorgula = ctx.tbl_UrunBilgisis.Where(x => x.urun_adi.Contains(yazi)).Select(x => new
            {
                UrunID = x.urun_id,
                UrunAdi = x.urun_adi,
                UrunTuru = x.tbl_UrunTuru.uruntur_adi,
                UretimTarihi = x.urunUretimTarihi,
                Fiyat = x.urunFiyati,
                Adet = x.urunMiktari,
                Depo = x.tbl_Depolama.depoAdi
            }).ToList();
            return urunSorgula;
        }

        public void Add(tbl_UrunBilgisi uretim)
        {
            ctx.tbl_UrunBilgisis.InsertOnSubmit(uretim);
            ctx.SubmitChanges();

        }

        public void Update(tbl_UrunBilgisi uretim)
        {
            tbl_UrunBilgisi urunGucelle = ctx.tbl_UrunBilgisis.SingleOrDefault(x => x.urun_id == uretim.urun_id);
            urunGucelle.urun_adi = uretim.urun_adi;
            urunGucelle.uruntur_id = uretim.uruntur_id;
            urunGucelle.urunUretimTarihi = uretim.urunUretimTarihi;
            urunGucelle.urunFiyati = uretim.urunFiyati;
            urunGucelle.urunMiktari = uretim.urunMiktari;
            urunGucelle.depo_id = uretim.depo_id;
            ctx.SubmitChanges();

        }
        public void Remove(int ureID)
        {
            tbl_UrunBilgisi Uretim = ctx.tbl_UrunBilgisis.SingleOrDefault(urun => urun.urun_id == ureID);
            ctx.tbl_UrunBilgisis.DeleteOnSubmit(Uretim);
            ctx.SubmitChanges();
        }
    }
}
