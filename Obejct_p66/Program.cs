using System;

// object 형식 : 어떤 데이터이든지 다룰 수 있는 데이터 형식
// C#은 object가 모든 데이터를 다룰 수 있도록 모든 데이터 혀ㅇ식이 자동으로 object 형식으로부터 상속받게 함
// 어떤 형식의 데이터라도 object에 담아 처리할 수 있음

namespace Object
{
    class MainApp
    {

        static void Main(string[] args)
        {
            PrintValue(22);                 // int->boxing O
            PrintValue("Hello, World!");    // reference type -> boxing X
            PrintValue(3.14);               // double -> boxing O
        }

        // 다양한 타입을 하나의 메소드에서 받을 수 있음!
        static void PrintValue (object obj)
        {
            Console.WriteLine($"Value: {obj}");
        }
    }
}