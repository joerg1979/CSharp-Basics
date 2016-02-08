using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Vs_Concat
{
    class Program
    {
        static void Main(string[] args)
        {

            string concatInfoText = "Zeichenketten können mittels +(Concat-Operator) verbunden werden. \nAllerdings führt dies dazu dass für jede Verkettung ein neuer " +
                "Speicherbereich für das neue String-Objekts reserviert und zugewiesen werden muss. \nIm kleinen Rahmen ist dies nicht problematisch, allerdings sollte " +
                "besser der StringBuilder() verwendet werden. \nDiese Klasse ist genau für diesen Anwendugsfall konzipiert und umgeht die Speicherverschwendung";

            Console.WriteLine(concatInfoText);
            Console.ReadLine();

            string concatString = "0";
            for (int i = 1; i < 100; i++)
            {
                concatString += "--" + i.ToString();
                if (i % 25 == 0)
                    concatString += "\n";
            }
            Console.WriteLine(concatString);
            Console.WriteLine("100 Stringverkettungen (--i)\nVerwendeter Befehl innerhalb des Schleifenrumpfs: { myString += \"--\" + i.ToString();}");
            Console.ReadLine();

            Console.WriteLine("Das selbe Ergebnis mit StringBuilder() => Initialisieren mit: StringBuilder sb = new StringBuilder(); ");
            StringBuilder sb = new StringBuilder();
            sb.Append("0");
            for (int i = 1; i < 100; i++)
            {
                sb.Append("--").Append(i);
                if (i % 25 == 0)
                    sb.Append("\n");
            }
            Console.WriteLine(sb.ToString());
            Console.WriteLine("Verwendeter Befehl innerhalb des Schleifenrumpfs: {sb.Append(\"--\").Append(i);}");
            Console.ReadLine();
        }
    }
}
