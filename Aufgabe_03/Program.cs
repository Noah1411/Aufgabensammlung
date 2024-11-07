using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            do
            {
                i = i + 1;
            }
            while (i <= 10);
            
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
