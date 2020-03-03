using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class SpaceBlasterAdapter : IWeapon
    {
        //Adapts the space blaster actually cause i named this poorly
        private readonly Blaster _blaster;
        private int damage;

        public SpaceBlasterAdapter(Blaster blaster)
        {
            this._blaster = blaster;
            this.damage = (this._blaster.ImpactDamage + this._blaster.LazerDamage)/2;
        }
        //below adapts to the iweapon interface:
        public int Damage
        {
            get { return this.damage; }
        }
        
        public void Use(IMonster enemy)
        {
            enemy.Armor-=this._blaster.ImpactDamage;
            enemy.Health -= this._blaster.Shoot();
        }

    }
}
