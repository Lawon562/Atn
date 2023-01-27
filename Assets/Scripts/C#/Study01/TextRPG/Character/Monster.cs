using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Character;

namespace TextRPG.Character
{
    class Monster : Character
    {

        public Monster(string name)
        {
            this.Color = ConsoleColor.Red;
            this.Name = name;
            this.Life = 30;
            this.Str = 3;
            this.DefPoint = 1;
            this.DefPercent = 1;
        }
        public void Attack(Player Target)
        {
            int point = 0;
            try
            {
                point = (this.Str - Target.DefPoint) / Target.DefPercent;
            }
            catch (DivideByZeroException e)
            {
                point = 1;
            }
            catch (Exception e)
            {
                point = 1;
            }
            finally
            {
                
            }
            Target.Life -= (point > 0) ? point : 1;
            if (Target.Life < 0) Target.Life = 0;
        }
    }
}
