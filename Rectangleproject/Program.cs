using System;

namespace Rectangleproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of the rectangle?");
            string length = Console.ReadLine();
            double L = double.Parse(length);
            Console.WriteLine("What is the width of the rectangle?");
            string width = Console.ReadLine();
            double W = double.Parse(width);
            double area = L * W;
            double parameter = (L * 2) + (W * 2);
            Console.WriteLine("The area of the rectangle is " + area + " and the parameter is " + parameter + ".");
            Console.WriteLine("The program has ended");
        }
    }
}
