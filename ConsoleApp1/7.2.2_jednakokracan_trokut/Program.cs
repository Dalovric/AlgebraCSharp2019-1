using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._2_jednakokracan_trokut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite povrsinu jednakokracnog trokuta");
            double p = double.Parse(Console.ReadLine());

            Console.WriteLine("Kateta jednakokračnog trokuta iznosi: {0}", kateta(p));
            Console.ReadKey();
        }
        static double kateta (double broj)
        {
            return Math.Sqrt(2 * broj);
        }
    }
}
