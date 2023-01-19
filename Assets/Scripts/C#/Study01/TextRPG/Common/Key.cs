using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Key
    {
        public static int windowSizeX = 80;
        public static int windowSizeY = 20;

        public static string[] menuStr = { "♤ 새로하기 ♤", "♤ 이어하기 ♤", "♤ 옵    션 ♤", "♤ 종    료 ♤" };
        public static string[] gameTitle = {
            "                _      _                       _ ",
            "  /\\/\\    __ _ | |__  (_) _ __    ___    __ _ (_)",
            " /    \\  / _` || '_ \\ | || '_ \\  / _ \\  / _` || |",
            "/ /\\/\\ \\| (_| || |_) || || | | || (_) || (_| || |",
            "\\/    \\/ \\__,_||_.__/ |_||_| |_| \\___/  \\__, ||_|",
            "                                        |___/    "
        };

        public static int titleX = windowSizeX / 2 - gameTitle.Max().Length / 2 - 1;
        public static int titleY = 3;

        public static string devDate = "2023-01-19 ver0.1";
        public static int menuX = windowSizeX / 2 - menuStr.Max().Length / 2 - 1;
        public static int menuY = 11;
    }
}
