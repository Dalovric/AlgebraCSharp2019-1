using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._4._3_Skola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi ime skole koju pohadjate: ");
            string skola = Console.ReadLine();

            if (!(skola=="Algebra"))
            {
                Console.WriteLine("Upisite seminar u Algebri!");
                Console.ReadKey();
            }
        }
    }
}
