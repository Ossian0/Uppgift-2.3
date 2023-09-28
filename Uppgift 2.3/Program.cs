using System;

namespace Biluthyrning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fråga användaren om antal dagar att hyra bilen och antal kilometer att köra
            Console.Write("Hur många dagar vill du hyra bilen? ");
            int antalDagar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hur många kilometer ska du köra? ");
            double antalKilometer = Convert.ToDouble(Console.ReadLine());

            // Beräkna kostnaden
            double startavgift = 300;
            double kostnadPerKilometer = 1;
            double extraDagsavgift = 500;

            double totalKostnad = startavgift + (antalKilometer * kostnadPerKilometer);
            if (antalDagar > 1)
            {
                totalKostnad += (antalDagar - 1) * extraDagsavgift;
            }

            // Skriv ut den totala kostnaden
            Console.WriteLine($"Den totala kostnaden för att hyra bilen är {totalKostnad} kr.");
            Console.ReadKey();
        }
    }
}