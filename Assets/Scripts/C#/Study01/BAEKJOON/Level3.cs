using System;
using System.Linq;
using System.Text;

namespace BAEKJOON
{
    class Level3
    {
        /*
         * baekjoon 2739 - 구구단
         * 문제 : N을 입력받은 뒤, 구구단 N단을 출력하는 프로그램을 작성하시오. 출력 형식에 맞춰서 출력하면 된다.
         * 입력 : 첫째 줄에 N이 주어진다. N은 1보다 크거나 같고, 9보다 작거나 같다.
         * 출력 : 출력형식과 같게 N*1부터 N*9까지 출력한다.
                2 * 1 = 2
                2 * 2 = 4
                2 * 3 = 6
                2 * 4 = 8
                2 * 5 = 10
                2 * 6 = 12
                2 * 7 = 14
                2 * 8 = 16
                2 * 9 = 18
         */
        public void Q2739()
        {
            int N = Console.Read() - 48;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{N} * {i} = {N * i}");
            }
        }


        /*
         * baekjoon 10950 - A+B-3
         * 문제 : 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
         * 입력 : 
         *      첫째 줄에 테스트 케이스의 개수 T가 주어진다.
         *      각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B < 10)
         * 출력 : 각 테스트 케이스마다 A+B를 출력한다.
         */
        public void Q10950()
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                var num = Console.ReadLine();
                Console.WriteLine(num[0] + num[2] - 96);
            }
        }


        /*
         * baekjoon 8393 - 합
         * 문제 : n이 주어졌을 때, 1부터 n까지 합을 구하는 프로그램을 작성하시오.
         * 입력 : 첫째 줄에 n (1 ≤ n ≤ 10,000)이 주어진다.
         * 출력 : 1부터 n까지 합을 출력한다.
         */
        public void Q8393()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n * (n + 1) / 2);
        }


        /*
         * baekjoon 25304 - 영수증
         * 문제 :
         * 준원이는 저번 주에 살면서 처음으로 코스트코를 가 봤다. 정말 멋졌다. 
         * 그런데, 몇 개 담지도 않았는데 수상하게 높은 금액이 나오는 것이다! 
         * 준원이는 영수증을 보면서 정확하게 계산된 것이 맞는지 확인해보려 한다.
         *
         *  영수증에 적힌,
         *      구매한 각 물건의 가격과 개수
         *      구매한 물건들의 총 금액
         *  을 보고, 구매한 물건의 가격과 개수로 계산한 총 금액이 
         *  영수증에 적힌 총 금액과 일치하는지 검사해보자.
         *  
         * 입력 : 
         *      첫째 줄에는 영수증에 적힌 총 금액 X가 주어진다.
         *      둘째 줄에는 영수증에 적힌 구매한 물건의 종류의 수 N이 주어진다.
         *      이후 N개의 줄에는 각 물건의 가격 a와 개수 b가 공백을 사이에 두고 주어진다.
         * 출력 : 
         *      구매한 물건의 가격과 개수로 계산한 총 금액이 영수증에 적힌 총 금액과 일치하면 Yes를 출력한다. 
         *      일치하지 않는다면 No를 출력한다.
         * 제한 :
         *       1 ≤ X ≤ 1,000,000,000
         *       1 ≤ N ≤ 100
         *       1 ≤ a ≤ 1,000,000
         *       1 ≤ b ≤ 10
         */
        public void Q25304()
        {
            int X = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                var obj = Console.ReadLine().Split();
                X -= int.Parse(obj[0]) * int.Parse(obj[1]);
            }
            Console.WriteLine(X == 0 ? "Yes" : "No");
        }


        /*
         * baekjoon 15552 - 빠른 A+B
         * 문제 :
         * 본격적으로 for문 문제를 풀기 전에 주의해야 할 점이 있다. 
         * 입출력 방식이 느리면 여러 줄을 입력받거나 출력할 때 시간초과가 날 수 있다는 점이다.
         * 
         * C++을 사용하고 있고 cin/cout을 사용하고자 한다면, cin.tie(NULL)과 sync_with_stdio(false)를 둘 다 적용해 주고, 
         * endl 대신 개행문자(\n)를 쓰자. 단, 이렇게 하면 더 이상 scanf/printf/puts/getchar/putchar 등 C의 입출력 방식을 사용하면 안 된다.
         * 
         * Java를 사용하고 있다면, Scanner와 System.out.println 대신 BufferedReader와 BufferedWriter를 사용할 수 있다. 
         * BufferedWriter.flush는 맨 마지막에 한 번만 하면 된다.
         * 
         * Python을 사용하고 있다면, input 대신 sys.stdin.readline을 사용할 수 있다.
         * 단, 이때는 맨 끝의 개행문자까지 같이 입력받기 때문에 문자열을 저장하고 싶을 경우 .rstrip()을 추가로 해 주는 것이 좋다.
         * 
         * 또한 입력과 출력 스트림은 별개이므로, 테스트케이스를 전부 입력받아서 저장한 뒤 전부 출력할 필요는 없다. 
         * 테스트케이스를 하나 받은 뒤 하나 출력해도 된다.
         * 
         * 자세한 설명 및 다른 언어의 경우는 이 글(https://www.acmicpc.net/board/view/22716)에 설명되어 있다.
         * 이 블로그 글(https://www.acmicpc.net/blog/view/55)에서 BOJ의 기타 여러 가지 팁을 볼 수 있다
         *  
         * 입력 : 
         *      첫 줄에 테스트케이스의 개수 T가 주어진다. T는 최대 1,000,000이다. 
         *      다음 T줄에는 각각 두 정수 A와 B가 주어진다. A와 B는 1 이상, 1,000 이하이다.
         * 출력 : 
         *      각 테스트케이스마다 A+B를 한 줄에 하나씩 순서대로 출력한다.
         */
        public void Q15552()
        {
            int T = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new StringBuilder();
            for (int i = 0; i < T; i++)
            {
                var N = Console.ReadLine().Split();
                sb.AppendLine((int.Parse(N[0]) + int.Parse(N[1])).ToString());
            }
            Console.WriteLine(sb.ToString());
        }


        /*
         * baekjoon 11021 - A+B-7
         * 문제 : 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
         * 입력 : 
         *      첫째 줄에 테스트 케이스의 개수 T가 주어진다.
         *      각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B < 10)
         * 출력 : 
         *      각 테스트 케이스마다 "Case #x: "를 출력한 다음, A+B를 출력한다. 
         *      테스트 케이스 번호는 1부터 시작한다.
         */
        public void Q11021()
        {
            int T = int.Parse(Console.ReadLine()) + 1;
            for (int i = 1; i < T; i++)
            {
                Console.WriteLine($"{"Case #"+i}: {(Array.ConvertAll(Console.ReadLine().Split(), int.Parse)).Sum()}");
            }
        }


        /*
         * baekjoon 11022 - A+B-8
         * 문제 : 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
         * 입력 : 
         *      첫째 줄에 테스트 케이스의 개수 T가 주어진다.
         *      각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B < 10)
         * 출력 : 
         *      각 테스트 케이스마다 "Case #x: A + B = C" 형식으로 출력한다. 
         *      x는 테스트 케이스 번호이고 1부터 시작하며, C는 A+B이다.
         */
        public void Q11022()
        {
            int T = int.Parse(Console.ReadLine()) + 1;
            for (int i = 1; i < T; i++)
            {
                var n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                Console.WriteLine($"{"Case #" + i}: {n[0]} + {n[1]} = {n.Sum()}");
            }
        }


        /*
         * baekjoon 2438 - 별 찍기 - 1
         * 문제 : 첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제
         * 입력 : 첫째 줄에 N(1 ≤ N ≤ 100)이 주어진다.
         * 출력 : 첫째 줄부터 N번째 줄까지 차례대로 별을 출력한다.
         * 
         * 예제 입력 1 :
            5
         * 예제 출력 1 : 
            *
            **
            ***
            ****
            *****
         */
        public void Q2438()
        {
            int T = int.Parse(Console.ReadLine()) + 1;
            for (int i = 1; i < T; i++)
                Console.WriteLine(new String('*', i));
        }

        /*
         * baekjoon 2439 - 별 찍기 - 2
         * 문제 : 
         *      첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제
         *      하지만, 오른쪽을 기준으로 정렬한 별(예제 참고)을 출력하시오.
         * 입력 : 첫째 줄에 N(1 ≤ N ≤ 100)이 주어진다.
         * 출력 : 첫째 줄부터 N번째 줄까지 차례대로 별을 출력한다.
         * 
         * 예제 입력 1 :
            5
         * 예제 출력 1 : 
                *
               **
              ***
             ****
            *****
         */
        public void Q2439()
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 1; i <= T; i++)
                Console.WriteLine(new String(' ', T - i) + new string('*', i));
        }


        /*
         * baekjoon 10952 - A+B-5
         * 문제 : 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
         * 입력 : 
         *      입력은 여러 개의 테스트 케이스로 이루어져 있다.
         *      각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B < 10)
         *      입력의 마지막에는 0 두 개가 들어온다.
         * 출력 : 각 테스트 케이스마다 A+B를 출력한다.
         */
        public void Q10952()
        {
            while (true)
            {
                var n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse).Sum();
                if (n == 0) break;
                Console.WriteLine(n);
            }
        }


        /*
        * baekjoon 10951 - A+B-4
        * 문제 : 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
        * 입력 : 
        *      입력은 여러 개의 테스트 케이스로 이루어져 있다.
        *      각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B < 10)
        * 출력 : 각 테스트 케이스마다 A+B를 출력한다.
        */
        public void Q10951()
        {
            string n;
            while ((n = Console.ReadLine()) != null)
            {
                Console.WriteLine(Array.ConvertAll(n.Split(), int.Parse).Sum());
            }
        }


        /*
        * baekjoon 1110 - 더하기 사이클
        * 문제 : 
        *       0보다 크거나 같고, 99보다 작거나 같은 정수가 주어질 때 다음과 같은 연산을 할 수 있다. 먼저 주어진 수가 10보다 작다면 앞에 0을 붙여 두 자리 수로 만들고, 각 자리의 숫자를 더한다. 그 다음, 주어진 수의 가장 오른쪽 자리 수와 앞에서 구한 합의 가장 오른쪽 자리 수를 이어 붙이면 새로운 수를 만들 수 있다. 다음 예를 보자.
        *       26부터 시작한다. 2+6 = 8이다. 새로운 수는 68이다. 6+8 = 14이다. 새로운 수는 84이다. 8+4 = 12이다. 새로운 수는 42이다. 4+2 = 6이다. 새로운 수는 26이다.
        *       위의 예는 4번만에 원래 수로 돌아올 수 있다. 따라서 26의 사이클의 길이는 4이다.
        *       N이 주어졌을 때, N의 사이클의 길이를 구하는 프로그램을 작성하시오.
        * 입력 : 첫째 줄에 N이 주어진다. N은 0보다 크거나 같고, 99보다 작거나 같은 정수이다.
        * 출력 : 첫째 줄에 N의 사이클 길이를 출력한다.
        */
        public void Q1110()
        {
            var N = int.Parse(Console.ReadLine());
            var cmpN = N;
            int count = 0;
            do
            {
                count++;
                N = ((N % 10) * 10) + ((N / 10 + N % 10) % 10);
            } while (N != cmpN);
            Console.WriteLine(count);
        }


    }
}