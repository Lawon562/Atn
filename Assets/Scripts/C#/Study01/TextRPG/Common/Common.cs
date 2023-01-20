﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    static class Common
    {
        public static void TextClearing()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(" ");
        }

        public static void ResetScreen()
        {
            Console.Clear();
            Common.TextClearing();
            TextColor.ResetColor();
        }

        public static void Exit()
        {
            TextColor.ForeWhite();
            Console.Write("게임을 종료하시겠습니까?(yes를 입력하시면 게임이 종료됩니다) : ");
            if (Console.ReadLine().Equals("yes")) Key.game = false;
            Common.ResetScreen();
        }
    }
}