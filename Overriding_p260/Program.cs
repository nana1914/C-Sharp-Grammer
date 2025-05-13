using System;

// 다형성 (Polymorphism)
// (객체지향 프로그래밍에서) 객체가 여러 형태를 가질 수 있음을 의미.
// 자신으로부터 상속받아 만들어진 파생 클래스를 통해 다형성을 실현

// 오버라이딩 (Overriding)
// 부모 클래스에서 정의한 메서드를 자식 클래스에서 재정의하는 것
// 다형성의 개념 중 하나

// 메소드 오버라이딩 조건
// 1) 오버라이딩을 할 메소드가 virtual 키워드로 한정되어 있어야 함
// 2) 오버라이딩을 하는 측에서는 기반 클래스에 선언되어 있던 메소드를 재정의하고
//    있음을 컴파일러에 알려야 하므로 override로 한정해줘야 함

namespace Overriding
{
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Launcher Armed");
        }
    }
    
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating ArmorSuite...");
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initialize();

            Console.WriteLine("\nCreating IronMan...");
            ArmorSuite ironman = new IronMan();
            ironman.Initialize();

            Console.WriteLine("\nCreating WarMachine...");
            ArmorSuite warmachine = new WarMachine();
            warmachine.Initialize();
        }
    }
}

// base 키워드
// "기반 클래스"를 가리킴
// base 키워드를 통해 기반 클래스의 멤버에 접근할 수 있음