using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice
{
    public class Zombie : IMonster
    {
        // class variables
        private int health;
        private readonly int level;
        private int armor;

        // gets and sets
        public int Armor
        {
            get
            {
                return this.armor;
            }
            set
            {
                this.armor = value;
            }
        }
        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value;
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }

        }

        // Constructor

        public Zombie(int zombieHealth, int zombieLevel, int zombieArmor)
        {
            Armor = zombieArmor;
            Health = zombieHealth;
            level = zombieLevel;
            
        }

        public void Attack(Player player)
        {
            Console.WriteLine("Zombie attacking " + player.Name);
        }

        public void Defend(Player player)
        {
            Console.WriteLine("Zombie defending from " + player.Name);
        }
    }
}