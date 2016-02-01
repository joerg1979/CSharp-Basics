using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIterations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of Strings zum durhclaufen mit der for-Schleife
            String[] forIterationsText =
            {
                "Syntax einer einfachen for-Schleife:",
                "for(int i = 0; i < 4; i++){",
                "   Auszuführender Code-Block;",
                "}",
            };
            Console.WriteLine(forIterationsText[0]);
            // Verarbeitung des Arrays in der forSchleife
            for (int i = 1; i < forIterationsText.Length ; i++)
            {
                Console.Write("Durchlauf " + i.ToString()+": ");
                Console.Write(forIterationsText[i]+"\n");
            }
            Console.ReadLine();
            Console.WriteLine("...beeinflussen von Schleifendurchläufen:");
            Console.ReadLine();
            // Unterbrechen von Schleifendurchläufen
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine("Der Durchlauf von For-Schleifen kann abgebrochen werden ");                    
                }
                if (i == 3)
                {
                    Console.WriteLine("Zum Abbruch kann dass \"break;\"-Statement verwendet werden.");
                    for(int j =1;j<=2;j++)
                    {
                        Console.WriteLine(forIterationsText[j]);
                    }
                    Console.WriteLine("   break;\n}");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
