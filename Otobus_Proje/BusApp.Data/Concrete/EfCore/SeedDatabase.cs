using BusApp.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusApp.Data.Concrete.EfCore
{
    // static class tekrar tekrar oluşturmamak için new sözcüğünü kullanmadan sınıfın ismiyle erişilecek
    // eğer methot static ise içindeki değişkende static olur
    public  static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new BusBiletContext();
            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if (context.Guzergahs.Count()==0)
                {
                    context.Guzergahs.AddRange(Guzergahs);
                }

                if (context.Bilets.Count()==0)
                {
                    context.Bilets.AddRange(Bilets);
                }

                if (context.Sehirs.Count()==0)
                {
                    context.Sehirs.AddRange(Sehirs);
                }
                context.SaveChanges();
            }         
        }

        private static Guzergah[] Guzergahs =
        {
            new Guzergah(){Baslangıc="İstanbul",gz1="Bolu",gz2="Sivas",Bitis="Erzincan",Tarih="05/07/2022", Saat="13.00",Fiyat=500},
            new Guzergah(){Baslangıc="İstanbul",gz1="Aydın",gz2="Manisa",Bitis="İzmir",Tarih="20/07/2022", Saat="17.00",Fiyat=500}

        };

        private static Bilet[] Bilets =
        {
           new Bilet(){Ad="Ali",Soyad="Bilir",Mail="ali@gmail",Nereden="İstanbul",Nereye="Bolu", KoltukNo=1,Fiyat=500},
           new Bilet(){Ad="Can",Soyad="Koç",Mail="can@gmail",Nereden="İstanbul",Nereye="Sivas", KoltukNo=2,Fiyat=500},
           new Bilet(){Ad="Melike",Soyad="Sabancı",Mail="melike@gmail",Nereden="Bolu",Nereye="Erzincan", KoltukNo=3,Fiyat=500},
           new Bilet(){Ad="Derin",Soyad="Dinçer",Mail="derin@gmail",Nereden="Sivas",Nereye="İstanbul", KoltukNo=4,Fiyat=500}

        };

        private static Sehir[] Sehirs =
        {
             new Sehir() {SehirAd="İstanbul"},
             new Sehir() {SehirAd="Bolu"},
             new Sehir() {SehirAd="Sivas"},
             new Sehir() {SehirAd="Erzincan"},
             new Sehir() {SehirAd="Aydın"},
             new Sehir() {SehirAd="Manisa"},
             new Sehir() {SehirAd="İzmir"}

        };
    }
}
