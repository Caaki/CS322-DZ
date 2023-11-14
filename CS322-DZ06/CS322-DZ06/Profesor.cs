using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ06
{
    internal class Profesor : Osoba
    {
        public double plata;
        public List<String> predmeti;
        
        public Profesor(string ime, string prezime, string jMBG, double plata, List<String> predmeti) : base(ime, prezime, jMBG)
        {
            this.plata = plata;
            this.predmeti = predmeti;
        }

        public override string ispisOsobe()
        {
            String sviPredmeti = "";
            for (int i = 0; i < predmeti.Count; i++)
            {
                sviPredmeti += $"\n [{i}] "+predmeti[i];
            }
            return Ime + " " + Prezime + "" + sviPredmeti;   
        }
    }
}
