using System;
namespace Hierarchical
{
    public class Parent
    {
        public void DisplayParentsAB()
        {
            Console.WriteLine("A and B are my parents");
        }
    }

    public class ChildC : Parent
    {
        public void DisplayChildC()
        {
            Console.WriteLine("I am the child C");
        }
    }

    public class ChildD : Parent
    {
        public void DisplayChildD()
        {
            Console.WriteLine("I am the child D");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            ChildC cc = new ChildC();
            ChildD cd = new ChildD();

            cc.DisplayChildC();
            cc.DisplayParentsAB();  

            cd.DisplayChildD();
            cd.DisplayParentsAB();  
        }
    }
}