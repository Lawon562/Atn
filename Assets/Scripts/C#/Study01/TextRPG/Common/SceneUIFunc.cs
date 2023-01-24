using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextRPG
{
    class SceneUIFunc
    {
        /*
         * 메소드 : GetLines
         * 설명 : UIFrame 설정 전에 설명될 내용의 줄 수를 반환하는 함수
         */
        public static int GetLines(string[] introStr)
        {
            int i = 3;
            foreach (string intro in introStr)
            {
                int lineCount = 0;

                foreach (char ch in intro)
                {
                    lineCount += (ch != ' ') ? 2 : 1;
                    if (lineCount > Key.mapNameUIBot.Length - 2)
                    {
                        lineCount = 0;
                        Console.SetCursorPosition(2, ++i);
                    }
                }
                Console.SetCursorPosition(2, i += 2);
            }
            return i;
        }

        public static void WriteUI(string mapName, string[] intro, bool anim = false)
        {
            TextColor.ForeWhite();

            Console.Clear();
            Key.lastLine = GetLines(intro);
            /* UI Frame 생성(type에 따라 애니메이션 이용) */
            if (anim) WriteUIFrame();
            else WriteUIFrameAnimation();
            /* UI Map 출력 부분에 하이라이트 출력 */
            WriteUIMapHighlight();
            /* UI Map 출력 부분에 MapName 출력 */
            WriteMapName(mapName);

            TextColor.ForeWhite();
            TextColor.BgBlack();
            SceneLineFunc.WriteIntro(intro);
        }
        public static void WriteUIMapHighlight()
        {
            Console.SetCursorPosition(2, 1);
            TextColor.BgDarkGray();
            for (int i = 0; i < Key.mapNameUITop.Length - 3; i++)
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

            Console.SetCursorPosition((Key.mapNameUITop.Length - 2) / 2 - mapNameLength / 2 + 2, 1);
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
            Console.WriteLine(Key.mapNameUITop);

            /* UI - mapName 중단 프레임 */
            Console.Write("│ ");
            Console.SetCursorPosition(Key.mapNameUITop.Length - 1, 1);
            Console.WriteLine("│");

            /* UI - mapName 하단 프레임 */
            Console.Write(Key.mapNameUIBot);

            /* UI - 전체 UI 하단 프레임 */
            Console.SetCursorPosition(0, Key.lastLine - 1);
            Console.Write("┗");
            for (int i = 0; i < Key.mapNameUIBot.Length - 2; i++) Console.Write("─");
            Console.Write("┛");

        }

    }
}
