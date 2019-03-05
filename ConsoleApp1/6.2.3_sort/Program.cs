using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._3_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi brojeve, za prekid 0");
            List<int> listaBrojeva = new List<int>();

            int br = -1;

            while(br!= 0)
            {
                br = int.Parse(Console.ReadLine());
                listaBrojeva.Add(br);
            }
            listaBrojeva.Sort();

            Console.WriteLine("Ispis: ");
            foreach (int a in listaBrojeva)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
