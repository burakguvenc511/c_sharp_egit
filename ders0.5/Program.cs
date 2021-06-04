using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders0._5
{
                    //statik olan bir metot içine statik olmayan birmetot eklenemez!!!
    class Program
    {               
        public static int sayi=2;
        public static int sayi2=5;
        static void Main(string[] args)
        {
            Console.WriteLine(topla());
            Console.ReadKey();
        }
        public static int topla()
        {
            return sayi + sayi2; 
        }
    }
}
