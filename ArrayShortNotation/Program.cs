﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayShortNotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Kurz Schreibweise: Array-Deklartation mit Wertzuweisung");
            Console.WriteLine("int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6 };");
            Console.ReadLine();

            // Bestimmen der Länge/Anzahl von Einträgen eines Arrays mittels Length-Property
            Console.WriteLine("Ausgabe der Länge des Arrays mittels Legth-Property");
            Console.WriteLine("numbers.Length  => "+numbers.Length);
            Console.ReadLine();
        }
    }
}
