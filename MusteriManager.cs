using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager

    {
      public void musteriEkle(Musteri musteri)
        {
            Console.WriteLine("=====WWW.KodlamaİO.com=======");
            Console.WriteLine(musteri.Ad+""+musteri.Soyadı+""+musteri.MusteriNumarasi+""+musteri.MusteriPuan+" : "+"Müşterisi eklendi ");
            Console.WriteLine("******************");
        }
        public void musteriSil(Musteri musteri)
        {
           
            Console.WriteLine("=====WWW.KodlamaİO.com=======");
            Console.WriteLine(musteri.Ad + "" + musteri.Soyadı + "" + musteri.MusteriNumarasi + "" + musteri.MusteriPuan + " : " + "Müşterisi silindi ");
            Console.WriteLine("******************");
        }
    }
}
