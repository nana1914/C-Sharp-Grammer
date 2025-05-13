using System;

namespace UsingVar
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = 20;         // var로 선언하는 변수는 반드시 초기화해야 함. var는 지역 변수로만 사용할 수 있음
            Console.WriteLine($"Type: {a.GetType()}, Value: {a}");

            var b = 3.1414213;
            Console.WriteLine($"Type: {b.GetType()}, Value: {b}");

            var c = "Hello, World!";
            Console.WriteLine($"Type: {c.GetType()}, Value: {c}");

            var d = new int[] { 10, 20, 30 };
            Console.Write($"Type: {d.GetType()}, Value: ");
            foreach (var i in d)
                Console.Write($"{i} ");

            Console.WriteLine();
        }
    }

}