using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    public class Cat
    {
        public string? Name;
        public string? Color;

        public void Meow()
        {
            Console.WriteLine($"{this.Name} : 야옹");
        }
    }
}

