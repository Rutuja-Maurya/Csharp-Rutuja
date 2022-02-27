using System;

namespace Overloading
{
    public class Area
    {
        //adding double value
        public double CalculateArea(double sd)
        {
            double CalculateArea = sd * sd;
            return CalculateArea;
        }
        //adding two double values
        public double CalculateArea(double len, double br)
        {
            double CalculateArea = len * br;
            return CalculateArea;
        }
    }
    //Main method    
    class OverloadingDemo
    {
        static void Main(string[] args)
        {
            //creating object
            Area ar = new Area();
            double length = 3.3;
            double breadth = 4.9;
            double rect = ar.CalculateArea(length,  breadth);  
            Console.WriteLine("Area of rectangle" + rect);

            double side = 3.3;
            double square = ar.CalculateArea(side);
            Console.WriteLine("Area of square" + square);

        }
    }
}
