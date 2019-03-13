// using _8._1._2_Prirucnik;
using System;

namespace BusinessLayer
{
    public abstract class Osoba
    {
        private string ime = "";
        public string prezime = "";
        public DateTime datumNastanka;
        

        public string Ime { get => ime; set => ime = ToUpper.FirstCharToUpper(value); }

        public Osoba()
        {
            this.datumNastanka = DateTime.Now;
            Console.WriteLine("Pozvana metoda Osoba:Osoba()");
        }

        public Osoba(string v1, string v2)
        {
            this.ime = v1;
            this.prezime = v2;
        }
    }
}