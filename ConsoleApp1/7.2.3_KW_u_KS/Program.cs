using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._3_KW_u_KS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite snagu u KW:");
            double kw = double.Parse(Console.ReadLine());

            Console.WriteLine("Snaga u KS iznosi {0}:", ks(kw));
            Console.ReadKey();
        }

        static double ks (double broj)
        {
            return (1.35 * broj);
        }

    }
}
