using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionhandling1
{
    public class DivideByZeroExceptionDemo
    {
        static void Main(string[] args)
        {
            int[] arr = { 19, 0, 75, 52 };

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("An Exception has occurred : {0}", ex.Message);
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