using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._6_Dobar_broj_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi jedan broj: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 5 == 0 || a % 3 == 0)
            {
                Console.WriteLine("Broje je dobar!");
            }
            else
            {
                Console.WriteLine("Broj nije dobar!");
            }
            Console.ReadKey();
        }
    }
}
