using NestleBLL.EF_Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestleBLL.Basvuru
{
    public class Basvuru_Islemleri
    {
        NestleDataContext ctx = new NestleDataContext();

        public IList BasvuruBilgileri()
        {
            var bsvr = ctx.tbl_BasvuruForms.Select(x => new
            {
              BasvuruID=x.basvuru_id,
              Basvuru_Adi=x.basvuruAdi,
              Basuvuru_Soyadi=x.basvuruSoyadi,
              Dogum_Tarihi=x.basvuruDogumTarihi,
              Cinsiyet=x.basvuruCinsiyet,
              Telefon=x.basvuruTelefon,
              EMail=x.basvuruMail,
              YabanciDil=x.basvuruYabanciDil,
              Askerlik_Durumu=x.basvuruAskerlikDurumu,
              Medeni_Durum=x.basvuruMedeniDurum,
              Eğitim_Bilgisi=x.basvuruEgitim,
              Deneyim=x.basvuruDeneyim,
              Adres=x.basvuruAdres,
              Resim=x.basvuruResim,
            }).ToList();
            return bsvr;

        }

        public void Add(tbl_BasvuruForm basvuru)
        {
            ctx.tbl_BasvuruForms.InsertOnSubmit(basvuru);
            ctx.SubmitChanges();

        }
        public void Remove(int basvuruID)
        {
            tbl_BasvuruForm Basvuru = ctx.tbl_BasvuruForms.SingleOrDefault(b => b.basvuru_id == basvuruID);
            ctx.tbl_BasvuruForms.DeleteOnSubmit(Basvuru);
            ctx.SubmitChanges();
        }
        public void Update(tbl_BasvuruForm basvuru)
        {
            tbl_BasvuruForm guncelbasvuru = ctx.tbl_BasvuruForms.SingleOrDefault(per => per.basvuru_id == basvuru.basvuru_id);
            guncelbasvuru.basvuruAdi = basvuru.basvuruAdi;
            guncelbasvuru.basvuruSoyadi = basvuru.basvuruSoyadi;
            guncelbasvuru.basvuruDogumTarihi = basvuru.basvuruDogumTarihi;
            guncelbasvuru.basvuruCinsiyet = basvuru.basvuruCinsiyet;
            guncelbasvuru.basvuruTelefon = basvuru.basvuruTelefon;
            guncelbasvuru.basvuruMail = basvuru.basvuruMail;
            guncelbasvuru.basvuruYabanciDil = basvuru.basvuruYabanciDil;
            guncelbasvuru.basvuruAskerlikDurumu = basvuru.basvuruAskerlikDurumu;
            guncelbasvuru.basvuruMedeniDurum = basvuru.basvuruMedeniDurum;
            guncelbasvuru.basvuruEgitim = basvuru.basvuruEgitim;
            guncelbasvuru.basvuruDeneyim = basvuru.basvuruDeneyim;
            guncelbasvuru.basvuruAdres = basvuru.basvuruAdres;
            guncelbasvuru.basvuruResim = basvuru.basvuruResim;
            ctx.SubmitChanges();

        }
        public IList BasvuruFiltre(string yazi)
        {

            var basvurufiltre = ctx.tbl_BasvuruForms.Where(x => x.basvuruAdi.Contains(yazi)).Select(x => new
            {
                BasvuruID = x.basvuru_id,
                Basvuru_Adi = x.basvuruAdi,
                Basuvuru_Soyadi = x.basvuruSoyadi,
                Dogum_Tarihi = x.basvuruDogumTarihi,
                Cinsiyet = x.basvuruCinsiyet,
                Telefon = x.basvuruTelefon,
                EMail = x.basvuruMail,
                YabanciDil = x.basvuruYabanciDil,
                Askerlik_Durumu = x.basvuruAskerlikDurumu,
                Medeni_Durum = x.basvuruMedeniDurum,
                Eğitim_Bilgisi = x.basvuruEgitim,
                Deneyim = x.basvuruDeneyim,
                Adres = x.basvuruAdres,
                Resim = x.basvuruResim,
            }).ToList();
            return basvurufiltre;
        }
        public IList BasvuruSiralaAZ()
        {
            return ctx.tbl_BasvuruForms.Select(x => new
            {
                BasvuruID = x.basvuru_id,
                Basvuru_Adi = x.basvuruAdi,
                Basuvuru_Soyadi = x.basvuruSoyadi,
                Dogum_Tarihi = x.basvuruDogumTarihi,
                Cinsiyet = x.basvuruCinsiyet,
                Telefon = x.basvuruTelefon,
                EMail = x.basvuruMail,
                YabanciDil = x.basvuruYabanciDil,
                Askerlik_Durumu = x.basvuruAskerlikDurumu,
                Medeni_Durum = x.basvuruMedeniDurum,
                Eğitim_Bilgisi = x.basvuruEgitim,
                Deneyim = x.basvuruDeneyim,
                Adres = x.basvuruAdres,
                Resim = x.basvuruResim,
            }).OrderBy(y => y.Basvuru_Adi).ToList();
        }
        public IList BasvuruSiralaZA()
        {
            return ctx.tbl_BasvuruForms.Select(x => new
            {
                BasvuruID = x.basvuru_id,
                Basvuru_Adi = x.basvuruAdi,
                Basuvuru_Soyadi = x.basvuruSoyadi,
                Dogum_Tarihi = x.basvuruDogumTarihi,
                Cinsiyet = x.basvuruCinsiyet,
                Telefon = x.basvuruTelefon,
                EMail = x.basvuruMail,
                YabanciDil = x.basvuruYabanciDil,
                Askerlik_Durumu = x.basvuruAskerlikDurumu,
                Medeni_Durum = x.basvuruMedeniDurum,
                Eğitim_Bilgisi = x.basvuruEgitim,
                Deneyim = x.basvuruDeneyim,
                Adres = x.basvuruAdres,
                Resim = x.basvuruResim,
            }).OrderByDescending(y => y.Basvuru_Adi).ToList();
        }
    }
}
