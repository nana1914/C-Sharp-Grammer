using System;

// 출력 전용 매개변수 : out 키워드
// 메서드에서 값을 "반드시 할당해서 돌려줄 목적"으로 사용.
// 호출하는 쪽에서는 초기화할 필요 없음
// 메서드 안에서는 반드시 값 할당이 필요함.

// 단, 전달 인수가 초기화되지 않아도 참조 전달이 됨
// 매개변수를 넘길 때는 메소드가 해당 매개변수에 결과를 저장하지 않으면 컴파일러가 에러 메시지 출력
// 따라서 컴파일러가 호출당하는 메소드에서 그 지역 변수를 할당할 것을 보장하기 때문에 ref 키워드보다 더 안전한 방법임.

namespace UsingOut
{
    class MainApp
    {
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
        
        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;

            Divide(a, b, out int c, out int d);

            Console.WriteLine($"a: {a}, b: {b}, a / b: {c}, a % b: {d}");
        }
    }

}