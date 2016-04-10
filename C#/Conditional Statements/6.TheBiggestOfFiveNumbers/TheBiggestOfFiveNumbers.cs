using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d= double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        bool isATheBiggest = (a >= b) && (a >= c) && (a >= d) && (a >= e);
        bool isBTheBiggest = (b >= a) && (b >= c) && (b >= d) && (b >= e);
        bool isCTheBiggest = (c >= b) && (c >= a) && (c >= d) && (c >= e);
        bool isDTheBiggest = (d >= b) && (d >= c) && (d >= a) && (d >= e);
        bool isETheBiggest = (e >= b) && (e >= c) && (e >= d) && (e >= a);

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
        else if (isDTheBiggest)
        {
            Console.WriteLine(d);
        }
        else if (isETheBiggest)
        {
            Console.WriteLine(e);
        }
    }
}