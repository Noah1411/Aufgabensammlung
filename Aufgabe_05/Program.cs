using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aufgabe_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Meter möchtest du rennen?");
            var manzahl = Convert.ToSingle(Console.ReadLine());

            float anzahlrunden = manzahl / 400;

            if (manzahl >= 42000)
            {
                Console.WriteLine("Das schafst du nicht.");
            }
            else
            {
                Console.WriteLine("Sie müssen "+anzahlrunden + " Runden rennen.");
            }
            Console.WriteLine("Bist du jetzt bereit?");
            var ready = Convert.ToString(Console.ReadLine());

            if (ready == "nein")
            {
                Console.WriteLine("Dann bist du jetzt fertig.");
            }
            else if (ready == "ja") 
            {
                int i = 1;
                while(i <= anzahlrunden )
                {
                    Console.WriteLine("Du läufst Runde "+ i);
                    i++;                   
                }
                Console.WriteLine("Du hast es geschaft.");
            }                             
            Console.ReadKey();
        }
    }
}
