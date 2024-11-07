using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Ganzzahlige Dezimalzahl:");
            var n = Convert.ToInt32(Console.ReadLine());


            string bin = "";

            while (n > 0)
            {
                int rest = n % 2;
                bin = rest + bin;

                int wert = n / 2;
                n = wert;
            }

            Console.WriteLine("Die Binärzahl lautet:\n" +bin);
            Console.ReadKey();
        }
    }
}
