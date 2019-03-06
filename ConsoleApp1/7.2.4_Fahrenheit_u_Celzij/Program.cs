using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._4_Fahrenheit_u_Celzij
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite stupnjeve u Fahrenheit-ima:");
            double fr = double.Parse(Console.ReadLine());

            Console.WriteLine("Uneseni Fahrenheiti u Celzijima iznose {0}", FruCz(fr));
            Console.ReadKey();
        }
        static double FruCz (double br)

        {
            return (double)5 / 9 * (br - 32);
        }
    }
}
