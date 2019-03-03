using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._12_suma_prosjek
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int suma = 0;

                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Unesi {0}. prirodan broj: ", i);
                    int br = int.Parse(Console.ReadLine());
                    if (br < 0)
                        throw new Exception("Uneseni broj mora biti veci od nule.");
                    suma += br;
                }
                float prosjek = (float)suma / 5;
                Console.WriteLine("Suma prirodnih brojeva je {0}, a prosjek {1}", suma, prosjek);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dogodila se greška.");
                Console.WriteLine("Opis greške: " + ex.Message);

            }
            
            Console.ReadKey();
        }
    }
}
