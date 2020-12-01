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
            int herhaalgetal;
            string somTekst = "";
            int totaleSom = 0;

            // invoer
            Console.Write("Voer een positief geheel getal in: ");
            herhaalgetal = int.Parse(Console.ReadLine());

            // uitvoer
            for (int i = 1; i <= herhaalgetal; i++)
            {
                somTekst += i;
                if (i < herhaalgetal)
                    somTekst += " + ";
                totaleSom += i;
            }

            Console.WriteLine($"{somTekst} = {totaleSom}");

            // afsluiten
            // Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nDruk op ENTER om het programma af te sluiten...");

            // dummy readline
            Console.ReadLine();
        }
    }
}

