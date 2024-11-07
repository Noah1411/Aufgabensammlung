using System;

namespace Aufgabe_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe die Zahl 1 ein: ");
            var zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gebe die Zahl 2 ein: ");
            var zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zahl\tQuersumme\tZahl/Quersumme");

            
            for (int zahl = Math.Min(zahl1, zahl2); zahl <= Math.Max(zahl1, zahl2); zahl++)
            {
                int quersumme = BerechneQuersumme(zahl);

                
                if (quersumme != 0 && zahl % quersumme == 0)
                {
                    int division = zahl / quersumme;
                    Console.WriteLine($"{zahl}\t{quersumme}\t\t{division}");
                }
            }

            Console.ReadKey();
        }

        
        static int BerechneQuersumme(int zahl)
        {
            int sum = 0;

            while (zahl != 0)
            {
                sum += zahl % 10;
                zahl /= 10;
            }

            return sum;
        }
    }
}
