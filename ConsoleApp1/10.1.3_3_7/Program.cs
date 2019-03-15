using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._3_3_7
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream fs1 = new FileStream("3ili7uNoviRed.txt", FileMode.Create);
            StreamWriter sw1 = new StreamWriter(fs1);

            FileStream fs2 = new FileStream("3ili7saZarezima.txt", FileMode.Create);
            StreamWriter sw2 = new StreamWriter(fs2);

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    sw1.WriteLine(i);
                    sw2.Write("{0}, ", i);
                }

            }
            sw1.Flush();
            sw1.Close();
            fs1.Close();
            sw2.Flush();
            sw2.Close();
            fs2.Close();
            

            }
        }
    }

