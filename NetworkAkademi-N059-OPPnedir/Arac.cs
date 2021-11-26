using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N059_OPPnedir
{
    class Arac
    {

        public string Marka;
        public string Model;
        public int ModelYili;
        public decimal Km;
        public int YakitTip;
        public int VitesTip;
        public decimal AlısFiyat;
        public decimal SatısFiyat;
        public decimal MaxIndırımTutar;
        public decimal Fiyat;

        public Arac()
        {
            //bos constractıon yaptık . Her zaman olusturmalısın catlamaması icin.
        }

        public Arac(string _marka, string _model)
        {
            Marka = _marka;
            Model = _model;
        }
        public Arac(string _marka, string _model, int _ModelYil)
        {
            Marka = _marka;
            Model = this.Model;
            ModelYili = _ModelYil;
        }

        public Arac(string _marka, string _model, int _ModelYil,decimal _Km)
        {
            Marka = _marka;
            Model = _model;
            ModelYili = _ModelYil;
            Km = _Km;
        }

        public Arac(string marka, string model, int modelYili, decimal km, int yakitTip) : this(marka, model, modelYili, km)
        {
            YakitTip = yakitTip;
        }

        public void BilgileriGoruntule()
        {
            Console.WriteLine("Marka {0} - Model {1} - Model Yili {2}",Marka,Model,ModelYili);

        }

        public void FiyatAta(decimal _fiyat)
        {
            decimal fiyatHesap = SatısFiyat - MaxIndırımTutar;
            if (_fiyat< fiyatHesap)
            {
                Console.WriteLine("Gecirsiz Fiyat girisi");
            }
            else
            {
                Fiyat = _fiyat;
                Console.WriteLine("Fiyat güncellendi.");
            }
        }
    }
}
