using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Key
    {
        public static int lastLine = 0;
        public static string mapNameUITop = "┏────────────────────────────┓";
        public static string mapNameUIBot = "┣────────────────────────────┻──────────────────────────────────────────────┓";
        public static string[] naoIntro =
        {
            "땅을 딛는 느낌에 눈을 뜨자, 켈트 매듭 문양이 새겨진 새하얀 바닥과 그 위에 서있는 소녀가 보인다.",
            "문양이 있는 검은색의 드레스를 입은 아름다운 소녀. 바다를 연상시키는 파란 눈동자는 빨려들어갈 것 같은 신비함이 느껴진다.",
            "맑고 깨끗한 피부와 마치 인형 같이 예쁜 몸매는 어딘지 현실의 사람이 아닌 것 같은 위화감이 있다."
        };


        public static bool game = true;

        public static int windowSizeX = 100;
        public static int windowSizeY = 24;

        public static string[] menuStr = { "♤ 새로하기 ♤", "♤ 이어하기 ♤", "♤ 옵    션 ♤", "♤ 종    료 ♤" };
        public static string[] gameTitle = {
            "                _      _                       _ ",
            "  /\\/\\    __ _ | |__  (_) _ __    ___    __ _ (_)",
            " /    \\  / _` || '_ \\ | || '_ \\  / _ \\  / _` || |",
            "/ /\\/\\ \\| (_| || |_) || || | | || (_) || (_| || |",
            "\\/    \\/ \\__,_||_.__/ |_||_| |_| \\___/  \\__, ||_|",
            "                                        |___/    "
        };
        public static ConsoleColor[] color = {
            ConsoleColor.Black,
            ConsoleColor.DarkGray,
            ConsoleColor.Gray,
            ConsoleColor.White,
        };
        public static string[] introStr = {
            "들리나요?",
            "아...",
            "제 말이 들리고 있군요..",
            "힘든 부탁이지만..",
            "이쪽 세상으로 와주세요.",
            "티르 나 노이가...",
            "파괴되려 합니다...",
            ""
        };


        public static int titleX = windowSizeX / 2 - gameTitle.Max().Length / 2 - 1;
        public static int titleY = 3;

        public static string devDate = "2023-01-19 ver0.1";
        public static int menuX = windowSizeX / 2 - menuStr.Max().Length / 2 - 1;
        public static int menuY = 11;
    }
}
