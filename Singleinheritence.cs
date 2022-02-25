using System;
namespace Singleinheritence
{
    public class Parent
    {
        public void DisplayParentsAB()
        {
            Console.WriteLine("A and B are my parents");
        }
    }

    public class Son : Parent
    {
        public void DisplaySonC()
        {
            Console.WriteLine("I am the son C");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Son s = new Son();
            s.DisplaySonC();
            s.DisplayParentsAB();
        }
    }
}