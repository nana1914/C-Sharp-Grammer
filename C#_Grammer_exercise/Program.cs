using System;

// 어떤 요소 타입도 받아들일 수 있는
// 스택 클래스를 C# 제너릭을 이용하여 정의

class MyStack<T>
{
    T[] elements_;
    int pos = 0;

    public MyStack()
    {
        elements_ = new T[100];
    }

    public void Push(T element)
    {
        elements_[++pos] = element;
    }

    public T Pop()
    {
        return elements_[pos--];
    }

    public bool IsEmpty()
    {
        return pos == 0;
    }
}


class Program
{
    static void Main(string[] args)
    {
        MyStack<int> numberStack = new MyStack<int>();
        MyStack<string> nameStack = new MyStack<string>();

        int num_ = 0;
        List<string> names_ = new List<string>();
        names_.Add("김나은");
        names_.Add("이정석");
        names_.Add("김혜경");
        names_.Add("김종길");


        foreach (string name in names_)
        {
            numberStack.Push(num_++);
            nameStack.Push(name);
        }

        Console.WriteLine("스택에서 꺼낸 결과 ");
        while(!numberStack.IsEmpty())
        {
            int number = numberStack.Pop();
            string name = nameStack.Pop();
            Console.WriteLine($"이름 : {name}, 번호 : {number}");
        }
    }
}