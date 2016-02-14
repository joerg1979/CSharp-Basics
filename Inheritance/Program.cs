using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void printMe(Vehicle vehicle)
        {
            Console.WriteLine("");
        }

    }
    class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

    }
    class Car : Vehicle
    {
        public string Doors { get; set; }
    }

    class Truck : Vehicle
    {
        public int TowingCapacity { get; set; }

    }
}
