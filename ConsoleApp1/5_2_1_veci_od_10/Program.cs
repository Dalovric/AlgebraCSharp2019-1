using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_1_veci_od_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi prirodan broj: ");
            int a = int.Parse(Console.ReadLine());
            if (a > 10)
            {
                Console.WriteLine("Uneseni broj je veci od 10.");
            }
            else
            {
                Console.WriteLine("Uneseni broj NIJE veci od 10.");
            }
            Console.ReadKey();
        }
    }
}
