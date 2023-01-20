using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using TextRPG.Scenes;
using TextRPG.Character;
using TextRPG.Object;
/*
* 프로젝트 이름 : 
* 개발 일자 : 2023.01.19
* 프로젝트 설명 : Console로 플레이하는 Text RPG
*/

namespace TextRPG
{
    class Program
    {
        //------------
        static void Main(string[] args)
        {
            Settings.Set();
            while (Key.game)
            {
                Common.ResetScreen();
                int select = TitleScene.Play();
                Console.Clear();
                if (select == 1)
                {
                    IntroScene.Play();
                }
                else if (select == 4)
                {
                    Common.Exit();
                }
            }
        }
        //------------
        
        
    }
}
