using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BağlıListe
{
    public class Liste
    {
        Eleman bas;
        Eleman son;
        public Liste()
        {
            bas = null;
            son = null;
        }
        /// <summary>
        /// liste başına eleman ekleme
        /// </summary>
        /// <param name="yeni"></param>
        public void listeBasınaElemanEkle(Eleman yeni)
        {
            if (son == null)
            {
                son = yeni;
            }
            yeni.ileri = bas;
            bas = yeni;
        }
        /// <summary>
        /// liste sonuna eleman ekleme
        /// </summary>
        /// <param name="yeni"></param>
        public void listeyeEkle(Eleman yeni)
        {
            if (bas == null)
                bas = yeni;
            else
                son.ileri = yeni;
            son = yeni;
        }
        /// <summary>
        /// liste ortasına eleman ekleme
        /// </summary>
        /// <param name="yeni"></param>
        /// <param name="once"></param>
        public void listeOrtasınaElemanEkle(Eleman yeni, Eleman once)
        {
            yeni.ileri = once.ileri;
            once.ileri = yeni;

        }
        /// <summary>
        /// listede eleman arar.Eğer bulamazsa null değer döner
        /// </summary>
        /// <param name="deger"></param>
        /// <returns></returns>
        public Eleman listeAra(int deger)
        {
            Eleman gecici;
            gecici = bas;
            while (gecici != null)
            {
                if (gecici.icerik == deger)
                {
                    return gecici;
                }
                gecici = gecici.ileri;

            }
            return null;
        }
        /// <summary>
        /// listede indisle belirtilen elemanı getirme
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Eleman elemanGetir(int index)
        {
            Eleman gecici = bas;
            int i = 0;
            while (gecici != null && i < index)
            {
                i++;
                gecici = gecici.ileri;
            }
            return gecici;
        }
        /// <summary>
        /// liste basından eleman sil
        /// </summary>
        public void listeBasındanElemanSil()
        {
            bas = bas.ileri;
            if (bas == null)
                son = null;

        }

        /// <summary>
        /// liste sonundan eleman silme 
        /// </summary>
        public void listeSonundanElemandSil()
        {
            Eleman gecici, once;
            gecici = bas;
            once = null;
            while (gecici != son)
            {
                once = gecici;
                gecici = gecici.ileri;
            }
            if (once == null)
                bas = null;
            else
                once.ileri = null;
            son = once;



        }
        /// <summary>
        /// listeden eleman siler 
        /// </summary>
        /// <param name="atılan"></param>
        public void listedeSil(Eleman e)
        {
            Eleman gecici, onceki;
            gecici = bas;
            onceki = null;
            while (gecici != e)
            {
                onceki = gecici;
                gecici = null;
            }
            onceki.ileri = e.ileri;


        } 
        /// <summary>
        /// listedeki eleman sayısını döner
        /// </summary>
        /// <returns></returns>
        public int ElemanSayısı()
        {
            int sayac = 0;
            Eleman gecici = bas;
            while (gecici!=null)
            {
                gecici = gecici.ileri;
                sayac++;

            }
            return sayac;
        }

    


    }

}
