using System;

namespace ExceptionHandling2
{
    class Nullreferenceexceptiondemo
    {
        static void Main(string[] args)
        {
            string str = null;
            try
            {
                Console.WriteLine(str.Substring(5));
            }
            catch (NullReferenceException err)
            {
                Console.WriteLine("Please check the string str.");
                Console.WriteLine(err.Message);
            }
            Console.WriteLine("Continuing with other statments..");
        }
    }
}
