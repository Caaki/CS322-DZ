using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ06
{
    internal abstract class Osoba: MetodeOsoba
    {
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String JMBG { get; set; }

        protected Osoba(string ime, string prezime, string jMBG)
        {
            Ime = ime;
            Prezime = prezime;
            JMBG = jMBG;
        }

        public abstract string ispisOsobe();
    }
}
