using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cs12_methods
{
    class Calc
    {
        public static int Plus (int a, int b)
        { 
            return a + b;
        }
        public static int Minus (int a, int b)
        {
            return a - b;
        }
    }
    internal class Program
    {
        /// <summary>
        /// 실행시 메모리에 최초 올라가야 하기때문에 static이 되어야 하고
        /// 메서드 이름이 Main 이면 실행될 때 알아서 제일 처음에 시작된다.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region < static 메서드 >

            int result = Calc.Plus (1, 2);
            // static은 최초 실행때 바로 올라가기 때문에
            // 클래스를 객체를 만들 필요가 없음 like new Calc();
            //Calc.Minus(3, 2);   // minus는 static이 아니기 때문에 접근 불가(객체생성해야 접근 가능)
            result = new Calc().Minus(3, 2);
            Console.WriteLine (result);
            #endregion

            #region < Call by reference vs Call by value 비교 >

            int x = 5; int y = 4;
            Swap(ref 5, ref 4);     // x, y가 가지고 있는 주소를 전달하라 Call by reference == pointer
            Console.WriteLine ("x = {0}, y = {1}",x ,y);

            #endregion

            #region < out 매개변수 >

            int divid = 10;
            int divor = 3;

            int rem = 0;
            Divide(divid, divor, out result, out rem);      // ref 나 out이나 상관없음
            Console.WriteLine("나누기값 {0}, 나머지{1}", result, rem);
            //result = Divide(divid, divor);
            //Console.WriteLine (result);

            (result, rem) = Divide(10, 6);
            Console.WriteLine("나누기값 {0}, 나머지{1}", result, out);

            #endregion

            #region < 가변길이 매개변수 >

            int resSum = Sum(1, 3, 5, 7, 9);
            Console.WriteLine(resSum);

            #endregion
        }

        //static int Divide(int x, int y)
        //{
        //    return x / y;
        //}
        //static int Reminder(int x, int y)
        //{
        //    return x % y;
        //}

        //static void Divide(int x, int y, ref int val, ref int rem)
        static void Divide(int x, int y, out int val, out int rem)
        {
            val = x / y;
            rem = x % y;
        }

        static (int result, int rem) Divide(int x, int y)
        {
            return (x / y, x % y);
        }
        static (float result, float rem) Divide(float x, float y)
        {
            return (x / y, x % y);
        }

            // Main메서드와 같은 레벨에 있는 메서드들은 전부 static이 되어야 함(무조건!)
            public static void Swap(int a, int b)
        {
            int temp = 0;
            temp = a;       // 5 : temp = 5
            a = b;          // a = 4
            b = temp;       // 5
        }

        static int val = 100;

        public static ref int GetNumber()
        {
            return ref val;
        }
        public static int Sum(params int[] args)
        {
            int sum = 0;

            foreach(var item in args)
            {
                sum += item;
            }
            return sum;
        }
    }

}
