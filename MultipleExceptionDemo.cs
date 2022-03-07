using System;

namespace ExceptionHandlingDemo
{
    class MultipleExceptionDemo
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("ENTER ANY TWO NUBERS");
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("C VALUE = " + c);
            }
            catch (DivideByZeroException dbe)
            {
                Console.WriteLine("2nd number should not be zero");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("enter only integer number");
            }
            finally
            {
                Console.WriteLine("hello this is finally block");
            }
            Console.ReadKey();
        }
    }
}