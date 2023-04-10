using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs20_abstractClass
{
    abstract class AbstractParent
    {
        protected void MethodA()
        {
            Console.WriteLine("AbstractParent.MethodA()");
        }
        public void MethodB()                   // 클래스와 동일
        {
            Console.WriteLine("AbstractParent.MethodB()");
        }
        public abstract void MethodC();         // 인터페이스와 기능은 동일! 추상메서드
    }

    class Child : AbstractParent    // 인터페이스 구현
    {
        public override void MethodC()          // 재정의(사실은 구현)
        {
            Console.Write("Child.MethodC() - 추상클래스 구현");
            MethodA();
        }
    }

    abstract class Mammal // 포유류 클래스 
    {
        public void Nurse()
        {
            Console.WriteLine("포유한다");
        }
        public abstract void Sound();
    }

    class Dogs : Mammal
    {
        public abstract void Sound()
        {
            Console.WriteLine("Bark!");
        }
    }

    class Cats : Mammal
    {
        public override void Sound()
        {
            Console.WriteLine("aeong");

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractParent parent = new Child();        // 부모클래스로 형변환해서 자식이 할당
            parent.MethodC();
            parent.MethodB();
            parent.MethodA();       // protected는 자기자신과 자식클래스 내에서만 쓸 수 있음
        }
    }
}
