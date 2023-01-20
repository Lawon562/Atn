using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Character
{
    public interface ICharacter
    {
        int MaxLife { get; set; }
        int MaxMana { get; set; }
        int MaxStamina { get; set; }
        int Life { get; set; }
        int Mana { get; set; }
        int Stamina { get; set; }
        int Str { get; set; }
        int Intellect { get; set; }
        int Dex { get; set; }
        int Will { get; set; }
        int Luck { get; set; }
        int DefPoint { get; set; }
        int DefPercent { get; set; }
        

    }
}
