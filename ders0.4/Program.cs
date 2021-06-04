using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ders0._4
{
    class Program
    {
        static void Main(string[] args)
        {

         

            List<film> filmler = new List<film>() 
            { 
                new film() 
                { 
                    filmNo = 1,
                    filmAdi="AVENGERS",
                    tur="bilim-kurgu" 
                }  
            };

            filmler.Add(new film()
            {
                filmNo = 2,
                filmAdi = "matrix",
                tur = "bilim-kurgu",
            });

            filmler.Add(new film()
            {
                filmNo = 3,
                filmAdi = "shrek",
                tur = "animasyon",
            });

            foreach (var don in filmler)
            {
                Console.WriteLine(don.filmNo+" "+don.filmAdi+" "+don.tur);
            }

            Console.ReadKey();
        }
    }
}
