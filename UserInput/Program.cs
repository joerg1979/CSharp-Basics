using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter something and press Enter key.");
            String userInput = "";
            userInput = Console.ReadLine();
            Console.WriteLine("You´ve entered: " + userInput);
            Console.ReadLine();

        }
    }
}
