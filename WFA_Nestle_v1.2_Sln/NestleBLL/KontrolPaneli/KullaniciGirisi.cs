using NestleBLL.EF_Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestleBLL.KontrolPaneli
{
    public class KullaniciGirisi
    {
        NestleDataContext ctx = new NestleDataContext();
        public bool KullaniciGiris(string kAdi, string parola)
        {
            bool girisKontrol = ctx.tbl_KullaniciBilgileris.Any(k => k.kullaniciAdi == kAdi && k.sifre == parola);
            if (girisKontrol)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public string Hakkimda()
        {
            return ctx.tbl_Kurumsals.FirstOrDefault(p => p.kurumsal_id == 1).hakkinda;

        }
        public string Slogan()
        {
            return ctx.tbl_Kurumsals.FirstOrDefault(p => p.kurumsal_id == 1).slogan;

        }
    }
}
