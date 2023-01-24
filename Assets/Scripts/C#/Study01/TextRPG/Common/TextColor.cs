using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    /*------------------------------------------*
     * class : TextColor
     * 설명 : 배경/글자색을 관리하는 class
     *------------------------------------------*/
    static class TextColor
    {
        /*--------------------------------------------*
         * Method : ResetColor
         * 설명 : 글자색/배경색 검정색으로 초기화
         *--------------------------------------------*/
        public static void ResetColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static void SetBackground(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }
        public static void SetConsoleColor(ConsoleColor bg, ConsoleColor fr)
        {
            Console.BackgroundColor = bg;
            Console.ForegroundColor = fr;
        }

        /*--------------------------------------------*
         * Method : Back_White_Fore_Black
         * 설명 : 글자색-검정색, 배경색-하얀색
         *--------------------------------------------*/
        public static void BackWhiteForeBlack()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        /*--------------------------------------------*
         * Method : Fore_DarkGray
         * 설명 : 글자색-어두운 회색
         *--------------------------------------------*/
        public static void ForeDarkGray()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        /*--------------------------------------------*
         * Method : Fore_Yellow
         * 설명 : 글자색-노란색
         *--------------------------------------------*/
        public static void ForeYellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        /*--------------------------------------------*
         * Method : Fore_Black
         * 설명 : 글자색-검정색
         *--------------------------------------------*/
        public static void ForeBlack()
        {
            Console.ForegroundColor = ConsoleColor.Black;
        }

        /*--------------------------------------------*
         * Method : Fore_White
         * 설명 : 글자색-하얀색
         *--------------------------------------------*/
        public static void ForeWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        /*--------------------------------------------*
         * Method : Fore_Cyan
         * 설명 : 글자색-시안색
         *--------------------------------------------*/
        public static void ForeCyan()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        /*--------------------------------------------*
         * Method : BgCyan
         * 설명 : 글자색-시안색
         *--------------------------------------------*/
        public static void BgCyan()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
        }

        /*--------------------------------------------*
         * Method : BgCyan
         * 설명 : 글자색-시안색
         *--------------------------------------------*/
        public static void BgBlack()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }

        /*--------------------------------------------*
         * Method : BgCyan
         * 설명 : 글자색-시안색
         *--------------------------------------------*/
        public static void BgDarkGray()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
        }
        public static void BgDarkCyan()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
        }
        public static void SetAnimationColorBlack(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }


    }
}
