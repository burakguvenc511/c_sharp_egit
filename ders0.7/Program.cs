using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders0._7
{
    class Program
    {
        static List<sebze> sebzeliste = new List<sebze>();
        static List<satis> satisliste = new List<satis>();
        static int satiNo = 0;
        static int urunNo = 0;

        static void yenisebze()
        {
            sebze newsebze = new sebze();
            urunNo++;
            newsebze.UnurNum = urunNo;
            Console.Write("ürün adı girin: ");
            newsebze.UrunAd=Console.ReadLine();

            Console.Write("ürün fiyatı girin: ");
            newsebze.Fiyat =Convert.ToDecimal(Console.ReadLine());
            Console.Write("stok sayısı girin: ");
            newsebze.Stok = Convert.ToInt32(Console.ReadLine());

            var sebzesorgu = sebzeliste.Exists(x => (x.UrunAd.Contains(newsebze.UrunAd)) && (x.UnurNum == newsebze.UnurNum));
            if (sebzesorgu == false)
            {
                sebzeliste.Add(newsebze);
            }
            else
            {
                Console.WriteLine("listede girdiğiniz sebze mevcuttur. ");
            }
        }

        static void liste()
        {
            Console.WriteLine("=========== ÜRÜN LİSTESİ ===========");
            Console.WriteLine("ÜRÜN NO \t ÜRÜN AD \t ÜRÜN FİYAT \t STOK");
            foreach (var item in sebzeliste)
            {
                Console.WriteLine(item.UnurNum+" "+item.UrunAd+" "+item.Fiyat+" "+item.Stok);
            }
        }

        static void satis()
        {
            Console.Write("satışı yapılacak olan ürüün numarasını girin: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("satmak istediğiniz adedi girin: ");
            int adet = Convert.ToInt32(Console.ReadLine());
            sebze satilacaksebze = sebzeliste.Find(x=>x.UnurNum==urunNo);
            satilacaksebze.Stok -= adet;  // stok = stok - adet; ile aynı
            satiNo++;

            satis yenisatis = new satis()
            {
                kg = adet,
                Sebze=satilacaksebze,
                satisNum=satiNo,
                tutar=satilacaksebze.Fiyat*adet
            };
            satisliste.Add(yenisatis);
        }

        static void Main(string[] args)
        {
            sebze ayna = new sebze();

            do
            {
                Console.WriteLine("MENÜ");
                Console.WriteLine("1) yeni sebze");
                Console.WriteLine("2) sebze listesi");
                Console.WriteLine("3) sebze satışı");
                Console.Write("seçim: ");
                char secim = Convert.ToChar(Console.ReadLine());
                switch (secim)
                {
                    case '1':  yenisebze();    break;
                    case '2':  liste();        break;
                    case '3':  satis();        break;
                }

            } while (true);

        }
    }
}
