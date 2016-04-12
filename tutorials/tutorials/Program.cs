using System;
using System.Text;

namespace tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================================================");
            Console.WriteLine("This is chapter03 branch.");
            Console.WriteLine("You can find full source code at https://github.com/dreamonesys/DOS_study/.");
            Console.WriteLine("===========================================================================");
            Console.WriteLine("");

            ChapterExamples examples = new ChapterExamples();

            string response = "Y";

            // 사용자가 샘플 실행 여부를 묻는 질문에 "Y" 입력시 다시 샘플 목록을 표시한다.
            do
            {
                // 샘플 목록을 표시한다.
                examples.showExample();
                // 사용자로부터 번호를 입력받아 샘플을 실행한다.
                examples.executeSample();

                // 다시 샘플을 실행할지 물어본다.
                Console.WriteLine("다시 샘플을 실행하시겠습니까? (Y/N)");
                response = Console.ReadLine();

            } while (response == "Y");

        }
    }

    class ChapterExamples
    {
        /// <summary>
        /// 샘플 목록을 표시한다.
        /// </summary>
        public void showExample()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. 2의 보수법(2's Complement)에 대해 알아본다.");
            sb.AppendLine("2. 오버플로우(Overflow) 에 대해 알아본다.");
            sb.AppendLine("3. 부동 소수점 형식(Float Pointing Types)과 Decimal 형식의 차이점에 대해 알아본다.");
            sb.AppendLine("4. char 형식의 문자 데이터 출력에 대해 알아본다.");
            sb.AppendLine("5. string 형식에 대해 알아본다.");
            sb.AppendLine("6. 논리(Boolean Type)에 대해 알아본다.");
            sb.AppendLine("7. Object Type 에 대해 알아본다.");
            sb.AppendLine("8. boxing 과 unboxing 에 대해 알아본다.");
            sb.AppendLine("9. 형식 변환(Type Conversion)에 대해 알아본다.");

            // 선택 메뉴를 표시한다.
            Console.WriteLine(sb.ToString());

            // 사용자로부터 번호를 입력받는다.
            Console.WriteLine("번호를 입력하세요.");
        }

        /// <summary>
        /// 샘플을 실행한다.
        /// </summary>
        public void executeSample()
        {

            string line = Console.ReadLine();
            int num = 0;

            if (int.TryParse(line, out num))
            {
                // 0 을 입력할 경우 1번 샘플을 실행한다.
                num = (num == 0) ? 1 : num;

                switch (num)
                {
                    case 1:
                        this.sample1();
                        break;
                    case 2:
                        this.sample2();
                        break;
                    case 3:
                        this.sample3();
                        break;
                    case 4:
                        this.sample4();
                        break;
                    case 5:
                        this.sample5();
                        break;
                    case 6:
                        this.sample6();
                        break;
                    case 7:
                        this.sample7();
                        break;
                    case 8:
                        this.sample8();
                        break;
                    case 9:
                        this.sample9();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("숫자를 입력하세요!");
            }
        }

        /// <summary>
        /// 예제1. 2의 보수법에 대해 알아본다.
        /// </summary>
        public void sample1 ()
        {
            byte a = 255;
            sbyte b = (sbyte)a;

            Console.WriteLine(a); // 255
            Console.WriteLine(b); // -1 (2의 보수법)
        }

        /// <summary>
        /// 예제2. 오버플로우(Overflow) 에 대해 알아본다.
        /// </summary>
        public void sample2()
        {
            uint a = uint.MaxValue; // 4,294,967,295 (4bytes, 약 42억개의 수 표현가능)

            Console.WriteLine(a);

            a += 1;

            Console.WriteLine(a); // 0
        }

        /// <summary>
        /// 예제3. 부동 소수점 형식(Float Pointing Types)과 Decimal 형식의 차이점에 대해 알아본다.
        /// </summary>
        public void sample3()
        {
            float a = 3.14159265358979323846f; // float 형식 변수에 값을 직접 할당하려면, 숫자 뒤에 f 를 붙여준다.
            Console.WriteLine(a); // 3.141594

            double b = 3.14159265358979323846;
            Console.WriteLine(b); // 3.14159265358979

            decimal c = 3.141592653589793238462643383279m;
            Console.WriteLine(c); // 3.1415926535897932384626433833
        }

        /// <summary>
        /// 예제4. char 형식의 문자 데이터 출력에 대해 알아본다.
        /// </summary>
        public void sample4()
        {
            char a = '안'; // " 를 사용할 경우 Cannot implicitly convert type 'string' to 'char' 오류 발생
            char b = '녕';
            char c = '하';
            char d = '세';
            char e = '요';

            Console.Write(a); // Write : 출력 후 줄바꿈 없음.
            Console.Write(b);
            Console.Write(c);
            Console.Write(d);
            Console.Write(e);
            Console.WriteLine();
        }

        /// <summary>
        /// 예제 5. string 형식에 대해 알아본다.
        /// </summary>
        public void sample5()
        {
            string a = "Hello"; // ' 를 사용할 경우, Too many charaters in character literal 오류 발생.
            string b = "Dreamonesys!";
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        /// <summary>
        /// 예제 6. 논리(Boolean Type)에 대해 알아본다.
        /// </summary>
        public void sample6()
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        /// <summary>
        /// 예제 7. Object Type 에 대해 알아본다.
        /// </summary>
        public void sample7()
        {
            object a = 123; // Integer
            object b = 3.141592653589793238462643383279m; // Decimal
            object c = true; // Boolean
            object d = "안녕하세요."; //string

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }

        /// <summary>
        /// 예제 8. boxing 과 unboxing 에 대해 알아본다.
        /// </summary>
        public void sample8()
        {
            int a = 123;
            object b = (object)a; // a에 담긴 값을 박싱하여 힙에 저장한다.
            int c = (int)b; // b에 담긴 값을 언박싱해서 스택에 저장한다.

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            double x = 3.1414213;
            double y = x; // x에 담긴 값을 박싱해서 힙에 저장한다.(형식 변환 연산자 => (object) 를 지정하지 않으면, 암시적으로 object 형식으로 변환)
            double z = (double)y; // y에 담긴 값을 언박싱해서 스택에 저장한다.

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }

        /// <summary>
        /// 예제 9. 형식 변환(Type Conversion)에 대해 알아본다.
        /// </summary>
        public void sample9()
        {
            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int x = 128; // sbyte 의 최대값 127 보다 1 큰수
            Console.WriteLine(x);

            sbyte y = (sbyte)x; // 오버플로우 발생
            Console.WriteLine(y); // -128
        }
    }
}
