using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLongNotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            numbers[0] = 3;
            numbers[1] = 5;
            numbers[2] = 7;
            numbers[3] = 11;
            numbers[4] = 13;

            // Nicht möglich! Arrays können nachträglich nicht vergrößert werden.
            // numbers[5] = 16;
            Console.WriteLine(numbers[1]);
            Console.ReadLine();

        }
    }
}
