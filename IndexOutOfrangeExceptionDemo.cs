using System;

namespace Exceptionhandling
{
    public class IndexOutOfrangeExceptionDemo
    {
        static void Main(string[] args)
        {
            int[] arr = { 19, 0, 75, 52 };

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[7]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(" {0}", arr[i]);
                }
            }


        }
    }
}
