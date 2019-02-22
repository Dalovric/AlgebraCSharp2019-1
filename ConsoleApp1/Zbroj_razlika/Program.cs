using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbroj_razlika
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 0, b = 0;
            Console.Write("Unesite 1. broj:");
            a = int.Parse(Console.ReadLine());

            Console.Write("Unesite 2. broj:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Zbroj je:{0}", a + b);
            Console.WriteLine("Razlika je:{0}", a - b);

            Console.WriteLine("Razlika je:{1} Zbroj je:{0}", a + b, a - b);

            Console.ReadLine(); */

            int a = 0, b = 0;
            Console.WriteLine("Unesite 1. broj:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite 2. broj:");
            b = int.Parse(Console.ReadLine());

            // castanje brojeva u decimalne pri djeljeljnju jer rezultat moze biti decimalni
            Console.WriteLine("Umnozak je {0}, Kvocijent je {1}", a * b, (float)a / (float)b);

            Console.ReadKey();
        }
    }
}
