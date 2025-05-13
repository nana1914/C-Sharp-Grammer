using System;

// ref 키워드
// C#에서 값을 참조로 전달할 때 사용하는 키워드.
// 단, 전달 인수가 반드시 초기화 되어서 전달되어야 함.

// 기본적으로 C#에서는 메서드에 인수를 전달하면 값 복사 (pass-by-value)가 일어남.
// ref 를 사용하면 값이 아닌 변수의 참조(주소)를 전달할 수 있다.
// 즉, 메서드 안에서 값을 바꾸면 호출한 쪽 변수에도 영향을 준다.



namespace RefReturn
{
    class Product
    {
        private int _price = 100;       // 초기화

        public ref int GetPrice()
        {
            return ref _price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price : {_price}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Product carrot = new Product();
            
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"Normal Local Price : {normal_local_price}");

            ref_local_price = 200;

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"Normal Local Price : {normal_local_price}");
        }
    }

}