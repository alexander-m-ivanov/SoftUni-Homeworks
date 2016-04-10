using System;

class FourDigitNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int d = n % 10;

        int secondDigit = n / 10;
        int c = secondDigit % 10;

        int thirdDigit = n / 100;
        int b = thirdDigit % 10;

        int fourthDigit = n / 1000;
        int a = fourthDigit % 10;

        Console.WriteLine();

        Console.WriteLine("Sum: {0}", a + b + c + d);
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
}