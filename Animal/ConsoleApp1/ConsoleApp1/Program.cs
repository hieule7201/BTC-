using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Animal {
        public void eat() { }
        public void makeSound() { }    }
    class Cat : Animal
    {
        public void run() { }
    }
    class Bird : Animal {
        public void fly() { }
    }
}
