using System;
using System.Text;

namespace Exceptionhandling3
{
    class OutOfmemoryExceptionDemo
    {
        static void Main(string[] args)
        {
            try
            {
                string StudentName = "Rutuja";
                string StudentSubject = "Science";
                StringBuilder sBuilder = new StringBuilder(StudentName.Length, StudentName.Length);
                // Append initial value
                sBuilder.Append(StudentName);
                sBuilder.Insert(value: StudentSubject, index: StudentName.Length - 1, count: 1);
            }
            catch (System.OutOfMemoryException e)
            {
                Console.WriteLine("Error:");
                Console.WriteLine(e);
            }
        }
    }
}
