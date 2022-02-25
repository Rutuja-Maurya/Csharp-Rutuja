using System;
namespace Pointerprogram
{

    class PointerType
    {

        static void Main()
        {
            unsafe
            {

                int n = 10;

                int* p = &n;
                Console.WriteLine("Value :{0}", n);
                Console.WriteLine("Address :{0}", (int)p);
            }
        }
    }
}


