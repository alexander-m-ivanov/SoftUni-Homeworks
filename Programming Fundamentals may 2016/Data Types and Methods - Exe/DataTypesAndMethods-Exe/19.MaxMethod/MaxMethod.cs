using System;

namespace _19.MaxMethod
{
    class MaxMethod
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int firstCompare = GetMAx(a, b);
            int secondCompare = GetMAx(c, b);
            int thirdCompare = GetMAx(firstCompare, secondCompare);

            Console.WriteLine(thirdCompare);
        }
        public static int GetMAx(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else if (a == b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
