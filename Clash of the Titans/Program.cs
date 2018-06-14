using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clash_of_the_Titans
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Do you want to play? (Yes/No)");
                Console.ForegroundColor = ConsoleColor.White;
                string p1 = Console.ReadLine();
                if (p1.Equals("Yes") || p1.Equals("yes"))
                {
                    Console.ResetColor();
                    Console.WriteLine("\tAvailable fighters: \n");

                    GameEngine.printAllInfo();

                    string f1 = null;
                    string f2 = null;

                    //Проверка на ввод перса
                    while (true)
                    {
                        if (f1 == "Warrior" || f1 == "Knight" || f1 == "Assassin" || f1 == "Monk")
                        {
                            if (f2 == "Warrior" || f2 == "Knight" || f2 == "Assassin" || f2 == "Monk")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Select and enter the second fighter  (Warrior/Knight/Assassin/Monk)");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                f2 = Console.ReadLine();
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Select and enter the first fighter  (Warrior/Knight/Assassin/Monk)");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            f1 = Console.ReadLine();
                            Console.ResetColor();
                        } 
                    }
                    Fighter winner = GameEngine.Fight(f1, f2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nIn this fight, the {winner.Name} won\n");
                    Console.ResetColor();
                    System.Threading.Thread.Sleep(2500);
                }
                else if (p1.Equals("No") || p1.Equals("no"))
                {
                    Console.WriteLine("\nI hope you enjoyed the game)");
                    System.Threading.Thread.Sleep(2500);
                    Console.WriteLine("\nBye..");
                    System.Threading.Thread.Sleep(1500);
                    Environment.Exit(0);
                    break;
                }
            }       
        }
    }
}
