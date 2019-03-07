using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2_Prirucnik
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sto je to nastavnik?");
            Console.WriteLine(Nastavnik.Opis());

            Console.WriteLine("Koji je koeficijent nastavnika?");
            Console.WriteLine(Nastavnik.Koeficijent());

            Nastavnik n1 = new Nastavnik();

            // ne mozemo postaviti read only property
            // n1.Ime = "Claudije";

            // ispis može
            Console.WriteLine("NJegovo ime je: " + n1.Ime);

            // OIB mozemo postaviti
            n1.Oib = 12345;

            Nastavnik.Koeficijent();

            // ne dozvoljava citanje OIB-a
            // Console.WriteLine("Njegov OIB je:" + n1.Oib);

            // Ispisi dio OIB-a
            Console.WriteLine("NJegov OIB je " + n1.PartialOib + "********");

            //Instanciraj novi objekt klase ucenik
            Ucenik uc1 = new Ucenik();
            

            //Inicijalizacija objekta
            Console.WriteLine("Unesi ime ucenika");
            uc1.Ime = Console.ReadLine();

            Console.WriteLine("Unesi prezime ucenika");
            uc1.prezime = Console.ReadLine();

            Console.WriteLine("Unesi ocjenu iz matematike");
            uc1.ocjenaIzMatematike = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi ocjenu iz biologije");
            uc1.ocjenaIzBiologije = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi ocjenu iz engleskog");
            uc1.ocjenaIzEngleskog = int.Parse(Console.ReadLine());

            

            Console.WriteLine("Prosjek je:" + uc1.Prosjek());

            //Instanciraj novi objekt klase ucenik
            Ucenik uc2 = new Ucenik("Perica");



            Console.WriteLine("Ime ucenika je " + uc1.Ime + " i " + uc2.Ime);


            //List<Ucenik> ucenici = new List<Ucenik>(); moze i ovako
            List<Ucenik> ucenici = new List<Ucenik> { uc1, uc2 };
            ucenici.Add(uc1);
            ucenici.Add(uc2);

            foreach (var item in ucenici)

            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Nastavnici:");

            List<Nastavnik> nastavnici = new List<Nastavnik>();
            nastavnici.Add(n1);

            foreach (var item in nastavnici)

            {
                Console.WriteLine(item);
            }



            Console.ReadKey();




        }
    }
}
