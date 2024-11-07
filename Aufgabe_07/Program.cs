using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = ""; 
            for (int i = 1; i <= 30; i++)
            {                
                if (i % 3 == 0 || i % 5 == 0)
                {
                    
                    output += i + ", ";
                }
            }         
            if (output.Length > 0)
            {
                output = output.Substring(0, output.Length - 2);
            }

            Console.WriteLine("Zahlen zwischen 1 und 30, die durch 5 und/oder 3 ohne Rest teilbar sind:\n" + output);
            Console.ReadKey();
        }
    }
}
