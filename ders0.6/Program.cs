using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders0._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. sayi: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayi: ");
            int y = Convert.ToInt32(Console.ReadLine());
            islem islemayna = new islem();
            islemayna.sayi = x;
            islemayna.sayi2 = y;
            Console.WriteLine(islemayna.topla());
            Console.ReadKey();
        }
    }
    class islem
    {
        public int sayi;
        public int sayi2;

        public int topla()
        {
            return sayi + sayi2;
        }
    }
}
