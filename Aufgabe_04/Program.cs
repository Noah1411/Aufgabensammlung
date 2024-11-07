using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe die Zahl des Monats ein: ");
            var ganzzahl = Convert.ToInt32(Console.ReadLine());

            switch (ganzzahl) 
            {
                case 1:
                    Console.WriteLine("Die Zahl ist der Monat Januar.");
                    break;

                case 2:
                    Console.WriteLine("Die Zahl ist der Monat Februar.");
                    break;

                case 3:
                    Console.WriteLine("Die Zahl ist der Monat März.");
                    break;

                case 4:
                    Console.WriteLine("Die Zahl ist der Monat April.");
                    break;

                case 5:
                    Console.WriteLine("Die Zahl ist der Monat Mai.");
                    break;

                case 6:
                    Console.WriteLine("Die Zahl ist der Monat Juni.");
                    break;

                case 7:
                    Console.WriteLine("Die Zahl ist der Monat Juli.");
                    break;

                case 8:
                    Console.WriteLine("Die Zahl ist der Monat August.");
                    break;

                case 9:
                    Console.WriteLine("Die Zahl ist der Monat September.");
                    break;

                case 10:
                    Console.WriteLine("Die Zahl ist der Monat Oktober.");
                    break;

                case 11:
                    Console.WriteLine("Die Zahl ist der Monat November.");
                    break;

                case 12:
                    Console.WriteLine("Die Zahl ist der Monat Dezember.");
                    break;
                
                default:
                    Console.WriteLine("Ungültige Monatszahl.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
