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
        public static string mapNameUITop = "┏────────────────────────────┓";
        public static string mapNameUIBot = "┣────────────────────────────┻────────────────────────────┓";
        public static void WriteUIFrame(string mapName)
        {
            Console.SetCursorPosition(0, 0);
            
            //Console.Write("┏");
            int mapFrameLength = mapName.Length + (mapName.Split().Length) * 2 + 1;
            //for (int i = 0; i < mapFrameLength; i++) Console.Write("━");
            //Console.WriteLine("┓");
            Console.WriteLine(mapNameUITop);

            //---------------
            Console.Write("│ ");

            

            Console.SetCursorPosition(mapNameUITop.Length - 1, 1);
            Console.WriteLine("│");
            //---------------

            Console.Write(mapNameUIBot);
            

            Console.SetCursorPosition(0, 8);
            Console.Write("┗");
            for (int i = 0; i < mapNameUIBot.Length-2; i++) Console.Write("─");
            Console.Write("┛");
        }

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
                    TextColor.ForeWhite();
                    string mapName = "소울 스트림";

                    
                    for (int i = 0; i < Key.color.Length; i++)
                    {
                        TextColor.SetAnimationColorBlack(Key.color[i]);
                        WriteUIFrame(mapName);
                        Thread.Sleep(100);
                    }

                    Console.SetCursorPosition(2, 1);
                    TextColor.BgDarkGray();
                    for (int i = 0; i < mapNameUITop.Length - 3; i++)
                    {
                        Console.Write(" ");
                        Thread.Sleep(25);
                    }
                    TextColor.BgBlack();


                    int mapNameLength = 0;
                    for (int i = 0; i < mapName.Length; i++)
                    {
                        if (mapName[i].Equals(" ")) mapNameLength += 1;
                        else mapNameLength += 2;
                    }

                    Console.SetCursorPosition((mapNameUITop.Length-2) / 2 - mapNameLength/2+2, 1);
                    TextColor.BgDarkGray();
                    TextColor.ForeWhite();
                    foreach (char ch in mapName)
                    {
                        Console.Write(ch);
                        Thread.Sleep(25);
                    }
                    
                    TextColor.ResetColor();
                    


                    Console.ReadLine();
                    
                    //-----------------
                    // 캐릭터 정보 물어보기
                    // - 이름
                    // - 성별
                    
                    

                    //-----------------
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
