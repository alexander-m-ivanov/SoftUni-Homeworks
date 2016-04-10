using System;

class ThirdDigitIs7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int thirdDigit = n / 100;
        int divisibleBy7 = thirdDigit % 10;

        if (divisibleBy7 == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}