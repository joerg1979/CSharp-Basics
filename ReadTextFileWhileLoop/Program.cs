using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ReadTextFileWhileLoop
{
    /* Anweisungen 
    * 1.  Projekt->Hinzufügen->Element: Datei in das Projekt hinzufügen.
    *
    * 2.  ProjektExplorer->Eigenschaften(Textdatei)->Erweitert->
    *     "In Ausgabeverzeichnis kopieren" ==> "Copy allways" oder "Copy newer" auswählen!!!
    *
    * 3.  Die Klasse StreamReader befindet sich im Namespace "System.IO" -> 
    *     Einbinden mit: using SystemIO;  
    */

    class Program
    {
        static void Main(string[] args)
        {
            // Initialisieren des StremReaders und an den Bezeichner "myReader" binden
            StreamReader myReader = new StreamReader("MeinText2Read.txt");

            // Initialisierung der String-Variablen zum zwischenspeichern einzelner Zeilen
            string line = "";

            // Beginnen mit der while-Schleife zum zeilenweise auslesen der Datei 
            while (line != null)
            {
                // String-Variable "line" mit der nächsten Zeile aus der Quelldatei befüllen
                line = myReader.ReadLine();
                
                // Prüfung ob Ende der Datei noch nicht erreicht ist.
                // Liefert ReadLine() des StreamReaders den Wert "null" ist keine weitere Zeile vorhanden
                if (line != null)
                {
                    // Ausgabe der eingelesenen Zeile
                    Console.WriteLine(line);
                }
            }

            // Den Stream-Reader schließen
            myReader.Close();

            // Auf beenden des Programms durch Benutzeringabe warten
            Console.ReadLine();

            // Alternativ zum Zeilenweisen einlesen der Datei kann,
            // die StreamReader.Methode  myReader.ReadToEnd();  verwendet werden..
        }
    }
}
