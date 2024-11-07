using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe eine Ganzzahl ein:");
            var ganzzahl = Convert.ToInt32(Console.ReadLine());

            
            int sum = BerechneQuersumme(ganzzahl);

            
            Console.WriteLine("Die Quersumme ist: " + sum);
            Console.ReadKey();
        }

        static int BerechneQuersumme(int zahl)
        {
            int sum = 0;

            
            while (zahl != 0)
            {
                sum = sum + (zahl % 10);  
                zahl = zahl / 10;         
            }
            return sum;  
        }
        
    }
}
