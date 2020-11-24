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

           




            // afsluiten
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nDruk op ENTER om het programma af te sluiten...");

            // dummy readline
            Console.ReadLine();
        }
    }
}
