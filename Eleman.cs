using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BağlıListe
{
    public class Eleman
    {
       public int icerik;
       public Eleman ileri;
        public Eleman(int icerik)
        {
            this.icerik = icerik;
            ileri = null;
        }
    }
}
