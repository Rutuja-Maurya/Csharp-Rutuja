using System;

namespace InterfaceDemo
{
    public interface IPolygon
    {
        void calculateArea();
    }
    // implements interface
    public class Rectangle : IPolygon
    {
        //implementation of IPoygon interface
        public void calculateArea()
        {
            int len = 30;
            int br = 90;
            int area = len * br;
            Console.WriteLine("Area of Rectangle:" + area);
        }
    }
    public class Square : IPolygon
    {
        //implementation of IPoygon interface
        public void calculateArea()
        {
            int len = 30;
            int area = len * len;
            Console.WriteLine("Area of Square:" + area);
        }
    }
    class Interface
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.calculateArea();

            Square sq = new Square();
            sq.calculateArea();
        }
    }
}


        
