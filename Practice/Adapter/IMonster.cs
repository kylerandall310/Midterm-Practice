using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public interface IMonster
    {
        int Health { get; set; }
        int Level { get; }
        int Armor { get; set; }
        void Attack(Player player);
        void Defend(Player player);
    }
}
