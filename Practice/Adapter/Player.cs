using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice
{
    public sealed class Player
    {
        // Class Variables
        private static readonly Player instance;
        private string name;
        private int level;
        private int armor;
        private int health;
        private IWeapon weapon;


        // Gets and Sets
        public static Player Instance
        {
            get
            {
                return instance;
            }
        }

        public string Name 
        { 
            get 
            {
                return this.name;
            }
            set 
            {
                this.name = value;
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
            }
        }
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
        public IWeapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        // Constructors start here
        private Player() { }


        static Player()
        {
            instance = new Player()
            {
                Name = "The One and Only Radcliff",
                Level = 1,
                Armor = 25,
                Health = 100
            };
        }
    }
}