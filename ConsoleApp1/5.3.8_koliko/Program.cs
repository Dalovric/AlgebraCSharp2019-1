using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._8_koliko
{
    class Program
    {
        static void Main(string[] args)
        {
            int koliko = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0 && i % 3 != 0)
                    koliko ++;
            }
            Console.WriteLine("U intervalu [1,100] djeljivih sa 7, a ne djeljivih sa 3 ima {0}", koliko);
            Console.ReadKey();
        }
    }
}
