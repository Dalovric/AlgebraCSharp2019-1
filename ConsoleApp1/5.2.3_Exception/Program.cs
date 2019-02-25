using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._3_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Unesi cijeli broj: ");
                int a = int.Parse(Console.ReadLine());
                if (a > 0)
                {
                    Console.WriteLine("Uneseni broj je pozitivan.");
                }
                else if (a < 0)
                {
                    Console.WriteLine("Uneseni broj je negativan.");
                }
                else
                {
                    Console.WriteLine("Uneseni broj je jednak nuli.");
                }
            }
            catch (Exception e)

            {
                Console.WriteLine("Opis greske: " + e.Message + e.ToString());
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}

