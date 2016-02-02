using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopUnlimited
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setzen einer Zählvariablen für die Abbruchbedingung
            int i = 1;
            // While-Schleife als Endlos-Schleife
            while (true)
            {
                // Ausgabe der Nummer des aktuellen Durchlaufs
                Console.WriteLine("Durchlauf: " + i);

                // Prüfung der Bedingung welche den Abbruch der Schleife einleitet
                if (i == 5)
                {
                    // Bestätigung das die Abbruchbedingungn eingetreten ist
                    Console.WriteLine("Abbruchbedingung erreicht.({0}/5)..ende mit [Enter]", i);
                    Console.ReadLine();

                    // Abbruch der While-Schleife
                    break;
                }

                // Aufforderung einen weiteren Schleifendurchlauf zu starten da Bedingung zum Abbruch noch nicht erfüllt.
                Console.WriteLine("Abbruchbedingung noch nicht erreicht.({0}/5)..weiter mit [Enter]", i);
                Console.ReadLine();

                // Inkrementieren des Zählers
                i++;
            }
    }
}
