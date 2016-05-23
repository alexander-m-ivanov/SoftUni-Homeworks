using System;

namespace _3.ExactSumOfRealNumbers
{
    class ExactSumOfRealNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal total = 0;

            for (int i = 0; i < n; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                total += num;
            }

            Console.WriteLine(total);
        }
    }
}
