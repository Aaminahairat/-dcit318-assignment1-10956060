using System;

namespace TriangleTypeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side 2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side 3: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            string triangleType;
            if (side1 == side2 && side2 == side3)
            {
                triangleType = "Equilateral";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                triangleType = "Isosceles";
            }
            else
            {
                triangleType = "Scalene";
            }

            Console.WriteLine($"The triangle is: {triangleType}");
        }
    }
}
