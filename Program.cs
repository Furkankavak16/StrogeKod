using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Furkan";
            musteri1.Soyadı = "Kavak";
            musteri1.MusteriNumarasi = 321;
            musteri1.MusteriPuan = 6.5;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ahmet";
            musteri2.Soyadı = "Şengül";
            musteri2.MusteriNumarasi = 897;
            musteri2.MusteriPuan = 4.8;


            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Osman ";
            musteri3.Soyadı = "Öztoprak";
            musteri3.MusteriNumarasi = 254;
            musteri3.MusteriPuan = 10;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2,musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.musteriEkle(musteri1);
            //musteriManager.musteriSil(musteri1);
            musteriManager.musteriEkle(musteri2);
           // musteriManager.musteriSil(musteri2);
            musteriManager.musteriEkle(musteri3);
           // musteriManager.musteriSil(musteri3);
            Console.ReadKey();

        }
    }
}
