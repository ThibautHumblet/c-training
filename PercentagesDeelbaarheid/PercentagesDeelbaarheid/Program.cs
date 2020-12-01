using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentagesDeelbaarheid
{
    class Program
    {
        static void Main(string[] args)
        {
            // wijzig kleuren console
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            // titelbalk
            Console.Title = "Percentages deelbaarheid random gekozen getallen";

            // declareren variablen
            int aantalRandomGetallen;
            int bovengrensGetallen;
            Random random = new Random();
            int randomGetal;

            int totaalDeelbaar2 = 0;
            int totaalDeelbaar3 = 0;
            int totaalDeelbaar5 = 0;

            double percentageDeelbaar2;
            double percentageDeelbaar3;
            double percentageDeelbaar5;

            // invoer
            Console.Write("Hoeveel getallen moeten er random gekozen worden? ");
            aantalRandomGetallen = int.Parse(Console.ReadLine());
            Console.Write("Wat is de bovengrens voor de random getallen? ");
            bovengrensGetallen = int.Parse(Console.ReadLine());

            for (int i = 1; i <= aantalRandomGetallen; i++)
            {
                // random getal berekenen
                randomGetal = random.Next(1, bovengrensGetallen + 1);

                if (randomGetal % 2 == 0)
                {
                    totaalDeelbaar2++;
                }
                if (randomGetal % 3 == 0)
                {
                    totaalDeelbaar3++;
                }
                if (randomGetal % 5 == 0)
                {
                    totaalDeelbaar5++;
                }
            }

            percentageDeelbaar2 = (double)totaalDeelbaar2 / aantalRandomGetallen * 100;
            percentageDeelbaar3 = (double)totaalDeelbaar3 / aantalRandomGetallen * 100;
            percentageDeelbaar5= (double)totaalDeelbaar5 / aantalRandomGetallen * 100;

            // uitvoer
            Console.WriteLine($"Er werden {aantalRandomGetallen} gekozen van 1 tot en met {bovengrensGetallen}.");
            Console.WriteLine();
            Console.WriteLine($"Percentage gekozen getallen deelbaar door 2: {percentageDeelbaar2:##0} %");
            Console.WriteLine($"Percentage gekozen getallen deelbaar door 3: {percentageDeelbaar3:##0} %");
            Console.WriteLine($"Percentage gekozen getallen deelbaar door 5: {percentageDeelbaar5:##0} %");



            // afsluiten
            // Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nDruk op ENTER om het programma af te sluiten...");

            // dummy readline
            Console.ReadLine();
        }
    }
}
