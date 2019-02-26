using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._2_primjeri_While
{
    class Program
    {
        static void Main(string[] args)
        {
            string ime = "";
            while (ime != "kraj")
            {
                Console.Write("Unesite ime:");
                ime = Console.ReadLine();
                if (ime != "kraj")
                {
                    Console.WriteLine("Dobar dan, {0}!", ime);
                }
            }
        }
    }
}
