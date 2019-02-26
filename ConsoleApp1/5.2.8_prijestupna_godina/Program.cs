using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._8_prijestupna_godina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi godinu: ");
            int a = int.Parse(Console.ReadLine());

            if ((a % 4 == 0 && a % 100 != 0) || (a % 400 == 0))
            {
                Console.WriteLine("Godina je prijestupna.");
            }
            else
            {
                Console.WriteLine("Godina nije prijestupna.");
            }
            Console.ReadKey();
                
        }
    }
}
