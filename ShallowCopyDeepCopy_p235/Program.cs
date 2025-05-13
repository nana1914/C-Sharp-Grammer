using System;

// 얕은 복사 (Shallow Copy)
// 객체를 복사할 때 참조만 살짝 복사하는 것

// 깊은 복사 (Deep Copy)
// 객체1이 힙에 보관되어 있는 내용을 객체2로부터 복사해서 받아 별도의
// 힙 공간에 객체를 보관하는 것

namespace ShallowCopyDeepCopy
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = MyField1;
            newCopy.MyField2 = MyField2;

            return newCopy;
        }
    }
    
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = new MyClass();
                target = source;
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1}   {source.MyField2}");
                Console.WriteLine($"{target.MyField1}   {target.MyField2}");
            }


            Console.WriteLine("Deep Copy");
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source.DeepCopy();
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1}   {source.MyField2}");
                Console.WriteLine($"{target.MyField1}   {target.MyField2}");
            }
        }
    }
}