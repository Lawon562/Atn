using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextRPG.Character
{
    abstract class Character : ICharacter
    {
        private string name;
        private string gender;
        private int combatPower = 0;
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

        public string Name
        {
            get => this.name;
            set { this.name = value; }
        }
        public string Gender
        {
            get => this.gender;
            set { this.gender = value; }
        }
        public int CombatPower
        {
            get => this.combatPower;
            set { this.combatPower = value; }
        }

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

        public void WriteLine(string str, bool anim = true)
        {
            Console.SetCursorPosition(2, Key.lastLine);
            foreach (char ch in str)
            {
                Console.Write(ch);
                if (anim) Thread.Sleep(50);
            }
            Key.lastLine+=2;
        }
        public void WriteLines(string[] introStr, bool anim = true)
        {
            Console.SetCursorPosition(2, Key.lastLine);
            foreach (string intro in introStr)
            {
                int lineCount = 0;
                foreach (char ch in intro)
                {
                    lineCount += (ch != ' ') ? 2 : 1;
                    if (lineCount > Key.mapNameUIBot.Length - 2)
                    {
                        lineCount = 0;
                        Console.SetCursorPosition(2, ++Key.lastLine);
                    }
                    Console.Write(ch);
                    if (anim) Thread.Sleep(50);
                }
                Console.SetCursorPosition(2, ++Key.lastLine);
            }
            Key.lastLine++;
        }



        public void Say(string script)
        {
            WriteCharacterName();
            WriteLine(script, true);
        }

        public void Say(string[] script)
        {
            WriteCharacterName();
            WriteLines(script);
        }

        public void WriteCharacterName()
        {
            Key.lastLine++;
            TextColor.BgDarkCyan();
            TextColor.ForeWhite();
            WriteLine($" 《 {this.Name} 》 ", false);
            TextColor.BgBlack();
            TextColor.ForeWhite();
        }


    }
}
