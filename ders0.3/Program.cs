using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ders0._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] otlar = new string[] {"cemen","maydanoz","tere" };
            ArrayList liste = new ArrayList();
            ArrayList baharat = new ArrayList {"biber","tuz","karabiber","tarçın" };

            Random rastgele = new Random();

            liste.Add("domates");               //add listeye ekleme yağpar
            liste.Add(5);
            liste.Add('t');
            liste.Add(3.25);

            liste.RemoveAt(2);                  //removeAt index olarak silmek için
            liste.Remove('t');                  //remove   veri  olarak silmek için

            liste.Clear();                      //clear listeyi tamamen temizler

            liste.Insert(0,"karpuz");           //insert listeye index olarak ekleme yapar
            liste.Add("adana");

            liste.InsertRange(1, otlar);        //insertRange listeye index e göre dizi eklemesi yapar

            liste.Sort();                       //sort listeyi küçükten büyüğe sıralar
                                                // dikkat listede iki ayrı tür olursa sıralama gferçekleşmez hata verir. 

            liste.Reverse();                    //reverse listeyi tersine sıralar                

            if (liste.Contains("tere"))         //contains listede verinin varlığını kontrol eder
            {
                liste.Remove("tere");
            }
            else                                //indexOf verinin ilk index değerini verir
            {
                Console.WriteLine($"{liste.IndexOf("tere")} sırasında tere var.");
            }

            liste.AddRange(baharat);            //addrange baharat listesini listenin sonuna ekler

            liste.Capacity = 17;                //listenin kapasitesini verir

            Console.WriteLine(liste[rastgele.Next(0,liste.Count)]);
            Console.WriteLine("listenin kapasitesi: "+liste.Capacity);
            Console.WriteLine("=================");

           foreach (var isim in liste)
           {
                Console.WriteLine(isim);
           }

            Console.ReadKey();
        }
    }
}
