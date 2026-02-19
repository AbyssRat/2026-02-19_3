using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalapacsVetesKonzol
{
    internal class Sportolo
    {
        public int Helyezes { get; set; }
        public double Eredmeny { get; set; }
        public string Nev { get; set; }
        public string Orszag { get; set; }
        public string Helyszin { get; set; }
        public DateTime Datum { get; set; }

        public Sportolo(int helyezes, double eredmeny, string nev, string orszag, string helyszin, DateTime datum)
        {
            Helyezes = helyezes;
            Eredmeny = eredmeny;
            Nev = nev;
            Orszag = orszag;
            Helyszin = helyszin;
            Datum = datum;
        }
    }
}
