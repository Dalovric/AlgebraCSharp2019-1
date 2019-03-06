using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._1_krug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi opseg kruga: ");
            double o = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesi povrsinu kruga: ");
            double p = double.Parse(Console.ReadLine());

            Console.WriteLine("Radijus prvog kruga je {0}, a radijus drugog {1}", radijus(o), radijus2(p));
            Console.ReadKey();
        }

        static double radijus (double broj)
        {
            return broj / (2 * 3.14);
        }
        static double radijus2 (double broj)
        {
            return Math.Sqrt(broj / 3.14);
        }
            
        
    }
}
