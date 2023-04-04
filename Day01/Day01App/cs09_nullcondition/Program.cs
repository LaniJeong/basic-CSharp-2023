using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs09_nullcondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foo my_foo = null;  // new Foo();  객체(instance) 생성
            // myfoo.member = 30;

            //int? bar;
            //if (my_foo != null)
            //{
            //    bar = my_foo.member;
            //}
            //else
            //{
            //    bar = null;
            //}
            // 위의 아홉줄(주석)모두 축약
            int? bar = my_foo?.member;
        }
    }

    class Foo
    {
        public int member;
    }
}
