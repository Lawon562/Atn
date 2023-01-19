using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Settings
    {
        /*------------------------------------------*
         * Method : Settings
         * 설명 : 게임의 설정을 관리하는 메소드
         *  - 커서 보이기 : 끄기
         *  - 콘솔 사이즈 설정
         *  - 콘솔 위치 설정
         *  - 콘솔 타이틀 설정
         *  - 글자색 : 검정
         *------------------------------------------*/
        public static void Set()
        {
            Console.CursorVisible = false;                              // Set Cursor visible
            Console.SetWindowSize(Key.windowSizeX, Key.windowSizeY);    // Set Window Size
            Console.SetWindowPosition(0, 0);                            // Set Window Position
            Console.Title = "Text RPG";                                 // Set Console Title
            TextColor.ForeBlack();                                         // Set Default Text Color
        }
    }
}
