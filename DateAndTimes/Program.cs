using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime toDay = DateTime.Now;
            Console.WriteLine("Nutzung der Klasse DateTime zur Ausgabe der aktuellen Uhrzeit -> DateTime toDay = DateTime.Now;");
            Console.WriteLine("Datum und Uhrzeit: " + toDay.ToString());

            Console.ReadLine();
            Console.WriteLine("Neben der Default-ToString-Methode stehen diverse andere Methoden zur formatierten Ausgabe zur Verfügung.");
            Console.WriteLine("Ausgabe mit  ToLongDateString(): " + toDay.ToLongDateString());
            Console.WriteLine("Ausgabe mit  ToLongTimeString(): " + toDay.ToLongTimeString());
            Console.WriteLine("Ausgabe mit  ToShortDateString(): " + toDay.ToShortDateString());
            Console.WriteLine("Ausgabe mit  ToShortTimeString(): " + toDay.ToShortTimeString());
            Console.ReadLine();

            Console.WriteLine("Manipulieren des DatumsObjekts");
            Console.WriteLine("Veränderung mit  toDay.AddDays(2): " + toDay.AddDays(2).ToLongDateString());
            Console.WriteLine("Veränderung mit  toDay.AddHours(2): " + toDay.AddHours(2).ToLongTimeString());
            Console.ReadLine();

            Console.WriteLine("Ausgabe spezieller Teile des DateTimeObjekts");
            Console.WriteLine("Ausgabe des Jahrs  mit  toDay.Year: " + toDay.Year);
            Console.WriteLine("Ausgabe des Monats mit  toDay.Month: " + toDay.Month);
            Console.WriteLine("Ausgabe des Tages  mit  toDay.Day: " + toDay.Day);
            Console.ReadLine();

            DateTime aSpecialDay = DateTime.Parse("03/12/1979");
            Console.WriteLine("Spezielles Datum im DateTimeObjekt festlegen");
            Console.WriteLine("DateTime aSpecialDay = DateTime.Parse(\"03/12/1979\");");
            Console.WriteLine(aSpecialDay.ToString());
            Console.ReadLine();

            TimeSpan myAge = DateTime.Now.Subtract(aSpecialDay);
            Console.WriteLine("Rechnen mit Datumswerten  -->  Zeitspanne berechnen");
            Console.WriteLine("TimeSpan myAge = DateTime.Now.Subtract(aSpecialDay);");
            Console.WriteLine("myAge.TotalDays -> Ausgabe: " + myAge.TotalDays);
            Console.ReadLine();



        }
    }
}
