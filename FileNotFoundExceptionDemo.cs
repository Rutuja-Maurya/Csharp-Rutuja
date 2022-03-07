using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exceptionhandling
{
    class FileNotFoundExceptionDemo
    {
        static void Main(string[] args)
        {
            try
            {
                File.OpenRead("InvalidFile");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}
