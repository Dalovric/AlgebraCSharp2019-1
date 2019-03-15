using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite jedan prirodan broj: ");
            int br = int.Parse(Console.ReadLine());

            ArrayList arr = new ArrayList();
                while (br > 0)
            {
                arr.Add(br % 10);
                br /= 10;

            }
            Console.WriteLine("Ispis broja naopako: ");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i]);
            }
            Console.ReadKey();

        }
    }
}
