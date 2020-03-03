using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice
{
    public class Blaster:ISpaceWeapon
    {
        private int impactDamage;
        private int lazerDamage;
        private int missChance;

        public Blaster(int iDmg, int lDmg, int mChn)
        {
            this.ImpactDamage = iDmg;
            this.LazerDamage = lDmg;
            this.MissChance = mChn;
        }

        public int ImpactDamage {
            get { return this.impactDamage; }
            set { this.impactDamage = value; }
        }
        public int LazerDamage
        {
            get { return this.lazerDamage; }
            set { this.lazerDamage = value; }
        }
        public int MissChance
        {
            get { return this.missChance; }
            set { this.missChance = value; }
        }

        public int Shoot()
        {
            return (this.ImpactDamage + this.LazerDamage) * this.MissChance;
        }

        public string ToString()
        {
            return this.ImpactDamage +" "+this.LazerDamage + " " + this.MissChance;
        }

    }
}