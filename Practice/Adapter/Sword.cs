using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice
{
    public class Sword : IWeapon
    {
        // class variables
        private int damage;
        private int armorDamage;

        // gets and sets
        public int Damage 
        {
            get
            {
                return this.damage;
            }
            
        }

        public int ArmorDamage
        {
            get
            {
                return this.armorDamage;
            }

        }

        // constructors
        public Sword(int swordDamage, int swordArmorDamage)
        {
            this.damage = swordDamage;
            this.armorDamage = swordArmorDamage;
        }

        public void Use(IMonster enemy)
        {
            enemy.Health -= Damage;
            enemy.Armor -= ArmorDamage;
        }
    }
}