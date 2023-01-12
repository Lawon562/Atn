﻿using System;


namespace BAEKJOON
{
    class Level1
    {
        /*
         * baekjoon 2557 - Hello World
         * 문제 : Hello World!를 출력하시오.
         * 출력 : Hello World!를 출력하시오.
         */
        public void Q2257()
        {
            Console.Write("Hello World!");
        }

        /*
         * baekjoon 1000 - A+B
         * 문제 : 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
         * 입력 : 첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)
         * 출력 : 첫째 줄에 A+B를 출력한다.
         * https://www.acmicpc.net/problem/1000
         */
        public void Q1000()
        {
            var number = Console.ReadLine();
            // 두 문자를 더한 아스키코드 값 - 두 문자의 최소 아스키코드값(48*2)
            Console.WriteLine(number[0] + number[2] - 96);
        }

        /*
         * baekjoon 1001 - A-B
         * 문제 : 두 정수 A와 B를 입력받은 다음, A-B를 출력하는 프로그램을 작성하시오.
         * 입력 : 첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)
         * 출력 : 첫째 줄에 A-B를 출력한다.
         */
        public void Q1001()
        {
            var number = Console.ReadLine();
            Console.WriteLine(number[0] - number[2]);
        }

        /*
         * baekjoon 10998 - A×B
         * 문제 : 두 정수 A와 B를 입력받은 다음, A×B를 출력하는 프로그램을 작성하시오.
         * 입력 : 첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)
         * 출력 : 첫째 줄에 A×B를 출력한다.
         */
        public void Q10998()
        {
            var number = Console.ReadLine();
            Console.WriteLine((number[0]-48) * (number[2]-48));
        }

        /*
         * baekjoon 1008 - A/B
         * 문제 : 두 정수 A와 B를 입력받은 다음, A/B를 출력하는 프로그램을 작성하시오.
         * 입력 : 첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)
         * 출력 : 첫째 줄에 A/B를 출력한다. 실제 정답과 출력값의 절대오차 또는 상대오차가 10-9 이하이면 정답이다.
         */
        public void Q1008()
        {
            var number = Console.ReadLine();
            Console.WriteLine((number[0]-48d)/(number[2]-48));
        }

        /*
         * baekjoon 10869 - 사칙연산
         * 문제 : 두 자연수 A와 B가 주어진다. 이때, A+B, A-B, A*B, A/B(몫), A%B(나머지)를 출력하는 프로그램을 작성하시오. 
         * 입력 : 두 자연수 A와 B가 주어진다. (1 ≤ A, B ≤ 10,000)
         * 출력 : 첫째 줄에 A+B, 둘째 줄에 A-B, 셋째 줄에 A*B, 넷째 줄에 A/B, 다섯째 줄에 A%B를 출력한다.
         */
        public void Q10869()
        {
            var number = Console.ReadLine().Split();
            var n1 = int.Parse(number[0]);
            var n2 = int.Parse(number[1]);
            var nl = "\n";
            Console.WriteLine(n1+n2+nl + (n1-n2)+nl + n1*n2+nl + n1/n2+nl + n1%n2);
        }

        /*
         * baekjoon 10926 - ??!
         * 문제 : 
         *      준하는 사이트에 회원가입을 하다가 joonas라는 아이디가 이미 존재하는 것을 보고 놀랐다. 
         *      준하는 놀람을 ??!로 표현한다. 
         *      준하가 가입하려고 하는 사이트에 이미 존재하는 아이디가 주어졌을 때, 놀람을 표현하는 프로그램을 작성하시오.
         * 입력 : 
         *      첫째 줄에 준하가 가입하려고 하는 사이트에 이미 존재하는 아이디가 주어진다. 
         *      아이디는 알파벳 소문자로만 이루어져 있으며, 길이는 50자를 넘지 않는다.
         * 출력 : 
         *      첫째 줄에 준하의 놀람을 출력한다. 놀람은 아이디 뒤에 ??!를 붙여서 나타낸다.
         */
        public void Q10926()
        {
            var id = Console.ReadLine();
            Console.WriteLine(id + "??!");
        }

        /*
         * baekjoon 18108 - 1998년생인 내가 태국에서는 2541년생?!
         * 문제 : 
         *      ICPC Bangkok Regional에 참가하기 위해 수완나품 국제공항에 막 도착한 팀 레드시프트 일행은 
         *      눈을 믿을 수 없었다. 공항의 대형 스크린에 올해가 2562년이라고 적혀 있던 것이었다.
         *      불교 국가인 태국은 불멸기원(佛滅紀元), 즉 석가모니가 열반한 해를 기준으로 연도를 세는 불기를 사용한다. 
         *      반면, 우리나라는 서기 연도를 사용하고 있다. 
         *      불기 연도가 주어질 때 이를 서기 연도로 바꿔 주는 프로그램을 작성하시오.
         * 입력 : 
         *      서기 연도를 알아보고 싶은 불기 연도 y가 주어진다. (1000 ≤ y ≤ 3000)
         * 출력 : 
         *      불기 연도를 서기 연도로 변환한 결과를 출력한다.
         */
        public void Q18108()
        {
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(y - 543);
        }

