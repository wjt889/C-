using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    abstract class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }
        public string Name { get; set;}

        public abstract void Shout();
    }

    class Dog:Animal
    {
        public Dog(string name) : base(name) { }

        public override void Shout()
        {
            Console.WriteLine("{0}:汪汪",base.Name);
             
        }

    }
      
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
