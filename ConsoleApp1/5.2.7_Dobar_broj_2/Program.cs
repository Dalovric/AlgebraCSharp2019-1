using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._7_Dobar_broj_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi jedan broj: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 4 == 0 && a > 100)
            {
                Console.WriteLine("Broj je dobar!");

            }
            else
            { 
                Console.WriteLine("Broj nije dobar");
            }
            Console.ReadKey();
        }
        
    }
}
