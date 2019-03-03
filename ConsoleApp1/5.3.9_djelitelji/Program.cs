using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._9_djelitelji
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi jedan prirodni broj");
            try
            {
                int a = int.Parse(Console.ReadLine());
                if (a < 0)
                    throw new Exception("Uneseni broj mora biti veci od nule");
                for (int i = 1; i <= a; i++)
                {
                    if (a % i == 0)
                    {
                        Console.Write("{0} ", i);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dogodila se greška:");
                Console.WriteLine("Opis greške: " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
            
            
            
            
        }
    }
}
