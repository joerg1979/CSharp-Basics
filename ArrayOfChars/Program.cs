using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mehrzeiliges Zeichenketten-Literal
            string stringAsChars = "Dieser lange Satz sagt zwar nichts spezielles aus"+
                " aber taugt aber als Beispiel zur Verdeutlichung.";
            
            // Initialisierung und Wertzuweisung mit HelperMethode
            char[] charArray = stringAsChars.ToCharArray();
            
            // Umkehr der Zeichenfolge im ArrayOfChars
            Array.Reverse(charArray);

            // Iteration durch das Array
            foreach (char stringChar in charArray)
            {
                Console.Write(stringChar);
            }
            Console.ReadLine();
        }
    }
}
