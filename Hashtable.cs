using System;
using System.Collections;

namespace Demo
{
    class HashtableDemo
    {
        static void Main(string[] args)
        {
            Hashtable my_ht = new Hashtable();
            //Add
            my_ht.Add("SID", 101);
            my_ht.Add("Sname", "Rutuja");
            my_ht.Add("Sbranch", "CS");

            foreach (DictionaryEntry ele1 in my_ht)
            {
                Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
                
            }
            //ContainsKey
            Console.WriteLine(my_ht.ContainsKey("Sname"));
            //ContainsValue
            Console.WriteLine(my_ht.ContainsValue("Mechanical"));
            Console.ReadKey();
        }
    }
}
