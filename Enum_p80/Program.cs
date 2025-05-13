using System;

namespace Enum
{
    class MainApp
    {
        // C#에서 enum, class, struct, interface 등 타입 정의는 클래스, 구조체, 네임스페이스의 멤버로만 허용
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }

        static void Main(string[] args)
        {
            DialogResult result = DialogResult.OK;

            Console.WriteLine(result == DialogResult.YES);
            Console.WriteLine(result == DialogResult.NO);
            Console.WriteLine(result == DialogResult.CANCEL);
            Console.WriteLine(result == DialogResult.CONFIRM);
            Console.WriteLine(result == DialogResult.OK);

            Console.WriteLine();

            Console.WriteLine($"(int)DialogResult.YES : {(int)DialogResult.YES}");
            Console.WriteLine($"(int)DialogResult.NO :  {(int)DialogResult.NO}");
            Console.WriteLine($"(int)DialogResult.CANCEL :  {(int)DialogResult.CANCEL}");
            Console.WriteLine($"(int)DialogResult.CONFIRM :  {(int)DialogResult.CONFIRM}");
            Console.WriteLine($"(int)DialogResult.OK :  {(int)DialogResult.OK}");

        }
    }

}