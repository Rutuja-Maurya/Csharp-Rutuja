using System;
public class InvalidAgeException : Exception
{
    public InvalidAgeException(String message)
        : base(message)
    {

    }
}
public class UserDefinedExceptionDemo
{
    static void validate(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Age must be greater than 18");
        }
    }
    public static void Main(string[] args)
    {
        try
        {
            validate(10);
        }
        catch (InvalidAgeException e) { Console.WriteLine(e); }
        Console.WriteLine("Rest of the code");
    }
}