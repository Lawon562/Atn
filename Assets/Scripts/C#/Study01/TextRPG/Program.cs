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
        public static int lastLine = 0;
        public static string mapNameUITop = "┏────────────────────────────┓";
        public static string mapNameUIBot = "┣────────────────────────────┻──────────────────────────────────────────────┓";
        /*
         * type 0 : 애니메이션 없는 버전
         * type 1 : 애니메이션 있는 버전
         */
        public static void WriteUI(string mapName, int type)
        {
            /* UI Frame 생성(type에 따라 애니메이션 이용) */
            if (type == 0) WriteUIFrame();
            else WriteUIFrameAnimation();
            /* UI Map 출력 부분에 하이라이트 출력 */
            WriteUIMapHighlight();
            /* UI Map 출력 부분에 MapName 출력 */
            WriteMapName(mapName);
        }
        public static void WriteUIMapHighlight()
        {
            Console.SetCursorPosition(2, 1);
            TextColor.BgDarkGray();
            for (int i = 0; i < mapNameUITop.Length - 3; i++)
            {
                Console.Write(" ");
                Thread.Sleep(25);
            }
            TextColor.BgBlack();
        }
        public static void WriteMapName(string mapName)
        {
            int mapNameLength = 0;
            for (int i = 0; i < mapName.Length; i++)
            {
                if (mapName[i].Equals(" ")) mapNameLength += 1;
                else mapNameLength += 2;
            }

            Console.SetCursorPosition((mapNameUITop.Length - 2) / 2 - mapNameLength / 2 + 2, 1);
            TextColor.BgDarkGray();
            TextColor.ForeWhite();
            foreach (char ch in mapName)
            {
                Console.Write(ch);
                Thread.Sleep(25);
            }
        }
        public static void WriteUIFrameAnimation()
        {
            for (int i = 0; i < Key.color.Length; i++)
            {
                TextColor.SetAnimationColorBlack(Key.color[i]);
                WriteUIFrame();
                Thread.Sleep(100);
            }
        }
        public static void WriteUIFrame()
        {
            /* UI - mapName 상단 프레임 */
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(mapNameUITop);

            /* UI - mapName 중단 프레임 */
            Console.Write("│ ");
            Console.SetCursorPosition(mapNameUITop.Length - 1, 1);
            Console.WriteLine("│");

            /* UI - mapName 하단 프레임 */
            Console.Write(mapNameUIBot);

            /* UI - 전체 UI 하단 프레임 */
            Console.SetCursorPosition(0, lastLine-1);
            Console.Write("┗");
            for (int i = 0; i < mapNameUIBot.Length-2; i++) Console.Write("─");
            Console.Write("┛");
            
        }

        public static void WriteLine(string str)
        {
            Console.SetCursorPosition(2, lastLine);
            foreach (char ch in str)
            {
                Console.Write(ch);
                Thread.Sleep(30);
            }
            //Common.TextClearing();
            lastLine++;
        }
        public static void WriteLine(int x, int y, string str)
        {
            Console.SetCursorPosition(x, y);
            foreach (char ch in str)
            {
                Console.Write(ch);
                Thread.Sleep(30);
            }
            Common.TextClearing();    
        }
        public static void WriteLines(string[] introStr)
        {
            Console.SetCursorPosition(2, lastLine);
            foreach (string intro in introStr)
            {
                int lineCount = 0;
                foreach (char ch in intro)
                {
                    lineCount += (ch != ' ') ? 2 : 1;
                    if (lineCount > mapNameUIBot.Length - 2)
                    {
                        lineCount = 0;
                        Console.SetCursorPosition(2, ++lastLine);
                    }
                    Console.Write(ch);
                    Thread.Sleep(50);
                }
                Common.TextClearing();
                Console.SetCursorPosition(2, ++lastLine);
            }
        }
        public static void WriteLines(int x, int y, string[] introStr)
        {
            Console.SetCursorPosition(x, y);
            foreach (string intro in introStr)
            {
                int lineCount = 0;
                foreach (char ch in intro)
                {
                    lineCount += (ch != ' ') ? 2 : 1;
                    if (lineCount > mapNameUIBot.Length - 2)
                    {
                        lineCount = 0;
                        Console.SetCursorPosition(2, ++y);
                    }
                    Console.Write(ch);
                    Thread.Sleep(50);
                }
                Common.TextClearing();
                Console.SetCursorPosition(2, ++y);
            }
        }

        public static void WriteIntro(int x, int y, string[] introStr)
        {
            //Console.SetCursorPosition(2, 3);
            Console.SetCursorPosition(x, y);
            //int i = 3;
            foreach (string intro in introStr)
            {
                int lineCount = 0;

                foreach (char ch in intro)
                {
                    lineCount += (ch != ' ') ? 2 : 1;
                    if (lineCount > mapNameUIBot.Length - 2)
                    {
                        lineCount = 0;
                        //Console.SetCursorPosition(2, ++i);
                        Console.SetCursorPosition(2, ++y);
                    }
                    Console.Write(ch);
                    Thread.Sleep(30);
                }
                Common.TextClearing();
                //Console.SetCursorPosition(2, i += 2);
                Console.SetCursorPosition(2, y += 2);
            }
        }
        public static int GetLines(string[] introStr)
        { 
            int i = 3;
            foreach (string intro in introStr)
            {
                int lineCount = 0;

                foreach (char ch in intro)
                {
                    lineCount += (ch != ' ') ? 2 : 1;
                    if (lineCount > mapNameUIBot.Length-2)
                    {
                        lineCount = 0;
                        Console.SetCursorPosition(2, ++i);
                    }
                }
                Console.SetCursorPosition(2, i+=2);
            }
            return i;
        }

        //------------
        static void Main(string[] args)
        {
            Settings.Set();
            while (Key.game)
            {
                Common.ResetScreen();
                int select = 1;// TitleScene.Play();
                Console.Clear();
                if (select == 1)
                {
                    //IntroScene.Play();
                    TextColor.ForeWhite();

                    string mapName = "소울 스트림";
                    string[] naoIntro =
                    {
                        "땅을 딛는 느낌에 눈을 뜨자, 켈트 매듭 문양이 새겨진 새하얀 바닥과 그 위에 서있는 소녀가 보인다.",
                        "문양이 있는 검은색의 드레스를 입은 아름다운 소녀. 바다를 연상시키는 파란 눈동자는 빨려들어갈 것 같은 신비함이 느껴진다.",
                        "맑고 깨끗한 피부와 마치 인형 같이 예쁜 몸매는 어딘지 현실의 사람이 아닌 것 같은 위화감이 있다."
                    };
                    lastLine = GetLines(naoIntro);
                    
                    WriteUI(mapName, 1);
                    
                    TextColor.ForeWhite();
                    TextColor.BgBlack();
                    WriteIntro(2,3,naoIntro);

                    string[] CreatePlayerLines =
                    {
                        "안녕하세요? 당신이 도착하길 기다리고 있었어요.",
                        "제 이름은 나오라고 해요. 당신같이 순수한 영혼을 에린으로 인도하는 것이 제 역할입니다. 만나서 반가워요."
                    };

                    TextColor.BgDarkCyan();
                    TextColor.ForeWhite();
                    WriteLine(" 《 나오 》 ");
                    TextColor.BgBlack();
                    TextColor.ForeWhite();
                    lastLine++;

                    WriteLines(CreatePlayerLines);

                    WriteLine("우선, 당신이 에린에서 불릴 이름을 알려주실 수 있으실까요? ");
                    lastLine++;

                    TextColor.BgDarkCyan();
                    TextColor.ForeWhite();
                    WriteLine(" 《 당신 》 ");
                    TextColor.BgBlack();
                    TextColor.ForeWhite();
                    lastLine++;

                    WriteLine("(당신의 이름을 입력해주세요)");

                    WriteLine("내 이름은... ");
                    Console.CursorVisible = true;
                    string name = Console.ReadLine();
                    WriteLine($"『{name}』 이야.");
                    Console.CursorVisible = false;
                    lastLine++;

                    TextColor.BgDarkCyan();
                    TextColor.ForeYellow();
                    WriteLine(" 《 나오 》 ");
                    TextColor.BgBlack();
                    TextColor.ForeWhite();
                    lastLine++;

                    WriteLine($"{name}..{name} 님이시군요. ");
                    string[] ar = {"이곳 소울 스트림에선 당신의 성별을 선택할 수 있어요.",
                        "당신의 성별을 선택해주시겠어요?" };
                    WriteLines(ar);
                    lastLine++;

                    TextColor.BgDarkCyan();
                    TextColor.ForeWhite();
                    WriteLine(" 《 당신 》 ");
                    TextColor.BgBlack();
                    TextColor.ForeWhite();
                    lastLine++;

                    WriteLine("(다음 텍스트 중 하나를 입력해 주세요. (남자/여자)) : ");
                    Console.CursorVisible = true;
                    string sex = Console.ReadLine();
                    WriteLine($"난 {sex}야.");
                    Console.CursorVisible = false;
                    lastLine++;


                    TextColor.ResetColor();
                    Console.ReadLine();
                    
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
