using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._4_x_znamenkasti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi jedan cijeli broj: ");
            int i = int.Parse(Console.ReadLine());

            if (i < 0) i = -i;
            if (i < 10)
            {
                Console.WriteLine("Uneseni broj je jednoznamenkast");
            }
            else if (i < 100)
            {
                Console.WriteLine("Uneseni broj je dvoznamenkast");
            }
            else if (i < 1000)
            {
                Console.WriteLine("Uneseni broj je troznamenkast");
            }
            else
            {
                Console.WriteLine("Uneseni broj je viseznamenkast");
            }
            Console.ReadKey();
        }
    }
}
