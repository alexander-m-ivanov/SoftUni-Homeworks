using System;

namespace _6.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string hello = Console.ReadLine();
            string world = Console.ReadLine();
            object concatenation = hello + " " + world;
            string initObject = (string)concatenation;
            Console.WriteLine(initObject);
        }
    }
}
