using System;

namespace _16.PrintPartOfASCII
{
    class PrintPartOfASCII
    {
        static void Main()
        {
            byte start = byte.Parse(Console.ReadLine());
            byte end = byte.Parse(Console.ReadLine());

            for (byte i = start; i <= end; i++)
            {
                char toPrint = (char)i;

                if (i < end)
                {
                    Console.Write(toPrint + " ");
                }
                else
                {
                    Console.WriteLine(toPrint);
                }
            }
        }
    }
}
