using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Object;

namespace TextRPG.Character
{
    class Player : Character
    {
        private static Player instance = null;
        public static Player GetInstance()
        {
            if (instance == null) return new Player("당신", "미정", ConsoleColor.DarkMagenta);
            return instance;
        }


        public Player(string name, string gender, ConsoleColor color)
        {
            this.Color = color;
            this.Name = name;
            this.Gender = gender;
            this.Life = 60;
            this.Mana = 31;
            this.Stamina = 37;
            this.Str = 12;
            this.Intellect = 17;
            this.Dex = 7;
            this.Will = 11;
            this.Luck = 5;
            this.DefPoint = 3;
            this.DefPercent = 1;
        }
        private Weapon weapon = new Weapon("나무 몽둥이", 3, 21);
        public Weapon Weapon { get; set; }

        

        public void Attack(Monster Target)
        {
            int point = 0;
            try
            {
                
                point = (this.Str +  this.weapon.WeaponDamage() - Target.DefPoint) / Target.DefPercent;
            }
            catch (DivideByZeroException e)
            {
                // To-do Somthing
            }
            catch (Exception e)
            {
                point = (this.Str - Target.DefPoint) / Target.DefPercent;
            }
            finally
            {
                //point = 1;
            }
            //Target.Life -= (point > 0) ? point : 1;
            Target.Life -= point;
            if (Target.Life < 0) Target.Life = 0;

        }

        public int PotionAmountCalc(int max, int current, int amount)
        {
            if (max >= current + amount) current += amount;
            else current = max;
            return current;
        }
        public void Recovery(Potion potion)
        {
            switch(potion.Type)
            {
                case PotionType.Life:
                    Life = PotionAmountCalc(MaxLife, Life, potion.Amount);          break;
                case PotionType.Mana:
                    Mana = PotionAmountCalc(MaxMana, Mana, potion.Amount);          break;
                case PotionType.Stamina:
                    Stamina = PotionAmountCalc(MaxStamina, Stamina, potion.Amount); break;
                case PotionType.None:
                    // Error
                    break;
            }
        }

    }
}
