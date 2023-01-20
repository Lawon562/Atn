using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Object
{
    class Weapon : IWeapon
    {
        public string name;
        public int apMin;
        public int apMax;

        public Weapon(string _name, int _min, int _max)
        {
            Name = _name;
            ApMin = _min;
            ApMax = _max;
        }
        public string Name { get; set; }
        public int ApMin { get; set; }
        public int ApMax { get; set; }

        public int WeaponDamage()
        {
            return Common.random.Next(this.ApMin, this.ApMax);
        }
    }
}
