using System;

namespace _14.IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string hex = Convert.ToString(n, 16);
            string binary = Convert.ToString(n, 2);

            Console.WriteLine(hex.ToUpper());
            Console.WriteLine(binary);
        }
    }
}
