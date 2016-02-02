using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            bool whileAlive = true;
            string breakCondition = "JA";
            int i = 1;
            Console.WriteLine("Schleifen Abbruchbedingung: {0}",breakCondition);
            Console.WriteLine("Schleife mit [Enter] beginnen.");
            Console.ReadLine();

            while (whileAlive)
            {
                Console.WriteLine("Schleifendurchlauf {0}: Geben Sie '{1}' ein um die Schleife abzubrechen",i, breakCondition);
                userInput = Console.ReadLine();
                if (userInput.Equals(breakCondition))
                {
                    Console.WriteLine("Schleifendurchlauf wird nun bei der {0}. Iteration abgebrochen", i);
                    Console.WriteLine("Eingabe durch den Benutzer: {0}", userInput);
                    Console.ReadLine();
                    whileAlive = false;
                }
                Console.WriteLine("Schleife wird nicht abgebrochen, Eingabe stimmt nicht mit der Abruchbedingung überein {0}/{1}\n",
                    userInput,breakCondition);
                i++;
            }
            Console.WriteLine("Schleife beendet.");
            Console.ReadLine();
        }
    }
}
