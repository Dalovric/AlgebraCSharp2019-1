using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_11._3
{
    class Program
    {
        static void Main(string[] args)
        {
            long skolarina = 1200;

            List<Ucenik> listaUcenika = new List<Ucenik>();

            Ucenik ucenik1 = new Ucenik("Ivan", "Ivic");

            Ucenik ucenik2 = new Ucenik("Marko", "Maric", 12345678901);

            Ucenik ucenik3 = new Ucenik("Iva", "Ivic", 12345678901, 4500 );

            listaUcenika.Add(ucenik1);
            listaUcenika.Add(ucenik2);
            listaUcenika.Add(ucenik3);

            foreach (Ucenik uc in listaUcenika)

            {
                //Console.WriteLine("Ime: {0} Prezime: {1}, racun:{2}", uc.Ime, uc.Prezime, uc.Racun);
                Console.WriteLine(uc.ToString());
                uc.Racun -= skolarina; 
            }

            Console.WriteLine("");

            foreach (Ucenik uc in listaUcenika)

            {
                Console.WriteLine("Ime: {0} Prezime: {1}, racun:{2}", uc.Ime, uc.Prezime, uc.Racun);
                
            }



            Console.ReadKey();


        }
    }
}
