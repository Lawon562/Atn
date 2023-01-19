using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    class IntroScene
    {
        public static void Play()
        {
            TextColor.ForeWhite();
            Thread.Sleep(1000);
            foreach (string s in stc)
            {
                Console.Clear();

                SayFadeStart(s);
                WriteNext();

                Console.ReadKey();
                SayFadeEnd(s);
            }
            TextColor.ResetColor();
        }

        public static ConsoleColor[] color = {
            ConsoleColor.Black,
            ConsoleColor.DarkGray,
            ConsoleColor.Gray,
            ConsoleColor.White,
        };
        public static string[] stc = {
            "들리나요?",
            "아...",
            "제 말이 들리고 있군요..",
            "힘든 부탁이지만..",
            "이쪽 세상으로 와주세요.",
            "티르 나 노이가...",
            "파괴되려 합니다...",
            ""
        };

        static void SayFadeStart(string s)
        {
            for (int i = 0; i < color.Length; i++)
            {
                WriteText(s, i);
                Thread.Sleep(100);
            }
        }

        static void SayFadeEnd(string s)
        {
            for (int i = color.Length - 1; i >= 0; i--)
            {
                WriteText(s, i);
                Thread.Sleep(100);
            }
        }

        static void WriteText(string s, int i)
        {
            TextColor.SetAnimationColorBlack(color[i]);
            Console.SetCursorPosition(Key.windowSizeX / 2 - s.Length, Key.windowSizeY / 2);
            Console.Write(s);
        }


        static void WriteNext()
        {
            String next = "아무 키나 눌러주세요 . . .";
            Console.SetCursorPosition(Key.windowSizeX - next.Length * 2 + 8, Key.windowSizeY - 1);
            Console.Write(next);
            Common.TextClearing();
        }

    }
}
