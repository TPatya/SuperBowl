using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SuperBowl
{
    internal class Donto
    {
        public string Ssz { get; set; }

        public string Datum { get; set; }

        public string Gyoztes { get; set; }

        public string Eredmeny { get; set; }

        public string Vesztes { get; set; }

        public string Helyszin { get; set; }

        public string VarosAllam { get; set; }

        public int NezoSzam { get; set; }

        public Donto(string sor)
        {
            string[] s = sor.Split(';');

            Ssz = s[0];

            Datum = s[1];

            Gyoztes = s[2];

            Eredmeny = s[3];

            Vesztes = s[4];

            Helyszin = s[5];

            VarosAllam = s[6];

            NezoSzam = int.Parse(s[7]);
        }
    }
}
