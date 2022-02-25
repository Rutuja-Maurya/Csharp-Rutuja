using System;

namespace ArrayFunctions
{
    public class ArrayDemo
    {
        static void Main(string[] args)
        {
            // Creating an array 
            int[] arr = new int[6] { 5, 8, 9, 25, 0, 7 };
            int[] arr2 = new int[6];

            //Displaying length of array
            Console.WriteLine("length of first array: " + arr.Length);

            // Finding index of an array element  
            Console.WriteLine("\nIndex position of 25 is " + Array.IndexOf(arr, 25));

            // Sorting array  
            Array.Sort(arr);
            foreach (int value in arr)
            {
                Console.WriteLine(value);

            }
            //Reverseing array
            Array.Reverse(arr);
            foreach (int value in arr)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();

        }
    }
}
