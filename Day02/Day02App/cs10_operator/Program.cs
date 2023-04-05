using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs10_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비트연산 : 더 작은 단위로 가공해야 할 경우
            // << : 왼쪽 시프트 연산자(왼쪽으로 이동)
            // >> : 오른쪽 시프트 연산자(오른쪽으로 이동)
            // & : 논리곱(AND) 연산자
            // ! : 논리합(OR) 연산자
            // ^ : 배타적 논리합(XOR) 연산자
            // ~ : 보쉬(NOT) 연산자

            int firstval = 1;          // 15
            int secondval = firstval << 1;  // 11110 16+8+4+2 = 30
            Console.WriteLine(secondval);

            // 1111 & 1101 => 1101
            // 1010 | 0101 => 1111
            firstval = 15;
            secondval = 13;
            Console.WriteLine(firstval & secondval);
            firstval = 10;
            secondval = 5;
            Console.WriteLine(firstval | secondval);
            Console.WriteLine(firstval ^ secondval);    // XOR
            Console.WriteLine(~secondval);              // 보수

            // Null 병합 연산자
            int? checkval = null;
            Console.WriteLine(checkval == null ? 0 : checkval); // 3항 연산자
            Console.WriteLine(checkval ?? 0);                   // null 병합연산자는 3항연산자를 더 축소

            checkval = 25;
            Console.WriteLine(checkval == null ? 0 : checkval);
            Console.WriteLine(checkval ?? 0);
        }
    }
}
