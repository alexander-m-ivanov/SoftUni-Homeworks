using System;

class DivideBy7And5
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int divideBy3 = n % 5;
        int divideBy7 = n % 7;

        bool isDivisible = (divideBy3 == 0) && (divideBy7 == 0) && (n != 0);

        if (isDivisible)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}