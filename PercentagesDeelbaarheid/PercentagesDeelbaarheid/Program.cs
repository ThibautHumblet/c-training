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

           

            // afsluiten
            // Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nDruk op ENTER om het programma af te sluiten...");

            // dummy readline
            Console.ReadLine();
        }
    }
}
