using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Object
{
    interface IWeapon
    {
        string Name { get; set; }
        int ApMin { get; set; }
        int ApMax { get; set; }
        
    }
}
