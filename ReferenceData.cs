using System;
namespace ValueTypeTest
{

    class ReferenceData
    {

        // Main Function
        static void Main()
        {

            string a = "Reference";

            a += "Data";
            a = a + "Type";
            Console.WriteLine(a);

            object obj;
            obj = 30;
            Console.WriteLine(obj);


            Console.WriteLine(obj.GetType());
        }
    }
}

