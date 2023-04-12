using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs27_deligatechain
{
    delegate void ThereIsAFire(string location);  // 불났을때 대신해주는 대리자

    delegate int Calc(int a, int b);              //

    delegate string Concatenate(string[] args);

    class Sample
    {
        #region < 람다식 >
        private int valueA;      // 멤버변수 - 외부접근 불가

        //public int ValueA
        //{
        //    //get { return valueA; }
        //    //set { valueA = value; }
        //    get => valueA;
        //    set => valueA = value;
        //}

        public int ValueA
        {
            get => valueA;  // 람다식
            set
            {
                valueA = value;
            }
            { return valueA;}
        }

        #endregion
    }
    internal class Program
    {
        static void Call119(string location)
        {
            Console.WriteLine("소방서죠?");
        }

        static void ShoutOut(string location)
        {
            Console.WriteLine("{0}에 불났어요", location);
        }

        static void Escape(string location)
        {
            Console.WriteLine("{0}에서 탈출합니다.", location);
        }

        static string ProConcate(string[] args)
        {
            string result = string.Empty; // == "";
            foreach (string s in args)
            {
                result += s + "/";
            }

            return result;
        }

        static void Main(string[] args)
        {
            #region < 대리자 체인 >
            //    var loc = "우리집";
            //    Call119(loc);
            //    ShoutOut(loc);
            //    Escape(loc);

            //    var otherloc = "경찰서";
            //    ThereIsAFire fire = new ThereIsAFire(Call119);
            //    fire += new ThereIsAFire(ShoutOut);
            //    fire += new ThereIsAFire(Escape);

            //    fire(otherloc);

            //    fire -= new ThereIsAFire(ShoutOut);     // 대리자에서 메서드를 삭제

            //    fire("다른 집");

            //    // 익병함수
            //    Calc plus = delegate (int a, int b)
            //    {
            //        return a + b;
            //    };

            //    Console.WriteLine(plus(6, 7));

            //    Calc minus = (a, b) => { return a - b; };       // 람다 함수

            //    Console.Write(minus(67, 9));

            //    Calc simpleMinus = (a, b) => a - b;
            //}

            #endregion
            Concatenate concat = new Concatenate(ProConcate);
            var reslut = concat(args);

            Console.WriteLine(result);

            Concatenate concat2 = (arr) =>
            {
                string res = string.Empty; // == "";
                foreach (string s in args)
                {
                    res += s + "/";
                }

                return res;
            };
            Console.WriteLine(concat2(args));
        }
    }
}
