using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOperanats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initislisierung von IntegerVariablen | Init Int Vars
            int a, b, x, y;
          
            // Zuweisungs Operator | Assignment operator    
            a = 5;
            b = 10;
            x = 0;
            y = 100;
           
            /* Mathematische Operationen*/
           
            /**
            * Kontruktion zur Ausgabe der Beispiele innerhalb einer
            * for-Schleife
            */
            string[] mathStatements =
            {"x = a + b;","x = b - a;","x = a * b;","x = b / a;","x = b % a;"};
            
            /*Erklärungstexte zu den Beispielen deutsch*/
            string[] mathStatementTexts_de = 
            {"AdditionsOperator","Subtraierungs Operator","Multiplikations Operator","Divisions Operator","Ganzzahlige Division"};

            /*Erklärungstexte zu den Beispielen englisch*/
            string[] mathStatementTexts_en =
            {"Addition operator","Subtraction operator","Multiplication operator","Division operator","Modulo operator"};
            
            /*Erklärungstexte zu den Beispielen beide Sprachen*/
            string[][] mathStatementTexts =
            {mathStatementTexts_de, mathStatementTexts_en};

            string introducingText_de = "Einführung in mathematische OPERATOREN";
            string introducingText_en = "Introducing a couple of OPERATORS";
            string[] introducingText =
            {
                introducingText_de,
                introducingText_en
            };

            Console.WriteLine("Please choose a language:\n 1: Deutsch \n 2: Englisch");
            string selectedLanguage = Console.ReadLine();

            int languageCode = (!selectedLanguage.Equals("2")) ? 0 : 1;


            Console.WriteLine((languageCode == 0)
                ?"Kanns losgehen?\nEnter zum starten"
                :"Ready to go?\npress enter to start");
            Console.ReadLine();

            /**
                Mathematische Operatoren | Mathematical operators
            */

            Console.WriteLine(introducingText[languageCode]);
            Console.ReadLine();
            // Verarbeitung 
            for (int i = 0; i < mathStatements.Length; i++)
            {
                Console.WriteLine(mathStatementTexts[languageCode][i]);
                Console.WriteLine(mathStatements[i]);
                Console.ReadLine();
            }
        }
    }
}
