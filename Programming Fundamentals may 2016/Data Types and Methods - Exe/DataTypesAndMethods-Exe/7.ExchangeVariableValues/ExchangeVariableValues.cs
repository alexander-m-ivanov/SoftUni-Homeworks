using System;

namespace _7.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int e = 0;
            Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);

            e = a;
            a = b;
            b = e;
            Console.WriteLine("After:\na = {0}\nb = {1}", a, b);
        }
    }
}
