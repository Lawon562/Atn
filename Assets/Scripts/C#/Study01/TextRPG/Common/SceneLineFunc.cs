using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextRPG
{
    public class SceneLineFunc
    {

        public static void WriteLine(string str, bool anim = true)
        {
            Console.SetCursorPosition(2, Key.lastLine);
            foreach (char ch in str)
            {
                Console.Write(ch);
                if (anim) Thread.Sleep(50);
            }
            Key.lastLine++;
        }
        public static void WriteLines(string[] introStr)
        {
            Console.SetCursorPosition(2, Key.lastLine);
            foreach (string intro in introStr)
            {
                int lineCount = 0;
                foreach (char ch in intro)
                {
                    lineCount += (ch != ' ') ? 2 : 1;
                    if (lineCount > Key.mapNameUIBot.Length - 2)
                    {
                        lineCount = 0;
                        Console.SetCursorPosition(2, ++Key.lastLine);
                    }
                    Console.Write(ch);
                    Thread.Sleep(50);
                }
                Console.SetCursorPosition(2, ++Key.lastLine);
            }
        }

        public static void WriteIntro(int x, int y, string[] introStr)
        {
            Console.SetCursorPosition(x, y);
            foreach (string intro in introStr)
            {
                int lineCount = 0;

                foreach (char ch in intro)
                {
                    lineCount += (ch != ' ') ? 2 : 1;
                    if (lineCount > Key.mapNameUIBot.Length - 2)
                    {
                        lineCount = 0;
                        Console.SetCursorPosition(2, ++y);
                    }
                    Console.Write(ch);
                    Thread.Sleep(30);
                }
                Common.TextClearing();
                Console.SetCursorPosition(2, y += 2);
            }
        }

        public static void WriteIntro(string[] introStr)
        {
            int x = 2;
            int y = 3;
            Console.SetCursorPosition(x, y);
            foreach (string intro in introStr)
            {
                int lineCount = 0;

                foreach (char ch in intro)
                {
                    lineCount += (ch != ' ') ? 2 : 1;
                    if (lineCount > Key.mapNameUIBot.Length - 2)
                    {
                        lineCount = 0;
                        Console.SetCursorPosition(2, ++y);
                    }
                    Console.Write(ch);
                    Thread.Sleep(30);
                }
                Common.TextClearing();
                Console.SetCursorPosition(2, y += 2);
            }
        }

        public static void WriteScript(string name, string script)
        {
            WriteCharacterName(name);
            WriteLine(script, true);
            Key.lastLine++;
        }

        public static void WriteScript(string name, string[] script)
        {
            WriteCharacterName(name);
            WriteLines(script);
            //Key.lastLine++;
        }

        public static void WriteCharacterName(string name)
        {
            Key.lastLine++;
            TextColor.BgDarkCyan();
            TextColor.ForeWhite();
            WriteLine($" 《 {name} 》 ", false);
            TextColor.BgBlack();
            TextColor.ForeWhite();
            Key.lastLine++;
        }
    }
}
