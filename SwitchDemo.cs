using System;

public class SwitchDemo
{
    public static void Main(String[] args)
    {
        int number = 50;
        switch (number)
        {
            case 10:
                Console.WriteLine("case 10");
                break;
            case 20:
                Console.WriteLine("case 20");
                break;
            case 30:
                Console.WriteLine("case 30");
                break;
            default:
                Console.WriteLine("No matches");
                break;
        }
    }
}