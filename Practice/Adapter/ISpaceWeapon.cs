using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public interface ISpaceWeapon
    {
        int ImpactDamage { get; }
        int LazerDamage { get; }

        // storm troopers get 100% strom troopers
        int MissChance { get; }

        int Shoot();
    }
}
