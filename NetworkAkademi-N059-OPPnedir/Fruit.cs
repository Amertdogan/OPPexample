using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N059_OPPnedir
{
    class Fruit
    {
        /*Class: sınıf demektir.Nesneyi ifade eder. C# da classlar bir namespace icinde olmalıdır 
         * Herhangi bir erisim belirleicisi almazsa class default olarak INTERNAL  seviyededir. 
         * private:özel
         * public: genel
         * Internal: sadece bulundugu projede yani namespace ulasabilir.
         * classlar icinde metotlar barındırabilir.
         * classlar icinde özellikler barındırabilir.
         * 
         * 
         * Özellik Property --> ingiliz anahtarı
         * Proberty nasıl yazılır?
         * Erisim belirleyicisi tip property adı{get; set;}
         */

        public string FruitName { get; set; }
        public string FruitColor { get; set; }
        public DateTime OlusturulmaTrihi { get; set; } = DateTime.Now;

        //Assagıda public yazdıgımızı secerek edit yaptık sonra refactring
        //sonrada Encupsulate dedik ve assagıdaki gibi yaptı.

        //private string fruitName;
        //private string fruitColor;
        //private DateTime olusturulmaTrihi;

        //public string FruitName { get => fruitName; set => fruitName = value; }
        //public string FruitColor { get => fruitColor; set => fruitColor = value; }
        //public DateTime OlusturulmaTrihi { get => olusturulmaTrihi; set => olusturulmaTrihi = value; }
    }
}
