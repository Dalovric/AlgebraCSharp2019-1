using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._1_neparni_do_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Neparni brojevi manji jednaki od 20");

            for (int i = 1; i <= 20; i+=2)
            {
                Console.WriteLine("{0} ", i.ToString());
            }
            Console.ReadKey();
        }
    }
}
