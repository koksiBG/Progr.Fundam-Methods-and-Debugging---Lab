using System;

namespace Calculate_Triangle_Area
{
    class Calculate_Triangle_Area
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(width, height);
            Console.WriteLine(area);
        }

        static double GetTriangleArea(double width, double height)
        {
            double triangleArea = width * height / 2;
            return triangleArea;
        }
    }
}