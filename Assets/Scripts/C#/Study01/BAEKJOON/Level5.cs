using System;
using System.Collections.Generic;
using System.Linq;

namespace BAEKJOON
{
    class Level5
    {
        /*
         * baekjoon 15596 - 정수 N개의 합
         * 문제 : 정수 n개가 주어졌을 때, n개의 합을 구하는 함수를 작성하시오.
         * 언어제한 : C#없음
         */
        public long sum(int[] a)
        {
            long res = a.Sum();
            return res;
        }
        public void Q15596()
        {
            int[] N = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(sum(N));
        }

        /*
         * baekjoon 4673 - 셀프 넘버
         * 문제 : 
         *      셀프 넘버는 1949년 인도 수학자 D.R. Kaprekar가 이름 붙였다. 
         *      양의 정수 n에 대해서 d(n)을 n과 n의 각 자리수를 더하는 함수라고 정의하자. 예를 들어, d(75) = 75+7+5 = 87이다.
         *      양의 정수 n이 주어졌을 때, 이 수를 시작해서 n, d(n), d(d(n)), d(d(d(n))), ...과 같은 무한 수열을 만들 수 있다. 
         *      예를 들어, 33으로 시작한다면 다음 수는 33 + 3 + 3 = 39이고, 그 다음 수는 39 + 3 + 9 = 51, 다음 수는 51 + 5 + 1 = 57이다. 이런식으로 다음과 같은 수열을 만들 수 있다.
         *      
         *      33, 39, 51, 57, 69, 84, 96, 111, 114, 120, 123, 129, 141, ...
         *      n을 d(n)의 생성자라고 한다. 위의 수열에서 33은 39의 생성자이고, 39는 51의 생성자, 51은 57의 생성자이다. 
         *      생성자가 한 개보다 많은 경우도 있다. 예를 들어, 101은 생성자가 2개(91과 100) 있다. 
         *      
         *      생성자가 없는 숫자를 셀프 넘버라고 한다. 100보다 작은 셀프 넘버는 총 13개가 있다. 
         *      1, 3, 5, 7, 9, 20, 31, 42, 53, 64, 75, 86, 97
         *      
         *      10000보다 작거나 같은 셀프 넘버를 한 줄에 하나씩 출력하는 프로그램을 작성하시오.
         * 입력 : 
         *      입력은 없다.
         * 출력 : 
         *      10,000보다 작거나 같은 셀프 넘버를 한 줄에 하나씩 증가하는 순서로 출력한다.
         */
        int d(int n)
        {
            return n.ToString().Sum(x => int.Parse(x.ToString())) + n;
        }
        public void Q4673()
        {
            List<int> list = new List<int>(Enumerable.Range(1, 10000));
            int i = 0;
            while (i < 10000) list.Remove(d(i++));
            Console.WriteLine(string.Join("\n", list));   
        }

        /*
         * baekjoon 1065 - 한수
         * 문제 : 
         *      어떤 양의 정수 X의 각 자리가 등차수열을 이룬다면, 그 수를 한수라고 한다. 
         *      등차수열은 연속된 두 개의 수의 차이가 일정한 수열을 말한다. 
         *      N이 주어졌을 때, 1보다 크거나 같고, N보다 작거나 같은 한수의 개수를 출력하는 프로그램을 작성하시오. 
         * 입력 : 
         *      첫째 줄에 1,000보다 작거나 같은 자연수 N이 주어진다.
         * 출력 : 
         *      첫째 줄에 1보다 크거나 같고, N보다 작거나 같은 한수의 개수를 출력한다.
         */
        public bool getNum(string num)
        {
            if (int.Parse(num) < 100) return true;
            if (num[0] - num[1] == num[1] - num[2]) return true;

            return false;
        }
        public void Q1065()
        {
            int N = int.Parse(Console.ReadLine());
            int i = 1;
            int count = 0;
            
            while (i <= N)
            {
                if (getNum(i++.ToString())) count++;
            }
            Console.WriteLine(count);
        }
    }
}