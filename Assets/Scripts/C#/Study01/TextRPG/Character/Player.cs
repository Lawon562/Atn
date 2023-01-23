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
            if (instance == null) return new Player("당신");
            return instance;
        }


        private Player(string name)
        {
            this.Name = name;
        }

        private Weapon weapon = new Weapon("나무 몽둥이", 3, 21);
        public Weapon Weapon { get; set; }

        

        public void Attack(Monster Target)
        {
            int point;
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
                // To-do Somthing
            }
            finally
            {
                point = 1;
            }
            Target.Life -= (point > 0) ? point : 1;
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
