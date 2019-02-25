using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._4._2_Direktor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi ime: ");
            String ime = Console.ReadLine();

            if (ime=="Tomislav" || ime=="Hrvoje" || ime=="Mislav")
            {
                Console.WriteLine("Dobar dan direktore!");
            }
            else
            {
                Console.WriteLine("Bok!");
            }

            Console.ReadKey();
        }
    }
}
