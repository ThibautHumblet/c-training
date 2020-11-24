using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ondervraging
{
    class Program
    {
        static void Main(string[] args)
        {
            // wijzig kleuren consolevenster
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            // titelbalk
            Console.Title = "Random ondervraging";

            // declareren variabelen
            int aantalLeerlingen;
            Random random = new Random();
            int randomLeerling;

            // invoer + random berekening
            Console.Write("Aantal leerlingen: ");
            aantalLeerlingen = int.Parse(Console.ReadLine());

            randomLeerling = random.Next(1, aantalLeerlingen + 1);
            int unicodeWaarde = random.Next(65, 71);
            char letter = (char)unicodeWaarde;


            // uitvoer
            Console.WriteLine($"Leerling met nummer {randomLeerling} beantwoordt vraag {letter}.");

            // afsluiten
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nDruk op ENTER om het programma af te sluiten...");

            // dummy readline
            Console.ReadLine();
        }
    }
}
