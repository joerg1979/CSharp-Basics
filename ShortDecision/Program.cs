using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("Please type in your quick Tip: 0 or 1");
            // store userinput in a variable
            String userChoice = Console.ReadLine();
            //  Store a given String using the ternary-Operator
            String message = (userChoice == "0") 
                ? "nothing else than an Information about the Ternary-Operator(?:;-If-Else-Syntax)"
                : "an If-Statement in the short syntax";
            // If-Else without curlybrackets
            if (userChoice != "0" && userChoice != "1")
                // using zero-based wildcards inside of {0} for the output
                Console.WriteLine("Your choice of \"{0}\" was not a assumed value. \nBut it was computed in short notation and using ternary-operator",userChoice);
            // will only work if there is only one Statement after If/Else
            else
                // additional wildcards have to be comma-seperated 
                Console.WriteLine("Your choice of \"{0}\" gave you: {1}.",userChoice,message);

            Console.WriteLine("\n Das wars...");
            Console.ReadLine();
        }
    }
}
