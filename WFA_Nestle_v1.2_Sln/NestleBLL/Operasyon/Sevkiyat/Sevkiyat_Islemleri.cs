using NestleBLL.EF_Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestleBLL.Sevkiyat
{
   public class Sevkiyat_Islemleri
    {
        NestleDataContext ctx = new NestleDataContext();

        public IList SevkiyatBilgileri()
        {
            var sevkiyatListe = ctx.tbl_Sevkiyats.Select(x => new {
                SevkiyatID = x.sev_id,
                Firma_Adi=x.tbl_Satis.FirmaAdi,
                Sevkiyat_Turu=x.tbl_Lojistik.lojistikTuru,
                UrunAdi=x.tbl_UrunBilgisi.urun_adi,
                Adres=x.sevAdres
          
            }).ToList();
            return sevkiyatListe;
        }
        public IList cmbFirma()
        {
            return ctx.tbl_Satis.ToList();
        }
        public IList cmbSevkiyatTuru()
        {
            return ctx.tbl_Lojistiks.ToList();
        }
        public IList cmbUrunAdi()
        {
            return ctx.tbl_UrunBilgisis.ToList();
        }

        public void Add(tbl_Sevkiyat sevEkle)
        {
            ctx.tbl_Sevkiyats.InsertOnSubmit(sevEkle);
            ctx.SubmitChanges();

        }
        public void Update(tbl_Sevkiyat sevGuncelle)
        {
            tbl_Sevkiyat sevGuncel = ctx.tbl_Sevkiyats.SingleOrDefault(x => x.sev_id == sevGuncelle.sev_id);
            sevGuncel.satis_id = sevGuncelle.satis_id;
            sevGuncel.lojistik_id = sevGuncelle.lojistik_id;
            sevGuncel.urun_id = sevGuncelle.urun_id;
            sevGuncel.sevAdres = sevGuncelle.sevAdres;
            

            ctx.SubmitChanges();

        }
        public void Remove(int sevID)
        {
            tbl_Sevkiyat sevSil = ctx.tbl_Sevkiyats.SingleOrDefault(sev => sev.sev_id == sevID);
            ctx.tbl_Sevkiyats.DeleteOnSubmit(sevSil);
            ctx.SubmitChanges();
        }

    }
}
