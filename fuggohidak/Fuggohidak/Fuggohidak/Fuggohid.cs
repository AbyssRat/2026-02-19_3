using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggohidak
{
    internal class Fuggohid
    {
            public int Helyezes { get; set; }
            public string Hid { get; set; }
            public string Hely { get; set; }
            public string Orszag { get; set; }
            public int Hossz { get; set; }
            public int Ev { get; set; }

            public Fuggohid(int helyezes, string hid, string hely, string orszag, int hossz, int ev)
            {
                Helyezes = helyezes;
                Hid = hid;
                Hely = hely;
                Orszag = orszag;
                Hossz = hossz;
                Ev = ev;
            }

        
    
    }
}
