using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1_enum
{

    public enum RadniDani
    {
        Ponedjeljak = 1,
        Utorak,
        Srijeda,
        Cetvrtak,
        Petak
    }

    public enum Ocjene
    {
        Nedovoljan = 1,
        Dovoljan,
        Dobar,
        Vrlodobar,
        Odlican
    }

    public enum Katovi
    {
        Prizemlje,
        Prvi,
        Drugi,
        Treci,
        Cetvrti
    }



    class Program
    {
        static void Main(string[] args)
        {
            Firma algebra = new Firma("Algebra d.o.o");
            algebra.Kat = Katovi.Treci;
            Console.WriteLine(algebra);
        }
    
}
    class Firma
{
        private Katovi kat;
        private string naziv;

        public Firma(string v)
        {
            this.Naziv = v;
        }

        public Katovi Kat { get => kat; set => kat = value; }
       
        public string Naziv { get; private set; }

        public override string ToString()
        {
            string kojiKat = "";
            switch ((int)kat)
            {
                case 0: kojiKat = "nultom"; break;
                case 1: kojiKat = "prvom"; break;
                case 2: kojiKat = "drugom"; break;
                case 3: kojiKat = "trecem"; break;
                case 4: kojiKat = "cetvrtom"; break;
                default: kojiKat = "nepoznatom"; break;
            }
            return "I nase ime je " + this.naziv + "i nalazimo se na " + kojiKat + " katu";
        }
        
    }
    
}