        /*
         * baekjoon 3003 - 킹, 퀸, 룩, 비숍, 나이트, 폰
         * 문제 : 
         *      동혁이는 오래된 창고를 뒤지다가 낡은 체스판과 피스를 발견했다. 
         *      체스판의 먼지를 털어내고 걸레로 닦으니 그럭저럭 쓸만한 체스판이 되었다. 
         *      하지만, 검정색 피스는 모두 있었으나, 흰색 피스는 개수가 올바르지 않았다. 
         *      체스는 총 16개의 피스를 사용하며, 킹 1개, 퀸 1개, 룩 2개, 비숍 2개, 나이트 2개, 폰 8개로 구성되어 있다. 
         *      동혁이가 발견한 흰색 피스의 개수가 주어졌을 때, 몇 개를 더하거나 빼야 
         *      올바른 세트가 되는지 구하는 프로그램을 작성하시오.
         * 입력 : 
         *      첫째 줄에 동혁이가 찾은 흰색 킹, 퀸, 룩, 비숍, 나이트, 폰의 개수가 주어진다. 
         *      이 값은 0보다 크거나 같고 10보다 작거나 같은 정수이다.
         * 출력 : 
         *      첫째 줄에 입력에서 주어진 순서대로 몇 개의 피스를 더하거나 빼야 되는지를 출력한다. 
         *      만약 수가 양수라면 동혁이는 그 개수 만큼 피스를 더해야 하는 것이고, 음수라면 제거해야 하는 것이다.
         */
        public void Q3003()
        {
            var p = Console.ReadLine().Split();
            int[] c = { 1, 1, 2, 2, 2, 8 };
            for(int i = 0; i<6; i++)
            {
                Console.Write(c[i] - int.Parse(p[i]) + " ");
            }
            Console.WriteLine();
        }

        /*
         * baekjoon 10430 - 나머지
         * 문제 : 
         *      (A+B)%C는 ((A%C) + (B%C))%C 와 같을까?
         *      (A×B)%C는 ((A%C) × (B%C))%C 와 같을까?
         *       세 수 A, B, C가 주어졌을 때, 위의 네 가지 값을 구하는 프로그램을 작성하시오.
         * 입력 : 
         *      첫째 줄에 A, B, C가 순서대로 주어진다. (2 ≤ A, B, C ≤ 10000) 
         * 출력 :
         *      첫째 줄에 (A+B)%C, 둘째 줄에 ((A%C) + (B%C))%C, 셋째 줄에 (A×B)%C, 넷째 줄에 ((A%C) × (B%C))%C를 출력한다.
         */
        public void Q10430()
        {
            var s = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(
                (s[0] + s[1]) % s[2] + "\n" +
                ((s[0] % s[2]) + (s[1] % s[2])) % s[2] + "\n" +
                (s[0] * s[1]) % s[2] + "\n" +
                ((s[0] % s[2]) * (s[1] % s[2])) % s[2] + "\n");
        }

        /*
         * baekjoon 2588 - 곱셈
         * 문제 : 
         *      (세 자리 수) × (세 자리 수)는 다음과 같은 과정을 통하여 이루어진다.
         *      
         *                 4  7  2  - - - - (1)
         *              × 3  8  5  - - - - (2)
         *      --------------------
         *              2  3  6  0  - - - - (3)
         *           3  7  7  6     - - - - (4)
         *        1  4  1  6        - - - - (5)
         *      --------------------
         *        1  8  1  7  2  0  - - - - (6)
         *
         *      (1)과 (2)위치에 들어갈 세 자리 자연수가 주어질 때 (3), (4), (5), (6)위치에 들어갈 값을 구하는 프로그램을 작성하시오.
         * 
         * 입력 : 
         *      첫째 줄에 (1)의 위치에 들어갈 세 자리 자연수가, 둘째 줄에 (2)의 위치에 들어갈 세자리 자연수가 주어진다.
         *      
         * 출력 : 
         *      첫째 줄부터 넷째 줄까지 차례대로 (3), (4), (5), (6)에 들어갈 값을 출력한다.
         */
        public void Q2588()
        {
            var (n1, n2) = (int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine(
                $"{n1 * (n2 % 10)}\n" +
                $"{n1 * (n2 / 10 % 10)}\n" +
                $"{n1 * (n2 / 100)}\n" +
                $"{n1 * n2}");
        }

        /*
         * baekjoon 10171 - 고양이
         * 문제 : 아래 예제와 같이 고양이를 출력하시오.
         * \    /\
         *  )  ( ')
         * (  /  )
         *  \(__)|
         * 입력 : 없음
         * 출력 : 고양이를 출력한다.
         */
        public void Q10171()
        {
            Console.WriteLine("\\    /\\\n )  ( ')\n(  /  )\n \\(__)|");
        }

        /*
         * baekjoon 10172 - 개
         * 문제 : 아래 예제와 같이 개를 출력하시오.
         * |\_/|
         * |q p|   /}
         * ( 0 )"""\
         * |"^"`    |
         * ||_/=\\__|
         * 입력 : 없음
         * 출력 : 개를 출력한다.
         */
        public void Q10172()
        {
            Console.WriteLine("|\\_/|\n|q p|   /}\n( 0 )\"\"\"\\\n|\"^\"`    |\n||_/=\\\\__|");
        }

        /*
         * baekjoon 25083 - 새싹
         * 문제 : 아래 예제와 같이 새싹을 출력하시오.
         *         ,r'"7
         *r`-_   ,'  ,/
         * \. ". L_r'
         *   `~\/
         *      |
         *      |
         * 입력 : 없음
         * 출력 : 새싹을 출력한다.
         */
        public void Q25083()
        {
            Console.WriteLine(@"         ,r'""7
r`-_   ,'  ,/
 \. "". L_r'
   `~\/
      |
      |");
        }
    }
}
