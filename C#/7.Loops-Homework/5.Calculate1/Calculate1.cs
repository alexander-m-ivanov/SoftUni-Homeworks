using System;

class Calculate1
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        double factorial = 1;
        double xCalc = 1;
        double result = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            xCalc *= x;
            result += factorial / xCalc;
        }

        Console.WriteLine("{0:F05}", result);
    }
}