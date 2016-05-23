using System;

namespace _2.Circle_Area
{
    class Circle_Area
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f12}", Math.PI * r * r);
        }
    }
}
