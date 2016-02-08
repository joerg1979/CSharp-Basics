using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            string escapeInfoText = "Das Escapen von Zeichen erfolgt in C# mittels des Backslashes.";
            string backslashExampleText = "Ausgabebeispiel: Go to your c:\\; \nSchreibweise: Go to your c:\\\\"; 
            Console.WriteLine(escapeInfoText + " \n" + backslashExampleText);
            Console.ReadLine();

            string doubleQuotationsInfoText = "Innerhalb von Zeichenketten-Literalen müssen darzusetllene Anführungszeichen ebenfalls mit einem Backslash 'escaped' werden!";
            string doubleQuotationsExampleText = "Ausgabebeispiel: Text in \"Anführungszeichen\" \nSchreibweise: Text in \\\"Anführungszeichen\\\" ";
            Console.WriteLine(doubleQuotationsInfoText + " \n" + doubleQuotationsExampleText);
            Console.ReadLine();

            string stringFormatInfoText = string.Format("Strings können mit Hilfe von string.Format() formatiert werden");
            string stringFormatExampleText = "Anwendungsbeispiel: Marke => BMW \nSchreibweise: string.Format(\"{0} => {1}\", \"Marke\", brand);";
            Console.WriteLine(stringFormatInfoText + " \n" + stringFormatExampleText);
            Console.ReadLine();

            string stringFormatMathNumInfoText = "Zur Formatierung von numerischen Werten kann string.Format() mit speziellen Wildcards verwendet werden!";
            Console.WriteLine(stringFormatMathNumInfoText);
            string stringFormatCurrency = string.Format("{0:C}", 150.50);           
            string stringFormatNumber = string.Format("{0:N}", 123456789);
            string stringFormatPercent = string.Format("{0:P}", .3334);
            Console.WriteLine("\nWährung: " + stringFormatCurrency+ "  => Schreibweise: string.Format(\"{ 0:C}\", 150.50);");
            Console.WriteLine("Zahlen: " + stringFormatNumber + "  => Schreibweise: string.Format(\"{ 0:N}\", 123456789);");
            Console.WriteLine("Prozente: " + stringFormatPercent + "  => Schreibweise: string.Format(\"{0:P}\", .3334);");
            Console.ReadLine();

            string stringFormatNumbersInfoText = "Die Formatierung kann individuell mittels #-Platzhaltern angepasst werden!";
            Console.WriteLine(stringFormatNumbersInfoText);
            string stringFormatPhone = string.Format("Tel.: {0:0###-########}", 51137381965);
            string stringFormatIntPhone = string.Format("Tel.: {0:++## (0)### ########}", 49051137381965);
            string stringFormatIntPhone2 = string.Format("Tel.: {0:00##-###-########}", 4951137381965);
            Console.WriteLine("\nNationale Telefonnummer: " + stringFormatPhone + "  => Schreibweise: string.Format(\"Tel.: {0:####-########}\", 051137381965);");
            Console.WriteLine("Internationale Telefonnummer: " + stringFormatIntPhone + "  => Schreibweise: string.Format(\"Tel.: {0 ++## (0)### ########}\", 49051137381965);");
            Console.WriteLine("Internationale Telefonnummer: " + stringFormatIntPhone2 + "  => Schreibweise: string.Format(\"Tel.: {0:00##-###-########}\", 4951137381965);");
            Console.ReadLine();
        }
    }
}
