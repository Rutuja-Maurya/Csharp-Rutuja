using System;
namespace Operators
{

    class Relational
    {
        static void Main(string[] args)
        {
            bool result;
            int x = 5, y = 10;

            
            result = (x == y);
            Console.WriteLine("Equal to Operator: " + result);

            
            result = (x > y);
            Console.WriteLine("Greater than Operator: " + result);

            
            result = (x < y);
            Console.WriteLine("Less than Operator: " + result);

            
            result = (x >= y);
            Console.WriteLine("Greater than or Equal to: " + result);

            
            result = (x <= y);
            Console.WriteLine("Lesser than or Equal to: " + result);

            
            result = (x != y);
            Console.WriteLine("Not Equal to Operator: " + result);
        }
    }
}


