using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prüfen ob es sich bei dem Jahr um ein Schaltjahr handelt.\n=========================================================");

            Console.Write("\nEingabe Jahr: ");
            var eingabejahr = Convert.ToInt32(Console.ReadLine());

            if (eingabejahr < 1582)
            {
                Console.WriteLine("Die Schaltjahrregel gilt erst ab dem Jahr 1582. Bitte ein Jahr ab 1582 eingeben.");
            }

            else if (eingabejahr % 4 == 0 || eingabejahr % 400 == 0)
            {
                Console.WriteLine("Das Jahr ist ein Schaltjahr.");
            }

            else 
            {
                Console.WriteLine("Das Jahr ist kein Schaltjahr.");
            }
    
            Console.ReadKey();
        }
    }
}
