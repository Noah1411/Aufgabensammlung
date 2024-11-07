using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wieviele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen");
            var Tag = Convert.ToInt32(Console.ReadLine());

            if (Tag >= 27 && Tag <= 32)
            {
                int sekundenanzahl = Tag * 86400;

                Console.WriteLine("Ihr Monat hat " + sekundenanzahl + " Sekunden");
            }
            else
            {
                Console.WriteLine("Es gibt keinen Monat mit dieser Anzahl an Tagen!");
            }
            Console.ReadKey();
        }
    }
}
