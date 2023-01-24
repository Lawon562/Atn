using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    static class Common
    {
        public static Random random = new Random();
        public static void TextClearing()
        {
            Console.SetCursorPosition(Key.windowSizeX-1, 0);
            Console.Write(" ");
        }

        public static void ClearInputBuffer()
        {
            while (Console.KeyAvailable) Console.ReadKey(false);
        }
        public static void ResetScreen()
        {
            Console.Clear();
            TextClearing();
            TextColor.ResetColor();
        }

        public static string PlayerInput()
        {
            Common.ClearInputBuffer();
            TextColor.BgBlack();
            TextColor.ForeWhite();
            Console.CursorVisible = true;
            string input = Console.ReadLine();
            Console.CursorVisible = false;
            return input;
        }

        public static void narration(string str)
        {
            Common.ClearInputBuffer();
            Key.lastLine++;
            TextColor.ForeDarkGray();
            SceneLineFunc.WriteLine(str);
            TextColor.ForeWhite();
            Key.lastLine++;
            TextColor.ResetColor();
        }

        public static string getBtnStr(string[] btns, bool direction = true)
        {
            ConsoleKey inputKey = ConsoleKey.LeftArrow;
            int selectNumber = 0;
            int lastLine = Key.lastLine;
            
            do
            {
                Common.ClearInputBuffer();
                TextColor.BgBlack();
                TextColor.ForeBlack();
                if (direction)
                {
                    if (selectNumber > 0 && inputKey == ConsoleKey.LeftArrow) selectNumber--;
                    else if (selectNumber < btns.Length - 1 && inputKey == ConsoleKey.RightArrow) selectNumber++;
                }
                else
                {
                    if (selectNumber > 0 && inputKey == ConsoleKey.UpArrow) selectNumber--;
                    else if (selectNumber < btns.Length - 1 && inputKey == ConsoleKey.DownArrow) selectNumber++;
                }

                Common.TextClearing();
                Console.Write(" ");
                lastLine = Key.lastLine;
                Console.SetCursorPosition(2, lastLine);
                Common.ClearInputBuffer();

                for (int i = 0; i < btns.Length; i++)
                {
                    if (selectNumber == i) TextColor.SetConsoleColor(ConsoleColor.White, ConsoleColor.Black);
                    else TextColor.SetConsoleColor(ConsoleColor.Black, ConsoleColor.White);
                    Console.Write($"   {btns[i]}   ");
                    TextColor.SetConsoleColor(ConsoleColor.Black, ConsoleColor.White);
                    Console.Write("  ");
                    if (!direction) Console.SetCursorPosition(2, ++lastLine);
                }
                TextColor.ResetColor();
            } while ((inputKey = Console.ReadKey().Key) != ConsoleKey.Enter);
            Key.lastLine = lastLine;
            Key.lastLine += 2;

            

            return btns[selectNumber];
        }


        public static void WriteNext()
        {
            String next = "아무 키나 눌러주세요 . . .";
            Console.SetCursorPosition(Key.windowSizeX - next.Length * 2 + 8, Key.windowSizeY - 1);
            Console.Write(next);
            Common.TextClearing();
            TextColor.ForeBlack();
        }

        public static void WriteNextScene(string next, bool color = false)
        {
            TextColor.BgBlack();
            if (color) TextColor.ForeDarkGray();
            else TextColor.ForeWhite();


            Console.SetCursorPosition(Key.windowSizeX - next.Length * 2 + 8, Key.lastLine++);
            Console.Write(next);
            TextColor.ForeBlack();
        }

        public static void Exit()
        {
            TextColor.ForeWhite();
            Console.Write("게임을 종료하시겠습니까?(yes를 입력하시면 게임이 종료됩니다) : ");
            if (Console.ReadLine().Equals("yes")) Key.game = false;
            ResetScreen();
        }
    }
}
