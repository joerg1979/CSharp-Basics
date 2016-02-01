using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Tinka", "Tabsi", "Purzi", "Karo", "Jörg" };
            Console.WriteLine("Ausgabe aller Einträge im Array");

            foreach (var name in names)
            {
                Console.WriteLine("Name aus dem Array: "+name);
            }
            Console.Write("Press [Enter] zum beenden.");
            Console.ReadLine();
        }
    }
}
