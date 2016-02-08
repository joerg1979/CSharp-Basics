using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToGetSubstringed = "Ein bestimmter Teil einer Zeichenkette kann mittels Substring(von,bis) erzeugt werden.\n" +
                "Beispiel: stringToGetSubstringed.Substring(0, 83) => liefert die ersten 84 Zeichen der vorherigen Zeichenkette!";
            Console.WriteLine(stringToGetSubstringed);
            Console.ReadLine();
            Console.WriteLine(stringToGetSubstringed.Substring(0, 83));
            Console.ReadLine();

            Console.WriteLine("Eine Zeichenkette in Großbuchstaben umwandeln mittels:  lowerCaseString.ToUpper() ");
            string lowerCaseString = "alles in kleinen buchstaben";
            Console.WriteLine(lowerCaseString + " => " + lowerCaseString.ToUpper());
            Console.ReadLine();

            Console.WriteLine("Alle \"Leerzeichen\" einer Zeichenkette umwandeln zu \"--\" mittels: lowerCaseString.Replace(\"\",\"--\")");
            Console.WriteLine(lowerCaseString + " => " + lowerCaseString.Replace(" ", "--"));
            Console.ReadLine();

            string string2Trim = "   Die 3 Leerzeichen am Beginn und am Ende dieser Zeichenkette können entfernt mittels \"string2Trim.Trim()\" entfernt werden.   ";
            Console.WriteLine(string2Trim);
            Console.ReadLine();
            Console.WriteLine("Länge vor Trim(): {0} => Länge nach Trim(): {1}", string2Trim.Length, string2Trim.Trim().Length);
            Console.WriteLine("Ausgeführter Code: Console.WriteLine(\"Länge vor Trim(): {0} => Länge nach Trim(): {1}\", string2Trim.Length, string2Trim.Trim().Length\");");
            Console.ReadLine();
        }
    }
}
