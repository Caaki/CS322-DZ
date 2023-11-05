using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ05
{

    /*
    
    2. Napraviti klasu Posetioc koja ima od podataka Ime, Prezime i broj ulaznice. Zatim napraviti
    pomoćnu klasu koja ima metodu koja vraća reč od 8 random slova pri čemu je prvo slovo
    veliko
    a ostala su mala, i metodu koja vraća slučajni ceo broj u intervalu od 1 do 200. Obratiti paznju
    na prava pristupa osobinama/varijablama klase, i kreirati potrebne getere i setere.
    U pokretackoj klasi kreirati dve instance klase Posetioc i svaku od njih napuniti random
    podacima koristeći pomoćnu klasu. Prikazati rezultat rada. 

     */


    internal class Posetioc
    {
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public int BrojUlazinice {  get; set; }

        public Posetioc() { }

        public Posetioc(string ime, string prezime, int brojUlazinice)
        {
            Ime = ime;
            Prezime = prezime;
            BrojUlazinice = brojUlazinice;
        }
    }
}
