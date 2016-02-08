using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "330Ci";
            myCar.Color = "Black";
            myCar.Year = 2008;

            Console.WriteLine(printCar(myCar));
            Console.WriteLine("Wert des Fahrzeugs: "+ determineValue(myCar));
            
            Console.ReadLine();

            Car mySecondCar = new Car("Porsche", "Cayman", 2011, "Racing Red");
            Console.WriteLine(printCar(mySecondCar));
            
            Console.WriteLine("Wert des Fahrzeugs: {0:C}", mySecondCar.DetermineCarValue());

            Console.ReadLine();
        }

        private static double determineValue(Car car)
        {
            double carValue = 1000.99;

            if (car.Year > 2010)
            {
                carValue = 12500.99;
            }
            else if (car.Year > 2000)
            {
                carValue = 7500.99;
            }
            else if (car.Year > 1990)
            {
                carValue = 2500.99;
            } 
            return carValue;
        }

        private static string printCar(Car car)
        {
            return String.Format("{0} - {1} - {2} - {3}",
                car.Make,
                car.Model,
                car.Year,
                car.Color);
        }
        
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }


        public Car()
        {
            Console.WriteLine("Ein neues Auto wurde erstellt. Es wurden keine Attribute definiert");
        }

        public Car(string make, string model, int year, string color)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
            Console.WriteLine("Ein neues Auto wurde erstellt. Es wurden alle Attribute definiert");
        }

        public double DetermineCarValue()
        {
            double carsValue = 1000.01;
            if (this.Year > 2005)
            {
                carsValue = 20000.99;
            }
            return carsValue;
        }
    }
}
