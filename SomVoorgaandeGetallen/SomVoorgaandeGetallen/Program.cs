using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomVoorgaandeGetallen
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
            Console.Title = "Som met alle voorgaande getallen";

            // declareren variabelen
            int getalHerhaling;
            int totaleSom = 0;

            // invoer
            Console.Write("Voer een positief getal in: ");
            getalHerhaling = int.Parse(Console.ReadLine());

            // berekening
            for (int i = 1; i <= getalHerhaling; i++)
            {
                totaleSom = i + totaleSom;
            }

            // uitvoer
            Console.WriteLine($"De som van alle getallen van 1 tot en met {getalHerhaling} is gelijk aan {totaleSom}");

            // afsluiten
            // Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nDruk op ENTER om het programma af te sluiten...");

            // dummy readline
            Console.ReadLine();
        }
    }
}

