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
            foreach (string s in Key.introStr)
            {
                Console.Clear();

                SayFadeStart(s);
                WriteNext();

                Common.ClearInputBuffer();

                Console.ReadKey();
                SayFadeEnd(s);
            }
            TextColor.ResetColor();
        }

        static void SayFadeStart(string s)
        {
            for (int i = 0; i < Key.color.Length; i++)
            {
                WriteText(s, i);
                Thread.Sleep(100);
            }
        }

        static void SayFadeEnd(string s)
        {
            for (int i = Key.color.Length - 1; i >= 0; i--)
            {
                WriteText(s, i);
                Thread.Sleep(100);
            }
        }

        static void WriteText(string s, int i)
        {
            TextColor.SetAnimationColorBlack(Key.color[i]);
            Console.SetCursorPosition(Key.windowSizeX / 2 - s.Length, Key.windowSizeY / 2);
            Console.Write(s);
        }


        static void WriteNext()
        {
            String next = "아무 키나 눌러주세요 . . .";
            Console.SetCursorPosition(Key.windowSizeX - next.Length * 2 + 8, Key.windowSizeY - 1);
            Console.Write(next);
            Common.TextClearing();
            TextColor.ForeBlack();
        }

    }
}
