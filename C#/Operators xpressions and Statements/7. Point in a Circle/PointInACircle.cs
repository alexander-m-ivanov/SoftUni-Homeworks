using System;

class PointInACircle
{
    static void Main()
    {
        //formula of a circle with center at points x and y 0 and radius 2 or K({0, 0}, 2):
        //  x^2 + y^2 = r^2
        double circleRadius = Math.Pow(2,2);
        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());
        double radiusOfInputXY = Math.Pow(pointX, 2) + Math.Pow(pointY, 2);
        bool isXYInCircle = radiusOfInputXY < circleRadius;

        if (isXYInCircle)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
