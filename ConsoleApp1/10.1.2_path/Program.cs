using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._2_path
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapa u kojoj se izvrsava nas program");
            Console.WriteLine(Environment.CurrentDirectory);

            Console.Write("Postoji li file Proba.txt u izvrsnoj mapi");

            // Path klasa
            string mojaPutanja = Path.Combine(Environment.CurrentDirectory, "Proba.txt");

            // File klasa
            Console.WriteLine(File.Exists(mojaPutanja));

            // Directory klasa
            if (!Directory.Exists("Proba"))
            {
                // Ako ne postoji folder Proba, kreiram ga
                Directory.CreateDirectory("Proba");
            }

            // Ispisujem sve foldere na C-u
            Console.WriteLine("Direktorij na C:");
            string[] sDirs = Directory.GetDirectories(@"C:\");
            foreach (string sDir in sDirs)
            {
                Console.WriteLine(sDir);
            }

            // Ispisujem sve fileove na C-u
            Console.WriteLine("Datoteke na C:");
            string[] sFiles = Directory.GetFiles(@"C:\");
            foreach (string sFile in sFiles)
            {
                Console.WriteLine(Path.GetFileName(sFile));
            }
            Console.ReadKey();
        }
    }
}
