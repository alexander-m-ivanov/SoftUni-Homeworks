using System;

namespace _5.BooleanVariable
{
    class BooleanVariable
    {
        static void Main()
        {
            string value = Console.ReadLine();

            bool isItTrue = value == "True";

            if (isItTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
