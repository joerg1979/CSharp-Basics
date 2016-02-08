using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car meinAuto = new Car();
        }
    }
    class Car
    {
        public string Marke { get; set; }
        public string Modell { get; set; }
        public string Farbe { get; set; }
        public int Baujahr { get; set; }


        public Car()
        {

        }
        public Car(string marke, string modell, int baujahr, string farbe)
        {
            this.Marke = marke;
            this.Modell = modell;
            this.Baujahr = baujahr;
            this.Farbe = farbe;
        }

        /**
         *  Das überschreiben der Konstruktor-Methode mit der selben Signatur mit nur geänderten
         *  VariablenNamen nicht möglich. Unterschiedliche Datentypen müssen in der Signatur sein.
        public Car(string andererParameter, string modell, int baujahr, string farbe)
        {
            this.Marke = andererParameter;
            this.Modell = modell;
            this.Baujahr = baujahr;
            this.Farbe = farbe;
        }
        */

    }
}
