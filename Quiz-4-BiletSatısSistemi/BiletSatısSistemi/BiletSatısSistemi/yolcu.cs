using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatısSistemi
{
    class yolcu
    {
        string ad;
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        string soyad;
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        int koltukNo;
        public int KoltukNo
        {
            get { return koltukNo; }
            set { koltukNo = value; }
        }
        string durum;
        public string Durum
        {
            get { return durum; }
            set { durum = value; }
        }
        public override string ToString()
        {
            return "Ad Soyad:" +Ad+Soyad+" KoltukNo: "+KoltukNo;
        }
        public yolcu()
        {

        }
    }
}
