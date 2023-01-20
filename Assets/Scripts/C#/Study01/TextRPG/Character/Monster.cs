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

        public void Attack(Player Target)
        {
            int point;
            try
            {
                point = (this.Str - Target.DefPoint) / Target.DefPercent;
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
    }
}
