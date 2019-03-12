using _8._1._2_automobil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3._1_nasljedjivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik uc1 = new Ucenik();  // Osoba() i Ucenik()
            Ucenik uc2 = new Ucenik("Anica");   //Osoba()
            Ucenik uc3 = new Ucenik("Perica","Peric");  //Osoba()

            List<Ucenik> ucenici = new List<Ucenik> { uc1, uc2, uc3 };
            foreach (var item in ucenici)

            {
                Console.WriteLine(item);
            }


            // dodaj vozace
            Vozac vo1 = new Vozac("Luka", "Krilic");  //Osoba()
            vo1.Kategorija_a = true;
            vo1.Kategorija_c = true;

            var a1 = new Automobil();
            a1.MarkaAutomobila = "Ford";
            vo1.Automobil.Add(a1);

            var a2 = new Automobil();
            a2.MarkaAutomobila = "Mazda";
            vo1.Automobil.Add(a2);

            Vozac vo2 = new Vozac("Janko", "Jakic");  //Osoba()
            vo2.Kategorija_b = true;
            vo2.Kategorija_d = true;

            Pilot pi1 = new Pilot("Marko", "Jakic");  //Osoba()
            pi1.Kategorija_b = true;
            pi1.Kategorija_d = true;
            pi1.Kategorija_x = true;

            List<Vozac> vozaci = new List<Vozac> { vo1, vo2 };
            foreach (var item in vozaci)

            {
                Console.WriteLine(item);
            }

            List<Pilot> piloti = new List<Pilot> { pi1 };
            foreach (var item in piloti)

            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
