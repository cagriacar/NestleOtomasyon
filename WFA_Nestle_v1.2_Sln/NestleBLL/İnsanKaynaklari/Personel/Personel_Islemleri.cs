using NestleBLL.EF_Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestleBLL.Personel
{
   public class Personel_Islemleri
    {
        NestleDataContext ctx = new NestleDataContext();
        public IList PersonelBilgileri()
        {
            var personel=ctx.tbl_PersonelBilgileris.Select(x => new
            {
                PersonelID=x.per_id,
                Adi = x.perAdi,
                Soyadi=x.perSoyadi,
                Dogum_Tarihi=x.perDogumTarihi,
                Tc_Kimlik_No=x.perTcno,
                Unvan=x.perUnvan,
                Telefon=x.perTelefon,
                E_Mail=x.perMail,
                Ulke=x.perUlke,
                Il=x.peril,
                Ilce = x.perilce,
                Adres=x.perAdres,
               Resim= x.perResim,
                Departman=x.tbl_Departman.departmanAdi,
            }).ToList();
            return personel;
        }
        public void Add(tbl_PersonelBilgileri personel)
        {
            ctx.tbl_PersonelBilgileris.InsertOnSubmit(personel);
            ctx.SubmitChanges();
            
        }
   
        public void Update(tbl_PersonelBilgileri personel)
        {
           tbl_PersonelBilgileri yeniPersonel= ctx.tbl_PersonelBilgileris.SingleOrDefault(per=>per.per_id==personel.per_id);
            yeniPersonel.perAdi = personel.perAdi;
            yeniPersonel.perSoyadi = personel.perSoyadi;
            yeniPersonel.perDogumTarihi = personel.perDogumTarihi;
            yeniPersonel.perTcno = personel.perTcno;
            yeniPersonel.perUnvan = personel.perUnvan;
            yeniPersonel.perTelefon = personel.perTelefon;
            yeniPersonel.perMail = personel.perMail;
            yeniPersonel.perUlke = personel.perUlke;
            yeniPersonel.peril = personel.peril;
            yeniPersonel.perilce = personel.perilce;
            yeniPersonel.perAdres = personel.perAdres;
            yeniPersonel.perResim = personel.perResim;
            yeniPersonel.departman_id = personel.departman_id;
            ctx.SubmitChanges();

        }
        public void Remove(int perID)
        {
            tbl_PersonelBilgileri personel = ctx.tbl_PersonelBilgileris.SingleOrDefault(urun => urun.per_id == perID);
            ctx.tbl_PersonelBilgileris.DeleteOnSubmit(personel);
            ctx.SubmitChanges();
        }

        public IList CmbDepartman()
        {
            return ctx.tbl_Departmans.ToList();
        }
        public IList PersonelAra(string yazi)
        {

            var personelAra = ctx.tbl_PersonelBilgileris.Where(x => x.perAdi.Contains(yazi)).Select(x => new
            {
                PersonelID = x.per_id,
                Adi = x.perAdi,
                Soyadi = x.perSoyadi,
                Dogum_Tarihi = x.perDogumTarihi,
                Tc_Kimlik_No = x.perTcno,
                Unvan = x.perUnvan,
                Telefon = x.perTelefon,
                E_Mail = x.perMail,
                Ulke = x.perUlke,
                Il = x.peril,
                Ilce = x.perilce,
                Adres = x.perAdres,
                Resim = x.perResim,
                Departman = x.tbl_Departman.departmanAdi,
            }).ToList();
            return personelAra;
        }
        public IList PersonelAdiSiralamaAZ()
        {
            return ctx.tbl_PersonelBilgileris.Select(x=> new
            {
                PersonelID = x.per_id,
                Adi = x.perAdi,
                Soyadi = x.perSoyadi,
                Dogum_Tarihi = x.perDogumTarihi,
                Tc_Kimlik_No = x.perTcno,
                Unvan = x.perUnvan,
                Telefon = x.perTelefon,
                E_Mail = x.perMail,
                Ulke = x.perUlke,
                Il = x.peril,
                Ilce = x.perilce,
                Adres = x.perAdres,
                Resim = x.perResim,
                Departman = x.tbl_Departman.departmanAdi,
            }).OrderBy(y=>y.Adi).ToList();
        }
        public IList PersonelAdiSiralamaZA()
        {
            return ctx.tbl_PersonelBilgileris.Select(x => new
            {
                PersonelID = x.per_id,
                Adi = x.perAdi,
                Soyadi = x.perSoyadi,
                Dogum_Tarihi = x.perDogumTarihi,
                Tc_Kimlik_No = x.perTcno,
                Unvan = x.perUnvan,
                Telefon = x.perTelefon,
                E_Mail = x.perMail,
                Ulke = x.perUlke,
                Il = x.peril,
                Ilce = x.perilce,
                Adres = x.perAdres,
                Resim = x.perResim,
                Departman = x.tbl_Departman.departmanAdi,
            }).OrderByDescending(y => y.Adi).ToList();
        }
    }
}
