using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clash_of_the_Titans
{
    class Warrior : Fighter
    {
        Random rand = new Random();

        public int Helth { get; private set; }


        public Warrior(string name, int health, int armor, int damage, string ability) : base(name, health, armor, damage, ability)
        {
        }
        public Warrior(string name, int health, int armor, int damage) : base(name, health, armor, damage)
        {
        }

        public override int DamageDo()
        {
            return (rand.Next(80, 120) * Damage) / 100;
        }

        public override int Defense()
        {
            return Armor;
        }

        public override void printInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\t   " + Name);
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
