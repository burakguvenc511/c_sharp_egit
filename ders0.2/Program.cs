using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders0._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //adam asmaca oyunu
            string kelime;
            bool dur=true;
            bool dogru = false;
            string kafa = " ";
            string kollar = " ";
            string govde = " ";
            string bacaklar = " ";
            char harf = ' ';
            int yanlis = 0;
            int kazanma = 0;
            /*
            string kelime;
            string kafa = "O";
            string kollar = "/|\\";
            string govde = "|";
            string bacaklar = "/\\";

            */

            Console.WriteLine("oyuncu 1 kelime girin: ");
            Console.Write("kelimeyi dikkatli yazın. çünki siz de göremeyeceksiniz!: ");
            Console.ForegroundColor = ConsoleColor.Black;
            kelime = Console.ReadLine();
            Console.ResetColor();
            Console.Clear(); 
            Console.Write("\n\n        ");
            for (int i = 0; i < kelime.Length; i++)
            {
                Console.Write(" _ ");
            }
            Console.WriteLine("\n\n");


            char[] harf2 = new char[kelime.Length];
            for (int basla = 0; basla < kelime.Length; basla++)
            {
                harf2[basla] = ' ';
            }


            Console.WriteLine("   +-----+--   ");
            Console.WriteLine("   |     |     ");
            Console.WriteLine("   |     {0}     ",kafa);
            Console.WriteLine("   |    {0}    ",kollar);
            Console.WriteLine("   |     {0}     ",govde);
            Console.WriteLine("   |    {0}    ",bacaklar);
            Console.WriteLine(" --+--         ");


            for (int i = 1; dur==true; i++)
            {
                Console.Write("oyuncu lütfen harf girin: ");
                harf = Convert.ToChar(Console.ReadLine());

                Console.Clear();
                for (int j = 0; j < kelime.Length; j++)
                {
                    if (harf == kelime[j])
                    {
                        Console.WriteLine("tebrikler doğru bildiniz.");
                        harf2[j] = harf;
                        dogru = true;
                    }
                }
                if(dogru==false)
                {
                    Console.WriteLine(":( bilemediniz...");
                    yanlis = yanlis + 1;
                }
                if (yanlis == 1) {    kafa  = "O";      }
                if (yanlis == 2) {    kollar="/|\\";    }
                if (yanlis == 3) {    govde = "|";      }
                if (yanlis == 4) {    bacaklar = " / \\"; }
                dogru = false;

                Console.WriteLine("\n\n        ");

                for (int j = 0; j < kelime.Length; j++)
                {
                    if (harf2[j] == kelime[j])
                    {
                        Console.Write($" {harf2[j]} ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine("");

                    for (int k = 0; k < kelime.Length; k++)
                {
                    Console.Write(" _ ");
                }
                Console.WriteLine("\n\n");

                Console.WriteLine("   +-----+--   ");
                Console.WriteLine("   |     |     ");
                Console.WriteLine("   |     {0}     ", kafa);
                Console.WriteLine("   |    {0}    ", kollar);
                Console.WriteLine("   |     {0}     ", govde);
                Console.WriteLine("   |   {0}    ", bacaklar);
                Console.WriteLine(" --+--         ");

                if (yanlis == 4)
                {
                    Console.WriteLine("üzgünüm kaybetttiniz mahkum asıldı...");
                    dur = false;
                    Console.ReadKey();

                }

                for (int son = 0; son < kelime.Length; son++)
                {
                    if(harf2[son]!=' ')
                    {
                        kazanma = kazanma + 1;
                    }
                }
                if (kazanma == kelime.Length)
                {
                    Console.Clear();

                    Console.WriteLine("\n\n        ");

                    for (int j = 0; j < kelime.Length; j++)
                    {
                        if (harf2[j] == kelime[j])
                        {
                            Console.Write($" {harf2[j]} ");
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }
                    Console.WriteLine("");

                    for (int k = 0; k < kelime.Length; k++)
                    {
                        Console.Write(" _ ");
                    }
                    Console.WriteLine("\n\n");

                    Console.WriteLine("   +-----+--   ");
                    Console.WriteLine("   |     |     ");
                    Console.WriteLine("   |        thanks...    ");
                    Console.WriteLine("   |     O     ", kafa);
                    Console.WriteLine("   |    \\|/    ", kollar);
                    Console.WriteLine("   |     |     ", govde);
                    Console.WriteLine(" --+--  / \\    ", bacaklar);


                    Console.WriteLine("tebrikler kazandınız mahkum özgürlüğüne kavuştu.");
                    dur = false;
                    Console.ReadKey();
                }
                kazanma = 0;
            }
        }
    }
}
