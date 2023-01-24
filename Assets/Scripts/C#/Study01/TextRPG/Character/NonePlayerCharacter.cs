using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Character
{
    class NonePlayerCharacter : Character
    {
        public NonePlayerCharacter(string name, string gender, ConsoleColor color)
        {
            this.Color = color;
            this.Name = name;
            this.Gender = gender;
        }
    }
}
