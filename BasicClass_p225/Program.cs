using System;

namespace BasicClass 
{ 
    class MainApp
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.Name = "키티";
            kitty.Color = "하얀색";
            
            kitty.Meow();
            Console.WriteLine($"kitty.Name: {kitty.Name}, kitty.Color:{kitty.Color}");

            Cat nero = new Cat();
            nero.Name = "네로";
            nero.Color = "검은색";
            nero.Meow();
            Console.WriteLine($"nero.Name: {nero.Name}, nero.Color: {nero.Color}");
        }
    }
}