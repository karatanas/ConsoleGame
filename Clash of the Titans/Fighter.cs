using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clash_of_the_Titans
{
    abstract class Fighter
    {
        public abstract int DamageDo();
        public abstract int Defense();

        public string Name { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Damage { get; set; }
        public string Ability { get; set; }

        public Fighter(string name, int health, int armor, int damage, string ability)
        {
            Name = name;
            Health = health;
            Armor = armor;
            Damage = damage;
            Ability = ability;
        }
        public Fighter(string name, int health, int armor, int damage)
        {
            Name = name;
            Health = health;
            Armor = armor;
            Damage = damage;
        }

        public Fighter()
        {
        }
        public abstract void printInfo();
    }
}
