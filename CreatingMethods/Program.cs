using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Aufruf der Methode myOwnMth()
            // Zuweisung der Rückgabe an die String-Variable "answer"
            string answer = myOwnMeth();
            Console.WriteLine("Aufruf der eigenen Methode \"myOwnMethod()\" => " + answer);
            Console.ReadLine();

            // Aufruf der überladenen Methode myOwnMth("Zeichenkette")
            // Zuweisung der Rückgabe an die String-Variable "secondAnswer"
            string argumentString = "Name: Jörg";
            string secondAnswer = myOwnMeth(argumentString);
            Console.WriteLine("Aufruf der eigenen überladenen Methode \"myOwnMethod("+
                argumentString + ")\" => " + secondAnswer);
            Console.ReadLine();

            // Aufruf der Überladenen Methode myOwnMth(666)
            // Zuweisung der Rückgabe an Integer-Variable "thirdAnswer"
            int thirdAnswer = myOwnMeth(666);
            Console.WriteLine("Aufruf der eigenen überladenen Methode \"myOwnMethod(666)\" => Rückgabe: " +
                thirdAnswer);
            Console.ReadLine();
        }

        // Die eigene Methode "myOwnMeth()"
        /** Eigenschaft     -verwendeter Wert       -mögliche Werte
        *   Sichtbarkeit:   privat                  |public|protected|
        *   Art:            statische Methode       |nicht statisch(keine Angabe nötig)
        *   Rückgabe-Typ:   String                  |void|int|double|char||etc.
        *   Parameter:      keine                   |int|double|char|string|etc.
        */
        private static string myOwnMeth()
        {
            return "Rückgabewert von: 'myOwnMeth()'";
        }

        //Überladene Methode erwartet einen String
        public static string myOwnMeth(string name)
        {
            return String.Format("Rückgabewert von: 'myOwnMeth({0})",name);
        }

        //Überladene Methode erwartet einen Interger-Wert
        public static int myOwnMeth(int number)
        {
            return number;
        }
    }
}
