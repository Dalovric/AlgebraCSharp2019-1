using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._10_savresn_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodan broj: ");
            int a = int.Parse(Console.ReadLine());

            int zbrojDjelitelja = 0;

            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    zbrojDjelitelja += i;
                }
            }
            if (a == zbrojDjelitelja)
            {
                Console.WriteLine("Broj je savršen.");
            }
            else
            {
                Console.WriteLine("Broj nije savršen");
            }
            Console.ReadKey();
        }
    }
}
