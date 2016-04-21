using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            // Formatting
            // 정수를 10진수로 출력하기
            int a = 3;
            Console.WriteLine ("{0:D5}", a); // 출력 결과 00003
            // 정수를 16진수로 출력하기
            int b = 255;
            Console.WriteLine("{0:X8}", b); // 000000FF

            // 비트 논리 연산 - 논리곱(AND) 연산자
            int result = 9 & 10;
            Console.WriteLine(result);

            // 비트 논리 연산 - 보수(NOT) 연산자
            int c = 255;

            //0x 는 16진수를 나타내는 prefix 이다.
            //X는 16진수 8은 자릿수
            Console.WriteLine("~{0}(0x{0:X8}) : {1}(0x{1:X8})", c, -c);
        }
    }

}
