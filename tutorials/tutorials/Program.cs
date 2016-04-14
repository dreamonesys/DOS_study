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

            // 사용자가 샘플 실행 여부를 묻는 질문에 "Y(y)" 입력시 다시 샘플 목록을 표시한다.
            do
            {
                // 샘플 목록을 표시한다.
                examples.showExample();
                // 사용자로부터 번호를 입력받아 샘플을 실행한다.
                examples.executeSample();

                // 다시 샘플을 실행할지 물어본다.
                Console.WriteLine("다시 샘플을 실행하시겠습니까? (Y/N)");
                response = Console.ReadLine().ToLower();

            } while (response == "y");

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
            sb.AppendLine("9. 형식 사이의 변환(Type Conversion)에 대해 알아본다.");
            sb.AppendLine("10. 상수(Constants)에 대해 알아본다.");
            sb.AppendLine("11. 열거형식(Enumerator)에 대해 알아본다.");
            sb.AppendLine("12. Nullable 형식에 대해 알아본다.");
            sb.AppendLine("13. 암시적 형식, var 에 대해 알아본다.");
            sb.AppendLine("14. 공용형식시스템(CTS, Common Type System)에 대해 알아본다.");
            sb.AppendLine("15. 연습문제");

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

            Console.WriteLine("=============================================");

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
                    case 10:
                        this.sample10();
                        break;
                    case 11:
                        this.sample11();
                        break;
                    case 12:
                        this.sample12();
                        break;
                    case 13:
                        this.sample13();
                        break;
                    case 14:
                        this.sample14();
                        break;
                    case 15:
                        this.sample15();
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
        /// 예제 9. 크기가 서로 다른 형식사이의 변환(Type Conversion)에 대해 알아본다.
        /// </summary>
        public void sample9()
        {
            // 크기가 서로 다른 정수 형식사이의 변환
            Console.WriteLine("크기가 서로 다른 정수 형식사이의 변환");

            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int x = 128; // sbyte 의 최대값 127 보다 1 큰수
            Console.WriteLine(x);

            sbyte y = (sbyte)x; // 오버플로우 발생
            Console.WriteLine(y); // -128

            // 크기가 서로 다른 부동 소수점 형식사이의 변환
            Console.WriteLine("=============================================");
            Console.WriteLine("크기가 서로 다른 부동 소수점 형식사이의 변환");

            float c = 69.6875f;
            Console.WriteLine("a(float) : {0}", a);

            double d = (double)c;
            Console.WriteLine("b(double) : {0}", d);
            Console.WriteLine("69.6875 == d : {0}", 69.6875 == d);

            float e = 0.1f;
            Console.WriteLine("x : {0}", x);

            double f = (double)e;
            Console.WriteLine("y : {0}", f);
            Console.WriteLine("0.1 == f : {0}", 0.1 == f);

            // 부호있는 정수형식과 부호없는 정수형식 사이의변환
            Console.WriteLine("=============================================");
            Console.WriteLine("부호있는 정수형식과 부호없는 정수형식 사이의 변환");

            int g = 500;
            uint h = (uint)g;
            Console.WriteLine("g(int) : {0}, h(uint) : {1}", g, h);

            int i = -30;
            uint j = (uint)i; // u : unsigned (부호 없는)
            Console.WriteLine("i(int) : {0}, j(uint) : {1}", i, j); // 언더플로우 발생.

            // 부동 소수점 형식과 정수 형식 사이의 변환
            Console.WriteLine("=============================================");
            Console.WriteLine("부동 소수점 형식과 정수 형식 사이의 변환");

            float k = 0.9f;
            int l = (int)a;
            Console.WriteLine("k(float) : {0}, l(int) : {1}", k, l);

            float m = 1.1f;
            int n = (int)m;
            Console.WriteLine("m(float) : {0}, n(int) : {1}", m, n);

            // 문자열을 숫자로, 숫자를 문자열로 변환
            Console.WriteLine("=============================================");
            Console.WriteLine("문자열을 숫자로, 숫자를 문자열로 변환");

            // int p = (int)o; => (int) 형식변환 연산자는 string 에 대해 언박싱이 불가. (string) 역시 마찬가지.
            // 정수 계열 및 부동 소수점 형식의 Parse() 메소드를 이용하면, int/float 으로 형변환 가능.
            int o = int.Parse("12345");
            float p = float.Parse("123.45");
            Console.WriteLine("m(float) : {0}, n(int) : {1}", m, n);

            // 정수 계열 및 부동 소수점 형식의 ToString() 메소드를 이용하면, string 으로 형변환 가능.
            int q = 12345;
            string r = q.ToString();
            Console.WriteLine("q(int) : {0}, r(string) : {1}", q, r);

            float s = 123.45f;
            string t = s.ToString();
            Console.WriteLine("s(float) : {0}, t(string) : {1}", s, t);
        }

        /// <summary>
        /// 예제 10. 상수(Constants)에 대해 알아본다.
        /// </summary>
        public void sample10()
        {
            const int MAX_INT = int.MaxValue;
            const int MIN_INT = int.MinValue;

            Console.WriteLine("MAX_INT : {0}, MIN_INT : {1}", MAX_INT, MIN_INT);
        }

        /// <summary>
        /// 예제 11. 열거형식(Enumerator)에 대해 알아본다.
        /// </summary>
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK };
        public void sample11()
        {
            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL );
            Console.WriteLine((int)DialogResult.CONFIRM );
            Console.WriteLine((int)DialogResult.OK );
        }

        /// <summary>
        /// 예제 12. Nullable 형식에 대해 알아본다.
        /// </summary>
        public void sample12()
        {
            int? a = null;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);

            a = 3;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a.Value);

            try
            {
                a = null;
                Console.WriteLine(a.Value); // InvalidOperationException 예외 발생.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                //Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 예제 13. 암시적 형식, var 에 대해 알아본다.
        /// </summary>
        public void sample13()
        {
            var a = 20; // var 키워드로 변수 선언시에는 반드시 초기화 필요.
            var b = 3.1414213;
            var c = "Hello, World!";
            var d = new int[] { 10, 20, 30 };

            Console.WriteLine("a => Type : {0}, Value : {1}", a.GetType(), a);
            Console.WriteLine("b => Type : {0}, Value : {1}", b.GetType(), b);
            Console.WriteLine("c => Type : {0}, Value : {1}", c.GetType(), c);
            Console.Write("d => Type : {0}, Value : {1}", d.GetType(), d);
            foreach (var item in d)
                Console.Write("{0} ", item);

            Console.WriteLine();
        }

        /// <summary>
        /// 예제 14. 공용형식시스템(CTS, Common Type System)에 대해 알아본다.
        /// </summary>
        public void sample14()
        {
            System.Int32 a = 123;
            int b = 456;

            Console.WriteLine("a type:{0}, value:{1}", a.GetType().ToString(), a);
            Console.WriteLine("b type:{0}, value:{1}", b.GetType().ToString(), b);

            System.String c = "abc";
            string d = "def";

            Console.WriteLine("c type:{0}, value:{1}", c.GetType().ToString(), c);
            Console.WriteLine("d type:{0}, value:{1}", d.GetType().ToString(), d);
        }

        /// <summary>
        /// 연습문제
        /// </summary>
        public void sample15()
        {
            // 1번
            Console.WriteLine("{0}, {1}, {2}, {3} 이 잘못되었다.", "int a = 7.3;", "float b = 3.14;", "char d \"abc\";", "string e = \'한\';");
            Console.WriteLine("int a = 7.3; => {0}", "double 에서 int 로 변경 불가. 해결책 : (int)");
            Console.WriteLine("float b = 3.14; => {0}", "double 고정값(literal) 을 암시적(implicitly) 형변환 불가. 해결책 : 3.14f");
            Console.WriteLine("char d \"abc\"; => {0}", "string 에서 char 로 암시적 형변환 불가. 해결책 : 1. a만 남겨놓고, \" => \'. 2. char => string 으로 변경");
            Console.WriteLine("string e = \'한\'; => {0}", "char 에서 string 로 암시적 형변환 불가. 해결책 : 1. string => char 2. \' => \"\"");

            // 2번
            Console.WriteLine("값 형식은 값을 담는 데이터 형식을 말한다.(스택에 값이 저장된다.)");
            Console.WriteLine("참조 형식은 값이 있는 곳의 위치(메모리주소)를 담는 데이터 형식이다.(힙에 값이 저장된다.)");
            Console.WriteLine();

            // 3번
            Console.WriteLine("박싱은, object 형식에 값형식의 데이터를 대입하는 경우 일어난다. (힙에 값이 저장된다.)");
            Console.WriteLine("언박싱은, 힙에 있는 값형식의 데이터를 값형식 객체에 다시 할당(형변환)하는 경우 일어난다. (스택에 값이 복사된다.)");
            Console.WriteLine();

            // 4번
            Console.WriteLine("사각형의 너비를 입력하세요.");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요.");
            string height = Console.ReadLine();

            int result = int.Parse(width) * int.Parse(height);
            Console.WriteLine("사각형의 넓이는 {0} 입니다.", result);

            // 5번
            var a = 2020; // int
            var b = "double"; // string
            Console.WriteLine("a 는 int 형식이고, b는 string 형식이다.");
        }
    }
}
