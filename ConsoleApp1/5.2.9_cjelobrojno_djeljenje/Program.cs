using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._9_cjelobrojno_djeljenje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi jedan broj: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Broj je paran");
            }
            else
            {
                Console.WriteLine("Broj je neparan");
            }
            if (a % 3 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa tri.");
            }
            else
            {
                Console.WriteLine("Ostatak pri djeljenju s tri je {0}. ", a % 3);
            }
            Console.ReadKey();
        }

    }
}
