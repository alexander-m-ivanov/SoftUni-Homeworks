using System;

class ComparingFloats
{
    static void Main()
    {
        double num1;
        double num2;
        Console.Write("Please write the 1st number: ");
        num1 = double.Parse(Console.ReadLine());
        Console.Write("Please write the 2nd number: ");
        num2 = double.Parse(Console.ReadLine());
        if (Math.Abs(num1 - num2) < 0.000001)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}