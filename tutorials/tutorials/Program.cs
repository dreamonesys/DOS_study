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
            Console.Write("반복 횟수를 입력하세요 : ");
            var readText = Console.ReadLine();

            if (string.IsNullOrEmpty(readText))
            {
                Console.WriteLine("빈 값을 입력할 순 없습니다.");
                return;
            }

            var count = Int32.Parse(readText);
            if (count < 0)
            {
                Console.WriteLine("0 보다 작거나 같은 수를 입력할 수 없습니다.");
                return;
            }
            else
            {
                int a = 1;
                while (a <= count)
                {
                    Console.Write(new string('*', a));
                    Console.WriteLine();
                    a++;
                }
            }
        }
    }
}
