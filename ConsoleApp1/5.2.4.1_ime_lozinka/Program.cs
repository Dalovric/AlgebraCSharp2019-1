using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._4._1_ime_lozinka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite korisnicko ime: ");
            string korisnickoIme = Console.ReadLine();

            Console.Write("Unesite lozinku: ");
            string lozinka = Console.ReadLine();

            if (korisnickoIme=="Pero" && lozinka=="123")
            {
                Console.WriteLine("Uspjesno logiranje");
            }
            else
            {
                Console.WriteLine("Pristup odbijen!");
            }

            Console.ReadKey();
        }
    }
}
