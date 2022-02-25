using System;
namespace Operators
{

    class Logical
    {
        static void Main(string[] args)
        {
            bool a = true, b = false, result;


            result = a && b;
            Console.WriteLine("AND Operator: " + result);


            result = a || b;
            Console.WriteLine("OR Operator: " + result);


            result = !a;
            Console.WriteLine("NOT Operator: " + result);

        }
    }
}



