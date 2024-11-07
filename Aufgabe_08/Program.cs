using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dein Kommentar: ");
            string kommentar = Console.ReadLine();

            string[] forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe", "arsch" };

            if (forbiddenWords.Any(word => kommentar.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0))
            {
                Console.WriteLine("\nDein Kommentar ernthält verbotene Wörter\nEr wird nicht veröfentlicht.");
            }
            else
            {
                Console.WriteLine("Vielen Dank für deinen Kommentar.");                                          
            }                                           
            Console.ReadKey();
        }
    }
}
