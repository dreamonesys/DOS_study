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
            Console.WriteLine("This is chapter03 branch. you can find it at github.com.");

            ChapterExamples examples = new ChapterExamples();

            // 예제1 : 2의 보수법(2's Complement)에 대해 알아본다.
            //examples.sample1();
            // 예제2 : 오버플로우(Overflow) 에 대해 알아본다.
            examples.sample2();
        }
    }

    class ChapterExamples
    {
        /// <summary>
        /// 예제1 : 2의 보수법에 대해 알아본다.
        /// </summary>
        public void sample1 ()
        {
            byte a = 255;
            sbyte b = (sbyte)a;

            Console.WriteLine(a); // 출력값 : 255
            Console.WriteLine(b); // 출력값 : -1 (2의 보수법)
        }

        /// <summary>
        /// 예제2 : 오버플로우(Overflow) 에 대해 알아본다.
        /// </summary>
        public void sample2()
        {
            uint a = uint.MaxValue; // 4,294,967,295 (4bytes, 약 42억개의 수 표현가능)

            Console.WriteLine(a);

            a += 1;

            Console.WriteLine(a); // 출력값 : 0
        }
    }
}
