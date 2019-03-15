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
            
                while(true)
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

                List<string> rijeciSaSlovomA = (from ri in skup where ri.Contains("a") select ri).ToList();
                List<string> rijeciSaSlovomB = (from ri in skup where ri.Contains("b") select ri).ToList();
                List<string> rijeciSaSlovomC = (from ri in skup where ri.Contains("c") select ri).ToList();

                foreach (string rij1 in rijeciSaSlovomA)
                {
                    Console.Write(rijec + ", ");
                }

                foreach (string rij1 in rijeciSaSlovomA)
                {
                    Console.Write(rijec + ", ");
                }

                foreach (string rij1 in rijeciSaSlovomA)
                {
                    Console.Write(rijec + ", ");
                }

                Console.ReadKey();
            }

        }
    }
}
