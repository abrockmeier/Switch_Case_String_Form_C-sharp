using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
        { 
        static void Main(string[] args)
        {
            //Variablen

            bool loopBreak = false;

            //Eingabe:

            while (loopBreak == false)
            {
                
                Console.WriteLine("Hallo! Willst du ein Spiel spielen?");
                Console.WriteLine("Für Candy-Crush drücke die 1.");
                Console.WriteLine("Für für Tic-Tac-Toe drücke die 2.");
                Console.WriteLine("Zum beenden drücke die 3.!", Environment.NewLine);
                //Console.WriteLine("Ihre Auswahl:");
                ConsoleKeyInfo caseInput = Console.ReadKey(true);
                StringBuilder output = new StringBuilder(
                    String.Format("Ihre Auswahl: {0}", caseInput.KeyChar));
                Console.WriteLine(output.ToString());

                //Verarbeitung / Ausgabe:

                switch (caseInput.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        loopBreak = true;
                        Console.WriteLine("Für Candy-Crush benutze gefälligst deinen eigenes Device!");
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        loopBreak = true;
                        Console.WriteLine("Tic-Tac-Toe is under construction!");
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        loopBreak = true;
                        Console.WriteLine("Programm wird beendet!");
                        break;
                        /* default:
                             loopConti = true;
                             Console.WriteLine("Eingabe fehlerhaft. Bitte wiederholen!");
                             break;
                        */
                }
                Console.ReadKey();
                if (loopBreak == false)
                {
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine("Eingabe fehlerhaft. Bitte wiederholen!\n");
                    
                }
            }
        }
    }
}
