using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._4_faktorijel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molim unesi cijeli pozitivni broj: ");
            // 5! = 120 (1*2*3*4*5)
            try {
                int a = int.Parse(Console.ReadLine());
                if (a <= 0)
                {
                    throw new NegativeNumberException("Negativni broj!");
                }
                if (a >= 20)
                {
                    throw new Exception("Broj je veci od 20!");
                }
                int faktorijel = 1;
                for (int i = a; i > 0; i--)
                {
                    // Console.WriteLine(i);
                    faktorijel *= i;
                }
                Console.Write("{0}", faktorijel);
            }

            catch (NegativeNumberException ex)
            {
                Console.WriteLine("Dozvoljeni brojevi su pozitivni", ex.ToString());
            }
            catch (VeciOdDvadeset ex)
            {
                Console.WriteLine("Dozvoljeni brojevi su u intervalu od [1,19]", ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
            }
        }
    public class NegativeNumberException: Exception
    {
        public NegativeNumberException()
        {

        }
    public class VeciOdDvadeset : Exception
        {
            public NegativeNumberException()
            {

            }
        }
        public class VeciOdDvadeset (string message)
        {
            public NegativeNumberException()
            {

            }
        }

    } 
