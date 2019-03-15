using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> skup = new List<string>();

            while (true)
            {
                Console.WriteLine("Upisi rijec: ");
                string rijec = Console.ReadLine();

                if (rijec.ToLower() == "kraj")
                {
                    break;
                }
                else
                {
                    skup.Add(rijec);
                }
            }
            List<string> rijeciSaSlovomA = (from ri in skup where ri.ToString().StartsWith("a") select ri).ToList();
            List<string> rijeciSaSlovomB = (from ri in skup where ri.ToString().StartsWith("b") select ri).ToList();
            List<string> rijeciSaSlovomC = (from ri in skup where ri.ToString().StartsWith("c") select ri).ToList();

            Console.WriteLine("Rijeci koje pocinju sa A:");
            foreach (string rij1 in rijeciSaSlovomA)
            {
                Console.Write(rij1 + ", ");
            }
            Console.WriteLine("Rijeci koje pocinju sa B:");
            foreach (string rij1 in rijeciSaSlovomB)
            {
                Console.Write(rij1 + ", ");
            }
            Console.WriteLine("Rijeci koje pocinju sa C:");
            foreach (string rij1 in rijeciSaSlovomC)
            {
                Console.Write(rij1 + ", ");
            }

            Console.ReadKey();
        }

    }

}
        
    

