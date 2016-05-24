using System;

namespace _4.VariabHexadecFormat
{
    class VariabHexadecFormat
    {
        static void Main()
        {
            string value = Console.ReadLine();

            int decRepres = Convert.ToInt32(value, 16);

            Console.WriteLine(decRepres);
        }
    }
}
