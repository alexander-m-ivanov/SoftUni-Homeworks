using System;

class SumOf3Numbers
{
    static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string c = Console.ReadLine();

        double sum1 = double.Parse(a);
        double sum2 = double.Parse(b);
        double sum3 = double.Parse(c);

        Console.WriteLine(sum1 + sum2 + sum3);
    }
}
