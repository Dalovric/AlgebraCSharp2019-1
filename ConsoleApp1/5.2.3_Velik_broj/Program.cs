using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._3_Velik_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi jedan broj: ");
            double a = double.Parse(Console.ReadLine());

            if (a >= 100)
            {
                Console.WriteLine("Broj je velik.");

            }
            else
            {
                Console.WriteLine("Broj nije velik.");
            }
            Console.ReadKey();
        }
    }
}
