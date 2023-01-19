using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
/*
 * 프로젝트 이름 : 
 * 개발 일자 : 2023.01.19
 * 프로젝트 설명 : Console로 플레이하는 Text RPG
 */

namespace TextRPG
{
    class Program
    { 
        static void Exit()
        {
            TextColor.Fore_White();
            Console.Write("게임을 종료하시겠습니까?(yes를 입력하시면 게임이 종료됩니다) : ");
            if (Console.ReadLine().Equals("yes")) return;
            TextColor.ResetColor();
        }

        static void Main(string[] args)
        {
            Settings.Set();
            //int select = TitleScene.Play();

            

        }
    }
}
