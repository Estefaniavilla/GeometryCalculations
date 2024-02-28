using GeometryCalculations;
using System;

namespace CalculoPerimetroTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle myTriangle = new Triangle();


            Console.Write("Enter the length of the first side: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of the second side: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of the third side: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            double perimeter = myTriangle.calculateperimeter(side1, side2, side3);

            Console.WriteLine($"The perimeter of the triangle is: {perimeter}");
        }
    }
}