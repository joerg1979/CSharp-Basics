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
            Vehicle cleanVehicle = new Vehicle();
            cleanVehicle.Make = "VW";
            printVehicleDetails(cleanVehicle);
            Console.ReadLine();

            Vehicle myVehicle = new Vehicle("BMW", "850CSI", "Racing Green", 1991);
            printVehicleDetails(myVehicle);
            Console.ReadLine();

            Car myCar = new Car("Audi", "A8", "Blue metallic", 2003,4);
            printVehicleDetails(myCar);
            Console.ReadLine();

            Truck myTruck = new Truck("Mercedes", "Actros", "Power White", 2015, 40);
            printVehicleDetails(myTruck);
            Console.ReadLine();
        }


        public static void printVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("Here are the Vehicle´s details: {0} ", vehicle.FormatMe());;
        }


    }
    /** A class handling all Vehicles*/
    class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        
        public  Vehicle()
        {         
        }

        public Vehicle(string make, string model, string color, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Color = color;
            this.Year = year;
        }

        public virtual string FormatMe()
        {
            return String.Format("Marke: {0}  | Modell: {1} | Farbe: {2} | Baujahr: {3}",
            this.Make,
            this.Model,
            this.Color,
            this.Year);
        }
    }
    /** A class handling Cars*/
    class Car : Vehicle
    {
        public int Doors { get; set; }

        public Car(string make, string model, string color, int year, int doors)
        {
            base.Make = make;
            base.Model = model;
            base.Color = color;
            base.Year = year;
            this.Doors = doors;
        }

        public override string FormatMe()
        {
            return base.FormatMe() + string.Format(" | Türen {0}",this.Doors);
        }
    }

    /** A class handling Trucks*/
    class Truck : Vehicle
    {
        public int Tons { get; set; }

        public Truck(string make, string model, string color, int year, int tons)
        {
            base.Make = make;
            base.Model = model;
            base.Color = color;
            base.Year = year;
            this.Tons = tons;
        }

        public override string FormatMe()
        {
            return base.FormatMe() + string.Format(" | Tonnen {0}", this.Tons);
        }
    }

}
