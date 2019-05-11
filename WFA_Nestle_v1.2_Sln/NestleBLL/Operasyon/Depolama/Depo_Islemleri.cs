using NestleBLL.EF_Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestleBLL.Depolama
{
    public class Depo_Islemleri
    {
        NestleDataContext ctx = new NestleDataContext();
        public IList DepoUrunBilgisi()
        {
            var depourunBilgisi = ctx.tbl_UrunBilgisis.Select(x => new
            {
                UrunID = x.urun_id,
                DepoAdi = x.tbl_Depolama.depoAdi,
                UrunAdi = x.urun_adi,
                UrunTuru=x.tbl_UrunTuru.uruntur_adi,
                Adet = x.urunMiktari,
            }).ToList();
            return depourunBilgisi;

        }
        public IList DepoBilgisi()
        {
            var depoBilgisi = ctx.tbl_Depolamas.Select(x => new
            {
                DepoID=x.depo_id,
                DepoAdi=x.depoAdi,
                Adres=x.depoAdres
            }).ToList();
            return depoBilgisi;

        }

        public IList cmbDepoAdi()
        {
            return ctx.tbl_Depolamas.ToList();
        }
        public IList cmbDepoListele(string id)
        {
            var liste = ctx.tbl_UrunBilgisis.Where(x => x.tbl_Depolama.depoAdi == id).Select(x => new
            {
                UrunID = x.urun_id,
                DepoAdi = x.tbl_Depolama.depoAdi,
                UrunAdi = x.urun_adi,
                UrunTuru = x.tbl_UrunTuru.uruntur_adi,
                Adet = x.urunMiktari,
            }).ToList();
            return liste ;
        }
        public IList UrunAra(string yazi)
        {

            var urunAra = ctx.tbl_UrunBilgisis.Where(x => x.urun_adi.Contains(yazi)).Select(x => new
            {
                UrunID = x.urun_id,
                DepoAdi = x.tbl_Depolama.depoAdi,
                UrunAdi = x.urun_adi,
                UrunTuru = x.tbl_UrunTuru.uruntur_adi,
                Adet = x.urunMiktari,
            }).ToList();
            return urunAra;
        }

        public void Add(tbl_Depolama depo)
        {
            ctx.tbl_Depolamas.InsertOnSubmit(depo);
            ctx.SubmitChanges();

        }
        public void Remove(int depoID)
        {
            tbl_Depolama depolama = ctx.tbl_Depolamas.SingleOrDefault(b => b.depo_id == depoID);
            ctx.tbl_Depolamas.DeleteOnSubmit(depolama);
            ctx.SubmitChanges();
        }
        public void Update(tbl_Depolama depolama)
        {
            tbl_Depolama guncelDepo = ctx.tbl_Depolamas.SingleOrDefault(de => de.depo_id == depolama.depo_id);
            guncelDepo.depoAdi = depolama.depoAdi;
            guncelDepo.depoAdres = depolama.depoAdres;
            ctx.SubmitChanges();

        }
        public IList DepoSorgula(string yazi)
        {

            var depoFiltre = ctx.tbl_Depolamas.Where(x => x.depoAdi.Contains(yazi)).Select(x => new
            {
                DepoID=x.depo_id,
                DepoAdi=x.depoAdi,
                Adres=x.depoAdres
            }).ToList();
            return depoFiltre;
        }
    }
}
