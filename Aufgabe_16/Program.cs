using System;

class Program
{
    static void Main(string[] args)
    {
        bool spielenWeiter = true;

        while (spielenWeiter)
        {
            
            Random random = new Random();
            int zufallsZahl = random.Next(1, 101);
            int versuche = 0;
            bool zahlGefunden = false;

            
            while (!zahlGefunden)
            {
                
                Console.Write("Deine Zahl (1..100): ");
                int eingabe;

                
                while (!int.TryParse(Console.ReadLine(), out eingabe) || eingabe < 1 || eingabe > 100)
                {
                    Console.Write("Bitte gib eine Zahl zwischen 1 und 100 ein: ");
                }

                versuche++;

                
                if (eingabe == zufallsZahl)
                {
                    zahlGefunden = true;
                    Console.WriteLine($"Die Zahl stimmt! Du hast total {versuche} Versuche benötigt.");
                }
                else if (eingabe < zufallsZahl)
                {
                    Console.WriteLine("Zahl ist zu klein! Nächster Versuch:");
                }
                else
                {
                    Console.WriteLine("Zahl ist zu gross! Nächster Versuch:");
                }
            }

            
            Console.Write("Noch einmal spielen? [y/n] ");
            string antwort = Console.ReadLine().ToLower();
            spielenWeiter = (antwort == "y" || antwort == "j");
        }
    }
}