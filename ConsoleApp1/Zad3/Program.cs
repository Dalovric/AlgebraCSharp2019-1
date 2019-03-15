using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil automobil = new Automobil();

            Console.WriteLine("Unesite naziv automobila: ");
            automobil.Naziv = Console.ReadLine();

            Console.WriteLine("Unesite godinu proizvodnje");
            automobil.GodinaProizvodnje = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite osnovnu cijenu: ");
            automobil.OsnovnaCijena = double.Parse(Console.ReadLine());
        
        }
    }
}
