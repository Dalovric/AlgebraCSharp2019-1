using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._5_djeljivi_s_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Unesi prvu granicu intervala");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesi drugu granicu intervala");
                int b = int.Parse(Console.ReadLine());

                if (b < a)
                {
                    throw new Exception("Neispravan interval");
                }

                for (int i = a; i <= b; i++)
                {
                    if (i % 3 == 0)
                        Console.Write("{0} ", i);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
