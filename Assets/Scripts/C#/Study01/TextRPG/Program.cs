using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Player
{

}

class Monster
{

}

namespace TextRPG
{
    class Program
    {
        static void StartSelect()
        {
            Console.WriteLine("에린에 오신 것을 환영합니다.");
            Console.WriteLine("당신은 마을에 들를 수 있고, 사냥터로 갈 수 있습니다.");
            Console.WriteLine("어디에 먼저 가보시겠습니까?\n");

            Console.WriteLine("왼쪽 방향키 : 마을 || 오른쪽 방향키 : 사냥터");
            Console.Write("입력 : ");
            var select = Console.ReadKey();
            if ((int)select.Key == 37)
            {
                Console.WriteLine("마을로 가기");
            }
            else if ((int)select.Key == 39)
            {
                Console.WriteLine("사냥터로 가기");
            }
        }


        static void Main(string[] args)
        {
            StartSelect();

            /*
             * 마을로 가면 "마을에 도착했다"라고 출력한다.
             * 1. 여관에 들른다.
             * 2. 공격력을 강화한다.
             * 3. 나간다.
             */

            /*
             * 싸움터로 가면 "싸움터에 도착했다" 라고 출력한다.
             * 1. 몬스터와 조우한다
             */

        }
    }
}
