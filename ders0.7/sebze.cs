using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders0._7
{
    class sebze
    {
        int urunNum;
        string urunAd;
        decimal fiyat;
        int stok;
                    //iki farklı yazım tarzı olduğu için böyle yazdım
                    // "=>" ya da "{}" dan istediğimizi kullanabiliriz

        public int UnurNum { get => urunNum; set { urunNum = value; } }
        public string UrunAd { get { return urunAd; } set { urunAd = value; } }
        public decimal Fiyat { get { return fiyat;  } set { fiyat = value;  } }
        public int Stok { get { return stok; } set { stok = value; } }

    }
}
