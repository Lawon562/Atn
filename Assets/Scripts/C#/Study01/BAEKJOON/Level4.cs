﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAEKJOON
{
    /*
     * Level4 : 1차원 배열
     * 배열을 사용해 봅시다.
     */
    class Level4
    {
        /*
         * baekjoon 10807 - 개수 세기
         * 문제 : 총 N개의 정수가 주어졌을 때, 정수 v가 몇 개인지 구하는 프로그램을 작성하시오.
         * 입력 : 
         *      첫째 줄에 정수의 개수 N(1 ≤ N ≤ 100)이 주어진다. 
         *      둘째 줄에는 정수가 공백으로 구분되어져있다. 
         *      셋째 줄에는 찾으려고 하는 정수 v가 주어진다. 
         *      입력으로 주어지는 정수와 v는 -100보다 크거나 같으며, 100보다 작거나 같다.
         * 출력 : 
         *      첫째 줄에 입력으로 주어진 N개의 정수 중에 v가 몇 개인지 출력한다.
         */
        public void Q10807()
        {
            Console.ReadLine();
            var d = Console.ReadLine().Split();
            var v = Console.ReadLine();
            Console.WriteLine(d.Where(x => x == v).Count());
        }


        /*
         * baekjoon 10871 - X보다 작은 수
         * 문제 : n이 주어졌을 때, 1부터 n까지 합을 구하는 프로그램을 작성하시오.
         * 입력 : 첫째 줄에 n (1 ≤ n ≤ 10,000)이 주어진다.
         * 출력 : 1부터 n까지 합을 출력한다.
         */
        public void Q10871()
        {
            var X = int.Parse(Console.ReadLine().Split()[1]);
            var A = Console.ReadLine().Split();
            foreach (string data in A)
                if (int.Parse(data) < X)
                    Console.Write(data + " ");
        }


        /*
         * baekjoon 10818 - 최소, 최대
         * 문제 : 
         *      정수 N개로 이루어진 수열 A와 정수 X가 주어진다. 
         *      이때, A에서 X보다 작은 수를 모두 출력하는 프로그램을 작성하시오.
         * 입력 : 
         *      첫째 줄에 N과 X가 주어진다. (1 ≤ N, X ≤ 10,000)
         *      둘째 줄에 수열 A를 이루는 정수 N개가 주어진다. 
         *      주어지는 정수는 모두 1보다 크거나 같고, 
         *      10,000보다 작거나 같은 정수이다.
         * 출력 : 
         *      X보다 작은 수를 입력받은 순서대로 공백으로 구분해 출력한다. 
         *      X보다 작은 수는 적어도 하나 존재한다.
         */
        public void Q10818()
        {
            Console.ReadLine();
            var data = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            Console.WriteLine($"{data.Min()} {data.Max()}");
        }


        /*
         * baekjoon 2562 - 최댓값
         * 문제 : 
         *      9개의 서로 다른 자연수가 주어질 때, 이들 중 최댓값을 찾고 
         *      그 최댓값이 몇 번째 수인지를 구하는 프로그램을 작성하시오.
         *      
         *      예를 들어, 서로 다른 9개의 자연수
         *      3, 29, 38, 12, 57, 74, 40, 85, 61이 주어지면, 
         *      이들 중 최댓값은 85이고, 이 값은 8번째 수이다.
         *      
         * 입력 : 
         *      첫째 줄부터 아홉 번째 줄까지 한 줄에 하나의 자연수가 주어진다. 
         *      주어지는 자연수는 100 보다 작다.
         * 출력 : 
         *      첫째 줄에 최댓값을 출력하고, 둘째 줄에 최댓값이 몇 번째 수인지를 출력한다.
         */
        public void Q2562()
        {
            List<int> list = new List<int>();
            var i = 0;
            while(i++<9)
                list.Add(int.Parse(Console.ReadLine()));
            var max = list.Max();
            Console.WriteLine($"{max}\n{list.IndexOf(max)+1}");
        }


        /*
         * baekjoon 5597 - 과재 안내신 분..?
         * 문제 : 
         *      X대학 M교수님은 프로그래밍 수업을 맡고 있다. 
         *      교실엔 학생이 30명이 있는데, 학생 명부엔 각 학생별로 1번부터 30번까지 출석번호가 붙어 있다.
         *      교수님이 내준 특별과제를 28명이 제출했는데, 
         *      그 중에서 제출 안 한 학생 2명의 출석번호를 구하는 프로그램을 작성하시오.
         * 입력 : 
         *      입력은 총 28줄로 각 제출자(학생)의 출석번호 n(1 ≤ n ≤ 30)가 한 줄에 하나씩 주어진다. 
         *      출석번호에 중복은 없다.
         * 출력 : 
         *      출력은 2줄이다. 1번째 줄엔 제출하지 않은 학생의 출석번호 중 가장 작은 것을 출력하고, 
         *      2번째 줄에선 그 다음 출석번호를 출력한다.
         */
        public void Q5597()
        {
            List<int> list = Enumerable.Range(1, 30).ToList();
            var i = 2;
            while (i++ < 30)
            {
                var d = int.Parse(Console.ReadLine());
                list.RemoveAt(list.IndexOf(d));
            }
            Console.WriteLine(String.Join(" ", list));
        }


        /*
         * baekjoon 3052 - 나머지
         * 문제 : 
         *      두 자연수 A와 B가 있을 때, A%B는 A를 B로 나눈 나머지 이다. 
         *      예를 들어, 7, 14, 27, 38을 3으로 나눈 나머지는 1, 2, 0, 2이다. 
         *      수 10개를 입력받은 뒤, 이를 42로 나눈 나머지를 구한다. 
         *      그 다음 서로 다른 값이 몇 개 있는지 출력하는 프로그램을 작성하시오.
         * 입력 : 
         *      첫째 줄부터 열번째 줄 까지 숫자가 한 줄에 하나씩 주어진다. 
         *      이 숫자는 1,000보다 작거나 같고, 음이 아닌 정수이다.
         * 출력 : 
         *      첫째 줄에, 42로 나누었을 때, 서로 다른 나머지가 몇 개 있는지 출력한다.
         */
        public void Q3052()
        {
            HashSet<int> data = new HashSet<int>();
            var i = 0;
            while (i++ < 10)
                data.Add(int.Parse(Console.ReadLine()) % 42);
            Console.WriteLine(data.Count());
        }


        /*
         * baekjoon 1546 - 평균
         * 문제 : 
         *      세준이는 기말고사를 망쳤다. 
         *      세준이는 점수를 조작해서 집에 가져가기로 했다. 
         *      일단 세준이는 자기 점수 중에 최댓값을 골랐다. 
         *      이 값을 M이라고 한다. 그리고 나서 모든 점수를 점수/M*100으로 고쳤다.
         *      예를 들어, 세준이의 최고점이 70이고, 
         *      수학점수가 50이었으면 수학점수는 50/70*100이 되어 71.43점이 된다.
         *      세준이의 성적을 위의 방법대로 새로 계산했을 때, 
         *      새로운 평균을 구하는 프로그램을 작성하시오.
         *      
         * 입력 : 
         *      첫째 줄에 시험 본 과목의 개수 N이 주어진다. 
         *      이 값은 1000보다 작거나 같다. 둘째 줄에 세준이의 현재 성적이 주어진다. 
         *      이 값은 100보다 작거나 같은 음이 아닌 정수이고, 
         *      적어도 하나의 값은 0보다 크다.
         *      
         * 출력 : 
         *      첫째 줄에 새로운 평균을 출력한다. 
         *      실제 정답과 출력값의 절대오차 또는 상대오차가 10-2 이하이면 정답이다.
         */
        public void Q1546()
        {
            Console.ReadLine();
            var data = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
            Console.WriteLine(data.Sum() / data.Max() / data.Length*100);
        }


        /*
         * baekjoon 8958 - OX 퀴즈
         * 문제 : 
         *      "OOXXOXXOOO"와 같은 OX퀴즈의 결과가 있다. 
         *      O는 문제를 맞은 것이고, X는 문제를 틀린 것이다. 
         *      문제를 맞은 경우 그 문제의 점수는 그 문제까지 연속된 O의 개수가 된다. 
         *      예를 들어, 10번 문제의 점수는 3이 된다.
         *      "OOXXOXXOOO"의 점수는 1+2+0+0+1+0+0+1+2+3 = 10점이다.
         *      OX퀴즈의 결과가 주어졌을 때, 점수를 구하는 프로그램을 작성하시오.
         * 입력 : 
         *      첫째 줄에 테스트 케이스의 개수가 주어진다. 
         *      각 테스트 케이스는 한 줄로 이루어져 있고, 
         *      길이가 0보다 크고 80보다 작은 문자열이 주어진다. 
         *      문자열은 O와 X만으로 이루어져 있다.
         * 출력 : 
         *      각 테스트 케이스마다 점수를 출력한다.
         */
        public void Q8958()
        {
            int N = int.Parse(Console.ReadLine()), i = 0;
            while (i++ < N)
            {
                var T = Console.ReadLine().Split('X');
                var sum = 0;
                foreach (string data in T)
                    sum += (data.Length * (data.Length + 1)) / 2;
                Console.WriteLine(sum);
            }
        }


        /*
         * baekjoon 4344 - 평균은 넘겠지
         * 문제 : 
         *      대학생 새내기들의 90%는 자신이 반에서 평균은 넘는다고 생각한다. 
         *      당신은 그들에게 슬픈 진실을 알려줘야 한다.
         * 입력 : 
         *      첫째 줄에는 테스트 케이스의 개수 C가 주어진다.
         *      둘째 줄부터 각 테스트 케이스마다 학생의 수 N(1 ≤ N ≤ 1000, N은 정수)이 첫 수로 주어지고,
         *      이어서 N명의 점수가 주어진다. 
         *      점수는 0보다 크거나 같고, 100보다 작거나 같은 정수이다.
         * 출력 : 각 케이스마다 한 줄씩 평균을 넘는 학생들의 비율을 반올림하여 소수점 셋째 자리까지 출력한다.
         */
        public void Q4344()
        {
            int C = int.Parse(Console.ReadLine());
            while (C-- > 0)
            {
                var N = Array.ConvertAll(Console.ReadLine().Split(), int.Parse).Skip(1).ToArray();
                Console.WriteLine("{0:F3}%", (float)N.Count(d => d > N.Average()) / N.Length * 100);
            }
        }

    }
}