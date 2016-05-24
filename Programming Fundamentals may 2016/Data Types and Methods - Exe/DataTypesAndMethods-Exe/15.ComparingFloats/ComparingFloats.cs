using System;

namespace _15.ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double result = Math.Abs(a - b);
            
            bool isItBigOrEqToEPS = result >= eps;

            if (isItBigOrEqToEPS)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
