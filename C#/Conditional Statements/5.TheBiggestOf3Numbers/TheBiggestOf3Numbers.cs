using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        bool isATheBiggest = (a >= b) && (a >= c);
        bool isBTheBiggest = (b >= a) && (b >= c);
        bool isCTheBiggest = (c >= a) && (c >= b);

        if (isATheBiggest)
        {
            Console.WriteLine(a);
        }
        else if (isBTheBiggest)
        {
            Console.WriteLine(b);
        }
        else if (isCTheBiggest)
        {
            Console.WriteLine(c);
        }
    }
}