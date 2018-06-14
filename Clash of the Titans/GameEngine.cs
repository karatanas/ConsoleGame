using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clash_of_the_Titans
{
    class GameEngine
    {
        Random rand = new Random();

        public static Fighter Fight(string f1, string f2)
        {
            
            Fighter fighter1 = null;
            Fighter fighter2 = null;

            if (f1 == "Warrior")
            {
                fighter1 = new Warrior("Warrior", 1170, 60, 150);
                if (f2 == "Knight")
                {
                    fighter2 = new Knight("Knight", 1000, 70, 130);
                }
                else if(f2 == "Assassin")
                {
                    fighter2 = new Assassin("Assassin", 1300, 10, 110);
                }
                else
                {
                    fighter2 = new Monk("Monk", 1900, 20, 120);
                }
            }
            if (f1 == "Knight")
            {
                fighter1 = new Knight("Knight", 1000, 70, 130);
                if (f2 == "Warrior")
                {
                    fighter2 = new Warrior("Warrior", 1170, 60, 150);
                }
                else if (f2 == "Assassin")
                {
                    fighter2 = new Assassin("Assassin", 1300, 10, 110);
                }
                else
                {
                    fighter2 = new Monk("Monk", 1900, 20, 120);
                }
            }
            if (f1 == "Assassin")
            {
                fighter1 = new Assassin("Assassin", 1300, 10, 110);
                if (f2 == "Warrior")
                {
                    fighter2 = new Warrior("Warrior", 1170, 60, 150);
                }
                else if (f2 == "Knight")
                {
                    fighter2 = new Knight("Knight", 1000, 70, 130);
                }
                else
                {
                    fighter2 = new Monk("Monk", 1900, 20, 120);
                }
            }
            if (f1 == "Monk")
            {
                fighter1 = new Monk("Monk", 1900, 20, 120);
                if (f2 == "Warrior")
                {
                    fighter2 = new Warrior("Warrior", 1170, 60, 150);
                }
                else if (f2 == "Knight")
                {
                    fighter2 = new Knight("Knight", 1000, 70, 130);
                }
                else
                {
                    fighter2 = new Assassin("Assassin", 1300, 10, 110);
                }
            }


            bool f1Dodge = false, f2Dodge = false;
            int KnightArmor = 1;
            int MonkArmor = 3;
            while (fighter1.Health > 0 && fighter2.Health > 0)
            {                

                
                //Ход первого
                if (((fighter1.Name.Equals("Monk") && MonkArmor % 9 == 0) || fighter1.Name.Equals("Knight") && KnightArmor % 5 == 0))
                {                
                    Console.Write("\n" + fighter1.Name + " HP: " + fighter1.Health); //Вывод 1 НР
                    f1Dodge = true;
                    System.Threading.Thread.Sleep(100);
                }
                else
                {
                    Console.Write("\n" + fighter1.Name + " HP: " + fighter1.Health);
                    if (f1Dodge == true)
                    {
                        Console.Write("   Dodge");
                        f1Dodge = false;
                    }
                    fighter1.Health -= fighter2.DamageDo() - fighter1.Defense();
                }
                
                System.Threading.Thread.Sleep(600);
                //Ход второго
                if ((fighter2.Name.Equals("Monk") && MonkArmor % 9 == 0) || (fighter2.Name.Equals("Knight") && KnightArmor % 5 == 0))
                {
                    Console.Write("\n" + fighter2.Name + " HP: " + fighter2.Health);  //Вывод 2 НР
                    f2Dodge = true;
                    System.Threading.Thread.Sleep(100);
                }
                else
                {
                    Console.Write("\n" + fighter2.Name + " HP: " + fighter2.Health);
                    if (f2Dodge == true)
                    {
                        Console.Write("   Dodge");
                        f2Dodge = false;
                    }
                    fighter2.Health -= fighter1.DamageDo() - fighter2.Defense(); 
                }
                System.Threading.Thread.Sleep(600);
                MonkArmor += 3;
                KnightArmor++;
            }
            if(fighter1.Health > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + fighter2.Name + " is Dead");
                return fighter1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + fighter1.Name + " is Dead");
                return fighter2;
            }
        }

        public static void printAllInfo()
        {
            Warrior warrior = new Warrior("Warrior", 1170, 60, 150, "No abilities");
            Knight knight = new Knight("Knight", 1000, 70, 130, "+20% to skip the attack of an opponent and 10% to deal 200% damage");
            Assassin assassin = new Assassin("Assassin", 1300, 10, 110, "30% to deal 300% damage");
            Monk monk = new Monk("Monk", 1900, 20, 120, "+30% to skip the attack of an opponent");

            warrior.printInfo();
            knight.printInfo();
            assassin.printInfo();
            monk.printInfo();
            Console.ResetColor();
            Console.WriteLine();
        }

    }
}
