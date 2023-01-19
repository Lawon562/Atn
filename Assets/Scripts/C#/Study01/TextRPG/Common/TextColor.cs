﻿using System;
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


        public static void SetAnimationColorBlack(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }


    }
}
