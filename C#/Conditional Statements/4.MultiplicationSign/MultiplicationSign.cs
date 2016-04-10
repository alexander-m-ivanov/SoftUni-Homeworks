using System;

class MultiplicationSign
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        bool isPositiveCase1 = (a > 0) && (b > 0) && (c > 0);
        bool isPositiveCase2 = (a < 0) && (b < 0) && (c > 0);
        bool isPositiveCase3 = (a < 0) && (b > 0) && (c < 0);
        bool isPositiveCase4 = (a > 0) && (b < 0) && (c < 0);

        bool isNegativeCase1 = (a < 0) && (b > 0) && (c > 0);
        bool isNegativeCase2 = (a > 0) && (b < 0) && (c > 0);
        bool isNegativeCase3 = (a > 0) && (b > 0) && (c < 0);
        bool isNegativeCase4 = (a < 0) && (b < 0) && (c < 0);

        if (isPositiveCase1 || isPositiveCase2 || isPositiveCase3 || isPositiveCase4)
        {
            Console.WriteLine("+");
        }
        else if (isNegativeCase1 || isNegativeCase2 || isNegativeCase3 || isNegativeCase4)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}