using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextRPG
{
    class TitleScene
    {
        public static int Play()
        {
            TitleUI();
            return SelectMenu();
        }

        /*-------------------------------------------------------*
         * Method : Title
         * 
         * 설명 : 타이틀 화면 출력 메소드
         *  - WriteVersionDate() : 버전 및 수정일자 출력
         *  - WriteGameTitle() : 게임 타이틀을 아스키아트로 출력
         *  - WriteMenu() : 메뉴 출력
         *-------------------------------------------------------*/
        static void TitleUI()
        {
            WriteVersionDate();
            WriteGameTitle();
            WriteMenu();

            Common.TextClearing();          // 출력 버퍼 비우기
            TextColor.ResetColor();         // 화면 글자색/배경색 검정색으로 초기화
        }

        /*-------------------------------------------------------*
         * Method : WriteVersionDate
         * 
         * 설명 : 화면에 개발 버전/날짜를 출력
         *  - 타이틀 우측 하단에 버전 출력
         *  - 출력되는 글자색은 검정색
         *  - WriteVersionDate 가 끝나기 전 글자색/배경색은 검정색으로 설정된다.
         *-------------------------------------------------------*/
        static void WriteVersionDate()
        {
            TextColor.Fore_DarkGray();
            Console.SetCursorPosition(Key.windowSizeX - Key.devDate.Length - 1, Key.windowSizeY - 1);
            Console.Write(Key.devDate);
            Common.TextClearing();
        }

        /*-------------------------------------------------------*
         * Method : WriteGameTitle
         * 
         * 설명 : 화면에 게임 타이틀 출력
         *  - 글씨 색깔 : 노란색
         *  - x : (콘솔화면너비/2) - (게임타이틀최대길이/2) - 1
         *  - y : 3;
         *  - 타이틀은 아스키코드로, 여러 줄의 문자열로 출력됨
         *  - 글자 출력 시 애니메이션 효과를 넣어야함.
         *-------------------------------------------------------*/
        static void WriteGameTitle()
        {
            TextColor.Fore_Yellow();

            int x = Key.titleX;
            int y = Key.titleY;

            foreach (string s in Key.gameTitle)
            {
                Console.SetCursorPosition(x, y++);
                
                foreach (char ch in s)      /* 애니메이션 효과 */
                {
                    Console.Write(ch);
                    if (ch != ' ') Thread.Sleep(1);
                }
            }
        }

        /*-------------------------------------------------------*
         * Method : WriteMenu
         * 
         * 설명 : 화면에 메뉴 출력
         *  - menuX, menuY 위치에 메뉴 문자열 배열 출력
         *  - 메뉴문자열 하나당 한 줄씩 띄워서 출력한다.
         *-------------------------------------------------------*/
        static void WriteMenu()
        {
            int x = Key.menuX;
            int y = Key.menuY;
            foreach (string s in Key.menuStr)
            {
                Console.SetCursorPosition(x, y);
                y += 2;
                foreach (char ch in s) Console.Write(ch);
            }
        }

        /*-------------------------------------------------------*
         * Method : SelectMenu
         * 
         * 설명 : 메뉴 선택 UI를 업데이트하고, 선택한 메뉴를 반환하는 메소드
         *  - W/S 또는 Up/DownArrow 버튼에 따라 ☞ 모양으로 메뉴를 가리킴
         *  - 고를 메뉴에 ☞를 두고, 엔터를 누르면 정해진 값이 반환됨
         *  - 새로하기(1)
         *  - 이어하기(2)
         *  - 옵션(3)
         *  - 종료(4)
         *-------------------------------------------------------*/
        static int SelectMenu()
        {
            int x = Key.windowSizeX / 2 - Key.menuStr.Max().Length / 2 - 5;
            int y = Key.menuY;
            WriteSelectUI(x, y, y);

            ConsoleKeyInfo select;
            do
            {
                x = Key.windowSizeX / 2 - Key.menuStr[0].Length / 2 - 6;
                select = Console.ReadKey();
                if (y > Key.menuY && (select.Key == ConsoleKey.UpArrow || select.Key == ConsoleKey.W))
                {
                    WriteSelectUI(x, y, y - 2);
                    y -= 2;
                }
                if (y < Key.menuY + (Key.menuStr.Length - 1) * 2 && (select.Key == ConsoleKey.DownArrow || select.Key == ConsoleKey.S))
                {
                    WriteSelectUI(x, y, y + 2);
                    y += 2;
                }
            } while (select.Key != ConsoleKey.Enter);
            TextColor.Fore_White();
            return (y - Key.menuY) / 2 + 1;
        }

        /*-------------------------------------------------------*
         * Method : WriteSelectUI
         * 
         * 설명 : 메뉴 선택 UI 업데이트
         *  - 글자색 : 하얀색
         *  - 움직이기 전 좌표(x,y)에 있던 글자를 초기화하고
         *    움직일 좌표(x,n)에 ☞를 출력한다.
         *  - 출력 버퍼 초기화 및 글자색/배경색 검정색으로 설정
         *-------------------------------------------------------*/
        public static void WriteSelectUI(int x, int y, int n)
        {
            TextColor.Fore_White();

            Console.SetCursorPosition(x, y);
            Console.Write("  ");
            Console.SetCursorPosition(x, n);
            Console.Write("☞");

            Common.TextClearing();
            TextColor.ResetColor();
        }
    }
}
