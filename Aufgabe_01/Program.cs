using System;

namespace Aufgabe_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe eine Ganzzahl ein: ");
            var zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gebe eine zweite Ganzzahl ein: ");
            var zahl2 = Convert.ToInt32(Console.ReadLine());

            int Resultat = zahl1 + zahl2;

            Console.WriteLine("Das Ergebnis ist "+ Resultat);

            Console.ReadKey();  
        }
    }
}
