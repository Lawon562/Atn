using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Object
{
    public enum PotionType { Life, Mana, Stamina, None }

    abstract class Potion
    {
        public PotionType type = PotionType.None;
        public PotionType Type { get; set; }

        private int amount = 0;
        public int Amount { get; set; }
        
    }
}
