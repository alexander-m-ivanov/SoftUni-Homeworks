using System;

class PointinCircleOutsideOfARectangle
{
    static void Main()
    {
        //formula of a circle with center at points x and y 0 and radius 2 or K({0, 0}, 2):
        //  x^2 + y^2 = r^2
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double xInCircleEquation = Math.Pow(x - 1, 2);
        double yInCircleEquation = Math.Pow(y - 1, 2);
        double circleRadius = Math.Pow(1.5, 2);

        bool isPointXYInCircle = xInCircleEquation + yInCircleEquation <= circleRadius;
        bool isXYPointOutOfRectangle = (-1 > x) || (x > 5) || (-1 > y) || (y > 1);

        if (isPointXYInCircle && isXYPointOutOfRectangle)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}