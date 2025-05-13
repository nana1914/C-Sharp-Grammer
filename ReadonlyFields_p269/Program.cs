using System;

// 읽기 전용 필드 : readonly 키워드
// 읽기만 가능한 필드
// 즉, 클래스나 구조체의 멤버로만 존재할 수 있으며, 생성자 안에서 한 번 값을 지정하면
// 그 후로는 값을 변경할 수 없는 것

namespace ReadonlyFields
{
    class Car
    {
        public readonly string Brand;
        public readonly int Year;

        // 읽기 전용 필드는 생성자 안에서만 초기화 가능함
        public Car(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"브랜드: {Brand}, 출시년도: {Year}");
        }
    }
    
    class MainApp
    {
        static void Main(string[] args)
        {
            Car car = new Car("Hyundai", 2021);
            car.ShowInfo();
        }
    }
}