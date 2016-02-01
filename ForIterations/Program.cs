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
                "Syntax einer einfachen for-Schleife...\n",
                "for(int i = 0; i < 4; i++){",
                "   Auszuführender Code-Block;",
                "}",
            };
            // Verarbeitung des Arrays in der forSchleife
            for (int i = 1; i < forIterationsText.Length ; i++)
            {
                Console.Write("Durchlauf " + i.ToString()+": ");
                Console.Write(forIterationsText[i]+"\n");
            }
            Console.ReadLine();
        }
    }
}
