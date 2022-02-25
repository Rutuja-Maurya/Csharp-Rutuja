using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ArrayFunctions
{
    class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            //Add elements
            myList.Add("Aishwariya");
            myList.Add("Rutuja");
            myList.Add("Shruti");
            myList.Add("Mahesh");
            myList.Add("Pravita");
            myList.Add("Shreyas");

            // Displaying the elements in ArrayList
            Console.WriteLine("The initial ArrayList: ");

            foreach (string str in myList)
                Console.WriteLine(str);

            myList.Remove("Rutuja");

            // Displaying the elements in ArrayList 
            Console.WriteLine("The elements in ArrayList are :");

            foreach (string str in myList)
                Console.WriteLine(str);

            // Removing the element present at index 4
            myList.RemoveAt(4);

            // Displaying the elements in ArrayList
            Console.WriteLine("The elements in ArrayList are :");

            foreach (string str in myList)
                Console.WriteLine(str);
        }

    }
}
