using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            String userDecision = "";

            Console.WriteLine("Please Choose one option: 1,2 or 3! and press Enter key.");
            userDecision = Console.ReadLine();

            if (userDecision == "1")
            {
                Console.WriteLine("Congrats: Option " + userDecision + " wins a Price...a new illuminated mouse");
            }
            else if (userDecision == "2")
            {
                Console.WriteLine("Congrats: Option " + userDecision + " wins a Price...an else if-Statement");
            }
            else if (userDecision == "3")
            {
                String price3 = "Wildcard";

                Console.WriteLine("Congrats: Option " + userDecision + " wins a Price...a {0}", price3);
            }
            else {
                String youLoose = "Sorry...you´ve entered an invalid value and loose with your choice of: ";
                String message = "";

                message = youLoose + userDecision;

                Console.WriteLine(message + "\nBut it was stored and computed in the variable \"message\".");
            }
            Console.ReadLine();
        }
    }
}
