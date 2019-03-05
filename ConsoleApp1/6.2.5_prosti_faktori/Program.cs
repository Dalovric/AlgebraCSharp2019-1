using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._5_prosti_faktori
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = int.Parse(Console.ReadLine());

            List<int> prosti = new List<int>();
            int faktor = 2;
            while(faktor<=broj)
            {
                if (broj % faktor == 0)
                {
                    prosti.Add(faktor);
                    broj = broj / faktor;
                }
                else
                {
                    faktor++;

               }
                
            }
            foreach (int item in prosti)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
    }
}
