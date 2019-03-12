using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_objekti
{
    class Program
    {
        static void Main(string[] args)

        {
            long skolarina = 1200;

            List<Ucenik> listaUcenika = new List<Ucenik>();

            Ucenik ucenik1 = new Ucenik("Marko", "Maric");

            Ucenik ucenik2 = new Ucenik("Jerko", "Kovac", 12345678901);

            Ucenik ucenik3 = new Ucenik("Mario", "Mihic", 12345678901, 4500);

            listaUcenika.Add(ucenik1);
            listaUcenika.Add(ucenik2);
            listaUcenika.Add(ucenik3);

            foreach (Ucenik uc in listaUcenika)
            {
                //Console.WriteLine("Ime {0}, prezime {1}, racun {3}", uc.Ime, uc.Prezime, uc.Racun);
                Console.WriteLine(uc.ToString());
                uc.Racun -= skolarina;
            }

            Console.WriteLine("");


            foreach (Ucenik uc in listaUcenika)
            {
                Console.WriteLine("Ime {0}, prezime {1}, racun {2}", uc.Ime, uc.Prezime, uc.Racun);
                
            }

            Console.ReadKey();
        }
    }
}
