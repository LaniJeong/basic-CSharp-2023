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
            Foo my_foo = null;  // 객체(instance) 생성

            int? bar;
            if (my_foo != null)
            {
                bar = my_foo.member;
            }
        }
    }

    class Foo
    {
        public int member;
    }
}
