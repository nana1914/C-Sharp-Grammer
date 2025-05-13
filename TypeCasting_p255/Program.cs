using System;

namespace TypeCasting
{
    // C# 제공 형식 변환 연산자 : is, as
    
    // is 연산자
    // 객체가 해당 형식에 해당하는지 검사하여 그 결과를 bool 값으로 반환.
    
    // as 연산자
    // 형식 변환 연산자와 같은 역할 수행
    // 다만 형식 변환 연산자가 변화에 실패하는 경우, 예외를 던지는 반면
    // as 연산자는 객체 참조를 null로 만든다는 것이 다름.
    // 형식 변환 대신 as 연산자를 사용하는 쪽을 권장..
    // 형식 변환에 실패하더라도 예외가 일어나 갑자기 코드의 실행이 점프하는
    // 일이 없으므로 코드를 관리하기 더욱 수월함

    // 형식 변환 연산자
    // 암시적 변환, 명시적 변환

    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            // is 연산자 이용
            Mammal mammal = new Dog();      // 부모 타입 변수에 자식 객체를 담음 (업캐스팅)
            Dog dog;

            if (mammal is Dog)
            {
                dog = (Dog)mammal;  // 형변환 (다운캐스팅)
                dog.Bark();
            }

            // as 연산자 이용
            Mammal mammal2 = new Cat();     // 부모 타입 변수에 자식 객체를 담음 (업캐스팅)
            Cat cat = mammal2 as Cat;       // 형변환 (다운캐스팅)

            if (cat != null)
            {
                cat.Meow();
            }

            Cat cat2 = mammal as Cat;
            if (cat2 != null)
            {
                cat2.Meow();
            }
            else
            {
                Console.WriteLine("cat2 is not a Cat");
            }
        }
    }
}

// 번외
// <<업캐스팅 사용하는 이유>
// 목적 : 공통 인터페이스로 처리하기 위해
// 다양한 자식 객체들을 부모 타입 하나로 다루기 위해..
// 이점 : 코드 확장성 좋음, 자식이 늘어나도 부모 타입으로 처리 가능, 일관성 유지

// <다운캐스팅 사용하는 이유>
// 목적 : 자식 클래스 고유 기능을 쓰고 싶을 때
// (부모 타입에는 없는 Bark() 같은 기능은 자식으로 되돌려야 사용 가능함)


// 정리
// 업캐스팅 : 모든 동물을 "동물"이라고 부르는 것..
// 사용 이유 : 다양한 자식들을 하나의 타입으로 다루기 위해
// 장점 : 공통 인터페이스 활용

// 다운캐스팅 : 그 동물이 개였다는 걸 알고, 개 전용 기능을 쓰는 것
// 사용 이유 : 자식 고유 기능을 쓰기 위해
// 장점 : 기능 확장 가능