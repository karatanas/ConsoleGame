using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clash_of_the_Titans
{
    class Assassin : Fighter
    {
        Random rand = new Random();

        public Assassin(string name, int health, int armor, int damage, string ability) : base(name, health, armor, damage, ability)
        {
            //ability = "30% to deal 300% damage";
        }
        public Assassin(string name, int health, int armor, int damage) : base(name, health, armor, damage)
        {
        }
        public double CheckCombo = 3.33;
        public bool Combo = false;

        public override int DamageDo()
        {
            if (CheckCombo % 9.99 == 0)
            {
                Combo = true;
                CheckCombo = 3.33;
                return (rand.Next(80, 120) * Damage * 3) / 100;
            }
            else
            {
                CheckCombo += 3.33;
                if (Combo == true)
                {
                    Console.Write("    3x Damage");
                    Combo = false;
                }
                return (rand.Next(80, 120) * Damage) / 100;
            }
        }
        public override int Defense()
        {
            return Armor;
        }
        public override void printInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n\n\t   " + Name);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n\tHealth: ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(Health);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n\tDamage: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(Damage);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n\tArmor: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(Armor);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n\tAbilities: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Ability);
        }
    }
}
