using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ06
{
    internal class Student : Osoba
    {

        public double Prosek {  get; set; }
        public int Godina { get; set; }

        public Student(string ime, string prezime, string jMBG, double prosek, int godina) : base(ime, prezime, jMBG)
        {
            this.Prosek = prosek;
            this.Godina = godina;

        }

        public override string ispisOsobe()
        {
            return $"{Ime} {Prezime} [{Godina}] - {Prosek}";
        }
    }
}
