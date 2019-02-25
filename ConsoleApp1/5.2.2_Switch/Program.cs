using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._2_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primjer kalkulator

            float a = 0, b = 0;
            string operacija = "";

            try
            {
                Console.WriteLine("Unesi prvi prirodan broj: ");
                a = float.Parse(Console.ReadLine());

                Console.WriteLine("Unesi drugi prirodan broj: ");
                b = float.Parse(Console.ReadLine());

                Console.WriteLine("Unesi operaciju + - * /");
                operacija = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                switch (operacija)
                {
                    case "+":
                    case "plus":
                        Console.WriteLine("Zbroj je {0} + {1} = {2}", a, b, a + b);
                        break;
                    case "-":
                        Console.WriteLine("Razlika je {0} - {1} = {2}", a, b, a - b);
                        break;
                    case "*":
                    case "x":
                        Console.WriteLine("Umnozak je {0} * {1} = {2}", a, b, a * b);
                        break;
                    case "/":
                            Console.WriteLine("Kvocijent je {0} / {1} = {2}", a, b, a / b);
                        break;
                    default:
                            Console.WriteLine("Nepoznata operacija");
                        break;
                        
                }
            }
            Console.ReadKey();
        }
    }
}
