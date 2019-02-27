using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._17_Potencije
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            for (int i = 1; i <= 10; i++)
            {
                n = 1;
                for (int j = 1; j <= i; j++)
                {
                    n *= 2;

                }
                Console.WriteLine("2 na {0} = {1}", i, n);
            }
            Console.ReadKey();
        }
    }
}
