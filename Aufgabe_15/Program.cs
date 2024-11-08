using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Breite des Stammes? ");
        int stammBreite = Convert.ToInt32(Console.ReadLine());

        Console.Write("Höhe des Stammes? ");
        int stammHoehe = Convert.ToInt32(Console.ReadLine());

        Console.Write("Höhe der Krone? ");
        int kronenHoehe = Convert.ToInt32(Console.ReadLine());

        
        for (int i = 0; i < kronenHoehe; i++)
        {
            
            for (int j = 0; j < kronenHoehe - i - 1; j++)
            {
                Console.Write(" ");
            }

            
            for (int k = 0; k < (2 * i + 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        
        for (int i = 0; i < stammHoehe; i++)
        {
            
            for (int j = 0; j < kronenHoehe - (stammBreite / 2) - 1; j++)
            {
                Console.Write(" ");
            }

            
            for (int j = 0; j < stammBreite; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.ReadKey();
    }
}