using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N059_OPPnedir
{
    class Program
    {
        static void Main(string[] args)
        {
            //araç sınıfından yeni bir arac türettik.
            //Arac bmw = new Arac("bmw","jeep");

            #region Araç sınıfı inceleme

            //Arac A1 = new Arac("Opel", "Corsa", 2010, 56000);
            //A1.AlısFiyat = 28000;
            //A1.SatısFiyat = 32000;
            //A1.MaxIndırımTutar = 1500;
            ////A1.Fiyat= Kapsülleme konusu
            //A1.FiyatAta(27000);
            //A1.BilgileriGoruntule();

            #endregion

            #region Musteri sınıfını inceledik.


            //Musteri M1 = new Musteri(); böylede olusturabiliriz.
            //Musteri M1 = new Musteri("54020189655", "Murat");
            //M1.TCkimlikNumarası = "1235469978";
            //M1.Isım = "Cengiz";
            //M1.SoyIsım = "Atilla";
            //M1.Cinsiyet = 717770001;
            //Musteri M2 = M1;

            //M2.Isım = "Murat";
            //M2.TCkimlikNumarası = "21365478952";
            //bool musterikontrol = M2.MusteriKontrol();

            //Console.WriteLine(musterikontrol);

            //M2 = null;
            //M1 = null;

            //string isim = M2.Isım;


            #endregion

            // Classlardan nesne bu sekilde new kelimesi ile türetilir
            //So, a class is a template for objects, and an object is an instance of a class.

            Fruit meyve1 = new Fruit();
            meyve1.FruitName = "Bu bir elmadır";
            meyve1.FruitColor = "Kırmızı";
            meyve1.OlusturulmaTrihi = DateTime.Now;

            Console.WriteLine(meyve1.FruitName);
            Console.WriteLine(meyve1.FruitColor);
            Console.WriteLine(meyve1.OlusturulmaTrihi);
            Console.WriteLine("**************************");

            Fruit meyve2 = new Fruit();

            meyve2.FruitName = "Bu bir cilektir";
            meyve2.FruitColor = "Kırmızı";
            meyve2.OlusturulmaTrihi = DateTime.Now;
            Console.WriteLine(meyve2.FruitName);
            Console.WriteLine(meyve2.FruitColor);
            Console.WriteLine(meyve2.OlusturulmaTrihi);

            #region

            #endregion

            Console.ReadLine();
        }
    }

    //Burdada sınıf tanımlayabiliriz.
    //class Musteri
    //{

    //}
}
