using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._7_djeljivi_sa_7_ne_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i % 7 == 0 && i % 3 != 0)
                {
                    Console.Write("{0} ", i);
                }
             
            }
            Console.ReadKey();
        }
    }
}
