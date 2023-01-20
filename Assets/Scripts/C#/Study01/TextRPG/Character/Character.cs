using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Character
{
    abstract class Character : ICharacter
    {
        private int maxLife     = 1;
        private int maxMana     = 1;
        private int maxStamina  = 1;
        private int life        = 1;
        private int mana        = 1;
        private int stamina     = 1;
        private int str         = 1;
        private int intellect   = 1;
        private int dex         = 1;
        private int will        = 1;
        private int luck        = 1;
        private int defPoint    = 1;
        private int defPercent  = 1;

        public int MaxLife
        {
            get => this.maxLife;
            set { this.maxLife = value; }
        }
        public int MaxMana
        {
            get => this.mana;
            set { this.mana = value; }
        }
        public int MaxStamina
        {
            get => this.maxStamina;
            set { this.maxStamina = value; }
        }
        public int Life
        {
            get => this.life;
            set { this.life = value; }
        }
        public int Mana
        {
            get => this.mana;
            set { this.mana = value; }
        }
        public int Stamina
        {
            get => this.stamina;
            set { this.stamina = value; }
        }
        public int Str
        {
            get => this.str;
            set { this.str = value; }
        }
        public int Intellect
        {
            get => this.intellect;
            set { this.intellect = value; }
        }
        public int Dex
        {
            get => this.dex;
            set { this.dex = value; }
        }
        public int Will
        {
            get => this.will;
            set { this.will = value; }
        }
        public int Luck
        {
            get => this.luck;
            set { this.luck = value; }
        }
        public int DefPoint
        {
            get => this.defPoint;
            set { this.defPoint = value; }
        }
        public int DefPercent
        {
            get => this.defPercent;
            set { this.defPercent = value; }
        }

    }
}
