using System;

// C#의 복합 데이터 형식 : 클래스, 구조체 있음
// 클래스는 참조 형식, 구조체는 값 형식

// 구조체의 인스턴스는 스택에 할당되고 인스턴스의 사용이 끝나면 즉시 메모리에서
// 제거된다는 점과 가비지 콜렉터를 덜 귀찮게 한다는 점에서
// 구조체는 클래스에 비해 성능의 이점을 가짐.

namespace Structure
{
    
    // 구조체 안에서 생성자와 메서드 정의 가능
    // 생성자는 반드시 모든 필드를 초기화해야 함
    // 기본 생성자는 사용자 정의 불가
    struct Point3D
    {
        public int X;
        public int Y;
        public int Z;

        // C# 구조체의 기본 생성자를 직접 정의할 수 없음
        public Point3D(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        // System.Object.ToString() 메소드를 오버라이딩
        public override string ToString()
        {
            return string.Format($"{X}   {Y}  {Z}");
        }
    }
    
    class MainApp
    {
        static void Main(string[] args)
        {
            Point3D p3d1;   // 구조체는 선언만으로 인스턴스가 생성됨
            p3d1.X = 10;
            p3d1.Y = 20;
            p3d1.Z = 40;

            Console.WriteLine(p3d1.ToString());

            // 생성자를 이용한 인스턴스 생성도 가능함
            Point3D p3d2 = new Point3D(100, 200, 300);
            Point3D p3d3 = p3d2;    // 구조체의 인스턴스를 다른 인스턴스에 할당 : 깊은 복사  (클래스는 얕은 복사)
            p3d3.Z = 400;

            Console.WriteLine(p3d2.ToString());
            Console.WriteLine(p3d3.ToString());
        }
    }
}

// string.Format()
// C#에서 문자열에 값을 삽입하거나 형식 지정자와 함께 문자열을 조합할 때 사용하는 메소드.