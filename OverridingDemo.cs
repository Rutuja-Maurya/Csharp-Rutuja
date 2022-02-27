using System;

namespace Overriding
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog: Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread..");
        }
    }
    class OverridingDemo
    {
        static void Main(string[] args)
        {
            Dog dg = new Dog();
            dg.eat();
        }
    }
}
