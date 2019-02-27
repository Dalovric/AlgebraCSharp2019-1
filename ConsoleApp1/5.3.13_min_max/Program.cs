using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._13_min_max
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 1; i <= 10; i++)

            {
                Console.WriteLine("Unesi broj");
                int n = int.Parse(Console.ReadLine());

                if (n < min)
                {
                    min = n;
                }
                if (n > max)
                {
                    max = n;
                }
            }
            Console.Write("Najmanji = {0}, najveci = {1}", min, max);
            Console.ReadKey();
        }
    }
}
