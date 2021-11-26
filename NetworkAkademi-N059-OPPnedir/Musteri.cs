using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N059_OPPnedir
{
    class Musteri
    {
        /*
         * TC kimlik numarası
         * İsim
         * Soy isim
         * Cinsiyet
         */

        //Propertiler
        public string TCkimlikNumarası;
        public string Isım;
        public string SoyIsım;
        public string Cinsiyet;//717770001:Bay-717770002:Bayan


        //Yapıcı Metot Constructıon

        public Musteri()
        {

        }
        public  Musteri(string Tc)
        {
            TCkimlikNumarası = Tc;
        }

        public Musteri(string tCkimlikNumarası, string ısım) : this(tCkimlikNumarası)
        {
            Isım = ısım;
        }

        public Musteri(string tCkimlikNumarası, string ısım, string soyIsım) : this(tCkimlikNumarası, ısım)
        {
            SoyIsım = soyIsım;
        }

        public Musteri(string tCkimlikNumarası, string ısım, string soyIsım, string cinsiyet) : this(tCkimlikNumarası, ısım, soyIsım)
        {
            Cinsiyet = cinsiyet;
        }
        public bool MusteriKontrol()
        {
            bool Kontrol = MusteriKontrolDatabase(TCkimlikNumarası);
            return true;
        }
        private bool MusteriKontrolDatabase(string tckiliknumarası)
        {
            //Database gidilir musterinin tc kimlik numarasına
            //gore daha once kayıt edilip edilmedıgı bilgisi sorgulanır..

            return true;
        }
    }
}
