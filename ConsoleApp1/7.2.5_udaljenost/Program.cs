using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._5_udaljenost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prvu kordinatu točke P1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugu koordinatu točke P1");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite prvu kordinatu točke P2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugu koordinatu točke P2");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Udaljenost tih dviju točaka je {0}:", udaljenost(x1, x2, y1, y2));
            Console.ReadKey();
        }

        static double udaljenost (double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
        }
    }
}
