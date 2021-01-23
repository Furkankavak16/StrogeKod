using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BağlıListe
{
    class Program
    {
        static void Main(string[] args)
        {
            //liste tanımlama
            Liste bağlıliste = new Liste();
            bağlıliste.listeBasınaElemanEkle(new Eleman(45));
            bağlıliste.listeyeEkle(new Eleman(55));
            bağlıliste.listeyeEkle(new Eleman(23));
            bağlıliste.listeyeEkle(new Eleman(9));
            bağlıliste.listeyeEkle(new Eleman(78));
            bağlıliste.listeyeEkle(new Eleman(61));
          

            Console.WriteLine("Eleman sayısı:" + $"{bağlıliste.ElemanSayısı()}");

            //liste eleman arama 
            Eleman arananEleman = bağlıliste.listeAra(9);
            if (arananEleman != null)
                Console.WriteLine("Bulundu:{0}", arananEleman.icerik);
            else
                Console.WriteLine("Bulunamadı");

            Eleman sıfır = bağlıliste.elemanGetir(0);
            Eleman bir = bağlıliste.elemanGetir(1);
            Eleman iki = bağlıliste.elemanGetir(2);
            Eleman uc = bağlıliste.elemanGetir(3);



            Console.WriteLine(sıfır.icerik);
            Console.WriteLine(bir.icerik);
            Console.WriteLine(iki.icerik);
            Console.WriteLine(uc.icerik);
            
            //liste basındaki elemanı sil
            bağlıliste.listeBasındanElemanSil();
            //liste sonundan eleman sil
            bağlıliste.listeSonundanElemandSil();

            //listeden eleman silmek 
            bağlıliste.listedeSil(iki);
            bağlıliste.listedeSil(uc);
            
            
            Console.WriteLine($"Eleman sayısı:" + $"{bağlıliste.ElemanSayısı()}");


            Console.ReadKey();



        }
    }
}
