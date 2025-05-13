using System;

// 추상 클래스 : abstract 한정자
// 완전하지 않은 클래스로, 직접 인스턴스를 만들 수 없고, 주로 공통 기능을 정의하면서
// 자식 클래스에 특정 기능 구현을 강제할 때 사용됨

// abstract 키워드로 선언
// 인스턴스화 불가능
// 추상 메소드를 가질 수 있음 (구현 없이 선언만 하는 메소드)
// 일반 메소드나 필드도 포함 가능 (공통 구현 포함)

// 추상 클래스는 일반 클래스가 가질 수 있는 구현과 추상 메소드를 가지고 있음
// 추상 메소드가 없는 추상 클래스도 문법적으로 하자가 있는 것은 아니지만
// 실질적으로 별 의미가 없는 코드임
// 추상 메소드는 추상 클래스를 사용하는 프로그래머가 그 기능을 정의하도록 강제하는 장치

namespace AbstractClass
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }

        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethod()");
        }

        public abstract void AbstractMethodA();
    }
    
    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstractMethodA()");
            PrivateMethodA();
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
        }
    }
}

// 추상 클래스 사용 이유?
// 1) 공통된 기능은 상위 클래스에서 구현하고
// 2) 각 자식 클래스만의 다른 동작은 강제로 구현하도록 하여
// 3) 일관성 있고 재사용성 높은 코드를 만들 수 있기 때문